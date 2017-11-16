Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Dim col As Color
        Dim x, y As Integer
        Dim bm As New Bitmap(PictureBox1.Image)

        x = e.X
        y = e.Y

        col = bm.GetPixel(x, y)

        TextBox1.Text = col.R
        TextBox2.Text = col.G
        TextBox3.Text = col.B
        TextBox4.Text = "(" & x & ", " & y & ")"
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    End Sub
End Class
