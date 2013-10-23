﻿Public Class frmUpCommingSchedule
    Public dtSml As DataTable
    Private Sub ChkFilter_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFilter.CheckedChanged
        If ChkFilter.Checked Then
            grpfilter.Enabled = True
        Else
            grpfilter.Enabled = False
        End If

    End Sub

    Private Sub frmUpCommingSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createtable()
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

        DgvUpComming.DataSource = dtSml
        DgvUpComming.BestFitColumns()
        DgvUpComming.AllowAddNewRow = False
        DgvUpComming.AllowDeleteRow = False
        DgvUpComming.AllowEditRow = False

    End Sub

    Private Sub DgvUpComming_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles DgvUpComming.CellDoubleClick
        FormMain.TwScheduledMaint.Show()
        FormMain.TwScheduledMaint.Select()
    End Sub
End Class