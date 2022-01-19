Public Class Registro_Form
    'Variables relacionadas al contrato
    Dim Var_FechaInicio As String
    Dim Var_FechaTerminacion As String

    'Variables relacionadas a las afiliaciones
    Dim Var_EPS As String
    Dim Var_ARL As String
    Dim Var_Pensiones As String
    Dim Var_Cesantias As String

    'Variables relacionadas a los datos de un familiar
    Dim Var_NombreFamiliar As String
    Dim Var_TelefonoFamiliar As String


    Const String_Vacio As String = ""


    Private Sub WMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub WClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WClose.Click
        End
    End Sub

    Private Sub Regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regresar.Click
        Principal_Form.Notificaciones.Items.Clear()
        Array.Resize(Loading_Screen.Listado_de_Notificaciones, 0)
        Loading_Screen.Notificaciones()

        Principal_Form.Show()
        Me.Hide()
    End Sub

    Private Sub TipoContrato_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoContrato.SelectedIndexChanged
        Dim Reg_Contr_Dialog As New Registro_Contrato_Dialog
        Dim dResult As DialogResult

        Dim s As String

        If TipoContrato.SelectedIndex = -1 Then Exit Sub

        s = TipoContrato.SelectedItem
        Reg_Contr_Dialog.TipoContrato.Text = "Contrato - " & s.Substring(0, 1) & LCase(s.Substring(1))
        Reg_Contr_Dialog.Icon = My.Resources.Icono

        'Carga de datos al formulario
        Reg_Contr_Dialog.Obl_FechaInicio = True
        Reg_Contr_Dialog.Obl_FechaTerminacion = True

        Reg_Contr_Dialog.FechaInicio.Text = Var_FechaInicio
        Reg_Contr_Dialog.FechaTerminacion.Text = Var_FechaTerminacion

        'Mostrar formulario
        dResult = Reg_Contr_Dialog.ShowDialog()
        If dResult = System.Windows.Forms.DialogResult.Cancel Then
            TipoContrato.SelectedIndex = -1
            TipoContrato.Text = String.Empty
        ElseIf dResult = System.Windows.Forms.DialogResult.OK Then
            Var_FechaInicio = Reg_Contr_Dialog.FechaInicio.Text
            Var_FechaTerminacion = Reg_Contr_Dialog.FechaTerminacion.Text
        End If
    End Sub

    Private Sub Afiliaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Afiliaciones.Click
        Dim Reg_Afil_Dialog As New Registro_Afiliaciones_Dialog
        Dim dResult As DialogResult

        Reg_Afil_Dialog.Icon = My.Resources.Icono

        'Carga de datos al formulario
        Reg_Afil_Dialog.EPS.Text = Var_EPS
        Reg_Afil_Dialog.ARL.Text = Var_ARL
        Reg_Afil_Dialog.Pensiones.Text = Var_Pensiones
        Reg_Afil_Dialog.Cesantias.Text = Var_Cesantias

        'Mostrar formulario
        dResult = Reg_Afil_Dialog.ShowDialog()
        If dResult = System.Windows.Forms.DialogResult.OK Then
            Var_EPS = Reg_Afil_Dialog.EPS.Text
            Var_ARL = Reg_Afil_Dialog.ARL.Text
            Var_Pensiones = Reg_Afil_Dialog.Pensiones.Text
            Var_Cesantias = Reg_Afil_Dialog.Cesantias.Text
        End If
    End Sub

    Private Sub DatosFamiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosFamiliar.Click
        Dim Reg_DatFamil_Dialog As New Registro_DatosFamiliar_Dialog
        Dim dResult As DialogResult

        Reg_DatFamil_Dialog.Icon = My.Resources.Icono

        'Carga de datos al formulario
        Reg_DatFamil_Dialog.Nombre.Text = Var_NombreFamiliar
        Reg_DatFamil_Dialog.Telefono.Text = Var_TelefonoFamiliar

        'Mostrar formulario
        dResult = Reg_DatFamil_Dialog.ShowDialog()
        If dResult = System.Windows.Forms.DialogResult.OK Then
            Var_NombreFamiliar = Reg_DatFamil_Dialog.Nombre.Text
            Var_TelefonoFamiliar = Reg_DatFamil_Dialog.Telefono.Text
        End If
    End Sub

    Private Sub Registro_Form_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim Pen_AzOsc As New Pen(Color.FromArgb(100, 50, 50, 50), 1)
        Dim Pen_Gris As New Pen(Color.FromArgb(100, 100, 100), 1)

        e.Graphics.DrawRectangle(Pen_AzOsc, 0, 0, Me.Width - 1, Me.Height - 1)

        With TipoContrato
            e.Graphics.DrawRectangle(Pen_Gris, .Left - 1, .Top - 1, .Width + 1, .Height + 1)
        End With
    End Sub

    Private Sub Registro_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Nombre.BackColor = Color.LightPink
        Cedula.BackColor = Color.LightPink
        FechaNacimiento.BackColor = Color.LightPink
        TipoSangre.BackColor = Color.LightPink
        Direccion.BackColor = Color.LightPink
        RIG.BackColor = Color.LightPink
        TipoContrato.BackColor = Color.LightPink
        Ciudad.BackColor = Color.LightPink

        Var_FechaInicio = String_Vacio
        Var_FechaTerminacion = String_Vacio

        Var_EPS = String_Vacio
        Var_ARL = String_Vacio
        Var_Pensiones = String_Vacio
        Var_Cesantias = String_Vacio

        Var_NombreFamiliar = String_Vacio
        Var_TelefonoFamiliar = String_Vacio
    End Sub

    Private Sub Cedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cedula.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ColoresObligatorios(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                                    Nombre.TextChanged, Cedula.TextChanged, FechaNacimiento.TextChanged, _
                                    TipoSangre.TextChanged, Direccion.TextChanged, RIG.TextChanged, _
                                    TipoContrato.TextChanged

        If sender Is Nombre Then
            If Nombre.Text.Length = 0 Then
                Nombre.BackColor = Color.LightPink
            Else
                Nombre.BackColor = Color.White
            End If
        ElseIf sender Is Cedula Then
            If Cedula.Text.Length = 0 Then
                Cedula.BackColor = Color.LightPink
            Else
                Cedula.BackColor = Color.White
            End If
        ElseIf sender Is FechaNacimiento Then
            If FechaNacimiento.Text.Length = 0 Then
                FechaNacimiento.BackColor = Color.LightPink
            Else
                FechaNacimiento.BackColor = Color.White
            End If
        ElseIf sender Is TipoSangre Then
            If TipoSangre.Text.Length = 0 Then
                TipoSangre.BackColor = Color.LightPink
            Else
                TipoSangre.BackColor = Color.White
            End If
        ElseIf sender Is Direccion Then
            If Direccion.Text.Length = 0 Then
                Direccion.BackColor = Color.LightPink
            Else
                Direccion.BackColor = Color.White
            End If
        ElseIf sender Is RIG Then
            If RIG.Text.Length = 0 Then
                RIG.BackColor = Color.LightPink
            Else
                RIG.BackColor = Color.White
            End If
        ElseIf sender Is TipoContrato Then
            If TipoContrato.Text.Length = 0 Then
                TipoContrato.BackColor = Color.LightPink
            Else
                TipoContrato.BackColor = Color.White
            End If
        ElseIf sender Is Ciudad Then
            If Ciudad.Text.Length = 0 Then
                Ciudad.BackColor = Color.LightPink
            Else
                Ciudad.BackColor = Color.White
            End If
        End If
    End Sub



    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Dim Buffer(440) As Byte

        Const Titulo_MsgBox As String = "Registrar"
        Dim Perfil_Dir As String

        'Verificar que los campos que son obligatorios esten llenos
        If Nombre.Text.Length = 0 Then
            Msgbox_Dialog.Imprimir(Titulo_MsgBox, "Falta el nombre")
            Exit Sub
        ElseIf Cedula.Text.Length = 0 Then
            Msgbox_Dialog.Imprimir(Titulo_MsgBox, "Falta la cédula")
            Exit Sub
        ElseIf FechaNacimiento.Text.Length = 0 Then
            Msgbox_Dialog.Imprimir(Titulo_MsgBox, "Falta la fecha de nacimiento")
            Exit Sub
        ElseIf TipoSangre.Text.Length = 0 Then
            Msgbox_Dialog.Imprimir(Titulo_MsgBox, "Falta el tipo de sangre")
            Exit Sub
        ElseIf Direccion.Text.Length = 0 Then
            Msgbox_Dialog.Imprimir(Titulo_MsgBox, "Falta la dirección")
            Exit Sub
        ElseIf RIG.Text.Length = 0 Then
            Msgbox_Dialog.Imprimir(Titulo_MsgBox, "Falta el RIG")
            Exit Sub
        ElseIf TipoContrato.Text.Length = 0 Then
            Msgbox_Dialog.Imprimir(Titulo_MsgBox, "Falta seleccionar un tipo de contrato, con su respectiva fecha de inicio y terminación")
            Exit Sub
        ElseIf Ciudad.Text.Length = 0 Then
            Msgbox_Dialog.Imprimir(Titulo_MsgBox, "Falta la ciudad")
            Exit Sub
        End If

        'Verificacion del formato de los datos
        If System.Text.RegularExpressions.Regex.IsMatch(FechaNacimiento.Text, "^[0-9]{2}/[0-9]{2}/[0-9]{4}$") = False Then
            Msgbox_Dialog.Imprimir(Titulo_MsgBox, "La fecha de nacimiento debe tener el formato, DD/MM/AAAA")
            Exit Sub
        End If

        Perfil_Dir = "Data\" & Cedula.Text
        'Verificar si ya esta registrado
        If My.Computer.FileSystem.DirectoryExists(Perfil_Dir) Then
            Msgbox_Dialog.Imprimir(Titulo_MsgBox, "Ya existe alguien registrado con el mismo número de cedula")
            Exit Sub
        End If

        'Creacion del directorio con el numero de cedula
        My.Computer.FileSystem.CreateDirectory(Perfil_Dir)





        System.Text.Encoding.UTF8.GetBytes(Nombre.Text).CopyTo(Buffer, 0)
        System.Text.Encoding.UTF8.GetBytes(Cedula.Text).CopyTo(Buffer, 64)
        System.Text.Encoding.UTF8.GetBytes(Ciudad.Text).CopyTo(Buffer, 76)
        System.Text.Encoding.UTF8.GetBytes(Telefono.Text).CopyTo(Buffer, 96)
        System.Text.Encoding.UTF8.GetBytes(TipoContrato.Text).CopyTo(Buffer, 108)
        System.Text.Encoding.UTF8.GetBytes(Direccion.Text).CopyTo(Buffer, 120)
        System.Text.Encoding.UTF8.GetBytes(RIG.Text).CopyTo(Buffer, 152)
        System.Text.Encoding.UTF8.GetBytes(Cargo.Text).CopyTo(Buffer, 176)
        System.Text.Encoding.UTF8.GetBytes(TipoSangre.Text).CopyTo(Buffer, 240)
        System.Text.Encoding.UTF8.GetBytes(LugarContratacion.Text).CopyTo(Buffer, 244)

        Try
            'BitConverter.GetBytes(Convert.ToDateTime(FechaNacimiento.Text).Ticks).CopyTo(Buffer, 264)
            BitConverter.GetBytes(Date.ParseExact(FechaNacimiento.Text, "dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")).Ticks).CopyTo(Buffer, 264)
            BitConverter.GetBytes(Date.ParseExact(Var_FechaInicio, "dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")).Ticks).CopyTo(Buffer, 274)
            If String.Compare(Var_FechaTerminacion, "0") <> 0 Then
                BitConverter.GetBytes(Date.ParseExact(Var_FechaTerminacion, "dd/MM/yyyy", New System.Globalization.CultureInfo("en-US")).Ticks).CopyTo(Buffer, 284)
            End If

        Catch
            Msgbox_Dialog.Imprimir("Error al registrar", "Hay una fecha o un dato que no es legible")
            Exit Sub
        End Try


        System.Text.Encoding.UTF8.GetBytes(Var_EPS).CopyTo(Buffer, 294)
        System.Text.Encoding.UTF8.GetBytes(Var_ARL).CopyTo(Buffer, 318)
        System.Text.Encoding.UTF8.GetBytes(Var_Pensiones).CopyTo(Buffer, 342)
        System.Text.Encoding.UTF8.GetBytes(Var_Cesantias).CopyTo(Buffer, 366)

        System.Text.Encoding.UTF8.GetBytes(Var_NombreFamiliar).CopyTo(Buffer, 390)
        System.Text.Encoding.UTF8.GetBytes(Var_TelefonoFamiliar).CopyTo(Buffer, 428)



        My.Computer.FileSystem.WriteAllBytes(Perfil_Dir & "\Perfil.dct", Buffer, False)





        'Limpiar formulario y variables
        Nombre.Text = String_Vacio
        Cedula.Text = String_Vacio
        Ciudad.Text = String_Vacio
        Telefono.Text = String_Vacio
        TipoContrato.Text = String_Vacio
        Direccion.Text = String_Vacio
        RIG.Text = String_Vacio
        Cargo.Text = String_Vacio
        TipoSangre.Text = String_Vacio
        LugarContratacion.Text = String_Vacio

        FechaNacimiento.Text = String_Vacio
        Var_FechaInicio = String_Vacio
        Var_FechaTerminacion = String_Vacio

        Var_EPS = String_Vacio
        Var_ARL = String_Vacio
        Var_Pensiones = String_Vacio
        Var_Cesantias = String_Vacio

        Var_NombreFamiliar = String_Vacio
        Var_TelefonoFamiliar = String_Vacio

        'Regresar al formulario principal
        Principal_Form.Show()
        Me.Hide()
    End Sub

End Class