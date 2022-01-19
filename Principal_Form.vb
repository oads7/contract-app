Public Class Principal_Form

    Private Sub Principal_Form_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim Pen_AzOsc As New Pen(Color.FromArgb(100, 50, 50, 50), 1)

        e.Graphics.DrawRectangle(Pen_AzOsc, 0, 0, Me.Width - 1, Me.Height - 1)

        With Notificaciones
            e.Graphics.FillRectangle(Brushes.White, .Left - 2, .Top - 2, .Width + 4, .Height + 4)
        End With
    End Sub

    Private Sub WMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub WClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WClose.Click
        End
    End Sub

    Private Sub Registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Registrar.Click
        Registro_Form.Show()
        Me.Hide()
    End Sub

    Private Sub VerDocumentacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerDocumentacion.Click
        VerDocumentacion_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Bitacora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bitacora.Click
        Bitacora_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Notificaciones_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Notificaciones.DoubleClick
        Dim str_A As String()

        str_A = Notificaciones.SelectedItem.ToString.Split(Chr(255))

        VerDocumentacion_Form.TipoBusqueda.SelectedIndex = 0
        VerDocumentacion_Form.CampoBusq.Text = str_A(1)
        VerDocumentacion_Form.Buscar_Click(VerDocumentacion_Form.Buscar, EventArgs.Empty)

        VerDocumentacion_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Notificaciones_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Notificaciones.DrawItem
        Dim str_A As String(), tmpStr As String
        Dim Faltante_Vencer As Long

        Dim Brush_Sel As New SolidBrush(Color.FromArgb(0, 176, 240))
        Dim Brush_Crit As New SolidBrush(Color.FromArgb(100, 0, 0))
        Dim Brush_Crit_Sel As New SolidBrush(Color.FromArgb(130, 0, 50))
        Dim Brush_Alert As New SolidBrush(Color.FromArgb(200, 80, 80))
        Dim Brush_Alert_Sel As New SolidBrush(Color.FromArgb(210, 112, 112))

        str_A = Notificaciones.Items.Item(e.Index).ToString.Split(Chr(255))
        If str_A(0).Length > 32 Then
            str_A(0) = str_A(0).Substring(0, 32) & "..."
        End If

        Faltante_Vencer = str_A(3)
        tmpStr = "Error de conteo"

        e.DrawBackground()
        If Faltante_Vencer > 8 Then     'Mas de 8 dias para vencerse
            If (e.State And DrawItemState.Selected) = 1 Then e.Graphics.FillRectangle(Brush_Sel, e.Bounds)

            tmpStr = "Se vence en " & str_A(3) & " días"
        ElseIf Faltante_Vencer >= 0 Then     'Menos de 8 dias para vencerse
            e.Graphics.FillRectangle(Brush_Alert, e.Bounds)
            If (e.State And DrawItemState.Selected) = 1 Then e.Graphics.FillRectangle(Brush_Alert_Sel, e.Bounds)

            tmpStr = "Se vence en " & str_A(3) & " días"
        ElseIf Faltante_Vencer < 0 Then     'Ya se venció
            e.Graphics.FillRectangle(Brush_Crit, e.Bounds)
            If (e.State And DrawItemState.Selected) = 1 Then e.Graphics.FillRectangle(Brush_Crit_Sel, e.Bounds)

            tmpStr = "Venció hace " & (Faltante_Vencer * -1) & " días"
        End If

        e.Graphics.DrawString(tmpStr, Notificaciones.Font, Brushes.White, e.Bounds.Left + 160, e.Bounds.Top + 28)

        e.Graphics.DrawString("Nombre: " & str_A(0), Notificaciones.Font, Brushes.White, e.Bounds)
        e.Graphics.DrawString(str_A(2), Notificaciones.Font, Brushes.White, e.Bounds.Left + 15, e.Bounds.Top + 14)
        e.Graphics.DrawString("Cédula: " & str_A(1), Notificaciones.Font, Brushes.White, e.Bounds.Left + 15, e.Bounds.Top + 28)

        e.DrawFocusRectangle()
    End Sub

    Private Sub Notificaciones_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles Notificaciones.MeasureItem
        e.ItemHeight *= 3
    End Sub
End Class
