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
    'Dim RSWo As RadScheduler = New RadScheduler()
    'Dim RSEmp As RadScheduler = New RadScheduler()
    'Dim RSEqp As RadScheduler = New RadScheduler()
    'Dim Rshcmms As RadScheduler = New RadScheduler()
    'Dim tpWo As TableLayoutPanel = New TableLayoutPanel()

    'Dim LblTsk As Label = New Label()
    'Dim Lblwo As Label = New Label()
    'Dim Lblemp As Label = New Label()
    'Dim Lbleqp As Label = New Label()

    Private Sub Rshcmms_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Rcal_SelectionChanged(sender As Object, e As EventArgs) Handles Rcal.SelectionChanged
        If Me.Rcal.SelectedDates.Count > 0 Then
            Me.RsTask.ActiveView.StartDate = Me.Rcal.SelectedDate
            Me.RSwo.ActiveView.StartDate = Me.Rcal.SelectedDate
            Me.RSEmp.ActiveView.StartDate = Me.Rcal.SelectedDate
            Me.RSEqp.ActiveView.StartDate = Me.Rcal.SelectedDate
        End If
    End Sub

    Private Sub frmShedular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TPsch.AutoSize = True
        TPsch.Dock = DockStyle.Fill
        'tpWo.GrowStyle = TableLayoutPanelGrowStyle.AddRows
        'tpWo.AutoSize = True
        'tpWo.Controls.Add(Lblwo)
        'tpWo.Controls.Add(RSWo)
        'RSWo.Dock = DockStyle.Fill



        'Rshcmms.AllowAppointmentMove = False
        'Rshcmms.AllowAppointmentResize = False
        'LblTsk.Text = "Task"
        'Lblwo.Text = "Work Order"
        'Lblemp.Text = "Employee"
        'Lbleqp.Text = "Equipment"

        'For i As Integer = 1 To 3
        '    TPsch.ColumnStyles.RemoveAt(0)
        'Next



        Adjustpanel()
        TPsch.Controls.Remove(TpWo)
        TPsch.Controls.Remove(TpTask)
        TPsch.Controls.Remove(TpEmp)
        TPsch.Controls.Remove(TpEqp)
        TPsch.ColumnCount = 0


        AddHandler RsTask.ActiveViewChanged, AddressOf Rshcmms_ActiveViewChanged
        AddHandler RsTask.ViewNavigated, AddressOf Rshcmms_ViewNavigated

        MonthUpDown.Minimum = 1
        MonthUpDown.Maximum = 12
        MonthUpDown.Value = 1
        SplitContainer2.IsSplitterFixed = True
        SplitContainer1.IsSplitterFixed = True
        SplitContainer2.FixedPanel = FixedPanel.Panel1
        RsTask.AllowAppointmentCreateInline = False
        ChkAllAreas.Checked = True
        radMultiView.Checked = True

        SchedulerNav.AssociatedScheduler = RsTask

        RsTask.ActiveViewType = SchedulerViewType.Month
    End Sub

    Private Sub Rshcmms_AppointmentElementDoubleClick(sender As Object, e As EventArgs)
        If RadTask.Checked = True Then
            FormMain.twTask.DefaultFloatingSize = New Size(900, 1000)
            FormMain.RadDockMain.FloatWindow(FormMain.twTask)
            FormMain.twTask.Select()
        End If
    End Sub

    Private Sub Rshcmms_AppointmentEditDialogShowing(sender As Object, e As AppointmentEditDialogShowingEventArgs)
        e.Cancel = True
    End Sub

    Private Sub Rshcmms_ContextMenuShowing(sender As Object, e As SchedulerContextMenuShowingEventArgs)
        If TypeOf e.Element Is AppointmentElement Then
            e.ContextMenu.Items.RemoveAt(0)
        End If
    End Sub

    Private Sub Rshcmms_AppointmentSelected(sender As Object, e As SchedulerAppointmentEventArgs)

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
        RsTask.Appointments.Clear()
        Dim baseDate As DateTime = DateTime.Today
        Dim start() As DateTime = {baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(9.0), baseDate.AddDays(2.0).AddHours(13.0), baseDate.AddDays(-3.0).AddHours(13.0), baseDate.AddDays(-2.0).AddHours(10.0), baseDate.AddDays(-1.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(0.0)}

        Dim [end]() As DateTime = {baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0), baseDate.AddDays(-3.0).AddHours(14.0), baseDate.AddDays(-2.0).AddHours(13.0), baseDate.AddDays(-1.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(14.0), baseDate.AddDays(-4.0).AddHours(16.0), baseDate.AddDays(-4.0).AddHours(32.0)}

        Dim summaries(8) As String
        For i As Integer = 0 To 8
            summaries(i) = "Tsk " & (i + 1).ToString()
        Next
        Dim appointment As Appointment = Nothing
        For i As Integer = 0 To summaries.Length - 1
            appointment = New Appointment(start(i), [end](i), summaries(i), "", "WorkOrder : Wo1")
            appointment.BackgroundId = AppointmentBackground.MustAttend
            Me.RsTask.Appointments.Add(appointment)
        Next i
        'Dim locations() As String = {"WorkOrder : Wo1", "WorkOrder : Wo1", "WorkOrder : Wo1", "WorkOrder : Wo1", "WorkOrder : Wo1", "WorkOrder : Wo1", "WorkOrder : Wo1", "WorkOrder : Wo1", "WorkOrder : Wo1"}

        appointment = Nothing
        For i As Integer = 21 To 30
            appointment = New Appointment(baseDate.AddDays(1).AddHours(6), baseDate.AddDays(1).AddHours(16), "Tsk " & (i + 1).ToString(), "", "WorkOrder : Wo2")
            appointment.BackgroundId = AppointmentBackground.MustAttend
            Me.RsTask.Appointments.Add(appointment)
        Next i
    End Sub
    Private Sub addWoAppointments(ByRef sche As RadScheduler)
        sche.Appointments.Clear()
        Dim baseDate As DateTime = DateTime.Today
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


        Dim appointment As Appointment = Nothing
        For i As Integer = 0 To summaries.Length - 1
            appointment = New Appointment(baseDate, baseDate.AddHours(6), summaries(i), "", "")
            appointment.BackgroundId = AppointmentBackground.TravelRequired
            sche.Appointments.Add(appointment)
        Next i
    End Sub
    Private Sub addEquipmentAppointments(ByRef sche As RadScheduler)
        sche.Appointments.Clear()
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
            sche.Appointments.Add(appointment)
        Next i
    End Sub

    Private Sub addEmployeeAppointments(ByRef sche As RadScheduler)
        sche.Appointments.Clear()
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

        Dim appointment As Appointment = Nothing
        For i As Integer = 0 To summaries.Length - 1
            appointment = New Appointment(start(i), [end](i), summaries(i), descriptions(i), locations(i))
            appointment.BackgroundId = AppointmentBackground.NeedsPreparation
            'appointment.StatusId = CInt(Fix(statuses(i)))
            sche.Appointments.Add(appointment)
        Next i
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.AddExtension = True
        saveFileDialog.DefaultExt = ".xml"
        saveFileDialog.Filter = "iCal files (*.ics)|*.ics|All files (*.*)|*.*"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Using fileStream As FileStream = File.Create(saveFileDialog.FileName)
                Me.RsTask.Export(fileStream, New SchedulerICalendarExporter())
            End Using
        End If
    End Sub

    Private Sub Rshcmms_AppointmentFormatting(sender As Object, e As SchedulerAppointmentEventArgs)
        'e.AppointmentElement.ShowAppointmentDescription = True
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
            addEmployeeAppointments(RsTask)
          
        ElseIf Type = "Equipment" Then
            addEquipmentAppointments(RsTask)
           
        Else
            addWoAppointments(RsTask)
        End If
    End Sub

    Private Sub Rshcmms_ActiveViewChanged(sender As Object, e As SchedulerViewChangedEventArgs)
        RSwo.ActiveViewType = e.NewView.ViewType
        RSEmp.ActiveViewType = e.NewView.ViewType
        RSEqp.ActiveViewType = e.NewView.ViewType

        If e.NewView.ViewType <> e.OldView.ViewType AndAlso e.NewView.ViewType = SchedulerViewType.Month Then
            Me.RsTask.GetMonthView().WeekCount = 5
            RSwo.GetMonthView().WeekCount = 5
            RSEmp.GetMonthView().WeekCount = 5
            RSEqp.GetMonthView().WeekCount = 5
            grpVisibleM.Visible = False
        ElseIf e.NewView.ViewType <> e.OldView.ViewType AndAlso e.NewView.ViewType = SchedulerViewType.Day Then
            Me.RsTask.GetDayView().DayCount = 1
            grpVisibleM.Visible = False
            RSwo.GetDayView().DayCount = 1
            RSEmp.GetDayView().DayCount = 1
            RSEqp.GetDayView().DayCount = 1
        ElseIf e.NewView.ViewType <> e.OldView.ViewType AndAlso e.NewView.ViewType = SchedulerViewType.Timeline Then
            RsTask.GetTimelineView().ShowTimescale(Timescales.Months)
            grpVisibleM.Visible = True

            Dim timescale As SchedulerTimescale = Me.RsTask.GetTimelineView().GetScaling()
            timescale.DisplayedCellsCount = CInt(Fix(Me.MonthUpDown.Value))

            timescale = RSEmp.GetTimelineView().GetScaling()
            timescale.DisplayedCellsCount = CInt(Fix(Me.MonthUpDown.Value))

            timescale = RSEqp.GetTimelineView().GetScaling()
            timescale.DisplayedCellsCount = CInt(Fix(Me.MonthUpDown.Value))

            timescale = RSwo.GetTimelineView().GetScaling()
            timescale.DisplayedCellsCount = CInt(Fix(Me.MonthUpDown.Value))
        Else
            grpVisibleM.Visible = False
        End If
    End Sub

    Private Sub MonthUpDown_ValueChanged(sender As Object, e As EventArgs) Handles MonthUpDown.ValueChanged
        If RsTask.ActiveViewType = SchedulerViewType.Timeline Then
            Dim timescale As SchedulerTimescale
            timescale = Me.RsTask.GetTimelineView().GetScaling()
            timescale.DisplayedCellsCount = CInt(Fix(Me.MonthUpDown.Value))

            timescale = RSEmp.GetTimelineView().GetScaling()
            timescale.DisplayedCellsCount = CInt(Fix(Me.MonthUpDown.Value))

            timescale = RSEqp.GetTimelineView().GetScaling()
            timescale.DisplayedCellsCount = CInt(Fix(Me.MonthUpDown.Value))

            timescale = RSwo.GetTimelineView().GetScaling()
            timescale.DisplayedCellsCount = CInt(Fix(Me.MonthUpDown.Value))
        End If
    End Sub

    Private Sub ChkAll_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChkWo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkWo.CheckedChanged
        If ChkWo.Checked Then
            'TPsch.Controls.Add(tpWo)
            'tpWo.Dock = DockStyle.Fill
            'tpWo.Visible = True
            TPsch.ColumnCount = TPsch.ColumnCount + 1
            TPsch.Controls.Add(TpWo)
            TpWo.Dock = DockStyle.Fill
            TpWo.Visible = True
            RSwo.ActiveViewType = RsTask.ActiveViewType
            addWoAppointments(RSwo)
        Else
            'If TPsch.Controls.Contains(tpWo) Then
            '    TPsch.Controls.Remove(tpWo)
            '    tpWo.Visible = False
            '    'RSWo.Visible = False
            'End If

            If TPsch.Controls.Contains(TpWo) Then
                TPsch.Controls.Remove(TpWo)
                TPsch.ColumnCount = TPsch.ColumnCount - 1
                TpWo.Visible = False
            End If

        End If
        Adjustpanel()
    End Sub

    Private Sub ChkTask_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTask.CheckedChanged
        If ChkTask.Checked Then
            TPsch.ColumnCount = TPsch.ColumnCount + 1
            TPsch.Controls.Contains(TpTask)
            TPsch.Controls.Add(TpTask)
            TpTask.Dock = DockStyle.Fill
            TpTask.Visible = True
            RsTask.ActiveViewType = RsTask.ActiveViewType
            addTaskAppointments()


            'SchedulerNav.AssociatedScheduler=
        Else
            If TPsch.Controls.Contains(TpTask) Then
                TPsch.Controls.Remove(TpTask)
                TPsch.ColumnCount = TPsch.ColumnCount - 1
                TpTask.Visible = False
            End If

        End If
        Adjustpanel()
    End Sub

    Private Sub ChkEmployee_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEmployee.CheckedChanged
        If ChkEmployee.Checked Then
            TPsch.ColumnCount = TPsch.ColumnCount + 1
            TPsch.Controls.Add(TpEmp)
            TpEmp.Dock = DockStyle.Fill
            TpEmp.Visible = True
            RSEmp.ActiveViewType = RsTask.ActiveViewType
            addEmployeeAppointments(RSEmp)
            'SchedulerNav.AssociatedScheduler=
        Else
            If TPsch.Controls.Contains(TpEmp) Then
                TPsch.Controls.Remove(TpEmp)
                TPsch.ColumnCount = TPsch.ColumnCount - 1
                TpEmp.Visible = False
            End If

        End If
        Adjustpanel()
    End Sub

    Private Sub ChkEquipment_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEquipment.CheckedChanged
        If ChkEquipment.Checked Then
            TPsch.ColumnCount = TPsch.ColumnCount + 1
            TPsch.Controls.Add(TpEqp)
            TpEqp.Dock = DockStyle.Fill
            TpEqp.Visible = True
            RSEmp.ActiveViewType = RsTask.ActiveViewType
            addEquipmentAppointments(RSEqp)
        Else
            If TPsch.Controls.Contains(TpEqp) Then
                TPsch.Controls.Remove(TpEqp)
                TPsch.ColumnCount = TPsch.ColumnCount - 1
                TpEqp.Visible = False
            End If
        End If
        Adjustpanel()

    End Sub

    Private Sub Adjustpanel()

        For Each p As ColumnStyle In TPsch.ColumnStyles
            Dim i As Integer = TPsch.ColumnCount
            p.SizeType = SizeType.Percent
            p.Width = (TPsch.Size.Width / i) * 100
        Next
    End Sub



    Private Sub radsingleView_CheckedChanged(sender As Object, e As EventArgs) Handles radsingleView.CheckedChanged

        'RadTask.Checked = True

        If radsingleView.Checked Then
            grpType.Visible = True
            grpMultiType.Visible = False
        End If

    End Sub

    Private Sub radMultiView_CheckedChanged(sender As Object, e As EventArgs) Handles radMultiView.CheckedChanged
        ChkTask.Checked = True
        ChkWo.Checked = False
        ChkEmployee.Checked = False
        ChkEquipment.Checked = False
        If radMultiView.Checked Then
            grpType.Visible = False
            grpMultiType.Visible = True
        End If
    End Sub

    Private Sub Rshcmms_ViewNavigated(sender As Object, e As SchedulerViewNavigatedEventArgs)
        RSwo.ActiveView.StartDate = RsTask.ActiveView.StartDate
        RSEmp.ActiveView.StartDate = RsTask.ActiveView.StartDate
        RSEqp.ActiveView.StartDate = RsTask.ActiveView.StartDate

    End Sub

    Private Sub SchedulerNav_NavigateBackwardsClick(sender As Object, e As EventArgs) Handles SchedulerNav.NavigateBackwardsClick
        RSwo.ActiveView.StartDate = RsTask.ActiveView.StartDate
        RSEmp.ActiveView.StartDate = RsTask.ActiveView.StartDate
        RSEqp.ActiveView.StartDate = RsTask.ActiveView.StartDate
    End Sub

    Private Sub SchedulerNav_NavigateForwardsClick(sender As Object, e As EventArgs) Handles SchedulerNav.NavigateForwardsClick
        RSwo.ActiveView.StartDate = RsTask.ActiveView.StartDate
        RSEmp.ActiveView.StartDate = RsTask.ActiveView.StartDate
        RSEqp.ActiveView.StartDate = RsTask.ActiveView.StartDate
    End Sub

    Private Sub SchedulerNav_ShowWeekendStateChanged(sender As Object, args As StateChangedEventArgs) Handles SchedulerNav.ShowWeekendStateChanged
        If RsTask.ActiveViewType = SchedulerViewType.Month Then
            RSwo.GetMonthView().ShowWeekend = SchedulerNav.ShowWeekendCheckBox.Checked
            RSEmp.GetMonthView().ShowWeekend = SchedulerNav.ShowWeekendCheckBox.Checked
            RSEqp.GetMonthView().ShowWeekend = SchedulerNav.ShowWeekendCheckBox.Checked
        ElseIf RsTask.ActiveViewType = SchedulerViewType.Week Then
            RSwo.GetWeekView().ShowWeekend = SchedulerNav.ShowWeekendCheckBox.Checked
            RSEmp.GetWeekView().ShowWeekend = SchedulerNav.ShowWeekendCheckBox.Checked
            RSEqp.GetWeekView().ShowWeekend = SchedulerNav.ShowWeekendCheckBox.Checked
        End If
    End Sub

    Private Sub TpTask_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub
End Class