Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class LoginForm

    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boey Jun Hui\OneDrive - Asia Pacific University\Visual Basic .NET (VBN)\Assignment\OceanaClinicManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    Dim command As New SqlCommand

    Dim query As String

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        MaximizeBox = False

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        connection.open()

        query = "SELECT * FROM UserAccount WHERE UserID = @userid AND Password = @password AND UserType = @usertype"

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@userid", SqlDbType.NVarChar).Value = txtUserID.Text
        command.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPassword.Text
        command.Parameters.Add("@usertype", SqlDbType.NVarChar).Value = cboUserType.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            If cboUserType.SelectedIndex = 0 Then
                AdminForm.Show()
                Me.Hide()
                txtUserID.Text = ""
                txtPassword.Text = ""
                cboUserType.SelectedIndex = -1
            ElseIf cboUserType.SelectedIndex = 1 Then
                StaffNurseForm.Show()
                Me.Hide()
                txtUserID.Text = ""
                txtPassword.Text = ""
                cboUserType.SelectedIndex = -1
            Else
                DoctorForm.Show()
                Me.Hide()
                txtUserID.Text = ""
                txtPassword.Text = ""
                cboUserType.SelectedIndex = -1
            End If
        ElseIf txtUserID.Text = "" Or txtPassword.Text = "" Or cboUserType.SelectedItem = String.Empty Then
            MsgBox("Please fill in all details", MessageBoxIcon.Warning, "Error")
        Else
            MsgBox("User ID or Password or User Type are invalid", MessageBoxIcon.Error, "Login Failed")
        End If

        connection.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Select Case MsgBox("Are You Sure?", MsgBoxStyle.YesNo, "Logout")
            Case MsgBoxResult.Yes
                If vbYes Then
                    Application.Exit()
                End If
            Case MsgBoxResult.No
        End Select

    End Sub

    Private Sub LoginForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dim dialog As DialogResult
        dialog = MsgBox("Are You Sure?", MsgBoxStyle.YesNo, "Exit")
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub

End Class