<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPatientForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.btnDisplayAll = New System.Windows.Forms.Button()
        Me.dgvPatientList = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.txtAllergies = New System.Windows.Forms.TextBox()
        Me.txtBloodType = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.txtNRICPassportNumber = New System.Windows.Forms.TextBox()
        Me.lblAllergies = New System.Windows.Forms.Label()
        Me.lblBloodType = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblNRICPassportNumber = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lblPatientInfo = New System.Windows.Forms.Label()
        Me.pnl2.SuspendLayout()
        CType(Me.dgvPatientList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl2
        '
        Me.pnl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl2.Controls.Add(Me.btnDisplayAll)
        Me.pnl2.Controls.Add(Me.dgvPatientList)
        Me.pnl2.Controls.Add(Me.btnDelete)
        Me.pnl2.Controls.Add(Me.btnUpdate)
        Me.pnl2.Controls.Add(Me.btnSearch)
        Me.pnl2.Controls.Add(Me.btnAdd)
        Me.pnl2.Controls.Add(Me.txtAddress)
        Me.pnl2.Controls.Add(Me.lblAddress)
        Me.pnl2.Controls.Add(Me.radFemale)
        Me.pnl2.Controls.Add(Me.radMale)
        Me.pnl2.Controls.Add(Me.txtAllergies)
        Me.pnl2.Controls.Add(Me.txtBloodType)
        Me.pnl2.Controls.Add(Me.txtHeight)
        Me.pnl2.Controls.Add(Me.txtWeight)
        Me.pnl2.Controls.Add(Me.txtEmail)
        Me.pnl2.Controls.Add(Me.txtContactNumber)
        Me.pnl2.Controls.Add(Me.txtNRICPassportNumber)
        Me.pnl2.Controls.Add(Me.lblAllergies)
        Me.pnl2.Controls.Add(Me.lblBloodType)
        Me.pnl2.Controls.Add(Me.lblHeight)
        Me.pnl2.Controls.Add(Me.lblWeight)
        Me.pnl2.Controls.Add(Me.txtName)
        Me.pnl2.Controls.Add(Me.txtPatientID)
        Me.pnl2.Controls.Add(Me.lblEmail)
        Me.pnl2.Controls.Add(Me.lblContactNumber)
        Me.pnl2.Controls.Add(Me.lblNRICPassportNumber)
        Me.pnl2.Controls.Add(Me.lblGender)
        Me.pnl2.Controls.Add(Me.lblName)
        Me.pnl2.Controls.Add(Me.lblPatientID)
        Me.pnl2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl2.Location = New System.Drawing.Point(0, 97)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(1920, 983)
        Me.pnl2.TabIndex = 38
        '
        'btnDisplayAll
        '
        Me.btnDisplayAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDisplayAll.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayAll.ForeColor = System.Drawing.Color.White
        Me.btnDisplayAll.Location = New System.Drawing.Point(898, 188)
        Me.btnDisplayAll.Name = "btnDisplayAll"
        Me.btnDisplayAll.Size = New System.Drawing.Size(218, 52)
        Me.btnDisplayAll.TabIndex = 75
        Me.btnDisplayAll.Text = "Display All"
        Me.btnDisplayAll.UseVisualStyleBackColor = False
        '
        'dgvPatientList
        '
        Me.dgvPatientList.BackgroundColor = System.Drawing.Color.White
        Me.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatientList.Location = New System.Drawing.Point(898, 262)
        Me.dgvPatientList.Name = "dgvPatientList"
        Me.dgvPatientList.RowHeadersWidth = 72
        Me.dgvPatientList.RowTemplate.Height = 31
        Me.dgvPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPatientList.Size = New System.Drawing.Size(957, 401)
        Me.dgvPatientList.TabIndex = 60
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(640, 611)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(164, 52)
        Me.btnDelete.TabIndex = 59
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(449, 611)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(164, 52)
        Me.btnUpdate.TabIndex = 58
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(259, 611)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(164, 52)
        Me.btnSearch.TabIndex = 57
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(68, 611)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(164, 52)
        Me.btnAdd.TabIndex = 56
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(524, 508)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(280, 45)
        Me.txtAddress.TabIndex = 52
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(333, 511)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(157, 37)
        Me.lblAddress.TabIndex = 51
        Me.lblAddress.Text = "Address:"
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.ForeColor = System.Drawing.Color.White
        Me.radFemale.Location = New System.Drawing.Point(643, 185)
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
        Me.radMale.Location = New System.Drawing.Point(524, 185)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(122, 41)
        Me.radMale.TabIndex = 48
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'txtAllergies
        '
        Me.txtAllergies.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllergies.Location = New System.Drawing.Point(1575, 107)
        Me.txtAllergies.Name = "txtAllergies"
        Me.txtAllergies.Size = New System.Drawing.Size(280, 45)
        Me.txtAllergies.TabIndex = 27
        '
        'txtBloodType
        '
        Me.txtBloodType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBloodType.Location = New System.Drawing.Point(1575, 29)
        Me.txtBloodType.Name = "txtBloodType"
        Me.txtBloodType.Size = New System.Drawing.Size(280, 45)
        Me.txtBloodType.TabIndex = 26
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(1046, 107)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(280, 45)
        Me.txtHeight.TabIndex = 25
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(1046, 29)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(280, 45)
        Me.txtWeight.TabIndex = 24
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(524, 424)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(280, 45)
        Me.txtEmail.TabIndex = 23
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Location = New System.Drawing.Point(524, 342)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(280, 45)
        Me.txtContactNumber.TabIndex = 22
        '
        'txtNRICPassportNumber
        '
        Me.txtNRICPassportNumber.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNRICPassportNumber.Location = New System.Drawing.Point(524, 262)
        Me.txtNRICPassportNumber.Name = "txtNRICPassportNumber"
        Me.txtNRICPassportNumber.Size = New System.Drawing.Size(280, 45)
        Me.txtNRICPassportNumber.TabIndex = 21
        '
        'lblAllergies
        '
        Me.lblAllergies.AutoSize = True
        Me.lblAllergies.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllergies.ForeColor = System.Drawing.Color.White
        Me.lblAllergies.Location = New System.Drawing.Point(1387, 110)
        Me.lblAllergies.Name = "lblAllergies"
        Me.lblAllergies.Size = New System.Drawing.Size(166, 37)
        Me.lblAllergies.TabIndex = 17
        Me.lblAllergies.Text = "Allergies:"
        '
        'lblBloodType
        '
        Me.lblBloodType.AutoSize = True
        Me.lblBloodType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBloodType.ForeColor = System.Drawing.Color.White
        Me.lblBloodType.Location = New System.Drawing.Point(1352, 32)
        Me.lblBloodType.Name = "lblBloodType"
        Me.lblBloodType.Size = New System.Drawing.Size(201, 37)
        Me.lblBloodType.TabIndex = 16
        Me.lblBloodType.Text = "Blood Type:"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.ForeColor = System.Drawing.Color.White
        Me.lblHeight.Location = New System.Drawing.Point(897, 110)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(129, 37)
        Me.lblHeight.TabIndex = 15
        Me.lblHeight.Text = "Height:"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.Color.White
        Me.lblWeight.Location = New System.Drawing.Point(891, 32)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(135, 37)
        Me.lblWeight.TabIndex = 14
        Me.lblWeight.Text = "Weight:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(524, 107)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(280, 45)
        Me.txtName.TabIndex = 7
        '
        'txtPatientID
        '
        Me.txtPatientID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(524, 29)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(280, 45)
        Me.txtPatientID.TabIndex = 6
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(377, 427)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(113, 37)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email:"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.ForeColor = System.Drawing.Color.White
        Me.lblContactNumber.Location = New System.Drawing.Point(209, 345)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(281, 37)
        Me.lblContactNumber.TabIndex = 4
        Me.lblContactNumber.Text = "Contact Number:"
        '
        'lblNRICPassportNumber
        '
        Me.lblNRICPassportNumber.AutoSize = True
        Me.lblNRICPassportNumber.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNRICPassportNumber.ForeColor = System.Drawing.Color.White
        Me.lblNRICPassportNumber.Location = New System.Drawing.Point(87, 265)
        Me.lblNRICPassportNumber.Name = "lblNRICPassportNumber"
        Me.lblNRICPassportNumber.Size = New System.Drawing.Size(403, 37)
        Me.lblNRICPassportNumber.TabIndex = 3
        Me.lblNRICPassportNumber.Text = "NRIC / Passport Number:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.White
        Me.lblGender.Location = New System.Drawing.Point(347, 185)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(143, 37)
        Me.lblGender.TabIndex = 2
        Me.lblGender.Text = "Gender:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(373, 110)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(117, 37)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'lblPatientID
        '
        Me.lblPatientID.AutoSize = True
        Me.lblPatientID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientID.ForeColor = System.Drawing.Color.White
        Me.lblPatientID.Location = New System.Drawing.Point(312, 32)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(178, 37)
        Me.lblPatientID.TabIndex = 0
        Me.lblPatientID.Text = "Patient ID:"
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl1.Controls.Add(Me.lblPatientInfo)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(1920, 99)
        Me.pnl1.TabIndex = 39
        '
        'lblPatientInfo
        '
        Me.lblPatientInfo.AutoSize = True
        Me.lblPatientInfo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientInfo.ForeColor = System.Drawing.Color.White
        Me.lblPatientInfo.Location = New System.Drawing.Point(26, 30)
        Me.lblPatientInfo.Name = "lblPatientInfo"
        Me.lblPatientInfo.Size = New System.Drawing.Size(223, 43)
        Me.lblPatientInfo.TabIndex = 0
        Me.lblPatientInfo.Text = "Patient Info"
        '
        'ViewPatientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.pnl2)
        Me.Name = "ViewPatientForm"
        Me.Size = New System.Drawing.Size(1920, 1080)
        Me.pnl2.ResumeLayout(False)
        Me.pnl2.PerformLayout()
        CType(Me.dgvPatientList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl2 As Panel
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents lblNRICPassportNumber As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPatientID As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents lblAllergies As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtAllergies As TextBox
    Friend WithEvents txtBloodType As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtNRICPassportNumber As TextBox
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents pnl1 As Panel
    Friend WithEvents lblPatientInfo As Label
    Friend WithEvents lblBloodType As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvPatientList As DataGridView
    Friend WithEvents btnDisplayAll As Button
End Class
