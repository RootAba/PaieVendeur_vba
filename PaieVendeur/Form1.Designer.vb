<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Fichier = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaieToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NettoyerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoliceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouleurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Fichier, Me.PaieToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(511, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Fichier
        '
        Me.Fichier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaieToolStripMenuItem1})
        Me.Fichier.Name = "Fichier"
        Me.Fichier.Size = New System.Drawing.Size(54, 20)
        Me.Fichier.Text = "Fichier"
        '
        'PaieToolStripMenuItem1
        '
        Me.PaieToolStripMenuItem1.Name = "PaieToolStripMenuItem1"
        Me.PaieToolStripMenuItem1.Size = New System.Drawing.Size(96, 22)
        Me.PaieToolStripMenuItem1.Text = "Paie"
        '
        'PaieToolStripMenuItem
        '
        Me.PaieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NettoyerToolStripMenuItem, Me.PoliceToolStripMenuItem, Me.CouleurToolStripMenuItem})
        Me.PaieToolStripMenuItem.Name = "PaieToolStripMenuItem"
        Me.PaieToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.PaieToolStripMenuItem.Text = "Edition"
        '
        'NettoyerToolStripMenuItem
        '
        Me.NettoyerToolStripMenuItem.Name = "NettoyerToolStripMenuItem"
        Me.NettoyerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NettoyerToolStripMenuItem.Text = "Nettoyer"
        '
        'PoliceToolStripMenuItem
        '
        Me.PoliceToolStripMenuItem.Name = "PoliceToolStripMenuItem"
        Me.PoliceToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PoliceToolStripMenuItem.Text = "Police"
        '
        'CouleurToolStripMenuItem
        '
        Me.CouleurToolStripMenuItem.Name = "CouleurToolStripMenuItem"
        Me.CouleurToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CouleurToolStripMenuItem.Text = "Couleur"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformationToolStripMenuItem})
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.InformationToolStripMenuItem.Text = "Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom Vendeur"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(163, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(163, 117)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Montant Vendu"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 15)
        Me.Label3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 15)
        Me.Label4.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Fichier As ToolStripMenuItem
    Friend WithEvents PaieToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PaieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NettoyerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PoliceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CouleurToolStripMenuItem As ToolStripMenuItem
End Class
