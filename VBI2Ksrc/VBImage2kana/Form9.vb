''*CID:''+dateR~:#72                             update#=  190;       ''~7912I~
'************************************************************************************''~7912I~
'v008 2017/09/12 dictionary support                                    ''~7912I~
'************************************************************************************''~7912I~
'*** Discarded by Form11 **************                                ''+7914I~
Imports System.Runtime.InteropServices.Marshal                         ''~7912I~
Public Class Form9                                                     ''~7912R~
    '** Dictionary Dialog                                              ''~7912I~
    ''~7912I~
    Private Const COLNO = 3                                            ''~7912I~
    Public callerForm3 As Form3                                        ''~7912I~
    Private cfgKeys As String = My.Settings.CFGF9_Dictionary           ''~7912I~
    Private dlgAddDictionary As Form10                                 ''~7912I~
    Private LV As ListView                                             ''~7912I~
    Private ListData() As String                                       ''~7912I~
    ''~7912I~
    '***************************************************************************''~7912I~
    Private Const SB_VERT = 1                                          ''~7912I~
    Private Const WM_VSCROLL = &H115                                   ''~7912I~
    Private Const SB_LINEUP = 0                                        ''~7912I~
    Private Const SB_LINEDOWN = 1                                      ''~7912I~
    Private Const SB_PAGEUP = 2                                        ''~7912I~
    Private Const SB_PAGEDOWN = 3                                      ''~7912I~
    Private Const SB_THUMBPOSITION = 4                                 ''~7912I~
    Private Const SB_THUMBTRACK = 5                                    ''~7912I~
    Private Const SB_TOP = 6                                           ''~7912I~
    Private Const SB_ENDSCROLL = 8                                     ''~7912I~
    Declare Auto Function GetScrollPos Lib "user32.dll" (hWnd As IntPtr, nBar As Integer) As Integer ''~7912I~
    Declare Auto Function SendMessage Lib "user32.dll" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lparam As Integer) As Integer ''~7912I~
    Public Structure SCROLLINFO                                        ''~7912I~
        Public cbSize, fMask, nMin, nMax, nPage, nPos, nTrackPos As Integer ''~7912I~
    End Structure                                                      ''~7912I~
    Private vsi As SCROLLINFO                                          ''~7912I~
    Private Const SIF_RANGE = &H1                                      ''~7912I~
    Private Const SIF_PAGE = &H2                                       ''~7912I~
    Private Const SIF_POS = &H4                                        ''~7912I~
    Private Const SIF_TRACKPOS = &H10                                  ''~7912I~
    Private Const SIF_ALL As Integer = SIF_RANGE Or SIF_PAGE Or SIF_POS Or SIF_TRACKPOS ''~7912I~
    Declare Auto Function GetScrollInfo Lib "user32.dll" Alias "GetScrollInfo" (ByVal hWnd As IntPtr, ByVal n As Integer, ByRef lpScrollInfo As SCROLLINFO) As Integer ''~7912I~
    Declare Auto Function SetScrollInfo Lib "user32.dll" Alias "SetScrollInfo" (ByVal hWnd As IntPtr, ByVal n As Integer, ByRef lpScrollInfo As SCROLLINFO, ByVal bool As Boolean) As Integer ''~7912I~
    Private swUpdated As Boolean = False                                 ''~7912I~
    Private swShown As Boolean = False                                 ''~7912I~
    '***************************************************************************''~7912I~
    Sub New()                                                          ''~7912I~
        initVSI()                                                      ''~7912I~
        initDlg()                                                      ''~7912I~
    End Sub                                                            ''~7912I~
    Private Sub initVSI()                                              ''~7912I~
        vsi = New SCROLLINFO()                                         ''~7912I~
        vsi.cbSize = SizeOf(vsi)                                       ''~7912I~
    End Sub                                                            ''~7912I~
    Private Sub initDlg()                                              ''~7912I~
        setLang()   'should set CurrentUICulture before InitializeComponent''~7912I~
        InitializeComponent()                                          ''~7912I~
        Form1.setupTitlebarIcon(Me)                                    ''~7912I~
        Dim width As Integer                                           ''~7912I~
        width = Me.Width - Me.ColumnKanji.Width - 40 'avoid horizontal scrollbar''~7912I~
        Me.ColumnKana.Width = width                                    ''~7912I~
        Me.ColumnEnable.Name = "ColumnEnable"    'name to applyResouce ''~7912I~
        Me.ColumnKanji.Name = "ColumnKanji"                            ''~7912I~
        Me.ColumnKana.Name = "ColumnKana"                              ''~7912I~
        dlgAddDictionary = New Form10()                                ''~7912I~
        getCfg()                                                       ''~7912I~
    End Sub                                                            ''~7912I~
    Public Sub showDlg()                                               ''~7912R~
        If swShown Then                                                     ''~7912R~
            If Not isDisposed() Then                                   ''~7912I~
                Me.Focus()                                             ''~7913I~
                Exit Sub                                               ''~7912R~
            End If                                                     ''~7912R~
            Form1.dlgDictionary = New Form9()                          ''~7913I~
            Form1.dlgDictionary.showDlg()                              ''~7913I~
            Exit Sub                                                   ''~7913I~
        End If                                                         ''~7912I~
        initListView()                                                 ''~7912I~
        Show()    'moderess                                            ''~7912I~
        swShown = True                                                   ''~7912I~
    End Sub                                                            ''~7912I~
    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click ''~7912I~
        If swUpdated Then                                                   ''~7912I~
            If Not confirmDiscard() Then                                    ''~7912I~
                Exit Sub                                               ''~7912I~
            End If                                                     ''~7912I~
        End If                                                          ''~7912I~
        Me.Close()                                                     ''~7912I~
    End Sub 'resize                                                    ''~7912I~
    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click ''~7912I~
        Dim str As String = Nothing                                    ''~7912I~
        If swUpdated Then                                                   ''~7912I~
            putCFG()                                                   ''~7912R~
        End If                                                          ''~7912I~
        Me.Close()                                                     ''~7912I~
    End Sub 'resize                                                    ''~7912I~
    Private Sub ButtonHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp.Click ''~7912I~
        showHelp()                                                     ''~7912I~
    End Sub                                                            ''~7912I~
    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click ''~7912I~
