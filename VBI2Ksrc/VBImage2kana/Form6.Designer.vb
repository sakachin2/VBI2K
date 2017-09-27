<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.PanelBottons = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelButtons1 = New System.Windows.Forms.Panel()
        Me.ButtonDefault = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonUp = New System.Windows.Forms.Button()
        Me.ButtonDown = New System.Windows.Forms.Button()
        Me.PanelButtons2 = New System.Windows.Forms.Panel()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ListViewSpecialChar = New System.Windows.Forms.ListView()
        Me.ColumnSeqNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnChar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelBottons.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelButtons1.SuspendLayout()
        Me.PanelButtons2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBottons
        '
        resources.ApplyResources(Me.PanelBottons, "PanelBottons")
        Me.PanelBottons.Controls.Add(Me.Panel4)
        Me.PanelBottons.Controls.Add(Me.PanelButtons2)
        Me.PanelBottons.Name = "PanelBottons"
        '
        'Panel4
        '
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Controls.Add(Me.PanelButtons1)
        Me.Panel4.Name = "Panel4"
        '
        'PanelButtons1
        '
        resources.ApplyResources(Me.PanelButtons1, "PanelButtons1")
        Me.PanelButtons1.Controls.Add(Me.ButtonDefault)
        Me.PanelButtons1.Controls.Add(Me.ButtonAdd)
        Me.PanelButtons1.Controls.Add(Me.ButtonDelete)
        Me.PanelButtons1.Controls.Add(Me.ButtonUp)
        Me.PanelButtons1.Controls.Add(Me.ButtonDown)
        Me.PanelButtons1.Name = "PanelButtons1"
        '
        'ButtonDefault
        '
        resources.ApplyResources(Me.ButtonDefault, "ButtonDefault")
        Me.ButtonDefault.Name = "ButtonDefault"
        Me.ButtonDefault.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        resources.ApplyResources(Me.ButtonAdd, "ButtonAdd")
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        resources.ApplyResources(Me.ButtonDelete, "ButtonDelete")
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonUp
        '
        resources.ApplyResources(Me.ButtonUp, "ButtonUp")
        Me.ButtonUp.Name = "ButtonUp"
        Me.ButtonUp.UseVisualStyleBackColor = True
        '
        'ButtonDown
        '
        resources.ApplyResources(Me.ButtonDown, "ButtonDown")
        Me.ButtonDown.Name = "ButtonDown"
        Me.ButtonDown.UseVisualStyleBackColor = True
        '
        'PanelButtons2
        '
        resources.ApplyResources(Me.PanelButtons2, "PanelButtons2")
        Me.PanelButtons2.Controls.Add(Me.ButtonHelp)
        Me.PanelButtons2.Controls.Add(Me.ButtonOK)
        Me.PanelButtons2.Controls.Add(Me.ButtonCancel)
        Me.PanelButtons2.Name = "PanelButtons2"
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
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        resources.ApplyResources(Me.ButtonOK, "ButtonOK")
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ListViewSpecialChar
        '
        resources.ApplyResources(Me.ListViewSpecialChar, "ListViewSpecialChar")
        Me.ListViewSpecialChar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnSeqNum, Me.ColumnChar, Me.ColumnDesc})
        Me.ListViewSpecialChar.FullRowSelect = True
        Me.ListViewSpecialChar.GridLines = True
        Me.ListViewSpecialChar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewSpecialChar.HideSelection = False
        Me.ListViewSpecialChar.MultiSelect = False
        Me.ListViewSpecialChar.Name = "ListViewSpecialChar"
        Me.ListViewSpecialChar.UseCompatibleStateImageBehavior = False
        Me.ListViewSpecialChar.View = System.Windows.Forms.View.Details
        '
        'ColumnSeqNum
        '
        resources.ApplyResources(Me.ColumnSeqNum, "ColumnSeqNum")
        '
        'ColumnChar
        '
        resources.ApplyResources(Me.ColumnChar, "ColumnChar")
        '
        'ColumnDesc
        '
        resources.ApplyResources(Me.ColumnDesc, "ColumnDesc")
        '
        'Form6
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = Global.WindowsApplication1.My.MySettings.Default.CFG_Form6ClientSize
        Me.Controls.Add(Me.ListViewSpecialChar)
        Me.Controls.Add(Me.PanelBottons)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ClientSize", Global.WindowsApplication1.My.MySettings.Default, "CFG_Form6ClientSize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form6"
        Me.PanelBottons.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.PanelButtons1.ResumeLayout(False)
        Me.PanelButtons2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBottons As System.Windows.Forms.Panel
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonHelp As System.Windows.Forms.Button
    Friend WithEvents ListViewSpecialChar As System.Windows.Forms.ListView
    Friend WithEvents ColumnChar As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents ButtonDefault As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents PanelButtons1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents PanelButtons2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ColumnSeqNum As System.Windows.Forms.ColumnHeader
    Friend WithEvents ButtonDown As System.Windows.Forms.Button
    Friend WithEvents ButtonUp As System.Windows.Forms.Button
End Class
