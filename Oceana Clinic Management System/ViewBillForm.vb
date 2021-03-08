Imports System.Data.SqlClient

Public Class ViewBillForm

    Private Shared _instance As ViewBillForm
    Public Shared ReadOnly Property Instance() As ViewBillForm
        Get
            If _instance Is Nothing Then
                _instance = New ViewBillForm()
            End If
            Return _instance
        End Get
    End Property

    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\OceanaClinicManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    Dim command As New SqlCommand

    Dim query As String

    Public Sub display_data()

        query = "SELECT * FROM Bill"

        command = connection.CreateCommand()
        command.CommandType = CommandType.Text
        command.CommandText = "SELECT * FROM Bill"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        dgvBillList.DataSource = table

    End Sub

    Private Sub ViewBillForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        display_data()

    End Sub

    Private Sub dgvBillList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBillList.CellClick

        Try
            txtPatientID.Text = dgvBillList.Rows(dgvBillList.CurrentRow.Index).Cells(0).Value
            txtName.Text = dgvBillList.Rows(dgvBillList.CurrentRow.Index).Cells(1).Value
            txtTotalConsultationFee.Text = dgvBillList.Rows(dgvBillList.CurrentRow.Index).Cells(2).Value
            txtTotalMedicationFee.Text = dgvBillList.Rows(dgvBillList.CurrentRow.Index).Cells(3).Value
            txtTotalServiceFee.Text = dgvBillList.Rows(dgvBillList.CurrentRow.Index).Cells(4).Value
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        connection.Open()

        query = "INSERT INTO Bill (PatientID, Name, ConsultationFee, MedicationFee, ServiceFee) VALUES (@patientid, @name, @consultationfee, @medicationfee, @servicefee)"

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@patientid", SqlDbType.NVarChar).Value = txtPatientID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text
        command.Parameters.Add("@consultationfee", SqlDbType.Int).Value = txtTotalConsultationFee.Text
        command.Parameters.Add("@medicationfee", SqlDbType.Int).Value = txtTotalMedicationFee.Text
        command.Parameters.Add("@servicefee", SqlDbType.Int).Value = txtTotalServiceFee.Text

        Try
            If txtPatientID.Text = "" Or txtName.Text = "" Or txtTotalConsultationFee.Text = "" Or txtTotalMedicationFee.Text = "" Or txtTotalServiceFee.Text = "" Then
                MsgBox("Please fill in all details", MessageBoxIcon.Warning, "Add Failed")
            Else
                command.ExecuteNonQuery()
                MsgBox("New bill is added", MessageBoxIcon.Information, "Bill Added")
            End If
        Catch ex As Exception
            MsgBox("Patient ID does not exist", MessageBoxIcon.Error, "Add Failed")
        End Try

        connection.Close()

        display_data()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        query = "SELECT * FROM Bill WHERE PatientID = @patientid OR Name = @name"

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@patientid", SqlDbType.NVarChar).Value = txtPatientID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text

        If txtPatientID.Text = "" And txtName.Text = "" Then
            MsgBox("Please fill in Patient ID or Name", MessageBoxIcon.Warning, "Search Failed")
            txtPatientID.Focus()
        Else
            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)

            dgvBillList.DataSource = table

            txtPatientID.Text = ""
            txtName.Text = ""
            txtTotalConsultationFee.Text = ""
            txtTotalMedicationFee.Text = ""
            txtTotalServiceFee.Text = ""
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        connection.Open()

        query = "Update Bill SET Name = @name, ConsultationFee = @consultationfee, MedicationFee = @medicationfee, ServiceFee = @servicefee WHERE PatientID = @patientid"

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@patientid", SqlDbType.NVarChar).Value = txtPatientID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text
        command.Parameters.Add("@consultationfee", SqlDbType.Int).Value = txtTotalConsultationFee.Text
        command.Parameters.Add("@medicationfee", SqlDbType.Int).Value = txtTotalMedicationFee.Text
        command.Parameters.Add("@servicefee", SqlDbType.Int).Value = txtTotalServiceFee.Text

        If txtPatientID.Text = "" Or txtName.Text = "" Or txtTotalConsultationFee.Text = "" Or txtTotalMedicationFee.Text = "" Or txtTotalServiceFee.Text = "" Then
            MsgBox("Please fill in all details", MessageBoxIcon.Warning, "Update Failed")
        Else
            Select Case MessageBox.Show("Are You Sure?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case MsgBoxResult.Yes
                    If vbYes Then
                        command.ExecuteNonQuery()
                        MsgBox("Record updated successfully", MessageBoxIcon.Information, "Record Updated")
                    End If
                Case MsgBoxResult.No
            End Select
        End If

            connection.Close()

        display_data()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        connection.Open()

        Dim query As String = "DELETE FROM Bill WHERE PatientID = @patientid"

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@patientid", SqlDbType.NVarChar).Value = txtPatientID.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text
        command.Parameters.Add("@consultationfee", SqlDbType.Int).Value = txtTotalConsultationFee.Text
        command.Parameters.Add("@medicationfee", SqlDbType.Int).Value = txtTotalMedicationFee.Text
        command.Parameters.Add("@servicefee", SqlDbType.Int).Value = txtTotalServiceFee.Text

        If txtPatientID.Text = "" Or txtName.Text = "" Or txtTotalConsultationFee.Text = "" Or txtTotalMedicationFee.Text = "" Or txtTotalServiceFee.Text = "" Then
            MsgBox("Please fill in all details", MessageBoxIcon.Warning, "Delete Failed")
        Else
            Select Case MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case MsgBoxResult.Yes
                    If vbYes Then
                        command.ExecuteNonQuery()
                        MsgBox("Record deleted successfully", MessageBoxIcon.Information, "Record Deleted")
                        txtPatientID.Text = ""
                        txtName.Text = ""
                        txtTotalConsultationFee.Text = ""
                        txtTotalMedicationFee.Text = ""
                        txtTotalServiceFee.Text = ""
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

    Private Sub btnCalculateTotalAmount_Click(sender As Object, e As EventArgs) Handles btnCalculateTotalAmount.Click

        Const consultation As Integer = 30
        Const onemedicinetype As Integer = 10
        Const labservices As Integer = 100
        Const xray As Integer = 50
        Const comprehensivehealthcheck As Integer = 120
        Const partialhealthcheck As Integer = 75

        Dim sum As Integer
        Dim totalconsultationfee As Integer
        Dim totalmedicationfee As Integer
        Dim totalservicefee As Integer

        If chkConsultation.Checked = True Then
            sum = sum + consultation
            totalconsultationfee = totalconsultationfee + consultation
        End If

        If chkOneMedicineType.Checked = True Then
            sum = sum + (Val(txtOneMedicineType.Text) * onemedicinetype)
            totalmedicationfee = totalmedicationfee + (Val(txtOneMedicineType.Text) * onemedicinetype)
        End If

        If chkLabServices.Checked = True Then
            sum = sum + labservices
            totalservicefee = totalservicefee + labservices
        End If

        If chkXRay.Checked = True Then
            sum = sum + xray
            totalservicefee = totalservicefee + xray
        End If

        If chkComprehensiveHealthCheck.Checked = True Then
            sum = sum + comprehensivehealthcheck
            totalservicefee = totalservicefee + comprehensivehealthcheck
        End If

        If chkPartialHealthCheck.Checked = True Then
            sum = sum + partialhealthcheck
            totalservicefee = totalservicefee + partialhealthcheck
        End If

        If chkConsultation.Checked = False And chkOneMedicineType.Checked = False And chkLabServices.Checked = False And chkXRay.Checked = False And chkComprehensiveHealthCheck.Checked = False And chkPartialHealthCheck.Checked = False Then
            MsgBox("Please tick at least one medicine or service type", MessageBoxIcon.Warning, "Calculate Failed")
        ElseIf chkOneMedicineType.Checked = True And txtOneMedicineType.Text = "" Then
            MsgBox("Please fill in the number of medicine type", MessageBoxIcon.Warning, "Calculate Failed")
            txtOneMedicineType.Focus()
        ElseIf chkOneMedicineType.Checked = True And IsNumeric(txtOneMedicineType.Text) = False Then
            MsgBox("Only number input is allowed for number of medicine type", MessageBoxIcon.Error, "Calculate Failed")
            txtOneMedicineType.Focus()
        Else
            txtTotalAmount.Text = sum
            txtTotalConsultationFee.Text = totalconsultationfee
            txtTotalMedicationFee.Text = totalmedicationfee
            txtTotalServiceFee.Text = totalservicefee
        End If

    End Sub

    Private Sub btnCalculateChangeAmount_Click(sender As Object, e As EventArgs) Handles btnCalculateChangeAmount.Click

        Dim totalamount, receivedamount, changeamount As Single

        totalamount = Val(txtTotalAmount.Text)
        receivedamount = Val(txtReceivedAmount.Text)

        changeamount = receivedamount - totalamount

        If txtReceivedAmount.Text = "" Then
            MsgBox("Please fill in the received amount", MessageBoxIcon.Warning, "Calculate Failed")
            txtReceivedAmount.Focus()
        ElseIf IsNumeric(txtReceivedAmount.Text) = False Then
            MsgBox("Only number input is allowed for received amount", MessageBoxIcon.Error, "Calculate Failed")
            txtReceivedAmount.Focus()
        Else
            txtChangeAmount.Text = changeamount
        End If

    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click

        Select Case MessageBox.Show("Are you sure?", "Clear All", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case MsgBoxResult.Yes
                If vbYes Then
                    txtPatientID.Text = ""
                    txtName.Text = ""
                    txtTotalConsultationFee.Text = ""
                    txtTotalMedicationFee.Text = ""
                    txtTotalServiceFee.Text = ""
                    chkConsultation.Checked = False
                    chkOneMedicineType.Checked = False
                    txtOneMedicineType.Text = ""
                    chkLabServices.Checked = False
                    chkXRay.Checked = False
                    chkComprehensiveHealthCheck.Checked = False
                    chkPartialHealthCheck.Checked = False
                    txtTotalAmount.Text = ""
                    txtReceivedAmount.Text = ""
                    txtChangeAmount.Text = ""
                    rtfReceipt.Text = ""
                End If
            Case MsgBoxResult.No
        End Select

    End Sub

    Private Sub btnGenerateReceipt_Click(sender As Object, e As EventArgs) Handles btnGenerateReceipt.Click

        rtfReceipt.AppendText(vbTab + vbTab + "OCEANA CLINIC" + vbNewLine)
        rtfReceipt.AppendText("" + vbNewLine)
        rtfReceipt.AppendText("Oceana Clinic, Asia Pacific University, Jalan Teknologi 5, Taman Teknologi Malaysia, 57000 Kuala Lumpur, Wilayah Persekutuan Kuala Lumpur." + vbNewLine)
        rtfReceipt.AppendText("" + vbNewLine)
        rtfReceipt.AppendText("Received By : " + txtName.Text + vbNewLine)
        rtfReceipt.AppendText("" + vbNewLine)
        rtfReceipt.AppendText("" + vbNewLine)
        rtfReceipt.AppendText("Total Consultation Fee :" + vbTab + "RM" + txtTotalConsultationFee.Text + vbNewLine)
        rtfReceipt.AppendText("Total Medication Fee :" + vbTab + "RM" + txtTotalMedicationFee.Text + vbNewLine)
        rtfReceipt.AppendText("Total Service Fee :" + vbTab + "RM" + txtTotalServiceFee.Text + vbNewLine)
        rtfReceipt.AppendText("" + vbNewLine)
        rtfReceipt.AppendText("" + vbNewLine)
        rtfReceipt.AppendText("Total Amount Due :" + vbTab + "RM" + txtTotalAmount.Text + vbNewLine)
        rtfReceipt.AppendText("Received Amount :" + vbTab + "RM" + txtReceivedAmount.Text + vbNewLine)
        rtfReceipt.AppendText("Change Amount :" + vbTab + "RM" + txtChangeAmount.Text + vbNewLine)
        rtfReceipt.AppendText("" + vbNewLine)
        rtfReceipt.AppendText("" + vbNewLine)
        rtfReceipt.AppendText("" + vbNewLine)
        rtfReceipt.AppendText(vbTab + vbTab + "Thank You!" + vbNewLine)

    End Sub

End Class
