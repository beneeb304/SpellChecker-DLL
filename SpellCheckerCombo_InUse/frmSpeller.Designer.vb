<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpeller
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
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnGUI = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(257, 10)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(127, 63)
        Me.btnCheck.TabIndex = 0
        Me.btnCheck.Text = "Check Spelling from DLL"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(12, 10)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(239, 20)
        Me.txtWord.TabIndex = 1
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(12, 60)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 2
        '
        'btnGUI
        '
        Me.btnGUI.Location = New System.Drawing.Point(257, 79)
        Me.btnGUI.Name = "btnGUI"
        Me.btnGUI.Size = New System.Drawing.Size(127, 63)
        Me.btnGUI.TabIndex = 3
        Me.btnGUI.Text = "Show Dialog from DLL GUI"
        Me.btnGUI.UseVisualStyleBackColor = True
        '
        'frmSpeller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 155)
        Me.Controls.Add(Me.btnGUI)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.btnCheck)
        Me.Name = "frmSpeller"
        Me.Text = "Using DLLs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCheck As Button
    Friend WithEvents txtWord As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnGUI As Button
End Class
