Imports Telerik.WinControls.UI.Docking
Public Class frmSheduleMaintanance

    Private Sub frmSheduleMaintanance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateTriggertbl()
        createpreTbl()
        createEmpTbl()
        'cmbThreshold.DataSource = dtType.DefaultView
        'cmbThreshold.DisplayMember = "UOM"
    End Sub

    Sub fillSched(dataRow As DataRow)
        txtMaintID.Text = dataRow("MaintananceID").ToString()
        txtName.Text = dataRow("Name").ToString()
        txtStatus.Text = dataRow("Status").ToString()
        'If dataRow("RecurrenceType").ToString() = "TimeBased" Then
        '    radTimeBased.Checked = True
        'Else
        '    radMeter.Checked = True
        'End If
    End Sub

    Private Sub btnViewUpComming_Click(sender As Object, e As EventArgs) Handles btnViewUpComming.Click
        FormMain.TwUpComming.DefaultFloatingSize = New Size(900, 600)
        FormMain.RadDockMain.FloatWindow(FormMain.TwUpComming)
        'FormMain.RadDockMain.DockWindow(FormMain.TwUpComming, DockPosition.Right)
        'FormMain.TwUpComming.TabStrip.SizeInfo.SizeMode = SplitPanelSizeMode.Absolute
        'FormMain.TwUpComming.TabStrip.SizeInfo.AbsoluteSize = New System.Drawing.Size(500, 0)
    End Sub

    Private Sub CreateTriggertbl()
        Dim dttrigger As New DataTable()
        dttrigger.Columns.Add("Trigger ID", GetType(String))
        dttrigger.Columns.Add("Recurrence Type", GetType(String))
        dttrigger.Columns.Add("Recurrence Period", GetType(String))
        dttrigger.Columns.Add("Threshold Period", GetType(String))
        dttrigger.Columns.Add("Start Date", GetType(String))
        dttrigger.Columns.Add("End After", GetType(String))
        dgvTriggers.DataSource = dttrigger
        dgvTriggers.BestFitColumns()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmTrigger_ As New frmTrigger()
        frmTrigger_.ShowDialog()
    End Sub

    Private Sub createpreTbl()
        Dim dtrpt As New DataTable()
        dtrpt.Columns.Add("Predefined TaskID", GetType(String))
        dtrpt.Columns.Add("Predefined Task Name", GetType(String))

        dtrpt.Rows.Add("Predefined TaskID 1", "Name1")
        dtrpt.Rows.Add("Predefined TaskID 2", "Name2")
        dtrpt.Rows.Add("Predefined TaskID 3", "Name3")
        


        dgvPredefined.DataSource = dtrpt
        dgvPredefined.BestFitColumns()
        dgvPredefined.AllowAddNewRow = False
        dgvPredefined.AllowDeleteRow = False
        dgvPredefined.AllowEditRow = False
    End Sub


    Private Sub createEmpTbl()
        Dim dtrpt As New DataTable()
        dtrpt.Columns.Add("EmployeeID", GetType(String))
        dtrpt.Columns.Add("Employee Name", GetType(String))

        dgvEmp.DataSource = dtrpt
        dgvEmp.BestFitColumns()
        dgvEmp.AllowAddNewRow = False
        dgvEmp.AllowDeleteRow = False
        dgvEmp.AllowEditRow = False
    End Sub

End Class