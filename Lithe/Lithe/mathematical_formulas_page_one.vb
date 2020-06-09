Public Class frm_mathematical_formulas_page_one
    Private Sub btn_summentation_Click(sender As Object, e As EventArgs) Handles btn_summentation.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\displaystyle\sum\limits_{i=0}^n i"
    End Sub

    Private Sub btn_vector_Click(sender As Object, e As EventArgs) Handles btn_vector.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\left(\begin{array}{c}a\\ b\end{array}\right)"
    End Sub

    Private Sub btn_matrice_Click(sender As Object, e As EventArgs) Handles btn_matrice.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\begin{bmatrix}a & b \\c & d \end{bmatrix}"
    End Sub

    Private Sub btn_paranthesis_matrice_Click(sender As Object, e As EventArgs) Handles btn_paranthesis_matrice.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\begin{pmatrix} a& b\\ c& d \end{pmatrix}"
    End Sub

    Private Sub btn_x_divides_y_Click(sender As Object, e As EventArgs) Handles btn_x_divides_y.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\left.x\right.|y"
    End Sub

    Private Sub btn_comparator_Click(sender As Object, e As EventArgs) Handles btn_comparator.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\begin{cases}a & x = 0\\b & x > 0\end{cases}"
    End Sub

    Private Sub btn_left_arrow_Click(sender As Object, e As EventArgs) Handles btn_left_arrow.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "A\:\xleftarrow[C]D\:B"
    End Sub

    Private Sub btn_right_arrow_Click(sender As Object, e As EventArgs) Handles btn_right_arrow.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "A\:\xrightarrow[C]D\:B"
    End Sub

    Private Sub frm_mathematical_formulas_page_one_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class