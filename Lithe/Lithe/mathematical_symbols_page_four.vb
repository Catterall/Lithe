Public Class frm_mathematical_symbols_page_four
    Private Sub btn_right_moustache_Click(sender As Object, e As EventArgs) Handles btn_right_moustache.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\rmoustache"
    End Sub

    Private Sub btn_left_brace_Click(sender As Object, e As EventArgs) Handles btn_left_brace.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\lbrace"
    End Sub

    Private Sub btn_right_brace_Click(sender As Object, e As EventArgs) Handles btn_right_brace.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\rbrace"
    End Sub

    Private Sub btn_left_ceil_Click(sender As Object, e As EventArgs) Handles btn_left_ceil.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\lceil"
    End Sub

    Private Sub btn_right_ceil_Click(sender As Object, e As EventArgs) Handles btn_right_ceil.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\rceil"
    End Sub

    Private Sub btn_left_floor_Click(sender As Object, e As EventArgs) Handles btn_left_floor.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\lfloor"
    End Sub

    Private Sub btn_right_floor_Click(sender As Object, e As EventArgs) Handles btn_right_floor.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\rfloor"
    End Sub

    Private Sub btn_sin_Click(sender As Object, e As EventArgs) Handles btn_sin.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\sin"
    End Sub

    Private Sub btn_cos_Click(sender As Object, e As EventArgs) Handles btn_cos.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\cos"
    End Sub
End Class