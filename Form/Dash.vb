Imports System.Data.OleDb
Public Class Dash

    Dim com As Compte
    Dim pressed As String


    Public Sub New(c As Compte)
        pressed = "ac"
        com = c
        ' This call is required by the designer.
        InitializeComponent()
        Label2.Text = com.getSetNom



        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Dim cmdArticles As New OleDbCommand
        cmdArticles.CommandText = "SELECT * FROM date_service "
        cmdArticles.Connection = cn

        Dim drArticles As OleDbDataReader = cmdArticles.ExecuteReader

        drArticles.Read()
        GunaLabel22.Text = drArticles.GetValue(2)
        GunaLabel20.Text = " Remarque :   " + drArticles.GetValue(3)
        GunaLabel18.Text = drArticles.GetValue(1)

        cn.Close()
        cn = Nothing

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub affiche_compte(s As String)
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Dim cmdArticles As New OleDbCommand
        cmdArticles.CommandText = "SELECT * FROM compte " + s
        cmdArticles.Connection = cn

        Dim drArticles As OleDbDataReader = cmdArticles.ExecuteReader

        GunaDataGridView6.Rows.Clear()

        While drArticles.Read
            GunaDataGridView6.Rows.Add(New String() {drArticles.GetValue(1) + " " + drArticles.GetValue(2), drArticles.GetValue(0), drArticles.GetValue(3), drArticles.GetValue(4), drArticles.GetValue(5), drArticles.GetValue(6)})
        End While
        cn.Close()
        cn = Nothing
    End Sub

    Public Sub affiche_service_termine(s As String)
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()
        Try

            Dim cmdArticles As New OleDbCommand
            Dim d As DateTime = DateTime.Today

            cmdArticles.CommandText = "SELECT * FROM `service`  " + s
            cmdArticles.Connection = cn

            Dim drArticles As OleDbDataReader = cmdArticles.ExecuteReader


            GunaDataGridView3.Rows.Clear()
            While drArticles.Read
                Dim cmdArticles2 As New OleDbCommand
                cmdArticles2.CommandText = "SELECT * FROM `client` where   cin = " + drArticles.GetValue(5).ToString + " "
                cmdArticles2.Connection = cn

                Dim drArticles2 As OleDbDataReader = cmdArticles2.ExecuteReader

                Dim i As Integer = 0
                Dim b As Boolean = False

                Dim j As Integer = drArticles.GetInt32(0)
                Dim ss As String = Integer.Parse(j)
                While (i < GunaDataGridView1.Rows.Count And b = False)

                    If (GunaDataGridView1.Rows(i).Cells(0).Value.ToString.Equals(ss)) Then
                        b = True
                    End If

                    i = i + 1
                End While

                drArticles2.Read()
                If b = False Then
                    GunaDataGridView3.Rows.Add(New String() {drArticles.GetValue(0), drArticles.GetValue(1), drArticles.GetValue(2), drArticles2.GetValue(3), drArticles.GetValue(3)})
                End If

            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString + "  *****  non")

        End Try


        cn.Close()
        cn = Nothing
    End Sub

    Public Sub affiche_service_non_termine(s As String)
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()
        Try

            Dim cmdArticles As New OleDbCommand
            Dim d As DateTime = DateTime.Today

            cmdArticles.CommandText = "SELECT * FROM date_service where date_s > DATEVALUE('" + d.ToString + "')"
            cmdArticles.Connection = cn

            Dim drArticles As OleDbDataReader = cmdArticles.ExecuteReader


            GunaDataGridView1.Rows.Clear()
            While drArticles.Read
                Dim cmdArticles2 As New OleDbCommand
                cmdArticles2.CommandText = "SELECT * FROM `service` where   id = " + drArticles.GetValue(4).ToString + " " + s
                cmdArticles2.Connection = cn

                Dim drArticles2 As OleDbDataReader = cmdArticles2.ExecuteReader

                Dim i As Integer = 0
                Dim b As Boolean = False

                Dim j As Integer = drArticles.GetInt32(4)
                Dim ss As String = Integer.Parse(j)
                While (i < GunaDataGridView1.Rows.Count And b = False)

                    If (GunaDataGridView1.Rows(i).Cells(0).Value.ToString.Equals(ss)) Then
                        b = True
                    End If

                    i = i + 1
                End While


                While drArticles2.Read And b = False
                    GunaDataGridView1.Rows.Add(New String() {drArticles2.GetValue(0), drArticles2.GetValue(1), drArticles2.GetValue(2), "", drArticles2.GetValue(3)})
                End While

            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString + " *****  ")

        End Try


        cn.Close()
        cn = Nothing
    End Sub


    Public Sub affiche_client(s As String)
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Dim cmdArticles As New OleDbCommand
        cmdArticles.CommandText = "SELECT * FROM client " + s
        cmdArticles.Connection = cn

        Dim drArticles As OleDbDataReader = cmdArticles.ExecuteReader

        GunaDataGridView5.Rows.Clear()

        While drArticles.Read
            GunaDataGridView5.Rows.Add(New String() {drArticles.GetValue(1) + " " + drArticles.GetValue(2), drArticles.GetValue(0), drArticles.GetValue(3), drArticles.GetValue(5), drArticles.GetValue(4)})
        End While
        cn.Close()
        cn = Nothing
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        pressed = "ac"

        Home.Visible = True
        service.Visible = False
        Compte.Visible = False
        client.Visible = False
        Guna2Button2.BackColor = Color.White
        Guna2Button2.ForeColor = Color.FromArgb(34, 45, 49)
        Guna2Button3.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button5.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button4.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button3.ForeColor = Color.White
        Guna2Button5.ForeColor = Color.White
        Guna2Button4.ForeColor = Color.White


    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        pressed = "se"

        Home.Visible = False
        service.Visible = True
        Compte.Visible = False
        client.Visible = False
        Guna2Button3.BackColor = Color.White
        Guna2Button3.ForeColor = Color.FromArgb(34, 45, 49)
        Guna2Button2.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button5.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button4.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button2.ForeColor = Color.White
        Guna2Button5.ForeColor = Color.White
        Guna2Button4.ForeColor = Color.White

        affiche_service_non_termine("")
        affiche_service_termine("")
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        pressed = "co"

        Home.Visible = False
        service.Visible = False
        Compte.Visible = True
        client.Visible = False
        Guna2Button4.BackColor = Color.White
        Guna2Button4.ForeColor = Color.FromArgb(34, 45, 49)
        Guna2Button2.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button5.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button3.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button2.ForeColor = Color.White
        Guna2Button5.ForeColor = Color.White
        Guna2Button3.ForeColor = Color.White


        affiche_compte("")


    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        pressed = "cl"

        Home.Visible = False
        service.Visible = False
        Compte.Visible = False
        client.Visible = True
        Guna2Button5.BackColor = Color.White
        Guna2Button5.ForeColor = Color.FromArgb(34, 45, 49)
        Guna2Button2.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button3.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button4.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button2.ForeColor = Color.White
        Guna2Button3.ForeColor = Color.White
        Guna2Button4.ForeColor = Color.White

        affiche_client("")
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Login.Close()
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Dash_Load(sender As Object, e As EventArgs) Handles Me.Load
        'For i As Integer = 0 To 7
        '    GunaDataGridView1.Rows.Add(New String() {"22", "youssef", "shooting", "55243382", "560DT"})
        '    GunaDataGridView2.Rows.Add(New String() {"22", "16/01/2020", "jemmel", "only girl"})
        '    GunaDataGridView3.Rows.Add(New String() {"22", "youssef", "shooting", "55243382", "560DT"})
        '    GunaDataGridView4.Rows.Add(New String() {"22", "16/01/2020", "jemmel", "only girl"})
        'Next


        Home.Visible = True
        service.Visible = False
        Compte.Visible = False
        client.Visible = False
        Guna2Button2.BackColor = Color.White
        Guna2Button2.ForeColor = Color.FromArgb(34, 45, 49)
        Guna2Button3.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button5.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button4.BackColor = Color.FromArgb(34, 45, 49)
        Guna2Button3.ForeColor = Color.White
        Guna2Button5.ForeColor = Color.White
        Guna2Button4.ForeColor = Color.White
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Dim c As AjouterCompte = New AjouterCompte(Me)
        Me.Enabled = False
        c.Show()

    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        Dim s As AjouterService = New AjouterService(Me)
        Me.Enabled = False
        s.Show()

    End Sub


    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click

        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Dim cmdArticles As New OleDbCommand
        cmdArticles.CommandText = "SELECT * FROM compte where cin = " + GunaDataGridView6.Item(1, GunaDataGridView6.CurrentRow.Index).Value
        cmdArticles.Connection = cn

        Dim drArticles As OleDbDataReader = cmdArticles.ExecuteReader

        While drArticles.Read
            Dim c1 As Compte = New Compte(drArticles.GetValue(0), drArticles.GetValue(1), drArticles.GetValue(2), drArticles.GetValue(3), drArticles.GetValue(4), drArticles.GetValue(5), drArticles.GetValue(6))
            Dim c As ModifierCompte = New ModifierCompte(c1, Me)
            Me.Enabled = False
            c.Show()
        End While

        cn.Close()
        cn = Nothing



    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click

        Dim result1 As DialogResult = MessageBox.Show(" Voulez vous supprimer ce compte ?? ", "Question Important ", MessageBoxButtons.YesNo)

        If (result1 = DialogResult.Yes) Then
            Dim cn As OleDbConnection = DbConnection.connect
            cn.Open()

            Dim cmdArticles As New OleDbCommand
            cmdArticles.CommandText = "SELECT * FROM compte where cin = " + GunaDataGridView6.Item(1, GunaDataGridView6.CurrentRow.Index).Value
            cmdArticles.Connection = cn

            Dim drArticles As OleDbDataReader = cmdArticles.ExecuteReader

            While drArticles.Read
                Dim c As Compte = New Compte(drArticles.GetValue(0), drArticles.GetValue(1), drArticles.GetValue(2), drArticles.GetValue(3), drArticles.GetValue(4), drArticles.GetValue(5), drArticles.GetValue(6))
                If (c.delete(GunaDataGridView6.Item(1, GunaDataGridView6.CurrentRow.Index).Value)) Then
                    MessageBox.Show(" le compte '" + drArticles.GetValue(1).ToString + " " + drArticles.GetValue(1).ToString + "' a été supprimer ", "!!")
                Else
                    MessageBox.Show(" erreur de suppression du compte : " + drArticles.GetValue(1).ToString + " " + drArticles.GetValue(1).ToString, "Er")
                End If

            End While

            cn.Close()
            cn = Nothing
            affiche_compte("")
        End If



    End Sub

    Private Sub Guna2TextBox1_Enter(sender As Object, e As EventArgs) Handles Guna2TextBox1.Enter
        If (Guna2TextBox1.Text = "Recherche...") Then
            Guna2TextBox1.Text = ""
        End If
    End Sub

    Private Sub Guna2TextBox1_Leave(sender As Object, e As EventArgs) Handles Guna2TextBox1.Leave
        If (Guna2TextBox1.Text = "") Then
            Guna2TextBox1.Text = "Recherche..."
        End If
    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox1.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            'MessageBox.Show("Enter key")
            Dim g As Guna.UI.WinForms.GunaDataGridView
            If (pressed = "ac") Then

            End If

            If (pressed = "se") Then
                Dim num As Integer
                If (Integer.TryParse(Guna2TextBox1.Text, num)) Then
                    affiche_service_termine("where id LIKE '" + Guna2TextBox1.Text + "%'")
                    affiche_service_non_termine("and id LIKE '" + Guna2TextBox1.Text + "%'")
                Else
                    affiche_service_termine("where nom_service LIKE '" + Guna2TextBox1.Text + "%'")
                    affiche_service_non_termine("and nom_service LIKE '" + Guna2TextBox1.Text + "%'")
                End If
            End If

            If (pressed = "co") Then

                Dim num As Integer
                If (Integer.TryParse(Guna2TextBox1.Text, num)) Then
                    affiche_compte("where cin LIKE '" + Guna2TextBox1.Text + "%'")
                Else
                    affiche_compte("where nom LIKE '" + Guna2TextBox1.Text + "%'")
                End If
            End If


            If (pressed = "cl") Then
                g = GunaDataGridView5
                Dim num As Integer
                If (Integer.TryParse(Guna2TextBox1.Text, num)) Then
                    affiche_client("where cin LIKE '" + Guna2TextBox1.Text + "%'")
                Else
                    affiche_client("where nom LIKE '" + Guna2TextBox1.Text + "%'")
                End If
            End If
        End If


    End Sub

    Private Sub GunaDataGridView1_Click(sender As Object, e As EventArgs) Handles GunaDataGridView1.Click
        If (GunaDataGridView1.Rows.Count > 0) Then
            Dim cn As OleDbConnection = DbConnection.connect
            cn.Open()

            Dim cmdArticles As New OleDbCommand
            cmdArticles.CommandText = "SELECT * FROM date_service where id_service = " + GunaDataGridView1.Item(0, GunaDataGridView1.CurrentRow.Index).Value
            cmdArticles.Connection = cn

            Dim drArticles As OleDbDataReader = cmdArticles.ExecuteReader

            GunaDataGridView2.Rows.Clear()

            While drArticles.Read
                GunaDataGridView2.Rows.Add(New String() {drArticles.GetValue(0), drArticles.GetValue(1), "", drArticles.GetValue(2), drArticles.GetValue(3)})
            End While
            cn.Close()
            cn = Nothing

        End If


        'GunaDataGridView1.CurrentRow.Index).Value
        'GunaDataGridView1.Item(1, GunaDataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub GunaDataGridView3_Click(sender As Object, e As EventArgs) Handles GunaDataGridView3.Click
        If (GunaDataGridView3.Rows.Count > 0) Then
            Dim cn As OleDbConnection = DbConnection.connect
            cn.Open()

            Dim cmdArticles As New OleDbCommand
            cmdArticles.CommandText = "SELECT * FROM date_service where id_service = " + GunaDataGridView3.Item(0, GunaDataGridView3.CurrentRow.Index).Value
            cmdArticles.Connection = cn

            Dim drArticles As OleDbDataReader = cmdArticles.ExecuteReader

            GunaDataGridView4.Rows.Clear()

            While drArticles.Read
                GunaDataGridView4.Rows.Add(New String() {drArticles.GetValue(0), drArticles.GetValue(1), "", drArticles.GetValue(2), drArticles.GetValue(3)})
            End While
            cn.Close()
            cn = Nothing

        End If


        'GunaDataGridView1.CurrentRow.Index).Value
        'GunaDataGridView1.Item(1, GunaDataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Dim cmdArticles As New OleDbCommand
        cmdArticles.CommandText = "SELECT * FROM client where cin = " + GunaDataGridView5.Item(1, GunaDataGridView5.CurrentRow.Index).Value
        cmdArticles.Connection = cn

        Dim drArticles As OleDbDataReader = cmdArticles.ExecuteReader

        While drArticles.Read
            Dim c1 As Client = New Client(drArticles.GetValue(0), drArticles.GetValue(1), drArticles.GetValue(2), drArticles.GetValue(3), drArticles.GetValue(4), drArticles.GetValue(5), drArticles.GetValue(6))
            Dim c As ModifierClient = New ModifierClient(c1, Me)
            Me.Enabled = False
            c.Show()
        End While

        cn.Close()
        cn = Nothing

    End Sub


    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Dim cmdArticles As New OleDbCommand
        cmdArticles.CommandText = "SELECT * FROM client where cin = " + GunaDataGridView5.Item(1, GunaDataGridView5.CurrentRow.Index).Value
        cmdArticles.Connection = cn

        Dim drArticles As OleDbDataReader = cmdArticles.ExecuteReader

        While drArticles.Read
            Dim c1 As Client = New Client(drArticles.GetValue(0), drArticles.GetValue(1), drArticles.GetValue(2), drArticles.GetValue(3), drArticles.GetValue(4), drArticles.GetValue(5), drArticles.GetValue(6))
            Dim c As Dette = New Dette(c1, Me)
            Me.Enabled = False
            c.Show()
        End While

        cn.Close()
        cn = Nothing
    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()

        Dim cmdArticles As New OleDbCommand
        cmdArticles.CommandText = "SELECT * FROM service where id = " + GunaDataGridView1.Item(0, GunaDataGridView1.CurrentRow.Index).Value
        cmdArticles.Connection = cn

        Dim drArticles As OleDbDataReader = cmdArticles.ExecuteReader

        drArticles.Read()

        Dim s1 As Service = New Service(drArticles.GetValue(1), drArticles.GetValue(2), drArticles.GetValue(3), drArticles.GetValue(4), drArticles.GetValue(5))

        Try
            Dim cmdArticles1 As New OleDbCommand
            cmdArticles1.CommandText = "DELETE FROM `date_service` WHERE id_service = " + drArticles.GetValue(0).ToString
            cmdArticles1.Connection = cn
            cmdArticles1.ExecuteNonQuery()

        Catch ex As Exception
        End Try

        MessageBox.Show("Service annulé !!!                      ")
        Me.affiche_service_non_termine("")





        cn.Close()
        cn = Nothing
    End Sub
End Class
