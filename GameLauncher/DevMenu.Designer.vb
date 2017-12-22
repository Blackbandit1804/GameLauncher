<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DevMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.devmenuSaveLoginCredentials = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Reset Log In Credentials"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(285, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Force Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(149, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Show Installation Folder"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(29, 41)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Foce Enable Play Button"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 108)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(267, 19)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "My.settings.keepKeepLauncherOpen = "
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 127)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(224, 19)
        Me.MaterialLabel2.TabIndex = 5
        Me.MaterialLabel2.Text = "Form1.keepLauncherOpenBox = "
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Nothing
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(12, 149)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(79, 36)
        Me.MaterialRaisedButton1.TabIndex = 6
        Me.MaterialRaisedButton1.Text = "refresh"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(174, 41)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Show Console"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'devmenuSaveLoginCredentials
        '
        Me.devmenuSaveLoginCredentials.AutoSize = True
        Me.devmenuSaveLoginCredentials.Depth = 0
        Me.devmenuSaveLoginCredentials.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.devmenuSaveLoginCredentials.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.devmenuSaveLoginCredentials.Location = New System.Drawing.Point(16, 92)
        Me.devmenuSaveLoginCredentials.MouseState = MaterialSkin.MouseState.HOVER
        Me.devmenuSaveLoginCredentials.Name = "devmenuSaveLoginCredentials"
        Me.devmenuSaveLoginCredentials.Size = New System.Drawing.Size(170, 19)
        Me.devmenuSaveLoginCredentials.TabIndex = 8
        Me.devmenuSaveLoginCredentials.Text = "SaveLoginCredentials = "
        '
        'DevMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 195)
        Me.Controls.Add(Me.devmenuSaveLoginCredentials)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "DevMenu"
        Me.Text = "DevMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Button5 As Button
    Friend WithEvents devmenuSaveLoginCredentials As MaterialSkin.Controls.MaterialLabel
End Class
