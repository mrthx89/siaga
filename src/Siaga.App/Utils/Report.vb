Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.UI

Namespace Utils
    Public Class Report
        Public Shared Function ViewReport(ByVal ReportName As String,
                                          ByVal DS As DataSet,
                                          ByVal Parameters As Dictionary(Of String, Object),
                                          ByVal CalculateFields As Dictionary(Of String, Object),
                                          ByVal FilterString As String,
                                          ByVal Action As [Enum].ActionPrint) As XtraReport
            Dim XtraReport As DevExpress.XtraReports.UI.XtraReport = Nothing
            Using dlg As New WaitDialogForm("Sedang diproses...", "Mohon Tunggu Sebentar.")
                ' Create a new Security Permission which denies any File IO operations.
                Dim permission As New ScriptSecurityPermission("System.Security.Permissions.FileIOPermission")
                Dim FileName As String = System.IO.Path.Combine(Environment.CurrentDirectory, "Report", ReportName)
                Try
                    dlg.TopMost = False
                    dlg.Show()

                    If (Not System.IO.File.Exists(FileName)) Then
                        If XtraMessageBox.Show("File tidak ditemukan, lakukan mode design ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            Action = [Enum].ActionPrint.Design
                        Else
                            Exit Try
                        End If
                    End If

                    XtraReport = New DevExpress.XtraReports.UI.XtraReport
                    If System.IO.File.Exists(FileName) Then 'Load Layouts
                        XtraReport.LoadLayout(FileName)
                    End If

                    'Set Datasource
                    If Not DS Is Nothing Then
                        If TypeOf DS Is DataSet Then
                            If Not System.IO.Directory.Exists(System.IO.Path.Combine(Environment.CurrentDirectory, "Report", "XSD")) Then
                                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(Environment.CurrentDirectory, "Report", "XSD"))
                            End If
                            DS.WriteXmlSchema(System.IO.Path.Combine(Environment.CurrentDirectory, "Report", "XSD", ReportName.Replace(".repx", ".xsd")))
                        End If
                        XtraReport.DataSource = DS
                    End If
                    If TypeOf DS Is DataSet Then
                        XtraReport.DataSourceSchema = System.IO.Path.Combine(Environment.CurrentDirectory, "Report", "XSD", ReportName.Replace(".repx", ".xsd"))
                    End If

                    'Calculate Fields
                    For Each cal In XtraReport.CalculatedFields
                        For Each calculate In CalculateFields
                            If (calculate.Key.ToUpper() = cal.Name.ToUpper()) Then
                                If (TypeOf calculate.Value Is Integer OrElse
                                        TypeOf calculate.Value Is Int16 OrElse
                                        TypeOf calculate.Value Is Int32 OrElse
                                        TypeOf calculate.Value Is Int64 OrElse
                                        TypeOf calculate.Value Is Long) Then
                                    cal.Expression = CLng(calculate.Value).ToString()
                                ElseIf (TypeOf calculate.Value Is DateTime OrElse
                                        TypeOf calculate.Value Is Date) Then
                                    cal.Expression = CDate(calculate.Value).ToString("#yyyy-MM-dd#")
                                ElseIf (TypeOf calculate.Value Is Double OrElse
                                        TypeOf calculate.Value Is Decimal) Then
                                    cal.Expression = CDbl(calculate.Value).ToString().Replace(",", ".")
                                Else
                                    cal.Expression = calculate.Value.ToString()
                                End If

                                Exit For
                            End If
                        Next
                        Application.DoEvents()
                    Next

                    'Parameters
                    For Each parameter In Parameters
                        If (TypeOf parameter.Value Is Integer OrElse
                                TypeOf parameter.Value Is Int16 OrElse
                                TypeOf parameter.Value Is Int32 OrElse
                                TypeOf parameter.Value Is Int64 OrElse
                                TypeOf parameter.Value Is Long) AndAlso XtraReport.Parameters(parameter.Key) IsNot Nothing Then
                            XtraReport.Parameters(parameter.Key).Value = CLng(parameter.Value).ToString()
                        ElseIf (TypeOf parameter.Value Is DateTime OrElse
                                TypeOf parameter.Value Is Date) AndAlso XtraReport.Parameters(parameter.Key) IsNot Nothing Then
                            XtraReport.Parameters(parameter.Key).Value = CDate(parameter.Value).ToString("#yyyy-MM-dd#")
                        ElseIf (TypeOf parameter.Value Is Double OrElse
                                TypeOf parameter.Value Is Decimal) AndAlso XtraReport.Parameters(parameter.Key) IsNot Nothing Then
                            XtraReport.Parameters(parameter.Key).Value = CDbl(parameter.Value).ToString().Replace(",", ".")
                        ElseIf (XtraReport.Parameters(parameter.Key) IsNot Nothing) Then
                            XtraReport.Parameters(parameter.Key).Value = parameter.Value.ToString()
                        End If
                    Next

                    'Scripting
                    XtraReport.ScriptLanguage = ScriptLanguage.VisualBasic

                    ' Add this permission to a report's list of permissions for scripts.
                    permission.Deny = True
                    XtraReport.ScriptSecurityPermissions.Add(permission)
                    For i As Integer = 0 To XtraReport.ScriptSecurityPermissions.Count - 1
                        XtraReport.ScriptSecurityPermissions.Item(i).Deny = True
                    Next

                    'Filter String
                    If FilterString <> "" Then
                        XtraReport.FilterString = FilterString
                    End If

                    'Option
                    XtraReport.Name = Replace(ReportName.ToUpper, ".REPX", "")
                    XtraReport.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, DevExpress.XtraPrinting.CommandVisibility.None)
                    XtraReport.DisplayName = ReportName

                    'Action
                    If Action = [Enum].ActionPrint.Design Then
                        dlg.SetCaption("Membuka Designer Report ...")
                        Application.DoEvents()
                        dlg.Close()
                        XtraReport.ShowRibbonDesignerDialog()
                    ElseIf Action = [Enum].ActionPrint.View Then
                        XtraReport.CreateDocument()
                    ElseIf Action = [Enum].ActionPrint.ViewDialog Then
                        Application.DoEvents()
                        dlg.Close()
                        XtraReport.ShowPreviewDialog()
                    ElseIf Action = [Enum].ActionPrint.PrintDialog Then
                        Application.DoEvents()
                        dlg.Close()
                        XtraReport.PrintDialog()
                    Else
                        Application.DoEvents()
                        dlg.Close()
                        XtraMessageBox.Show("Report tidak dapat diload karena tidak ada action", "Reporting", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    Dim trace = New System.Diagnostics.StackTrace(ex, True)
                    Dim line As String = Strings.Right(trace.ToString, 5)
                    Dim nombreMetodo As String = ""

                    For Each sf As StackFrame In trace.GetFrames
                        nombreMetodo = sf.GetMethod().Name & " Line " & sf.GetFileLineNumber
                    Next

                    dlg.Dispose()
                    XtraMessageBox.Show("Info Kesalahan : " & ex.Message & vbCrLf & nombreMetodo, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    dlg.Dispose()

                    If Not DS Is Nothing AndAlso Action = [Enum].ActionPrint.PrintDialog Then
                        DS.Dispose()
                    End If

                    If Not XtraReport Is Nothing AndAlso Action = [Enum].ActionPrint.PrintDialog Then
                        XtraReport.Dispose()
                    End If
                End Try
            End Using
            Return XtraReport
        End Function
    End Class
End Namespace
