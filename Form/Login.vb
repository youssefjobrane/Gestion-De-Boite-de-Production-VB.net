Imports System.Data.OleDb
Public Class Login


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        GunaLabel1.Hide()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub RibbonForm1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Show()
        GunaButton2.Select()
    End Sub


    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        GunaButton2.Focus()

        Dim cn As OleDbConnection
        cn = New OleDbConnection
        Dim chemin As String = "E:\training\fluuter\OneClick Prod\login\login\DataBase\Gestion_De_Boite_De_Production.mdb"
        cn.ConnectionString = "provider=Microsoft.JET.OLEDB.4.0;data source=" & chemin
        cn.Open()

        Try
            Dim i As Integer = 0
            Dim cmdArticles As New OleDbCommand
            cmdArticles.CommandText = "SELECT * FROM compte WHERE cin = " + GunaTextBox1.Text
            cmdArticles.Connection = cn


            Dim drArticles As OleDbDataReader = cmdArticles.ExecuteReader

            While drArticles.Read
                If (GunaTextBox2.Text = drArticles.GetValue(6)) Then


                    Dim c1 As Compte = New Compte(drArticles.GetValue(0), drArticles.GetValue(1), drArticles.GetValue(2), drArticles.GetValue(3), drArticles.GetValue(4), drArticles.GetValue(5), drArticles.GetValue(6))
                    If (c1.getSetType = "Admin") Then
                        Dim d As Dash = New Dash(c1)
                        d.Show()
                        Me.Hide()
                    Else
                        Dim d As Dash = New Dash(c1)
                        d.Show()
                        Me.Hide()
                    End If




                Else
                        GunaLabel1.Show()
                End If
                i = i + 1
            End While
            If (i = 0) Then
                GunaLabel1.Show()
            End If
            cn = Nothing
        Catch ex As Exception
            'MessageBox.Show(ex, "E")
            GunaLabel1.Show()
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim unused = Process.Start("https://www.facebook.com/j00ker.96")
    End Sub


    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Me.Close()
    End Sub



    Private Sub GunaTextBox2_GotFocus(sender As Object, e As EventArgs) Handles GunaTextBox2.GotFocus
        If (GunaTextBox2.Text = "pass") Then
            GunaTextBox2.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox1_Leave(sender As Object, e As EventArgs) Handles GunaTextBox1.Leave
        If (GunaTextBox1.Text = "") Then
            GunaTextBox1.Text = "C I N"
        End If
    End Sub

    Private Sub GunaTextBox1_Enter(sender As Object, e As EventArgs) Handles GunaTextBox1.Enter
        If (GunaTextBox1.Text = "C I N") Then
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox2_Leave(sender As Object, e As EventArgs) Handles GunaTextBox2.Leave
        If (GunaTextBox2.Text = "") Then
            GunaTextBox2.Text = "pass"
        End If
    End Sub

    Private Sub GunaTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox1.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
End Class
