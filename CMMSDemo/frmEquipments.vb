Imports Telerik.WinControls.UI.Docking
Public Class frmAssignEquipments
    Dim schedular As frmResourceSchedular
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
        Dim frmou As frmOutsource = New frmOutsource("Equipment")
        frmou.ShowDialog()
    End Sub

    Private Sub frmAssignEquipments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radInternal.Checked = True
        createData()
    End Sub

    Private Sub btnViewSchedular_Click(sender As Object, e As EventArgs) Handles btnViewSchedular.Click
        RadDockequip.DockWindow(twEquipment, DockPosition.Left)
        If Not RadDockequip.Contains(schedular) Then
            schedular = New frmResourceSchedular("Equipment")
            Me.WindowState = FormWindowState.Maximized
            RadDockequip.DockControl(schedular, Telerik.WinControls.UI.Docking.DockPosition.Right)
            twEquipment.TabStrip.SizeInfo.SizeMode = SplitPanelSizeMode.Absolute
            twEquipment.TabStrip.SizeInfo.AbsoluteSize = New System.Drawing.Size(700, 0)
        End If
    End Sub

    Private Sub createData()
        Dim dtequip As DataTable = New DataTable()
        dtequip.Columns.Add("Name", GetType(String))
        dtequip.Columns.Add("AssignedDate", GetType(String))
        dtequip.Columns.Add("StartTime", GetType(String))
        dtequip.Columns.Add("EndTime", GetType(String))
        dtequip.Columns.Add("Type", GetType(String))

        dtequip.Rows.Add("Equipment 1", System.DateTime.Now.Date.AddDays(1).Date.ToString(), "08.30", "16.30", "Internal")
        dtequip.Rows.Add("Equipment 2", System.DateTime.Now.Date.AddDays(1).Date.ToString(), "10.15", "17.15", "Outsourced")
        dtequip.Rows.Add("Equipment 3", System.DateTime.Now.Date.AddDays(1).Date.ToString(), "09.00", "15.00", "Internal")
        dtequip.Rows.Add("Equipment 4", System.DateTime.Now.Date.AddDays(1).Date.ToString(), "8.00", "18.00", "Internal")
        dtequip.Rows.Add("Equipment 5", System.DateTime.Now.Date.AddDays(1).Date.ToString(), "8.30", "16.30", "Outsourced")
        dtequip.Rows.Add("Equipment 6", System.DateTime.Now.Date.AddDays(1).Date.ToString(), "11.00", "16.00", "Internal")

        dgvEquipment.DataSource = dtequip
        dgvEquipment.AllowAddNewRow = False
        dgvEquipment.AllowDeleteRow = False
        dgvEquipment.AllowEditRow = False
        dgvEquipment.BestFitColumns()

    End Sub

End Class