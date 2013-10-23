Public Class frmUpCommingSchedule
    Public dtSml As DataTable
    Private Sub ChkFilter_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFilter.CheckedChanged
        If ChkFilter.Checked Then
            grpfilter.Enabled = True
        Else
            grpfilter.Enabled = False
        End If

    End Sub

    Private Sub frmUpCommingSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub createtable()
        dtSml = New DataTable()
        dtSml.Columns.Add("MaintananceID", GetType(String))
        dtSml.Columns.Add("Task Name", GetType(String))
        dtSml.Columns.Add("Date", GetType(String))
        dtSml.Columns.Add("Description", GetType(String))

        dtSml.Rows.Add("Maintanance 1", "Oil Change to car", System.DateTime.Now.AddDays(40), "")
        dtSml.Rows.Add("Maintanance 2", "Clean Mechine 2", System.DateTime.Now.AddDays(40), "")
        dtSml.Rows.Add("Maintanance 3", "Name 3", System.DateTime.Now.AddDays(40), "")
        dtSml.Rows.Add("Maintanance 4", "Name 4", System.DateTime.Now.AddDays(40), "")
        dtSml.Rows.Add("Maintanance 5", "Name 5", System.DateTime.Now.AddDays(40), "")

        'For i As Integer = 1 To 15
        '    If i < 4 Then
        '        dtSml.Rows.Add("Maintanance " & i.ToString(), "Name " + i.ToString(), "Asset " + i.ToString(), "", "TimeBased", "New")
        '    ElseIf i >= 4 And i < 8 Then
        '        dtSml.Rows.Add("Maintanance " & i.ToString(), "Name " + i.ToString(), "Asset " + i.ToString(), "", "Meter Reading", "Approved")
        '    ElseIf i >= 8 And i < 12 Then
        '        dtSml.Rows.Add("Maintanance " & i.ToString(), "Name " + i.ToString(), "Asset " + i.ToString(), "", "TimeBased", "Approved")
        '    Else
        '        dtSml.Rows.Add("Maintanance " & i.ToString(), "Name " + i.ToString(), "Asset " + i.ToString(), "", "Meter Reading", "Approved")
        '    End If
        'Next
        'dgvSchedMaint.DataSource = dtSml.Copy()
        'dgvSchedMaint.BestFitColumns()
    End Sub
End Class