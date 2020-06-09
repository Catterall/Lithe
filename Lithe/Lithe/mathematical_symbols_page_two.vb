Public Class frm_mathematical_symbols_page_two
    Private Sub btn_tilde_Click(sender As Object, e As EventArgs) Handles btn_tilde.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\tilde{x}"
    End Sub

    Private Sub btn_wide_tilde_Click(sender As Object, e As EventArgs) Handles btn_wide_tilde.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\widetilde{x}"
    End Sub

    Private Sub btn_dot_Click(sender As Object, e As EventArgs) Handles btn_dot.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\dot{x}"
    End Sub

    Private Sub btn_double_dot_Click(sender As Object, e As EventArgs) Handles btn_double_dot.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\ddot{x}"
    End Sub

    Private Sub btn_triple_dot_Click(sender As Object, e As EventArgs) Handles btn_triple_dot.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\dddot{x}"
    End Sub

    Private Sub btn_hat_Click(sender As Object, e As EventArgs) Handles btn_hat.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\hat{x}"
    End Sub

    Private Sub btn_wide_hat_Click(sender As Object, e As EventArgs) Handles btn_wide_hat.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\widehat{x}"
    End Sub

    Private Sub btn_grave_Click(sender As Object, e As EventArgs) Handles btn_grave.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\grave{x}"
    End Sub

    Private Sub btn_breve_Click(sender As Object, e As EventArgs) Handles btn_breve.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\breve{x}"
    End Sub
End Class