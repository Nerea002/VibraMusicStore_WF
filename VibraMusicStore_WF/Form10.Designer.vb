<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstrumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccesoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorreovibracorreofakexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.VibraMusicStore_WF.My.Resources.Resources.Groovy
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(416, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 216)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip1.Font = New System.Drawing.Font("ItalicC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(666, 26)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatalogoToolStripMenuItem
        '
        Me.CatalogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstrumentosToolStripMenuItem, Me.AccesoriosToolStripMenuItem})
        Me.CatalogoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        Me.CatalogoToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.CatalogoToolStripMenuItem.Text = "Catálogo"
        '
        'InstrumentosToolStripMenuItem
        '
        Me.InstrumentosToolStripMenuItem.Name = "InstrumentosToolStripMenuItem"
        Me.InstrumentosToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.InstrumentosToolStripMenuItem.Text = "Instrumentos"
        '
        'AccesoriosToolStripMenuItem
        '
        Me.AccesoriosToolStripMenuItem.Name = "AccesoriosToolStripMenuItem"
        Me.AccesoriosToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.AccesoriosToolStripMenuItem.Text = "Accesorios"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ConsultasToolStripMenuItem.Text = "Servicios"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.CorreovibracorreofakexToolStripMenuItem})
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ReportesToolStripMenuItem.Text = "Contactanos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(416, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "BIENVENIDO"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("ItalicT", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(445, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cerrar Sesión"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Productos más vendidos"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(372, 303)
        Me.DataGridView1.TabIndex = 7
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(289, 22)
        Me.ToolStripMenuItem2.Text = "000-010-00-70"
        '
        'CorreovibracorreofakexToolStripMenuItem
        '
        Me.CorreovibracorreofakexToolStripMenuItem.Name = "CorreovibracorreofakexToolStripMenuItem"
        Me.CorreovibracorreofakexToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.CorreovibracorreofakexToolStripMenuItem.Text = "correovibra@correofake.x"
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(666, 405)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form10"
        Me.Text = "Form10"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatalogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstrumentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccesoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CorreovibracorreofakexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
