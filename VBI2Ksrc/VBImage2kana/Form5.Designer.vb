﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOptions))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ButtonPrintFont = New System.Windows.Forms.Button()
        Me.ButtonScrFont = New System.Windows.Forms.Button()
        Me.TextBoxPrintFontname = New System.Windows.Forms.TextBox()
        Me.TextBoxScrFontName = New System.Windows.Forms.TextBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBoxLang = New System.Windows.Forms.GroupBox()
        Me.RBLangEN = New System.Windows.Forms.RadioButton()
        Me.RBLangJP = New System.Windows.Forms.RadioButton()
        Me.RBLangDefault = New System.Windows.Forms.RadioButton()
        Me.RGLang = New System.Windows.Forms.Panel()
        Me.CheckBoxWinBES99 = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxKeySpecialChar = New System.Windows.Forms.TextBox()
        Me.TextBoxKeySmallKana = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxLabelSpecialChar = New System.Windows.Forms.TextBox()
        Me.CheckBoxPrintFont = New System.Windows.Forms.CheckBox()
        Me.TextBoxLabelSmallKey = New System.Windows.Forms.TextBox()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBoxLang.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2
        '
        resources.ApplyResources(Me.SplitContainer2, "SplitContainer2")
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ButtonPrintFont)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ButtonScrFont)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TextBoxPrintFontname)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TextBoxScrFontName)
        '
        'ButtonPrintFont
        '
        resources.ApplyResources(Me.ButtonPrintFont, "ButtonPrintFont")
        Me.ButtonPrintFont.Name = "ButtonPrintFont"
        Me.ButtonPrintFont.UseVisualStyleBackColor = True
        '
        'ButtonScrFont
        '
        resources.ApplyResources(Me.ButtonScrFont, "ButtonScrFont")
        Me.ButtonScrFont.Name = "ButtonScrFont"
        Me.ButtonScrFont.UseVisualStyleBackColor = True
        '
        'TextBoxPrintFontname
        '
        resources.ApplyResources(Me.TextBoxPrintFontname, "TextBoxPrintFontname")
        Me.TextBoxPrintFontname.Name = "TextBoxPrintFontname"
        Me.TextBoxPrintFontname.ReadOnly = True
        '
        'TextBoxScrFontName
        '
        resources.ApplyResources(Me.TextBoxScrFontName, "TextBoxScrFontName")
        Me.TextBoxScrFontName.Name = "TextBoxScrFontName"
        Me.TextBoxScrFontName.ReadOnly = True
        '
        'SplitContainer3
        '
        resources.ApplyResources(Me.SplitContainer3, "SplitContainer3")
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBoxLang)
        Me.SplitContainer3.Panel1.Controls.Add(Me.RGLang)
        Me.SplitContainer3.Panel1.Controls.Add(Me.CheckBoxWinBES99)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.ButtonHelp)
        Me.SplitContainer3.Panel2.Controls.Add(Me.ButtonCancel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.ButtonOK)
        '
        'GroupBoxLang
        '
        Me.GroupBoxLang.Controls.Add(Me.RBLangEN)
        Me.GroupBoxLang.Controls.Add(Me.RBLangJP)
        Me.GroupBoxLang.Controls.Add(Me.RBLangDefault)
        resources.ApplyResources(Me.GroupBoxLang, "GroupBoxLang")
        Me.GroupBoxLang.Name = "GroupBoxLang"
        Me.GroupBoxLang.TabStop = False
        '
        'RBLangEN
        '
        resources.ApplyResources(Me.RBLangEN, "RBLangEN")
        Me.RBLangEN.Name = "RBLangEN"
        Me.RBLangEN.TabStop = True
        Me.RBLangEN.UseVisualStyleBackColor = True
        '
        'RBLangJP
        '
        resources.ApplyResources(Me.RBLangJP, "RBLangJP")
        Me.RBLangJP.Name = "RBLangJP"
        Me.RBLangJP.TabStop = True
        Me.RBLangJP.UseVisualStyleBackColor = True
        '
        'RBLangDefault
        '
        resources.ApplyResources(Me.RBLangDefault, "RBLangDefault")
        Me.RBLangDefault.Name = "RBLangDefault"
        Me.RBLangDefault.TabStop = True
        Me.RBLangDefault.UseVisualStyleBackColor = True
        '
        'RGLang
        '
        resources.ApplyResources(Me.RGLang, "RGLang")
        Me.RGLang.Name = "RGLang"
        '
        'CheckBoxWinBES99
        '
        resources.ApplyResources(Me.CheckBoxWinBES99, "CheckBoxWinBES99")
        Me.CheckBoxWinBES99.Name = "CheckBoxWinBES99"
        Me.CheckBoxWinBES99.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxKeySpecialChar)
        Me.Panel1.Controls.Add(Me.TextBoxKeySmallKana)
        Me.Panel1.Controls.Add(Me.Panel2)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'TextBoxKeySpecialChar
        '
        resources.ApplyResources(Me.TextBoxKeySpecialChar, "TextBoxKeySpecialChar")
        Me.TextBoxKeySpecialChar.Name = "TextBoxKeySpecialChar"
        '
        'TextBoxKeySmallKana
        '
        resources.ApplyResources(Me.TextBoxKeySmallKana, "TextBoxKeySmallKana")
        Me.TextBoxKeySmallKana.Name = "TextBoxKeySmallKana"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBoxLabelSpecialChar)
        Me.Panel2.Controls.Add(Me.CheckBoxPrintFont)
        Me.Panel2.Controls.Add(Me.TextBoxLabelSmallKey)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'TextBoxLabelSpecialChar
        '
        Me.TextBoxLabelSpecialChar.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxLabelSpecialChar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        resources.ApplyResources(Me.TextBoxLabelSpecialChar, "TextBoxLabelSpecialChar")
        Me.TextBoxLabelSpecialChar.Name = "TextBoxLabelSpecialChar"
        '
        'CheckBoxPrintFont
        '
        resources.ApplyResources(Me.CheckBoxPrintFont, "CheckBoxPrintFont")
        Me.CheckBoxPrintFont.Name = "CheckBoxPrintFont"
        Me.CheckBoxPrintFont.UseVisualStyleBackColor = True
        '
        'TextBoxLabelSmallKey
        '
        Me.TextBoxLabelSmallKey.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        resources.ApplyResources(Me.TextBoxLabelSmallKey, "TextBoxLabelSmallKey")
        Me.TextBoxLabelSmallKey.Name = "TextBoxLabelSmallKey"
        Me.TextBoxLabelSmallKey.ReadOnly = True
        '
        'ButtonHelp
        '
        resources.ApplyResources(Me.ButtonHelp, "ButtonHelp")
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.ButtonCancel, "ButtonCancel")
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        resources.ApplyResources(Me.ButtonOK, "ButtonOK")
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'FormOptions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormOptions"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBoxLang.ResumeLayout(False)
        Me.GroupBoxLang.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBoxScrFontName As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ButtonPrintFont As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ButtonHelp As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxKeySmallKana As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxLabelSmallKey As System.Windows.Forms.TextBox
    Friend WithEvents ButtonScrFont As System.Windows.Forms.Button
    Friend WithEvents TextBoxPrintFontname As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxPrintFont As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxKeySpecialChar As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLabelSpecialChar As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxWinBES99 As System.Windows.Forms.CheckBox
    Friend WithEvents RGLang As System.Windows.Forms.Panel
    Friend WithEvents GroupBoxLang As System.Windows.Forms.GroupBox
    Friend WithEvents RBLangEN As System.Windows.Forms.RadioButton
    Friend WithEvents RBLangJP As System.Windows.Forms.RadioButton
    Friend WithEvents RBLangDefault As System.Windows.Forms.RadioButton
End Class
