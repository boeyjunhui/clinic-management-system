Imports System.Data.SqlClient

Public Class AddPrescriptionForm

    Private Shared _instance As AddPrescriptionForm
    Public Shared ReadOnly Property Instance() As AddPrescriptionForm
        Get
            If _instance Is Nothing Then
                _instance = New AddPrescriptionForm()
            End If
            Return _instance
        End Get
    End Property

    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Boey Jun Hui\OneDrive - Asia Pacific University\Visual Basic .NET (VBN)\Assignment\OceanaClinicManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    Dim command As New SqlCommand

    Dim query As String

    Public Sub display_data()

        query = "SELECT * FROM Prescription"

        command = connection.CreateCommand()
        command.CommandType = CommandType.Text
        command.CommandText = "select * from Prescription"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        dgvPrescriptionList.DataSource = table

    End Sub

    Private Sub AddPrescriptionForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        display_data()

    End Sub

    Private Sub dgvPrescriptionList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrescriptionList.CellClick

        Try
            txtPatientID.Text = dgvPrescriptionList.Rows(dgvPrescriptionList.CurrentRow.Index).Cells(0).Value
            txtName.Text = dgvPrescriptionList.Rows(dgvPrescriptionList.CurrentRow.Index).Cells(1).Value
            txtDisease.Text = dgvPrescriptionList.Rows(dgvPrescriptionList.CurrentRow.Index).Cells(2).Value
            txtPrescription.Text = dgvPrescriptionList.Rows(dgvPrescriptionList.CurrentRow.Index).Cells(3).Value
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        connection.Open()

        query = "INSERT INTO Prescription (PatientID, Name, Disease, Prescription) VALUES (@patientid, @name, @disease, @prescription)"

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@patientid", SqlDbType.NVarChar).Value = txtPatientID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text
        command.Parameters.Add("@disease", SqlDbType.NVarChar).Value = txtDisease.Text
        command.Parameters.Add("@prescription", SqlDbType.NVarChar).Value = txtPrescription.Text

        Try
            If txtPatientID.Text = "" Or txtName.Text = "" Or txtDisease.Text = "" Or txtPrescription.Text = "" Then
                MsgBox("Please fill in all details", MessageBoxIcon.Warning, "Error")
            Else
                command.ExecuteNonQuery()
                MsgBox("New prescription is added", MessageBoxIcon.Information, "Prescription Added")
                txtPatientID.Text = ""
                txtName.Text = ""
                txtDisease.Text = ""
                txtPrescription.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Patient ID does not exist", MessageBoxIcon.Error, "Add Failed")
        End Try

        connection.Close()

        'MsgBox("Patient ID is already exist", MessageBoxIcon.Error, "Add Failed")

        display_data()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        query = "SELECT * FROM Prescription WHERE PatientID = @patientid OR Name = @name"

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

            dgvPrescriptionList.DataSource = table

            txtPatientID.Text = ""
            txtName.Text = ""
            txtDisease.Text = ""
            txtPrescription.Text = ""
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        connection.Open()

        query = "UPDATE Prescription SET Name = @name, Disease = @disease, Prescription = @prescription WHERE PatientID = @patientid"

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@patientid", SqlDbType.NVarChar).Value = txtPatientID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text
        command.Parameters.Add("@disease", SqlDbType.NVarChar).Value = txtDisease.Text
        command.Parameters.Add("@prescription", SqlDbType.NVarChar).Value = txtPrescription.Text

        If txtPatientID.Text = "" Or txtName.Text = "" Or txtDisease.Text = "" Or txtPrescription.Text = "" Then
            MsgBox("Please fill in all details", MessageBoxIcon.Warning, "Error")
        Else
            Select Case MsgBox("Are You Sure?", MessageBoxButtons.YesNo, "Update")
                Case MsgBoxResult.Yes
                    If vbYes Then
                        command.ExecuteNonQuery()
                        MsgBox("Record updated successfully", MessageBoxIcon.Information, "Record Updated")
                        txtPatientID.Text = ""
                        txtName.Text = ""
                        txtDisease.Text = ""
                        txtPrescription.Text = ""
                    End If
                Case MsgBoxResult.No
            End Select
        End If

        connection.Close()

        display_data()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        connection.Open()

        query = "DELETE FROM Prescription WHERE PatientID = @patientid"

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@patientid", SqlDbType.NVarChar).Value = txtPatientID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text
        command.Parameters.Add("@disease", SqlDbType.NVarChar).Value = txtDisease.Text
        command.Parameters.Add("@prescription", SqlDbType.NVarChar).Value = txtPrescription.Text

        If txtPatientID.Text = "" Or txtName.Text = "" Or txtDisease.Text = "" Or txtPrescription.Text = "" Then
            MsgBox("Please fill in all details", MessageBoxIcon.Warning, "Error")
        Else
            Select Case MsgBox("Are You Sure?", MessageBoxButtons.YesNo, "Delete")
                Case MsgBoxResult.Yes
                    If vbYes Then
                        command.ExecuteNonQuery()
                        MsgBox("Record deleted successfully", MessageBoxIcon.Information, "Record Deleted")
                        txtPatientID.Text = ""
                        txtName.Text = ""
                        txtDisease.Text = ""
                        txtPrescription.Text = ""
                    End If
                Case MsgBoxResult.No
            End Select
        End If

        connection.Close()

        display_data()

    End Sub

    Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click

        display_data()

    End Sub

End Class
