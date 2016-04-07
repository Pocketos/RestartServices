<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestartEpicServices
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRestartServices = New System.Windows.Forms.Button()
        Me.btn_rstservice = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tb_lbl_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lst_services = New System.Windows.Forms.ListBox()
        Me.lbl_servicedisplayname = New System.Windows.Forms.Label()
        Me.lbl_servicename = New System.Windows.Forms.Label()
        Me.lbl_servicestatus = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRestartServices
        '
        Me.btnRestartServices.Location = New System.Drawing.Point(311, 166)
        Me.btnRestartServices.Name = "btnRestartServices"
        Me.btnRestartServices.Size = New System.Drawing.Size(91, 23)
        Me.btnRestartServices.TabIndex = 0
        Me.btnRestartServices.Text = "Restart All"
        Me.btnRestartServices.UseVisualStyleBackColor = True
        '
        'btn_rstservice
        '
        Me.btn_rstservice.Location = New System.Drawing.Point(311, 137)
        Me.btn_rstservice.Name = "btn_rstservice"
        Me.btn_rstservice.Size = New System.Drawing.Size(91, 23)
        Me.btn_rstservice.TabIndex = 2
        Me.btn_rstservice.Text = "Restart Service"
        Me.btn_rstservice.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tb_lbl_status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 196)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(414, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tb_lbl_status
        '
        Me.tb_lbl_status.Name = "tb_lbl_status"
        Me.tb_lbl_status.Size = New System.Drawing.Size(64, 17)
        Me.tb_lbl_status.Text = "Version 1.0"
        '
        'lst_services
        '
        Me.lst_services.FormattingEnabled = True
        Me.lst_services.Location = New System.Drawing.Point(12, 13)
        Me.lst_services.Name = "lst_services"
        Me.lst_services.Size = New System.Drawing.Size(390, 108)
        Me.lst_services.TabIndex = 8
        '
        'lbl_servicedisplayname
        '
        Me.lbl_servicedisplayname.AutoSize = True
        Me.lbl_servicedisplayname.Location = New System.Drawing.Point(12, 137)
        Me.lbl_servicedisplayname.Name = "lbl_servicedisplayname"
        Me.lbl_servicedisplayname.Size = New System.Drawing.Size(69, 13)
        Me.lbl_servicedisplayname.TabIndex = 9
        Me.lbl_servicedisplayname.Text = "DisplayName"
        '
        'lbl_servicename
        '
        Me.lbl_servicename.AutoSize = True
        Me.lbl_servicename.Location = New System.Drawing.Point(12, 156)
        Me.lbl_servicename.Name = "lbl_servicename"
        Me.lbl_servicename.Size = New System.Drawing.Size(71, 13)
        Me.lbl_servicename.TabIndex = 10
        Me.lbl_servicename.Text = "ServiceName"
        '
        'lbl_servicestatus
        '
        Me.lbl_servicestatus.AutoSize = True
        Me.lbl_servicestatus.Location = New System.Drawing.Point(12, 175)
        Me.lbl_servicestatus.Name = "lbl_servicestatus"
        Me.lbl_servicestatus.Size = New System.Drawing.Size(73, 13)
        Me.lbl_servicestatus.TabIndex = 11
        Me.lbl_servicestatus.Text = "ServiceStatus"
        '
        'frmRestartEpicServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 218)
        Me.Controls.Add(Me.lbl_servicestatus)
        Me.Controls.Add(Me.lbl_servicename)
        Me.Controls.Add(Me.lbl_servicedisplayname)
        Me.Controls.Add(Me.lst_services)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_rstservice)
        Me.Controls.Add(Me.btnRestartServices)
        Me.Name = "frmRestartEpicServices"
        Me.Text = "Epic Services"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRestartServices As System.Windows.Forms.Button
    Friend WithEvents btn_rstservice As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tb_lbl_status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lst_services As System.Windows.Forms.ListBox
    Friend WithEvents lbl_servicedisplayname As System.Windows.Forms.Label
    Friend WithEvents lbl_servicename As System.Windows.Forms.Label
    Friend WithEvents lbl_servicestatus As System.Windows.Forms.Label

End Class
