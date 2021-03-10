Imports System.Data.OleDb
Public Class Service
    Private nom_service As String
    Private type As String
    Private tarif As String
    Private avance As String
    Private client As String

    Public Sub New(nom As String, type As String, tarif As String, avance As String, client As String)
        Me.nom_service = nom
        Me.type = type
        Me.tarif = tarif
        Me.avance = avance
        Me.client = client
    End Sub

    Public Property getSetNom_serv() As String
        Get
            Return nom_service
        End Get
        Set(ByVal n As String)
            Me.nom_service = n
        End Set
    End Property
    Public Property getSetType() As String
        Get
            Return type
        End Get
        Set(ByVal t As String)
            Me.type = t
        End Set
    End Property
    Public Property getSetTarif() As String
        Get
            Return tarif
        End Get
        Set(ByVal t As String)
            Me.tarif = t
        End Set
    End Property

    Public Property getSetAvance() As String
        Get
            Return avance
        End Get
        Set(ByVal a As String)
            Me.avance = a
        End Set
    End Property
    Public Property getSetClient() As String
        Get
            Return client
        End Get
        Set(ByVal c As String)
            Me.client = c
        End Set
    End Property

    Public Function insert(tab As Guna.UI.WinForms.GunaDataGridView, cl As Client) As Boolean
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        'AJOUTER CLIENT SI IL N EXISTE PAS SINON MISE A JOUR DETTE 
        Try
            Dim cmdArticles1 As New OleDbCommand
            cmdArticles1.CommandText = "Select * FROM `client` WHERE cin = " + Me.client
            cmdArticles1.Connection = cn

            Dim drArticles As OleDbDataReader = cmdArticles1.ExecuteReader
            Dim nbClient As Boolean = False
            While drArticles.Read
                nbClient = True
            End While
            If (nbClient = False) Then
                cl.insert()
            Else
                cl.updateDette(Integer.Parse(Me.tarif) - Integer.Parse(Me.avance))
            End If
        Catch ex As Exception
            MessageBox.Show(" erreur  AJOUTER CLIENT  ")
        End Try
        'INSERTION SERVICE 
        Try

            Dim cmdArticles2 As New OleDbCommand
            cmdArticles2.CommandText = "INSERT INTO `service`( `nom_service`, `type`, `tarif`, `avance`, `cin_client`) VALUES ('" + nom_service + "','" + type + "','" + tarif + "','" + avance + "','" + client + "')"
            cmdArticles2.Connection = cn
            cmdArticles2.ExecuteNonQuery()



        Catch ex As Exception
            MessageBox.Show("erreur  INSERTION SERVICE : " + ex.ToString)
            Return False
        End Try
        ' GET MAX ID6SERVICE DU BASE DE DONNéE pour le ajouter dans les date comme clé etrangère 
        Dim max As Integer
        Try

            Dim cmdArticles3 As New OleDbCommand
            cmdArticles3.CommandText = "SELECT MAX(`id`) FROM service "
            cmdArticles3.Connection = cn

            Dim drArticles As OleDbDataReader = cmdArticles3.ExecuteReader
            drArticles.Read()
            max = drArticles.GetValue(0)
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(" GET MAX  ERROR : " + ex.ToString)
            Return False
        End Try
        'INSERRER TOUT LES DATE DU SERVICE 
        Dim i As Integer = 0
        Dim date_s, lieu, remarque As String
        While (i < tab.Rows.Count)
            date_s = tab.Rows(i).Cells(0).Value
            lieu = tab.Rows(i).Cells(1).Value
            remarque = tab.Rows(i).Cells(2).Value
            Dim dat As DateService = New DateService(date_s, lieu, remarque, max)
            If Not (dat.insert()) Then
                Return False
            End If
            i = i + 1
        End While

        Return True
    End Function

    Public Function delete(data As String) As Boolean
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Try
            Dim cmdArticles As New OleDbCommand
            cmdArticles.CommandText = "DELETE FROM `service` WHERE id = " + data
            cmdArticles.Connection = cn
            cmdArticles.ExecuteNonQuery()
            cn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("           " + ex.ToString)
            Return False
        End Try

    End Function
End Class
