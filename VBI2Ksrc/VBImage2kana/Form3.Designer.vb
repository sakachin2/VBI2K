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
        Me.ContextMenuWordSelection = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemSpecialChar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_DocOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemDictionary = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemWords = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelCharType = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuWordSelection.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonSave, Me.ToolStripButtonSaveAs, Me.ToolStripSeparator5, Me.ToolStripButtonPrint, Me.ToolStripSeparator3, Me.ToolStripButtonUndo, Me.ToolStripButtonRedo, Me.ToolStripSeparator6, Me.ToolStripButton2Kana, Me.ToolStripSeparator2, Me.ToolStripButtonHelp})
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Stretch = True
        '
        'ToolStripButtonSave
        '
        resources.ApplyResources(Me.ToolStripButtonSave, "ToolStripButtonSave")
        Me.ToolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonSave.Name = "ToolStripButtonSave"
        '
        'ToolStripButtonSaveAs
        '
        resources.ApplyResources(Me.ToolStripButtonSaveAs, "ToolStripButtonSaveAs")
        Me.ToolStripButtonSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonSaveAs.Name = "ToolStripButtonSaveAs"
        '
        'ToolStripSeparator5
        '
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        '
        'ToolStripButtonPrint
        '
        resources.ApplyResources(Me.ToolStripButtonPrint, "ToolStripButtonPrint")
        Me.ToolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPrint.Name = "ToolStripButtonPrint"
        '
        'ToolStripSeparator3
        '
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        '
        'ToolStripButtonUndo
        '
        resources.ApplyResources(Me.ToolStripButtonUndo, "ToolStripButtonUndo")
        Me.ToolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonUndo.Name = "ToolStripButtonUndo"
        '
        'ToolStripButtonRedo
        '
        resources.ApplyResources(Me.ToolStripButtonRedo, "ToolStripButtonRedo")
        Me.ToolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRedo.Name = "ToolStripButtonRedo"
        '
        'ToolStripSeparator6
        '
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        '
        'ToolStripButton2Kana
        '
        resources.ApplyResources(Me.ToolStripButton2Kana, "ToolStripButton2Kana")
        Me.ToolStripButton2Kana.BackColor = System.Drawing.Color.Yellow
        Me.ToolStripButton2Kana.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2Kana.Name = "ToolStripButton2Kana"
        '
        'ToolStripSeparator2
        '
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        '
        'ToolStripButtonHelp
        '
        resources.ApplyResources(Me.ToolStripButtonHelp, "ToolStripButtonHelp")
        Me.ToolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonHelp.Name = "ToolStripButtonHelp"
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuWordSelection
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Name = "TextBox1"
        '
        'ContextMenuWordSelection
        '
        resources.ApplyResources(Me.ContextMenuWordSelection, "ContextMenuWordSelection")
        Me.ContextMenuWordSelection.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMCut, Me.CMCopy, Me.CMPaste, Me.CMSelectAll, Me.ToolStripMenuItemSpecialChar, Me.ToolStripMenuItemFind, Me.ToolStripMenuItem_DocOptions, Me.ToolStripMenuItemDictionary, Me.ToolStripMenuItemWords})
        Me.ContextMenuWordSelection.Name = "ContextMenuStrip1"
        '
        'CMCut
        '
        resources.ApplyResources(Me.CMCut, "CMCut")
        Me.CMCut.Name = "CMCut"
        '
        'CMCopy
        '
        resources.ApplyResources(Me.CMCopy, "CMCopy")
        Me.CMCopy.Name = "CMCopy"
        '
        'CMPaste
        '
        resources.ApplyResources(Me.CMPaste, "CMPaste")
        Me.CMPaste.Name = "CMPaste"
        '
        'CMSelectAll
        '
        resources.ApplyResources(Me.CMSelectAll, "CMSelectAll")
        Me.CMSelectAll.Name = "CMSelectAll"
        '
        'ToolStripMenuItemSpecialChar
        '
        resources.ApplyResources(Me.ToolStripMenuItemSpecialChar, "ToolStripMenuItemSpecialChar")
        Me.ToolStripMenuItemSpecialChar.Name = "ToolStripMenuItemSpecialChar"
        '
        'ToolStripMenuItemFind
        '
        resources.ApplyResources(Me.ToolStripMenuItemFind, "ToolStripMenuItemFind")
        Me.ToolStripMenuItemFind.Name = "ToolStripMenuItemFind"
        '
        'ToolStripMenuItem_DocOptions
        '
        resources.ApplyResources(Me.ToolStripMenuItem_DocOptions, "ToolStripMenuItem_DocOptions")
        Me.ToolStripMenuItem_DocOptions.Name = "ToolStripMenuItem_DocOptions"
        '
        'ToolStripMenuItemDictionary
        '
        resources.ApplyResources(Me.ToolStripMenuItemDictionary, "ToolStripMenuItemDictionary")
        Me.ToolStripMenuItemDictionary.Name = "ToolStripMenuItemDictionary"
        '
        'ToolStripMenuItemWords
        '
        resources.ApplyResources(Me.ToolStripMenuItemWords, "ToolStripMenuItemWords")
        Me.ToolStripMenuItemWords.Name = "ToolStripMenuItemWords"
        '
        'SaveFileDialog1
        '
        resources.ApplyResources(Me.SaveFileDialog1, "SaveFileDialog1")
        '
        'ToolStripSeparator4
        '
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        '
        'BackgroundWorker1
        '
        '
        'StatusStrip1
        '
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelCharType, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripStatusLabelCharType
        '
        resources.ApplyResources(Me.ToolStripStatusLabelCharType, "ToolStripStatusLabelCharType")
        Me.ToolStripStatusLabelCharType.Name = "ToolStripStatusLabelCharType"
        '
        'ToolStripStatusLabel1
        '
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
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
        Me.ContextMenuWordSelection.ResumeLayout(False)
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
    Friend WithEvents ContextMenuWordSelection As System.Windows.Forms.ContextMenuStrip
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
    Friend WithEvents ToolStripMenuItemWords As System.Windows.Forms.ToolStripMenuItem
End Class
