Imports System.IO
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

End Class