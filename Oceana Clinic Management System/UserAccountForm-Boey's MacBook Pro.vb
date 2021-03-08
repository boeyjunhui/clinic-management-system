Imports System.Data.SqlClient

Public Class UserAccountForm

    Private Shared _instance As UserAccountForm
    Public Shared ReadOnly Property Instance() As UserAccountForm
        Get
            If _instance Is Nothing Then
                _instance = New UserAccountForm
            End If
            Return _instance
        End Get
    End Property

    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boey Jun Hui\OneDrive - Asia Pacific University\Visual Basic .NET (VBN)\Assignment\OceanaClinicManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    Dim command As New SqlCommand

    Dim query As String

    Public Sub display_data()

        query = "SELECT UserID, UserType FROM UserAccount"

        command = connection.CreateCommand()
        command.CommandType = CommandType.Text
        command.CommandText = "SELECT UserID, UserType FROM UserAccount"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        dgvUserAccountList.DataSource = table

    End Sub

    Private Sub UserAccountForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        display_data()

    End Sub

    Private Sub dgvUserAccountList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserAccountList.CellClick

        Try
            txtUserID.Text = dgvUserAccountList.Rows(dgvUserAccountList.CurrentRow.Index).Cells(0).Value
            cboUserType.Text = dgvUserAccountList.Rows(dgvUserAccountList.CurrentRow.Index).Cells(1).Value
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnCreateNewAccount_Click(sender As Object, e As EventArgs) Handles btnCreateNewAccount.Click

        connection.Open()

        query = "INSERT INTO UserAccount (UserID, Password, UserType) VALUES (@userid, @password, @usertype)"

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@userid", SqlDbType.NVarChar).Value = txtUserID.Text
        command.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPassword.Text
        command.Parameters.Add("@usertype", SqlDbType.NVarChar).Value = cboUserType.SelectedItem

        Try
            If txtUserID.Text = "" Or txtPassword.Text = "" Or cboUserType.SelectedItem = String.Empty Then
                MsgBox("Please fill in all details", MessageBoxIcon.Warning, "Error")
            Else
                command.ExecuteNonQuery()
                MsgBox("New user account created", MessageBoxIcon.Information, "Account Created")
                txtUserID.Text = ""
                txtPassword.Text = ""
                cboUserType.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox("User ID is already exist", MessageBoxIcon.Error, "Create Failed")
        End Try

        connection.Close()

        display_data()

    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click

        connection.Open()

        query = "UPDATE UserAccount SET Password = @password WHERE UserID = @userid"

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@userid", SqlDbType.NVarChar).Value = txtUserID.Text
        command.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPassword.Text

        If txtUserID.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please fill in User ID and new password to change password", MessageBoxIcon.Warning, "Error")
            txtUserID.Focus()
        Else
            Select Case MsgBox("Are You Sure?", MessageBoxButtons.YesNo, "Change Password")
                Case MsgBoxResult.Yes
                    If vbYes Then
                        command.ExecuteNonQuery()
                        MsgBox("Password changed successfully", MessageBoxIcon.Information, "Password Changed")
                        txtUserID.Text = ""
                        txtPassword.Text = ""
                        cboUserType.SelectedIndex = -1
                    End If
                Case MsgBoxResult.No
            End Select
        End If

        connection.Close()

        display_data()

    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click

        connection.Open()

        query = "DELETE FROM UserAccount WHERE UserID = @userid"

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@userid", SqlDbType.NVarChar).Value = txtUserID.Text
        command.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPassword.Text

        If txtUserID.Text = "" Then
            MsgBox("Please fill in User ID", MessageBoxIcon.Warning, "Error")
            txtUserID.Focus()
        Else
            Select Case MsgBox("Are You Sure?", MessageBoxButtons.YesNo, "Delete")
                Case MsgBoxResult.Yes
                    If vbYes Then
                        command.ExecuteNonQuery()
                        MsgBox("User deleted successfully", MessageBoxIcon.Information, "User Account Deleted")
                        txtUserID.Text = ""
                        txtPassword.Text = ""
                        cboUserType.SelectedIndex = -1
                    End If
                Case MsgBoxResult.No
            End Select
        End If

        connection.Close()

        display_data()

    End Sub

End Class
