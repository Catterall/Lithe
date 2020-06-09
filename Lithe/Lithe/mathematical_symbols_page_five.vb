Public Class frm_mathematical_symbols_page_five
    Private Sub btn_tan_Click(sender As Object, e As EventArgs) Handles btn_tan.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\tan"
    End Sub

    Private Sub btn_limit_Click(sender As Object, e As EventArgs) Handles btn_limit.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\lim_{x \to y}"
    End Sub

    Private Sub btn_integral_Click(sender As Object, e As EventArgs) Handles btn_integral.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\int_b^a"
    End Sub

    Private Sub btn_contour_integral_Click(sender As Object, e As EventArgs) Handles btn_contour_integral.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\oint_b^a"
    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\prod"
    End Sub

    Private Sub btn_coproduct_Click(sender As Object, e As EventArgs) Handles btn_coproduct.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\coprod"
    End Sub

    Private Sub btn_bigcap_Click(sender As Object, e As EventArgs) Handles btn_bigcap.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\bigcap"
    End Sub

    Private Sub btn_disjoint_union_Click(sender As Object, e As EventArgs) Handles btn_disjoint_union.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\bigsqcup"
    End Sub

    Private Sub btn_big_v_Click(sender As Object, e As EventArgs) Handles btn_big_v.Click
        frm_mainWindow.rtxt_latex_textbox.SelectedText = "\bigv"
    End Sub
End Class