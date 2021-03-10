Imports System.Data.OleDb
Public Class DateService
    Private date_ser As String
    Private lieu As String
    Private remarque As String
    Private idService As String


    Public Sub New(date_ser As String, lieu As String, remarque As String, id_service As String)
        Me.date_ser = date_ser
        Me.lieu = lieu
        Me.remarque = remarque
        Me.idService = id_service 
    End Sub

    Public Property getSetDate_ser() As Integer
        Get
            Return date_ser
        End Get
        Set(ByVal date_ser As Integer)
            Me.date_ser = date_ser
        End Set
    End Property

    Public Property getSetLieu() As String
        Get
            Return Me.lieu
        End Get
        Set(ByVal l As String)
            Me.lieu = l
        End Set
    End Property

    Public Property getSetRemarque() As String
        Get
            Return remarque
        End Get
        Set(ByVal re As String)
            Me.remarque = re
        End Set
    End Property

    Public Property getSetId_service() As String
        Get
            Return idService
        End Get
        Set(ByVal i As String)
            Me.idService = i
        End Set
    End Property
    Public Function insert() As Boolean
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Try
            Dim cmdArticles As New OleDbCommand
            cmdArticles.CommandText = "INSERT INTO `date_service`(`date_s`, `lieu`, `remarque`, `id_service`) 
                                        VALUES ('" + date_ser + "','" + lieu + "','" + remarque + "','" + idService + "')"
            cmdArticles.Connection = cn
            cmdArticles.ExecuteNonQuery()
            cn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(" DATE  ERROR : " + ex.ToString)
            Return False
        End Try
    End Function

    Public Function delete(data As String) As Boolean
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Try
            Dim cmdArticles As New OleDbCommand
            cmdArticles.CommandText = "DELETE FROM `date_service` WHERE id_service = " + data
            cmdArticles.Connection = cn
            cmdArticles.ExecuteNonQuery()
            cn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
