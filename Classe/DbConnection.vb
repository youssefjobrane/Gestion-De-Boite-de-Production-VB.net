Imports System.Data.OleDb
Public Class DbConnection
    Shared Function connect() As OleDbConnection
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        Dim chemin As String = "C:\Users\Ramez\Desktop\login\login\DataBase\Gestion_De_Boite_De_Production.mdb"
        cn.ConnectionString = "provider=Microsoft.JET.OLEDB.4.0;data source=" & chemin
        Return cn
    End Function
End Class
