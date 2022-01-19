Public Class Loading_Screen
    Public Listado_de_Notificaciones(-1) As Notificacion

    Structure Notificacion
        Public Nombre As String
        Public Cedula As String
        Public Documento As String
        Public Faltante_Vencer As Long
    End Structure

    Private Sub Loading_Screen_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim Pen_AzOsc As New Pen(Color.FromArgb(100, 50, 50, 50), 1)

        e.Graphics.DrawRectangle(Pen_AzOsc, 0, 0, Me.Width - 1, Me.Height - 1)
        e.Graphics.DrawString("Cargando...", New Font("Segoe UI", 12), Brushes.White, New Point(86, 48))

        'Precarga
        Me.Icon = My.Resources.Icono
        Bitacora_Form.Icon = My.Resources.Icono
        Msgbox_Dialog.Icon = My.Resources.Icono
        Principal_Form.Icon = My.Resources.Icono
        Registro_Afiliaciones_Dialog.Icon = My.Resources.Icono
        Registro_Contrato_Dialog.Icon = My.Resources.Icono
        Registro_DatosFamiliar_Dialog.Icon = My.Resources.Icono
        Registro_Form.Icon = My.Resources.Icono
        VerDocum_AdjRenov_Dialog.Icon = My.Resources.Icono
        VerDocum_ListCoinc_Dialog.Icon = My.Resources.Icono
        VerDocum_ModifDat_Dialog.Icon = My.Resources.Icono
        VerDocum_VerOtrDat_Dialog.Icon = My.Resources.Icono
        VerDocumentacion_Form.Icon = My.Resources.Icono

        If My.Computer.FileSystem.GetDirectoryInfo("Data").Exists = False Then
            My.Computer.FileSystem.CreateDirectory("Data")
        End If

        'Notificaciones
        Notificaciones()


        Principal_Form.Show()
        Me.Hide()
    End Sub

    'Formato de notificaciones:
    'Nombre \255 Cedula \255 Documento \255 Fecha de vencimiento \255 Cuanto falta para vencerse

    Public Sub Notificaciones()
        Dim DirList As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Dim ArchivosFCT As System.Collections.ObjectModel.ReadOnlyCollection(Of String)

        Dim Buffer_Perfil(440) As Byte, Buffer_FCT(8) As Byte
        Dim TempNotif As Notificacion, tmpStr As String

        Dim Date_Ahora As Long, Date_Vencimiento As Long
        Dim Date_Diff_Ticks As Long

        Dim n As Integer

        'Inicializar
        Date_Ahora = System.DateTime.Now.Ticks

        'Listar carpetas
        DirList = My.Computer.FileSystem.GetDirectories("Data")
        'Listar notificaciones segun fecha
        For i As Integer = 0 To DirList.Count - 1
            'Perfil
            Buffer_Perfil = My.Computer.FileSystem.ReadAllBytes(DirList.Item(i) & "\Perfil.dct")

            Date_Vencimiento = System.DateTime.FromBinary(BitConverter.ToInt64(Buffer_Perfil, 284)).Ticks
            If Date_Vencimiento <> 0 Then
                Date_Diff_Ticks = Date_Vencimiento - Date_Ahora

                If Date_Diff_Ticks < 25056000000000 Then
                    Array.Resize(Listado_de_Notificaciones, Listado_de_Notificaciones.Length + 1)

                    n = Listado_de_Notificaciones.Length - 1
                    With Listado_de_Notificaciones(n)
                        .Nombre = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 0, 64)
                        .Cedula = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 64, 12)
                        .Documento = "El Contrato " & System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 108, 12)
                        .Faltante_Vencer = Date_Diff_Ticks / 864000000000

                        'Normalizar cadenas quitando espacios nulos
                        .Nombre = .Nombre.Substring(0, .Nombre.IndexOf(Chr(0)))
                        .Cedula = .Cedula.Substring(0, .Cedula.IndexOf(Chr(0)))
                    End With
                End If
            End If

            'Archivos adjuntos
            ArchivosFCT = My.Computer.FileSystem.GetFiles(DirList.Item(i), FileIO.SearchOption.SearchTopLevelOnly, "*.FCT")
            For j As Integer = 0 To ArchivosFCT.Count - 1
                Buffer_FCT = My.Computer.FileSystem.ReadAllBytes(ArchivosFCT(j))

                Date_Vencimiento = System.DateTime.FromBinary(BitConverter.ToInt64(Buffer_FCT, 8)).Ticks
                If Date_Vencimiento <> 0 Then
                    Date_Diff_Ticks = Date_Vencimiento - Date_Ahora
                    If Date_Diff_Ticks < 25056000000000 Then
                        Array.Resize(Listado_de_Notificaciones, Listado_de_Notificaciones.Length + 1)

                        n = Listado_de_Notificaciones.Length - 1
                        With Listado_de_Notificaciones(n)
                            .Nombre = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 0, 64)
                            .Cedula = System.Text.Encoding.ASCII.GetString(Buffer_Perfil, 64, 12)
                            tmpStr = My.Computer.FileSystem.GetName(ArchivosFCT(j))
                            tmpStr = tmpStr.Substring(0, tmpStr.Length - 4)
                            If tmpStr.Length > 30 Then
                                tmpStr = tmpStr.Substring(0, 22) & "..." & tmpStr.Substring(tmpStr.Length - 8)
                            End If
                            .Documento = "El documento " & Chr(34) & tmpStr & Chr(34)
                            .Faltante_Vencer = Date_Diff_Ticks / 864000000000

                            'Normalizar cadenas quitando espacios nulos
                            .Nombre = .Nombre.Substring(0, .Nombre.IndexOf(Chr(0)))
                            .Cedula = .Cedula.Substring(0, .Cedula.IndexOf(Chr(0)))
                        End With
                    End If
                End If
            Next
        Next

        'Organizar notificaciones segun fecha
        n = Listado_de_Notificaciones.Length - 1
        For i As Integer = 0 To n
            For j As Integer = 0 To n
                If Listado_de_Notificaciones(i).Faltante_Vencer < Listado_de_Notificaciones(j).Faltante_Vencer Then
                    TempNotif = Listado_de_Notificaciones(j)
                    Listado_de_Notificaciones(j) = Listado_de_Notificaciones(i)
                    Listado_de_Notificaciones(i) = TempNotif
                End If
            Next
        Next

        'Agregar al listbox del formulario principal
        For i As Integer = 0 To n
            Principal_Form.Notificaciones.Items.Add(Listado_de_Notificaciones(i).Nombre & Chr(255) & _
                                                    Listado_de_Notificaciones(i).Cedula & Chr(255) & _
                                                    Listado_de_Notificaciones(i).Documento & Chr(255) & _
                                                    Listado_de_Notificaciones(i).Faltante_Vencer)
        Next
    End Sub
End Class