﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ver
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.bAnterior = New System.Windows.Forms.Button()
        Me.bSiguiente = New System.Windows.Forms.Button()
        Me.VerDatos1 = New Proyecto.VerDatos()
        Me.tlpBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.bAnterior, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.bSiguiente, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.VerDatos1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tlpBotones, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'bAnterior
        '
        Me.bAnterior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bAnterior.Location = New System.Drawing.Point(3, 3)
        Me.bAnterior.Name = "bAnterior"
        Me.bAnterior.Size = New System.Drawing.Size(75, 34)
        Me.bAnterior.TabIndex = 1
        Me.bAnterior.Text = "<"
        Me.bAnterior.UseVisualStyleBackColor = True
        '
        'bSiguiente
        '
        Me.bSiguiente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bSiguiente.Location = New System.Drawing.Point(722, 3)
        Me.bSiguiente.Name = "bSiguiente"
        Me.bSiguiente.Size = New System.Drawing.Size(75, 34)
        Me.bSiguiente.TabIndex = 2
        Me.bSiguiente.Text = ">"
        Me.bSiguiente.UseVisualStyleBackColor = True
        '
        'VerDatos1
        '
        Me.VerDatos1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerDatos1.Location = New System.Drawing.Point(84, 43)
        Me.VerDatos1.Name = "VerDatos1"
        Me.VerDatos1.Size = New System.Drawing.Size(632, 404)
        Me.VerDatos1.TabIndex = 3
        '
        'tlpBotones
        '
        Me.tlpBotones.ColumnCount = 5
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpBotones.Controls.Add(Me.Button3, 2, 0)
        Me.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBotones.Location = New System.Drawing.Point(84, 3)
        Me.tlpBotones.Name = "tlpBotones"
        Me.tlpBotones.RowCount = 1
        Me.tlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpBotones.Size = New System.Drawing.Size(632, 34)
        Me.tlpBotones.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Location = New System.Drawing.Point(255, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 28)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Ver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ver"
        Me.Text = "Ver"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tlpBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents bAnterior As Button
    Friend WithEvents bSiguiente As Button
    Friend WithEvents VerDatos1 As VerDatos
    Friend WithEvents tlpBotones As TableLayoutPanel
    Friend WithEvents Button3 As Button
End Class
