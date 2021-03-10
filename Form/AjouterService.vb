Imports System.Data.OleDb
Public Class AjouterService
    Dim d As Dash
    Public Sub New(d As Dash)
        Me.d = d
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Function test_client() As Boolean
        Dim C As Color = Color.Red
        Dim b As Color = Color.Transparent
        Dim ret As Boolean = True

        If GunaTextBox3.Text = "N°Cin" Or GunaTextBox3.Text.Length < 8 Then
            GunaTextBox3.BorderColor = C
            ret = False
        Else
            GunaTextBox3.BorderColor = b
        End If

        If GunaTextBox4.Text = "Nom" Then
            GunaTextBox4.BorderColor = C
            ret = False
        Else
            GunaTextBox4.BorderColor = b
        End If

        If GunaTextBox5.Text = "Prenom" Then
            GunaTextBox5.BorderColor = C
            ret = False
        Else
            GunaTextBox5.BorderColor = b
        End If

        If GunaTextBox6.Text = "N°Telephone" Or GunaTextBox6.Text.Length < 8 Then
            GunaTextBox6.BorderColor = C
            ret = False
        Else

            GunaTextBox6.BorderColor = b
        End If

        If (Not (GunaTextBox7.Text = "expl@exmpl.com") And (GunaTextBox7.Text.IndexOf("@") = -1)) Then
            GunaTextBox7.BorderColor = C
            ret = False
        Else

            GunaTextBox7.BorderColor = b
        End If

        If GunaTextBox8.Text = "Adresse" Then
            GunaTextBox8.BorderColor = C
            ret = False
        Else
            GunaTextBox8.BorderColor = b
        End If

        If GunaTextBox10.Text = "Totale" Then
            GunaTextBox10.BorderColor = C
            ret = False
        Else
            GunaTextBox10.BorderColor = b
        End If

        If GunaTextBox9.Text = "Avance" Then
            GunaTextBox9.BorderColor = C
            ret = False
        Else
            GunaTextBox9.BorderColor = b
        End If


        Return ret
    End Function

    Private Function test_service()
        Dim result As Boolean = True


        If GunaDataGridView1.Rows.Count() = 0 Then
            GunaCirclePictureBox1.Visible = True
            result = False

        Else
            GunaCirclePictureBox1.Visible = False
        End If

        If GunaTextBox1.Text = "" Then
            GunaTextBox1.BorderColor = Color.Red
            result = False
        Else
            GunaTextBox1.BorderColor = Color.Transparent
        End If

        If Guna2RadioButton1.Checked = False And Guna2RadioButton2.Checked = False And Guna2RadioButton3.Checked = False And Guna2RadioButton4.Checked = False And GunaTextBox2.Text = "" Then
            GunaCirclePictureBox2.Visible = True
            GunaTextBox2.BorderColor = Color.Red
            result = False
        Else
            GunaTextBox2.BorderColor = Color.Transparent
            GunaCirclePictureBox2.Visible = False
        End If

        If GunaTextBox9.Text = "" Or GunaTextBox9.Text = "Avance" Then
            GunaTextBox9.BorderColor = Color.Red
            result = False
        Else
            GunaTextBox9.BorderColor = Color.Transparent
        End If

        If GunaTextBox10.Text = "" Or GunaTextBox10.Text = "Totale" Then

            GunaTextBox10.BorderColor = Color.Red
            result = False
        Else
            GunaTextBox10.BorderColor = Color.Transparent
        End If

        If result = True Then
            If (Integer.Parse(GunaTextBox9.Text) > Integer.Parse(GunaTextBox10.Text)) Then
                GunaTextBox9.BorderColor = Color.Red
                result = False
            Else
                GunaTextBox9.BorderColor = Color.Transparent
            End If
        End If


        Return result
    End Function

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If (test_client() And test_service()) Then
            'ajouter service this.dispose

            Dim nom_service As String = GunaTextBox1.Text

            Dim Type As String = GunaTextBox2.Text
            If (Guna2RadioButton1.Checked = True) Then
                Type = "mariage"
            ElseIf (Guna2RadioButton2.Checked = True) Then
                Type = "thour"
            ElseIf (Guna2RadioButton3.Checked = True) Then
                Type = "evenement"
            ElseIf (Guna2RadioButton4.Checked = True) Then
                Type = "shooting"
            End If

            Dim tarif As String = GunaTextBox10.Text
            Dim avance As String = GunaTextBox9.Text

            Dim cin_client As String = GunaTextBox3.Text
            Dim nom_client As String = GunaTextBox4.Text
            Dim pren_client As String = GunaTextBox5.Text
            Dim tel_client As String = GunaTextBox6.Text
            Dim adr_client As String = GunaTextBox7.Text
            Dim mail_client As String = GunaTextBox8.Text

            Dim ser As Service = New Service(nom_service, Type, tarif, avance, cin_client)
            Dim client As Client = New Client(cin_client, nom_client, pren_client, tel_client, adr_client, mail_client, Integer.Parse(tarif) - Integer.Parse(avance))

            If (ser.insert(GunaDataGridView1, client)) Then
                ' insetion reussite *//*/**/*//*/*/*/*/**/*/*/*/*/**
                MessageBox.Show(" SERVICE AJOUTER ")
                d.Enabled = True
                d.affiche_service_non_termine("")
                Me.Dispose()
            Else
                ' insertion echouée /*/*///*/*/*/*/*/*/*/**/*//**//*/*
                MessageBox.Show(" ERREUR ")
            End If



        End If

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        d.Enabled = True

        Me.Close()
    End Sub

    Private Sub GunaTextBox3_Enter(sender As Object, e As EventArgs) Handles GunaTextBox3.Enter
        If GunaTextBox3.Text = "N°Cin" Then
            sender.text = ""
        End If

    End Sub

    Private Sub GunaTextBox3_Leave(sender As Object, e As EventArgs) Handles GunaTextBox8.Leave, GunaTextBox7.Leave, GunaTextBox6.Leave, GunaTextBox5.Leave




        If GunaTextBox4.Text = "" Then
            GunaTextBox4.Text = "Nom"
        End If

        If GunaTextBox5.Text = "" Then
            GunaTextBox5.Text = "Prenom"
        End If

        If GunaTextBox6.Text = "" Then
            GunaTextBox6.Text = "N°Telephone"
        End If

        If GunaTextBox7.Text = "" Then
            GunaTextBox7.Text = "expl@exmpl.com"
        End If

        If GunaTextBox8.Text = "" Then
            GunaTextBox8.Text = "Adresse"
        End If

    End Sub

    Private Sub GunaTextBox4_Enter(sender As Object, e As EventArgs) Handles GunaTextBox4.Enter
        If GunaTextBox4.Text = "Nom" Then
            sender.text = ""
        End If

    End Sub

    Private Sub GunaTextBox5_Enter(sender As Object, e As EventArgs) Handles GunaTextBox5.Enter
        If GunaTextBox5.Text = "Prenom" Then
            sender.text = ""
        End If

    End Sub

    Private Sub GunaTextBox6_Enter(sender As Object, e As EventArgs) Handles GunaTextBox6.Enter
        If GunaTextBox6.Text = "N°Telephone" Then
            sender.text = ""
        End If

    End Sub

    Private Sub GunaTextBox7_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox7.TextChanged

    End Sub

    Private Sub GunaTextBox7_Enter(sender As Object, e As EventArgs) Handles GunaTextBox7.Enter
        If GunaTextBox7.Text = "expl@exmpl.com" Then
            sender.text = ""
        End If

    End Sub

    Private Sub GunaTextBox8_Enter(sender As Object, e As EventArgs) Handles GunaTextBox8.Enter
        If GunaTextBox8.Text = "Adresse" Then
            sender.text = ""
        End If
    End Sub

    Private Sub GunaTextBox2_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox2.TextChanged
        Guna2RadioButton1.Checked = False
        Guna2RadioButton2.Checked = False
        Guna2RadioButton3.Checked = False
        Guna2RadioButton4.Checked = False

    End Sub

    Private Sub Guna2RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton4.CheckedChanged, Guna2RadioButton3.CheckedChanged, Guna2RadioButton2.CheckedChanged, Guna2RadioButton1.CheckedChanged
        GunaTextBox2.Text = ""
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        For Each row As DataGridViewRow In GunaDataGridView1.SelectedRows
            GunaDataGridView1.Rows.Remove(row)
        Next
    End Sub
    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Dim d As AjouterDate = New AjouterDate(Me)
        d.Show()
        Me.Enabled = False
    End Sub

    Private Sub GunaTextBox10_Enter(sender As Object, e As EventArgs) Handles GunaTextBox10.Enter
        If (GunaTextBox10.Text = "Totale") Then
            GunaTextBox10.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox10_Leave(sender As Object, e As EventArgs) Handles GunaTextBox10.Leave
        If (GunaTextBox10.Text = "") Then
            GunaTextBox10.Text = "Totale"
        End If
        Dim a As Integer
        If (Integer.TryParse(GunaTextBox10.Text, a)) Then
            GunaTextBox9.Text = Int(a / 2)
        End If
    End Sub

    Private Sub GunaTextBox9_Enter(sender As Object, e As EventArgs) Handles GunaTextBox9.Enter
        If (GunaTextBox9.Text = "Avance") Then
            GunaTextBox9.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox9_Leave(sender As Object, e As EventArgs) Handles GunaTextBox9.Leave
        If (GunaTextBox9.Text = "") Then
            GunaTextBox9.Text = "Avance"
        End If
    End Sub

    Private Sub GunaTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox2.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsLetter(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaTextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox4.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsLetter(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaTextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox5.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsLetter(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaTextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox3.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaTextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox6.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaTextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox10.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaTextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox9.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub GunaTextBox4_Leave(sender As Object, e As EventArgs) Handles GunaTextBox4.Leave
        If GunaTextBox4.Text = "" Then
            sender.text = "Nom"
        End If
    End Sub

    Private Sub GunaPanel1_MouseClick(sender As Object, e As MouseEventArgs) Handles GunaPanel1.MouseClick
        Guna2Button1.Focus()
    End Sub

    Private Sub GunaTextBox3_Leave_1(sender As Object, e As EventArgs) Handles GunaTextBox3.Leave

        If GunaTextBox3.Text = "" Then
            GunaTextBox3.Text = "N°Cin"
        End If
        Dim cn As OleDbConnection = DbConnection.connect
        cn.Open()
        'if sender is CIN

        Try
            Dim cmdArticles As New OleDbCommand
            cmdArticles.CommandText = "Select * FROM `client` WHERE cin = " + GunaTextBox3.Text
            cmdArticles.Connection = cn

            Dim drArticles As OleDbDataReader = cmdArticles.ExecuteReader
            drArticles.Read()
            GunaTextBox4.Text = drArticles.GetValue(1).ToString
            GunaTextBox4.Enabled = False
            GunaTextBox5.Text = drArticles.GetValue(2).ToString
            GunaTextBox5.Enabled = False
            GunaTextBox6.Text = drArticles.GetValue(3).ToString
            GunaTextBox6.Enabled = False
            GunaTextBox8.Text = drArticles.GetValue(5).ToString
            GunaTextBox8.Enabled = False
            GunaTextBox7.Text = drArticles.GetValue(4).ToString
            GunaTextBox7.Enabled = False

            cn.Close()

        Catch ex As Exception
            GunaTextBox4.Text = "Nom"
            GunaTextBox4.Enabled = True
            GunaTextBox5.Text = "Prenom"
            GunaTextBox5.Enabled = True
            GunaTextBox6.Text = "N°Telephone"
            GunaTextBox6.Enabled = True
            GunaTextBox8.Text = "Adresse"
            GunaTextBox8.Enabled = True
            GunaTextBox7.Text = "expl@exmpl.com"
            GunaTextBox7.Enabled = True
        End Try
    End Sub
End Class