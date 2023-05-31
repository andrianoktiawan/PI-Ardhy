<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreateAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateAccount))
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblCreateuser = New System.Windows.Forms.Label()
        Me.lblCreatepw = New System.Windows.Forms.Label()
        Me.lblCreaterole = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(110, 229)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create User"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblCreateuser
        '
        Me.lblCreateuser.AutoSize = True
        Me.lblCreateuser.Location = New System.Drawing.Point(67, 72)
        Me.lblCreateuser.Name = "lblCreateuser"
        Me.lblCreateuser.Size = New System.Drawing.Size(56, 14)
        Me.lblCreateuser.TabIndex = 2
        Me.lblCreateuser.Text = "Username"
        '
        'lblCreatepw
        '
        Me.lblCreatepw.AutoSize = True
        Me.lblCreatepw.Location = New System.Drawing.Point(67, 109)
        Me.lblCreatepw.Name = "lblCreatepw"
        Me.lblCreatepw.Size = New System.Drawing.Size(57, 14)
        Me.lblCreatepw.TabIndex = 3
        Me.lblCreatepw.Text = "Password"
        '
        'lblCreaterole
        '
        Me.lblCreaterole.AutoSize = True
        Me.lblCreaterole.Location = New System.Drawing.Point(70, 154)
        Me.lblCreaterole.Name = "lblCreaterole"
        Me.lblCreaterole.Size = New System.Drawing.Size(28, 14)
        Me.lblCreaterole.TabIndex = 4
        Me.lblCreaterole.Text = "Role"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(146, 69)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(234, 20)
        Me.txtUser.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(146, 106)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(234, 20)
        Me.txtPassword.TabIndex = 7
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(238, 228)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Kembali"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(518, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'cmbRole
        '
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Items.AddRange(New Object() {"Admin", "Pegawai"})
        Me.cmbRole.Location = New System.Drawing.Point(146, 151)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(121, 22)
        Me.cmbRole.TabIndex = 12
        '
        'frmCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblCreaterole)
        Me.Controls.Add(Me.lblCreatepw)
        Me.Controls.Add(Me.lblCreateuser)
        Me.Controls.Add(Me.btnCreate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCreateAccount"
        Me.Text = "frmCreateAccount"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents lblCreateuser As Label
    Friend WithEvents lblCreatepw As Label
    Friend WithEvents lblCreaterole As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbRole As ComboBox
End Class
