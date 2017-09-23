<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxKanji = New System.Windows.Forms.TextBox()
        Me.TextBoxKana = New System.Windows.Forms.TextBox()
        Me.PanelDictionary = New System.Windows.Forms.Panel()
        Me.PanelButtons.SuspendLayout()
        Me.PanelDictionary.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelButtons
        '
        Me.PanelButtons.Controls.Add(Me.ButtonCancel)
        Me.PanelButtons.Controls.Add(Me.ButtonHelp)
        Me.PanelButtons.Controls.Add(Me.ButtonOK)
        resources.ApplyResources(Me.PanelButtons, "PanelButtons")
        Me.PanelButtons.Name = "PanelButtons"
        '
        'ButtonCancel
        '
        resources.ApplyResources(Me.ButtonCancel, "ButtonCancel")
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonHelp
        '
        resources.ApplyResources(Me.ButtonHelp, "ButtonHelp")
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        resources.ApplyResources(Me.ButtonOK, "ButtonOK")
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TextBoxKanji
        '
        resources.ApplyResources(Me.TextBoxKanji, "TextBoxKanji")
        Me.TextBoxKanji.Name = "TextBoxKanji"
        '
        'TextBoxKana
        '
        resources.ApplyResources(Me.TextBoxKana, "TextBoxKana")
        Me.TextBoxKana.Name = "TextBoxKana"
        '
        'PanelDictionary
        '
        Me.PanelDictionary.Controls.Add(Me.Label1)
        Me.PanelDictionary.Controls.Add(Me.TextBoxKana)
        Me.PanelDictionary.Controls.Add(Me.Label2)
        Me.PanelDictionary.Controls.Add(Me.TextBoxKanji)
        resources.ApplyResources(Me.PanelDictionary, "PanelDictionary")
        Me.PanelDictionary.Name = "PanelDictionary"
        '
        'Form10
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelDictionary)
        Me.Controls.Add(Me.PanelButtons)
        Me.Name = "Form10"
        Me.PanelButtons.ResumeLayout(False)
        Me.PanelDictionary.ResumeLayout(False)
        Me.PanelDictionary.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelButtons As System.Windows.Forms.Panel
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonHelp As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKanji As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKana As System.Windows.Forms.TextBox
    Friend WithEvents PanelDictionary As System.Windows.Forms.Panel
End Class
