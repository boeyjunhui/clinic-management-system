<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPrescriptionForm
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
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lblAddPrescription = New System.Windows.Forms.Label()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.btnDisplayAll = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvPrescriptionList = New System.Windows.Forms.DataGridView()
        Me.txtPrescription = New System.Windows.Forms.TextBox()
        Me.txtDisease = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.lblPrescription = New System.Windows.Forms.Label()
        Me.lblDisease = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.pnl1.SuspendLayout()
        Me.pnl2.SuspendLayout()
        CType(Me.dgvPrescriptionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl1.Controls.Add(Me.lblAddPrescription)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(1920, 99)
        Me.pnl1.TabIndex = 21
        '
        'lblAddPrescription
        '
        Me.lblAddPrescription.AutoSize = True
        Me.lblAddPrescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddPrescription.ForeColor = System.Drawing.Color.White
        Me.lblAddPrescription.Location = New System.Drawing.Point(26, 30)
        Me.lblAddPrescription.Name = "lblAddPrescription"
        Me.lblAddPrescription.Size = New System.Drawing.Size(322, 43)
        Me.lblAddPrescription.TabIndex = 0
        Me.lblAddPrescription.Text = "Add Prescription"
        '
        'pnl2
        '
        Me.pnl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl2.Controls.Add(Me.btnDisplayAll)
        Me.pnl2.Controls.Add(Me.btnDelete)
        Me.pnl2.Controls.Add(Me.btnUpdate)
        Me.pnl2.Controls.Add(Me.btnSearch)
        Me.pnl2.Controls.Add(Me.btnAdd)
        Me.pnl2.Controls.Add(Me.dgvPrescriptionList)
        Me.pnl2.Controls.Add(Me.txtPrescription)
        Me.pnl2.Controls.Add(Me.txtDisease)
        Me.pnl2.Controls.Add(Me.txtName)
        Me.pnl2.Controls.Add(Me.txtPatientID)
        Me.pnl2.Controls.Add(Me.lblPrescription)
        Me.pnl2.Controls.Add(Me.lblDisease)
        Me.pnl2.Controls.Add(Me.lblName)
        Me.pnl2.Controls.Add(Me.lblPatientID)
        Me.pnl2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl2.Location = New System.Drawing.Point(0, 99)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(1920, 981)
        Me.pnl2.TabIndex = 22
        '
        'btnDisplayAll
        '
        Me.btnDisplayAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDisplayAll.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayAll.ForeColor = System.Drawing.Color.White
        Me.btnDisplayAll.Location = New System.Drawing.Point(930, 30)
        Me.btnDisplayAll.Name = "btnDisplayAll"
        Me.btnDisplayAll.Size = New System.Drawing.Size(218, 52)
        Me.btnDisplayAll.TabIndex = 75
        Me.btnDisplayAll.Text = "Display All"
        Me.btnDisplayAll.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(691, 506)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(164, 52)
        Me.btnDelete.TabIndex = 61
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(501, 506)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(164, 52)
        Me.btnUpdate.TabIndex = 60
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(310, 506)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(164, 52)
        Me.btnSearch.TabIndex = 59
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(122, 506)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(164, 52)
        Me.btnAdd.TabIndex = 58
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'dgvPrescriptionList
        '
        Me.dgvPrescriptionList.BackgroundColor = System.Drawing.Color.White
        Me.dgvPrescriptionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrescriptionList.Location = New System.Drawing.Point(930, 107)
        Me.dgvPrescriptionList.Name = "dgvPrescriptionList"
        Me.dgvPrescriptionList.RowHeadersWidth = 72
        Me.dgvPrescriptionList.RowTemplate.Height = 31
        Me.dgvPrescriptionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrescriptionList.Size = New System.Drawing.Size(873, 451)
        Me.dgvPrescriptionList.TabIndex = 57
        '
        'txtPrescription
        '
        Me.txtPrescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrescription.Location = New System.Drawing.Point(415, 336)
        Me.txtPrescription.Multiline = True
        Me.txtPrescription.Name = "txtPrescription"
        Me.txtPrescription.Size = New System.Drawing.Size(400, 120)
        Me.txtPrescription.TabIndex = 7
        '
        'txtDisease
        '
        Me.txtDisease.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisease.Location = New System.Drawing.Point(415, 184)
        Me.txtDisease.Multiline = True
        Me.txtDisease.Name = "txtDisease"
        Me.txtDisease.Size = New System.Drawing.Size(400, 120)
        Me.txtDisease.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(415, 107)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(400, 45)
        Me.txtName.TabIndex = 5
        '
        'txtPatientID
        '
        Me.txtPatientID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(415, 30)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(400, 45)
        Me.txtPatientID.TabIndex = 4
        '
        'lblPrescription
        '
        Me.lblPrescription.AutoSize = True
        Me.lblPrescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrescription.ForeColor = System.Drawing.Color.White
        Me.lblPrescription.Location = New System.Drawing.Point(146, 339)
        Me.lblPrescription.Name = "lblPrescription"
        Me.lblPrescription.Size = New System.Drawing.Size(218, 37)
        Me.lblPrescription.TabIndex = 3
        Me.lblPrescription.Text = "Prescription:"
        '
        'lblDisease
        '
        Me.lblDisease.AutoSize = True
        Me.lblDisease.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisease.ForeColor = System.Drawing.Color.White
        Me.lblDisease.Location = New System.Drawing.Point(213, 187)
        Me.lblDisease.Name = "lblDisease"
        Me.lblDisease.Size = New System.Drawing.Size(151, 37)
        Me.lblDisease.TabIndex = 2
        Me.lblDisease.Text = "Disease:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(247, 110)
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
        Me.lblPatientID.Location = New System.Drawing.Point(186, 33)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(178, 37)
        Me.lblPatientID.TabIndex = 0
        Me.lblPatientID.Text = "Patient ID:"
        '
        'AddPrescriptionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "AddPrescriptionForm"
        Me.Size = New System.Drawing.Size(1920, 1080)
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.pnl2.ResumeLayout(False)
        Me.pnl2.PerformLayout()
        CType(Me.dgvPrescriptionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl1 As Panel
    Friend WithEvents lblAddPrescription As Label
    Friend WithEvents pnl2 As Panel
    Friend WithEvents lblPrescription As Label
    Friend WithEvents lblDisease As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPatientID As Label
    Friend WithEvents txtPrescription As TextBox
    Friend WithEvents txtDisease As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents dgvPrescriptionList As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDisplayAll As Button
End Class
