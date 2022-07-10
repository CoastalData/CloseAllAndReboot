<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.txtProcessName = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkReboot = New System.Windows.Forms.CheckBox()
        Me.chkVerify = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdRun
        '
        Me.cmdRun.AutoSize = True
        Me.cmdRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdRun.BackColor = System.Drawing.Color.DarkOrange
        Me.cmdRun.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdRun.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdRun.Location = New System.Drawing.Point(0, 150)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(347, 42)
        Me.cmdRun.TabIndex = 0
        Me.cmdRun.Text = "CLICK HERE TO CLOSE ALL"
        Me.cmdRun.UseVisualStyleBackColor = False
        '
        'txtProcessName
        '
        Me.txtProcessName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProcessName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProcessName.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtProcessName.Location = New System.Drawing.Point(11, 108)
        Me.txtProcessName.Multiline = True
        Me.txtProcessName.Name = "txtProcessName"
        Me.txtProcessName.Size = New System.Drawing.Size(318, 14)
        Me.txtProcessName.TabIndex = 1
        Me.txtProcessName.Text = "Process Name"
        Me.txtProcessName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.chkReboot)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkVerify)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmdCancel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(347, 25)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'chkReboot
        '
        Me.chkReboot.AutoSize = True
        Me.chkReboot.Checked = True
        Me.chkReboot.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReboot.Location = New System.Drawing.Point(3, 3)
        Me.chkReboot.Name = "chkReboot"
        Me.chkReboot.Size = New System.Drawing.Size(64, 19)
        Me.chkReboot.TabIndex = 2
        Me.chkReboot.Text = "Reboot"
        Me.ToolTip1.SetToolTip(Me.chkReboot, "Should the operating system request a reboot when done?")
        Me.chkReboot.UseVisualStyleBackColor = True
        '
        'chkVerify
        '
        Me.chkVerify.AutoSize = True
        Me.chkVerify.Checked = True
        Me.chkVerify.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVerify.Location = New System.Drawing.Point(73, 3)
        Me.chkVerify.Name = "chkVerify"
        Me.chkVerify.Size = New System.Drawing.Size(135, 19)
        Me.chkVerify.TabIndex = 3
        Me.chkVerify.Text = "Verify User Processes"
        Me.ToolTip1.SetToolTip(Me.chkVerify, "Slower - Attempt to verify ownership of every process before asking it to close")
        Me.chkVerify.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(214, 0)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.622951!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.37705!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtProcessName, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCount, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.018518!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.98148!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(347, 125)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'lblCount
        '
        Me.lblCount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCount.AutoSize = True
        Me.lblCount.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCount.Location = New System.Drawing.Point(11, 6)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(318, 99)
        Me.lblCount.TabIndex = 3
        Me.lblCount.Text = "01"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AcceptButton = Me.cmdRun
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(347, 192)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.cmdRun)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "!! CLOSE ALL AND REBOOT ?? !!"
        Me.TopMost = True
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdRun As Button
    Friend WithEvents txtProcessName As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents chkReboot As CheckBox
    Friend WithEvents chkVerify As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblCount As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cmdCancel As Button
End Class
