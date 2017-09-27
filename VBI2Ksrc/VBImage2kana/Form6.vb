''*CID:''+dateR~:#72                             update#=  174;       ''~7617R~
'************************************************************************************''+7926I~
'************************************************************************************''+7926I~
Imports System.Runtime.InteropServices.Marshal
Public Class Form6 ''~7515R~
    'localization done                                                     ''~7618I~
    '**specialKey Dialog                                                   ''~7523I~

    Private Const COLNO = 3                                            ''~7618I~
    Private Const ZEN_DQ1 = ChrW(&H201C)                                 ''~7515I~
    Private Const ZEN_DQ2 = ChrW(&H201D)
    Private Const ZEN_SQ1 = ChrW(&H2018)
    Private Const ZEN_SQ2 = ChrW(&H2019)
    Private Const ZEN_DAIKAKKO1 = ChrW(&HFF3B)
    Private Const ZEN_DAIKAKKO2 = ChrW(&HFF3D)
    Public callerForm1 As Form1                                        ''~7515R~
    Public callerForm3 As Form3                                        ''~7515I~
    Public swForm1 As Boolean                                          ''~7515I~
    Private cfgKeys As String = My.Settings.CfgSpecialKeys              ''~7515I~
    Private dlgAddSpecialChar As Form7                                 ''~7516I~
    Private LV As ListView                                             ''~7515R~
    ''~7515I~
    Private listDataDefault() As String = { _
    "。", "句点", "Japanese period", _
    "、", "読点", "Japanese comma", _
    "・", "中点", "Punc. of middle point", _
    "「", "第１鍵", "1st parenthesis bnt", _
    "」", "第１鍵", "1st parenthesis bent", _
    "＜", "第２鍵", "2nd parenthesis bent", _
    "＞", "第２鍵", "2nd parenthesis bent", _
    "｢｢", "ふたえ鍵(『)", "Doble parentheses bent", _
    "｣｣", "ふたえ鍵( 』)", "Double parentheses bent", _
    "｛", "第２括弧", "2nd parenthesis", _
    "｝", "第２括弧", "2nd parenthesis", _
    "((", "２重括弧(《)", "Double parentheses", _
    "))", "２重括弧(》)", "Double parentheses", _
    "［", "第１指示符(')", "1st instruction sign", _
    "］", "第１指示符(')", "1st instruction sign", _
    "[_", "第２指示符("")", "2nd instruction sign", _
    "_]", "第２指示符("")", "2nd instruction sign", _
    "[[", "第３指示符(【)", "3rd instruction sign", _
    "]]", "第３指示符(】)", "3rd instruction sign", _
    ZEN_DQ1, "外国語引用符", "Double quotation", _
    ZEN_DQ2, "外国語引用符", "Double quotation", _
    "－", "マイナス(ハイフォン)", "Minus(hiphenation)", _
    "－－", "ダッシュ(２マイナス)", "Dash(2 minus)", _
    "ーー", "棒線(２長音符)", "Horizontal bar", _
    "･･･", "点線(３半カナ中点)", "Dotted line", _
    "<--", "左向き矢印(半角)", "Left arrow", _
    "-->", "右向き矢印(半角)", "Right arrow", _
    "<-->", "両向き矢印(半角)", "Both dir. arrow", _
    "[==]", "空欄記号(半角)", "Sign of blank", _
    "~ﾟ[", "シングルクォート(" & ZEN_SQ1 & ")", "Single quotation", _
    "~ﾟ]", "シングルクォート(" & ZEN_SQ2 & ")", "Single quotation", _
    "||", "詩行符(／)", "Poem line splitter", _
    "~ﾟ||", "二重詩行符(／／)", "Double poem line splitter", _
    "~ﾟﾏﾙ", "伏せ字の○", "Consored word:○", _
    "~ﾟｻﾝｶ", "伏せ字の△", "Consored word:△", _
    "~ﾟｼｶｸ", "伏せ字の□", "Consored word:□", _
    "~ﾟｶｹ", "伏せ字の×", "Consored word:×", _
    "~ﾟｿﾉﾀ", "その他の伏せ字", "Consored word:Other"
   }
