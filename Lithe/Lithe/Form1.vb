Public Class frm_mainWindow
    Dim ExitYN As System.Windows.Forms.DialogResult
    Private Sub frm_mainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.Directory.Exists("generated images") = False Then
            System.IO.Directory.CreateDirectory("generated images")
        Else
        End If
    End Sub
    Private Sub btn_view_latex_snippets_Click(sender As Object, e As EventArgs) Handles btn_view_latex_snippets.Click
        frm_latex_snippets.Show()
    End Sub


    Private Sub btn_latex_snippets_help_Click(sender As Object, e As EventArgs) Handles btn_latex_snippets_help.Click
        MessageBox.Show("This button will allow you to view and add snippets of LaTeX you may want to use." & vbCrLf & vbCrLf & "Example: \frac{a}{b}", "View LaTeX Snippets")
    End Sub


    Private Sub btn_save_img_Click(sender As Object, e As EventArgs) Handles btn_save_img.Click
        If System.IO.Directory.Exists("generated images") = False Then
            System.IO.Directory.CreateDirectory("generated images")
        Else
        End If
        If System.IO.File.Exists("generated images\" & txt_file_name.Text & ".png") = True Then
            MessageBox.Show("A file by that name already exists; please choose a different file name.", "Issue")
            Exit Sub
        End If
        If rtxt_latex_textbox.Text.Length > 0 And txt_file_name.Text <> "" Then
            Dim latex As String = "\documentclass{standalone}" & vbCrLf & "\thispagestyle{empty}" & vbCrLf & "\begin{document}" & vbCrLf & "$" & rtxt_latex_textbox.Text & vbCrLf & "$" & vbCrLf & "\end{document}"
            System.IO.File.WriteAllText("generated images\formula.tex", latex)
        Else
            MessageBox.Show("Please make sure of the following:" & vbCrLf & vbCrLf & "You have entered LaTeX into the editor text box." & vbCrLf & "You have specified a file name.", "Issue")
            Exit Sub
        End If
        Dim psi As New ProcessStartInfo("save_to_image.bat", Chr(34) & rtxt_latex_textbox.Text & Chr(34) & " " & Chr(34) & txt_file_name.Text & ".png" & Chr(34))
        Dim p As New Process
        p.StartInfo = psi
        p.Start()
        p.WaitForExit()
        frm_display_image.Show()
    End Sub


    Private Sub btn_github_Click(sender As Object, e As EventArgs) Handles btn_github.Click
        Process.Start("https://github.com/Catterall/lithe")
    End Sub


    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub


    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ExitYN <> Windows.Forms.DialogResult.Yes Then
            e.Cancel = MessageBox.Show("Do you really want to exit?", "LiThE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes
        End If
    End Sub

    Private Sub btn_file_name_help_Click(sender As Object, e As EventArgs) Handles btn_file_name_help.Click
        MessageBox.Show("This is what the name of the file will be when it is saved.", "Name of file")
    End Sub


End Class