Imports System.Data.SqlClient

Public Class ViewStaffNurseForm

    Private Shared _instance As ViewStaffNurseForm
    Public Shared ReadOnly Property Instance() As ViewStaffNurseForm
        Get
            If _instance Is Nothing Then
                _instance = New ViewStaffNurseForm()
            End If
            Return _instance
        End Get
    End Property

    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\OceanaClinicManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    Dim command As New SqlCommand

    Dim query As String

    Public Sub display_data()

        query = "SELECT * FROM StaffNurse"

        command = connection.CreateCommand()
        Command.CommandType = CommandType.Text
        command.CommandText = "SELECT * FROM StaffNurse"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Dim adapter As New SqlDataAdapter(Command)

        Dim table As New DataTable()

        adapter.Fill(table)

        dgvStaffNurseList.DataSource = table

    End Sub

    Private Sub ViewStaffNurseForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        display_data()

    End Sub

    Private Sub dgvStaffNurseList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaffNurseList.CellClick

        Try
            txtStaffNurseID.Text = dgvStaffNurseList.Rows(dgvStaffNurseList.CurrentRow.Index).Cells(0).Value
            txtName.Text = dgvStaffNurseList.Rows(dgvStaffNurseList.CurrentRow.Index).Cells(1).Value
            If dgvStaffNurseList.CurrentRow.Cells(2).Value.Equals("Male") Then
                radMale.Checked = True
            End If
            If dgvStaffNurseList.CurrentRow.Cells(2).Value.Equals("Female") Then
                radFemale.Checked = True
            End If
            txtContactNumber.Text = dgvStaffNurseList.Rows(dgvStaffNurseList.CurrentRow.Index).Cells(3).Value
            txtAddress.Text = dgvStaffNurseList.Rows(dgvStaffNurseList.CurrentRow.Index).Cells(4).Value
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        connection.Open()

        query = "INSERT INTO StaffNurse (StaffNurseID, Name, Gender, ContactNumber, Address) VALUES (@staffnurseid, @name, @gender, @contactnumber, @address)"

        Dim gender As String = ""

        If radMale.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@staffnurseid", SqlDbType.NVarChar).Value = txtStaffNurseID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text
        command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender
        command.Parameters.Add("@contactnumber", SqlDbType.NVarChar).Value = txtContactNumber.Text
        command.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtAddress.Text

        Try
            If txtStaffNurseID.Text = "" Or txtName.Text = "" Or txtContactNumber.Text = "" Or txtAddress.Text = "" Then
                MsgBox("Please fill in all details", MessageBoxIcon.Warning, "Add Failed")
            ElseIf IsNumeric(txtContactNumber.Text) = False Then
                MsgBox("Only number input is allowed for contact number", MessageBoxIcon.Error, "Add Failed")
                txtContactNumber.Focus()
            Else
                command.ExecuteNonQuery()
                MsgBox("New staff nurse is added", MessageBoxIcon.Information, "Staff Nurse Added")
                txtStaffNurseID.Text = ""
                txtName.Text = ""
                radMale.Checked = False
                radFemale.Checked = False
                txtContactNumber.Text = ""
                txtAddress.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Staff Nurse ID is already exist", MessageBoxIcon.Error, "Add Failed")
        End Try

        connection.Close()

        display_data()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click


        query = "SELECT * FROM StaffNurse WHERE StaffNurseID = @staffnurseid OR Name = @name"

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@staffnurseid", SqlDbType.NVarChar).Value = txtStaffNurseID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text

        If txtStaffNurseID.Text = "" And txtName.Text = "" Then
            MsgBox("Please fill in Staff Nurse ID or Name", MessageBoxIcon.Warning, "Search Failed")
            txtStaffNurseID.Focus()
        Else
            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)

            dgvStaffNurseList.DataSource = table

            txtStaffNurseID.Text = ""
            txtName.Text = ""
            radMale.Checked = False
            radFemale.Checked = False
            txtContactNumber.Text = ""
            txtAddress.Text = ""
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        connection.Open()

        query = "UPDATE StaffNurse SET Name = @name, Gender = @gender, ContactNumber = @contactnumber, Address = @address WHERE StaffNurseID = @staffnurseid"

        Dim gender As String = ""

        If radMale.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@staffnurseid", SqlDbType.NVarChar).Value = txtStaffNurseID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text
        command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender
        command.Parameters.Add("@contactnumber", SqlDbType.NVarChar).Value = txtContactNumber.Text
        command.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtAddress.Text

        If txtStaffNurseID.Text = "" Or txtName.Text = "" Or txtContactNumber.Text = "" Or txtAddress.Text = "" Then
                MsgBox("Please fill in all details", MessageBoxIcon.Warning, "Update Failed")
            ElseIf IsNumeric(txtContactNumber.Text) = False Then
                MsgBox("Only number input is allowed for contact number", MessageBoxIcon.Error, "Update Failed")
                txtContactNumber.Focus()
            Else
                Select Case MessageBox.Show("Are Your Sure?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    Case MsgBoxResult.Yes
                        If vbYes Then
                            command.ExecuteNonQuery()
                            MsgBox("Record updated successfully", MessageBoxIcon.Information, "Record Updated")
                            txtStaffNurseID.Text = ""
                            txtName.Text = ""
                            radMale.Checked = False
                            radFemale.Checked = False
                            txtContactNumber.Text = ""
                            txtAddress.Text = ""
                        End If
                    Case MsgBoxResult.No
                End Select
            End If

            connection.Close()

            display_data()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        connection.Open()

        query = "DELETE FROM StaffNurse WHERE StaffNurseID = @staffnurseid"

        Dim gender As String = ""

        If radMale.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@staffnurseid", SqlDbType.NVarChar).Value = txtStaffNurseID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text
        command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender
        command.Parameters.Add("@contactnumber", SqlDbType.NVarChar).Value = txtContactNumber.Text
        command.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtAddress.Text

        If txtStaffNurseID.Text = "" Or txtName.Text = "" Or txtContactNumber.Text = "" Or txtAddress.Text = "" Then
            MsgBox("Please fill in all details", MessageBoxIcon.Warning, "Delete Failed")
        ElseIf IsNumeric(txtContactNumber.Text) = False Then
            MsgBox("Only number input is allowed for contact number", MessageBoxIcon.Error, "Delete Failed")
            txtContactNumber.Focus()
        Else
            Select Case MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case MsgBoxResult.Yes
                    If vbYes Then
                        command.ExecuteNonQuery()
                        MsgBox("Record deleted successfully", MessageBoxIcon.Information, "Record Deleted")
                        txtStaffNurseID.Text = ""
                        txtName.Text = ""
                        radMale.Checked = False
                        radFemale.Checked = False
                        txtContactNumber.Text = ""
                        txtAddress.Text = ""
                    End If
                Case MsgBoxResult.No
            End Select
        End If

        connection.Close()

        display_data()

    End Sub

    Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click

        display_data()

        txtStaffNurseID.Text = ""
        txtName.Text = ""
        radMale.Checked = False
        radFemale.Checked = False
        txtContactNumber.Text = ""
        txtAddress.Text = ""

    End Sub

End Class
