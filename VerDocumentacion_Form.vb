Public Class VerDocumentacion_Form
    Public Class Perfil_Info
        Public Nombre As String
        Public Cedula As String
        Public Ciudad As String
        Public Telefono As String
        Public TipoContrato As String
        Public Direccion As String
        Public RIG As String
        Public Cargo As String
        Public TipoSangre As String
        Public LugarContratacion As String
        Public FechaNacimiento As String
        Public FechaInicioContrato As String
        Public FechaTerminacionContrato As String
        Public EPS As String
        Public ARL As String
        Public Pensiones As String
        Public Cesantias As String
        Public NombreFamiliar As String
        Public TelefonoFamiliar As String

        Public Date_FechaNacimiento As DateTime
        Public Date_FechaInicioContrato As DateTime
        Public Date_FechaTerminacionContrato As DateTime
    End Class

    Dim Buffer_Perfil(440) As Byte

    Dim Perfil_Ruta As String
    Dim Perfil As New Perfil_Info

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

    Private Sub VerDocumentacion_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TipoBusqueda.SelectedIndex = 0
    End Sub

    Public Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Dim VerDo_ListC_Dialog As New VerDocum_ListCoinc_Dialog
        Dim dResult As DialogResult

        Dim NumDirs As Integer
        Dim DirList As System.Collections.ObjectModel.ReadOnlyCollection(Of String)

        Dim str_Nombre As String, str_Cedula As String
        Dim str_CampNombres As String(), l_nom As Integer, res_nom As Boolean


        If CampoBusq.TextLength = 0 Then
            Msgbox_Dialog.Imprimir("Ver documentación", "El campo de búsqueda esta vacío")
            Exit Sub
        End If

        Label1.Text = "Ver documentación - Buscando..."

        If TipoBusqueda.SelectedIndex = 0 Then
            'Buscar por cedula
            If My.Computer.FileSystem.DirectoryExists("Data\" & CampoBusq.Text) = False Then
                Label1.Text = "Ver documentación"
                Msgbox_Dialog.Imprimir("Ver documentación", "No se encontró un perfil con ese número de cédula")
                Exit Sub
            End If

            Perfil_Ruta = "Data\" & CampoBusq.Text
            Label1.Text = "Ver documentación"
        ElseIf TipoBusqueda.SelectedIndex = 1 Then
            VerDo_ListC_Dialog.Icon = My.Resources.Icono
            'Buscar por nombre

            'Conseguir la lista de carpetas en "Data"
            DirList = My.Computer.FileSystem.GetDirectories("Data")

            'Numero de carpetas en "Data"
            NumDirs = DirList.Count
            For i As Integer = 0 To NumDirs - 1
                'Cargar perfil y Nombre
                Buffer_Perfil = My.Computer.FileSystem.ReadAllBytes(DirList.Item(i) & "\Perfil.dct")
                str_Nombre = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 0, 64)
                str_Cedula = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 64, 12)

                str_Nombre = str_Nombre.Substring(0, str_Nombre.IndexOf(Chr(0)))
                str_Cedula = str_Cedula.Substring(0, str_Cedula.IndexOf(Chr(0)))

                'Comparar el campo con los nombres de perfiles
                str_CampNombres = CampoBusq.Text.Split(Chr(32))
                l_nom = str_CampNombres.Length - 1

                res_nom = True
                For j_nom As Integer = 0 To l_nom
                    res_nom = res_nom And str_Nombre.Contains(str_CampNombres(j_nom))
                Next

                If res_nom Then
                    VerDo_ListC_Dialog.ListaNombres.Items.Add(str_Nombre & Chr(255) & str_Cedula)
                End If
            Next

            Label1.Text = "Ver documentación"
            'Si no hay coincidencias
            If VerDo_ListC_Dialog.ListaNombres.Items.Count = 0 Then
                Msgbox_Dialog.Imprimir("Ver documentación", "No coincidió ningún perfil de acuerdo a la busqueda")
                Exit Sub
            End If

            dResult = VerDo_ListC_Dialog.ShowDialog()
            If dResult = System.Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            ElseIf dResult = System.Windows.Forms.DialogResult.OK Then
                'Usando el perfil escogido en el listbox obtener la ruta
                str_Cedula = VerDo_ListC_Dialog.ListaNombres.SelectedItem.ToString
                str_Cedula = str_Cedula.Substring(str_Cedula.IndexOf(Chr(255)) + 1)

                Perfil_Ruta = "Data\" & str_Cedula
            End If
        End If

        'Cargar archivo de perfil
        Buffer_Perfil = My.Computer.FileSystem.ReadAllBytes(Perfil_Ruta & "\Perfil.dct")

        'Cargar datos del archivo a la aplicacion
        Perfil.Nombre = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 0, 64)
        Perfil.Cedula = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 64, 12)
        Perfil.Ciudad = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 76, 20)
        Perfil.Telefono = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 96, 12)
        Perfil.TipoContrato = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 108, 12)
        Perfil.Direccion = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 120, 32)
        Perfil.RIG = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 152, 24)
        Perfil.Cargo = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 176, 64)
        Perfil.TipoSangre = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 240, 4)
        Perfil.LugarContratacion = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 244, 20)

        Perfil.Date_FechaNacimiento = System.DateTime.FromBinary(BitConverter.ToInt64(Buffer_Perfil, 264))
        Perfil.Date_FechaInicioContrato = System.DateTime.FromBinary(BitConverter.ToInt64(Buffer_Perfil, 274))
        Perfil.Date_FechaTerminacionContrato = System.DateTime.FromBinary(BitConverter.ToInt64(Buffer_Perfil, 284))
        Perfil.FechaNacimiento = Perfil.Date_FechaNacimiento.ToString("dd/MM/yyyy")
        Perfil.FechaInicioContrato = Perfil.Date_FechaInicioContrato.ToString("dd/MM/yyyy")
        If Perfil.Date_FechaTerminacionContrato.ToBinary = 0 Then
            Perfil.FechaTerminacionContrato = "0"
        Else
            Perfil.FechaTerminacionContrato = Perfil.Date_FechaTerminacionContrato.ToString("dd/MM/yyyy")
        End If

        Perfil.EPS = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 294, 24)
        Perfil.ARL = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 318, 24)
        Perfil.Pensiones = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 342, 24)
        Perfil.Cesantias = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 366, 24)
        Perfil.NombreFamiliar = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 390, 38)
        Perfil.TelefonoFamiliar = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 428, 12)

        'Normalizar cadenas quitando espacios nulos
        Perfil.Nombre = Perfil.Nombre.Substring(0, Perfil.Nombre.IndexOf(Chr(0)))
        Perfil.Cedula = Perfil.Cedula.Substring(0, Perfil.Cedula.IndexOf(Chr(0)))
        Perfil.Ciudad = Perfil.Ciudad.Substring(0, Perfil.Ciudad.IndexOf(Chr(0)))
        Perfil.Telefono = Perfil.Telefono.Substring(0, Perfil.Telefono.IndexOf(Chr(0)))
        Perfil.TipoContrato = Perfil.TipoContrato.Substring(0, Perfil.TipoContrato.IndexOf(Chr(0)))
        Perfil.Direccion = Perfil.Direccion.Substring(0, Perfil.Direccion.IndexOf(Chr(0)))
        Perfil.RIG = Perfil.RIG.Substring(0, Perfil.RIG.IndexOf(Chr(0)))
        Perfil.Cargo = Perfil.Cargo.Substring(0, Perfil.Cargo.IndexOf(Chr(0)))
        Perfil.TipoSangre = Perfil.TipoSangre.Substring(0, Perfil.TipoSangre.IndexOf(Chr(0)))
        Perfil.LugarContratacion = Perfil.LugarContratacion.Substring(0, Perfil.LugarContratacion.IndexOf(Chr(0)))

        Perfil.EPS = Perfil.EPS.Substring(0, Perfil.EPS.IndexOf(Chr(0)))
        Perfil.ARL = Perfil.ARL.Substring(0, Perfil.ARL.IndexOf(Chr(0)))
        Perfil.Pensiones = Perfil.Pensiones.Substring(0, Perfil.Pensiones.IndexOf(Chr(0)))
        Perfil.Cesantias = Perfil.Cesantias.Substring(0, Perfil.Cesantias.IndexOf(Chr(0)))
        Perfil.NombreFamiliar = Perfil.NombreFamiliar.Substring(0, Perfil.NombreFamiliar.IndexOf(Chr(0)))
        Perfil.TelefonoFamiliar = Perfil.TelefonoFamiliar.Substring(0, Perfil.TelefonoFamiliar.IndexOf(Chr(0)))

        'Mostrar datos y cambiar la visibilidad de los controles
        Perfil_ImprimirDatosPrincipales()

        Dat_Nombre.Visible = True
        Dat_Cedula.Visible = True
        Dat_Ciudad.Visible = True
        Dat_Telefono.Visible = True
        Dat_TipoContrato.Visible = True
        Dat_Direccion.Visible = True
        Dat_FechaTerminacion.Visible = True
        Dat_RIG.Visible = True

        VerOtrosDatos.Visible = True
        ModificarDatos.Visible = True





        ListaArchivos_Actualizar()


        Docs_Adjuntar.Visible = True
        Docs_Renovar.Visible = True
        Docs_Quitar.Visible = True
        ListaDocs.Visible = True
        Label9.Visible = True
        Label10.Visible = True




        'MsgBox(Perfil_Ruta)
    End Sub

    Private Sub ModificarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarDatos.Click
        Dim VerDo_ModDat_Dialog As New VerDocum_ModifDat_Dialog
        Dim dResult As DialogResult

        Dim CleanBuffer As String

        VerDo_ModDat_Dialog.Icon = My.Resources.Icono

        VerDo_ModDat_Dialog.Perfil = Perfil
