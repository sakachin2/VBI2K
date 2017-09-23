<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.ListViewDictionary = New System.Windows.Forms.ListView()
        Me.ColumnEnable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnKanji = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnKana = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelButton1 = New System.Windows.Forms.Panel()
        Me.ButtonDown = New System.Windows.Forms.Button()
        Me.ButtonSort = New System.Windows.Forms.Button()
        Me.ButtonUp = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.PanelButtonAll = New System.Windows.Forms.Panel()
        Me.PanelButton2 = New System.Windows.Forms.Panel()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.PanelButton1.SuspendLayout()
        Me.PanelButtonAll.SuspendLayout()
        Me.PanelButton2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewDictionary
        '
        Me.ListViewDictionary.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnEnable, Me.ColumnKanji, Me.ColumnKana})
        resources.ApplyResources(Me.ListViewDictionary, "ListViewDictionary")
        Me.ListViewDictionary.FullRowSelect = True
        Me.ListViewDictionary.GridLines = True
        Me.ListViewDictionary.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewDictionary.HideSelection = False
        Me.ListViewDictionary.MultiSelect = False
        Me.ListViewDictionary.Name = "ListViewDictionary"
        Me.ListViewDictionary.UseCompatibleStateImageBehavior = False
        Me.ListViewDictionary.View = System.Windows.Forms.View.Details
        '
        'ColumnEnable
        '
        resources.ApplyResources(Me.ColumnEnable, "ColumnEnable")
        '
        'ColumnKanji
        '
        resources.ApplyResources(Me.ColumnKanji, "ColumnKanji")
        '
        'ColumnKana
        '
        resources.ApplyResources(Me.ColumnKana, "ColumnKana")
        '
        'PanelButton1
        '
        Me.PanelButton1.Controls.Add(Me.ButtonDown)
        Me.PanelButton1.Controls.Add(Me.ButtonSort)
        Me.PanelButton1.Controls.Add(Me.ButtonUp)
        Me.PanelButton1.Controls.Add(Me.ButtonDelete)
        Me.PanelButton1.Controls.Add(Me.ButtonAdd)
        resources.ApplyResources(Me.PanelButton1, "PanelButton1")
        Me.PanelButton1.Name = "PanelButton1"
        '
        'ButtonDown
        '
        resources.ApplyResources(Me.ButtonDown, "ButtonDown")
        Me.ButtonDown.Name = "ButtonDown"
        Me.ButtonDown.UseVisualStyleBackColor = True
        '
        'ButtonSort
        '
        resources.ApplyResources(Me.ButtonSort, "ButtonSort")
        Me.ButtonSort.Name = "ButtonSort"
        Me.ButtonSort.UseVisualStyleBackColor = True
        '
        'ButtonUp
        '
        resources.ApplyResources(Me.ButtonUp, "ButtonUp")
        Me.ButtonUp.Name = "ButtonUp"
        Me.ButtonUp.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        resources.ApplyResources(Me.ButtonDelete, "ButtonDelete")
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        resources.ApplyResources(Me.ButtonAdd, "ButtonAdd")
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'PanelButtonAll
        '
        Me.PanelButtonAll.Controls.Add(Me.PanelButton2)
        Me.PanelButtonAll.Controls.Add(Me.PanelButton1)
        resources.ApplyResources(Me.PanelButtonAll, "PanelButtonAll")
        Me.PanelButtonAll.Name = "PanelButtonAll"
        '
        'PanelButton2
        '
        Me.PanelButton2.Controls.Add(Me.ButtonHelp)
        Me.PanelButton2.Controls.Add(Me.ButtonCancel)
        Me.PanelButton2.Controls.Add(Me.ButtonOK)
        resources.ApplyResources(Me.PanelButton2, "PanelButton2")
        Me.PanelButton2.Name = "PanelButton2"
        '
        'ButtonHelp
        '
        resources.ApplyResources(Me.ButtonHelp, "ButtonHelp")
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
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
        'Form9
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelButtonAll)
        Me.Controls.Add(Me.ListViewDictionary)
        Me.Name = "Form9"
        Me.PanelButton1.ResumeLayout(False)
        Me.PanelButtonAll.ResumeLayout(False)
        Me.PanelButton2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListViewDictionary As System.Windows.Forms.ListView
    Friend WithEvents PanelButton1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonSort As System.Windows.Forms.Button
    Friend WithEvents ButtonDown As System.Windows.Forms.Button
    Friend WithEvents ButtonUp As System.Windows.Forms.Button
    Friend WithEvents ColumnEnable As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnKanji As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnKana As System.Windows.Forms.ColumnHeader
    Friend WithEvents PanelButtonAll As System.Windows.Forms.Panel
    Friend WithEvents PanelButton2 As System.Windows.Forms.Panel
    Friend WithEvents ButtonHelp As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
End Class
