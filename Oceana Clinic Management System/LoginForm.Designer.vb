<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.lblOCEANACLINIC = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblManagementSystem = New System.Windows.Forms.Label()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.cboUserType = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOCEANACLINIC
        '
        Me.lblOCEANACLINIC.AutoSize = True
        Me.lblOCEANACLINIC.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOCEANACLINIC.ForeColor = System.Drawing.Color.White
        Me.lblOCEANACLINIC.Location = New System.Drawing.Point(269, 106)
        Me.lblOCEANACLINIC.Name = "lblOCEANACLINIC"
        Me.lblOCEANACLINIC.Size = New System.Drawing.Size(646, 87)
        Me.lblOCEANACLINIC.TabIndex = 0
        Me.lblOCEANACLINIC.Text = "OCEANA CLINIC"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.White
        Me.lblUserID.Location = New System.Drawing.Point(406, 315)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(143, 37)
        Me.lblUserID.TabIndex = 1
        Me.lblUserID.Text = "User ID:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(369, 388)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(180, 37)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password:"
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.Color.White
        Me.txtUserID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(566, 312)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(255, 45)
        Me.txtUserID.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(566, 385)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(255, 45)
        Me.txtPassword.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(371, 556)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(250, 55)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblManagementSystem
        '
        Me.lblManagementSystem.AutoSize = True
        Me.lblManagementSystem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManagementSystem.ForeColor = System.Drawing.Color.White
        Me.lblManagementSystem.Location = New System.Drawing.Point(362, 195)
        Me.lblManagementSystem.Name = "lblManagementSystem"
        Me.lblManagementSystem.Size = New System.Drawing.Size(459, 50)
        Me.lblManagementSystem.TabIndex = 9
        Me.lblManagementSystem.Text = "Management System"
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.ForeColor = System.Drawing.Color.White
        Me.lblUserType.Location = New System.Drawing.Point(364, 463)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(185, 37)
        Me.lblUserType.TabIndex = 10
        Me.lblUserType.Text = "User Type:"
        '
        'cboUserType
        '
        Me.cboUserType.BackColor = System.Drawing.Color.White
        Me.cboUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUserType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUserType.FormattingEnabled = True
        Me.cboUserType.Items.AddRange(New Object() {"Admin", "Staff Nurse", "Doctor"})
        Me.cboUserType.Location = New System.Drawing.Point(566, 460)
        Me.cboUserType.Name = "cboUserType"
        Me.cboUserType.Size = New System.Drawing.Size(255, 45)
        Me.cboUserType.TabIndex = 11
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(651, 556)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(170, 55)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1176, 736)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cboUserType)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lblManagementSystem)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblOCEANACLINIC)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOCEANACLINIC As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblManagementSystem As Label
    Friend WithEvents lblUserType As Label
    Friend WithEvents cboUserType As ComboBox
    Friend WithEvents btnExit As Button
End Class