_Salto1:
        dResult = VerDo_ModDat_Dialog.ShowDialog()
        If dResult = System.Windows.Forms.DialogResult.OK Then
            Perfil = VerDo_ModDat_Dialog.Perfil

            'Convertir fechas
            Try
                Perfil.Date_FechaNacimiento = Date.ParseExact(Perfil.FechaNacimiento, "dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
                Perfil.Date_FechaInicioContrato = Date.ParseExact(Perfil.FechaInicioContrato, "dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
                If Perfil.FechaTerminacionContrato = "0" Then
                    Perfil.Date_FechaTerminacionContrato = Date.FromBinary(0)
                Else
                    Perfil.Date_FechaTerminacionContrato = Date.ParseExact(Perfil.FechaTerminacionContrato, "dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
                End If
            Catch
                Msgbox_Dialog.Imprimir("Error al modificar", "Hay una fecha o un dato que no es legible")
                GoTo _Salto1
            End Try

            'Preparar al buffer (limpiar los campos modificables)
            CleanBuffer = Strings.StrDup(512, Chr(0))

            System.Text.Encoding.UTF8.GetBytes(CleanBuffer, 0, 32).CopyTo(Buffer_Perfil, 120)       'Direccion
            System.Text.Encoding.UTF8.GetBytes(CleanBuffer, 0, 12).CopyTo(Buffer_Perfil, 96)        'Telefono
            System.Text.Encoding.UTF8.GetBytes(CleanBuffer, 0, 24).CopyTo(Buffer_Perfil, 152)       'RIG

            System.Text.Encoding.UTF8.GetBytes(CleanBuffer, 0, 64).CopyTo(Buffer_Perfil, 176)       'Cargo
            System.Text.Encoding.UTF8.GetBytes(CleanBuffer, 0, 20).CopyTo(Buffer_Perfil, 244)       'Lugar de contratacion
            System.Text.Encoding.UTF8.GetBytes(CleanBuffer, 0, 38).CopyTo(Buffer_Perfil, 390)       'Nombre de un familiar
            System.Text.Encoding.UTF8.GetBytes(CleanBuffer, 0, 12).CopyTo(Buffer_Perfil, 428)       'Telefono de un familiar
            System.Text.Encoding.UTF8.GetBytes(CleanBuffer, 0, 24).CopyTo(Buffer_Perfil, 294)       'EPS
            System.Text.Encoding.UTF8.GetBytes(CleanBuffer, 0, 24).CopyTo(Buffer_Perfil, 318)       'ARL
            System.Text.Encoding.UTF8.GetBytes(CleanBuffer, 0, 24).CopyTo(Buffer_Perfil, 342)       'Pensiones
            System.Text.Encoding.UTF8.GetBytes(CleanBuffer, 0, 24).CopyTo(Buffer_Perfil, 366)       'Cesantias

            System.Text.Encoding.UTF8.GetBytes(CleanBuffer, 0, 12).CopyTo(Buffer_Perfil, 108)       'Tipo de contrato
            System.Text.Encoding.UTF8.GetBytes(CleanBuffer, 0, 10).CopyTo(Buffer_Perfil, 274)       'Fecha de inicio
            System.Text.Encoding.UTF8.GetBytes(CleanBuffer, 0, 10).CopyTo(Buffer_Perfil, 284)       'Fecha de terminacion

            'Agregar cambios al Buffer
            System.Text.Encoding.UTF8.GetBytes(Perfil.Direccion).CopyTo(Buffer_Perfil, 120)
            System.Text.Encoding.UTF8.GetBytes(Perfil.Telefono).CopyTo(Buffer_Perfil, 96)
            System.Text.Encoding.UTF8.GetBytes(Perfil.RIG).CopyTo(Buffer_Perfil, 152)

            System.Text.Encoding.UTF8.GetBytes(Perfil.Cargo).CopyTo(Buffer_Perfil, 176)
            System.Text.Encoding.UTF8.GetBytes(Perfil.LugarContratacion).CopyTo(Buffer_Perfil, 244)
            System.Text.Encoding.UTF8.GetBytes(Perfil.NombreFamiliar).CopyTo(Buffer_Perfil, 390)
            System.Text.Encoding.UTF8.GetBytes(Perfil.TelefonoFamiliar).CopyTo(Buffer_Perfil, 428)
            System.Text.Encoding.UTF8.GetBytes(Perfil.EPS).CopyTo(Buffer_Perfil, 294)
            System.Text.Encoding.UTF8.GetBytes(Perfil.ARL).CopyTo(Buffer_Perfil, 318)
            System.Text.Encoding.UTF8.GetBytes(Perfil.Pensiones).CopyTo(Buffer_Perfil, 342)
            System.Text.Encoding.UTF8.GetBytes(Perfil.Cesantias).CopyTo(Buffer_Perfil, 366)

            System.Text.Encoding.UTF8.GetBytes(Perfil.TipoContrato).CopyTo(Buffer_Perfil, 108)
            BitConverter.GetBytes(Perfil.Date_FechaInicioContrato.Ticks).CopyTo(Buffer_Perfil, 274)
            BitConverter.GetBytes(Perfil.Date_FechaTerminacionContrato.Ticks).CopyTo(Buffer_Perfil, 284)

            'Guardar cambios y actualizar
            My.Computer.FileSystem.WriteAllBytes(Perfil_Ruta & "\Perfil.dct", Buffer_Perfil, False)

            Perfil_ImprimirDatosPrincipales()
        End If
    End Sub

    Private Sub VerDocumentacion_Form_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim Pen_AzOsc As New Pen(Color.FromArgb(100, 50, 50, 50), 1)
        Dim Pen_Gris As New Pen(Color.FromArgb(100, 100, 100), 1)

        e.Graphics.DrawRectangle(Pen_AzOsc, 0, 0, Me.Width - 1, Me.Height - 1)

        With TipoBusqueda
            e.Graphics.DrawRectangle(Pen_Gris, .Left - 1, .Top - 1, .Width + 1, .Height + 1)
        End With
    End Sub

    Private Sub Docs_Adjuntar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Docs_Adjuntar.Click
        Dim VerDo_Adj_Dialog As New VerDocum_AdjRenov_Dialog
        Dim dResult As DialogResult

        Dim DestinoArchivo As String
        Dim FechasArchivo(15) As Byte

        VerDo_Adj_Dialog.Icon = My.Resources.Icono
        VerDo_Adj_Dialog.Text = "Adjuntar"
        VerDo_Adj_Dialog.Titulo.Text = "Adjuntar"

_Salto1:
        dResult = VerDo_Adj_Dialog.ShowDialog()
        If dResult = System.Windows.Forms.DialogResult.OK Then
            'Copia del archivo
            DestinoArchivo = Perfil_Ruta & "\" & VerDo_Adj_Dialog.NombreArchivo
            If My.Computer.FileSystem.FileExists(DestinoArchivo) Then
                Msgbox_Dialog.Imprimir("Adjuntar - Advertencia", "Ya existe un archivo con el mismo nombre y por seguridad no se sobrescribirá, por favor seleccione otro archivo o renombre el mismo.")
                GoTo _Salto1
            End If

            My.Computer.FileSystem.CopyFile(VerDo_Adj_Dialog.RutaArchivo, DestinoArchivo)

            'Creacion del archivo asociado a fechas
            BitConverter.GetBytes(Date.Today.Ticks).CopyTo(FechasArchivo, 0)
            BitConverter.GetBytes(VerDo_Adj_Dialog.Date_FechaVencimiento.Ticks).CopyTo(FechasArchivo, 8)
            My.Computer.FileSystem.WriteAllBytes(DestinoArchivo & ".fct", FechasArchivo, False)

            ListaArchivos_Actualizar()
        End If
    End Sub

    Private Sub Docs_Renovar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Docs_Renovar.Click
        Dim VerDo_Renov_Dialog As New VerDocum_AdjRenov_Dialog
        Dim dResult As DialogResult

        Dim str_A() As String
        Dim DestinoArchivo As String
        Dim FechasArchivo(15) As Byte

        If ListaDocs.SelectedIndex < 0 Then
            Msgbox_Dialog.Imprimir("Adjuntar", "Seleccione un archivo de la lista")
            Exit Sub
        End If

        VerDo_Renov_Dialog.Icon = My.Resources.Icono
        VerDo_Renov_Dialog.Text = "Renovar"
        VerDo_Renov_Dialog.Titulo.Text = "Renovar"

_Salto1:
        dResult = VerDo_Renov_Dialog.ShowDialog()
        If dResult = System.Windows.Forms.DialogResult.OK Then
            'Verificar si el nuevo archivo ya existe en la carpeta del perfil
            DestinoArchivo = Perfil_Ruta & "\" & VerDo_Renov_Dialog.NombreArchivo
            If My.Computer.FileSystem.FileExists(DestinoArchivo) Then
                Msgbox_Dialog.Imprimir("Adjuntar - Advertencia", "Ya existe un archivo con el mismo nombre y por seguridad no se sobrescribirá, por favor seleccione otro archivo o renombre el mismo.")
                GoTo _Salto1
            End If

            'Eliminar el archivo seleccionado y el archivo de fechas correspondiente
            str_A = ListaDocs.SelectedItem.ToString.Split(Chr(255))
            My.Computer.FileSystem.DeleteFile(Perfil_Ruta & "\" & str_A(0))
            My.Computer.FileSystem.DeleteFile(Perfil_Ruta & "\" & str_A(0) & ".fct")

            'Copiar el nuevo archivo
            My.Computer.FileSystem.CopyFile(VerDo_Renov_Dialog.RutaArchivo, DestinoArchivo)

            'Creacion del archivo asociado a fechas
            BitConverter.GetBytes(Date.Today.Ticks).CopyTo(FechasArchivo, 0)
            BitConverter.GetBytes(VerDo_Renov_Dialog.Date_FechaVencimiento.Ticks).CopyTo(FechasArchivo, 8)
            My.Computer.FileSystem.WriteAllBytes(DestinoArchivo & ".fct", FechasArchivo, False)

            ListaArchivos_Actualizar()
        End If
    End Sub

    Private Sub VerOtrosDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerOtrosDatos.Click
        Dim VerDo_VerOtrosDat_Dialog As New VerDocum_VerOtrDat_Dialog
        Dim dResult As DialogResult

        With VerDo_VerOtrosDat_Dialog
            .Icon = My.Resources.Icono

            .Cargo.Text = "Cargo: " & Perfil.Cargo
            .FechaNacimiento.Text = "Fecha de nacimiento: " & Perfil.FechaNacimiento
            .TipoSangre.Text = "Tipo de sangre: " & Perfil.TipoSangre

            .EPS.Text = "EPS: " & Perfil.EPS
            .ARL.Text = "ARL: " & Perfil.ARL
            .Pensiones.Text = "Pensiones: " & Perfil.Pensiones
            .Cesantias.Text = "Cesantías: " & Perfil.Cesantias

            .NombreFamiliar.Text = "Nombre: " & Perfil.NombreFamiliar
            .TelefonoFamiliar.Text = "Teléfono: " & Perfil.TelefonoFamiliar

            .LugarContratacion.Text = "Lugar de contratación: " & Perfil.LugarContratacion
            If Perfil.Date_FechaTerminacionContrato.ToBinary = 0 Then
                .FechasContrato.Text = "El contrato inició el " & Perfil.FechaInicioContrato & " y no vence"
            Else
                .FechasContrato.Text = "El contrato inició el " & Perfil.FechaInicioContrato & " y finaliza el " & Perfil.FechaTerminacionContrato
            End If

        End With

        dResult = VerDo_VerOtrosDat_Dialog.ShowDialog()
    End Sub

    Private Sub TipoBusqueda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoBusqueda.SelectedIndexChanged
        If TipoBusqueda.SelectedIndex = 1 Then
            Msgbox_Dialog.Imprimir("Ver documentación", "Advertencia: La busquedas por nombre son mucho mas lentas que por numero de cedula")
        End If
        CampoBusq.Text = ""
        CampoBusq.Focus()
    End Sub

    Private Sub CampoBusq_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CampoBusq.KeyPress
        If Asc(e.KeyChar) = 13 Then Buscar_Click(Buscar, EventArgs.Empty)
    End Sub


    Private Sub Perfil_ImprimirDatosPrincipales()
        Dat_Nombre.Text = "Nombre completo: " & Perfil.Nombre
        Dat_Cedula.Text = "Cédula: " & Perfil.Cedula
        Dat_Ciudad.Text = "Ciudad: " & Perfil.Ciudad
        Dat_Telefono.Text = "Teléfono: " & Perfil.Telefono
        Dat_TipoContrato.Text = "Tipo de contrato: " & Perfil.TipoContrato
        Dat_Direccion.Text = "Dirección: " & Perfil.Direccion

        If Perfil.Date_FechaTerminacionContrato.ToBinary = 0 Then
            Dat_FechaTerminacion.Text = "El contrato no vence"
        Else
            Dat_FechaTerminacion.Text = "El contrato finaliza el " & Perfil.FechaTerminacionContrato
        End If

        Dat_RIG.Text = "RIG: " & Perfil.RIG
    End Sub

    Private Sub ListaArchivos_Actualizar()
        Dim ListadoArchivos_FCT As System.Collections.ObjectModel.ReadOnlyCollection(Of String)

        Dim tmpRutaArchivo As String, NombreArchivo As String
        Dim tmpBufferFechas As Byte(), Date_Subida As Date, Date_Vence As Date

        ListaDocs.Items.Clear()

        'Obtener todos los archivos con la extension fct
        ListadoArchivos_FCT = My.Computer.FileSystem.GetFiles(Perfil_Ruta, FileIO.SearchOption.SearchTopLevelOnly, "*.FCT")

        For i = 0 To ListadoArchivos_FCT.Count - 1
            tmpRutaArchivo = ListadoArchivos_FCT.Item(i)
            tmpBufferFechas = My.Computer.FileSystem.ReadAllBytes(tmpRutaArchivo)

            Date_Subida = System.DateTime.FromBinary(BitConverter.ToInt64(tmpBufferFechas, 0))
            Date_Vence = System.DateTime.FromBinary(BitConverter.ToInt64(tmpBufferFechas, 8))
            NombreArchivo = My.Computer.FileSystem.GetName(tmpRutaArchivo)
            NombreArchivo = NombreArchivo.Substring(0, NombreArchivo.Length - 4)

            If Date_Vence.ToBinary = 0 Then
                ListaDocs.Items.Add(NombreArchivo & Chr(255) & _
                                    "Subido el " & Date_Subida.ToString("dd/MM/yyyy") & " - No vence" & _
                                    Chr(255) & Date_Vence.Ticks)
            Else
                ListaDocs.Items.Add(NombreArchivo & Chr(255) & _
                                    "Subido el " & Date_Subida.ToString("dd/MM/yyyy") & _
                                    " - Vence el " & Date_Vence.ToString("dd/MM/yyyy") & _
                                    Chr(255) & Date_Vence.Ticks)
            End If
        Next
    End Sub

    Private Sub ListaDocs_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaDocs.DoubleClick
        Dim str_A As String()

        str_A = ListaDocs.SelectedItem.ToString.Split(Chr(255))
        Process.Start(Perfil_Ruta & "\" & str_A(0))
    End Sub

    Private Sub ListaDocs_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListaDocs.DrawItem
        Dim str_A As String()
        Dim Fecha As Date, DiferTicks As Long
        Dim Brush_Sel As New SolidBrush(Color.FromArgb(0, 176, 240))
        Dim Brush_Crit As New SolidBrush(Color.FromArgb(100, 0, 0))
        Dim Brush_Crit_Sel As New SolidBrush(Color.FromArgb(130, 0, 50))
        Dim Brush_Alert As New SolidBrush(Color.FromArgb(200, 80, 80))
        Dim Brush_Alert_Sel As New SolidBrush(Color.FromArgb(210, 112, 112))


        str_A = ListaDocs.Items.Item(e.Index).ToString.Split(Chr(255))
        If str_A(0).Length > 64 Then
            str_A(0) = str_A(0).Substring(0, 32) & "..." & str_A(0).Substring(str_A(0).Length - 32)
        End If
        Fecha = System.DateTime.FromBinary(str_A(2))
        DiferTicks = Fecha.Ticks - System.DateTime.Now.Ticks

        'MsgBox(System.DateTime.Parse("30/01/0001").Ticks) = 25056000000000   1 dia = 864000000000

        e.DrawBackground()
        If (Fecha.Ticks = 0) Or (DiferTicks > 25056000000000) Then
            If (e.State And DrawItemState.Selected) = 1 Then e.Graphics.FillRectangle(Brush_Sel, e.Bounds)

            e.Graphics.DrawString(str_A(0), ListaDocs.Font, Brushes.Black, e.Bounds)
            e.Graphics.DrawString(str_A(1), ListaDocs.Font, Brushes.DarkSlateGray, e.Bounds.Left + 200, e.Bounds.Top + 12)
        ElseIf DiferTicks < 0 Then
            e.Graphics.FillRectangle(Brush_Crit, e.Bounds)

            If (e.State And DrawItemState.Selected) = 1 Then e.Graphics.FillRectangle(Brush_Crit_Sel, e.Bounds)

            e.Graphics.DrawString(str_A(0), ListaDocs.Font, Brushes.White, e.Bounds)
            e.Graphics.DrawString(str_A(1).Replace("Vence", "Venció"), ListaDocs.Font, Brushes.LightGray, e.Bounds.Left + 200, e.Bounds.Top + 12)
        ElseIf DiferTicks < 25056000000000 Then
            e.Graphics.FillRectangle(Brush_Alert, e.Bounds)

            If (e.State And DrawItemState.Selected) = 1 Then e.Graphics.FillRectangle(Brush_Alert_Sel, e.Bounds)

            e.Graphics.DrawString(str_A(0), ListaDocs.Font, Brushes.White, e.Bounds)
            e.Graphics.DrawString(str_A(1), ListaDocs.Font, Brushes.LightGray, e.Bounds.Left + 200, e.Bounds.Top + 12)
        End If

        e.DrawFocusRectangle()
    End Sub

    Private Sub ListaDocs_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles ListaDocs.MeasureItem
        e.ItemHeight *= 2
    End Sub

    Private Sub Docs_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Docs_Quitar.Click
        Dim Mensaje_Dialog As New Msgbox_Dialog
        Dim dResult As DialogResult

        Dim str_A() As String

        Mensaje_Dialog.Icon = My.Resources.Icono
        Mensaje_Dialog.MsgTitulo.Text = "Quitar archivos"
        Mensaje_Dialog.Text = Mensaje_Dialog.MsgTitulo.Text

        Mensaje_Dialog.MsgMensaje.Text = "Si está seguro de eliminar el archivo seleccionado, haga clic en Aceptar. Para cancelar, haga clic en cerrar (X)"
        dResult = Mensaje_Dialog.ShowDialog()
        If dResult = System.Windows.Forms.DialogResult.OK Then
            If ListaDocs.SelectedIndex < 0 Then
                Msgbox_Dialog.Imprimir("Adjuntar", "Seleccione un archivo de la lista")
                Exit Sub
            End If

            'Eliminar el archivo seleccionado y el archivo de fechas correspondiente
            str_A = ListaDocs.SelectedItem.ToString.Split(Chr(255))
            My.Computer.FileSystem.DeleteFile(Perfil_Ruta & "\" & str_A(0))
            My.Computer.FileSystem.DeleteFile(Perfil_Ruta & "\" & str_A(0) & ".fct")

            ListaArchivos_Actualizar()
        End If
    End Sub
End Class
