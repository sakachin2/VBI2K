<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。 
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonSaveAs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonUndo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRedo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2Kana = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonHelp = New System.Windows.Forms.ToolStripButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemSpecialChar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_DocOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemDictionary = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelCharType = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonSave, Me.ToolStripButtonSaveAs, Me.ToolStripSeparator5, Me.ToolStripButtonPrint, Me.ToolStripSeparator3, Me.ToolStripButtonUndo, Me.ToolStripButtonRedo, Me.ToolStripSeparator6, Me.ToolStripButton2Kana, Me.ToolStripSeparator2, Me.ToolStripButtonHelp})
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Stretch = True
        '
        'ToolStripButtonSave
        '
        Me.ToolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ToolStripButtonSave, "ToolStripButtonSave")
        Me.ToolStripButtonSave.Name = "ToolStripButtonSave"
        '
        'ToolStripButtonSaveAs
        '
        Me.ToolStripButtonSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ToolStripButtonSaveAs, "ToolStripButtonSaveAs")
        Me.ToolStripButtonSaveAs.Name = "ToolStripButtonSaveAs"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        '
        'ToolStripButtonPrint
        '
        Me.ToolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ToolStripButtonPrint, "ToolStripButtonPrint")
        Me.ToolStripButtonPrint.Name = "ToolStripButtonPrint"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'ToolStripButtonUndo
        '
        Me.ToolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ToolStripButtonUndo, "ToolStripButtonUndo")
        Me.ToolStripButtonUndo.Name = "ToolStripButtonUndo"
        '
        'ToolStripButtonRedo
        '
        Me.ToolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ToolStripButtonRedo, "ToolStripButtonRedo")
        Me.ToolStripButtonRedo.Name = "ToolStripButtonRedo"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        '
        'ToolStripButton2Kana
        '
        Me.ToolStripButton2Kana.BackColor = System.Drawing.Color.Yellow
        Me.ToolStripButton2Kana.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.ToolStripButton2Kana, "ToolStripButton2Kana")
        Me.ToolStripButton2Kana.Name = "ToolStripButton2Kana"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'ToolStripButtonHelp
        '
        Me.ToolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ToolStripButtonHelp, "ToolStripButtonHelp")
        Me.ToolStripButtonHelp.Name = "ToolStripButtonHelp"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMCut, Me.CMCopy, Me.CMPaste, Me.CMSelectAll, Me.ToolStripMenuItemSpecialChar, Me.ToolStripMenuItemFind, Me.ToolStripMenuItem_DocOptions, Me.ToolStripMenuItemDictionary})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'CMCut
        '
        Me.CMCut.Name = "CMCut"
        resources.ApplyResources(Me.CMCut, "CMCut")
        '
        'CMCopy
        '
        Me.CMCopy.Name = "CMCopy"
        resources.ApplyResources(Me.CMCopy, "CMCopy")
        '
        'CMPaste
        '
        Me.CMPaste.Name = "CMPaste"
        resources.ApplyResources(Me.CMPaste, "CMPaste")
        '
        'CMSelectAll
        '
        Me.CMSelectAll.Name = "CMSelectAll"
        resources.ApplyResources(Me.CMSelectAll, "CMSelectAll")
        '
        'ToolStripMenuItemSpecialChar
        '
        Me.ToolStripMenuItemSpecialChar.Name = "ToolStripMenuItemSpecialChar"
        resources.ApplyResources(Me.ToolStripMenuItemSpecialChar, "ToolStripMenuItemSpecialChar")
        '
        'ToolStripMenuItemFind
        '
        Me.ToolStripMenuItemFind.Name = "ToolStripMenuItemFind"
        resources.ApplyResources(Me.ToolStripMenuItemFind, "ToolStripMenuItemFind")
        '
        'ToolStripMenuItem_DocOptions
        '
        Me.ToolStripMenuItem_DocOptions.Name = "ToolStripMenuItem_DocOptions"
        resources.ApplyResources(Me.ToolStripMenuItem_DocOptions, "ToolStripMenuItem_DocOptions")
        '
        'ToolStripMenuItemDictionary
        '
        Me.ToolStripMenuItemDictionary.Name = "ToolStripMenuItemDictionary"
        resources.ApplyResources(Me.ToolStripMenuItemDictionary, "ToolStripMenuItemDictionary")
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelCharType, Me.ToolStripStatusLabel1})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripStatusLabelCharType
        '
        Me.ToolStripStatusLabelCharType.Name = "ToolStripStatusLabelCharType"
        resources.ApplyResources(Me.ToolStripStatusLabelCharType, "ToolStripStatusLabelCharType")
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        '
        'Form3
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form3"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2Kana As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonSaveAs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ToolStripButtonHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonRedo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CMCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemSpecialChar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_DocOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemDictionary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabelCharType As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
