Public Class VerDocum_ModifDat_Dialog

    Public Perfil As VerDocumentacion_Form.Perfil_Info

    Private Sub WClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WClose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Perfil.Direccion = Direccion.Text
        Perfil.Telefono = Telefono.Text
        Perfil.RIG = RIG.Text
        Perfil.Cargo = Cargo.Text
        Perfil.LugarContratacion = LugarContratacion.Text
        Perfil.TipoContrato = TipoContrato.Text


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub VerDocum_ModifDat_Dialog_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim Pen_AzOsc As New Pen(Color.FromArgb(100, 50, 50, 50), 1)

        e.Graphics.DrawRectangle(Pen_AzOsc, 0, 0, Me.Width - 1, Me.Height - 1)
    End Sub

    Private Sub DatosFamiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosFamiliar.Click
        Dim Edit_DatFamil_Dialog As New Registro_DatosFamiliar_Dialog
        Dim dResult As DialogResult

        Edit_DatFamil_Dialog.Nombre.Text = Perfil.NombreFamiliar
        Edit_DatFamil_Dialog.Telefono.Text = Perfil.TelefonoFamiliar

        dResult = Edit_DatFamil_Dialog.ShowDialog()
        If dResult = System.Windows.Forms.DialogResult.OK Then
            Perfil.NombreFamiliar = Edit_DatFamil_Dialog.Nombre.Text
            Perfil.TelefonoFamiliar = Edit_DatFamil_Dialog.Telefono.Text
        End If
    End Sub

    Private Sub Afiliaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Afiliaciones.Click
        Dim Edit_Afil_Dialog As New Registro_Afiliaciones_Dialog
        Dim dResult As DialogResult

        Edit_Afil_Dialog.EPS.Text = Perfil.EPS
        Edit_Afil_Dialog.ARL.Text = Perfil.ARL
        Edit_Afil_Dialog.Pensiones.Text = Perfil.Pensiones
        Edit_Afil_Dialog.Cesantias.Text = Perfil.Cesantias

        dResult = Edit_Afil_Dialog.ShowDialog()
        If dResult = System.Windows.Forms.DialogResult.OK Then
            Perfil.EPS = Edit_Afil_Dialog.EPS.Text
            Perfil.ARL = Edit_Afil_Dialog.ARL.Text
            Perfil.Pensiones = Edit_Afil_Dialog.Pensiones.Text
            Perfil.Cesantias = Edit_Afil_Dialog.Cesantias.Text
        End If
    End Sub

    Private Sub FechasContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechasContrato.Click
        Dim Edit_FechasContr_Dialog As New Registro_Contrato_Dialog
        Dim dResult As DialogResult

        Dim s As String

        If TipoContrato.SelectedIndex = -1 Then Exit Sub

        s = TipoContrato.SelectedItem
        Edit_FechasContr_Dialog.TipoContrato.Text = "Contrato - " & s.Substring(0, 1) & LCase(s.Substring(1))

        Edit_FechasContr_Dialog.Obl_FechaInicio = False
        Edit_FechasContr_Dialog.Obl_FechaTerminacion = False
        Edit_FechasContr_Dialog.FechaInicio.Text = Perfil.FechaInicioContrato
        Edit_FechasContr_Dialog.FechaTerminacion.Text = Perfil.FechaTerminacionContrato

        dResult = Edit_FechasContr_Dialog.ShowDialog()
        If dResult = System.Windows.Forms.DialogResult.OK Then
            Perfil.FechaInicioContrato = Edit_FechasContr_Dialog.FechaInicio.Text
            Perfil.FechaTerminacionContrato = Edit_FechasContr_Dialog.FechaTerminacion.Text
        End If
    End Sub

    Private Sub VerDocum_ModifDat_Dialog_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Direccion.Text = Perfil.Direccion
        Telefono.Text = Perfil.Telefono
        RIG.Text = Perfil.RIG
        Cargo.Text = Perfil.Cargo
        LugarContratacion.Text = Perfil.LugarContratacion
        TipoContrato.Text = Perfil.TipoContrato

    End Sub

    Private Sub Label4_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label4.Paint
        Dim Pen_Gris As New Pen(Color.FromArgb(100, 100, 100), 1)

        With TipoContrato
            e.Graphics.DrawRectangle(Pen_Gris, .Left - Label4.Left - 1, .Top - Label4.Top - 1, .Width + 1, .Height + 1)
        End With
    End Sub
End Class