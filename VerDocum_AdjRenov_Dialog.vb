Public Class VerDocum_AdjRenov_Dialog
    Public RutaArchivo As String
    Public NombreArchivo As String

    Public Date_FechaVencimiento As Date

    Private Sub WClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WClose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Aceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        If NombreArchivo = "" Then
            Msgbox_Dialog.Imprimir(Titulo.Text, "Seleccione algún archivo")
            Exit Sub
        End If

        If FechaVencimiento.Text = "" Then
            Msgbox_Dialog.Imprimir(Titulo.Text, "Asigne una fecha de vencimiento al archivo")
            FechaVencimiento.Focus()
            Exit Sub
        ElseIf FechaVencimiento.Text <> "0" Then
            If System.Text.RegularExpressions.Regex.IsMatch(FechaVencimiento.Text, "^[0-9]{2}/[0-9]{2}/[0-9]{4}$") = False Then
                Msgbox_Dialog.Imprimir(Titulo.Text, "La fecha de terminación debe tener el formato, DD/MM/AAAA")
                Exit Sub
            End If
        End If

        Try
            If FechaVencimiento.Text = "0" Then
                Date_FechaVencimiento = Date.FromBinary(0)
            Else
                Date_FechaVencimiento = Date.ParseExact(FechaVencimiento.Text, "dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
            End If

        Catch
            Msgbox_Dialog.Imprimir("Error al " & Titulo.Text.ToLower, "La fecha de vencimiento no es legible")
            Exit Sub
        End Try

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub VerDocum_AdjRenov_Dialog_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim Pen_AzOsc As New Pen(Color.FromArgb(100, 50, 50, 50), 1)

        e.Graphics.DrawRectangle(Pen_AzOsc, 0, 0, Me.Width - 1, Me.Height - 1)
    End Sub

    Private Sub SelArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelArchivo.Click
        Dim SelArch_Dialog As New OpenFileDialog

        SelArch_Dialog.Title = "Selecciona un archivo..."
        SelArch_Dialog.Filter = "Todos los archivos (*.*)|*.*"
        SelArch_Dialog.FilterIndex = 1

        If SelArch_Dialog.ShowDialog() = DialogResult.OK Then
            RutaArchivo = SelArch_Dialog.FileName
            NombreArchivo = My.Computer.FileSystem.GetName(RutaArchivo)

            If NombreArchivo.Length > 30 Then
                lblArchivo.Text = NombreArchivo.Substring(0, 28).Insert(28, "...")
            Else
                lblArchivo.Text = NombreArchivo
            End If
        End If
    End Sub

    Private Sub VerDocum_AdjRenov_Dialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If FechaVencimiento.Text.Length = 0 Then FechaVencimiento.BackColor = Color.LightPink
    End Sub

    Private Sub FechaVencimiento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaVencimiento.TextChanged
        If FechaVencimiento.Text.Length = 0 Then
            FechaVencimiento.BackColor = Color.LightPink
        Else
            FechaVencimiento.BackColor = Color.White
        End If
    End Sub
End Class