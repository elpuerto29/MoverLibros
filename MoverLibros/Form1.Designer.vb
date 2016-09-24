<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.LabelDirectorio = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelLetra = New System.Windows.Forms.Label()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonMover = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonDestino = New System.Windows.Forms.Button()
        Me.ButtonOrigen = New System.Windows.Forms.Button()
        Me.Label_DEstino = New System.Windows.Forms.Label()
        Me.Label_Origen = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelDirectorio
        '
        Me.LabelDirectorio.AutoSize = True
        Me.LabelDirectorio.Location = New System.Drawing.Point(79, 258)
        Me.LabelDirectorio.Name = "LabelDirectorio"
        Me.LabelDirectorio.Size = New System.Drawing.Size(0, 13)
        Me.LabelDirectorio.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(723, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LabelLetra)
        Me.GroupBox1.Controls.Add(Me.ButtonCancelar)
        Me.GroupBox1.Controls.Add(Me.ButtonMover)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonDestino)
        Me.GroupBox1.Controls.Add(Me.ButtonOrigen)
        Me.GroupBox1.Controls.Add(Me.Label_DEstino)
        Me.GroupBox1.Controls.Add(Me.Label_Origen)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 276)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(390, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "STOP"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'LabelLetra
        '
        Me.LabelLetra.AutoSize = True
        Me.LabelLetra.Location = New System.Drawing.Point(48, 243)
        Me.LabelLetra.Name = "LabelLetra"
        Me.LabelLetra.Size = New System.Drawing.Size(0, 13)
        Me.LabelLetra.TabIndex = 21
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancelar.Location = New System.Drawing.Point(390, 163)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 20
        Me.ButtonCancelar.Text = "SALIR"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'ButtonMover
        '
        Me.ButtonMover.Location = New System.Drawing.Point(390, 82)
        Me.ButtonMover.Name = "ButtonMover"
        Me.ButtonMover.Size = New System.Drawing.Size(75, 23)
        Me.ButtonMover.TabIndex = 19
        Me.ButtonMover.Text = "Mover Archivos"
        Me.ButtonMover.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(157, 166)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(201, 20)
        Me.TextBox2.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(157, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 20)
        Me.TextBox1.TabIndex = 17
        '
        'ButtonDestino
        '
        Me.ButtonDestino.Location = New System.Drawing.Point(51, 166)
        Me.ButtonDestino.Name = "ButtonDestino"
        Me.ButtonDestino.Size = New System.Drawing.Size(85, 23)
        Me.ButtonDestino.TabIndex = 16
        Me.ButtonDestino.Text = "Elegir Destino"
        Me.ButtonDestino.UseVisualStyleBackColor = True
        '
        'ButtonOrigen
        '
        Me.ButtonOrigen.Location = New System.Drawing.Point(51, 77)
        Me.ButtonOrigen.Name = "ButtonOrigen"
        Me.ButtonOrigen.Size = New System.Drawing.Size(85, 28)
        Me.ButtonOrigen.TabIndex = 15
        Me.ButtonOrigen.Text = "Elegir Origen"
        Me.ButtonOrigen.UseVisualStyleBackColor = True
        '
        'Label_DEstino
        '
        Me.Label_DEstino.AutoSize = True
        Me.Label_DEstino.Location = New System.Drawing.Point(48, 131)
        Me.Label_DEstino.Name = "Label_DEstino"
        Me.Label_DEstino.Size = New System.Drawing.Size(94, 13)
        Me.Label_DEstino.TabIndex = 14
        Me.Label_DEstino.Text = "Directorio Destino:"
        '
        'Label_Origen
        '
        Me.Label_Origen.AutoSize = True
        Me.Label_Origen.Location = New System.Drawing.Point(48, 49)
        Me.Label_Origen.Name = "Label_Origen"
        Me.Label_Origen.Size = New System.Drawing.Size(89, 13)
        Me.Label_Origen.TabIndex = 13
        Me.Label_Origen.Text = "Directorio Origen:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(663, 100)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mover libros desde biblioteca CALIBRE al directorio temporal."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Directorio temporal:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(168, 49)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(367, 20)
        Me.TextBox3.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(723, 524)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelDirectorio)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mover Libros"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents LabelDirectorio As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelLetra As Label
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ButtonMover As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonDestino As Button
    Friend WithEvents ButtonOrigen As Button
    Friend WithEvents Label_DEstino As Label
    Friend WithEvents Label_Origen As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
End Class
