<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DoctorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPrescriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lblWelcomeBackdoctor = New System.Windows.Forms.Label()
        Me.lblOCEANACLINIC = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPatientToolStripMenuItem, Me.AddPrescriptionToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 151)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(682, 45)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewPatientToolStripMenuItem
        '
        Me.ViewPatientToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPatientToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewPatientToolStripMenuItem.Name = "ViewPatientToolStripMenuItem"
        Me.ViewPatientToolStripMenuItem.Size = New System.Drawing.Size(230, 41)
        Me.ViewPatientToolStripMenuItem.Text = "View Patient"
        '
        'AddPrescriptionToolStripMenuItem
        '
        Me.AddPrescriptionToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPrescriptionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AddPrescriptionToolStripMenuItem.Name = "AddPrescriptionToolStripMenuItem"
        Me.AddPrescriptionToolStripMenuItem.Size = New System.Drawing.Size(299, 41)
        Me.AddPrescriptionToolStripMenuItem.Text = "Add Prescription"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(144, 41)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'pnl2
        '
        Me.pnl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl2.Location = New System.Drawing.Point(0, 196)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(1896, 820)
        Me.pnl2.TabIndex = 3
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnl1.Controls.Add(Me.lblWelcomeBackdoctor)
        Me.pnl1.Controls.Add(Me.lblOCEANACLINIC)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(1896, 148)
        Me.pnl1.TabIndex = 20
        '
        'lblWelcomeBackdoctor
        '
        Me.lblWelcomeBackdoctor.AutoSize = True
        Me.lblWelcomeBackdoctor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeBackdoctor.ForeColor = System.Drawing.Color.White
        Me.lblWelcomeBackdoctor.Location = New System.Drawing.Point(17, 95)
        Me.lblWelcomeBackdoctor.Name = "lblWelcomeBackdoctor"
        Me.lblWelcomeBackdoctor.Size = New System.Drawing.Size(375, 37)
        Me.lblWelcomeBackdoctor.TabIndex = 2
        Me.lblWelcomeBackdoctor.Text = "Welcome back, doctor!"
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
        'DoctorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1896, 1016)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.pnl2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DoctorForm"
        Me.Text = "Doctor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddPrescriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnl2 As Panel
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnl1 As Panel
    Friend WithEvents lblWelcomeBackdoctor As Label
    Friend WithEvents lblOCEANACLINIC As Label
    Friend WithEvents ViewPatientToolStripMenuItem As ToolStripMenuItem
End Class