#If False Then                                                              ''~7608M~
    "・ま", "伏せ字の○", _                                            ''~7608M~
    "・み", "伏せ字の△", _                                            ''~7608M~
    "・む", "伏せ字の□", _                                            ''~7608M~
    "・め", "伏せ字の×", _                                            ''~7608M~
    "・も", "伏せ字のその他", _                                        ''~7608M~
#End If                                                                ''~7608M~
    '   "【", "第３指示符", _
    '   "】", "第３指示符", _
    '   ZEN_SQ1, "第１指示符(')", _
    '   ZEN_SQ2, "第１指示符(')", _
    '   ZEN_DQ1, "第２指示符(""), _
    '   ZEN_DQ2, "第２指示符("")", _
    '   {"\xf2\xd7", "「第１ストレス符」"}, _
    '   {"\xf2\xb7", "「第２ストレス符」"}, _
    '	"\xf2\xd7フフニ",	"「空欄記号」",
    '   "\xf2\xaf\xf2\xdd",	"「その他の伏せ字」",
    ' "/__", "詩行符 (半角)", _
    ' "＋", "プラス", _
    ' "÷", "ワル", _
    ' "＝", "イコール", _
    '  "‘", "シングルクオート", _
    ' "’", "シングルクオート", _
    ' """", "Quote(u-22)", _
    ' "'", "apostorophy(u-27)", _
    ' "〝", "doublemute(u301d)", _
    ' "〟", "doublemute(u301f)", _
    ' "〞", "doublemute(u301e)", _
    Private ListData() As String                                       ''~7516R~
    ''~7515R~
    '***************************************************************************''~7526I~
    Private Const SB_VERT = 1                                          ''~7526I~
    Private Const WM_VSCROLL = &H115                                   ''~7526I~
    Private Const SB_LINEUP = 0                                 ''~7527M~
    Private Const SB_LINEDOWN = 1                                 ''~7527M~
    Private Const SB_PAGEUP = 2                                 ''~7526I~
    Private Const SB_PAGEDOWN = 3                                 ''~7526R~
    Private Const SB_THUMBPOSITION = 4                                 ''~7526M~
    Private Const SB_THUMBTRACK = 5                                 ''~7527I~
    Private Const SB_TOP = 6                                 ''~7527I~
    Private Const SB_ENDSCROLL = 8                                 ''~7527I~
    '   Private Const SB_BOTTOM        = 7                                 ''~7526I~
    Declare Auto Function GetScrollPos Lib "user32.dll" (hWnd As IntPtr, nBar As Integer) As Integer ''~7526I~
    Declare Auto Function SendMessage Lib "user32.dll" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lparam As Integer) As Integer ''~7526I~
    Public Structure SCROLLINFO                                        ''~7526I~
        Public cbSize, fMask, nMin, nMax, nPage, nPos, nTrackPos As Integer   ''~7526I~
    End Structure                                                      ''~7526I~
    Private vsi As SCROLLINFO                                             ''~7526I~
    Private Const SIF_RANGE = &H1                                       ''~7526I~
    Private Const SIF_PAGE = &H2                                       ''~7526I~
    Private Const SIF_POS = &H4                                       ''~7526I~
    Private Const SIF_TRACKPOS = &H10                                    ''~7526I~
    Private Const SIF_ALL As Integer = SIF_RANGE Or SIF_PAGE Or SIF_POS Or SIF_TRACKPOS ''~7526I~
    Declare Auto Function GetScrollInfo Lib "user32.dll" Alias "GetScrollInfo" (ByVal hWnd As IntPtr, ByVal n As Integer, ByRef lpScrollInfo As SCROLLINFO) As Integer ''~7526I~
    Declare Auto Function SetScrollInfo Lib "user32.dll" Alias "SetScrollInfo" (ByVal hWnd As IntPtr, ByVal n As Integer, ByRef lpScrollInfo As SCROLLINFO, ByVal bool As Boolean) As Integer ''~7526I~
    '***************************************************************************''~7526I~
    Sub New()                                                          ''~7515R~
        initVSI()                                                      ''~7526I~
        initDlg()                                                      ''~7515I~
    End Sub ''~7515I~
    Private Sub initVSI()                                              ''~7526I~
        vsi = New SCROLLINFO()                                           ''~7526I~
        vsi.cbSize = SizeOf(vsi)                                         ''~7526I~
    End Sub                                                            ''~7526I~
    Private Sub initDlg()                                              ''~7515I~
        setLang()   'should set CurrentUICulture before InitializeComponent''~7614I~
        InitializeComponent()                                          ''~7515M~
        Form1.setupTitlebarIcon(Me)                                    ''~7612I~
        Dim width As Integer                                           ''~7515I~
        width = Me.Width - Me.ColumnChar.Width - 40 'avoid horizontal scrollbar''~7515R~
        Me.ColumnDesc.Width = width                                    ''~7515I~
        Me.ColumnSeqNum.Name = "ColumnSeqNum"    'name to applyResouce   ''~7614I~
        Me.ColumnChar.Name = "ColumnChar"                                ''~7614I~
        Me.ColumnDesc.Name = "ColumnDesc"                                ''~7614I~
        dlgAddSpecialChar = New Form7()                                             ''~7515R~''~7516I~
        getCfg()                                                       ''~7515I~
    End Sub                                                            ''~7515I~
    Public Sub showForForm1(Pform As Form1)                            ''~7515I~
        If Form1.MainForm.showDlgSpecialKey(True, Pform) Then 'New() if disposed''~7523I~
            Exit Sub                                                    ''~7523I~
        End If                                                         ''~7523I~
        swForm1 = True                                                   ''~7515I~
        callerForm1 = Pform                                              ''~7515I~
        initListView()                                                 ''~7515M~
        LV.BackColor = callerForm1.TBBES.BackColor                     ''~7523I~
        '       ShowDialog(Pform)                                              ''~7515I~''~7516R~''~7523R~
        Show()    'modeless                                            ''~7516R~''~7523I~
    End Sub                                                            ''~7515I~
    Public Sub showForForm3(Pform As Form3)                            ''~7515I~
        swForm1 = False                                                   ''~7515I~
        If Form1.MainForm.showDlgSpecialKey(False, Pform) Then               ''~7523I~
            Exit Sub                                                    ''~7523I~
        End If                                                         ''~7523I~
        callerForm3 = Pform                                              ''~7515I~
        initListView()                                                 ''~7515I~
        LV.BackColor = callerForm3.TextBox1.BackColor                  ''~7523I~
        '       ShowDialog(Pform)                                              ''~7515I~''~7516R~''~7523R~
        Show()    'moderess                                            ''~7516R~''~7523R~
    End Sub                                                            ''~7515I~
    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click ''~7515I~
        Me.Close()                                                     ''~7515I~
    End Sub 'resize                                                    ''~7515I~
    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click ''~7515I~
        Dim str As String = Nothing                                              ''~7515R~
        If Not getSelectedChar(str) Then                               ''~7515R~
            '           MessageBox.Show("行が選択されていません")                  ''~7515I~''~7618R~
            MessageBox.Show(Rstr.MSG_ERR_SELECT_LINE)                  ''~7618I~
            Exit Sub                                                   ''~7515I~
        End If                                                         ''~7515I~
        If swForm1 Then                                                     ''~7515I~
            callerForm1.undoRedo.setSpecialChar(str)                   ''~7515R~
        Else                                                           ''~7515I~
            callerForm3.undoRedo.setSpecialChar(str)                   ''~7515R~
        End If                                                         ''~7515I~
        '       Me.Close()                                                     ''~7515I~''~7523R~
    End Sub 'resize                                                    ''~7515I~
    Private Sub ButtonHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp.Click ''~7515I~
        showHelp()                                                     ''~7515I~
    End Sub                                                            ''~7515R~
    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click ''~7515I~
        Dim pos As Integer = getSelectedPos()                          ''~7526I~
        If pos < 0 Then                                                       ''~7526M~
            '           MessageBox.Show("追加する位置（その行の前に追加）を選択してください") ''~7526R~''~7618R~
            MessageBox.Show(Rstr.MSG_ERR_ADD_SELECT_LINE)              ''~7618I~
            Exit Sub                                                   ''~7526M~
        End If                                                         ''~7526M~
        Dim rc As Integer = dlgAddSpecialChar.ShowDialog()                              ''~7515I~''~7516R~
        If rc = DialogResult.OK Then                                   ''~7515I~
            Dim str As String = dlgAddSpecialChar.strKey                       ''~7515I~''~7516R~
            Dim cmt As String = dlgAddSpecialChar.strComment                   ''~7515I~''~7516R~
            addSpecialCharKey(str, cmt, pos)                                 ''~7515I~''~7526R~
        End If                                                         ''~7515I~
    End Sub                                                            ''~7515R~
    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click ''~7515I~
        Dim pos As Integer = getSelectedPos()                            ''~7516I~
        Dim elem As Integer = ListData.Length                          ''~7516I~
        If elem < 3 Then                                                      ''~7526I~
            Exit Sub                                                   ''~7526I~
        End If                                                         ''~7526I~
        '       Dim listDataTemp(elem - 2 - 1) As String    'allocation is +1 entry''~7516R~''~7618R~
        Dim listDataTemp(elem - COLNO - 1) As String    'allocation is +1 entry''~7618I~
        If pos < 0 Then                                                       ''~7526I~
            '           MessageBox.Show("削除行が選択されていません")              ''~7526I~''~7618R~
            MessageBox.Show(Rstr.MSG_ERR_SELECT_LINE)                 ''~7618I~
            Exit Sub                                                   ''~7526I~
        End If                                                         ''~7526I~
        If pos > 0 Then                                                       ''~7516I~
            '           Array.Copy(ListData, listDataTemp, pos * 2)                    ''~7516I~''~7618R~
            Array.Copy(ListData, listDataTemp, pos * COLNO)            ''~7618I~
        End If                                                         ''~7516I~
        If pos < elem Then                                                    ''~7516I~
            '           Array.Copy(ListData, pos * 2 + 2, listDataTemp, pos * 2, elem - pos * 2 - 2) ''~7516R~''~7618R~
            Array.Copy(ListData, pos * COLNO + COLNO, listDataTemp, pos * COLNO, elem - pos * COLNO - COLNO) ''~7618I~
        End If                                                         ''~7516I~
        ListData = listDataTemp                                        ''~7516I~
        putCFG()                                                       ''~7516I~
        initListView()                                                 ''~7516I~
    End Sub                                                            ''~7515R~
    Private Sub ButtonUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUp.Click ''~7526I~
        Dim pos As Integer = getSelectedPos()                          ''~7526I~
        Dim elem As Integer = ListData.Length                          ''~7526I~
        If elem < 1 Then                                                      ''~7526I~
            Exit Sub                                                   ''~7526I~
        End If                                                         ''~7526I~
        Dim listDataTemp(elem - 1) As String    'allocation is +1 entry''~7526I~
        If pos <= 0 Then                                                      ''~7526I~
            '           MessageBox.Show("上移動する行を選択してください")          ''~7526I~''~7618R~
            MessageBox.Show(Rstr.MSG_ERR_SELECT_LINE)                 ''~7618I~
            Exit Sub                                                   ''~7526I~
        End If                                                         ''~7526I~
        Array.Copy(ListData, listDataTemp, elem)                       ''~7526R~
        '       Array.Copy(ListData, pos * 2, listDataTemp, (pos - 1) * 2, 2)   ''~7526I~''~7618R~
        Array.Copy(ListData, pos * COLNO, listDataTemp, (pos - 1) * COLNO, COLNO) ''~7618I~
        '       Array.Copy(ListData, (pos - 1) * 2, listDataTemp, pos * 2, 2)   ''~7526I~''~7618R~
        Array.Copy(ListData, (pos - 1) * COLNO, listDataTemp, pos * COLNO, COLNO) ''~7618I~
        ListData = listDataTemp                                        ''~7526I~
        putCFG()                                                       ''~7526I~
        initListView()                                                 ''~7526I~
        setSelectedPos(pos - 1)                                        ''~7526M~''~7527R~
        If pos = getVScrollPos(Nothing) Then                                  ''~7527I~
            LineScroll(-1)                                             ''~7527R~
        End If                                                         ''~7527I~
    End Sub                                                            ''~7526I~
    Private Sub ButtonDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDown.Click ''~7526I~
        Dim pos As Integer = getSelectedPos()                          ''~7526I~
        Dim elem As Integer = ListData.Length                          ''~7526I~
        If elem < 1 Then                                                      ''~7526I~
            Exit Sub                                                   ''~7526I~
        End If                                                         ''~7526I~
        Dim listDataTemp(elem - 1) As String    'allocation is +1 entry''~7526I~
        '       If pos < 0 OrElse pos + 1 = elem / 2 Then                        ''~7526R~''~7618R~
        If pos < 0 OrElse pos + 1 = elem / COLNO Then                  ''~7618I~
            '           MessageBox.Show("下移動する行を選択してください")          ''~7526I~''~7618R~
            MessageBox.Show(Rstr.MSG_ERR_SELECT_LINE)                 ''~7618I~
            Exit Sub                                                   ''~7526I~
        End If                                                         ''~7526I~
        Array.Copy(ListData, listDataTemp, elem)                       ''~7526R~
        '       Array.Copy(ListData, pos * 2, listDataTemp, (pos + 1) * 2, 2)   ''~7526I~''~7618R~
        Array.Copy(ListData, pos * COLNO, listDataTemp, (pos + 1) * COLNO, COLNO) ''~7618I~
        '       Array.Copy(ListData, (pos + 1) * 2, listDataTemp, pos * 2, 2)   ''~7526I~''~7618R~
        Array.Copy(ListData, (pos + 1) * COLNO, listDataTemp, pos * COLNO, COLNO) ''~7618I~
        ListData = listDataTemp                                        ''~7526I~
        putCFG()                                                       ''~7526I~
        initListView()                                                 ''~7527R~
        setSelectedPos(pos + 1)                                        ''~7526M~''~7527R~
        Dim pagesz As Integer                                          ''~7527I~
        If pos + 1 >= getVScrollPos(pagesz) + pagesz Then                         ''~7527I~
            LineScroll(1)                                              ''~7527R~
        End If                                                         ''~7527I~
    End Sub                                                            ''~7526I~
    Private Sub ButtonDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDefault.Click ''~7515I~
        '       If MessageBox.Show("", "既定に戻しますか？", MessageBoxButtons.YesNo) = DialogResult.No Then ''~7608I~''~7618R~
        If MessageBox.Show(Rstr.MSG_CONFIRM_RESTORE_DEFAULT, Me.Text, MessageBoxButtons.YesNo) = DialogResult.No Then ''~7618I~
            Exit Sub                                                   ''~7608I~
        End If                                                         ''~7608I~
        ListData = listDataDefault                                           ''~7515I~''~7516R~
        putCFG()                                                       ''~7516I~
        initListView()                                                 ''~7516I~
    End Sub                                                            ''~7515R~
    Private Sub showHelp()                                             ''~7515I~
        Dim txt As String                                              ''~7515I~
        If FormOptions.swLangEN Then                                   ''~7614I~
            txt = My.Resources.help_form6E                             ''~7614I~
        Else                                                           ''~7614I~
            txt = My.Resources.help_form6                                  ''~7515I~''~7614R~
        End If                                                         ''~7614I~
        MessageBox.Show(txt, Me.Text)                                           ''~7515I~''~7614R~
    End Sub                                                            ''~7515I~
    Private Sub initListView()                                         ''~7515R~
        Dim vpos As Integer                                            ''~7526I~
        LV = ListViewSpecialChar                                        ''~7515R~
        vpos = getVScrollPos(Nothing)                                         ''~7526I~''~7527R~
        fillColumn()                                                   ''~7515M~''~7527R~
        setVScrollPos(vpos)                                            ''~7526I~
    End Sub                                                            ''~7515I~
    Private Function getVScrollPos(ByRef Pppagesz As Integer) As Integer                        ''~7526I~''~7527R~
        '       Return GetScrollPos(LV.Handle, SB_VERT)                        ''~7526I~''~7527R~
        vsi.fMask = SIF_ALL                                              ''~7526I~
        GetScrollInfo(LV.Handle, SB_VERT, vsi)                           ''~7526I~
        If Not IsNothing(Pppagesz) Then                                     ''~7527I~
            Pppagesz = vsi.nPage                                             ''~7527I~
        End If                                                         ''~7527I~
        Return vsi.nPos                                                ''~7526I~
    End Function                                                       ''~7526I~
    Private Sub setVScrollPos(Ppos As Integer)                         ''~7526I~
