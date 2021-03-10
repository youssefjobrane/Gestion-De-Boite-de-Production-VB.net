Public Class AjouterDate

    Public a As AjouterService
    Public Sub New(aj As AjouterService)
        Me.a = aj
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Function time_valide() As Boolean
        If Not (GunaTextBox1.Text.Length = 5) Then
            GunaCirclePictureBox1.Visible = True
            Return False
        End If
        Dim c As String = GunaTextBox1.Text
        Dim c1 As Char = GetChar(c, 1)
        Dim c2 As Char = GetChar(c, 2)
        Dim c3 As Char = GetChar(c, 3)
        Dim c4 As Char = GetChar(c, 4)
        Dim c5 As Char = GetChar(c, 5)
        Dim e As Integer
        If (Integer.TryParse(c1, e) And Integer.TryParse(c2, e) And c3 = ":" And Integer.TryParse(c4, e) And Integer.TryParse(c5, e)) Then
            GunaCirclePictureBox1.Visible = False
            Return True
        End If
        GunaCirclePictureBox1.Visible = True
        Return False

    End Function
    Public Function lieu_valide() As Boolean
        If GunaTextBox2.Text = "" Or GunaTextBox2.Text = "ex: Le Palce" Then
            GunaCirclePictureBox2.Visible = True
            Return False
        Else
            GunaCirclePictureBox2.Visible = False
            Return True
        End If
    End Function

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Me.a.Enabled = True
        Me.Close()
    End Sub

    Private Sub GunaTextBox2_Enter(sender As Object, e As EventArgs) Handles GunaTextBox2.Enter
        If GunaTextBox2.Text = "ex: Le Palce" Then
            GunaTextBox2.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox2_Leave(sender As Object, e As EventArgs) Handles GunaTextBox2.Leave
        If GunaTextBox2.Text = "" Then
            GunaTextBox2.Text = "ex: Le Palce"
        End If

    End Sub
    Private Sub GunaTextBox1_Enter(sender As Object, e As EventArgs) Handles GunaTextBox1.Enter
        If GunaTextBox1.Text = "hh:mm" Then
            GunaTextBox1.Text = ""
        End If
    End Sub


    Private Sub GunaTextBox1_Leave(sender As Object, e As EventArgs) Handles GunaTextBox1.Leave
        If GunaTextBox1.Text = "" Then
            GunaTextBox1.Text = "hh:mm"
        End If

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If (time_valide()) And (lieu_valide()) Then
            a.GunaDataGridView1.Rows.Add(New String() {GunaDateTimePicker1.Text + " " + GunaTextBox1.Text, GunaTextBox2.Text, GunaTextBox3.Text})
            a.Enabled = True
            Me.Dispose()

        End If
    End Sub

End Class