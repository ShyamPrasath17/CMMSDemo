Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Scheduler.ICalendar
Imports Telerik.WinControls
Public Class frmPrint
    Dim schedular As RadScheduler
    Dim parentfrm As frmShedular
    Sub New(ByRef parent As frmShedular)
        InitializeComponent()
        parentfrm = parent
    End Sub
    Private Sub frmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        setPrintStyle()
        schedular.Print(True, SchPrintDocument)
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        setPrintStyle()
        schedular.PrintPreview(SchPrintDocument)
    End Sub

    Private Sub setPrintStyle()

        schedular = Nothing
        If RadWo.Checked Then
            SchPrintDocument.AssociatedObject = parentfrm.RSwo
            schedular = parentfrm.RSwo
        ElseIf RadTask.Checked Then
            SchPrintDocument.AssociatedObject = parentfrm.RsTask
            schedular = parentfrm.RsTask
        ElseIf RadEmp.Checked Then
            SchPrintDocument.AssociatedObject = parentfrm.RSEmp
            schedular = parentfrm.RSEmp
        Else
            SchPrintDocument.AssociatedObject = parentfrm.RSEqp
            schedular = parentfrm.RSEqp
        End If

        If schedular.ActiveViewType = SchedulerViewType.Day Then
            schedular.PrintStyle = New SchedulerDailyPrintStyle(schedular.ActiveView.StartDate, schedular.ActiveView.EndDate)
        ElseIf schedular.ActiveViewType = SchedulerViewType.Week Then
            Dim startDate As Date = DateHelper.GetStartOfWeek(schedular.ActiveView.EndDate, schedular.DateTimeFormat, DayOfWeek.Monday)
            Dim endDate As Date = DateHelper.GetEndOfWeek(startDate, schedular.DateTimeFormat, DayOfWeek.Monday).AddDays(-1)
            schedular.PrintStyle = New SchedulerWeeklyPrintStyle(startDate, endDate)
        ElseIf schedular.ActiveViewType = SchedulerViewType.Month Then
            schedular.PrintStyle = New SchedulerMonthlyPrintStyle(schedular.ActiveView.StartDate, schedular.ActiveView.EndDate)
        ElseIf schedular.ActiveViewType = SchedulerViewType.Timeline Then
            schedular.PrintStyle = New SchedulerDetailsPrintStyle(schedular.ActiveView.StartDate, schedular.ActiveView.EndDate)
        End If

    End Sub

    Private Sub btnPrintSettings_Click(sender As Object, e As EventArgs) Handles btnPrintSettings.Click
        setPrintStyle()
        Dim dialog As New SchedulerPrintSettingsDialog()
        dialog.ThemeName = schedular.ThemeName
        dialog.PrintDocument = SchPrintDocument

        If dialog.ShowDialog() = DialogResult.OK Then
            btnPreview_Click(sender, e)
        End If
    End Sub
End Class