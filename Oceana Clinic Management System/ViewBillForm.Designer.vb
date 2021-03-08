<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewBillForm
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
        Me.lblBillInfo = New System.Windows.Forms.Label()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.txtTotalConsultationFee = New System.Windows.Forms.TextBox()
        Me.lblTotalConsultationFee = New System.Windows.Forms.Label()
        Me.lblTotalMedicationFee = New System.Windows.Forms.Label()
        Me.txtTotalMedicationFee = New System.Windows.Forms.TextBox()
        Me.lblTotalServiceFee = New System.Windows.Forms.Label()
        Me.btnDisplayAll = New System.Windows.Forms.Button()
        Me.txtTotalServiceFee = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvBillList = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.pnl3 = New System.Windows.Forms.Panel()
        Me.grbMedicineandServices = New System.Windows.Forms.GroupBox()
        Me.chkPartialHealthCheck = New System.Windows.Forms.CheckBox()
        Me.chkComprehensiveHealthCheck = New System.Windows.Forms.CheckBox()
        Me.chkXRay = New System.Windows.Forms.CheckBox()
        Me.chkLabServices = New System.Windows.Forms.CheckBox()
        Me.chkOneMedicineType = New System.Windows.Forms.CheckBox()
        Me.chkConsultation = New System.Windows.Forms.CheckBox()
        Me.txtOneMedicineType = New System.Windows.Forms.TextBox()
        Me.grbPaymentCalculation = New System.Windows.Forms.GroupBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.btnCalculateTotalAmount = New System.Windows.Forms.Button()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.lblReceivedAmount = New System.Windows.Forms.Label()
        Me.txtReceivedAmount = New System.Windows.Forms.TextBox()
        Me.txtChangeAmount = New System.Windows.Forms.TextBox()
        Me.btnCalculateChangeAmount = New System.Windows.Forms.Button()
        Me.lblChangeAmount = New System.Windows.Forms.Label()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.pnl4 = New System.Windows.Forms.Panel()
        Me.btnGenerateReceipt = New System.Windows.Forms.Button()
        Me.rtfReceipt = New System.Windows.Forms.RichTextBox()
        Me.pnl1.SuspendLayout()
        Me.pnl2.SuspendLayout()
        CType(Me.dgvBillList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl3.SuspendLayout()
        Me.grbMedicineandServices.SuspendLayout()
        Me.grbPaymentCalculation.SuspendLayout()
        Me.pnl4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl1.Controls.Add(Me.lblBillInfo)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(2048, 99)
        Me.pnl1.TabIndex = 20
        '
        'lblBillInfo
        '
        Me.lblBillInfo.AutoSize = True
        Me.lblBillInfo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillInfo.ForeColor = System.Drawing.Color.White
        Me.lblBillInfo.Location = New System.Drawing.Point(26, 30)
        Me.lblBillInfo.Name = "lblBillInfo"
        Me.lblBillInfo.Size = New System.Drawing.Size(153, 43)
        Me.lblBillInfo.TabIndex = 0
        Me.lblBillInfo.Text = "Bill Info"
        '
        'pnl2
        '
        Me.pnl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl2.Controls.Add(Me.txtTotalConsultationFee)
        Me.pnl2.Controls.Add(Me.lblTotalConsultationFee)
        Me.pnl2.Controls.Add(Me.lblTotalMedicationFee)
        Me.pnl2.Controls.Add(Me.txtTotalMedicationFee)
        Me.pnl2.Controls.Add(Me.lblTotalServiceFee)
        Me.pnl2.Controls.Add(Me.btnDisplayAll)
        Me.pnl2.Controls.Add(Me.txtTotalServiceFee)
        Me.pnl2.Controls.Add(Me.btnDelete)
        Me.pnl2.Controls.Add(Me.dgvBillList)
        Me.pnl2.Controls.Add(Me.btnUpdate)
        Me.pnl2.Controls.Add(Me.btnSearch)
        Me.pnl2.Controls.Add(Me.btnAdd)
        Me.pnl2.Controls.Add(Me.txtName)
        Me.pnl2.Controls.Add(Me.txtPatientID)
        Me.pnl2.Controls.Add(Me.lblName)
        Me.pnl2.Controls.Add(Me.lblPatientID)
        Me.pnl2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl2.Location = New System.Drawing.Point(0, 97)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(680, 1055)
        Me.pnl2.TabIndex = 21
        '
        'txtTotalConsultationFee
        '
        Me.txtTotalConsultationFee.BackColor = System.Drawing.Color.White
        Me.txtTotalConsultationFee.Enabled = False
        Me.txtTotalConsultationFee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalConsultationFee.Location = New System.Drawing.Point(451, 134)
        Me.txtTotalConsultationFee.Name = "txtTotalConsultationFee"
        Me.txtTotalConsultationFee.ReadOnly = True
        Me.txtTotalConsultationFee.Size = New System.Drawing.Size(200, 41)
        Me.txtTotalConsultationFee.TabIndex = 115
        '
        'lblTotalConsultationFee
        '
        Me.lblTotalConsultationFee.AutoSize = True
        Me.lblTotalConsultationFee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalConsultationFee.ForeColor = System.Drawing.Color.White
        Me.lblTotalConsultationFee.Location = New System.Drawing.Point(19, 137)
        Me.lblTotalConsultationFee.Name = "lblTotalConsultationFee"
        Me.lblTotalConsultationFee.Size = New System.Drawing.Size(413, 33)
        Me.lblTotalConsultationFee.TabIndex = 113
        Me.lblTotalConsultationFee.Text = "Total Consultation Fee (RM):"
        '
        'lblTotalMedicationFee
        '
        Me.lblTotalMedicationFee.AutoSize = True
        Me.lblTotalMedicationFee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMedicationFee.ForeColor = System.Drawing.Color.White
        Me.lblTotalMedicationFee.Location = New System.Drawing.Point(44, 195)
        Me.lblTotalMedicationFee.Name = "lblTotalMedicationFee"
        Me.lblTotalMedicationFee.Size = New System.Drawing.Size(388, 33)
        Me.lblTotalMedicationFee.TabIndex = 114
        Me.lblTotalMedicationFee.Text = "Total Medication Fee (RM):"
        '
        'txtTotalMedicationFee
        '
        Me.txtTotalMedicationFee.BackColor = System.Drawing.Color.White
        Me.txtTotalMedicationFee.Enabled = False
        Me.txtTotalMedicationFee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMedicationFee.Location = New System.Drawing.Point(451, 192)
        Me.txtTotalMedicationFee.Name = "txtTotalMedicationFee"
        Me.txtTotalMedicationFee.ReadOnly = True
        Me.txtTotalMedicationFee.Size = New System.Drawing.Size(200, 41)
        Me.txtTotalMedicationFee.TabIndex = 116
        '
        'lblTotalServiceFee
        '
        Me.lblTotalServiceFee.AutoSize = True
        Me.lblTotalServiceFee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalServiceFee.ForeColor = System.Drawing.Color.White
        Me.lblTotalServiceFee.Location = New System.Drawing.Point(92, 254)
        Me.lblTotalServiceFee.Name = "lblTotalServiceFee"
        Me.lblTotalServiceFee.Size = New System.Drawing.Size(340, 33)
        Me.lblTotalServiceFee.TabIndex = 117
        Me.lblTotalServiceFee.Text = "Total Service Fee (RM):"
        '
        'btnDisplayAll
        '
        Me.btnDisplayAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDisplayAll.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayAll.ForeColor = System.Drawing.Color.White
        Me.btnDisplayAll.Location = New System.Drawing.Point(25, 405)
        Me.btnDisplayAll.Name = "btnDisplayAll"
        Me.btnDisplayAll.Size = New System.Drawing.Size(200, 50)
        Me.btnDisplayAll.TabIndex = 92
        Me.btnDisplayAll.Text = "Display All"
        Me.btnDisplayAll.UseVisualStyleBackColor = False
        '
        'txtTotalServiceFee
        '
        Me.txtTotalServiceFee.BackColor = System.Drawing.Color.White
        Me.txtTotalServiceFee.Enabled = False
        Me.txtTotalServiceFee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalServiceFee.Location = New System.Drawing.Point(451, 251)
        Me.txtTotalServiceFee.Name = "txtTotalServiceFee"
        Me.txtTotalServiceFee.ReadOnly = True
        Me.txtTotalServiceFee.Size = New System.Drawing.Size(200, 41)
        Me.txtTotalServiceFee.TabIndex = 118
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(511, 327)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(140, 50)
        Me.btnDelete.TabIndex = 59
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'dgvBillList
        '
        Me.dgvBillList.BackgroundColor = System.Drawing.Color.White
        Me.dgvBillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBillList.Location = New System.Drawing.Point(25, 484)
        Me.dgvBillList.Name = "dgvBillList"
        Me.dgvBillList.RowHeadersWidth = 72
        Me.dgvBillList.RowTemplate.Height = 31
        Me.dgvBillList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBillList.Size = New System.Drawing.Size(626, 420)
        Me.dgvBillList.TabIndex = 91
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(348, 327)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(140, 50)
        Me.btnUpdate.TabIndex = 58
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(186, 327)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(140, 50)
        Me.btnSearch.TabIndex = 57
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(25, 327)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(140, 50)
        Me.btnAdd.TabIndex = 56
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(451, 76)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 41)
        Me.txtName.TabIndex = 5
        '
        'txtPatientID
        '
        Me.txtPatientID.BackColor = System.Drawing.Color.White
        Me.txtPatientID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(451, 18)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(200, 41)
        Me.txtPatientID.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(326, 79)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(106, 33)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'lblPatientID
        '
        Me.lblPatientID.AutoSize = True
        Me.lblPatientID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientID.ForeColor = System.Drawing.Color.White
        Me.lblPatientID.Location = New System.Drawing.Point(272, 21)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(160, 33)
        Me.lblPatientID.TabIndex = 0
        Me.lblPatientID.Text = "Patient ID:"
        '
        'pnl3
        '
        Me.pnl3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl3.Controls.Add(Me.grbMedicineandServices)
        Me.pnl3.Controls.Add(Me.grbPaymentCalculation)
        Me.pnl3.Controls.Add(Me.btnClearAll)
        Me.pnl3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl3.Location = New System.Drawing.Point(679, 97)
        Me.pnl3.Name = "pnl3"
        Me.pnl3.Size = New System.Drawing.Size(730, 1055)
        Me.pnl3.TabIndex = 22
        '
        'grbMedicineandServices
        '
        Me.grbMedicineandServices.Controls.Add(Me.chkPartialHealthCheck)
        Me.grbMedicineandServices.Controls.Add(Me.chkComprehensiveHealthCheck)
        Me.grbMedicineandServices.Controls.Add(Me.chkXRay)
        Me.grbMedicineandServices.Controls.Add(Me.chkLabServices)
        Me.grbMedicineandServices.Controls.Add(Me.chkOneMedicineType)
        Me.grbMedicineandServices.Controls.Add(Me.chkConsultation)
        Me.grbMedicineandServices.Controls.Add(Me.txtOneMedicineType)
        Me.grbMedicineandServices.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbMedicineandServices.ForeColor = System.Drawing.Color.White
        Me.grbMedicineandServices.Location = New System.Drawing.Point(39, 18)
        Me.grbMedicineandServices.Name = "grbMedicineandServices"
        Me.grbMedicineandServices.Size = New System.Drawing.Size(650, 350)
        Me.grbMedicineandServices.TabIndex = 139
        Me.grbMedicineandServices.TabStop = False
        Me.grbMedicineandServices.Text = "Medicine and Services"
        '
        'chkPartialHealthCheck
        '
        Me.chkPartialHealthCheck.AutoSize = True
        Me.chkPartialHealthCheck.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPartialHealthCheck.Location = New System.Drawing.Point(88, 284)
        Me.chkPartialHealthCheck.Name = "chkPartialHealthCheck"
        Me.chkPartialHealthCheck.Size = New System.Drawing.Size(335, 37)
        Me.chkPartialHealthCheck.TabIndex = 151
        Me.chkPartialHealthCheck.Text = "Partial Health Check"
        Me.chkPartialHealthCheck.UseVisualStyleBackColor = True
        '
        'chkComprehensiveHealthCheck
        '
        Me.chkComprehensiveHealthCheck.AutoSize = True
        Me.chkComprehensiveHealthCheck.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComprehensiveHealthCheck.Location = New System.Drawing.Point(88, 236)
        Me.chkComprehensiveHealthCheck.Name = "chkComprehensiveHealthCheck"
        Me.chkComprehensiveHealthCheck.Size = New System.Drawing.Size(466, 37)
        Me.chkComprehensiveHealthCheck.TabIndex = 150
        Me.chkComprehensiveHealthCheck.Text = "Comprehensive Health Check"
        Me.chkComprehensiveHealthCheck.UseVisualStyleBackColor = True
        '
        'chkXRay
        '
        Me.chkXRay.AutoSize = True
        Me.chkXRay.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkXRay.Location = New System.Drawing.Point(88, 189)
        Me.chkXRay.Name = "chkXRay"
        Me.chkXRay.Size = New System.Drawing.Size(129, 37)
        Me.chkXRay.TabIndex = 149
        Me.chkXRay.Text = "X-Ray"
        Me.chkXRay.UseVisualStyleBackColor = True
        '
        'chkLabServices
        '
        Me.chkLabServices.AutoSize = True
        Me.chkLabServices.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLabServices.Location = New System.Drawing.Point(88, 141)
        Me.chkLabServices.Name = "chkLabServices"
        Me.chkLabServices.Size = New System.Drawing.Size(230, 37)
        Me.chkLabServices.TabIndex = 148
        Me.chkLabServices.Text = "Lab Services"
        Me.chkLabServices.UseVisualStyleBackColor = True
        '
        'chkOneMedicineType
        '
        Me.chkOneMedicineType.AutoSize = True
        Me.chkOneMedicineType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOneMedicineType.Location = New System.Drawing.Point(88, 94)
        Me.chkOneMedicineType.Name = "chkOneMedicineType"
        Me.chkOneMedicineType.Size = New System.Drawing.Size(315, 37)
        Me.chkOneMedicineType.TabIndex = 147
        Me.chkOneMedicineType.Text = "One Medicine Type"
        Me.chkOneMedicineType.UseVisualStyleBackColor = True
        '
        'chkConsultation
        '
        Me.chkConsultation.AutoSize = True
        Me.chkConsultation.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConsultation.Location = New System.Drawing.Point(88, 47)
        Me.chkConsultation.Name = "chkConsultation"
        Me.chkConsultation.Size = New System.Drawing.Size(227, 37)
        Me.chkConsultation.TabIndex = 146
        Me.chkConsultation.Text = "Consultation"
        Me.chkConsultation.UseVisualStyleBackColor = True
        '
        'txtOneMedicineType
        '
        Me.txtOneMedicineType.BackColor = System.Drawing.Color.White
        Me.txtOneMedicineType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOneMedicineType.Location = New System.Drawing.Point(434, 92)
        Me.txtOneMedicineType.Name = "txtOneMedicineType"
        Me.txtOneMedicineType.Size = New System.Drawing.Size(120, 41)
        Me.txtOneMedicineType.TabIndex = 141
        '
        'grbPaymentCalculation
        '
        Me.grbPaymentCalculation.Controls.Add(Me.lblTotalAmount)
        Me.grbPaymentCalculation.Controls.Add(Me.btnCalculateTotalAmount)
        Me.grbPaymentCalculation.Controls.Add(Me.txtTotalAmount)
        Me.grbPaymentCalculation.Controls.Add(Me.lblReceivedAmount)
        Me.grbPaymentCalculation.Controls.Add(Me.txtReceivedAmount)
        Me.grbPaymentCalculation.Controls.Add(Me.txtChangeAmount)
        Me.grbPaymentCalculation.Controls.Add(Me.btnCalculateChangeAmount)
        Me.grbPaymentCalculation.Controls.Add(Me.lblChangeAmount)
        Me.grbPaymentCalculation.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbPaymentCalculation.ForeColor = System.Drawing.Color.White
        Me.grbPaymentCalculation.Location = New System.Drawing.Point(39, 409)
        Me.grbPaymentCalculation.Name = "grbPaymentCalculation"
        Me.grbPaymentCalculation.Size = New System.Drawing.Size(650, 400)
        Me.grbPaymentCalculation.TabIndex = 138
        Me.grbPaymentCalculation.TabStop = False
        Me.grbPaymentCalculation.Text = "Payment Calculation"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.White
        Me.lblTotalAmount.Location = New System.Drawing.Point(102, 55)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(285, 33)
        Me.lblTotalAmount.TabIndex = 111
        Me.lblTotalAmount.Text = "Total Amount (RM):"
        '
        'btnCalculateTotalAmount
        '
        Me.btnCalculateTotalAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnCalculateTotalAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateTotalAmount.ForeColor = System.Drawing.Color.White
        Me.btnCalculateTotalAmount.Location = New System.Drawing.Point(96, 247)
        Me.btnCalculateTotalAmount.Name = "btnCalculateTotalAmount"
        Me.btnCalculateTotalAmount.Size = New System.Drawing.Size(450, 50)
        Me.btnCalculateTotalAmount.TabIndex = 100
        Me.btnCalculateTotalAmount.Text = "Calculate Total Amount"
        Me.btnCalculateTotalAmount.UseVisualStyleBackColor = False
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BackColor = System.Drawing.Color.White
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(400, 52)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(200, 41)
        Me.txtTotalAmount.TabIndex = 101
        '
        'lblReceivedAmount
        '
        Me.lblReceivedAmount.AutoSize = True
        Me.lblReceivedAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceivedAmount.ForeColor = System.Drawing.Color.White
        Me.lblReceivedAmount.Location = New System.Drawing.Point(42, 119)
        Me.lblReceivedAmount.Name = "lblReceivedAmount"
        Me.lblReceivedAmount.Size = New System.Drawing.Size(345, 33)
        Me.lblReceivedAmount.TabIndex = 102
        Me.lblReceivedAmount.Text = "Received Amount (RM):"
        '
        'txtReceivedAmount
        '
        Me.txtReceivedAmount.BackColor = System.Drawing.Color.White
        Me.txtReceivedAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceivedAmount.Location = New System.Drawing.Point(400, 116)
        Me.txtReceivedAmount.Name = "txtReceivedAmount"
        Me.txtReceivedAmount.Size = New System.Drawing.Size(200, 41)
        Me.txtReceivedAmount.TabIndex = 103
        '
        'txtChangeAmount
        '
        Me.txtChangeAmount.BackColor = System.Drawing.Color.White
        Me.txtChangeAmount.Enabled = False
        Me.txtChangeAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeAmount.Location = New System.Drawing.Point(400, 180)
        Me.txtChangeAmount.Name = "txtChangeAmount"
        Me.txtChangeAmount.ReadOnly = True
        Me.txtChangeAmount.Size = New System.Drawing.Size(200, 41)
        Me.txtChangeAmount.TabIndex = 104
        '
        'btnCalculateChangeAmount
        '
        Me.btnCalculateChangeAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnCalculateChangeAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateChangeAmount.ForeColor = System.Drawing.Color.White
        Me.btnCalculateChangeAmount.Location = New System.Drawing.Point(96, 315)
        Me.btnCalculateChangeAmount.Name = "btnCalculateChangeAmount"
        Me.btnCalculateChangeAmount.Size = New System.Drawing.Size(450, 50)
        Me.btnCalculateChangeAmount.TabIndex = 105
        Me.btnCalculateChangeAmount.Text = "Calculate Change Amount"
        Me.btnCalculateChangeAmount.UseVisualStyleBackColor = False
        '
        'lblChangeAmount
        '
        Me.lblChangeAmount.AutoSize = True
        Me.lblChangeAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeAmount.ForeColor = System.Drawing.Color.White
        Me.lblChangeAmount.Location = New System.Drawing.Point(64, 183)
        Me.lblChangeAmount.Name = "lblChangeAmount"
        Me.lblChangeAmount.Size = New System.Drawing.Size(323, 33)
        Me.lblChangeAmount.TabIndex = 112
        Me.lblChangeAmount.Text = "Change Amount (RM):"
        '
        'btnClearAll
        '
        Me.btnClearAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnClearAll.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.ForeColor = System.Drawing.Color.White
        Me.btnClearAll.Location = New System.Drawing.Point(276, 844)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(170, 60)
        Me.btnClearAll.TabIndex = 119
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = False
        '
        'pnl4
        '
        Me.pnl4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl4.Controls.Add(Me.btnGenerateReceipt)
        Me.pnl4.Controls.Add(Me.rtfReceipt)
        Me.pnl4.Location = New System.Drawing.Point(1407, 97)
        Me.pnl4.Name = "pnl4"
        Me.pnl4.Size = New System.Drawing.Size(641, 1055)
        Me.pnl4.TabIndex = 23
        '
        'btnGenerateReceipt
        '
        Me.btnGenerateReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnGenerateReceipt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReceipt.ForeColor = System.Drawing.Color.White
        Me.btnGenerateReceipt.Location = New System.Drawing.Point(173, 804)
        Me.btnGenerateReceipt.Name = "btnGenerateReceipt"
        Me.btnGenerateReceipt.Size = New System.Drawing.Size(300, 50)
        Me.btnGenerateReceipt.TabIndex = 120
        Me.btnGenerateReceipt.Text = "Generate Receipt"
        Me.btnGenerateReceipt.UseVisualStyleBackColor = False
        '
        'rtfReceipt
        '
        Me.rtfReceipt.BackColor = System.Drawing.Color.White
        Me.rtfReceipt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfReceipt.Location = New System.Drawing.Point(46, 21)
        Me.rtfReceipt.Name = "rtfReceipt"
        Me.rtfReceipt.ReadOnly = True
        Me.rtfReceipt.Size = New System.Drawing.Size(550, 750)
        Me.rtfReceipt.TabIndex = 0
        Me.rtfReceipt.Text = ""
        '
        'ViewBillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl4)
        Me.Controls.Add(Me.pnl3)
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "ViewBillForm"
        Me.Size = New System.Drawing.Size(2048, 1152)
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.pnl2.ResumeLayout(False)
        Me.pnl2.PerformLayout()
        CType(Me.dgvBillList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl3.ResumeLayout(False)
        Me.grbMedicineandServices.ResumeLayout(False)
        Me.grbMedicineandServices.PerformLayout()
        Me.grbPaymentCalculation.ResumeLayout(False)
        Me.grbPaymentCalculation.PerformLayout()
        Me.pnl4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl1 As Panel
    Friend WithEvents lblBillInfo As Label
    Friend WithEvents pnl2 As Panel
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblPatientID As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDisplayAll As Button
    Friend WithEvents dgvBillList As DataGridView
    Friend WithEvents txtTotalConsultationFee As TextBox
    Friend WithEvents lblTotalConsultationFee As Label
    Friend WithEvents lblTotalMedicationFee As Label
    Friend WithEvents txtTotalMedicationFee As TextBox
    Friend WithEvents lblTotalServiceFee As Label
    Friend WithEvents txtTotalServiceFee As TextBox
    Friend WithEvents pnl3 As Panel
    Friend WithEvents grbMedicineandServices As GroupBox
    Friend WithEvents txtOneMedicineType As TextBox
    Friend WithEvents grbPaymentCalculation As GroupBox
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents btnCalculateTotalAmount As Button
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents lblReceivedAmount As Label
    Friend WithEvents txtReceivedAmount As TextBox
    Friend WithEvents txtChangeAmount As TextBox
    Friend WithEvents btnCalculateChangeAmount As Button
    Friend WithEvents lblChangeAmount As Label
    Friend WithEvents btnClearAll As Button
    Friend WithEvents chkPartialHealthCheck As CheckBox
    Friend WithEvents chkComprehensiveHealthCheck As CheckBox
    Friend WithEvents chkXRay As CheckBox
    Friend WithEvents chkLabServices As CheckBox
    Friend WithEvents chkOneMedicineType As CheckBox
    Friend WithEvents chkConsultation As CheckBox
    Friend WithEvents pnl4 As Panel
    Friend WithEvents rtfReceipt As RichTextBox
    Friend WithEvents btnGenerateReceipt As Button
End Class
