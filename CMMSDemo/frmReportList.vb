Public Class frmReportList

    Private Sub frmReportList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtrpt As New DataTable()
        dtrpt.Columns.Add("ReportName", GetType(String))
        dtrpt.Columns.Add("Description", GetType(String))

        dtrpt.Rows.Add("Work Orders - Estimated vs Actual Completion Date", "This Report Lists W/O's Estimated vs Actual Completion Dates")
        dtrpt.Rows.Add("Work Orders - Estimated vs Actual Completion Date by User/Leader", "Details graphically weather a user has been completing Their W/O's on time....")
        dtrpt.Rows.Add("Work Orders - Estimated vs Actual Completion Date by Symptoms", "Shows graphically weather W/O's are been completed on time or not.Filters by Symptoms....")
        dtrpt.Rows.Add("Work Orders over view by Technician(Employee)", "Lists of work order Details for each user,Including # of W/O's asigned,# of closed W/O's...")
        dtrpt.Rows.Add("Work Order KPI Dashboard for Sites", "Shows work orders and Projects completed in a period")
        dtrpt.Rows.Add("Work Hours logged by Technician(Employee)", "Lists W/O hours logged for a particular technician in a given Time frame.")
        dtrpt.Rows.Add("Work Order completion Rate by Maintanance type.", "Shows Work Order completion Rate by Maintanance type")
        dtrpt.Rows.Add("Summary Report for a given Asset", " This Report gives a graphical Summary of maintanance on a particular Asset.")
        dtrpt.Rows.Add("Overdue Work Orders by Asset Category", " Shows all Open Work orders by date and days Overdue.")
        dtrpt.Rows.Add("Overdue Work Orders by User", " Shows all Open Work orders by date and days Overdue for a user.")
        dtrpt.Rows.Add("Open Work Orders Requested by a user", " Shows all Open Work orders requested by a particular user.")
        dtrpt.Rows.Add("Open Work Orders Requested by Asset", "Shows all Open Work orders by Asset.")
        dtrpt.Rows.Add("Overdue Work Orders by Priority", " Shows all Open Work orders by Priority.")
        dtrpt.Rows.Add("Overdue Work Orders by User", " Shows all Open Work orders by date and days Overdue for a user.")

        dgvrpt.DataSource = dtrpt
        dgvrpt.BestFitColumns()
        dgvrpt.AllowAddNewRow = False
        dgvrpt.AllowDeleteRow = False
        dgvrpt.AllowEditRow = False

    End Sub
End Class