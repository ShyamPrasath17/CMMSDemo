Public Class frmWorkRequest

    Private Sub frmWorkRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createpreTbl()
        createEmpTbl()
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