#If True Then                                                         ''~7526R~''~7527R~
        Dim pos As Integer                                             ''~7527M~
#If False Then                                                              ''~7527I~
        pos = (Ppos << 16) Or SB_THUMBPOSITION                           ''~7526R~''~7527R~
        '        pos = (Ppos << 16) Or SB_THUMBTRACK                            ''~7527I~
        SendMessage(LV.Handle, WM_VSCROLL, pos, 0)              ''~7526R~''~7527R~
#Else                                                                  ''~7527I~
        pos = SB_TOP                                                   ''~7527M~
        SendMessage(LV.Handle, WM_VSCROLL, pos, 0)                     ''~7527M~
        '       pos =  SB_BOTTOM                                               ''~7526R~
        '       pos =  SB_PAGEDOWN                                             ''~7526I~''~7527R~
        pos = SB_LINEDOWN                                             ''~7527R~
        For ii As Integer = 0 To Ppos - 1                                 ''~7527R~
            SendMessage(LV.Handle, WM_VSCROLL, pos, 0)                 ''~7527R~
        Next                                                           ''~7527R~
        '       pos = SB_ENDSCROLL                                             ''~7527R~
        '       SendMessage(LV.Handle, WM_VSCROLL, pos, 0)                     ''~7527R~
#End If                                                                ''~7527I~
#Else                                                                  ''~7526I~
        vsi.fMask = SIF_POS                                            ''~7527I~
        vsi.nPos = Ppos                                                ''~7527I~
        Dim newpos As Integer = SetScrollInfo(LV.Handle, SB_VERT, vsi, True) ''~7527I~
