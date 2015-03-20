<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits MilkGear.gdkForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.PicPanel = New System.Windows.Forms.Panel()
        Me.Preview = New System.Windows.Forms.PictureBox()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.BtnImport = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.TitleBar.SuspendLayout()
        Me.PicPanel.SuspendLayout()
        CType(Me.Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblTitle.Location = New System.Drawing.Point(4, 4)
        Me.LblTitle.Size = New System.Drawing.Size(182, 19)
        Me.LblTitle.Text = "MilkGear v0.3 - by gdkchan"
        '
        'TitleBar
        '
        Me.TitleBar.Controls.Add(Me.BtnExport)
        Me.TitleBar.Controls.Add(Me.BtnImport)
        Me.TitleBar.Controls.Add(Me.BtnSave)
        Me.TitleBar.Controls.Add(Me.BtnOpen)
        Me.TitleBar.Controls.SetChildIndex(Me.LblTitle, 0)
        Me.TitleBar.Controls.SetChildIndex(Me.BtnOpen, 0)
        Me.TitleBar.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.TitleBar.Controls.SetChildIndex(Me.BtnImport, 0)
        Me.TitleBar.Controls.SetChildIndex(Me.BtnExport, 0)
        '
        'PicPanel
        '
        Me.PicPanel.AutoScroll = True
        Me.PicPanel.BackColor = System.Drawing.Color.Transparent
        Me.PicPanel.Controls.Add(Me.Preview)
        Me.PicPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicPanel.Location = New System.Drawing.Point(0, 28)
        Me.PicPanel.Name = "PicPanel"
        Me.PicPanel.Size = New System.Drawing.Size(640, 356)
        Me.PicPanel.TabIndex = 17
        '
        'Preview
        '
        Me.Preview.BackColor = System.Drawing.SystemColors.Control
        Me.Preview.BackgroundImage = CType(resources.GetObject("Preview.BackgroundImage"), System.Drawing.Image)
        Me.Preview.Location = New System.Drawing.Point(0, 0)
        Me.Preview.Name = "Preview"
        Me.Preview.Size = New System.Drawing.Size(64, 64)
        Me.Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Preview.TabIndex = 18
        Me.Preview.TabStop = False
        '
        'BtnExport
        '
        Me.BtnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExport.Location = New System.Drawing.Point(456, 2)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(64, 24)
        Me.BtnExport.TabIndex = 19
        Me.BtnExport.Text = "&Exportar"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'BtnImport
        '
        Me.BtnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImport.Location = New System.Drawing.Point(526, 2)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.Size = New System.Drawing.Size(64, 24)
        Me.BtnImport.TabIndex = 20
        Me.BtnImport.Text = "&Importar"
        Me.BtnImport.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Location = New System.Drawing.Point(402, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(48, 24)
        Me.BtnSave.TabIndex = 18
        Me.BtnSave.Text = "&Salvar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnOpen
        '
        Me.BtnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpen.Location = New System.Drawing.Point(348, 2)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(48, 24)
        Me.BtnOpen.TabIndex = 17
        Me.BtnOpen.Text = "&Abrir"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(640, 384)
        Me.Controls.Add(Me.PicPanel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Controls.SetChildIndex(Me.TitleBar, 0)
        Me.Controls.SetChildIndex(Me.PicPanel, 0)
        Me.TitleBar.ResumeLayout(False)
        Me.TitleBar.PerformLayout()
        Me.PicPanel.ResumeLayout(False)
        Me.PicPanel.PerformLayout()
        CType(Me.Preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicPanel As System.Windows.Forms.Panel
    Friend WithEvents Preview As System.Windows.Forms.PictureBox
    Friend WithEvents BtnExport As System.Windows.Forms.Button
    Friend WithEvents BtnImport As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnOpen As System.Windows.Forms.Button

End Class
