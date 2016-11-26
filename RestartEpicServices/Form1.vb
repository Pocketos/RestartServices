Imports System.ServiceProcess

Public Class frmRestartEpicServices

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Dim serviceName As String
    Dim serviceDisplayName As String
    Dim status As String
    Dim servicefilter As String = ""

    Sub GetAllServices()
        For Each service As ServiceController In ServiceController.GetServices()
            Dim serviceName As String = service.ServiceName
            Dim serviceDisplayName As String = service.DisplayName
            Dim status As String = service.Status
            If serviceDisplayName.IndexOf(servicefilter, 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                lst_services.Items.Add(serviceDisplayName)
            End If
        Next
    End Sub

    Sub SearchAllServices()
        lst_services.Items.Clear()
        servicefilter = txt_searchfilter.Text
        GetAllServices()
        Try
            lst_services.SetSelected(0, True)
        Catch
        End Try

    End Sub

    Sub RestartGlobal()
        Dim scname As New ServiceController(lst_services.SelectedItem.ToString)
        If servicecase() = 1 Then
            MsgBox("The Service is not running")
        End If
        If servicecase() = 2 Then
            MsgBox("The service is starting.  Please wait a moment before trying to restart it.")
        End If

        If servicecase() = 3 Then
            MsgBox("The service is stopping.  Please wait a moment before trying to restart it.")
        End If
        If servicecase() = 4 Then
            Try
                scname.Stop()
                lst_actionlog.Items.Add("Stopping " & lst_services.SelectedItem.ToString)
                scname.WaitForStatus(1)
                lst_actionlog.Items.Add("Waiting for " & lst_services.SelectedItem.ToString)
                scname.Start()
                lst_actionlog.Items.Add("Starting " & lst_services.SelectedItem.ToString)
            Catch ex As Exception
                MsgBox("Unable to alter service status.  Try running the application Administrator")
            End Try
        End If
    End Sub

    Function servicecase()
        Dim scstatus As New ServiceController(lst_services.SelectedItem)
        Return scstatus.Status
    End Function

    Private Sub frmRestartEpicServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAllServices()
        Me.Show()
        txt_searchfilter.Focus()
        Try
            lst_services.SetSelected(0, True)
        Catch
        End Try
    End Sub

    Sub lst_services_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_services.SelectedIndexChanged
        lbl_servicedisplayname.Text = lst_services.SelectedItem
        Dim scname As New ServiceController(lst_services.SelectedItem)
        serviceName = scname.ServiceName
        lbl_servicename.Text = serviceName
        Select Case servicecase()
            Case 1
                lbl_servicestatus.Text = "The service is not running"
            Case 2
                lbl_servicestatus.Text = "The service is starting"
            Case 3
                lbl_servicestatus.Text = "The service is stopping"
            Case 4
                lbl_servicestatus.Text = "The service is running"
            Case Else
                lbl_servicestatus.Text = "The service status is Unknown"
        End Select
    End Sub

    Private Sub btn_rstservice_Click(sender As Object, e As EventArgs) Handles btn_rstservice.Click
        RestartGlobal()
    End Sub

    Private Sub btnRestartServices_Click(sender As Object, e As EventArgs) Handles btnRestartServices.Click
        For Each serviceName In lst_services.Items
            RestartGlobal()
        Next
    End Sub

    Private Sub txt_searchfilter_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_searchfilter.KeyUp
        SearchAllServices()
    End Sub
End Class

'References
'http://www.ezzylearning.com/tutorial/display-windows-services-in-vb-net
'http://www.dotnetheaven.com/article/get-all-services-on-a-system-using-vb.net