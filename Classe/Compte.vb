Imports System.Data.OleDb
Public Class Compte


    Private cin As String
    Private nom As String
    Private prenom As String
    Private num_tel As String
    Private sexe As String
    Private type_compte As String
    Private password As String

    Public Sub New(cin As String, nom As String, prenom As String, num_tel As String, sexe As String, type As String, pass As String)
        Me.cin = cin
        Me.nom = nom
        Me.prenom = prenom
        Me.num_tel = num_tel
        Me.sexe = sexe
        Me.type_compte = type
        Me.password = pass
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

    Public Property getSetSexe() As String
        Get
            Return sexe
        End Get
        Set(ByVal sexe As String)
            Me.sexe = sexe
        End Set
    End Property
    Public Property getSetType() As String
        Get
            Return type_compte
        End Get
        Set(ByVal type As String)
            Me.type_compte = type
        End Set
    End Property
    Public Property getSetPass() As String
        Get
            Return password
        End Get
        Set(ByVal pass As String)
            Me.password = pass
        End Set
    End Property


    Public Function insert() As Boolean
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Try
            Dim cmdArticles As New OleDbCommand
            cmdArticles.CommandText = "INSERT INTO `compte`( `cin`,`nom`, `prenom`, `num_tel`, `sexe`, `type`, `mot_de_passe`) VALUES ('" + cin + "','" + nom + "','" + prenom + "','" + num_tel + "','" + sexe + "','" + type_compte + "','" + password + "')"
            cmdArticles.Connection = cn
            cmdArticles.ExecuteNonQuery()
            cn.Close()
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
            cmdArticles.CommandText = "DELETE FROM `compte` WHERE cin = " + data
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
            cmdArticles.CommandText = "UPDATE `compte` SET  `nom`='" + nom + "',`prenom`='" + prenom + "',`num_tel`='" + num_tel + "',`sexe` = '" + sexe + "',`type`='" + type_compte + "',`mot_de_passe`='" + password + "' WHERE `cin`=" + Me.cin + ""
            cmdArticles.Connection = cn
            cmdArticles.ExecuteNonQuery()
            cn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
