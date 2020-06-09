<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_display_image
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_display_image))
        Me.pic_generated_img = New System.Windows.Forms.PictureBox()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_abort = New System.Windows.Forms.Button()
        CType(Me.pic_generated_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_generated_img
        '
        Me.pic_generated_img.Location = New System.Drawing.Point(12, 12)
        Me.pic_generated_img.Name = "pic_generated_img"
        Me.pic_generated_img.Size = New System.Drawing.Size(760, 450)
        Me.pic_generated_img.TabIndex = 0
        Me.pic_generated_img.TabStop = False
        '
        'btn_confirm
        '
        Me.btn_confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.25!)
        Me.btn_confirm.Location = New System.Drawing.Point(12, 468)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(361, 81)
        Me.btn_confirm.TabIndex = 0
        Me.btn_confirm.Text = "Confirm"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'btn_abort
        '
        Me.btn_abort.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.25!)
        Me.btn_abort.Location = New System.Drawing.Point(411, 468)
        Me.btn_abort.Name = "btn_abort"
        Me.btn_abort.Size = New System.Drawing.Size(361, 81)
        Me.btn_abort.TabIndex = 1
        Me.btn_abort.Text = "Abort"
        Me.btn_abort.UseVisualStyleBackColor = True
        '
        'frm_display_image
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btn_abort)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.pic_generated_img)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frm_display_image"
        Me.Text = "Generated Image"
        CType(Me.pic_generated_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pic_generated_img As PictureBox
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_abort As Button
End Class
