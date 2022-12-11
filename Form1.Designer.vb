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
        Me.btnActivation = New System.Windows.Forms.Button()
        Me.txtActivationKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnActivation
        '
        Me.btnActivation.Location = New System.Drawing.Point(98, 128)
        Me.btnActivation.Name = "btnActivation"
        Me.btnActivation.Size = New System.Drawing.Size(495, 119)
        Me.btnActivation.TabIndex = 0
        Me.btnActivation.Text = "Activation"
        Me.btnActivation.UseVisualStyleBackColor = True
        '
        'txtActivationKey
        '
        Me.txtActivationKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActivationKey.Location = New System.Drawing.Point(98, 311)
        Me.txtActivationKey.Name = "txtActivationKey"
        Me.txtActivationKey.Size = New System.Drawing.Size(495, 49)
        Me.txtActivationKey.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 431)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(514, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Click Activation button to generate the activation key"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 584)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtActivationKey)
        Me.Controls.Add(Me.btnActivation)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnActivation As Button
    Friend WithEvents txtActivationKey As TextBox
    Friend WithEvents Label1 As Label
End Class
