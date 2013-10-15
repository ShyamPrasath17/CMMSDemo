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
        If FormMain.frmTskLst.dttask.Select("TaskNo = '" & e.Appointment.Summary.ToString() & "'").Length > 0 Then
            FormMain.frmTsk.filltask(FormMain.frmTskLst.dttask.Select("TaskNo = '" & e.Appointment.Summary.ToString() & "'")(0))
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
            summaries(i) = "Task " & (i + 1).ToString()
        Next
        Dim descriptions() As String = {"Silverlight 3 provides a rich set of options for customizing your controls. Unlike other technologies, creating user and custom controls is not necessary to get the customized control you want. In this talk I will cover Compositing, Styling, Templating and Custom Controls to help attendees understand when and how to customize their controls.", "Face it! The out of the box user interface for your Windows SharePoint Services 3.0 sites and your Microsoft Office SharePoint Server 2007 sites is BORING!  In this session we’ll look at spicing up your life a bit with many ways to make your SharePoint sites 'Web 2.0'. This session includes:1. New AJAX support provided with Service Pack 1. Learn how to AJAX enable your web.config files. Learn to AJAX enable your web parts and to call web services using AJAX. Integrate controls from the AJAX Control ToolKit.2. A look at the SharePoint controls provided by third party Telerik. 3. Silverlight integration into SharePoint And then watch your SharePoint sites come to life!", "Now hat WCF/WF services have gained some popularity companies are starting to ask the question 'How do we manage those services?'. The most common problems with the today’s middle-tier services are related to the deployment of those services to test, staging and production environments, observing the operation of the services deployed, scaling the services that hit the boundaries of their servers, and versioning the services without requiring all clients to get upgraded simultaneously. This talk will show Microsoft’s approach for solving some of these problems. We will start with a single long-running durable Workflow service implemented in .Net 4.0 and we will show how it gets it persistence working. Then we will show how to export it and how to import it in a different environment. After that we will see how to inspect and control instances of that service.", "This session will highlight many of the ways that the Windows Presentation Foundation (WPF) and the Windows Communications Foundation (WCF) can be leveraged in applications built with Visual Studio Tools for the Office System (VSTO). Visual Studio® 2008 introduced an array of new features aimed at a wide range of Office solution types. With Visual Studio 2008, you can build solutions that incorporate the native capabilities of the Office client applications (like Outlook) combined with the sophisticated UI capabilities of WPF that's connected to remote data and services via WCF and use the RAD features of LINQ<br/> to manipulate that data. These new technologies provide opportunities for building owerful solutions with functionality that was previously difficult or impossible to achieve. Now that Office has evolved into a true development platform, office-based solutions are becoming increasingly sophisticated, less document-focused, and more loosely coupled. This session will show you how easy it is to build robust solutions that leverage the latest technologies. WPF provides developers and designers with a unified programming model for building rich Windows smart client user experiences with Office client applications that incorporate UI, media, and documents. WCF contains a support framework and a design-time toolset for building service-oriented solutions that connect rich Office clients with powerful server-side functionality and remote data access. Visual Studio 2008 provides a simple GUI wizard that lets you consume WCF services without having to worry about service metadata, protocols, or XML configuration.", "With the .NET 3.0 Framework, developers were given the plumbing to create business process management solutions graphically. In this session, Mark will introduce the basics of working with Workflow Foundation. This is a 100 level talk for developers that are new to WF. We will spend some time talking about the architecture and when best to use a tool like WF for the greatest return. We'll also compare WF to BizTalk and learn that they are completely different worlds.", "WCF, WPF, Silverlight: Always new Buzzwords appear and come to market with new technologies, which are hard to learn. But how do those technologies integrate and collaborate? Data Access is usually encapsulated in a data access layer. Does this still make sense with the all over presence and acceptance of object-relational mapping (ORM)? Using surprisingly simple tools, you can implement basic and complex applications. This presentation shows that you need to rethink your architecture in order to implement persistent objects in nowadays application requirements. You will learn about the necessary feature set of an object-relational mapping tool and how it simplifies your daily work and how it reduces your data access code by 90%", "Business Data Catalog is a new business integration feature in Microsoft Office SharePoint Server 2007 to surface business data from back-end server applications without any coding. Business Data Catalog bridges the gap between the portal site and your business applications and enables you to bring in key data from various business applications to Office SharePoint Server 2007 lists, Web Parts, search, user profiles, and custom applications. To achieve this goal, Business Data Catalog provides homogeneous access to the underlying data sources with a metadata model that provides a consistent and simplified client object model. Business Data Catalog is the key infrastructural component around which the other Business Data features of Office SharePoint Server 2007 are built. We will explore how to expose SQL-Server 2005 data in a SP 2007 portal.", "Looking for something fun and inspirational? Let Carl Franklin show you some of the fun you can have with Visual Studio .NET and a few cool ideas, from artificial intelligence to practical joke software.", "The Entity Framework combined with the Entity Data Model (EDM) bring data access to a new level in Enterprise Applications. Entity Framework Object Services APIs, while providing a lot of automated functionality, are filled with features that give developers much more control over how objects are handled. The most important jobs of the ObjectContext are relationship management and change tracking. This session drills into how the ObjectContext manages relationships and how you can control its behavior. This is especially important in SOA scenarios where you may need to transport ObjectGraphs. We also look closely at change tracking, focusing on the challenges and solutions for dealing with data concurrency when moving objects across tiers in your enterprise applications. Knowing what to expect from these features and how to take control of them will empower you in your use of the Entity Framework and EDMs in your Web sites, SOA applications, and smart clients, as well as other applications that share the EDM."}
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