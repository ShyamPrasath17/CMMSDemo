Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Scheduler.ICalendar
Imports Telerik.WinControls
Imports System.Collections.Generic
Imports Telerik.WinControls.UI.Scheduler.Dialogs

Public Class frmTaskShedular
    
    Private Sub Rshcmms_Click(sender As Object, e As EventArgs) Handles Rshcmms.Click

    End Sub

    Private Sub Rcal_SelectionChanged(sender As Object, e As EventArgs) Handles Rcal.SelectionChanged
        If Me.Rcal.SelectedDates.Count > 0 Then
            Me.Rshcmms.ActiveView.StartDate = Me.Rcal.SelectedDate
        End If
    End Sub

    Private Sub frmShedular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        addTaskAppointments()
        SplitContainer2.IsSplitterFixed = True
        SplitContainer1.IsSplitterFixed = True
        SplitContainer2.FixedPanel = FixedPanel.Panel1
        Rshcmms.AllowAppointmentCreateInline = False
        ChkAllAreas.Checked = True
    End Sub

    Private Sub Rshcmms_AppointmentElementDoubleClick(sender As Object, e As EventArgs) Handles Rshcmms.AppointmentElementDoubleClick
        'Dim frm As frmTasks = New frmTasks()
        'frm.ShowDialog()
        FormMain.twTask.Show()
        FormMain.twTask.Select()
    End Sub

    Private Sub Rshcmms_AppointmentEditDialogShowing(sender As Object, e As AppointmentEditDialogShowingEventArgs) Handles Rshcmms.AppointmentEditDialogShowing
        e.Cancel = True
    End Sub

    Private Sub Rshcmms_ContextMenuShowing(sender As Object, e As SchedulerContextMenuShowingEventArgs) Handles Rshcmms.ContextMenuShowing
        If TypeOf e.Element Is AppointmentElement Then
            e.ContextMenu.Items.RemoveAt(0)
        End If
    End Sub

    Private Sub Rshcmms_AppointmentSelected(sender As Object, e As SchedulerAppointmentEventArgs) Handles Rshcmms.AppointmentSelected
        If FormMain.frmTskLst.dttask.Select("TaskID = '" & e.Appointment.Summary.ToString() & "'").Length > 0 Then
            FormMain.frmTsk.filltask(FormMain.frmTskLst.dttask.Select("TaskID = '" & e.Appointment.Summary.ToString() & "'")(0))
            FormMain.frmTsk.dtpStartDate.Value = e.Appointment.Start
            FormMain.frmTsk.dtpStartTime.Value = e.Appointment.Start
            FormMain.frmTsk.dtpEndDate.Value = e.Appointment.End
            FormMain.frmTsk.dtpEndTime.Value = e.Appointment.End
        End If
    End Sub

    Private Sub BtnViewNonScheduled_Click(sender As Object, e As EventArgs) Handles BtnViewNonScheduled.Click
        FormMain.RadDockMain.DockWindow(FormMain.twCommonTaskPool, Telerik.WinControls.UI.Docking.DockPosition.Bottom)
    End Sub

    Private Sub ChkAllAreas_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAllAreas.CheckedChanged
        If ChkAllAreas.Checked Then
            grpSite.Enabled = False
        Else
            grpSite.Enabled = True
        End If
    End Sub

    Private Sub addTaskAppointments()
        Dim baseDate As DateTime = DateTime.Today
        Dim start() As DateTime = {baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(9.0), baseDate.AddDays(2.0).AddHours(13.0), baseDate.AddDays(-3.0).AddHours(13.0), baseDate.AddDays(-2.0).AddHours(10.0), baseDate.AddDays(-1.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(0.0)}

        Dim [end]() As DateTime = {baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0), baseDate.AddDays(-3.0).AddHours(14.0), baseDate.AddDays(-2.0).AddHours(13.0), baseDate.AddDays(-1.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(14.0), baseDate.AddDays(-4.0).AddHours(16.0), baseDate.AddDays(-4.0).AddHours(32.0)}

        Dim summaries(8) As String
        For i As Integer = 0 To 8
            summaries(i) = "Tsk " & (i + 1).ToString()
        Next
        Dim descriptions() As String = {"", "", "", "", "", "", "", "", ""}
        Dim locations() As String = {"", "", "", "", "", "", "", "", ""}
        Dim backgrounds() As AppointmentBackground = {AppointmentBackground.Business, AppointmentBackground.MustAttend, AppointmentBackground.Personal, AppointmentBackground.Important, AppointmentBackground.NeedsPreparation, AppointmentBackground.Birthday, AppointmentBackground.TravelRequired, AppointmentBackground.NeedsPreparation, AppointmentBackground.Business}
        Dim statuses() As AppointmentStatus = {AppointmentStatus.Busy, AppointmentStatus.Free, AppointmentStatus.Busy, AppointmentStatus.Tentative, AppointmentStatus.Tentative, AppointmentStatus.Tentative, AppointmentStatus.Free, AppointmentStatus.Free, AppointmentStatus.Busy}

        Dim appointment As Appointment = Nothing
        For i As Integer = 0 To summaries.Length - 1
            appointment = New Appointment(start(i), [end](i), summaries(i), descriptions(i), locations(i))
            appointment.BackgroundId = CInt(Fix(backgrounds(i)))
            appointment.StatusId = CInt(Fix(statuses(i)))
            Me.Rshcmms.Appointments.Add(appointment)
        Next i
    End Sub

    'Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
    '    Dim openFileDialog As New OpenFileDialog()
    '    openFileDialog.AddExtension = True
    '    openFileDialog.DefaultExt = ".ics"
    '    openFileDialog.Filter = "iCal files (*.ics)|*.ics|All files (*.*)|*.*"
    '    openFileDialog.Multiselect = False

    '    If openFileDialog.ShowDialog() = DialogResult.OK Then

    '        Using fileStream As FileStream = File.OpenRead(openFileDialog.FileName)
    '            Me.Rshcmms.Import(fileStream, New SchedulerICalendarImporter())
    '        End Using
    '    End If
    'End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.AddExtension = True
        saveFileDialog.DefaultExt = ".xml"
        saveFileDialog.Filter = "iCal files (*.ics)|*.ics|All files (*.*)|*.*"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Using fileStream As FileStream = File.Create(saveFileDialog.FileName)
                Me.Rshcmms.Export(fileStream, New SchedulerICalendarExporter())
            End Using
        End If
    End Sub

    Private Sub Rshcmms_AppointmentFormatting(sender As Object, e As SchedulerAppointmentEventArgs) Handles Rshcmms.AppointmentFormatting
        'e.AppointmentElement.ShowAppointmentDescription = True
        'e.AppointmentElement.Location.
    End Sub
End Class