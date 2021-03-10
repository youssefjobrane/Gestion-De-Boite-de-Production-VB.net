<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaDragControl2 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.GunaDragControl3 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 8
        Me.GunaElipse2.TargetControl = Me
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Transparent
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.LightSeaGreen
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.Transparent
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.Control
        Me.GunaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox1.ForeColor = System.Drawing.Color.Snow
        Me.GunaTextBox1.Location = New System.Drawing.Point(52, 291)
        Me.GunaTextBox1.MaxLength = 8
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Radius = 8
        Me.GunaTextBox1.SelectedText = ""
        Me.GunaTextBox1.Size = New System.Drawing.Size(238, 43)
        Me.GunaTextBox1.TabIndex = 1
        Me.GunaTextBox1.Text = "C I N"
        Me.GunaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.Transparent
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.LightSeaGreen
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.Transparent
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.Control
        Me.GunaTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GunaTextBox2.ForeColor = System.Drawing.Color.Snow
        Me.GunaTextBox2.Location = New System.Drawing.Point(52, 340)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.GunaTextBox2.Radius = 8
        Me.GunaTextBox2.SelectedText = ""
        Me.GunaTextBox2.Size = New System.Drawing.Size(238, 41)
        Me.GunaTextBox2.TabIndex = 2
        Me.GunaTextBox2.Text = "pass"
        Me.GunaTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(71, 390)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 12
        Me.GunaButton1.Size = New System.Drawing.Size(87, 31)
        Me.GunaButton1.TabIndex = 3
        Me.GunaButton1.Text = "LOGIN"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Transparent
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(174, 390)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 12
        Me.GunaButton2.Size = New System.Drawing.Size(87, 31)
        Me.GunaButton2.TabIndex = 4
        Me.GunaButton2.Text = "CANCEL"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(61, 427)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(200, 10)
        Me.Guna2Separator1.TabIndex = 5
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.2!)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Gray
        Me.LinkLabel1.Location = New System.Drawing.Point(122, 440)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(83, 12)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ABOUT | CONACT"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'GunaDragControl2
        '
        Me.GunaDragControl2.TargetControl = Me.GunaPanel1
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackgroundImage = Global.login.My.Resources.Resources.lo
        Me.GunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(344, 250)
        Me.GunaPanel1.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImage = Global.login.My.Resources.Resources.logo_v1
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(82, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(179, 50)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'GunaDragControl3
        '
        Me.GunaDragControl3.TargetControl = Me.Guna2PictureBox1
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Symbol", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel1.Location = New System.Drawing.Point(65, 253)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(215, 32)
        Me.GunaLabel1.TabIndex = 7
        Me.GunaLabel1.Text = "Verifier votre login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(344, 476)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaTextBox2)
        Me.Controls.Add(Me.GunaTextBox1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControl2 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControl3 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
