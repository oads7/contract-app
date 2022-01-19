Public Class VerDocum_ListCoinc_Dialog

    Private Sub WClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WClose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Seleccionar.Click



        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub VerDocum_ListCoinc_Dialog_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim Pen_AzOsc As New Pen(Color.FromArgb(100, 50, 50, 50), 1)

        e.Graphics.DrawRectangle(Pen_AzOsc, 0, 0, Me.Width - 1, Me.Height - 1)
    End Sub

    Private Sub ListaNombres_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaNombres.DoubleClick
        Seleccionar_Click(Seleccionar, EventArgs.Empty)
    End Sub

    Private Sub ListaNombres_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListaNombres.DrawItem
        Dim str_A As String()
        Dim Brush_Sel As New SolidBrush(Color.FromArgb(0, 176, 240))
        Dim Fuente As Font

        e.DrawBackground()
        If (e.State And DrawItemState.Selected) = 1 Then e.Graphics.FillRectangle(Brush_Sel, e.Bounds)

        str_A = ListaNombres.Items.Item(e.Index).ToString.Split(Chr(255))
        If str_A(0).Length > 35 Then
            e.Graphics.DrawString(str_A(0).Substring(0, 32).Insert(32, "..."), ListaNombres.Font, Brushes.Black, e.Bounds)
        Else
            e.Graphics.DrawString(str_A(0), ListaNombres.Font, Brushes.Black, e.Bounds)
        End If

        Fuente = New Font(ListaNombres.Font.Name, ListaNombres.Font.Size, FontStyle.Italic)
        e.Graphics.DrawString("CC:", ListaNombres.Font, Brushes.DarkSlateGray, e.Bounds.Left + 25, e.Bounds.Top + 12)
        e.Graphics.DrawString(str_A(1), Fuente, Brushes.DarkSlateGray, e.Bounds.Left + 50, e.Bounds.Top + 12)

        e.DrawFocusRectangle()
    End Sub

    Private Sub ListaNombres_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles ListaNombres.MeasureItem
        e.ItemHeight *= 2
    End Sub
End Class