<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerDocum_VerOtrDat_Dialog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cargo = New System.Windows.Forms.Label()
        Me.WClose = New System.Windows.Forms.Button()
        Me.LugarContratacion = New System.Windows.Forms.Label()
        Me.FechaNacimiento = New System.Windows.Forms.Label()
        Me.TipoSangre = New System.Windows.Forms.Label()
        Me.FechasContrato = New System.Windows.Forms.Label()
        Me.NombreFamiliar = New System.Windows.Forms.Label()
        Me.TelefonoFamiliar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EPS = New System.Windows.Forms.Label()
        Me.ARL = New System.Windows.Forms.Label()
        Me.Pensiones = New System.Windows.Forms.Label()
        Me.Cesantias = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ver otros datos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cargo
        '
        Me.Cargo.BackColor = System.Drawing.Color.Transparent
        Me.Cargo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cargo.ForeColor = System.Drawing.Color.White
        Me.Cargo.Location = New System.Drawing.Point(40, 50)
        Me.Cargo.Name = "Cargo"
        Me.Cargo.Size = New System.Drawing.Size(375, 20)
        Me.Cargo.TabIndex = 26
        Me.Cargo.Text = "Cargo: [Algún cargo]"
        Me.Cargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.WClose.Location = New System.Drawing.Point(379, 1)
        Me.WClose.Name = "WClose"
        Me.WClose.Size = New System.Drawing.Size(50, 30)
        Me.WClose.TabIndex = 27
        Me.WClose.TabStop = False
        Me.WClose.Text = "X"
        Me.WClose.UseVisualStyleBackColor = False
        '
        'LugarContratacion
        '
        Me.LugarContratacion.BackColor = System.Drawing.Color.Transparent
        Me.LugarContratacion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LugarContratacion.ForeColor = System.Drawing.Color.White
        Me.LugarContratacion.Location = New System.Drawing.Point(40, 290)
        Me.LugarContratacion.Name = "LugarContratacion"
        Me.LugarContratacion.Size = New System.Drawing.Size(375, 20)
        Me.LugarContratacion.TabIndex = 28
        Me.LugarContratacion.Text = "Lugar de contratación: [Algún lugar]"
        Me.LugarContratacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.FechaNacimiento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaNacimiento.ForeColor = System.Drawing.Color.White
        Me.FechaNacimiento.Location = New System.Drawing.Point(40, 70)
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.FechaNacimiento.TabIndex = 29
        Me.FechaNacimiento.Text = "Fecha de nacimiento: [Una fecha]"
        Me.FechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TipoSangre
        '
        Me.TipoSangre.BackColor = System.Drawing.Color.Transparent
        Me.TipoSangre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoSangre.ForeColor = System.Drawing.Color.White
        Me.TipoSangre.Location = New System.Drawing.Point(275, 70)
        Me.TipoSangre.Name = "TipoSangre"
        Me.TipoSangre.Size = New System.Drawing.Size(140, 20)
        Me.TipoSangre.TabIndex = 30
        Me.TipoSangre.Text = "Tipo de sangre: [Tipo]"
        Me.TipoSangre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FechasContrato
        '
        Me.FechasContrato.BackColor = System.Drawing.Color.Transparent
        Me.FechasContrato.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechasContrato.ForeColor = System.Drawing.Color.White
        Me.FechasContrato.Location = New System.Drawing.Point(40, 310)
        Me.FechasContrato.Name = "FechasContrato"
        Me.FechasContrato.Size = New System.Drawing.Size(375, 20)
        Me.FechasContrato.TabIndex = 31
        Me.FechasContrato.Text = "El contrato inició el [Una fecha] y finaliza el [Una fecha]"
        Me.FechasContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NombreFamiliar
        '
        Me.NombreFamiliar.BackColor = System.Drawing.Color.Transparent
        Me.NombreFamiliar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreFamiliar.ForeColor = System.Drawing.Color.White
        Me.NombreFamiliar.Location = New System.Drawing.Point(40, 230)
        Me.NombreFamiliar.Name = "NombreFamiliar"
        Me.NombreFamiliar.Size = New System.Drawing.Size(375, 20)
        Me.NombreFamiliar.TabIndex = 32
        Me.NombreFamiliar.Text = "Nombre: [Algún nombre]"
        Me.NombreFamiliar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TelefonoFamiliar
        '
        Me.TelefonoFamiliar.BackColor = System.Drawing.Color.Transparent
        Me.TelefonoFamiliar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoFamiliar.ForeColor = System.Drawing.Color.White
        Me.TelefonoFamiliar.Location = New System.Drawing.Point(40, 250)
        Me.TelefonoFamiliar.Name = "TelefonoFamiliar"
        Me.TelefonoFamiliar.Size = New System.Drawing.Size(375, 20)
        Me.TelefonoFamiliar.TabIndex = 33
        Me.TelefonoFamiliar.Text = "Teléfono: [Algún número]"
        Me.TelefonoFamiliar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Datos de un Familiar"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EPS
        '
        Me.EPS.BackColor = System.Drawing.Color.Transparent
        Me.EPS.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EPS.ForeColor = System.Drawing.Color.White
        Me.EPS.Location = New System.Drawing.Point(40, 110)
        Me.EPS.Name = "EPS"
        Me.EPS.Size = New System.Drawing.Size(375, 20)
        Me.EPS.TabIndex = 35
        Me.EPS.Text = "EPS: [Aseguradora]"
        Me.EPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ARL
        '
        Me.ARL.BackColor = System.Drawing.Color.Transparent
        Me.ARL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ARL.ForeColor = System.Drawing.Color.White
        Me.ARL.Location = New System.Drawing.Point(40, 130)
        Me.ARL.Name = "ARL"
        Me.ARL.Size = New System.Drawing.Size(375, 20)
        Me.ARL.TabIndex = 36
        Me.ARL.Text = "ARL: [Aseguradora]"
        Me.ARL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pensiones
        '
        Me.Pensiones.BackColor = System.Drawing.Color.Transparent
        Me.Pensiones.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pensiones.ForeColor = System.Drawing.Color.White
        Me.Pensiones.Location = New System.Drawing.Point(40, 150)
        Me.Pensiones.Name = "Pensiones"
        Me.Pensiones.Size = New System.Drawing.Size(375, 20)
        Me.Pensiones.TabIndex = 37
        Me.Pensiones.Text = "Pensiones: [Fondo]"
        Me.Pensiones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cesantias
        '
        Me.Cesantias.BackColor = System.Drawing.Color.Transparent
        Me.Cesantias.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cesantias.ForeColor = System.Drawing.Color.White
        Me.Cesantias.Location = New System.Drawing.Point(40, 170)
        Me.Cesantias.Name = "Cesantias"
        Me.Cesantias.Size = New System.Drawing.Size(375, 20)
        Me.Cesantias.TabIndex = 38
        Me.Cesantias.Text = "Cesantías: [Fondo]"
        Me.Cesantias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VerDocum_VerOtrDat_Dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 350)
        Me.Controls.Add(Me.Cesantias)
        Me.Controls.Add(Me.Pensiones)
        Me.Controls.Add(Me.ARL)
        Me.Controls.Add(Me.EPS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TelefonoFamiliar)
        Me.Controls.Add(Me.NombreFamiliar)
        Me.Controls.Add(Me.FechasContrato)
        Me.Controls.Add(Me.TipoSangre)
        Me.Controls.Add(Me.FechaNacimiento)
        Me.Controls.Add(Me.LugarContratacion)
        Me.Controls.Add(Me.WClose)
        Me.Controls.Add(Me.Cargo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerDocum_VerOtrDat_Dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver otros datos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cargo As System.Windows.Forms.Label
    Friend WithEvents WClose As System.Windows.Forms.Button
    Friend WithEvents LugarContratacion As System.Windows.Forms.Label
    Friend WithEvents FechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents TipoSangre As System.Windows.Forms.Label
    Friend WithEvents FechasContrato As System.Windows.Forms.Label
    Friend WithEvents NombreFamiliar As System.Windows.Forms.Label
    Friend WithEvents TelefonoFamiliar As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EPS As System.Windows.Forms.Label
    Friend WithEvents ARL As System.Windows.Forms.Label
    Friend WithEvents Pensiones As System.Windows.Forms.Label
    Friend WithEvents Cesantias As System.Windows.Forms.Label
End Class
