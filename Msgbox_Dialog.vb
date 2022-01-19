Public Class Msgbox_Dialog

    Private Sub WClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WClose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Msgbox_Dialog_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim Pen_AzOsc As New Pen(Color.FromArgb(100, 50, 50, 50), 1)

        e.Graphics.DrawRectangle(Pen_AzOsc, 0, 0, Me.Width - 1, Me.Height - 1)
    End Sub

    Public Sub Imprimir(ByRef Titulo As String, ByRef Mensaje As String)
        Dim Msg_Diag As New Msgbox_Dialog

        Msg_Diag.Icon = My.Resources.Icono

        Msg_Diag.MsgTitulo.Text = Titulo
        Msg_Diag.Text = Titulo

        Msg_Diag.MsgMensaje.Text = Mensaje
        Msg_Diag.ShowDialog()
    End Sub
End Class