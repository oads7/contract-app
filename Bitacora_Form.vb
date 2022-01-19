Public Class Bitacora_Form
    Dim Perfil_Ruta As String

    Dim Bitacora_Ruta As String
    Dim Bitacora_Buffer() As Byte

    Private Sub WMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub WClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WClose.Click
        End
    End Sub

    Private Sub Regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regresar.Click
        Principal_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Bitacora_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TipoBusqueda.SelectedIndex = 0
    End Sub

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Dim Bitac_ListC_Dialog As New VerDocum_ListCoinc_Dialog
        Dim dResult As DialogResult

        Dim NumDirs As Integer, Buffer_Perfil As Byte()
        Dim DirList As System.Collections.ObjectModel.ReadOnlyCollection(Of String)

        Dim str_Nombre As String, str_Cedula As String
        Dim str_CampNombres As String(), l_nom As Integer, res_nom As Boolean

        Bitac_ListC_Dialog.Icon = My.Resources.Icono

        If CampoBusq.TextLength = 0 Then
            Msgbox_Dialog.Imprimir("Bitácora", "El campo de búsqueda esta vacío")
            Exit Sub
        End If
        Label1.Text = "Bitácora - Buscando..."

        If TipoBusqueda.SelectedIndex = 0 Then
            'Buscar por cedula

            If My.Computer.FileSystem.DirectoryExists("Data\" & CampoBusq.Text) = False Then
                Label1.Text = "Bitácora"
                Msgbox_Dialog.Imprimir("Bitácora", "No se encontró un perfil con ese número de cédula")
                Exit Sub
            End If

            Perfil_Ruta = "Data\" & CampoBusq.Text
            Label1.Text = "Bitácora"
        ElseIf TipoBusqueda.SelectedIndex = 1 Then
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
                    Bitac_ListC_Dialog.ListaNombres.Items.Add(str_Nombre & Chr(255) & str_Cedula)
                End If
            Next

            Label1.Text = "Bitácora"
            'Si no hay coincidencias
            If Bitac_ListC_Dialog.ListaNombres.Items.Count = 0 Then
                Msgbox_Dialog.Imprimir("Bitácora", "No coincidió ningún perfil de acuerdo a la busqueda")
                Exit Sub
            End If

            dResult = Bitac_ListC_Dialog.ShowDialog()
            If dResult = System.Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            ElseIf dResult = System.Windows.Forms.DialogResult.OK Then
                'Usando el perfil escogido en el listbox obtener la ruta
                str_Cedula = Bitac_ListC_Dialog.ListaNombres.SelectedItem.ToString
                str_Cedula = str_Cedula.Substring(str_Cedula.IndexOf(Chr(255)) + 1)

                Perfil_Ruta = "Data\" & str_Cedula
            End If
        End If

        'Verifica si existe la bitacora y la carga, sino la crea
        Bitacora_Ruta = Perfil_Ruta & "\" & "Bitacora.bct"
        If My.Computer.FileSystem.FileExists(Bitacora_Ruta) Then
            Bitacora_Buffer = My.Computer.FileSystem.ReadAllBytes(Bitacora_Ruta)
        Else
            Array.Resize(Bitacora_Buffer, 0)
            My.Computer.FileSystem.WriteAllBytes(Bitacora_Ruta, Bitacora_Buffer, False)
        End If

        If Bitacora_Buffer.Length = 0 Then
            Historial.Text = "[No existe ninguna anotación]"
        Else
            Historial.Text = System.Text.Encoding.UTF8.GetString(Bitacora_Buffer)
        End If

        If Anotacion.Visible = False Then
            Historial.Visible = True
            Label3.Visible = True
            Anotacion.Visible = True
            AgregarAnotacion.Visible = True

            With Anotacion
                Me.CreateGraphics.DrawRectangle(New Pen(Color.FromArgb(100, 100, 100), 1), .Left - 1, .Top - 1, .Width + 1, .Height + 1)
            End With
        End If

        Historial.SelectionStart = Historial.TextLength
        Historial.ScrollToCaret()
        Anotacion.Focus()
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

    Private Sub Bitacora_Form_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim Pen_AzOsc As New Pen(Color.FromArgb(100, 50, 50, 50), 1)
        Dim Pen_Gris As New Pen(Color.FromArgb(100, 100, 100), 1)

        e.Graphics.DrawRectangle(Pen_AzOsc, 0, 0, Me.Width - 1, Me.Height - 1)

        With TipoBusqueda
            e.Graphics.DrawRectangle(Pen_Gris, .Left - 1, .Top - 1, .Width + 1, .Height + 1)
        End With
    End Sub

    Private Sub AgregarAnotacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarAnotacion.Click
        Dim i As Integer
        Dim FechaHora As String
        Dim Anot_Buffer() As Byte

        If Anotacion.TextLength > 0 Then
            FechaHora = Date.Now.ToString("[dd/MM/yyyy - hh:mm tt]")

            If Bitacora_Buffer.Length = 0 Then
                Anot_Buffer = System.Text.Encoding.UTF8.GetBytes(FechaHora & vbCrLf & Anotacion.Text)
            Else
                Anot_Buffer = System.Text.Encoding.UTF8.GetBytes(vbCrLf & vbCrLf & FechaHora & vbCrLf & Anotacion.Text)
            End If

            i = Bitacora_Buffer.Length
            Array.Resize(Bitacora_Buffer, i + Anot_Buffer.Length)
            Anot_Buffer.CopyTo(Bitacora_Buffer, i)

            My.Computer.FileSystem.WriteAllBytes(Bitacora_Ruta, Anot_Buffer, True)
            Historial.Text = System.Text.Encoding.UTF8.GetString(Bitacora_Buffer)

            Anotacion.Text=""
        End If
    End Sub

    Private Sub Historial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Historial.KeyPress
        e.Handled = True
    End Sub

    Private Sub Historial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Historial.TextChanged
        Historial.SelectionStart = Historial.TextLength
        Historial.ScrollToCaret()
        Anotacion.Focus()
    End Sub

    Private Sub Anotacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Anotacion.KeyPress
        If Anotacion.TextLength = 0 Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
End Class