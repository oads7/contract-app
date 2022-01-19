<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerDocum_AdjRenov_Dialog
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
        Me.WClose = New System.Windows.Forms.Button()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.lblArchivo = New System.Windows.Forms.Label()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.SelArchivo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FechaVencimiento = New System.Windows.Forms.TextBox()
        Me.Tool_Tip = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.WClose.Location = New System.Drawing.Point(354, 1)
        Me.WClose.Name = "WClose"
        Me.WClose.Size = New System.Drawing.Size(50, 30)
        Me.WClose.TabIndex = 6
        Me.WClose.TabStop = False
        Me.WClose.Text = "X"
        Me.WClose.UseVisualStyleBackColor = False
        '
        'Titulo
        '
        Me.Titulo.BackColor = System.Drawing.Color.Transparent
        Me.Titulo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.ForeColor = System.Drawing.Color.White
        Me.Titulo.Location = New System.Drawing.Point(20, 10)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(150, 30)
        Me.Titulo.TabIndex = 7
        Me.Titulo.Text = "[Titulo]"
        Me.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblArchivo
        '
        Me.lblArchivo.BackColor = System.Drawing.Color.Transparent
        Me.lblArchivo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArchivo.ForeColor = System.Drawing.Color.White
        Me.lblArchivo.Location = New System.Drawing.Point(40, 50)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(210, 25)
        Me.lblArchivo.TabIndex = 8
        Me.lblArchivo.Text = "[Nombre de Archivo]"
        Me.lblArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Aceptar
        '
        Me.Aceptar.BackColor = System.Drawing.Color.Transparent
        Me.Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Aceptar.FlatAppearance.BorderSize = 2
        Me.Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aceptar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar.ForeColor = System.Drawing.Color.White
        Me.Aceptar.Location = New System.Drawing.Point(270, 125)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(120, 30)
        Me.Aceptar.TabIndex = 11
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = False
        '
        'SelArchivo
        '
        Me.SelArchivo.BackColor = System.Drawing.Color.Transparent
        Me.SelArchivo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.SelArchivo.FlatAppearance.BorderSize = 2
        Me.SelArchivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.SelArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SelArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelArchivo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelArchivo.ForeColor = System.Drawing.Color.White
        Me.SelArchivo.Location = New System.Drawing.Point(250, 48)
        Me.SelArchivo.Name = "SelArchivo"
        Me.SelArchivo.Size = New System.Drawing.Size(140, 30)
        Me.SelArchivo.TabIndex = 12
        Me.SelArchivo.Text = "Seleccionar Archivo"
        Me.SelArchivo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(140, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Fecha de vencimiento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FechaVencimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FechaVencimiento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaVencimiento.Location = New System.Drawing.Point(290, 85)
        Me.FechaVencimiento.MaxLength = 10
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.Size = New System.Drawing.Size(100, 25)
        Me.FechaVencimiento.TabIndex = 14
        Me.Tool_Tip.SetToolTip(Me.FechaVencimiento, "DD/MM/AAAA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si selecciona 0, el archivo no vence")
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
        'VerDocum_AdjRenov_Dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(405, 170)
        Me.Controls.Add(Me.FechaVencimiento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SelArchivo)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.lblArchivo)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.WClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerDocum_AdjRenov_Dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WClose As System.Windows.Forms.Button
    Friend WithEvents Titulo As System.Windows.Forms.Label
    Friend WithEvents lblArchivo As System.Windows.Forms.Label
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents SelArchivo As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FechaVencimiento As System.Windows.Forms.TextBox
    Friend WithEvents Tool_Tip As System.Windows.Forms.ToolTip
End Class
