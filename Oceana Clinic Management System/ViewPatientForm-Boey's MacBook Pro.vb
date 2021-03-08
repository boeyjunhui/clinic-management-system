Imports System.Data.SqlClient

Public Class ViewPatientForm

    Private Shared _instance As ViewPatientForm
    Public Shared ReadOnly Property Instance() As ViewPatientForm
        Get
            If _instance Is Nothing Then
                _instance = New ViewPatientForm()
            End If
            Return _instance
        End Get
    End Property

    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boey Jun Hui\OneDrive - Asia Pacific University\Visual Basic .NET (VBN)\Assignment\OceanaClinicManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    Dim command As New SqlCommand

    Dim query As String

    Public Sub display_data()

        query = "SELECT * FROM Patient"

        command = connection.CreateCommand()
        command.CommandType = CommandType.Text
        command.CommandText = "SELECT * FROM Patient"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        dgvPatientList.DataSource = table

    End Sub

    Private Sub ViewPatientForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        display_data()

    End Sub

    Private Sub dgvPatientList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatientList.CellClick

        Try
            txtPatientID.Text = dgvPatientList.Rows(dgvPatientList.CurrentRow.Index).Cells(0).Value
            txtName.Text = dgvPatientList.Rows(dgvPatientList.CurrentRow.Index).Cells(1).Value
            If dgvPatientList.CurrentRow.Cells(2).Value.Equals("Male") Then
                radMale.Checked = True
            End If
            If dgvPatientList.CurrentRow.Cells(2).Value.Equals("Female") Then
                radFemale.Checked = True
            End If
            txtNRICPassportNumber.Text = dgvPatientList.Rows(dgvPatientList.CurrentRow.Index).Cells(3).Value
            txtContactNumber.Text = dgvPatientList.Rows(dgvPatientList.CurrentRow.Index).Cells(4).Value
            txtEmail.Text = dgvPatientList.Rows(dgvPatientList.CurrentRow.Index).Cells(5).Value
            txtAddress.Text = dgvPatientList.Rows(dgvPatientList.CurrentRow.Index).Cells(6).Value
            txtWeight.Text = dgvPatientList.Rows(dgvPatientList.CurrentRow.Index).Cells(7).Value
            txtHeight.Text = dgvPatientList.Rows(dgvPatientList.CurrentRow.Index).Cells(8).Value
            txtBloodType.Text = dgvPatientList.Rows(dgvPatientList.CurrentRow.Index).Cells(9).Value
            txtAllergies.Text = dgvPatientList.Rows(dgvPatientList.CurrentRow.Index).Cells(10).Value
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        connection.Open()

        query = "INSERT INTO Patient (PatientID, Name, Gender, NRICPassportNumber, ContactNumber, Email, Address, Weight, Height, BloodType, Allergies) VALUES (@patientid, @name, @gender, @nricpassportnumber, @contactnumber, @email, @address, @weight, @height, @bloodtype, @allergies)"

        Dim gender As String = ""

        If radMale.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@patientid", SqlDbType.NVarChar).Value = txtPatientID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text
        command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender
        command.Parameters.Add("@nricpassportnumber", SqlDbType.NVarChar).Value = txtNRICPassportNumber.Text
        command.Parameters.Add("@contactnumber", SqlDbType.NVarChar).Value = txtContactNumber.Text
        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmail.Text
        command.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtAddress.Text
        command.Parameters.Add("@weight", SqlDbType.Int).Value = txtWeight.Text
        command.Parameters.Add("@height", SqlDbType.Int).Value = txtHeight.Text
        command.Parameters.Add("@bloodtype", SqlDbType.NVarChar).Value = txtBloodType.Text
        command.Parameters.Add("@allergies", SqlDbType.NVarChar).Value = txtAllergies.Text

        Try
            If txtPatientID.Text = "" Or txtName.Text = "" Or txtNRICPassportNumber.Text = "" Or txtContactNumber.Text = "" Or txtEmail.Text = "" Or txtAddress.Text = "" Or txtWeight.Text = "" Or txtHeight.Text = "" Or txtBloodType.Text = "" Or txtAllergies.Text = "" Then
                MsgBox("Please fill in all details", MessageBoxIcon.Warning, "Error")
            ElseIf IsNumeric(txtContactNumber.Text) = False Then
                MsgBox("Only number input is allowed for contact number", MessageBoxIcon.Error, "Add Failed")
                ElseIf IsNumeric(txtWeight.Text) = False Or IsNumeric(txtHeight.Text) = False Then
                MsgBox("Only number input is allowed for weight and height", MessageBoxIcon.Error, "Add Failed")
            Else
                command.ExecuteNonQuery()
                MsgBox("New patient is added", MessageBoxIcon.Information, "Patient Added")
                txtPatientID.Text = ""
                txtName.Text = ""
                radMale.Checked = False
                radFemale.Checked = False
                txtNRICPassportNumber.Text = ""
                txtContactNumber.Text = ""
                txtEmail.Text = ""
                txtAddress.Text = ""
                txtWeight.Text = ""
                txtHeight.Text = ""
                txtBloodType.Text = ""
                txtAllergies.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Patient ID is already exist", MessageBoxIcon.Error, "Add Failed")
        End Try

        connection.Close()

        display_data()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        query = "SELECT * FROM Patient WHERE PatientID = @patientid OR Name = @name"

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@patientid", SqlDbType.NVarChar).Value = txtPatientID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text

        If txtPatientID.Text = "" And txtName.Text = "" Then
            MsgBox("Please fill in Patient ID or Name", MessageBoxIcon.Warning, "Error")
            txtPatientID.Focus()
        Else
            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)

            dgvPatientList.DataSource = table

            txtPatientID.Text = ""
            txtName.Text = ""
            radMale.Checked = False
            radFemale.Checked = False
            txtNRICPassportNumber.Text = ""
            txtContactNumber.Text = ""
            txtEmail.Text = ""
            txtAddress.Text = ""
            txtWeight.Text = ""
            txtHeight.Text = ""
            txtBloodType.Text = ""
            txtAllergies.Text = ""
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        connection.Open()

        query = "UPDATE Patient SET Name = @name, Gender = @gender, NRICPassportNumber = @nricpassportnumber, ContactNumber = @contactnumber, Email = @email, Address = @address, Weight = @weight, Height = @height, BloodType = @bloodtype, Allergies = @allergies WHERE PatientID = @patientid"

        Dim gender As String = ""

        If radMale.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@patientid", SqlDbType.NVarChar).Value = txtPatientID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text
        command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender
        command.Parameters.Add("@nricpassportnumber", SqlDbType.NVarChar).Value = txtNRICPassportNumber.Text
        command.Parameters.Add("@contactnumber", SqlDbType.NVarChar).Value = txtContactNumber.Text
        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmail.Text
        command.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtAddress.Text
        command.Parameters.Add("@weight", SqlDbType.Int).Value = txtWeight.Text
        command.Parameters.Add("@height", SqlDbType.Int).Value = txtHeight.Text
        command.Parameters.Add("@bloodtype", SqlDbType.NVarChar).Value = txtBloodType.Text
        command.Parameters.Add("@allergies", SqlDbType.NVarChar).Value = txtAllergies.Text

        Try
            If txtPatientID.Text = "" Or txtName.Text = "" Or txtNRICPassportNumber.Text = "" Or txtContactNumber.Text = "" Or txtEmail.Text = "" Or txtAddress.Text = "" Or txtWeight.Text = "" Or txtHeight.Text = "" Or txtBloodType.Text = "" Or txtAllergies.Text = "" Then
                MsgBox("Please fill in all details", MessageBoxIcon.Warning, "Error")
            ElseIf IsNumeric(txtContactNumber.Text) = False Then
                MsgBox("Only number input is allowed for contact number", MessageBoxIcon.Error, "Update Failed")
            ElseIf IsNumeric(txtWeight.Text) = False Or IsNumeric(txtHeight.Text) = False Then
                MsgBox("Only number input is allowed for weight and height", MessageBoxIcon.Error, "Update Failed")
            Else
                Select Case MsgBox("Are You Sure?", MessageBoxButtons.YesNo, "Update")
                    Case MsgBoxResult.Yes
                        If vbYes Then
                            command.ExecuteNonQuery()
                            MsgBox("Record updated successfully", MessageBoxIcon.Information, "Record Updated")
                            txtPatientID.Text = ""
                            txtName.Text = ""
                            radMale.Checked = False
                            radFemale.Checked = False
                            txtNRICPassportNumber.Text = ""
                            txtContactNumber.Text = ""
                            txtEmail.Text = ""
                            txtAddress.Text = ""
                            txtWeight.Text = ""
                            txtHeight.Text = ""
                            txtBloodType.Text = ""
                            txtAllergies.Text = ""
                        End If
                    Case MsgBoxResult.No
                End Select
            End If
        Catch ex As Exception
        End Try

        connection.Close()

        display_data()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        connection.Open()

        query = "DELETE FROM Patient WHERE PatientID = @patientid"

        Dim gender As String = ""

        If radMale.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@patientid", SqlDbType.NVarChar).Value = txtPatientID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text
        command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender
        command.Parameters.Add("@nricpassportnumber", SqlDbType.NVarChar).Value = txtNRICPassportNumber.Text
        command.Parameters.Add("@contactnumber", SqlDbType.NVarChar).Value = txtContactNumber.Text
        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmail.Text
        command.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtAddress.Text
        command.Parameters.Add("@weight", SqlDbType.Int).Value = txtWeight.Text
        command.Parameters.Add("@height", SqlDbType.Int).Value = txtHeight.Text
        command.Parameters.Add("@bloodtype", SqlDbType.NVarChar).Value = txtBloodType.Text
        command.Parameters.Add("@allergies", SqlDbType.NVarChar).Value = txtAllergies.Text

        Try
            If txtPatientID.Text = "" Or txtName.Text = "" Or txtNRICPassportNumber.Text = "" Or txtContactNumber.Text = "" Or txtEmail.Text = "" Or txtAddress.Text = "" Or txtWeight.Text = "" Or txtHeight.Text = "" Or txtBloodType.Text = "" Or txtAllergies.Text = "" Then
                MsgBox("Please fill in all details", MessageBoxIcon.Warning, "Error")
            ElseIf IsNumeric(txtContactNumber.Text) = False Then
                MsgBox("Only number input is allowed for contact number", MessageBoxIcon.Error, "Delete Failed")
                ElseIf IsNumeric(txtWeight.Text) = False Or IsNumeric(txtHeight.Text) = False Then
                MsgBox("Only number input is allowed for Weight and Height", MessageBoxIcon.Error, "Delete Failed")
            Else
                Select Case MsgBox("Are You Sure?", MessageBoxButtons.YesNo, "Delete")
                    Case MsgBoxResult.Yes
                        If vbYes Then
                            command.ExecuteNonQuery()
                            MsgBox("Record deleted successfully", MessageBoxIcon.Information, "Record Deleted")
                            txtPatientID.Text = ""
                            txtName.Text = ""
                            radMale.Checked = False
                            radFemale.Checked = False
                            txtNRICPassportNumber.Text = ""
                            txtContactNumber.Text = ""
                            txtEmail.Text = ""
                            txtAddress.Text = ""
                            txtWeight.Text = ""
                            txtHeight.Text = ""
                            txtBloodType.Text = ""
                            txtAllergies.Text = ""
                        End If
                    Case MsgBoxResult.No
                End Select
            End If
        Catch ex As Exception
            MsgBox("Patient ID exists in Prescription or Bill record. Prescription or Bill record needs to be deleted before Patient record can be deleted", MessageBoxIcon.Error, "Delete Failed")
        End Try

        connection.Close()

        display_data()

    End Sub

    Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click

        display_data()

        txtPatientID.Text = ""
        txtName.Text = ""
        radMale.Checked = False
        radFemale.Checked = False
        txtNRICPassportNumber.Text = ""
        txtContactNumber.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtWeight.Text = ""
        txtHeight.Text = ""
        txtBloodType.Text = ""
        txtAllergies.Text = ""

    End Sub

End Class