#If False Then                                                         ''~7913I~
        Dim pos As Integer = getSelectedPos()                          ''~7912I~
        Dim elem As Integer = ListData.Length                          ''~7913I~
        If pos < 0 Then                                                ''~7912I~
            If elem < 3 Then                                           ''~7913I~
                pos = 0                                                  ''~7913I~
            Else                                                       ''~7913I~
                MessageBox.Show(Rstr.MSG_ERR_ADD_SELECT_LINE)              ''~7912I~''~7913R~
                Exit Sub                                                   ''~7912I~''~7913R~
            End If                                                     ''~7913I~
        End If                                                         ''~7912I~
        Dim rc As Integer = dlgAddDictionary.ShowDialog()              ''~7912I~
        If rc = DialogResult.OK Then                                   ''~7912I~
            Dim enable As String = "1"                                 ''~7912R~
            Dim kanji As String = dlgAddDictionary.strKanji            ''~7912I~
            Dim kana As String = dlgAddDictionary.strKana              ''~7912I~
            addWord(enable, kanji, kana, pos)                           ''~7912R~
        End If                                                         ''~7912I~
#Else                                                                  ''~7913I~
    	Dim dlg as Form11=New Form11()                                 ''~7913I~
        dlg.showDialog()                                               ''~7913R~
