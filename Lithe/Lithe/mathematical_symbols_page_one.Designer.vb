<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mathematical_symbols_page_one
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
        Me.btn_div_symbol = New System.Windows.Forms.Button()
        Me.btn_mul_symbol_x = New System.Windows.Forms.Button()
        Me.btn_mul_symbol_dot = New System.Windows.Forms.Button()
        Me.btn_uneqal = New System.Windows.Forms.Button()
        Me.btn_acute = New System.Windows.Forms.Button()
        Me.btn_bar = New System.Windows.Forms.Button()
        Me.btn_right_vector = New System.Windows.Forms.Button()
        Me.btn_left_vector = New System.Windows.Forms.Button()
        Me.btn_n_root = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_div_symbol
        '
        Me.btn_div_symbol.Location = New System.Drawing.Point(20, 31)
        Me.btn_div_symbol.Name = "btn_div_symbol"
        Me.btn_div_symbol.Size = New System.Drawing.Size(97, 52)
        Me.btn_div_symbol.TabIndex = 0
        Me.btn_div_symbol.Text = "Divide symbol"
        Me.btn_div_symbol.UseVisualStyleBackColor = True
        '
        'btn_mul_symbol_x
        '
        Me.btn_mul_symbol_x.Location = New System.Drawing.Point(242, 31)
        Me.btn_mul_symbol_x.Name = "btn_mul_symbol_x"
        Me.btn_mul_symbol_x.Size = New System.Drawing.Size(97, 52)
        Me.btn_mul_symbol_x.TabIndex = 2
        Me.btn_mul_symbol_x.Text = "Multiplication X"
        Me.btn_mul_symbol_x.UseVisualStyleBackColor = True
        '
        'btn_mul_symbol_dot
        '
        Me.btn_mul_symbol_dot.Location = New System.Drawing.Point(130, 31)
        Me.btn_mul_symbol_dot.Name = "btn_mul_symbol_dot"
        Me.btn_mul_symbol_dot.Size = New System.Drawing.Size(97, 52)
        Me.btn_mul_symbol_dot.TabIndex = 1
        Me.btn_mul_symbol_dot.Text = "Multiplication Dot"
        Me.btn_mul_symbol_dot.UseVisualStyleBackColor = True
        '
        'btn_uneqal
        '
        Me.btn_uneqal.Location = New System.Drawing.Point(20, 124)
        Me.btn_uneqal.Name = "btn_uneqal"
        Me.btn_uneqal.Size = New System.Drawing.Size(97, 52)
        Me.btn_uneqal.TabIndex = 3
        Me.btn_uneqal.Text = "Unequal symbol"
        Me.btn_uneqal.UseVisualStyleBackColor = True
        '
        'btn_acute
        '
        Me.btn_acute.Location = New System.Drawing.Point(130, 217)
        Me.btn_acute.Name = "btn_acute"
        Me.btn_acute.Size = New System.Drawing.Size(97, 52)
        Me.btn_acute.TabIndex = 7
        Me.btn_acute.Text = "Acute symbol"
        Me.btn_acute.UseVisualStyleBackColor = True
        '
        'btn_bar
        '
        Me.btn_bar.Location = New System.Drawing.Point(242, 217)
        Me.btn_bar.Name = "btn_bar"
        Me.btn_bar.Size = New System.Drawing.Size(97, 52)
        Me.btn_bar.TabIndex = 8
        Me.btn_bar.Text = "Bar symbol"
        Me.btn_bar.UseVisualStyleBackColor = True
        '
        'btn_right_vector
        '
        Me.btn_right_vector.Location = New System.Drawing.Point(130, 124)
        Me.btn_right_vector.Name = "btn_right_vector"
        Me.btn_right_vector.Size = New System.Drawing.Size(97, 52)
        Me.btn_right_vector.TabIndex = 4
        Me.btn_right_vector.Text = "Right vector"
        Me.btn_right_vector.UseVisualStyleBackColor = True
        '
        'btn_left_vector
        '
        Me.btn_left_vector.Location = New System.Drawing.Point(242, 124)
        Me.btn_left_vector.Name = "btn_left_vector"
        Me.btn_left_vector.Size = New System.Drawing.Size(97, 52)
        Me.btn_left_vector.TabIndex = 5
        Me.btn_left_vector.Text = "Left vector"
        Me.btn_left_vector.UseVisualStyleBackColor = True
        '
        'btn_n_root
        '
        Me.btn_n_root.Location = New System.Drawing.Point(20, 217)
        Me.btn_n_root.Name = "btn_n_root"
        Me.btn_n_root.Size = New System.Drawing.Size(97, 52)
        Me.btn_n_root.TabIndex = 6
        Me.btn_n_root.Text = "n root"
        Me.btn_n_root.UseVisualStyleBackColor = True
        '
        'frm_mathematical_symbols_page_one
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 310)
        Me.Controls.Add(Me.btn_n_root)
        Me.Controls.Add(Me.btn_left_vector)
        Me.Controls.Add(Me.btn_right_vector)
        Me.Controls.Add(Me.btn_bar)
        Me.Controls.Add(Me.btn_acute)
        Me.Controls.Add(Me.btn_uneqal)
        Me.Controls.Add(Me.btn_mul_symbol_dot)
        Me.Controls.Add(Me.btn_mul_symbol_x)
        Me.Controls.Add(Me.btn_div_symbol)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_mathematical_symbols_page_one"
        Me.Text = "mathematical_symbols_page_one"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_div_symbol As Button
    Friend WithEvents btn_mul_symbol_x As Button
    Friend WithEvents btn_mul_symbol_dot As Button
    Friend WithEvents btn_uneqal As Button
    Friend WithEvents btn_acute As Button
    Friend WithEvents btn_bar As Button
    Friend WithEvents btn_right_vector As Button
    Friend WithEvents btn_left_vector As Button
    Friend WithEvents btn_n_root As Button
End Class
