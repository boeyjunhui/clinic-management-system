<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffNurseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffNurseForm))
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.ViewPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrescriptionListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lblWelcomeBackStaffNurse = New System.Windows.Forms.Label()
        Me.lblOCEANACLINIC = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl2
        '
        Me.pnl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl2.Location = New System.Drawing.Point(0, 196)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(2278, 1029)
        Me.pnl2.TabIndex = 3
        '
        'ViewPatientToolStripMenuItem
        '
        Me.ViewPatientToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPatientToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewPatientToolStripMenuItem.Name = "ViewPatientToolStripMenuItem"
        Me.ViewPatientToolStripMenuItem.Size = New System.Drawing.Size(230, 41)
        Me.ViewPatientToolStripMenuItem.Text = "View Patient"
        '
        'ViewBillToolStripMenuItem
        '
        Me.ViewBillToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewBillToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewBillToolStripMenuItem.Name = "ViewBillToolStripMenuItem"
        Me.ViewBillToolStripMenuItem.Size = New System.Drawing.Size(171, 41)
        Me.ViewBillToolStripMenuItem.Text = "View Bill"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(144, 41)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPatientToolStripMenuItem, Me.PrescriptionListToolStripMenuItem, Me.ViewBillToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 151)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(846, 45)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrescriptionListToolStripMenuItem
        '
        Me.PrescriptionListToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrescriptionListToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PrescriptionListToolStripMenuItem.Name = "PrescriptionListToolStripMenuItem"
        Me.PrescriptionListToolStripMenuItem.Size = New System.Drawing.Size(292, 41)
        Me.PrescriptionListToolStripMenuItem.Text = "Prescription List"
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl1.Controls.Add(Me.lblWelcomeBackStaffNurse)
        Me.pnl1.Controls.Add(Me.lblOCEANACLINIC)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(2278, 148)
        Me.pnl1.TabIndex = 19
        '
        'lblWelcomeBackStaffNurse
        '
        Me.lblWelcomeBackStaffNurse.AutoSize = True
        Me.lblWelcomeBackStaffNurse.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeBackStaffNurse.ForeColor = System.Drawing.Color.White
        Me.lblWelcomeBackStaffNurse.Location = New System.Drawing.Point(17, 95)
        Me.lblWelcomeBackStaffNurse.Name = "lblWelcomeBackStaffNurse"
        Me.lblWelcomeBackStaffNurse.Size = New System.Drawing.Size(438, 37)
        Me.lblWelcomeBackStaffNurse.TabIndex = 2
        Me.lblWelcomeBackStaffNurse.Text = "Welcome back, staff nurse!"
        '
        'lblOCEANACLINIC
        '
        Me.lblOCEANACLINIC.AutoSize = True
        Me.lblOCEANACLINIC.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOCEANACLINIC.ForeColor = System.Drawing.Color.White
        Me.lblOCEANACLINIC.Location = New System.Drawing.Point(12, 9)
        Me.lblOCEANACLINIC.Name = "lblOCEANACLINIC"
        Me.lblOCEANACLINIC.Size = New System.Drawing.Size(552, 75)
        Me.lblOCEANACLINIC.TabIndex = 1
        Me.lblOCEANACLINIC.Text = "OCEANA CLINIC"
        '
        'StaffNurseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(2278, 1225)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.pnl2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StaffNurseForm"
        Me.Text = "Staff Nurse"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl2 As Panel
    Friend WithEvents ViewPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewBillToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents pnl1 As Panel
    Friend WithEvents lblWelcomeBackStaffNurse As Label
    Friend WithEvents lblOCEANACLINIC As Label
    Friend WithEvents PrescriptionListToolStripMenuItem As ToolStripMenuItem
End Class
