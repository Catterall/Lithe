Public Class frm_latex_snippets
    Private Sub frm_latex_snippets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(frm_mathematical_symbols_page_one)
    End Sub

    Sub switchPanel(ByVal panel As Form)
        pnl_snippets.Controls.Clear()
        panel.TopLevel = False
        pnl_snippets.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Page1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Page1ToolStripMenuItem.Click
        switchPanel(frm_mathematical_symbols_page_one)
    End Sub

    Private Sub Page2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Page2ToolStripMenuItem.Click
        switchPanel(frm_mathematical_symbols_page_two)
    End Sub

    Private Sub Page3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Page3ToolStripMenuItem.Click
        switchPanel(frm_mathematical_symbols_page_three)
    End Sub
    Private Sub Page4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Page4ToolStripMenuItem.Click
        switchPanel(frm_mathematical_symbols_page_four)
    End Sub
    Private Sub Page5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Page5ToolStripMenuItem.Click
        switchPanel(frm_mathematical_symbols_page_five)
    End Sub

    Private Sub Page6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Page6ToolStripMenuItem.Click
        switchPanel(frm_mathematical_symbols_page_six)
    End Sub

    Private Sub Page1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Page1ToolStripMenuItem1.Click
        switchPanel(frm_mathematical_formulas_page_one)
    End Sub
End Class