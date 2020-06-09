<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_mainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainWindow))
        Me.pic_title = New System.Windows.Forms.PictureBox()
        Me.rtxt_latex_textbox = New System.Windows.Forms.RichTextBox()
        Me.btn_view_latex_snippets = New System.Windows.Forms.Button()
        Me.btn_latex_snippets_help = New System.Windows.Forms.Button()
        Me.btn_save_img = New System.Windows.Forms.Button()
        Me.btn_github = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_name_of_file = New System.Windows.Forms.Label()
        Me.txt_file_name = New System.Windows.Forms.TextBox()
        Me.btn_file_name_help = New System.Windows.Forms.Button()
        CType(Me.pic_title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_title
        '
        Me.pic_title.Image = CType(resources.GetObject("pic_title.Image"), System.Drawing.Image)
        Me.pic_title.Location = New System.Drawing.Point(0, 0)
        Me.pic_title.Name = "pic_title"
        Me.pic_title.Size = New System.Drawing.Size(734, 79)
        Me.pic_title.TabIndex = 0
        Me.pic_title.TabStop = False
        '
        'rtxt_latex_textbox
        '
        Me.rtxt_latex_textbox.Location = New System.Drawing.Point(11, 134)
        Me.rtxt_latex_textbox.Name = "rtxt_latex_textbox"
        Me.rtxt_latex_textbox.Size = New System.Drawing.Size(710, 119)
        Me.rtxt_latex_textbox.TabIndex = 0
        Me.rtxt_latex_textbox.Text = ""
        '
        'btn_view_latex_snippets
        '
        Me.btn_view_latex_snippets.Location = New System.Drawing.Point(572, 97)
        Me.btn_view_latex_snippets.Name = "btn_view_latex_snippets"
        Me.btn_view_latex_snippets.Size = New System.Drawing.Size(123, 23)
        Me.btn_view_latex_snippets.TabIndex = 7
        Me.btn_view_latex_snippets.Text = "View LaTeX Snippets"
        Me.btn_view_latex_snippets.UseVisualStyleBackColor = True
        '
        'btn_latex_snippets_help
        '
        Me.btn_latex_snippets_help.Location = New System.Drawing.Point(698, 97)
        Me.btn_latex_snippets_help.Name = "btn_latex_snippets_help"
        Me.btn_latex_snippets_help.Size = New System.Drawing.Size(27, 23)
        Me.btn_latex_snippets_help.TabIndex = 8
        Me.btn_latex_snippets_help.Text = "?"
        Me.btn_latex_snippets_help.UseVisualStyleBackColor = True
        '
        'btn_save_img
        '
        Me.btn_save_img.Location = New System.Drawing.Point(11, 334)
        Me.btn_save_img.Name = "btn_save_img"
        Me.btn_save_img.Size = New System.Drawing.Size(427, 50)
        Me.btn_save_img.TabIndex = 4
        Me.btn_save_img.Text = "Save LaTeX to PNG"
        Me.btn_save_img.UseVisualStyleBackColor = True
        '
        'btn_github
        '
        Me.btn_github.Location = New System.Drawing.Point(444, 334)
        Me.btn_github.Name = "btn_github"
        Me.btn_github.Size = New System.Drawing.Size(147, 50)
        Me.btn_github.TabIndex = 5
        Me.btn_github.Text = "View the LiThE github page"
        Me.btn_github.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(597, 334)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(124, 50)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.Text = "Exit LiThE"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'lbl_name_of_file
        '
        Me.lbl_name_of_file.AutoSize = True
        Me.lbl_name_of_file.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_name_of_file.Location = New System.Drawing.Point(11, 287)
        Me.lbl_name_of_file.Name = "lbl_name_of_file"
        Me.lbl_name_of_file.Size = New System.Drawing.Size(66, 13)
        Me.lbl_name_of_file.TabIndex = 1
        Me.lbl_name_of_file.Text = "Name of file:"
        '
        'txt_file_name
        '
        Me.txt_file_name.Location = New System.Drawing.Point(77, 284)
        Me.txt_file_name.Name = "txt_file_name"
        Me.txt_file_name.Size = New System.Drawing.Size(118, 20)
        Me.txt_file_name.TabIndex = 2
        '
        'btn_file_name_help
        '
        Me.btn_file_name_help.Location = New System.Drawing.Point(199, 284)
        Me.btn_file_name_help.Name = "btn_file_name_help"
        Me.btn_file_name_help.Size = New System.Drawing.Size(27, 20)
        Me.btn_file_name_help.TabIndex = 3
        Me.btn_file_name_help.Text = "?"
        Me.btn_file_name_help.UseVisualStyleBackColor = True
        '
        'frm_mainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 396)
        Me.Controls.Add(Me.btn_file_name_help)
        Me.Controls.Add(Me.txt_file_name)
        Me.Controls.Add(Me.lbl_name_of_file)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_github)
        Me.Controls.Add(Me.btn_save_img)
        Me.Controls.Add(Me.btn_latex_snippets_help)
        Me.Controls.Add(Me.btn_view_latex_snippets)
        Me.Controls.Add(Me.rtxt_latex_textbox)
        Me.Controls.Add(Me.pic_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_mainWindow"
        Me.Text = "LiThE - IEG"
        CType(Me.pic_title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_title As PictureBox
    Friend WithEvents rtxt_latex_textbox As RichTextBox
    Friend WithEvents btn_view_latex_snippets As Button
    Friend WithEvents btn_latex_snippets_help As Button
    Friend WithEvents btn_save_img As Button
    Friend WithEvents btn_github As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_name_of_file As Label
    Friend WithEvents txt_file_name As TextBox
    Friend WithEvents btn_file_name_help As Button
End Class
