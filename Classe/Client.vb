Imports System.Data.OleDb
Public Class Client


    Private cin As String
    Private nom As String
    Private prenom As String
    Private num_tel As String
    Private adresse As String
    Private mail As String
    Private dette As String

    Public Sub New(cin As String, nom As String, prenom As String, num_tel As String, adresse As String, mail As String, dette As String)
        Me.cin = cin
        Me.nom = nom
        Me.prenom = prenom
        Me.num_tel = num_tel
        Me.adresse = adresse
        Me.mail = mail
        Me.dette = dette
    End Sub

    Public Property getSetCin() As Integer
        Get
            Return cin
        End Get
        Set(ByVal cin As Integer)
            Me.cin = cin
        End Set
    End Property

    Public Property getSetNom() As String
        Get
            Return Me.nom
        End Get
        Set(ByVal nom As String)
            Me.nom = nom
        End Set
    End Property

    Public Property getSetPrenom() As String
        Get
            Return prenom
        End Get
        Set(ByVal prenom As String)
            Me.prenom = prenom
        End Set
    End Property

    Public Property getSetTel() As String
        Get
            Return num_tel
        End Get
        Set(ByVal num_tel As String)
            Me.num_tel = num_tel
        End Set
    End Property

    Public Property getSetAdresse() As String
        Get
            Return adresse
        End Get
        Set(ByVal ad As String)
            Me.adresse = ad
        End Set
    End Property
    Public Property getSetMail() As String
        Get
            Return mail
        End Get
        Set(ByVal mail As String)
            Me.mail = mail
        End Set
    End Property

    Public Property getSetDette() As String
        Get
            Return dette
        End Get
        Set(ByVal d As String)
            Me.dette = d
        End Set
    End Property



    Public Function insert() As Boolean
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Try
            Dim cmdArticles As New OleDbCommand
            cmdArticles.CommandText = "INSERT INTO `client`(`cin`, `nom`, `prenom`, `num_tel`, `e_mail`, `adresse`,`dette`) VALUES ('" + Me.cin + "','" + Me.nom + "','" + Me.prenom + "','" + Me.num_tel + "','" + Me.mail + "','" + Me.adresse + "','" + Me.dette + "')"
            cmdArticles.Connection = cn
            cmdArticles.ExecuteNonQuery()
            'cn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function delete(data As String) As Boolean
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Try
            Dim cmdArticles As New OleDbCommand
            cmdArticles.CommandText = ""
            cmdArticles.Connection = cn
            cmdArticles.ExecuteNonQuery()
            cn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function update() As Boolean
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Try
            Dim cmdArticles As New OleDbCommand
            cmdArticles.CommandText = "UPDATE `client` SET  `nom`='" + nom + "',`prenom`='" + prenom + "',`num_tel`='" + num_tel + "',`e_mail`='" + Me.mail + "',`adresse`='" + Me.adresse + "' WHERE `cin`=" + Me.cin + ""
            cmdArticles.Connection = cn
            cmdArticles.ExecuteNonQuery()
            cn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function updateDette(det As Integer) As Boolean
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Try
            Dim cmdArticles As New OleDbCommand
            cmdArticles.CommandText = "UPDATE `client` SET `dette` = `dette` + " + det.ToString + " where cin = " + cin
            cmdArticles.Connection = cn
            cmdArticles.ExecuteNonQuery()
            ' cn.Close()
            Return True
        Catch ex As Exception
            'sMessageBox.Show("********************************************" + ex.ToString)
            Return False
        End Try
    End Function

    Public Function payeDette(det As Integer) As Boolean
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Try
            Dim cmdArticles As New OleDbCommand
            cmdArticles.CommandText = "UPDATE `client` SET `dette` = `dette` - " + det.ToString + " where cin = " + cin
            cmdArticles.Connection = cn
            cmdArticles.ExecuteNonQuery()
            ' cn.Close()
            Return True
        Catch ex As Exception
            'sMessageBox.Show("********************************************" + ex.ToString)
            Return False
        End Try
    End Function
End Class
