Public Class VerDocum_VerOtrDat_Dialog

    Private Sub WClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WClose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub VerDocum_VerOtrDat_Dialog_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim Pen_AzOsc As New Pen(Color.FromArgb(100, 50, 50, 50), 1)

        e.Graphics.DrawRectangle(Pen_AzOsc, 0, 0, Me.Width - 1, Me.Height - 1)
    End Sub
End Class