Imports System.ServiceProcess

Public Class frmRestartEpicServices

    Dim serviceName As String
    Dim serviceDisplayName As String
    Dim status As String

    Sub GetAllServices()
        For Each service As ServiceController In ServiceController.GetServices()
            Dim serviceName As String = service.ServiceName
            Dim serviceDisplayName As String = service.DisplayName
            Dim status As String = service.Status
            If serviceName Like "Wdi*" Then
                lst_services.Items.Add(serviceDisplayName)
            End If
        Next
    End Sub

    Private Sub frmRestartEpicServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAllServices()
    End Sub

    Sub lst_services_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_services.SelectedIndexChanged
        lbl_servicedisplayname.Text = lst_services.SelectedItem
        Dim scname As New ServiceController(lst_services.SelectedItem)
        serviceName = scname.ServiceName
        lbl_servicename.Text = serviceName
        Dim scstatus As New ServiceController(lst_services.SelectedItem)
        status = scstatus.Status
        Select Case status
            Case 1
                lbl_servicestatus.Text = "The service is not running"
            Case 2
                lbl_servicestatus.Text = "The service is starting"
            Case 3
                lbl_servicestatus.Text = "The service is stopping"
            Case 4
                lbl_servicestatus.Text = "The service is running"
            Case Else
                lbl_servicestatus.Text = "The Service is in Unknown"
        End Select
    End Sub

    Private Sub btn_rstservice_Click(sender As Object, e As EventArgs) Handles btn_rstservice.Click
        Dim scname As New ServiceController(lst_services.SelectedItem.ToString)
        scname.Stop()
        scname.WaitForStatus(1)
        scname.Start()
    End Sub

    Private Sub btnRestartServices_Click(sender As Object, e As EventArgs) Handles btnRestartServices.Click
        For Each serviceName In lst_services.SelectedItems
            Dim scname As New ServiceController(lst_services.SelectedItem.ToString)
            scname.Start()
        Next
    End Sub

End Class

'References
'http://www.ezzylearning.com/tutorial/display-windows-services-in-vb-net
'http://www.dotnetheaven.com/article/get-all-services-on-a-system-using-vb.net