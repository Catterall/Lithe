Public Class frm_display_image
    Private Sub frm_display_image_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.Directory.Exists("generated images") = False Then
            System.IO.Directory.CreateDirectory("generated images")
        Else
        End If
        Try
            pic_generated_img.Image = Image.FromFile("generated images\" & frm_mainWindow.txt_file_name.Text & ".png")
        Catch ex As Exception
            Me.Close()
        End Try

    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Me.Close()
    End Sub

    Private Sub btn_abort_Click(sender As Object, e As EventArgs) Handles btn_abort.Click
        pic_generated_img.Image.Dispose()
        If System.IO.Directory.Exists("generated images") = False Then
            System.IO.Directory.CreateDirectory("generated images")
        Else
        End If
        My.Computer.FileSystem.DeleteFile("generated images\" & frm_mainWindow.txt_file_name.Text & ".png")
        Try
            Me.Close()
        Catch ex As Exception
            pic_generated_img.Dispose()
            Me.Close()
        End Try

    End Sub
End Class