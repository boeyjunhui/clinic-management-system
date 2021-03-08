<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrescriptionListForm
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
        Me.lblPrescriptionList = New System.Windows.Forms.Label()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.btnDisplayAll = New System.Windows.Forms.Button()
        Me.txtPatientIDName = New System.Windows.Forms.TextBox()
        Me.lblPatientIDName = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvPrescriptionList = New System.Windows.Forms.DataGridView()
        Me.pnl1.SuspendLayout()
        Me.pnl2.SuspendLayout()
        CType(Me.dgvPrescriptionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl1.Controls.Add(Me.lblPrescriptionList)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(1920, 99)
        Me.pnl1.TabIndex = 22
        '
        'lblPrescriptionList
        '
        Me.lblPrescriptionList.AutoSize = True
        Me.lblPrescriptionList.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrescriptionList.ForeColor = System.Drawing.Color.White
        Me.lblPrescriptionList.Location = New System.Drawing.Point(26, 30)
        Me.lblPrescriptionList.Name = "lblPrescriptionList"
        Me.lblPrescriptionList.Size = New System.Drawing.Size(314, 43)
        Me.lblPrescriptionList.TabIndex = 0
        Me.lblPrescriptionList.Text = "Prescription List"
        '
        'pnl2
        '
        Me.pnl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl2.Controls.Add(Me.btnDisplayAll)
        Me.pnl2.Controls.Add(Me.txtPatientIDName)
        Me.pnl2.Controls.Add(Me.lblPatientIDName)
        Me.pnl2.Controls.Add(Me.btnSearch)
        Me.pnl2.Controls.Add(Me.dgvPrescriptionList)
        Me.pnl2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl2.Location = New System.Drawing.Point(0, 98)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(1920, 982)
        Me.pnl2.TabIndex = 23
        '
        'btnDisplayAll
        '
        Me.btnDisplayAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDisplayAll.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayAll.ForeColor = System.Drawing.Color.White
        Me.btnDisplayAll.Location = New System.Drawing.Point(469, 112)
        Me.btnDisplayAll.Name = "btnDisplayAll"
        Me.btnDisplayAll.Size = New System.Drawing.Size(220, 50)
        Me.btnDisplayAll.TabIndex = 31
        Me.btnDisplayAll.Text = "Display All"
        Me.btnDisplayAll.UseVisualStyleBackColor = False
        '
        'txtPatientIDName
        '
        Me.txtPatientIDName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientIDName.Location = New System.Drawing.Point(875, 27)
        Me.txtPatientIDName.Name = "txtPatientIDName"
        Me.txtPatientIDName.Size = New System.Drawing.Size(272, 45)
        Me.txtPatientIDName.TabIndex = 30
        '
        'lblPatientIDName
        '
        Me.lblPatientIDName.AutoSize = True
        Me.lblPatientIDName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientIDName.ForeColor = System.Drawing.Color.White
        Me.lblPatientIDName.Location = New System.Drawing.Point(564, 31)
        Me.lblPatientIDName.Name = "lblPatientIDName"
        Me.lblPatientIDName.Size = New System.Drawing.Size(293, 37)
        Me.lblPatientIDName.TabIndex = 29
        Me.lblPatientIDName.Text = "Patient ID / Name:"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(1181, 27)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(180, 50)
        Me.btnSearch.TabIndex = 28
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'dgvPrescriptionList
        '
        Me.dgvPrescriptionList.BackgroundColor = System.Drawing.Color.White
        Me.dgvPrescriptionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrescriptionList.Location = New System.Drawing.Point(469, 182)
        Me.dgvPrescriptionList.Name = "dgvPrescriptionList"
        Me.dgvPrescriptionList.RowHeadersWidth = 72
        Me.dgvPrescriptionList.RowTemplate.Height = 31
        Me.dgvPrescriptionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrescriptionList.Size = New System.Drawing.Size(1000, 450)
        Me.dgvPrescriptionList.TabIndex = 27
        '
        'PrescriptionListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "PrescriptionListForm"
        Me.Size = New System.Drawing.Size(1920, 1080)
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.pnl2.ResumeLayout(False)
        Me.pnl2.PerformLayout()
        CType(Me.dgvPrescriptionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl1 As Panel
    Friend WithEvents lblPrescriptionList As Label
    Friend WithEvents pnl2 As Panel
    Friend WithEvents txtPatientIDName As TextBox
    Friend WithEvents lblPatientIDName As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvPrescriptionList As DataGridView
    Friend WithEvents btnDisplayAll As Button
End Class
