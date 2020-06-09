Public Class frm_mathematical_symbols_page_three
    Private Sub btn_backslash_Click(sender As Object, e As EventArgs) Handles btn_backslash.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\backslash"
    End Sub

    Private Sub btn_small_set_minus_Click(sender As Object, e As EventArgs) Handles btn_small_set_minus.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\smallsetminus"
    End Sub

    Private Sub btn_arrowvert_Click(sender As Object, e As EventArgs) Handles btn_arrowvert.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\arrowvert"
    End Sub

    Private Sub btn_brace_vert_Click(sender As Object, e As EventArgs) Handles btn_brace_vert.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\bracevert"
    End Sub

    Private Sub btn_left_group_parenthesis_Click(sender As Object, e As EventArgs) Handles btn_left_group_parenthesis.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\lgroup"
    End Sub

    Private Sub btn_right_group_parenthesis_Click(sender As Object, e As EventArgs) Handles btn_right_group_parenthesis.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\rgroup"
    End Sub

    Private Sub btn_left_angle_Click(sender As Object, e As EventArgs) Handles btn_left_angle.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\langle"
    End Sub

    Private Sub btn_right_angle_Click(sender As Object, e As EventArgs) Handles btn_right_angle.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\rangle"
    End Sub

    Private Sub btn_left_moustache_Click(sender As Object, e As EventArgs) Handles btn_left_moustache.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\lmoustache"
    End Sub
End Class