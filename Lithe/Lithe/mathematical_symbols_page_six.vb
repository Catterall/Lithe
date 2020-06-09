Public Class frm_mathematical_symbols_page_six
    Private Sub btn_big_wedge_Click(sender As Object, e As EventArgs) Handles btn_big_wedge.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\bigwedge"
    End Sub

    Private Sub btn_overbrace_Click(sender As Object, e As EventArgs) Handles btn_overbrace.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\overbrace{x}"
    End Sub

    Private Sub btn_underbrace_Click(sender As Object, e As EventArgs) Handles btn_underbrace.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\underbrace{x}"
    End Sub
End Class