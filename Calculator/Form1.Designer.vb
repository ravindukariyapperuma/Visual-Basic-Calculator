<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calcutator
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
        Me.display = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_sqrt = New System.Windows.Forms.Button()
        Me.btn_plusOrmin = New System.Windows.Forms.Button()
        Me.btn_div = New System.Windows.Forms.Button()
        Me.btn_mul = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_sub = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_equl = New System.Windows.Forms.Button()
        Me.btn_point = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'display
        '
        Me.display.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display.Location = New System.Drawing.Point(12, 12)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(296, 40)
        Me.display.TabIndex = 0
        Me.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.LightSalmon
        Me.btn_clear.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(13, 58)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(69, 66)
        Me.btn_clear.TabIndex = 1
        Me.btn_clear.Text = "C"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_sqrt
        '
        Me.btn_sqrt.BackColor = System.Drawing.Color.LawnGreen
        Me.btn_sqrt.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sqrt.Location = New System.Drawing.Point(88, 58)
        Me.btn_sqrt.Name = "btn_sqrt"
        Me.btn_sqrt.Size = New System.Drawing.Size(69, 66)
        Me.btn_sqrt.TabIndex = 2
        Me.btn_sqrt.Text = "Sqrt"
        Me.btn_sqrt.UseVisualStyleBackColor = False
        '
        'btn_plusOrmin
        '
        Me.btn_plusOrmin.BackColor = System.Drawing.Color.LawnGreen
        Me.btn_plusOrmin.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_plusOrmin.Location = New System.Drawing.Point(163, 58)
        Me.btn_plusOrmin.Name = "btn_plusOrmin"
        Me.btn_plusOrmin.Size = New System.Drawing.Size(69, 66)
        Me.btn_plusOrmin.TabIndex = 3
        Me.btn_plusOrmin.Text = "+ -"
        Me.btn_plusOrmin.UseVisualStyleBackColor = False
        '
        'btn_div
        '
        Me.btn_div.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_div.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_div.Location = New System.Drawing.Point(238, 58)
        Me.btn_div.Name = "btn_div"
        Me.btn_div.Size = New System.Drawing.Size(69, 66)
        Me.btn_div.TabIndex = 4
        Me.btn_div.Text = "/"
        Me.btn_div.UseVisualStyleBackColor = False
        '
        'btn_mul
        '
        Me.btn_mul.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_mul.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mul.Location = New System.Drawing.Point(239, 133)
        Me.btn_mul.Name = "btn_mul"
        Me.btn_mul.Size = New System.Drawing.Size(69, 66)
        Me.btn_mul.TabIndex = 8
        Me.btn_mul.Text = "X"
        Me.btn_mul.UseVisualStyleBackColor = False
        '
        'btn_9
        '
        Me.btn_9.BackColor = System.Drawing.Color.Yellow
        Me.btn_9.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_9.Location = New System.Drawing.Point(164, 133)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(69, 66)
        Me.btn_9.TabIndex = 7
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = False
        '
        'btn_8
        '
        Me.btn_8.BackColor = System.Drawing.Color.Yellow
        Me.btn_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_8.Location = New System.Drawing.Point(89, 133)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(69, 66)
        Me.btn_8.TabIndex = 6
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = False
        '
        'btn_7
        '
        Me.btn_7.BackColor = System.Drawing.Color.Yellow
        Me.btn_7.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_7.Location = New System.Drawing.Point(14, 133)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(69, 66)
        Me.btn_7.TabIndex = 5
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = False
        '
        'btn_sub
        '
        Me.btn_sub.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_sub.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sub.Location = New System.Drawing.Point(238, 205)
        Me.btn_sub.Name = "btn_sub"
        Me.btn_sub.Size = New System.Drawing.Size(69, 66)
        Me.btn_sub.TabIndex = 12
        Me.btn_sub.Text = "-"
        Me.btn_sub.UseVisualStyleBackColor = False
        '
        'btn_6
        '
        Me.btn_6.BackColor = System.Drawing.Color.Yellow
        Me.btn_6.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_6.Location = New System.Drawing.Point(163, 205)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(69, 66)
        Me.btn_6.TabIndex = 11
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = False
        '
        'btn_5
        '
        Me.btn_5.BackColor = System.Drawing.Color.Yellow
        Me.btn_5.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_5.Location = New System.Drawing.Point(88, 205)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(69, 66)
        Me.btn_5.TabIndex = 10
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = False
        '
        'btn_4
        '
        Me.btn_4.BackColor = System.Drawing.Color.Yellow
        Me.btn_4.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_4.Location = New System.Drawing.Point(13, 205)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(69, 66)
        Me.btn_4.TabIndex = 9
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_add.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(238, 277)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(69, 66)
        Me.btn_add.TabIndex = 16
        Me.btn_add.Text = "+"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_3
        '
        Me.btn_3.BackColor = System.Drawing.Color.Yellow
        Me.btn_3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3.Location = New System.Drawing.Point(163, 277)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(69, 66)
        Me.btn_3.TabIndex = 15
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = False
        '
        'btn_2
        '
        Me.btn_2.BackColor = System.Drawing.Color.Yellow
        Me.btn_2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2.Location = New System.Drawing.Point(88, 277)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(69, 66)
        Me.btn_2.TabIndex = 14
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = False
        '
        'btn_1
        '
        Me.btn_1.BackColor = System.Drawing.Color.Yellow
        Me.btn_1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1.Location = New System.Drawing.Point(13, 277)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(69, 66)
        Me.btn_1.TabIndex = 13
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = False
        '
        'btn_equl
        '
        Me.btn_equl.BackColor = System.Drawing.Color.Lime
        Me.btn_equl.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_equl.Location = New System.Drawing.Point(164, 349)
        Me.btn_equl.Name = "btn_equl"
        Me.btn_equl.Size = New System.Drawing.Size(143, 66)
        Me.btn_equl.TabIndex = 19
        Me.btn_equl.Text = "="
        Me.btn_equl.UseVisualStyleBackColor = False
        '
        'btn_point
        '
        Me.btn_point.BackColor = System.Drawing.Color.Yellow
        Me.btn_point.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_point.Location = New System.Drawing.Point(89, 349)
        Me.btn_point.Name = "btn_point"
        Me.btn_point.Size = New System.Drawing.Size(69, 66)
        Me.btn_point.TabIndex = 18
        Me.btn_point.Text = "."
        Me.btn_point.UseVisualStyleBackColor = False
        '
        'btn_0
        '
        Me.btn_0.BackColor = System.Drawing.Color.Yellow
        Me.btn_0.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_0.Location = New System.Drawing.Point(14, 349)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(69, 66)
        Me.btn_0.TabIndex = 17
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 418)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 418)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 418)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'Calcutator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(320, 425)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_equl)
        Me.Controls.Add(Me.btn_point)
        Me.Controls.Add(Me.btn_0)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.btn_sub)
        Me.Controls.Add(Me.btn_6)
        Me.Controls.Add(Me.btn_5)
        Me.Controls.Add(Me.btn_4)
        Me.Controls.Add(Me.btn_mul)
        Me.Controls.Add(Me.btn_9)
        Me.Controls.Add(Me.btn_8)
        Me.Controls.Add(Me.btn_7)
        Me.Controls.Add(Me.btn_div)
        Me.Controls.Add(Me.btn_plusOrmin)
        Me.Controls.Add(Me.btn_sqrt)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.display)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Calcutator"
        Me.Text = "Calcutator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents display As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_sqrt As Button
    Friend WithEvents btn_plusOrmin As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents btn_mul As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_sub As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_equl As Button
    Friend WithEvents btn_point As Button
    Friend WithEvents btn_0 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
