Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class HistoryKeAutoIncreament
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropPrimaryKey("historydetailasset")
            AddColumn("historydetailasset", "noid", Function(c) c.Long(nullable:=False, identity:=True))
            AddPrimaryKey("historydetailasset", "noid")
        End Sub
        
        Public Overrides Sub Down()
            DropPrimaryKey("historydetailasset")
            DropColumn("historydetailasset", "noid")
            AddPrimaryKey("historydetailasset", "id")
        End Sub
    End Class
End Namespace
