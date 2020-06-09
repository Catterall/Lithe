<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_latex_snippets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_latex_snippets))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menu_maths_symbols = New System.Windows.Forms.ToolStripMenuItem()
        Me.Page1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Page2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Page3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Page4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Page5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Page6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_maths_formulas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Page1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_snippets = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_maths_symbols, Me.menu_maths_formulas})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menu_maths_symbols
        '
        Me.menu_maths_symbols.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Page1ToolStripMenuItem, Me.Page2ToolStripMenuItem, Me.Page3ToolStripMenuItem, Me.Page4ToolStripMenuItem, Me.Page5ToolStripMenuItem, Me.Page6ToolStripMenuItem})
        Me.menu_maths_symbols.Name = "menu_maths_symbols"
        Me.menu_maths_symbols.Size = New System.Drawing.Size(140, 20)
        Me.menu_maths_symbols.Text = "Mathematical Symbols"
        '
        'Page1ToolStripMenuItem
        '
        Me.Page1ToolStripMenuItem.Name = "Page1ToolStripMenuItem"
        Me.Page1ToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.Page1ToolStripMenuItem.Text = "Page 1"
        '
        'Page2ToolStripMenuItem
        '
        Me.Page2ToolStripMenuItem.Name = "Page2ToolStripMenuItem"
        Me.Page2ToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.Page2ToolStripMenuItem.Text = "Page 2"
        '
        'Page3ToolStripMenuItem
        '
        Me.Page3ToolStripMenuItem.Name = "Page3ToolStripMenuItem"
        Me.Page3ToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.Page3ToolStripMenuItem.Text = "Page 3"
        '
        'Page4ToolStripMenuItem
        '
        Me.Page4ToolStripMenuItem.Name = "Page4ToolStripMenuItem"
        Me.Page4ToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.Page4ToolStripMenuItem.Text = "Page 4"
        '
        'Page5ToolStripMenuItem
        '
        Me.Page5ToolStripMenuItem.Name = "Page5ToolStripMenuItem"
        Me.Page5ToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.Page5ToolStripMenuItem.Text = "Page 5"
        '
        'Page6ToolStripMenuItem
        '
        Me.Page6ToolStripMenuItem.Name = "Page6ToolStripMenuItem"
        Me.Page6ToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.Page6ToolStripMenuItem.Text = "Page 6"
        '
        'menu_maths_formulas
        '
        Me.menu_maths_formulas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Page1ToolStripMenuItem1})
        Me.menu_maths_formulas.Name = "menu_maths_formulas"
        Me.menu_maths_formulas.Size = New System.Drawing.Size(144, 20)
        Me.menu_maths_formulas.Text = "Mathematical Formulas"
        '
        'Page1ToolStripMenuItem1
        '
        Me.Page1ToolStripMenuItem1.Name = "Page1ToolStripMenuItem1"
        Me.Page1ToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.Page1ToolStripMenuItem1.Text = "Page 1"
        '
        'pnl_snippets
        '
        Me.pnl_snippets.Location = New System.Drawing.Point(12, 36)
        Me.pnl_snippets.Name = "pnl_snippets"
        Me.pnl_snippets.Size = New System.Drawing.Size(360, 310)
        Me.pnl_snippets.TabIndex = 1
        '
        'frm_latex_snippets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.pnl_snippets)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frm_latex_snippets"
        Me.Text = "LaTeX Snippets"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menu_maths_symbols As ToolStripMenuItem
    Friend WithEvents Page1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Page2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Page3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Page4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu_maths_formulas As ToolStripMenuItem
    Friend WithEvents Page1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents pnl_snippets As Panel
    Friend WithEvents Page5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Page6ToolStripMenuItem As ToolStripMenuItem
End Class
