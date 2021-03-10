Public Class AjouterCompte
    Dim d As Dash
    Public Sub New(d As Dash)
        Me.d = d
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Function test() As Boolean
        Dim a As Boolean = True
        If GunaTextBox1.Text = "" Then
            GunaTextBox1.BorderColor = Color.Red
            a = False
        Else
            GunaTextBox1.BorderColor = Color.Transparent
        End If


        If GunaTextBox2.Text = "" Then
            GunaTextBox2.BorderColor = Color.Red
            a = False
        Else
            GunaTextBox2.BorderColor = Color.Transparent
        End If

        If GunaTextBox3.Text = "" Or (GunaTextBox3.Text.Length < 8) Then
            GunaTextBox3.BorderColor = Color.Red
            a = False
        Else
            GunaTextBox3.BorderColor = Color.Transparent
        End If


        If GunaTextBox4.Text = "" Or (GunaTextBox4.Text.Length < 8) Then
            GunaTextBox4.BorderColor = Color.Red
            a = False
        Else
            GunaTextBox4.BorderColor = Color.Transparent
        End If


        If GunaTextBox5.Text = "" Then
            GunaTextBox5.BorderColor = Color.Red
            a = False
        Else
            GunaTextBox5.BorderColor = Color.Transparent
        End If


        If GunaRadioButton1.Checked = "false" And GunaRadioButton2.Checked = "false" Then
            GunaCirclePictureBox1.Visible = True
            a = False
        Else
            GunaCirclePictureBox1.Visible = False
        End If


        If GunaComboBox1.SelectedItem = "" Then
            GunaComboBox1.BorderColor = Color.Red
            a = False
        Else
            GunaComboBox1.BorderColor = Color.Transparent
        End If

        Return a
    End Function


    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If (test()) Then
            Dim nom As String = GunaTextBox1.Text
            Dim prenom As String = GunaTextBox2.Text
            Dim cin As String = GunaTextBox3.Text
            Dim num As String = GunaTextBox4.Text
            Dim pass As String = GunaTextBox5.Text
            Dim sexe As String
            Dim type As String = GunaComboBox1.SelectedItem
            If (GunaRadioButton1.Checked = True) Then
                sexe = "H"
            Else
                sexe = "F"
            End If
            Dim c As Compte = New Compte(cin, nom, prenom, num, sexe, type, pass)
            If (c.insert()) Then
                d.Enabled = True
                d.affiche_compte("")
                Me.Close()
            Else
                GunaTextBox3.BorderColor = Color.Red
                MessageBox.Show("CIN existe deja", "Erreur                                                   !!")
            End If


        End If


    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        d.Enabled = True
        Me.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GunaTextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox4.KeyPress, GunaTextBox3.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox2.KeyPress, GunaTextBox1.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsLetter(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GunaTextBox1_Leave(sender As Object, e As EventArgs) Handles GunaTextBox1.Leave
        If GunaTextBox1.Text = "" Then
            GunaTextBox1.BorderColor = Color.Red
        Else
            GunaTextBox1.BorderColor = Color.Transparent
        End If
    End Sub

    Private Sub GunaTextBox2_Leave(sender As Object, e As EventArgs) Handles GunaTextBox2.Leave
        If GunaTextBox2.Text = "" Then
            GunaTextBox2.BorderColor = Color.Red
        Else
            GunaTextBox2.BorderColor = Color.Transparent
        End If
    End Sub

    Private Sub GunaTextBox3_Leave(sender As Object, e As EventArgs) Handles GunaTextBox3.Leave
        If GunaTextBox3.Text = "" Then
            GunaTextBox3.BorderColor = Color.Red
        Else
            GunaTextBox3.BorderColor = Color.Transparent
        End If
    End Sub

    Private Sub GunaTextBox4_Leave(sender As Object, e As EventArgs) Handles GunaTextBox4.Leave

        If GunaTextBox4.Text = "" Then
            GunaTextBox4.BorderColor = Color.Red
        Else
            GunaTextBox4.BorderColor = Color.Transparent
        End If
    End Sub

    Private Sub GunaTextBox5_Leave(sender As Object, e As EventArgs) Handles GunaTextBox5.Leave
        If GunaTextBox5.Text = "" Then
            GunaTextBox5.BorderColor = Color.Red
        Else
            GunaTextBox5.BorderColor = Color.Transparent
        End If
    End Sub


End Class