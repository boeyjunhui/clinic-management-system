<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserAccountForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lblUserAccount = New System.Windows.Forms.Label()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.cboUserType = New System.Windows.Forms.ComboBox()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.dgvUserAccountList = New System.Windows.Forms.DataGridView()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnCreateNewAccount = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.pnl1.SuspendLayout()
        Me.pnl2.SuspendLayout()
        CType(Me.dgvUserAccountList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl1.Controls.Add(Me.lblUserAccount)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(1920, 99)
        Me.pnl1.TabIndex = 21
        '
        'lblUserAccount
        '
        Me.lblUserAccount.AutoSize = True
        Me.lblUserAccount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserAccount.ForeColor = System.Drawing.Color.White
        Me.lblUserAccount.Location = New System.Drawing.Point(26, 30)
        Me.lblUserAccount.Name = "lblUserAccount"
        Me.lblUserAccount.Size = New System.Drawing.Size(264, 43)
        Me.lblUserAccount.TabIndex = 0
        Me.lblUserAccount.Text = "User Account"
        '
        'pnl2
        '
        Me.pnl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl2.Controls.Add(Me.cboUserType)
        Me.pnl2.Controls.Add(Me.lblUserType)
        Me.pnl2.Controls.Add(Me.dgvUserAccountList)
        Me.pnl2.Controls.Add(Me.btnDeleteUser)
        Me.pnl2.Controls.Add(Me.btnCreateNewAccount)
        Me.pnl2.Controls.Add(Me.btnChangePassword)
        Me.pnl2.Controls.Add(Me.txtPassword)
        Me.pnl2.Controls.Add(Me.txtUserID)
        Me.pnl2.Controls.Add(Me.lblPassword)
        Me.pnl2.Controls.Add(Me.lblUserID)
        Me.pnl2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl2.Location = New System.Drawing.Point(0, 98)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(1920, 982)
        Me.pnl2.TabIndex = 22
        '
        'cboUserType
        '
        Me.cboUserType.BackColor = System.Drawing.Color.White
        Me.cboUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUserType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUserType.FormattingEnabled = True
        Me.cboUserType.Items.AddRange(New Object() {"Admin", "Staff Nurse", "Doctor"})
        Me.cboUserType.Location = New System.Drawing.Point(502, 201)
        Me.cboUserType.Name = "cboUserType"
        Me.cboUserType.Size = New System.Drawing.Size(382, 45)
        Me.cboUserType.TabIndex = 12
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.ForeColor = System.Drawing.Color.White
        Me.lblUserType.Location = New System.Drawing.Point(287, 204)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(185, 37)
        Me.lblUserType.TabIndex = 7
        Me.lblUserType.Text = "User Type:"
        '
        'dgvUserAccountList
        '
        Me.dgvUserAccountList.BackgroundColor = System.Drawing.Color.White
        Me.dgvUserAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserAccountList.Location = New System.Drawing.Point(1003, 38)
        Me.dgvUserAccountList.Name = "dgvUserAccountList"
        Me.dgvUserAccountList.RowHeadersWidth = 72
        Me.dgvUserAccountList.RowTemplate.Height = 31
        Me.dgvUserAccountList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserAccountList.Size = New System.Drawing.Size(600, 412)
        Me.dgvUserAccountList.TabIndex = 6
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDeleteUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.ForeColor = System.Drawing.Color.White
        Me.btnDeleteUser.Location = New System.Drawing.Point(502, 484)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(382, 57)
        Me.btnDeleteUser.TabIndex = 5
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'btnCreateNewAccount
        '
        Me.btnCreateNewAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnCreateNewAccount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNewAccount.ForeColor = System.Drawing.Color.White
        Me.btnCreateNewAccount.Location = New System.Drawing.Point(502, 302)
        Me.btnCreateNewAccount.Name = "btnCreateNewAccount"
        Me.btnCreateNewAccount.Size = New System.Drawing.Size(382, 57)
        Me.btnCreateNewAccount.TabIndex = 4
        Me.btnCreateNewAccount.Text = "Create New Account"
        Me.btnCreateNewAccount.UseVisualStyleBackColor = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnChangePassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.White
        Me.btnChangePassword.Location = New System.Drawing.Point(502, 393)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(382, 57)
        Me.btnChangePassword.TabIndex = 4
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(502, 118)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(382, 45)
        Me.txtPassword.TabIndex = 3
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(502, 38)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(382, 45)
        Me.txtUserID.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(292, 121)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(180, 37)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.White
        Me.lblUserID.Location = New System.Drawing.Point(329, 41)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(143, 37)
        Me.lblUserID.TabIndex = 0
        Me.lblUserID.Text = "User ID:"
        '
        'UserAccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "UserAccountForm"
        Me.Size = New System.Drawing.Size(1920, 1080)
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.pnl2.ResumeLayout(False)
        Me.pnl2.PerformLayout()
        CType(Me.dgvUserAccountList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl1 As Panel
    Friend WithEvents lblUserAccount As Label
    Friend WithEvents pnl2 As Panel
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnCreateNewAccount As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents dgvUserAccountList As DataGridView
    Friend WithEvents lblUserType As Label
    Friend WithEvents cboUserType As ComboBox
End Class