'       LV.Invalidate()                                                ''~7527R~
#End If                                                                ''~7526I~
    End Sub                                                            ''~7526I~
    Private Sub LineScroll(Pctr As Integer)                            ''~7527R~
        Dim pos, ctr As Integer                                         ''~7527I~
        If Pctr < 0 Then                                                      ''~7527I~
            pos = SB_LINEUP                                            ''~7527I~
            ctr = -Pctr                                                  ''~7527I~
        Else                                                           ''~7527I~
            pos = SB_LINEDOWN                                          ''~7527I~
            ctr = Pctr                                                   ''~7527I~
        End If                                                         ''~7527I~
        For ii As Integer = 0 To ctr - 1                                 ''~7527I~
            SendMessage(LV.Handle, WM_VSCROLL, pos, 0)                 ''~7527I~
        Next                                                           ''~7527I~
    End Sub                                                            ''~7527I~
    Private Sub fillColumn()
        LV.Items.Clear()    ' clear() also delete column               ''~7516R~
        '       For ii As Integer = 0 To ListData.Length / 2 - 1                 ''~7516R~''~7618R~
        For ii As Integer = 0 To ListData.Length / COLNO - 1           ''~7618I~
            LV.Items.Add((ii + 1).ToString(), 0)                         ''~7525R~
            LV.Items(ii).SubItems.Add(ListData(ii * COLNO))            ''~7525I~''~7618R~
            If FormOptions.swLangEN AndAlso ListData(ii * COLNO + 2).CompareTo("") <> 0 Then ''~7618I~
                LV.Items(ii).SubItems.Add(ListData(ii * COLNO + 2))    ''~7618I~
            Else                                                       ''~7618I~
                LV.Items(ii).SubItems.Add(ListData(ii * COLNO + 1))            ''~7525I~''~7618R~
            End If                                                     ''~7618I~
        Next                                                           ''~7515I~
    End Sub                                                            ''~7515I~
    Private Function getSelectedChar(ByRef Ppstr As String) As Boolean ''~7515R~
        If LV.SelectedItems.Count > 0 Then                                ''~7515I~
            Ppstr = LV.SelectedItems(0).SubItems(1).Text               ''~7525I~
            Return True                                                ''~7515I~
        End If                                                         ''~7515I~
        Return False                                                   ''~7515I~
    End Function                                                            ''~7515I~
    Private Function getSelectedPos() As Integer                       ''~7516I~
        Dim pos As Integer                                             ''~7516I~
        If LV.SelectedItems.Count > 0 Then                             ''~7516I~
            pos = LV.SelectedIndices(0)                                 ''~7516I~
        Else                                                           ''~7516I~
            pos = -1                                                      ''~7516I~''~7526R~
        End If                                                         ''~7516I~
        Return pos                                                     ''~7516I~
    End Function                                                       ''~7516I~
    Private Sub setSelectedPos(Ppos As Integer)
        If Ppos < 0 OrElse Ppos >= LV.Items.Count Then                        ''~7526I~
            Exit Sub                                                   ''~7526I~
        End If                                                         ''~7526I~
        '       LV.Items(Ppos).Focused = True                                  ''~7526R~
        LV.Focus()                                                     ''~7526I~
        LV.Items(Ppos).Selected = True                                 ''~7526I~
        '       LV.Select()                                                    ''~7526R~
    End Sub                                                            ''~7526I~
    Public Function getSpecialStr(Pindex As Integer) As String         ''~7525I~
        'By Alt+Num key                                                    ''~7525I~
        '       If Pindex >= ListData.Length / 2 Then                                   ''~7525I~''~7618R~
        If Pindex >= ListData.Length / COLNO Then                      ''~7618I~
            Return Nothing                                             ''~7525I~
        End If                                                         ''~7525I~
        '       Return ListData(Pindex * 2)                                      ''~7525I~''~7618R~
        Return ListData(Pindex * COLNO)                                ''~7618I~
    End Function                                                       ''~7525I~
    Private Sub addSpecialCharKey(Pkey As String, Pcmt As String, Ppos As Integer)       ''~7515I~''~7526R~
        Dim elem As Integer = ListData.Length                          ''~7516R~
        '       Dim listDataTemp(elem + 2 - 1) As String    'allocated +1 entry    ''~7516R~''~7618R~
        Dim listDataTemp(elem + COLNO - 1) As String    'allocated +1 entry''~7618I~
        Dim pos As Integer = Ppos                                        ''~7526I~
        If pos > 0 Then                                                       ''~7516I~''~7526R~
            '           Array.Copy(ListData, listDataTemp, pos * 2)                    ''~7516I~''~7618R~
            Array.Copy(ListData, listDataTemp, pos * COLNO)            ''~7618I~
        End If                                                         ''~7516I~
        '       listDataTemp(pos * 2) = Pkey                                         ''~7515I~''~7516R~''~7618R~
        listDataTemp(pos * COLNO) = Pkey                               ''~7618I~
        '       listDataTemp(pos * 2 + 1) = Pcmt                                         ''~7515I~''~7516R~''~7618R~
        listDataTemp(pos * COLNO + 1) = Pcmt                           ''~7618I~
        listDataTemp(pos * COLNO + 2) = Pcmt                           ''~7618I~
        If pos < elem Then                                                    ''~7516I~
            '           Array.Copy(ListData, pos * 2, listDataTemp, pos * 2 + 2, elem - pos * 2) ''~7516R~''~7618R~
            Array.Copy(ListData, pos * COLNO, listDataTemp, pos * COLNO + COLNO, elem - pos * COLNO) ''~7618I~
        End If                                                         ''~7516I~
        ListData = listDataTemp                                       ''~7515I~''~7516R~
        putCFG()                                                       ''~7515I~
        initListView()                                                 ''~7516I~
    End Sub                                                       ''~7515I~
    Private Sub putCFG()                                               ''~7515I~
        cfgKeys = String.Join(";", ListData)                          ''~7515R~''~7516R~
        My.Settings.CfgSpecialKeys = cfgKeys                              ''~7515I~
    End Sub                                                       ''~7515I~
    Private Sub getCfg()                                               ''~7515I~
        If cfgKeys.CompareTo("") = 0 Then                                       ''~7515I~
            ListData = listDataDefault                                ''~7515I~''~7516R~
        Else                                                           ''~7515I~
            ListData = cfgKeys.Split(";"c)             ''~7515R~     ''~7516R~
        End If                                                         ''~7515I~
    End Sub                                                       ''~7515I~

    Private Sub ListViewSpecialChar_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListViewSpecialChar.SelectedIndexChanged

    End Sub
    Private Sub setLang()                                              ''~7614I~
        FormOptions.setLang()                                          ''~7614I~
    End Sub                                                            ''~7614I~
End Class