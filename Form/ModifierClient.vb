Public Class ModifierClient

    Private c As Client
    Dim d As Dash
    Public Sub New(c As Client, d As Dash)
        Me.c = c
        Me.d = d
        ' This call is required by the designer.
        InitializeComponent()
        GunaTextBox1.Text = c.getSetNom
        GunaTextBox2.Text = c.getSetPrenom
        GunaTextBox3.Text = c.getSetTel
        GunaTextBox4.Text = c.getSetMail
        GunaTextBox5.Text = c.getSetAdresse
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Function test_vide() As Boolean
        Dim t As Boolean = True
        If GunaTextBox1.Text = "" Then
            GunaTextBox1.BorderColor = Color.Red
            t = False
        Else
            GunaTextBox1.BorderColor = Color.Transparent
        End If

        If GunaTextBox2.Text = "" Then
            GunaTextBox2.BorderColor = Color.Red
            t = False
        Else
            GunaTextBox2.BorderColor = Color.Transparent
        End If

        If GunaTextBox3.Text.Length < 8 Then
            GunaTextBox3.BorderColor = Color.Red
            t = False
        Else
            GunaTextBox3.BorderColor = Color.Transparent
        End If


        If GunaTextBox5.Text = "" Then
            GunaTextBox5.BorderColor = Color.Red
            t = False
        Else
            GunaTextBox5.BorderColor = Color.Transparent
        End If

        Return t
    End Function
    Private Sub GunaTextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox3.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        d.Enabled = True
        Me.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If (test_vide()) Then
            Dim nom As String = GunaTextBox1.Text
            Dim prenom As String = GunaTextBox2.Text
            Dim tel As String = GunaTextBox3.Text
            Dim mail As String = GunaTextBox4.Text
            Dim adresse As String = GunaTextBox5.Text


            Dim cc As Client = New Client(c.getSetCin, nom, prenom, tel, adresse, mail, c.getSetDette)
            If (cc.update()) Then
                d.Enabled = True
                MessageBox.Show("Modifier !!")
                d.affiche_client("")
                Me.Close()
            Else

            End If

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

        If GunaTextBox3.Text.Length < 8 Then
            GunaTextBox3.BorderColor = Color.Red
        Else
            GunaTextBox3.BorderColor = Color.Transparent
        End If
    End Sub
    Private Sub GunaTextBox5_Leave(sender As Object, e As EventArgs) Handles GunaTextBox5.Leave
        If GunaTextBox5.Text = "" Then
            GunaTextBox5.BorderColor = Color.Red
        Else
            GunaTextBox5.BorderColor = Color.Transparent
        End If
    End Sub
    Private Sub GunaTextBox4_Leave(sender As Object, e As EventArgs) Handles GunaTextBox4.Leave
        If GunaTextBox4.Text = "" Then
            GunaTextBox4.BorderColor = Color.Red
        Else
            GunaTextBox4.BorderColor = Color.Transparent
        End If
    End Sub

End Class