#End If                                                                ''~7913I~
    End Sub                                                            ''~7912I~
    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click ''~7912I~
        Dim pos As Integer = getSelectedPos()                          ''~7912I~
        Dim elem As Integer = ListData.Length                          ''~7912I~
        If elem < 3 Then                                               ''~7912I~
            Exit Sub                                                   ''~7912I~
        End If                                                         ''~7912I~
        Dim listDataTemp(elem - COLNO - 1) As String    'allocation is +1 entry''~7912I~
        If pos < 0 Then                                                ''~7912I~
            '           MessageBox.Show("削除行が選択されていません")  ''~7912I~
            MessageBox.Show(Rstr.MSG_ERR_SELECT_LINE)                  ''~7912I~
            Exit Sub                                                   ''~7912I~
        End If                                                         ''~7912I~
        If pos > 0 Then                                                ''~7912I~
            '           Array.Copy(ListData, listDataTemp, pos * 2)    ''~7912I~
            Array.Copy(ListData, listDataTemp, pos * COLNO)            ''~7912I~
        End If                                                         ''~7912I~
        If pos < elem Then                                             ''~7912I~
            '           Array.Copy(ListData, pos * 2 + 2, listDataTemp, pos * 2, elem - pos * 2 - 2)''~7912I~
            Array.Copy(ListData, pos * COLNO + COLNO, listDataTemp, pos * COLNO, elem - pos * COLNO - COLNO) ''~7912I~
        End If                                                         ''~7912I~
        ListData = listDataTemp                                        ''~7912I~
        initListView()                                                 ''~7912I~
    End Sub                                                            ''~7912I~
    Private Sub ButtonUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUp.Click ''~7912I~
        Dim pos As Integer = getSelectedPos()                          ''~7912I~
        Dim elem As Integer = ListData.Length                          ''~7912I~
        If elem < 1 Then                                               ''~7912I~
            Exit Sub                                                   ''~7912I~
        End If                                                         ''~7912I~
        Dim listDataTemp(elem - 1) As String    'allocation is +1 entry''~7912I~
        If pos <= 0 Then                                               ''~7912I~
            '           MessageBox.Show("上移動する行を選択してください")''~7912I~
            MessageBox.Show(Rstr.MSG_ERR_SELECT_LINE)                  ''~7912I~
            Exit Sub                                                   ''~7912I~
        End If                                                         ''~7912I~
        Array.Copy(ListData, listDataTemp, elem)                       ''~7912I~
        Array.Copy(ListData, pos * COLNO, listDataTemp, (pos - 1) * COLNO, COLNO) ''~7912I~
        Array.Copy(ListData, (pos - 1) * COLNO, listDataTemp, pos * COLNO, COLNO) ''~7912I~
        ListData = listDataTemp                                        ''~7912I~
        initListView()                                                 ''~7912I~
        setSelectedPos(pos - 1)                                        ''~7912I~
        If pos = getVScrollPos(Nothing) Then                           ''~7912I~
            LineScroll(-1)                                             ''~7912I~
        End If                                                         ''~7912I~
    End Sub                                                            ''~7912I~
    Private Sub ButtonDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDown.Click ''~7912I~
        Dim pos As Integer = getSelectedPos()                          ''~7912I~
        Dim elem As Integer = ListData.Length                          ''~7912I~
        If elem < 1 Then                                               ''~7912I~
            Exit Sub                                                   ''~7912I~
        End If                                                         ''~7912I~
        Dim listDataTemp(elem - 1) As String    'allocation is +1 entry''~7912I~
        '       If pos < 0 OrElse pos + 1 = elem / 2 Then              ''~7912I~
        If pos < 0 OrElse pos + 1 = elem / COLNO Then                  ''~7912I~
            '           MessageBox.Show("下移動する行を選択してください")''~7912I~
            MessageBox.Show(Rstr.MSG_ERR_SELECT_LINE)                  ''~7912I~
            Exit Sub                                                   ''~7912I~
        End If                                                         ''~7912I~
        Array.Copy(ListData, listDataTemp, elem)                       ''~7912I~
        Array.Copy(ListData, pos * COLNO, listDataTemp, (pos + 1) * COLNO, COLNO) ''~7912I~
        Array.Copy(ListData, (pos + 1) * COLNO, listDataTemp, pos * COLNO, COLNO) ''~7912I~
        ListData = listDataTemp                                        ''~7912I~
        initListView()                                                 ''~7912I~
        setSelectedPos(pos + 1)                                        ''~7912I~
        Dim pagesz As Integer                                          ''~7912I~
        If pos + 1 >= getVScrollPos(pagesz) + pagesz Then              ''~7912I~
            LineScroll(1)                                              ''~7912I~
        End If                                                         ''~7912I~
    End Sub                                                            ''~7912I~
    Private Sub showHelp()                                             ''~7912I~
        Dim txt As String                                              ''~7912I~
        If FormOptions.swLangEN Then                                   ''~7912I~
            txt = My.Resources.help_form9E                             ''~7913R~
        Else                                                           ''~7912I~
            txt = My.Resources.help_form9                              ''~7913R~
        End If                                                         ''~7912I~
        MessageBox.Show(txt, Me.Text)                                  ''~7912I~
    End Sub                                                            ''~7912I~
    Private Sub initListView()                                         ''~7912I~
        Dim vpos As Integer                                            ''~7912I~
        LV = ListViewDictionary                                       ''~7912I~
        vpos = getVScrollPos(Nothing)                                  ''~7912I~
        fillColumn()                                                   ''~7912I~
        setVScrollPos(vpos)                                            ''~7912I~
    End Sub                                                            ''~7912I~
    Private Function getVScrollPos(ByRef Pppagesz As Integer) As Integer ''~7912I~
        vsi.fMask = SIF_ALL                                            ''~7912I~
        GetScrollInfo(LV.Handle, SB_VERT, vsi)                         ''~7912I~
        If Not IsNothing(Pppagesz) Then                                ''~7912I~
            Pppagesz = vsi.nPage                                       ''~7912I~
        End If                                                         ''~7912I~
        Return vsi.nPos                                                ''~7912I~
    End Function                                                       ''~7912I~
    Private Sub setVScrollPos(Ppos As Integer)                         ''~7912I~
        Dim pos As Integer                                             ''~7912I~
        pos = SB_TOP                                                   ''~7912I~
        SendMessage(LV.Handle, WM_VSCROLL, pos, 0)                     ''~7912I~
        '       pos =  SB_BOTTOM                                       ''~7912I~
        '       pos =  SB_PAGEDOWN                                     ''~7912I~
        pos = SB_LINEDOWN                                              ''~7912I~
        For ii As Integer = 0 To Ppos - 1                              ''~7912I~
            SendMessage(LV.Handle, WM_VSCROLL, pos, 0)                 ''~7912I~
        Next                                                           ''~7912I~
        '       pos = SB_ENDSCROLL                                     ''~7912I~
        '       SendMessage(LV.Handle, WM_VSCROLL, pos, 0)             ''~7912I~
    End Sub                                                            ''~7912I~
    Private Sub LineScroll(Pctr As Integer)                            ''~7912I~
        Dim pos, ctr As Integer                                        ''~7912I~
        If Pctr < 0 Then                                               ''~7912I~
            pos = SB_LINEUP                                            ''~7912I~
            ctr = -Pctr                                                ''~7912I~
        Else                                                           ''~7912I~
            pos = SB_LINEDOWN                                          ''~7912I~
            ctr = Pctr                                                 ''~7912I~
        End If                                                         ''~7912I~
        For ii As Integer = 0 To ctr - 1                               ''~7912I~
            SendMessage(LV.Handle, WM_VSCROLL, pos, 0)                 ''~7912I~
        Next                                                           ''~7912I~
    End Sub                                                            ''~7912I~
    Private Sub fillColumn()                                           ''~7912I~
        LV.Items.Clear()    ' clear() also delete column               ''~7912I~
        For ii As Integer = 0 To ListData.Length / COLNO - 1           ''~7912I~
            LV.Items.Add(ListData(ii * COLNO), 0)                       ''~7912I~''~7913R~
            LV.Items(ii).SubItems.Add(ListData(ii * COLNO + 1))            ''~7912I~''~7913R~
            LV.Items(ii).SubItems.Add(ListData(ii * COLNO + 2))    ''~7912I~''~7913R~
        Next                                                           ''~7912I~
    End Sub                                                            ''~7912I~
    Private Function getSelectedChar(ByRef Ppstr As String) As Boolean ''~7912I~
        If LV.SelectedItems.Count > 0 Then                             ''~7912I~
            Ppstr = LV.SelectedItems(0).SubItems(1).Text               ''~7912I~
            Return True                                                ''~7912I~
        End If                                                         ''~7912I~
        Return False                                                   ''~7912I~
    End Function                                                       ''~7912I~
    Private Function getSelectedPos() As Integer                       ''~7912I~
        Dim pos As Integer                                             ''~7912I~
        If LV.SelectedItems.Count > 0 Then                             ''~7912I~
            pos = LV.SelectedIndices(0)                                ''~7912I~
        Else                                                           ''~7912I~
            pos = -1                                                   ''~7912I~
        End If                                                         ''~7912I~
        Return pos                                                     ''~7912I~
    End Function                                                       ''~7912I~
    Private Sub setSelectedPos(Ppos As Integer)                        ''~7912I~
        If Ppos < 0 OrElse Ppos >= LV.Items.Count Then                 ''~7912I~
            Exit Sub                                                   ''~7912I~
        End If                                                         ''~7912I~
        LV.Focus()                                                     ''~7912I~
        LV.Items(Ppos).Selected = True                                 ''~7912I~
    End Sub                                                            ''~7912I~
    Public Function getSpecialStr(Pindex As Integer) As String         ''~7912I~
        'By Alt+Num key                                                ''~7912I~
        '       If Pindex >= ListData.Length / 2 Then                  ''~7912I~
        If Pindex >= ListData.Length / COLNO Then                      ''~7912I~
            Return Nothing                                             ''~7912I~
        End If                                                         ''~7912I~
        '       Return ListData(Pindex * 2)                            ''~7912I~
        Return ListData(Pindex * COLNO)                                ''~7912I~
    End Function                                                       ''~7912I~
    Private Sub addWord(Penable As String, Pkanji As String, Pkana As String, Ppos As Integer) ''~7912R~
        Dim elem As Integer = ListData.Length                          ''~7912I~
        Dim listDataTemp(elem + COLNO - 1) As String    'allocated +1 entry''~7912I~
        Dim pos As Integer = Ppos                                      ''~7912I~
        If pos > 0 Then                                                ''~7912I~
            Array.Copy(ListData, listDataTemp, pos * COLNO)            ''~7912I~
        End If                                                         ''~7912I~
        listDataTemp(pos * COLNO) = Penable                            ''~7912R~
        listDataTemp(pos * COLNO + 1) = Pkanji                         ''~7912R~
        listDataTemp(pos * COLNO + 2) = Pkana                          ''~7912R~
        If pos < elem Then                                             ''~7912I~
            Array.Copy(ListData, pos * COLNO, listDataTemp, pos * COLNO + COLNO, elem - pos * COLNO) ''~7912I~
        End If                                                         ''~7912I~
        ListData = listDataTemp                                        ''~7912I~
        initListView()                                                 ''~7912I~
    End Sub                                                            ''~7912I~
    Private Sub putCFG()                                               ''~7912I~
        cfgKeys = String.Join(";", ListData)                           ''~7912I~
        My.Settings.CFGF9_Dictionary = cfgKeys                         ''~7912I~
    End Sub                                                            ''~7912I~
    Private Sub getCfg()                                               ''~7912I~
        If cfgKeys.CompareTo("") = 0 Then                              ''~7912I~
            ListData = {""}                                            ''~7913R~
        Else                                                           ''~7912I~
            ListData = cfgKeys.Split(";"c)                             ''~7912I~
        End If                                                         ''~7912I~
    End Sub                                                            ''~7912I~
    ''~7912I~
    Private Sub setLang()                                              ''~7912I~
        FormOptions.setLang()                                          ''~7912I~
    End Sub                                                            ''~7912I~
    Private Function confirmDiscard() As Boolean                       ''~7912I~
        If MessageBox.Show(Rstr.getStr("STR_MSG_CONFIRM_DISCARD_DICTIONARY_UPDATE"), Me.Text, MessageBoxButtons.YesNo) = DialogResult.No Then ''~7912I~
            Return False                                               ''~7912I~
        End If                                                         ''~7912I~
        Return True                                                    ''~7912I~
    End Function                                                       ''~7912I~

    Private Sub ListViewDictionary_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListViewDictionary.SelectedIndexChanged

    End Sub
End Class