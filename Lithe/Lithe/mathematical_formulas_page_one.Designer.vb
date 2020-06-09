<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mathematical_formulas_page_one
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
        Me.btn_left_arrow = New System.Windows.Forms.Button()
        Me.btn_comparator = New System.Windows.Forms.Button()
        Me.btn_x_divides_y = New System.Windows.Forms.Button()
        Me.btn_right_arrow = New System.Windows.Forms.Button()
        Me.btn_paranthesis_matrice = New System.Windows.Forms.Button()
        Me.btn_vector = New System.Windows.Forms.Button()
        Me.btn_matrice = New System.Windows.Forms.Button()
        Me.btn_summentation = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_left_arrow
        '
        Me.btn_left_arrow.Location = New System.Drawing.Point(20, 217)
        Me.btn_left_arrow.Name = "btn_left_arrow"
        Me.btn_left_arrow.Size = New System.Drawing.Size(97, 52)
        Me.btn_left_arrow.TabIndex = 6
        Me.btn_left_arrow.Text = "Left arrow notation"
        Me.btn_left_arrow.UseVisualStyleBackColor = True
        '
        'btn_comparator
        '
        Me.btn_comparator.Location = New System.Drawing.Point(242, 124)
        Me.btn_comparator.Name = "btn_comparator"
        Me.btn_comparator.Size = New System.Drawing.Size(97, 52)
        Me.btn_comparator.TabIndex = 5
        Me.btn_comparator.Text = "Comparator notation"
        Me.btn_comparator.UseVisualStyleBackColor = True
        '
        'btn_x_divides_y
        '
        Me.btn_x_divides_y.Location = New System.Drawing.Point(130, 124)
        Me.btn_x_divides_y.Name = "btn_x_divides_y"
        Me.btn_x_divides_y.Size = New System.Drawing.Size(97, 52)
        Me.btn_x_divides_y.TabIndex = 4
        Me.btn_x_divides_y.Text = """x divides y"" notation"
        Me.btn_x_divides_y.UseVisualStyleBackColor = True
        '
        'btn_right_arrow
        '
        Me.btn_right_arrow.Location = New System.Drawing.Point(130, 217)
        Me.btn_right_arrow.Name = "btn_right_arrow"
        Me.btn_right_arrow.Size = New System.Drawing.Size(97, 52)
        Me.btn_right_arrow.TabIndex = 7
        Me.btn_right_arrow.Text = "Right arrow notation"
        Me.btn_right_arrow.UseVisualStyleBackColor = True
        '
        'btn_paranthesis_matrice
        '
        Me.btn_paranthesis_matrice.Location = New System.Drawing.Point(20, 124)
        Me.btn_paranthesis_matrice.Name = "btn_paranthesis_matrice"
        Me.btn_paranthesis_matrice.Size = New System.Drawing.Size(97, 52)
        Me.btn_paranthesis_matrice.TabIndex = 3
        Me.btn_paranthesis_matrice.Text = "Paranthesis Matrice Notation"
        Me.btn_paranthesis_matrice.UseVisualStyleBackColor = True
        '
        'btn_vector
        '
        Me.btn_vector.Location = New System.Drawing.Point(130, 31)
        Me.btn_vector.Name = "btn_vector"
        Me.btn_vector.Size = New System.Drawing.Size(97, 52)
        Me.btn_vector.TabIndex = 1
        Me.btn_vector.Text = "Vector notation"
        Me.btn_vector.UseVisualStyleBackColor = True
        '
        'btn_matrice
        '
        Me.btn_matrice.Location = New System.Drawing.Point(242, 31)
        Me.btn_matrice.Name = "btn_matrice"
        Me.btn_matrice.Size = New System.Drawing.Size(97, 52)
        Me.btn_matrice.TabIndex = 2
        Me.btn_matrice.Text = "Matrice notation"
        Me.btn_matrice.UseVisualStyleBackColor = True
        '
        'btn_summentation
        '
        Me.btn_summentation.Location = New System.Drawing.Point(20, 31)
        Me.btn_summentation.Name = "btn_summentation"
        Me.btn_summentation.Size = New System.Drawing.Size(97, 52)
        Me.btn_summentation.TabIndex = 0
        Me.btn_summentation.Text = "Summentation notation"
        Me.btn_summentation.UseVisualStyleBackColor = True
        '
        'frm_mathematical_formulas_page_one
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 310)
        Me.Controls.Add(Me.btn_left_arrow)
        Me.Controls.Add(Me.btn_comparator)
        Me.Controls.Add(Me.btn_x_divides_y)
        Me.Controls.Add(Me.btn_right_arrow)
        Me.Controls.Add(Me.btn_paranthesis_matrice)
        Me.Controls.Add(Me.btn_vector)
        Me.Controls.Add(Me.btn_matrice)
        Me.Controls.Add(Me.btn_summentation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_mathematical_formulas_page_one"
        Me.Text = "mathematical_formulas_page_one"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_left_arrow As Button
    Friend WithEvents btn_comparator As Button
    Friend WithEvents btn_x_divides_y As Button
    Friend WithEvents btn_right_arrow As Button
    Friend WithEvents btn_paranthesis_matrice As Button
    Friend WithEvents btn_vector As Button
    Friend WithEvents btn_matrice As Button
    Friend WithEvents btn_summentation As Button
End Class
