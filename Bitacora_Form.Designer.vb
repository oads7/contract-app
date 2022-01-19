<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bitacora_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bitacora_Form))
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WMinimize = New System.Windows.Forms.Button()
        Me.WClose = New System.Windows.Forms.Button()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.CampoBusq = New System.Windows.Forms.TextBox()
        Me.TipoBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Historial = New System.Windows.Forms.TextBox()
        Me.Anotacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AgregarAnotacion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.Regresar.TabIndex = 17
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
        Me.Label1.Size = New System.Drawing.Size(121, 40)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Bitácora"
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
        Me.WMinimize.TabIndex = 20
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
        Me.WClose.TabIndex = 19
        Me.WClose.TabStop = False
        Me.WClose.Text = "X"
        Me.WClose.UseVisualStyleBackColor = False
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
        Me.Buscar.TabIndex = 23
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = False
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
        Me.CampoBusq.TabIndex = 22
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
        Me.TipoBusqueda.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Buscar por:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Historial
        '
        Me.Historial.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Historial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Historial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Historial.ForeColor = System.Drawing.Color.White
        Me.Historial.Location = New System.Drawing.Point(50, 140)
        Me.Historial.MaxLength = 0
        Me.Historial.Multiline = True
        Me.Historial.Name = "Historial"
        Me.Historial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Historial.Size = New System.Drawing.Size(595, 100)
        Me.Historial.TabIndex = 25
        Me.Historial.TabStop = False
        Me.Historial.Visible = False
        '
        'Anotacion
        '
        Me.Anotacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Anotacion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Anotacion.Location = New System.Drawing.Point(50, 275)
        Me.Anotacion.MaxLength = 0
        Me.Anotacion.Multiline = True
        Me.Anotacion.Name = "Anotacion"
        Me.Anotacion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Anotacion.Size = New System.Drawing.Size(595, 75)
        Me.Anotacion.TabIndex = 26
        Me.Anotacion.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(50, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Nueva anotación:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'AgregarAnotacion
        '
        Me.AgregarAnotacion.BackColor = System.Drawing.Color.Transparent
        Me.AgregarAnotacion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.AgregarAnotacion.FlatAppearance.BorderSize = 2
        Me.AgregarAnotacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.AgregarAnotacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AgregarAnotacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AgregarAnotacion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarAnotacion.ForeColor = System.Drawing.Color.White
        Me.AgregarAnotacion.Location = New System.Drawing.Point(495, 360)
        Me.AgregarAnotacion.Name = "AgregarAnotacion"
        Me.AgregarAnotacion.Size = New System.Drawing.Size(150, 30)
        Me.AgregarAnotacion.TabIndex = 28
        Me.AgregarAnotacion.Text = "Agregar anotación"
        Me.AgregarAnotacion.UseVisualStyleBackColor = False
        Me.AgregarAnotacion.Visible = False
        '
        'Bitacora_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 410)
        Me.Controls.Add(Me.AgregarAnotacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Anotacion)
        Me.Controls.Add(Me.Historial)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.CampoBusq)
        Me.Controls.Add(Me.TipoBusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WMinimize)
        Me.Controls.Add(Me.WClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Regresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bitacora_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContractApp - Bitácora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Regresar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WMinimize As System.Windows.Forms.Button
    Friend WithEvents WClose As System.Windows.Forms.Button
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents CampoBusq As System.Windows.Forms.TextBox
    Friend WithEvents TipoBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Historial As System.Windows.Forms.TextBox
    Friend WithEvents Anotacion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AgregarAnotacion As System.Windows.Forms.Button
End Class
