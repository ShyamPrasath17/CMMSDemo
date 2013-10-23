Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Scheduler.ICalendar
Public Class frmImportSchedule

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.AddExtension = True
        openFileDialog.DefaultExt = ".ics"
        openFileDialog.Filter = "iCal files (*.ics)|*.ics|All files (*.*)|*.*"
        openFileDialog.Multiselect = False

        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Using fileStream As FileStream = File.OpenRead(openFileDialog.FileName)
                Me.RshImport.Import(fileStream, New SchedulerICalendarImporter())
            End Using
        End If
    End Sub

    Private Sub frmImportSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Rcal_SelectionChanged(sender As Object, e As EventArgs) Handles Rcal.SelectionChanged
        If Me.Rcal.SelectedDates.Count > 0 Then
            Me.RshImport.ActiveView.StartDate = Me.Rcal.SelectedDate
        End If
    End Sub

    Private Sub RshImport_ContextMenuShowing(sender As Object, e As Telerik.WinControls.UI.SchedulerContextMenuShowingEventArgs) Handles RshImport.ContextMenuShowing
        If TypeOf e.Element Is AppointmentElement Then
            e.ContextMenu.Items.RemoveAt(0)
        End If
    End Sub

    Private Sub RshImport_AppointmentElementDoubleClick(sender As Object, e As EventArgs) Handles RshImport.AppointmentElementDoubleClick
        Dim frmattach As frmUpCommingSchedule = New frmUpCommingSchedule()
        frmattach.ShowDialog()
    End Sub

    Private Sub RshImport_AppointmentEditDialogShowing(sender As Object, e As AppointmentEditDialogShowingEventArgs) Handles RshImport.AppointmentEditDialogShowing
        e.Cancel = True
    End Sub
End Class