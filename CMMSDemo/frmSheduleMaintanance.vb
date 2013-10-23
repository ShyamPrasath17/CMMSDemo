Imports Telerik.WinControls.UI.Docking
Public Class frmSheduleMaintanance
    Dim dtType As DataTable
    Private Sub radTimeBased_CheckedChanged(sender As Object, e As EventArgs) Handles radTimeBased.CheckedChanged
        If radTimeBased.Checked Then
            dtType.DefaultView.RowFilter = "Type= 'TimeBased'"
        End If
    End Sub

    Private Sub radMeter_CheckedChanged(sender As Object, e As EventArgs) Handles radMeter.CheckedChanged
        If radMeter.Checked Then
            dtType.DefaultView.RowFilter = "Type= 'MeterBased'"
        End If
    End Sub

    Private Sub frmSheduleMaintanance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createTypeTbl()
        radTimeBased.Checked = True
        cmbrptUom.DataSource = dtType.DefaultView
        cmbrptUom.DisplayMember = "UOM"
        'cmbThreshold.DataSource = dtType.DefaultView
        'cmbThreshold.DisplayMember = "UOM"
    End Sub

    Private Sub createTypeTbl()
        dtType = New DataTable()
        dtType.Columns.Add("Type", GetType(String))
        dtType.Columns.Add("UOM", GetType(String))
        dtType.Rows.Add("TimeBased", "Hours")
        dtType.Rows.Add("TimeBased", "Days")
        dtType.Rows.Add("TimeBased", "Weeks")
        dtType.Rows.Add("TimeBased", "Months")
        dtType.Rows.Add("TimeBased", "Years")
        dtType.Rows.Add("MeterBased", "Kms")
        dtType.Rows.Add("MeterBased", "Meters")
        dtType.Rows.Add("MeterBased", "Cycles")
    End Sub

    Sub fillSched(dataRow As DataRow)
        txtMaintID.Text = dataRow("MaintananceID").ToString()
        txtName.Text = dataRow("Name").ToString()
        txtStatus.Text = dataRow("Status").ToString()
        If dataRow("RecurrenceType").ToString() = "TimeBased" Then
            radTimeBased.Checked = True
        Else
            radMeter.Checked = True
        End If
    End Sub

    Private Sub btnViewUpComming_Click(sender As Object, e As EventArgs) Handles btnViewUpComming.Click
        FormMain.RadDockMain.DockWindow(FormMain.TwUpComming, DockPosition.Right)
        FormMain.TwUpComming.TabStrip.SizeInfo.SizeMode = SplitPanelSizeMode.Absolute
        FormMain.TwUpComming.TabStrip.SizeInfo.AbsoluteSize = New System.Drawing.Size(500, 0)
    End Sub
End Class