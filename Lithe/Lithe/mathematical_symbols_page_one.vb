Public Class frm_mathematical_symbols_page_one
    Private Sub btn_div_symbol_Click(sender As Object, e As EventArgs) Handles btn_div_symbol.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\div"
    End Sub

    Private Sub btn_mul_symbol_dot_Click(sender As Object, e As EventArgs) Handles btn_mul_symbol_dot.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\cdot"
    End Sub

    Private Sub btn_mul_symbol_x_Click(sender As Object, e As EventArgs) Handles btn_mul_symbol_x.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\times"
    End Sub

    Private Sub btn_uneqal_Click(sender As Object, e As EventArgs) Handles btn_uneqal.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\neq"
    End Sub

    Private Sub btn_right_vector_Click(sender As Object, e As EventArgs) Handles btn_right_vector.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\vec{x}"
    End Sub

    Private Sub btn_left_vector_Click(sender As Object, e As EventArgs) Handles btn_left_vector.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\overleftarrow{x}"
    End Sub

    Private Sub btn_n_root_Click(sender As Object, e As EventArgs) Handles btn_n_root.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\sqrt[n]{x}"
    End Sub

    Private Sub btn_acute_Click(sender As Object, e As EventArgs) Handles btn_acute.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\acute{x}"
    End Sub

    Private Sub btn_bar_Click(sender As Object, e As EventArgs) Handles btn_bar.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\bar{x}"
    End Sub
End Class