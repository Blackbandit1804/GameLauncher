<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Console
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
        Me.consoleBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'consoleBox
        '
        Me.consoleBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.consoleBox.Location = New System.Drawing.Point(0, 0)
        Me.consoleBox.Multiline = True
        Me.consoleBox.Name = "consoleBox"
        Me.consoleBox.Size = New System.Drawing.Size(837, 438)
        Me.consoleBox.TabIndex = 0
        '
        'Console
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 438)
        Me.Controls.Add(Me.consoleBox)
        Me.MaximumSize = New System.Drawing.Size(853, 477)
        Me.MinimumSize = New System.Drawing.Size(853, 477)
        Me.Name = "Console"
        Me.Text = "Console"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents consoleBox As TextBox
End Class
