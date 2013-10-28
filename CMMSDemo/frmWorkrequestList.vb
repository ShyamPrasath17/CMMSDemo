Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class frmWorkrequestList
    Public dtSml As DataTable
    Private Sub frmWorkrequestList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createtable()
    End Sub

    Private Sub createtable()
        dtSml = New DataTable()
        dtSml.Columns.Add("RequestID", GetType(String))
        dtSml.Columns.Add("TaskName", GetType(String))
        dtSml.Columns.Add("Asset", GetType(String))
        dtSml.Columns.Add("Description", GetType(String))
        dtSml.Columns.Add("Assigned Date", GetType(DateTime))

        dtSml.Rows.Add("Req 1", "Clean Snow in Road", "Car 001", "", System.DateTime.Now.AddDays(100).Date)
        dtSml.Rows.Add("Req 2", "TaskReq Name1", "Mechine 002", "", System.DateTime.Now.AddDays(26).Date)
        dtSml.Rows.Add("Req 3", "TaskReq Name2", "Asset A", "", System.DateTime.Now.AddDays(25).Date)
        dtSml.Rows.Add("Req 4", "TaskReq Name3", "Asset B", "", System.DateTime.Now.AddDays(56).Date)
        dtSml.Rows.Add("Req 5", "TaskReq Name3", "Asset C", "", System.DateTime.Now.AddDays(80).Date)

        dgvWorkReq.DataSource = dtSml.Copy()
        dgvWorkReq.BestFitColumns()

        Dim btncol As GridViewCommandColumn = New GridViewCommandColumn()
        btncol.Name = "Create WorkOrder"
        btncol.HeaderText = "Create WorkOrder"
        btncol.DefaultText = "Create WorkOrder"
        btncol.UseDefaultText = True
        btncol.AutoEllipsis = True
        btncol.Width = 120
        dgvWorkReq.Columns.Insert(5, btncol)

        dgvWorkReq.AllowAddNewRow = False
        dgvWorkReq.AllowDeleteRow = False
        dgvWorkReq.AllowEditRow = False
    End Sub

    Private Sub dgvWorkReq_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles dgvWorkReq.CellDoubleClick
        FormMain.TwWorkReq.DefaultFloatingSize = New Size(800, 900)
        FormMain.RadDockMain.FloatWindow(FormMain.TwWorkReq)
        'FormMain.TwWorkReq.Show()
        FormMain.TwWorkReq.Select()
    End Sub

    Private Sub dgvWorkReq_CommandCellClick(sender As Object, e As EventArgs) Handles dgvWorkReq.CommandCellClick
        If Not dgvWorkReq.CurrentRow Is Nothing Then
            FormMain.ToolWindowWo.DefaultFloatingSize = New Size(900, 1000)
            FormMain.RadDockMain.FloatWindow(FormMain.ToolWindowWo)
            FormMain.frmwo.txtReq.Text = dgvWorkReq.CurrentRow.Cells("RequestID").Value.ToString()
            'FormMain.ToolWindowWo.Show()
            FormMain.ToolWindowWo.Select()
        End If
    End Sub
End Class