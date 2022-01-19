<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal_Form
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
        Me.Registrar = New System.Windows.Forms.Button()
        Me.VerDocumentacion = New System.Windows.Forms.Button()
        Me.Bitacora = New System.Windows.Forms.Button()
        Me.Notificaciones = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WClose = New System.Windows.Forms.Button()
        Me.WMinimize = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "¿Qué deseas hacer?"
        '
        'Registrar
        '
        Me.Registrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Registrar.FlatAppearance.BorderSize = 2
        Me.Registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Registrar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registrar.ForeColor = System.Drawing.Color.White
        Me.Registrar.Location = New System.Drawing.Point(90, 150)
        Me.Registrar.Name = "Registrar"
        Me.Registrar.Size = New System.Drawing.Size(195, 40)
        Me.Registrar.TabIndex = 1
        Me.Registrar.Text = "Registrar"
        Me.Registrar.UseVisualStyleBackColor = True
        '
        'VerDocumentacion
        '
        Me.VerDocumentacion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.VerDocumentacion.FlatAppearance.BorderSize = 2
        Me.VerDocumentacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VerDocumentacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VerDocumentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerDocumentacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerDocumentacion.ForeColor = System.Drawing.Color.White
        Me.VerDocumentacion.Location = New System.Drawing.Point(90, 220)
        Me.VerDocumentacion.Name = "VerDocumentacion"
        Me.VerDocumentacion.Size = New System.Drawing.Size(195, 40)
        Me.VerDocumentacion.TabIndex = 2
        Me.VerDocumentacion.Text = "Ver documentación"
        Me.VerDocumentacion.UseVisualStyleBackColor = True
        '
        'Bitacora
        '
        Me.Bitacora.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Bitacora.FlatAppearance.BorderSize = 2
        Me.Bitacora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Bitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bitacora.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bitacora.ForeColor = System.Drawing.Color.White
        Me.Bitacora.Location = New System.Drawing.Point(90, 290)
        Me.Bitacora.Name = "Bitacora"
        Me.Bitacora.Size = New System.Drawing.Size(195, 40)
        Me.Bitacora.TabIndex = 3
        Me.Bitacora.Text = "Bitácora"
        Me.Bitacora.UseVisualStyleBackColor = True
        '
        'Notificaciones
        '
        Me.Notificaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Notificaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Notificaciones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.Notificaciones.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notificaciones.ForeColor = System.Drawing.Color.White
        Me.Notificaciones.FormattingEnabled = True
        Me.Notificaciones.ItemHeight = 15
        Me.Notificaciones.Location = New System.Drawing.Point(360, 180)
        Me.Notificaciones.Name = "Notificaciones"
        Me.Notificaciones.Size = New System.Drawing.Size(290, 200)
        Me.Notificaciones.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(360, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 30)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Listado de notificaciones"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.WClose.TabIndex = 8
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
        Me.WMinimize.TabIndex = 7
        Me.WMinimize.TabStop = False
        Me.WMinimize.Text = "_"
        Me.WMinimize.UseVisualStyleBackColor = False
        '
        'Principal_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 410)
        Me.Controls.Add(Me.WMinimize)
        Me.Controls.Add(Me.WClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Notificaciones)
        Me.Controls.Add(Me.Bitacora)
        Me.Controls.Add(Me.VerDocumentacion)
        Me.Controls.Add(Me.Registrar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Principal_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContractApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Registrar As System.Windows.Forms.Button
    Friend WithEvents VerDocumentacion As System.Windows.Forms.Button
    Friend WithEvents Bitacora As System.Windows.Forms.Button
    Friend WithEvents Notificaciones As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WClose As System.Windows.Forms.Button
    Friend WithEvents WMinimize As System.Windows.Forms.Button

End Class
