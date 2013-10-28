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
        Rshcmms.AllowAppointmentMove = False
        Rshcmms.AllowAppointmentResize = False
        SplitContainer2.IsSplitterFixed = True
        SplitContainer1.IsSplitterFixed = True
        SplitContainer2.FixedPanel = FixedPanel.Panel1
        Rshcmms.AllowAppointmentCreateInline = False
        ChkAllAreas.Checked = True
        cmbView.SelectedItem = "Weekly"
    End Sub

    Private Sub Rshcmms_AppointmentElementDoubleClick(sender As Object, e As EventArgs) Handles Rshcmms.AppointmentElementDoubleClick
        If RadTask.Checked = True Then
            FormMain.twTask.DefaultFloatingSize = New Size(900, 1000)
            FormMain.RadDockMain.FloatWindow(FormMain.twTask)
            FormMain.twTask.Select()
        End If
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
       
    End Sub

    Private Sub BtnViewResourceSchedular_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChkAllAreas_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAllAreas.CheckedChanged
        If ChkAllAreas.Checked Then
            grpSite.Enabled = False
        Else
            grpSite.Enabled = True
        End If
    End Sub

    Private Sub addTaskAppointments()
        Rshcmms.Appointments.Clear()
        Dim baseDate As DateTime = DateTime.Today
        Dim start() As DateTime = {baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(9.0), baseDate.AddDays(2.0).AddHours(13.0), baseDate.AddDays(-3.0).AddHours(13.0), baseDate.AddDays(-2.0).AddHours(10.0), baseDate.AddDays(-1.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(0.0)}

        Dim [end]() As DateTime = {baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0), baseDate.AddDays(-3.0).AddHours(14.0), baseDate.AddDays(-2.0).AddHours(13.0), baseDate.AddDays(-1.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(14.0), baseDate.AddDays(-4.0).AddHours(16.0), baseDate.AddDays(-4.0).AddHours(32.0)}

        Dim summaries(8) As String
        For i As Integer = 0 To 8
            summaries(i) = "Tsk " & (i + 1).ToString()
        Next
        Dim descriptions() As String = {"", "", "", "", "", "", "", "", ""}
        Dim locations() As String = {"WorkOrder : Wo1", "WorkOrder : Wo1", "WorkOrder : Wo1", "WorkOrder : Wo1", "WorkOrder : Wo1", "WorkOrder : Wo1", "WorkOrder : Wo1", "WorkOrder : Wo1", "WorkOrder : Wo1"}
        'Dim backgrounds() As AppointmentBackground = {AppointmentBackground.Important, AppointmentBackground.Important, AppointmentBackground.Important, AppointmentBackground.Important, AppointmentBackground.NeedsPreparation, AppointmentBackground.Birthday, AppointmentBackground.TravelRequired, AppointmentBackground.NeedsPreparation, AppointmentBackground.Business}
        ' Dim statuses() As AppointmentStatus = {AppointmentStatus.Busy, AppointmentStatus.Busy, AppointmentStatus.Busy, AppointmentStatus.Busy, AppointmentStatus.Busy, AppointmentStatus.Busy, AppointmentStatus.Busy, AppointmentStatus.Busy, AppointmentStatus.Busy}

        Dim appointment As Appointment = Nothing
        For i As Integer = 0 To summaries.Length - 1
            appointment = New Appointment(start(i), [end](i), summaries(i), descriptions(i), locations(i))
            appointment.BackgroundId = AppointmentBackground.MustAttend
            'appointment.StatusId = CInt(Fix(statuses(i)))
            Me.Rshcmms.Appointments.Add(appointment)
        Next i
    End Sub
    Private Sub addWoAppointments()
        Rshcmms.Appointments.Clear()
        Dim baseDate As DateTime = DateTime.Today
        Dim start() As DateTime = {baseDate, baseDate, baseDate, baseDate, baseDate, baseDate.AddDays(-1.0).AddHours(8.0), baseDate.AddDays(-4.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(0.0)}

        Dim [end]() As DateTime = {baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0), baseDate.AddDays(-2.0).AddHours(14.0), baseDate.AddDays(-2.0).AddHours(13.0), baseDate.AddDays(-1.0).AddHours(13.0), baseDate.AddDays(-4.0).AddHours(14.0), baseDate.AddDays(-4.0).AddHours(16.0), baseDate.AddDays(-4.0).AddHours(32.0)}

        Dim summaries(5) As String
        'For i As Integer = 0 To 5
        '    summaries(i) = "Equipment " & (i + 1).ToString()
        'Next
        summaries(0) = "WorkOrderNo " & (1).ToString()
        summaries(1) = "WorkOrderNo " & (2).ToString()
        summaries(2) = "WorkOrderNo " & (3).ToString()
        summaries(3) = "WorkOrderNo " & (2).ToString()
        summaries(4) = "WorkOrderNo " & (3).ToString()
        summaries(5) = "WorkOrderNo " & (4).ToString()
        Dim descriptions() As String = {"", "", "", "", "", ""}
        Dim locations() As String = {"", "", "", "", "", ""}
        Dim backgrounds() As AppointmentBackground = {AppointmentBackground.TravelRequired, AppointmentBackground.TravelRequired, AppointmentBackground.TravelRequired, AppointmentBackground.TravelRequired, AppointmentBackground.TravelRequired, AppointmentBackground.TravelRequired}
        'Dim statuses() As AppointmentStatus = {AppointmentStatus.Busy, AppointmentStatus.Free, AppointmentStatus.Busy, AppointmentStatus.Tentative, AppointmentStatus.Tentative, AppointmentStatus.Tentative, AppointmentStatus.Free, AppointmentStatus.Free, AppointmentStatus.Busy}

        Dim appointment As Appointment = Nothing
        For i As Integer = 0 To summaries.Length - 1
            appointment = New Appointment(start(i), [end](i), summaries(i), descriptions(i), locations(i))
            appointment.BackgroundId = CInt(Fix(backgrounds(i)))
            'appointment.StatusId = CInt(Fix(statuses(i)))
            Me.Rshcmms.Appointments.Add(appointment)
        Next i
    End Sub
    Private Sub addEquipmentAppointments()
        Rshcmms.Appointments.Clear()
        Dim baseDate As DateTime = DateTime.Today
        Dim start() As DateTime = {baseDate.AddHours(2.0), baseDate.AddHours(3.0), baseDate.AddHours(1.0), baseDate.AddDays(-2.0).AddHours(13.0), baseDate.AddDays(-2.0).AddHours(10.0), baseDate.AddDays(-1.0).AddHours(8.0), baseDate.AddDays(-4.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(0.0)}

        Dim [end]() As DateTime = {baseDate.AddHours(6.0), baseDate.AddHours(5.0), baseDate.AddHours(5.0), baseDate.AddDays(-2.0).AddHours(14.0), baseDate.AddDays(-2.0).AddHours(13.0), baseDate.AddDays(-1.0).AddHours(13.0), baseDate.AddDays(-4.0).AddHours(14.0), baseDate.AddDays(-4.0).AddHours(16.0), baseDate.AddDays(-4.0).AddHours(32.0)}

        Dim summaries(5) As String
        'For i As Integer = 0 To 5
        '    summaries(i) = "Equipment " & (i + 1).ToString()
        'Next
        summaries(0) = "Equipment " & (1).ToString()
        summaries(1) = "Equipment " & (2).ToString()
        summaries(2) = "Equipment " & (3).ToString()
        summaries(3) = "Equipment " & (2).ToString()
        summaries(4) = "Equipment " & (3).ToString()
        summaries(5) = "Equipment " & (4).ToString()
        Dim descriptions() As String = {"", "", "", "", "", ""}
        Dim locations() As String = {"Task : Tsk 1", "Task : Tsk 4", "Task : Tsk 2", "Task : Tsk 2", "Task : Tsk 3", "Task : Tsk 1"}
        Dim appointment As Appointment = Nothing
        For i As Integer = 0 To summaries.Length - 1
            appointment = New Appointment(start(i), [end](i), summaries(i), descriptions(i), locations(i))
            appointment.BackgroundId = AppointmentBackground.TravelRequired
            Me.Rshcmms.Appointments.Add(appointment)
        Next i
    End Sub

    Private Sub addEmployeeAppointments()
        Rshcmms.Appointments.Clear()
        Dim baseDate As DateTime = DateTime.Today
        Dim start() As DateTime = {baseDate.AddHours(4.0), baseDate.AddHours(5.0), baseDate.AddDays(1.0).AddHours(2.0), baseDate.AddDays(-3.0).AddHours(13.0), baseDate.AddDays(-2.0).AddHours(10.0), baseDate.AddDays(-1.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(0.0)}

        Dim [end]() As DateTime = {baseDate.AddHours(8.0), baseDate.AddHours(6.0), baseDate.AddDays(1.0).AddHours(8.0), baseDate.AddDays(-3.0).AddHours(14.0), baseDate.AddDays(-2.0).AddHours(13.0), baseDate.AddDays(-1.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(14.0), baseDate.AddDays(-4.0).AddHours(16.0), baseDate.AddDays(-4.0).AddHours(32.0)}

        Dim summaries(5) As String
        'For i As Integer = 0 To 5
        '    summaries(i) = "Equipment " & (i + 1).ToString()
        'Next
        summaries(0) = "Employee " & (1).ToString()
        summaries(1) = "Employee " & (2).ToString()
        summaries(2) = "Employee " & (3).ToString()
        summaries(3) = "Employee " & (2).ToString()
        summaries(4) = "Employee " & (3).ToString()
        summaries(5) = "Employee " & (4).ToString()
        Dim descriptions() As String = {"", "", "", "", "", ""}
        Dim locations() As String = {"Task : Tsk 1", "Task : Tsk 4", "Task : Tsk 2", "Task : Tsk 2", "Task : Tsk 3", "Task : Tsk 1"}
        Dim backgrounds() As AppointmentBackground = {AppointmentBackground.Business, AppointmentBackground.Business, AppointmentBackground.Business, AppointmentBackground.Business, AppointmentBackground.Business, AppointmentBackground.Business}
        'Dim statuses() As AppointmentStatus = {AppointmentStatus.Busy, AppointmentStatus.Free, AppointmentStatus.Busy, AppointmentStatus.Tentative, AppointmentStatus.Tentative, AppointmentStatus.Tentative, AppointmentStatus.Free, AppointmentStatus.Free, AppointmentStatus.Busy}

        Dim appointment As Appointment = Nothing
        For i As Integer = 0 To summaries.Length - 1
            appointment = New Appointment(start(i), [end](i), summaries(i), descriptions(i), locations(i))
            appointment.BackgroundId = CInt(Fix(backgrounds(i)))
            'appointment.StatusId = CInt(Fix(statuses(i)))
            Me.Rshcmms.Appointments.Add(appointment)
        Next i
    End Sub

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
    End Sub

    Private Sub cmbView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbView.SelectedIndexChanged
        If cmbView.SelectedItem.ToString() = "Daily" Then
            Rshcmms.ActiveViewType = SchedulerViewType.MultiDay
        ElseIf cmbView.SelectedItem.ToString() = "Weekly" Then
            Rshcmms.ActiveViewType = SchedulerViewType.Week
        Else
            Rshcmms.ActiveViewType = SchedulerViewType.Month
        End If
    End Sub

    Private Sub RadWo_CheckedChanged(sender As Object, e As EventArgs) Handles RadWo.CheckedChanged
        If RadWo.Checked Then
            ShowSchedular("WorkOrder")
        End If
    End Sub

    Private Sub RadTask_CheckedChanged(sender As Object, e As EventArgs) Handles RadTask.CheckedChanged
        If RadTask.Checked Then
            ShowSchedular("Task")
        End If
    End Sub

    Private Sub RadEmp_CheckedChanged(sender As Object, e As EventArgs) Handles RadEmp.CheckedChanged
        If RadEmp.Checked Then
            ShowSchedular("Employee")
        End If
    End Sub

    Private Sub RadWoEqp_CheckedChanged(sender As Object, e As EventArgs) Handles RadWoEqp.CheckedChanged
        If RadWoEqp.Checked Then
            ShowSchedular("Equipment")
        End If
    End Sub

    Private Sub ShowSchedular(Type As String)
        If Type = "Task" Then
            addTaskAppointments()
        ElseIf Type = "Employee" Then
            addEmployeeAppointments()
        ElseIf Type = "Equipment" Then
            addEquipmentAppointments()
        Else
            addWoAppointments()
        End If
    End Sub

End Class