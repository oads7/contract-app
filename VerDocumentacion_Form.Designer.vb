<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerDocumentacion_Form
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerDocumentacion_Form))
        Me.WClose = New System.Windows.Forms.Button()
        Me.WMinimize = New System.Windows.Forms.Button()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TipoBusqueda = New System.Windows.Forms.ComboBox()
        Me.CampoBusq = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Dat_Cedula = New System.Windows.Forms.Label()
        Me.Dat_Ciudad = New System.Windows.Forms.Label()
        Me.Dat_Nombre = New System.Windows.Forms.Label()
        Me.Dat_Telefono = New System.Windows.Forms.Label()
        Me.Dat_TipoContrato = New System.Windows.Forms.Label()
        Me.Dat_Direccion = New System.Windows.Forms.Label()
        Me.Dat_FechaTerminacion = New System.Windows.Forms.Label()
        Me.Dat_RIG = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ModificarDatos = New System.Windows.Forms.Button()
        Me.VerOtrosDatos = New System.Windows.Forms.Button()
        Me.ListaDocs = New System.Windows.Forms.ListBox()
        Me.Docs_Adjuntar = New System.Windows.Forms.Button()
        Me.Docs_Renovar = New System.Windows.Forms.Button()
        Me.Docs_Quitar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WClose
        '
        Me.WClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.WClose.FlatAppearance.BorderSize = 0
        Me.WClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.WClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.WClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WClose.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WClose.ForeColor = System.Drawing.Color.White
        Me.WClose.Location = New System.Drawing.Point(630, 0)
        Me.WClose.Name = "WClose"
        Me.WClose.Size = New System.Drawing.Size(50, 30)
        Me.WClose.TabIndex = 16
        Me.WClose.TabStop = False
        Me.WClose.Text = "X"
        Me.WClose.UseVisualStyleBackColor = False
        '
        'WMinimize
        '
        Me.WMinimize.BackColor = System.Drawing.Color.Transparent
        Me.WMinimize.FlatAppearance.BorderSize = 0
        Me.WMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.WMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WMinimize.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WMinimize.ForeColor = System.Drawing.Color.White
        Me.WMinimize.Location = New System.Drawing.Point(590, 0)
        Me.WMinimize.Name = "WMinimize"
        Me.WMinimize.Size = New System.Drawing.Size(40, 30)
        Me.WMinimize.TabIndex = 17
        Me.WMinimize.TabStop = False
        Me.WMinimize.Text = "_"
        Me.WMinimize.UseVisualStyleBackColor = False
        '
        'Regresar
        '
        Me.Regresar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Regresar.FlatAppearance.BorderSize = 0
        Me.Regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Regresar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.White
        Me.Regresar.Image = CType(resources.GetObject("Regresar.Image"), System.Drawing.Image)
        Me.Regresar.Location = New System.Drawing.Point(25, 25)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(50, 50)
        Me.Regresar.TabIndex = 18
        Me.Regresar.TabStop = False
        Me.Regresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(80, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 40)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ver documentación"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Buscar por:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoBusqueda
        '
        Me.TipoBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TipoBusqueda.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TipoBusqueda.FormattingEnabled = True
        Me.TipoBusqueda.Items.AddRange(New Object() {"Cedula", "Nombre"})
        Me.TipoBusqueda.Location = New System.Drawing.Point(130, 100)
        Me.TipoBusqueda.Name = "TipoBusqueda"
        Me.TipoBusqueda.Size = New System.Drawing.Size(90, 25)
        Me.TipoBusqueda.TabIndex = 1
        '
        'CampoBusq
        '
        Me.CampoBusq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CampoBusq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CampoBusq.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CampoBusq.Location = New System.Drawing.Point(230, 100)
        Me.CampoBusq.MaxLength = 64
        Me.CampoBusq.Name = "CampoBusq"
        Me.CampoBusq.Size = New System.Drawing.Size(300, 25)
        Me.CampoBusq.TabIndex = 2
        '
        'Buscar
        '
        Me.Buscar.BackColor = System.Drawing.Color.Transparent
        Me.Buscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Buscar.FlatAppearance.BorderSize = 2
        Me.Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.ForeColor = System.Drawing.Color.White
        Me.Buscar.Location = New System.Drawing.Point(545, 98)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(100, 30)
        Me.Buscar.TabIndex = 3
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = False
        '
        'Dat_Cedula
        '
        Me.Dat_Cedula.BackColor = System.Drawing.Color.Transparent
        Me.Dat_Cedula.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_Cedula.ForeColor = System.Drawing.Color.White
        Me.Dat_Cedula.Location = New System.Drawing.Point(50, 150)
        Me.Dat_Cedula.Name = "Dat_Cedula"
        Me.Dat_Cedula.Size = New System.Drawing.Size(150, 20)
        Me.Dat_Cedula.TabIndex = 24
        Me.Dat_Cedula.Text = "Cédula: [Algún numero]"
        Me.Dat_Cedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dat_Cedula.Visible = False
        '
        'Dat_Ciudad
        '
        Me.Dat_Ciudad.BackColor = System.Drawing.Color.Transparent
        Me.Dat_Ciudad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_Ciudad.ForeColor = System.Drawing.Color.White
        Me.Dat_Ciudad.Location = New System.Drawing.Point(230, 150)
        Me.Dat_Ciudad.Name = "Dat_Ciudad"
        Me.Dat_Ciudad.Size = New System.Drawing.Size(220, 20)
        Me.Dat_Ciudad.TabIndex = 25
        Me.Dat_Ciudad.Text = "Ciudad: [Algún lugar]"
        Me.Dat_Ciudad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dat_Ciudad.Visible = False
        '
        'Dat_Nombre
        '
        Me.Dat_Nombre.BackColor = System.Drawing.Color.Transparent
        Me.Dat_Nombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_Nombre.ForeColor = System.Drawing.Color.White
        Me.Dat_Nombre.Location = New System.Drawing.Point(50, 130)
        Me.Dat_Nombre.Name = "Dat_Nombre"
        Me.Dat_Nombre.Size = New System.Drawing.Size(595, 20)
        Me.Dat_Nombre.TabIndex = 26
        Me.Dat_Nombre.Text = "Nombre completo: [Algún nombre]"
        Me.Dat_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dat_Nombre.Visible = False
        '
        'Dat_Telefono
        '
        Me.Dat_Telefono.BackColor = System.Drawing.Color.Transparent
        Me.Dat_Telefono.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_Telefono.ForeColor = System.Drawing.Color.White
        Me.Dat_Telefono.Location = New System.Drawing.Point(485, 150)
        Me.Dat_Telefono.Name = "Dat_Telefono"
        Me.Dat_Telefono.Size = New System.Drawing.Size(160, 20)
        Me.Dat_Telefono.TabIndex = 27
        Me.Dat_Telefono.Text = "Teléfono: [Algún número]"
        Me.Dat_Telefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dat_Telefono.Visible = False
        '
        'Dat_TipoContrato
        '
        Me.Dat_TipoContrato.BackColor = System.Drawing.Color.Transparent
        Me.Dat_TipoContrato.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_TipoContrato.ForeColor = System.Drawing.Color.White
        Me.Dat_TipoContrato.Location = New System.Drawing.Point(50, 170)
        Me.Dat_TipoContrato.Name = "Dat_TipoContrato"
        Me.Dat_TipoContrato.Size = New System.Drawing.Size(200, 20)
        Me.Dat_TipoContrato.TabIndex = 28
        Me.Dat_TipoContrato.Text = "Tipo de contrato: [Término Tal]"
        Me.Dat_TipoContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dat_TipoContrato.Visible = False
        '
        'Dat_Direccion
        '
        Me.Dat_Direccion.BackColor = System.Drawing.Color.Transparent
        Me.Dat_Direccion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_Direccion.ForeColor = System.Drawing.Color.White
        Me.Dat_Direccion.Location = New System.Drawing.Point(290, 170)
        Me.Dat_Direccion.Name = "Dat_Direccion"
        Me.Dat_Direccion.Size = New System.Drawing.Size(355, 20)
        Me.Dat_Direccion.TabIndex = 29
        Me.Dat_Direccion.Text = "Dirección: [Una dirección]"
        Me.Dat_Direccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dat_Direccion.Visible = False
        '
        'Dat_FechaTerminacion
        '
        Me.Dat_FechaTerminacion.BackColor = System.Drawing.Color.Transparent
        Me.Dat_FechaTerminacion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_FechaTerminacion.ForeColor = System.Drawing.Color.White
        Me.Dat_FechaTerminacion.Location = New System.Drawing.Point(50, 190)
        Me.Dat_FechaTerminacion.Name = "Dat_FechaTerminacion"
        Me.Dat_FechaTerminacion.Size = New System.Drawing.Size(210, 20)
        Me.Dat_FechaTerminacion.TabIndex = 30
        Me.Dat_FechaTerminacion.Text = "El contrato finaliza el [Una fecha]"
        Me.Dat_FechaTerminacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dat_FechaTerminacion.Visible = False
        '
        'Dat_RIG
        '
        Me.Dat_RIG.BackColor = System.Drawing.Color.Transparent
        Me.Dat_RIG.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dat_RIG.ForeColor = System.Drawing.Color.White
        Me.Dat_RIG.Location = New System.Drawing.Point(290, 190)
        Me.Dat_RIG.Name = "Dat_RIG"
        Me.Dat_RIG.Size = New System.Drawing.Size(355, 20)
        Me.Dat_RIG.TabIndex = 31
        Me.Dat_RIG.Text = "RIG: [Algún número]"
        Me.Dat_RIG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dat_RIG.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(50, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 30)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Listado de Documentos"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(50, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(595, 140)
        Me.Label10.TabIndex = 33
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label10.Visible = False
        '
        'ModificarDatos
        '
        Me.ModificarDatos.BackColor = System.Drawing.Color.Transparent
        Me.ModificarDatos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ModificarDatos.FlatAppearance.BorderSize = 2
        Me.ModificarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.ModificarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ModificarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModificarDatos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarDatos.ForeColor = System.Drawing.Color.White
        Me.ModificarDatos.Location = New System.Drawing.Point(505, 220)
        Me.ModificarDatos.Name = "ModificarDatos"
        Me.ModificarDatos.Size = New System.Drawing.Size(140, 30)
        Me.ModificarDatos.TabIndex = 4
        Me.ModificarDatos.Text = "Modificar datos"
        Me.ModificarDatos.UseVisualStyleBackColor = False
        Me.ModificarDatos.Visible = False
        '
        'VerOtrosDatos
        '
        Me.VerOtrosDatos.BackColor = System.Drawing.Color.Transparent
        Me.VerOtrosDatos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.VerOtrosDatos.FlatAppearance.BorderSize = 2
        Me.VerOtrosDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VerOtrosDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VerOtrosDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerOtrosDatos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerOtrosDatos.ForeColor = System.Drawing.Color.White
        Me.VerOtrosDatos.Location = New System.Drawing.Point(355, 220)
        Me.VerOtrosDatos.Name = "VerOtrosDatos"
        Me.VerOtrosDatos.Size = New System.Drawing.Size(140, 30)
        Me.VerOtrosDatos.TabIndex = 5
        Me.VerOtrosDatos.Text = "Ver otros datos"
        Me.VerOtrosDatos.UseVisualStyleBackColor = False
        Me.VerOtrosDatos.Visible = False
        '
        'ListaDocs
        '
        Me.ListaDocs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListaDocs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.ListaDocs.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ListaDocs.FormattingEnabled = True
        Me.ListaDocs.Location = New System.Drawing.Point(60, 270)
        Me.ListaDocs.Name = "ListaDocs"
        Me.ListaDocs.Size = New System.Drawing.Size(465, 121)
        Me.ListaDocs.TabIndex = 36
        Me.ListaDocs.TabStop = False
        Me.ListaDocs.Visible = False
        '
        'Docs_Adjuntar
        '
        Me.Docs_Adjuntar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Docs_Adjuntar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Docs_Adjuntar.FlatAppearance.BorderSize = 2
        Me.Docs_Adjuntar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Docs_Adjuntar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Docs_Adjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Docs_Adjuntar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Docs_Adjuntar.ForeColor = System.Drawing.Color.White
        Me.Docs_Adjuntar.Location = New System.Drawing.Point(535, 270)
        Me.Docs_Adjuntar.Name = "Docs_Adjuntar"
        Me.Docs_Adjuntar.Size = New System.Drawing.Size(100, 30)
        Me.Docs_Adjuntar.TabIndex = 6
        Me.Docs_Adjuntar.Text = "Adjuntar"
        Me.Docs_Adjuntar.UseVisualStyleBackColor = False
        Me.Docs_Adjuntar.Visible = False
        '
        'Docs_Renovar
        '
        Me.Docs_Renovar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Docs_Renovar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Docs_Renovar.FlatAppearance.BorderSize = 2
        Me.Docs_Renovar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Docs_Renovar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Docs_Renovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Docs_Renovar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Docs_Renovar.ForeColor = System.Drawing.Color.White
        Me.Docs_Renovar.Location = New System.Drawing.Point(535, 305)
        Me.Docs_Renovar.Name = "Docs_Renovar"
        Me.Docs_Renovar.Size = New System.Drawing.Size(100, 30)
        Me.Docs_Renovar.TabIndex = 7
        Me.Docs_Renovar.Text = "Renovar"
        Me.Docs_Renovar.UseVisualStyleBackColor = False
        Me.Docs_Renovar.Visible = False
        '
        'Docs_Quitar
        '
        Me.Docs_Quitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Docs_Quitar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Docs_Quitar.FlatAppearance.BorderSize = 2
        Me.Docs_Quitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Docs_Quitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Docs_Quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Docs_Quitar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Docs_Quitar.ForeColor = System.Drawing.Color.White
        Me.Docs_Quitar.Location = New System.Drawing.Point(535, 340)
        Me.Docs_Quitar.Name = "Docs_Quitar"
        Me.Docs_Quitar.Size = New System.Drawing.Size(100, 30)
        Me.Docs_Quitar.TabIndex = 8
        Me.Docs_Quitar.Text = "Quitar"
        Me.Docs_Quitar.UseVisualStyleBackColor = False
        Me.Docs_Quitar.Visible = False
        '
        'VerDocumentacion_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 410)
        Me.Controls.Add(Me.Docs_Quitar)
        Me.Controls.Add(Me.Docs_Renovar)
        Me.Controls.Add(Me.Docs_Adjuntar)
        Me.Controls.Add(Me.ListaDocs)
        Me.Controls.Add(Me.VerOtrosDatos)
        Me.Controls.Add(Me.ModificarDatos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Dat_RIG)
        Me.Controls.Add(Me.Dat_FechaTerminacion)
        Me.Controls.Add(Me.Dat_Direccion)
        Me.Controls.Add(Me.Dat_TipoContrato)
        Me.Controls.Add(Me.Dat_Telefono)
        Me.Controls.Add(Me.Dat_Nombre)
        Me.Controls.Add(Me.Dat_Ciudad)
        Me.Controls.Add(Me.Dat_Cedula)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.CampoBusq)
        Me.Controls.Add(Me.TipoBusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.WMinimize)
        Me.Controls.Add(Me.WClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerDocumentacion_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContractApp - Ver documentación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WClose As System.Windows.Forms.Button
    Friend WithEvents WMinimize As System.Windows.Forms.Button
    Friend WithEvents Regresar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TipoBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents CampoBusq As System.Windows.Forms.TextBox
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents Dat_Cedula As System.Windows.Forms.Label
    Friend WithEvents Dat_Ciudad As System.Windows.Forms.Label
    Friend WithEvents Dat_Nombre As System.Windows.Forms.Label
    Friend WithEvents Dat_Telefono As System.Windows.Forms.Label
    Friend WithEvents Dat_TipoContrato As System.Windows.Forms.Label
    Friend WithEvents Dat_Direccion As System.Windows.Forms.Label
    Friend WithEvents Dat_FechaTerminacion As System.Windows.Forms.Label
    Friend WithEvents Dat_RIG As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ModificarDatos As System.Windows.Forms.Button
    Friend WithEvents VerOtrosDatos As System.Windows.Forms.Button
    Friend WithEvents ListaDocs As System.Windows.Forms.ListBox
    Friend WithEvents Docs_Adjuntar As System.Windows.Forms.Button
    Friend WithEvents Docs_Renovar As System.Windows.Forms.Button
    Friend WithEvents Docs_Quitar As System.Windows.Forms.Button
End Class
