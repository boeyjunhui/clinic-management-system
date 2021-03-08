Imports System.ComponentModel

Public Class StaffNurseForm

    Private Sub ViewPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPatientToolStripMenuItem.Click

        If Not pnl2.Controls.Contains(ViewPatientForm.Instance) Then
            pnl2.Controls.Add(ViewPatientForm.Instance)
            ViewPatientForm.Instance.Dock = DockStyle.Fill
            ViewPatientForm.Instance.BringToFront()
            ViewPatientForm.Instance.Visible = True
        End If
        ViewPatientForm.Instance.BringToFront()
        ViewPatientForm.Instance.Visible = True

    End Sub

    Private Sub PrescriptionListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrescriptionListToolStripMenuItem.Click

        If Not pnl2.Controls.Contains(PrescriptionListForm.Instance) Then
            pnl2.Controls.Add(PrescriptionListForm.Instance)
            PrescriptionListForm.Instance.Dock = DockStyle.Fill
            PrescriptionListForm.Instance.BringToFront()
            PrescriptionListForm.Instance.Visible = True
        End If
        PrescriptionListForm.Instance.BringToFront()
        PrescriptionListForm.Instance.Visible = True

    End Sub

    Private Sub ViewBillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBillToolStripMenuItem.Click

        If Not pnl2.Controls.Contains(ViewBillForm.Instance) Then
            pnl2.Controls.Add(ViewBillForm.Instance)
            ViewBillForm.Instance.Dock = DockStyle.Fill
            ViewBillForm.Instance.BringToFront()
            ViewBillForm.Instance.Visible = True
        End If
        ViewBillForm.Instance.BringToFront()
        ViewBillForm.Instance.Visible = True

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        Select Case MessageBox.Show("Are You Sure?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case MsgBoxResult.Yes
                If vbYes Then
                    LoginForm.Show()
                    Me.Hide()
                End If
            Case MsgBoxResult.No
        End Select

    End Sub

    Private Sub StaffNurseForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dim dialog As DialogResult

        dialog = MessageBox.Show("Are You Sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub

End Class
