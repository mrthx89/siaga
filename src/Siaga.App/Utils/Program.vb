Imports System.Data.Entity.Migrations
Imports System.Globalization
Imports System.Threading
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.UserSkins
Imports Newtonsoft.Json
Imports Serilog
Imports Siaga.App.Data.Entity

Public Class Program
    Public Shared AppConfig As New Model.AppConfig With {.Theme = "Office 2016 Colorful", .DBConfig = New Model.DBConfig With {.Server = "127.0.0.1", .UserID = "root", .Password = "", .Timeout = 60}}
    Public Shared FolderApp As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Siaga.App")
    Public Shared UserLogin As Pengguna

    <STAThread()>
    Public Shared Sub Main()
        Try
            CreateFolder()

            ' Konfigurasi logger: log ke file dengan rolling harian
            Log.Logger = New LoggerConfiguration() _
            .MinimumLevel.Debug() _
            .WriteTo.Console() _
            .WriteTo.File(IO.Path.Combine(FolderApp, "Logs", "log-.txt"),
                          rollingInterval:=RollingInterval.Day,
                          outputTemplate:="{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] {Message}{NewLine}{Exception}") _
            .CreateLogger()
            Log.Information("Application Starting ...")

            DevExpress.XtraEditors.WindowsFormsSettings.LoadApplicationSettings()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            ' Change current culture
            Dim culture As CultureInfo
            culture = CultureInfo.CreateSpecificCulture("en-US")
            Thread.CurrentThread.CurrentCulture = culture
            Thread.CurrentThread.CurrentUICulture = culture

            BonusSkins.Register()
            SkinManager.EnableFormSkins()

            OpenConfig()

            Dim migrator = New DbMigrator(New Migrations.Configuration())
            migrator.Update()

            Dim db = New Data.ApplicationDbContext()
            Migrations.Configuration.SeedData(db)
            db.SaveChanges()

            Application.Run(New frmMain())
        Catch ex As Exception
            Log.Error(ex, "Error : " & ex.Message)
        Finally
            Log.CloseAndFlush()
        End Try
    End Sub

    Private Shared Sub CreateFolder()
        If Not IO.Directory.Exists(FolderApp) Then IO.Directory.CreateDirectory(FolderApp)
        If Not IO.Directory.Exists(IO.Path.Combine(FolderApp, "Logs")) Then IO.Directory.CreateDirectory(IO.Path.Combine(FolderApp, "Logs"))
        If Not IO.Directory.Exists(IO.Path.Combine(FolderApp, "System")) Then IO.Directory.CreateDirectory(IO.Path.Combine(FolderApp, "System"))
        If Not IO.Directory.Exists(IO.Path.Combine(FolderApp, "System", "Layouts")) Then IO.Directory.CreateDirectory(IO.Path.Combine(FolderApp, "System", "Layouts"))
        If Not IO.Directory.Exists(IO.Path.Combine(FolderApp, "Report")) Then IO.Directory.CreateDirectory(IO.Path.Combine(FolderApp, "Report"))
    End Sub

    Public Shared Sub OpenConfig()
        If (IO.File.Exists(IO.Path.Combine(FolderApp, "System", "AppConfig.json"))) Then
            AppConfig = JsonConvert.DeserializeObject(Of Model.AppConfig)(IO.File.ReadAllText(IO.Path.Combine(FolderApp, "System", "AppConfig.json")))
        End If

        If (AppConfig Is Nothing OrElse
            AppConfig.DBConfig Is Nothing OrElse
            String.IsNullOrEmpty(AppConfig.DBConfig.Server) OrElse
            String.IsNullOrWhiteSpace(AppConfig.DBConfig.Server)) Then
            'Create New Config
            AppConfig = New Model.AppConfig With {.Theme = "Office 2016 Colorful", .DBConfig = New Model.DBConfig With {.Server = "127.0.0.1", .UserID = "root", .Password = "", .Timeout = 60}}
        End If

        SetSkinName(AppConfig.Theme)
    End Sub

    Public Shared Sub SaveConfig(AppConfig As Model.AppConfig)
        Using sw As New IO.StreamWriter(IO.Path.Combine(FolderApp, "System", "AppConfig.json"), False)
            Try
                sw.AutoFlush = True
                sw.Write(JsonConvert.SerializeObject(AppConfig))
                sw.Flush()
            Catch ex As Exception
                Log.Error(ex, "Error : " & ex.Message)
            Finally
                sw.Dispose()
            End Try
        End Using
    End Sub


    Public Shared Sub SetSkinName(SkinName As String)
        SkinManager.EnableFormSkins()
        UserLookAndFeel.Default.SkinName = SkinName
        UserLookAndFeel.Default.SetSkinStyle(SkinName)
        Application.DoEvents()
    End Sub
End Class
