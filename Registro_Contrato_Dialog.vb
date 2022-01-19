Public Class Registro_Contrato_Dialog

    Public Obl_FechaInicio As Boolean
    Public Obl_FechaTerminacion As Boolean

    Private Sub WClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WClose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        If Obl_FechaInicio And (FechaInicio.Text.Length = 0) Then
            Msgbox_Dialog.Imprimir(TipoContrato.Text, "La fecha de inicio del contrato es obligatoria")
            Exit Sub
        End If
        If Obl_FechaTerminacion And (FechaTerminacion.Text.Length = 0) Then
            Msgbox_Dialog.Imprimir(TipoContrato.Text, "La fecha de terminación del contrato es obligatoria")
            Exit Sub
        End If

        If System.Text.RegularExpressions.Regex.IsMatch(FechaInicio.Text, "^[0-9]{2}/[0-9]{2}/[0-9]{4}$") = False Then
            Msgbox_Dialog.Imprimir(TipoContrato.Text, "La fecha de inicio debe tener el formato, DD/MM/AAAA")
            Exit Sub
        End If
        If FechaTerminacion.Text <> "0" Then
            If System.Text.RegularExpressions.Regex.IsMatch(FechaTerminacion.Text, "^[0-9]{2}/[0-9]{2}/[0-9]{4}$") = False Then
                Msgbox_Dialog.Imprimir(TipoContrato.Text, "La fecha de terminación debe tener el formato, DD/MM/AAAA")
                Exit Sub
            End If
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Registro_Contrato_Dialog_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim Pen_AzOsc As New Pen(Color.FromArgb(100, 50, 50, 50), 1)

        e.Graphics.DrawRectangle(Pen_AzOsc, 0, 0, Me.Width - 1, Me.Height - 1)
    End Sub

    Private Sub Registro_Contrato_Dialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If FechaInicio.Text.Length = 0 And Obl_FechaInicio Then FechaInicio.BackColor = Color.LightPink
        If FechaTerminacion.Text.Length = 0 And Obl_FechaTerminacion Then FechaTerminacion.BackColor = Color.LightPink
    End Sub

    Private Sub ColoresObligatorios(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                                    FechaInicio.TextChanged, FechaTerminacion.TextChanged

        If sender Is FechaInicio Then
            If FechaInicio.Text.Length = 0 And Obl_FechaInicio Then
                FechaInicio.BackColor = Color.LightPink
            Else
                FechaInicio.BackColor = Color.White
            End If
        ElseIf sender Is FechaTerminacion And Obl_FechaTerminacion Then
            If FechaTerminacion.Text.Length = 0 Then
                FechaTerminacion.BackColor = Color.LightPink
            Else
                FechaTerminacion.BackColor = Color.White
            End If
        End If
    End Sub
End Class