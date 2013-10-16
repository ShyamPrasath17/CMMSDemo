Imports Telerik.WinControls.UI.Docking
Public Class frmAssignEmployees
    Dim schedular As frmResourceSchedular
    Private Sub frmAssignEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radInternal.Checked = True
        createData()
    End Sub

    Private Sub radInternal_CheckedChanged(sender As Object, e As EventArgs) Handles radInternal.CheckedChanged
        'If radInternal.Checked Then
        '    grpInternalEmp.Visible = True
        '    grpOutSource.Visible = False
        'End If
    End Sub

    Private Sub radOutsourced_CheckedChanged(sender As Object, e As EventArgs) Handles radOutsourced.CheckedChanged
        'If radOutsourced.Checked Then
        '    grpOutSource.Visible = True
        '    grpInternalEmp.Visible = False
        'End If
    End Sub

    Private Sub btnOutSource_Click(sender As Object, e As EventArgs) Handles btnOutSource.Click
        Dim frmou As frmOutsource = New frmOutsource("Employee")
        frmou.ShowDialog()
    End Sub

    Private Sub btnViewSchedular_Click(sender As Object, e As EventArgs) Handles btnViewSchedular.Click
        RadDockEmp.DockWindow(twEmp, DockPosition.Left)
        If Not RadDockEmp.Contains(schedular) Then
            schedular = New frmResourceSchedular("Employee")
            Me.WindowState = FormWindowState.Maximized
            RadDockEmp.DockControl(schedular, Telerik.WinControls.UI.Docking.DockPosition.Right)
            twEmp.TabStrip.SizeInfo.SizeMode = SplitPanelSizeMode.Absolute
            twEmp.TabStrip.SizeInfo.AbsoluteSize = New System.Drawing.Size(700, 0)
        End If
    End Sub

    Private Sub createData()
        Dim dtemp As DataTable = New DataTable()
        dtemp.Columns.Add("Name", GetType(String))
        dtemp.Columns.Add("AssignedDate", GetType(String))
        dtemp.Columns.Add("StartTime", GetType(String))
        dtemp.Columns.Add("EndTime", GetType(String))
        dtemp.Columns.Add("Type", GetType(String))

        dtemp.Rows.Add("Employee 1", System.DateTime.Now.Date.AddDays(1).Date.ToString(), "08.30", "16.30", "Internal")
        dtemp.Rows.Add("Employee 2", System.DateTime.Now.Date.AddDays(1).Date.ToString(), "10.15", "17.15", "Outsourced")
        dtemp.Rows.Add("Employee 3", System.DateTime.Now.Date.AddDays(1).Date.ToString(), "09.00", "15.00", "Internal")
        dtemp.Rows.Add("Employee 4", System.DateTime.Now.Date.AddDays(1).Date.ToString(), "8.00", "18.00", "Internal")
        dtemp.Rows.Add("Employee 5", System.DateTime.Now.Date.AddDays(1).Date.ToString(), "8.30", "16.30", "Outsourced")
        dtemp.Rows.Add("Employee 6", System.DateTime.Now.Date.AddDays(1).Date.ToString(), "11.00", "16.00", "Internal")

        dgvEmployees.DataSource = dtemp
        dgvEmployees.AllowAddNewRow = False
        dgvEmployees.AllowDeleteRow = False
        dgvEmployees.AllowEditRow = False
        dgvEmployees.BestFitColumns()

    End Sub
End Class