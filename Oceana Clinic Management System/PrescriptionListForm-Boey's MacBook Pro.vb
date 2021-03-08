Imports System.Data.SqlClient

Public Class PrescriptionListForm

    Private Shared _instance As PrescriptionListForm
    Public Shared ReadOnly Property Instance() As PrescriptionListForm
        Get
            If _instance Is Nothing Then
                _instance = New PrescriptionListForm
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
        command.CommandText = "SELECT * FROM Prescription"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        dgvPrescriptionList.DataSource = table

    End Sub

    Private Sub PrescriptionListForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        display_data()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click


        query = "SELECT * FROM Prescription WHERE PatientID = @patientid OR Name = @name"

        command = New SqlCommand(query, connection)
        command.Parameters.Add("@patientid", SqlDbType.NVarChar).Value = txtPatientIDName.Text
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtPatientIDName.Text

        If txtPatientIDName.Text = "" Then
            MsgBox("Please fill in Patient ID or Name", MessageBoxIcon.Warning, "Error")
            txtPatientIDName.Focus()
        Else
            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)

            dgvPrescriptionList.DataSource = table

            txtPatientIDName.Text = ""
        End If

    End Sub

    Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click

        display_data()

        txtPatientIDName.Text = ""

    End Sub

End Class
