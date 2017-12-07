Public Class Form1
    Dim mode As Integer = 1
    Dim i As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        PictureBox2.Width = PictureBox1.Width
        PictureBox2.Height = PictureBox1.Height
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mode = 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim col As Color
        Dim x, y As Integer
        Dim bm As New Bitmap(PictureBox1.Image)
        Dim g As Graphics = PictureBox2.CreateGraphics()
        Dim p As New Pen(Color.Black)

        For x = 0 To PictureBox1.Width - 1
            For y = 0 To PictureBox1.Height - 1
                col = bm.GetPixel(x, y)
                col = Color.FromArgb(255 - col.R, 255 - col.G, 255 - col.B)

                p.Color = col
                g.DrawEllipse(p, x, y, 1, 1)
            Next
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim col As Color
        Dim x, y As Integer
        Dim bm As New Bitmap(PictureBox1.Image)
        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim p As New Pen(Color.Black)

        bm.RotateFlip(RotateFlipType.Rotate180FlipY)
        PictureBox1.Image = bm
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim col As Color
        Dim x, y As Integer
        Dim bm As New Bitmap(PictureBox1.Image)
        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim p As New Pen(Color.Black)

        bm.RotateFlip(RotateFlipType.Rotate180FlipX)
        PictureBox1.Image = bm
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 0
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim col As Color
        Dim x, y As Integer
        Dim bm As New Bitmap(PictureBox1.Image)
        Dim g As Graphics = PictureBox2.CreateGraphics()
        Dim p As New Pen(Color.Black)

        i += 1
        If i > 2 Then
            i = 0
        End If
        Button7.Text = i

        For x = 0 To PictureBox1.Width - 1
            For y = 0 To PictureBox1.Height - 1
                col = bm.GetPixel(x, y)

                Select Case i
                    Case 0
                        col = Color.FromArgb(col.R, col.G, col.B)
                    Case 1
                        col = Color.FromArgb(col.B, col.R, col.G)
                    Case 2
                        col = Color.FromArgb(col.G, col.B, col.R)
                End Select

                p.Color = col
                g.DrawEllipse(p, x, y, 1, 1)
            Next
        Next
    End Sub
End Class
