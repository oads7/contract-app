<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_Form))
        Me.WMinimize = New System.Windows.Forms.Button()
        Me.WClose = New System.Windows.Forms.Button()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Cedula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Ciudad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.TipoContrato = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RIG = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cargo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TipoSangre = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LugarContratacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.FechaNacimiento = New System.Windows.Forms.TextBox()
        Me.Afiliaciones = New System.Windows.Forms.Button()
        Me.DatosFamiliar = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Tool_Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
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
        Me.WMinimize.TabIndex = 16
        Me.WMinimize.TabStop = False
        Me.WMinimize.Text = "_"
        Me.WMinimize.UseVisualStyleBackColor = False
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
        Me.WClose.TabIndex = 15
        Me.WClose.TabStop = False
        Me.WClose.Text = "X"
        Me.WClose.UseVisualStyleBackColor = False
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
        Me.Regresar.TabIndex = 16
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
        Me.Label1.Size = New System.Drawing.Size(329, 40)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Registrar un nuevo perfil"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nombre completo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Nombre
        '
        Me.Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.Location = New System.Drawing.Point(175, 100)
        Me.Nombre.MaxLength = 64
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(470, 25)
        Me.Nombre.TabIndex = 1
        '
        'Cedula
        '
        Me.Cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cedula.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cedula.Location = New System.Drawing.Point(105, 130)
        Me.Cedula.MaxLength = 12
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(100, 25)
        Me.Cedula.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(50, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Cédula:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(230, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Ciudad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ciudad
        '
        Me.Ciudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ciudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ciudad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ciudad.Location = New System.Drawing.Point(285, 130)
        Me.Ciudad.MaxLength = 20
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.Size = New System.Drawing.Size(160, 25)
        Me.Ciudad.TabIndex = 3
        Me.Tool_Tip.SetToolTip(Me.Ciudad, "Ciudad de nacimiento")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(475, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Teléfono:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Telefono
        '
        Me.Telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Telefono.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefono.Location = New System.Drawing.Point(545, 130)
        Me.Telefono.MaxLength = 12
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(100, 25)
        Me.Telefono.TabIndex = 4
        '
        'TipoContrato
        '
        Me.TipoContrato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TipoContrato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TipoContrato.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TipoContrato.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TipoContrato.FormattingEnabled = True
        Me.TipoContrato.Items.AddRange(New Object() {"INDEFINIDO", "FIJO", "SERVICIOS", "APRENDIZAJE", "TEMPORAL", "OBRA"})
        Me.TipoContrato.Location = New System.Drawing.Point(165, 160)
        Me.TipoContrato.Name = "TipoContrato"
        Me.TipoContrato.Size = New System.Drawing.Size(110, 25)
        Me.TipoContrato.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(50, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 25)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Tipo de contrato:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(310, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 25)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Dirección:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Direccion
        '
        Me.Direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Direccion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.Location = New System.Drawing.Point(380, 160)
        Me.Direccion.MaxLength = 32
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(265, 25)
        Me.Direccion.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(405, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 25)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "RIG:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RIG
        '
        Me.RIG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RIG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RIG.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RIG.Location = New System.Drawing.Point(445, 190)
        Me.RIG.MaxLength = 24
        Me.RIG.Name = "RIG"
        Me.RIG.Size = New System.Drawing.Size(200, 25)
        Me.RIG.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(50, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 30)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Otros datos"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(60, 250)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 25)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Cargo:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(50, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(400, 140)
        Me.Label10.TabIndex = 26
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cargo
        '
        Me.Cargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cargo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargo.Location = New System.Drawing.Point(110, 250)
        Me.Cargo.MaxLength = 64
        Me.Cargo.Name = "Cargo"
        Me.Cargo.Size = New System.Drawing.Size(170, 25)
        Me.Cargo.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(295, 250)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 25)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Tipo de sangre:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoSangre
        '
        Me.TipoSangre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TipoSangre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TipoSangre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoSangre.Location = New System.Drawing.Point(400, 250)
        Me.TipoSangre.MaxLength = 4
        Me.TipoSangre.Name = "TipoSangre"
        Me.TipoSangre.Size = New System.Drawing.Size(40, 25)
        Me.TipoSangre.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(60, 278)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(145, 25)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Lugar de contratación:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LugarContratacion
        '
        Me.LugarContratacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LugarContratacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LugarContratacion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LugarContratacion.Location = New System.Drawing.Point(210, 280)
        Me.LugarContratacion.MaxLength = 20
        Me.LugarContratacion.Name = "LugarContratacion"
        Me.LugarContratacion.Size = New System.Drawing.Size(160, 25)
        Me.LugarContratacion.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(60, 310)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 25)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Fecha de nacimiento:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FechaNacimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FechaNacimiento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaNacimiento.Location = New System.Drawing.Point(200, 310)
        Me.FechaNacimiento.MaxLength = 10
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.Size = New System.Drawing.Size(100, 25)
        Me.FechaNacimiento.TabIndex = 11
        Me.Tool_Tip.SetToolTip(Me.FechaNacimiento, "DD/MM/AAAA")
        '
        'Afiliaciones
        '
        Me.Afiliaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Afiliaciones.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Afiliaciones.FlatAppearance.BorderSize = 2
        Me.Afiliaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Afiliaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Afiliaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Afiliaciones.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Afiliaciones.ForeColor = System.Drawing.Color.White
        Me.Afiliaciones.Location = New System.Drawing.Point(170, 342)
        Me.Afiliaciones.Name = "Afiliaciones"
        Me.Afiliaciones.Size = New System.Drawing.Size(110, 30)
        Me.Afiliaciones.TabIndex = 12
        Me.Afiliaciones.Text = "Afiliaciones"
        Me.Afiliaciones.UseVisualStyleBackColor = False
        '
        'DatosFamiliar
        '
        Me.DatosFamiliar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatosFamiliar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.DatosFamiliar.FlatAppearance.BorderSize = 2
        Me.DatosFamiliar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DatosFamiliar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DatosFamiliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DatosFamiliar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatosFamiliar.ForeColor = System.Drawing.Color.White
        Me.DatosFamiliar.Location = New System.Drawing.Point(290, 342)
        Me.DatosFamiliar.Name = "DatosFamiliar"
        Me.DatosFamiliar.Size = New System.Drawing.Size(150, 30)
        Me.DatosFamiliar.TabIndex = 13
        Me.DatosFamiliar.Text = "Datos de un Familiar"
        Me.DatosFamiliar.UseVisualStyleBackColor = False
        '
        'Guardar
        '
        Me.Guardar.BackColor = System.Drawing.Color.Transparent
        Me.Guardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Guardar.FlatAppearance.BorderSize = 2
        Me.Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Guardar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.ForeColor = System.Drawing.Color.White
        Me.Guardar.Location = New System.Drawing.Point(525, 350)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(120, 30)
        Me.Guardar.TabIndex = 14
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = False
        '
        'Tool_Tip
        '
        Me.Tool_Tip.AutomaticDelay = 100
        Me.Tool_Tip.AutoPopDelay = 10000
        Me.Tool_Tip.InitialDelay = 100
        Me.Tool_Tip.IsBalloon = True
        Me.Tool_Tip.ReshowDelay = 20
        Me.Tool_Tip.Tag = ""
        '
        'Registro_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 410)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.DatosFamiliar)
        Me.Controls.Add(Me.Afiliaciones)
        Me.Controls.Add(Me.FechaNacimiento)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LugarContratacion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TipoSangre)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Cargo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RIG)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TipoContrato)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Ciudad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cedula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.WMinimize)
        Me.Controls.Add(Me.WClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContractApp - Registrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WMinimize As System.Windows.Forms.Button
    Friend WithEvents WClose As System.Windows.Forms.Button
    Friend WithEvents Regresar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Cedula As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Ciudad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents TipoContrato As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RIG As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Cargo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TipoSangre As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LugarContratacion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents FechaNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents Afiliaciones As System.Windows.Forms.Button
    Friend WithEvents DatosFamiliar As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Tool_Tip As System.Windows.Forms.ToolTip
End Class
