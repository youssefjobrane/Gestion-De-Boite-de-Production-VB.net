Public Class Dette



    Dim dd As Dash
    Dim cc As Client
    Public Sub New(c As Client, d As Dash)
        dd = d
        Me.cc = c


        ' This call is required by the designer.
        InitializeComponent()
        GunaLabel5.Text = cc.getSetDette
        GunaLabel3.Text = cc.getSetNom
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        dd.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            Dim det As Integer = Integer.Parse(GunaTextBox1.Text)
            cc.payeDette(det)
            dd.affiche_client("")
            dd.Enabled = True
            Me.Dispose()
            MessageBox.Show("Payé !!!                                          ")
        Catch ex As Exception

        End Try



    End Sub

    Private Sub GunaTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox1.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
End Class