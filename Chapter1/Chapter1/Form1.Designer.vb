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
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.txtPerimeter = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblPerimeter = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.cmdEvaluate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtWidth
        '
        Me.txtWidth.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtWidth.Location = New System.Drawing.Point(22, 61)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(158, 26)
        Me.txtWidth.TabIndex = 1
        '
        'txtArea
        '
        Me.txtArea.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtArea.Location = New System.Drawing.Point(296, 112)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(158, 26)
        Me.txtArea.TabIndex = 8
        '
        'txtPerimeter
        '
        Me.txtPerimeter.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPerimeter.Location = New System.Drawing.Point(296, 61)
        Me.txtPerimeter.Name = "txtPerimeter"
        Me.txtPerimeter.Size = New System.Drawing.Size(158, 26)
        Me.txtPerimeter.TabIndex = 6
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtHeight.Location = New System.Drawing.Point(22, 112)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(158, 26)
        Me.txtHeight.TabIndex = 3
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblWidth.Location = New System.Drawing.Point(22, 40)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(45, 18)
        Me.lblWidth.TabIndex = 0
        Me.lblWidth.Text = "&Width"
        '
        'lblPerimeter
        '
        Me.lblPerimeter.AutoSize = True
        Me.lblPerimeter.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPerimeter.Location = New System.Drawing.Point(296, 40)
        Me.lblPerimeter.Name = "lblPerimeter"
        Me.lblPerimeter.Size = New System.Drawing.Size(70, 18)
        Me.lblPerimeter.TabIndex = 5
        Me.lblPerimeter.Text = "&Perimeter"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHeight.Location = New System.Drawing.Point(22, 94)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(49, 18)
        Me.lblHeight.TabIndex = 2
        Me.lblHeight.Text = "&Height"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblArea.Location = New System.Drawing.Point(296, 94)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(38, 18)
        Me.lblArea.TabIndex = 7
        Me.lblArea.Text = "&Area"
        '
        'cmdEvaluate
        '
        Me.cmdEvaluate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdEvaluate.Location = New System.Drawing.Point(202, 40)
        Me.cmdEvaluate.Name = "cmdEvaluate"
        Me.cmdEvaluate.Size = New System.Drawing.Size(75, 30)
        Me.cmdEvaluate.TabIndex = 4
        Me.cmdEvaluate.Text = "&Evaluate"
        Me.cmdEvaluate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 176)
        Me.Controls.Add(Me.cmdEvaluate)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblPerimeter)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtPerimeter)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.txtWidth)
        Me.Name = "Form1"
        Me.Text = "Rectangle Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtArea As TextBox
    Friend WithEvents txtPerimeter As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblPerimeter As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents cmdEvaluate As Button
End Class
