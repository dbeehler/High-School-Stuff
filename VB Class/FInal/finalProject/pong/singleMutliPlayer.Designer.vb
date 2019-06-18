<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class singleMutliPlayer
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
        Me.btnSP = New System.Windows.Forms.Button()
        Me.btnMP = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSP
        '
        Me.btnSP.Location = New System.Drawing.Point(0, 0)
        Me.btnSP.Name = "btnSP"
        Me.btnSP.Size = New System.Drawing.Size(145, 222)
        Me.btnSP.TabIndex = 0
        Me.btnSP.Text = "1 Player"
        Me.btnSP.UseVisualStyleBackColor = True
        '
        'btnMP
        '
        Me.btnMP.Location = New System.Drawing.Point(143, 0)
        Me.btnMP.Name = "btnMP"
        Me.btnMP.Size = New System.Drawing.Size(142, 222)
        Me.btnMP.TabIndex = 1
        Me.btnMP.Text = "2 Player"
        Me.btnMP.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(0, 215)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(285, 48)
        Me.btnMainMenu.TabIndex = 2
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'singleMutliPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnMP)
        Me.Controls.Add(Me.btnSP)
        Me.Name = "singleMutliPlayer"
        Me.ShowIcon = False
        Me.Text = "singleMutliPlayer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSP As System.Windows.Forms.Button
    Friend WithEvents btnMP As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
End Class
