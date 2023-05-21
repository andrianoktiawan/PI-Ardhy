<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblCreateid = New System.Windows.Forms.Label()
        Me.lblCreateuser = New System.Windows.Forms.Label()
        Me.lblCreatepw = New System.Windows.Forms.Label()
        Me.lblCreaterole = New System.Windows.Forms.Label()
        Me.txtbId = New System.Windows.Forms.TextBox()
        Me.txtbUser = New System.Windows.Forms.TextBox()
        Me.txtbPassword = New System.Windows.Forms.TextBox()
        Me.txtbRole = New System.Windows.Forms.TextBox()
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
        'lblCreateid
        '
        Me.lblCreateid.AutoSize = True
        Me.lblCreateid.Location = New System.Drawing.Point(67, 59)
        Me.lblCreateid.Name = "lblCreateid"
        Me.lblCreateid.Size = New System.Drawing.Size(16, 14)
        Me.lblCreateid.TabIndex = 1
        Me.lblCreateid.Text = "ID"
        '
        'lblCreateuser
        '
        Me.lblCreateuser.AutoSize = True
        Me.lblCreateuser.Location = New System.Drawing.Point(67, 87)
        Me.lblCreateuser.Name = "lblCreateuser"
        Me.lblCreateuser.Size = New System.Drawing.Size(56, 14)
        Me.lblCreateuser.TabIndex = 2
        Me.lblCreateuser.Text = "Username"
        '
        'lblCreatepw
        '
        Me.lblCreatepw.AutoSize = True
        Me.lblCreatepw.Location = New System.Drawing.Point(67, 125)
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
        'txtbId
        '
        Me.txtbId.Location = New System.Drawing.Point(146, 53)
        Me.txtbId.Name = "txtbId"
        Me.txtbId.Size = New System.Drawing.Size(234, 20)
        Me.txtbId.TabIndex = 5
        '
        'txtbUser
        '
        Me.txtbUser.Location = New System.Drawing.Point(146, 87)
        Me.txtbUser.Name = "txtbUser"
        Me.txtbUser.Size = New System.Drawing.Size(234, 20)
        Me.txtbUser.TabIndex = 6
        '
        'txtbPassword
        '
        Me.txtbPassword.Location = New System.Drawing.Point(146, 119)
        Me.txtbPassword.Name = "txtbPassword"
        Me.txtbPassword.Size = New System.Drawing.Size(234, 20)
        Me.txtbPassword.TabIndex = 7
        '
        'txtbRole
        '
        Me.txtbRole.Location = New System.Drawing.Point(146, 148)
        Me.txtbRole.Name = "txtbRole"
        Me.txtbRole.Size = New System.Drawing.Size(234, 20)
        Me.txtbRole.TabIndex = 8
        '
        'frmCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtbRole)
        Me.Controls.Add(Me.txtbPassword)
        Me.Controls.Add(Me.txtbUser)
        Me.Controls.Add(Me.txtbId)
        Me.Controls.Add(Me.lblCreaterole)
        Me.Controls.Add(Me.lblCreatepw)
        Me.Controls.Add(Me.lblCreateuser)
        Me.Controls.Add(Me.lblCreateid)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "frmCreateAccount"
        Me.Text = "frmCreateAccount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents lblCreateid As Label
    Friend WithEvents lblCreateuser As Label
    Friend WithEvents lblCreatepw As Label
    Friend WithEvents lblCreaterole As Label
    Friend WithEvents txtbId As TextBox
    Friend WithEvents txtbUser As TextBox
    Friend WithEvents txtbPassword As TextBox
    Friend WithEvents txtbRole As TextBox
End Class
