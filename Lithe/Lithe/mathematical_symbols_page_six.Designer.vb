<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mathematical_symbols_page_six
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
        Me.btn_overbrace = New System.Windows.Forms.Button()
        Me.btn_underbrace = New System.Windows.Forms.Button()
        Me.btn_big_wedge = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_overbrace
        '
        Me.btn_overbrace.Location = New System.Drawing.Point(130, 31)
        Me.btn_overbrace.Name = "btn_overbrace"
        Me.btn_overbrace.Size = New System.Drawing.Size(97, 52)
        Me.btn_overbrace.TabIndex = 1
        Me.btn_overbrace.Text = "Overbrace symbol"
        Me.btn_overbrace.UseVisualStyleBackColor = True
        '
        'btn_underbrace
        '
        Me.btn_underbrace.Location = New System.Drawing.Point(242, 31)
        Me.btn_underbrace.Name = "btn_underbrace"
        Me.btn_underbrace.Size = New System.Drawing.Size(97, 52)
        Me.btn_underbrace.TabIndex = 2
        Me.btn_underbrace.Text = "Underbrace symbol"
        Me.btn_underbrace.UseVisualStyleBackColor = True
        '
        'btn_big_wedge
        '
        Me.btn_big_wedge.Location = New System.Drawing.Point(20, 31)
        Me.btn_big_wedge.Name = "btn_big_wedge"
        Me.btn_big_wedge.Size = New System.Drawing.Size(97, 52)
        Me.btn_big_wedge.TabIndex = 0
        Me.btn_big_wedge.Text = "Big wedge symbol"
        Me.btn_big_wedge.UseVisualStyleBackColor = True
        '
        'frm_mathematical_symbols_page_six
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 310)
        Me.Controls.Add(Me.btn_overbrace)
        Me.Controls.Add(Me.btn_underbrace)
        Me.Controls.Add(Me.btn_big_wedge)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_mathematical_symbols_page_six"
        Me.Text = "mathematical_symbols_page_six"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_overbrace As Button
    Friend WithEvents btn_underbrace As Button
    Friend WithEvents btn_big_wedge As Button
End Class
