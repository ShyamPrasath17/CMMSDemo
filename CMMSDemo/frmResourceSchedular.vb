Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.Collections.Generic
Imports Telerik.WinControls.UI.Scheduler.Dialogs
Imports System.IO
Imports Telerik.WinControls.UI.Scheduler.ICalendar
Public Class frmResourceSchedular
    Dim schedularType_ As String


    Sub New(schedularType As String)
        InitializeComponent()
        schedularType_ = schedularType
    End Sub

    Private Sub frmResourceSchedular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If schedularType_ = "Employee" Then
            addEmployeeAppointments()
            lblSelect.Text = "Employee"
            ChkAll.Text = "All Employees"
        ElseIf schedularType_ = "Equipment" Then
            addEquipmentAppointments()
            lblSelect.Text = "Equipment"
            ChkAll.Text = "All Equipment"
        End If
    End Sub

    Private Sub addEmployeeAppointments()
        Dim baseDate As DateTime = DateTime.Today
        Dim start() As DateTime = {baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(9.0), baseDate.AddDays(2.0).AddHours(13.0), baseDate.AddDays(-3.0).AddHours(13.0), baseDate.AddDays(-2.0).AddHours(10.0), baseDate.AddDays(-1.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(0.0)}

        Dim [end]() As DateTime = {baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0), baseDate.AddDays(-3.0).AddHours(14.0), baseDate.AddDays(-2.0).AddHours(13.0), baseDate.AddDays(-1.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(14.0), baseDate.AddDays(-4.0).AddHours(16.0), baseDate.AddDays(-4.0).AddHours(32.0)}

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
        Dim locations() As String = {"Task : Task 1", "Task : Task 4", "Task : Task 2", "Task : Task 2", "Task : Task 3", "Task : Task 1"}
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
        Dim baseDate As DateTime = DateTime.Today
        Dim start() As DateTime = {baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(10.0), baseDate.AddDays(2.0).AddHours(13.0), baseDate.AddDays(-2.0).AddHours(13.0), baseDate.AddDays(-2.0).AddHours(10.0), baseDate.AddDays(-1.0).AddHours(8.0), baseDate.AddDays(-4.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(0.0)}

        Dim [end]() As DateTime = {baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0), baseDate.AddDays(-2.0).AddHours(14.0), baseDate.AddDays(-2.0).AddHours(13.0), baseDate.AddDays(-1.0).AddHours(13.0), baseDate.AddDays(-4.0).AddHours(14.0), baseDate.AddDays(-4.0).AddHours(16.0), baseDate.AddDays(-4.0).AddHours(32.0)}

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
        Dim locations() As String = {"Task : Task 1", "Task : Task 4", "Task : Task 2", "Task : Task 2", "Task : Task 3", "Task : Task 1"}
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

    Private Sub ChkAll_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAll.CheckedChanged
        If ChkAll.Checked Then
            grpSelect.Enabled = False
        Else
            grpSelect.Enabled = True
        End If
    End Sub
    Private Sub btnImport_Click(sender As Object, e As EventArgs)
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.AddExtension = True
        openFileDialog.DefaultExt = ".ics"
        openFileDialog.Filter = "iCal files (*.ics)|*.ics|All files (*.*)|*.*"
        openFileDialog.Multiselect = False

        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Using fileStream As FileStream = File.OpenRead(openFileDialog.FileName)
                Me.Rshcmms.Import(fileStream, New SchedulerICalendarImporter())
            End Using
        End If
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
End Class