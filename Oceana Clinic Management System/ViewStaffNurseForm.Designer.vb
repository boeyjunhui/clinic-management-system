<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewStaffNurseForm
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
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.btnDisplayAll = New System.Windows.Forms.Button()
        Me.dgvStaffNurseList = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtStaffNurseID = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblStaffNurseID = New System.Windows.Forms.Label()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lblStaffNurseInfo = New System.Windows.Forms.Label()
        Me.pnl2.SuspendLayout()
        CType(Me.dgvStaffNurseList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl2
        '
        Me.pnl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl2.Controls.Add(Me.btnDisplayAll)
        Me.pnl2.Controls.Add(Me.dgvStaffNurseList)
        Me.pnl2.Controls.Add(Me.btnDelete)
        Me.pnl2.Controls.Add(Me.btnUpdate)
        Me.pnl2.Controls.Add(Me.btnSearch)
        Me.pnl2.Controls.Add(Me.txtAddress)
        Me.pnl2.Controls.Add(Me.radFemale)
        Me.pnl2.Controls.Add(Me.radMale)
        Me.pnl2.Controls.Add(Me.lblGender)
        Me.pnl2.Controls.Add(Me.btnAdd)
        Me.pnl2.Controls.Add(Me.txtContactNumber)
        Me.pnl2.Controls.Add(Me.txtName)
        Me.pnl2.Controls.Add(Me.txtStaffNurseID)
        Me.pnl2.Controls.Add(Me.lblAddress)
        Me.pnl2.Controls.Add(Me.lblContactNumber)
        Me.pnl2.Controls.Add(Me.lblName)
        Me.pnl2.Controls.Add(Me.lblStaffNurseID)
        Me.pnl2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl2.Location = New System.Drawing.Point(0, 97)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(1920, 983)
        Me.pnl2.TabIndex = 36
        '
        'btnDisplayAll
        '
        Me.btnDisplayAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDisplayAll.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayAll.ForeColor = System.Drawing.Color.White
        Me.btnDisplayAll.Location = New System.Drawing.Point(933, 42)
        Me.btnDisplayAll.Name = "btnDisplayAll"
        Me.btnDisplayAll.Size = New System.Drawing.Size(218, 52)
        Me.btnDisplayAll.TabIndex = 74
        Me.btnDisplayAll.Text = "Display All"
        Me.btnDisplayAll.UseVisualStyleBackColor = False
        '
        'dgvStaffNurseList
        '
        Me.dgvStaffNurseList.BackgroundColor = System.Drawing.Color.White
        Me.dgvStaffNurseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaffNurseList.Location = New System.Drawing.Point(933, 122)
        Me.dgvStaffNurseList.Name = "dgvStaffNurseList"
        Me.dgvStaffNurseList.RowHeadersWidth = 72
        Me.dgvStaffNurseList.RowTemplate.Height = 31
        Me.dgvStaffNurseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStaffNurseList.Size = New System.Drawing.Size(873, 377)
        Me.dgvStaffNurseList.TabIndex = 56
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(687, 447)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(164, 52)
        Me.btnDelete.TabIndex = 55
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(497, 447)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(164, 52)
        Me.btnUpdate.TabIndex = 54
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(306, 447)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(164, 52)
        Me.btnSearch.TabIndex = 53
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(502, 340)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(280, 45)
        Me.txtAddress.TabIndex = 50
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.ForeColor = System.Drawing.Color.White
        Me.radFemale.Location = New System.Drawing.Point(621, 192)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(161, 41)
        Me.radFemale.TabIndex = 49
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.ForeColor = System.Drawing.Color.White
        Me.radMale.Location = New System.Drawing.Point(502, 192)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(122, 41)
        Me.radMale.TabIndex = 48
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.White
        Me.lblGender.Location = New System.Drawing.Point(323, 194)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(143, 37)
        Me.lblGender.TabIndex = 44
        Me.lblGender.Text = "Gender:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(117, 447)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(164, 52)
        Me.btnAdd.TabIndex = 43
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Location = New System.Drawing.Point(502, 259)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(280, 45)
        Me.txtContactNumber.TabIndex = 42
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(502, 122)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(280, 45)
        Me.txtName.TabIndex = 40
        '
        'txtStaffNurseID
        '
        Me.txtStaffNurseID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffNurseID.Location = New System.Drawing.Point(502, 42)
        Me.txtStaffNurseID.Name = "txtStaffNurseID"
        Me.txtStaffNurseID.Size = New System.Drawing.Size(280, 45)
        Me.txtStaffNurseID.TabIndex = 39
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(310, 343)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(157, 37)
        Me.lblAddress.TabIndex = 38
        Me.lblAddress.Text = "Address:"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.ForeColor = System.Drawing.Color.White
        Me.lblContactNumber.Location = New System.Drawing.Point(189, 262)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(281, 37)
        Me.lblContactNumber.TabIndex = 37
        Me.lblContactNumber.Text = "Contact Number:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(348, 122)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(117, 37)
        Me.lblName.TabIndex = 36
        Me.lblName.Text = "Name:"
        '
        'lblStaffNurseID
        '
        Me.lblStaffNurseID.AutoSize = True
        Me.lblStaffNurseID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffNurseID.ForeColor = System.Drawing.Color.White
        Me.lblStaffNurseID.Location = New System.Drawing.Point(228, 45)
        Me.lblStaffNurseID.Name = "lblStaffNurseID"
        Me.lblStaffNurseID.Size = New System.Drawing.Size(243, 37)
        Me.lblStaffNurseID.TabIndex = 35
        Me.lblStaffNurseID.Text = "Staff Nurse ID:"
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl1.Controls.Add(Me.lblStaffNurseInfo)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(1920, 99)
        Me.pnl1.TabIndex = 37
        '
        'lblStaffNurseInfo
        '
        Me.lblStaffNurseInfo.AutoSize = True
        Me.lblStaffNurseInfo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffNurseInfo.ForeColor = System.Drawing.Color.White
        Me.lblStaffNurseInfo.Location = New System.Drawing.Point(26, 30)
        Me.lblStaffNurseInfo.Name = "lblStaffNurseInfo"
        Me.lblStaffNurseInfo.Size = New System.Drawing.Size(297, 43)
        Me.lblStaffNurseInfo.TabIndex = 0
        Me.lblStaffNurseInfo.Text = "Staff Nurse Info"
        '
        'ViewStaffNurseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.pnl2)
        Me.Name = "ViewStaffNurseForm"
        Me.Size = New System.Drawing.Size(1920, 1080)
        Me.pnl2.ResumeLayout(False)
        Me.pnl2.PerformLayout()
        CType(Me.dgvStaffNurseList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl2 As Panel
    Friend WithEvents lblGender As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStaffNurseID As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblStaffNurseID As Label
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents pnl1 As Panel
    Friend WithEvents lblStaffNurseInfo As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents dgvStaffNurseList As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDisplayAll As Button
End Class
