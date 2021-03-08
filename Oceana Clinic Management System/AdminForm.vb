Imports System.ComponentModel

Public Class AdminForm

    Private Sub UserAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserAccountToolStripMenuItem.Click

        If Not pnl2.Controls.Contains(UserAccountForm.Instance) Then
            pnl2.Controls.Add(UserAccountForm.Instance)
            UserAccountForm.Instance.Dock = DockStyle.Fill
            UserAccountForm.Instance.BringToFront()
            UserAccountForm.Instance.Visible = True
        End If
        UserAccountForm.Instance.BringToFront()
        UserAccountForm.Instance.Visible = True

    End Sub

    Private Sub ViewStaffNurseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStaffNurseToolStripMenuItem.Click

        If Not pnl2.Controls.Contains(ViewStaffNurseForm.Instance) Then
            pnl2.Controls.Add(ViewStaffNurseForm.Instance)
            ViewStaffNurseForm.Instance.Dock = DockStyle.Fill
            ViewStaffNurseForm.Instance.BringToFront()
            ViewStaffNurseForm.Instance.Visible = True
        End If
        ViewStaffNurseForm.Instance.BringToFront()
        ViewStaffNurseForm.Instance.Visible = True

    End Sub

    Private Sub ViewDoctorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDoctorToolStripMenuItem.Click

        If Not pnl2.Controls.Contains(ViewDoctorForm.Instance) Then
            pnl2.Controls.Add(ViewDoctorForm.Instance)
            ViewDoctorForm.Instance.Dock = DockStyle.Fill
            ViewDoctorForm.Instance.BringToFront()
            ViewDoctorForm.Instance.Visible = True
        End If
        ViewDoctorForm.Instance.BringToFront()
        ViewDoctorForm.Instance.Visible = True

    End Sub

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

    Private Sub AdminForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dim dialog As DialogResult

        dialog = MessageBox.Show("Are You Sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub

End Class
