Public Class Form1
    Private Sub DateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateToolStripMenuItem.Click
        Label1.Text = DateString
        Timer1.Stop()
    End Sub

    Private Sub TimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeToolStripMenuItem.Click
        Label1.Text = TimeString
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeString
    End Sub
End Class
