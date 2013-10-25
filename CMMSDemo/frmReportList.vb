Public Class frmReportList

    Private Sub frmReportList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtrpt As New DataTable()
        dtrpt.Columns.Add("ReportName", GetType(String))
        dtrpt.Columns.Add("Description", GetType(String))

        dtrpt.Rows.Add("Pending Task Report", "Report about Pending Tasks")
        dtrpt.Rows.Add("Report 1", "description1")
        dtrpt.Rows.Add("Report 2", "description2")
        dtrpt.Rows.Add("Report 3", "description3")
        dtrpt.Rows.Add("Report 4", "description4")
        dtrpt.Rows.Add("Report 5", "description5")


        dgvrpt.DataSource = dtrpt
        dgvrpt.BestFitColumns()
        dgvrpt.AllowAddNewRow = False
        dgvrpt.AllowDeleteRow = False
        dgvrpt.AllowEditRow = False

    End Sub
End Class