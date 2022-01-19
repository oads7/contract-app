<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerDocum_ModifDat_Dialog
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
        Me.WClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TipoContrato = New System.Windows.Forms.ComboBox()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RIG = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cargo = New System.Windows.Forms.TextBox()
        Me.LugarContratacion = New System.Windows.Forms.TextBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DatosFamiliar = New System.Windows.Forms.Button()
        Me.Afiliaciones = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FechasContrato = New System.Windows.Forms.Button()
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
        Me.WClose.Location = New System.Drawing.Point(529, 1)
        Me.WClose.Name = "WClose"
        Me.WClose.Size = New System.Drawing.Size(50, 30)
        Me.WClose.TabIndex = 6
        Me.WClose.TabStop = False
        Me.WClose.Text = "X"
        Me.WClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Modificar datos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tipo de contrato:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoContrato
        '
        Me.TipoContrato.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TipoContrato.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TipoContrato.FormattingEnabled = True
        Me.TipoContrato.Items.AddRange(New Object() {"INDEFINIDO", "FIJO", "SERVICIOS", "APRENDIZAJE", "TEMPORAL", "OBRA"})
        Me.TipoContrato.Location = New System.Drawing.Point(165, 220)
        Me.TipoContrato.Name = "TipoContrato"
        Me.TipoContrato.Size = New System.Drawing.Size(110, 25)
        Me.TipoContrato.TabIndex = 8
        '
        'Direccion
        '
        Me.Direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Direccion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion.Location = New System.Drawing.Point(110, 50)
        Me.Direccion.MaxLength = 32
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(265, 25)
        Me.Direccion.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(40, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 25)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Dirección:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RIG
        '
        Me.RIG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RIG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RIG.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RIG.Location = New System.Drawing.Point(365, 80)
        Me.RIG.MaxLength = 24
        Me.RIG.Name = "RIG"
        Me.RIG.Size = New System.Drawing.Size(200, 25)
        Me.RIG.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(330, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 25)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "RIG:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Telefono
        '
        Me.Telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Telefono.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefono.Location = New System.Drawing.Point(465, 50)
        Me.Telefono.MaxLength = 12
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(100, 25)
        Me.Telefono.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(400, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Teléfono:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cargo
        '
        Me.Cargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cargo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargo.Location = New System.Drawing.Point(100, 130)
        Me.Cargo.MaxLength = 64
        Me.Cargo.Name = "Cargo"
        Me.Cargo.Size = New System.Drawing.Size(170, 25)
        Me.Cargo.TabIndex = 4
        '
        'LugarContratacion
        '
        Me.LugarContratacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LugarContratacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LugarContratacion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LugarContratacion.Location = New System.Drawing.Point(190, 160)
        Me.LugarContratacion.MaxLength = 20
        Me.LugarContratacion.Name = "LugarContratacion"
        Me.LugarContratacion.Size = New System.Drawing.Size(160, 25)
        Me.LugarContratacion.TabIndex = 5
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
        Me.Guardar.Location = New System.Drawing.Point(445, 260)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(120, 30)
        Me.Guardar.TabIndex = 10
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(40, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(525, 85)
        Me.Label10.TabIndex = 54
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 30)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Otros datos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(50, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(145, 25)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Lugar de contratación:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(50, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 25)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Cargo:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.DatosFamiliar.Location = New System.Drawing.Point(355, 125)
        Me.DatosFamiliar.Name = "DatosFamiliar"
        Me.DatosFamiliar.Size = New System.Drawing.Size(200, 30)
        Me.DatosFamiliar.TabIndex = 6
        Me.DatosFamiliar.Text = "Editar Datos de un Familiar"
        Me.DatosFamiliar.UseVisualStyleBackColor = False
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
        Me.Afiliaciones.Location = New System.Drawing.Point(405, 160)
        Me.Afiliaciones.Name = "Afiliaciones"
        Me.Afiliaciones.Size = New System.Drawing.Size(150, 30)
        Me.Afiliaciones.TabIndex = 7
        Me.Afiliaciones.Text = "Editar Afiliaciones"
        Me.Afiliaciones.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(40, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(385, 50)
        Me.Label4.TabIndex = 60
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(40, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 30)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Renovación de contrato"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FechasContrato
        '
        Me.FechasContrato.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FechasContrato.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.FechasContrato.FlatAppearance.BorderSize = 2
        Me.FechasContrato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.FechasContrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.FechasContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FechasContrato.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechasContrato.ForeColor = System.Drawing.Color.White
        Me.FechasContrato.Location = New System.Drawing.Point(285, 220)
        Me.FechasContrato.Name = "FechasContrato"
        Me.FechasContrato.Size = New System.Drawing.Size(130, 30)
        Me.FechasContrato.TabIndex = 9
        Me.FechasContrato.Text = "Editar Fechas"
        Me.FechasContrato.UseVisualStyleBackColor = False
        '
        'VerDocum_ModifDat_Dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 305)
        Me.Controls.Add(Me.FechasContrato)
        Me.Controls.Add(Me.TipoContrato)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DatosFamiliar)
        Me.Controls.Add(Me.Afiliaciones)
        Me.Controls.Add(Me.Cargo)
        Me.Controls.Add(Me.LugarContratacion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.RIG)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WClose)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerDocum_ModifDat_Dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TipoContrato As System.Windows.Forms.ComboBox
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RIG As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cargo As System.Windows.Forms.TextBox
    Friend WithEvents LugarContratacion As System.Windows.Forms.TextBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DatosFamiliar As System.Windows.Forms.Button
    Friend WithEvents Afiliaciones As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FechasContrato As System.Windows.Forms.Button
End Class
