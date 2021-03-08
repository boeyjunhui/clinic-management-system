Imports System.ComponentModel

Public Class DoctorForm

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

    Private Sub AddPrescriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPrescriptionToolStripMenuItem.Click

        If Not pnl2.Controls.Contains(AddPrescriptionForm.Instance) Then
            pnl2.Controls.Add(AddPrescriptionForm.Instance)
            AddPrescriptionForm.Instance.Dock = DockStyle.Fill
            AddPrescriptionForm.Instance.BringToFront()
            AddPrescriptionForm.Instance.Visible = True
        End If
        AddPrescriptionForm.Instance.BringToFront()
        AddPrescriptionForm.Instance.Visible = True

    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        Select Case MessageBox.Show("Are You Sure?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case MsgBoxResult.Yes
                If vbYes Then
                    LoginForm.Show()
                    Me.Hide()
                End If
            Case MsgBoxResult.No
        End Select

    End Sub

    Private Sub DoctorForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dim dialog As DialogResult

        dialog = MessageBox.Show("Are You Sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub

End Class
