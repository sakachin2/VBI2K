'CID:''+v037R~:#72                          update#=  196;            ''+v037R~
'************************************************************************************''~v026I~
'v037 2017/09/22 assign F4 as query of replacing char                  ''+v037I~
'                Forecolor have to be InactiveCaptureText to get effective for switching Text by language''+v037I~
'v026 2017/09/19 By F5,"り"(hiragana)<-->"リ"(katakana),"工"(kanji)-->"エ"(katakana)-->"ェ"(katakana-small)-->"工" (wrap),"力"(kanji)-->"カ"(katakana)-->"ヵ"(katakana)-->"力"(Wrap)''~v026I~
'************************************************************************************''~v026I~
Public Class ClassUndoRedo                                             ''~7429R~
    'localization not required                                             ''~7618I~
    Public Const OPT_BESTEXT = 0                                        ''~7501I~''~7506M~
    Public Const OPT_KANJITEXT = 1                                       ''~7501I~''~7506R~
    Public Const OPT_KANATEXT = 2                                      ''~7506I~
    Private Const POSFLAG_CUT = &H10000                                ''~7514I~''~7525R~
    Private Const POSFLAG_VSCROLL = &H20000                        ''~7525I~
    Private Const POSFLAG_VSCROLL_CTR = &HFFFF                        ''~7525I~
    ''~7506I~
    Private TB As TextBox                                          ''~7429I~
    Private swSetText, swSaved As Boolean                       ''~7429R~''~7501R~
    Private undoStack As New Stack(Of String)
    Private redoStack As New Stack(Of String)    ''~7429I~''~7506R~
    Private undoStackPos As New Stack(Of Rectangle)                    ''~7506R~
    Private redoStackPos As New Stack(Of Rectangle)                    ''~7506R~
    Private btnUndo, btnRedo As ToolStripButton                     ''~7429I~
    Private menuUndo, menuRedo As ToolStripMenuItem                    ''~7501I~
    Private optFormat As Integer                                       ''~7501I~
    '   Private dlgOptions As FormOptions                                  ''~7506I~''~7525R~
    Private dlgSpecialKey As Form6                                    ''~7515I~
    Private fmtBES As FormatBES                                        ''~7506I~
    Private swKeyBS As Boolean                                         ''~7506I~
    Private btnType As Boolean '@@@@                                   ''~7513I~
    Private swDeleteCRLF As Boolean '@@@@                               ''~7513I~
    Private posCut As Integer                                          ''~7514I~
    Private swCut As Boolean                                           ''~7514I~
    Private swForm1 As Boolean                                         ''~7515I~
    Private cposRepAll As Rectangle                                    ''~7612I~
    Sub New(Popt As Integer, Ptb As TextBox, PbtnUndo As ToolStripButton, PbtnRedo As ToolStripButton) ''~7429R~''~7501R~
        swForm1 = False                                                  ''~7515I~
        btnType = True                                                   ''~7513M~''~7515M~
        TB = Ptb                                                         ''~7429I~
        optFormat = Popt                                                 ''~7501R~
        btnUndo = PbtnUndo                                               ''~7429I~
        btnRedo = PbtnRedo                                               ''~7429I~
        setUndoEnable(False)                                           ''~7501I~
        setRedoEnable(False)                                           ''~7501I~
        swSaved = False                                                  ''~7429I~
        '       dlgOptions = Form1.MainForm.dlgOptions                                  ''~7506I~''~7521R~''~7525R~
        dlgSpecialKey = Form1.MainForm.dlgSpecialKey                            ''~7515I~''~7521R~
        fmtBES = Form1.MainForm.fmtBES                                          ''~7506I~''~7521R~
    End Sub                                                            ''~7429I~
    Sub resetForm1()                                                   ''~7519I~
        setUndoEnable(False)                                           ''~7519I~
        setRedoEnable(False)                                           ''~7519I~
        swSaved = False                                                ''~7519I~
        undostack.clear()                                              ''~7519I~
        undostackPos.clear()                                           ''~7519I~
        redostack.clear()                                              ''~7519I~
        redostackPos.clear()                                           ''~7519I~
    End Sub                                                            ''~7519I~
    Sub New(Popt As Integer, Ptb As TextBox, PbtnUndo As ToolStripMenuItem, PbtnRedo As ToolStripMenuItem) ''~7501I~
        swForm1 = True                                                   ''~7515M~
        btnType = False                                                ''~7515R~
        TB = Ptb                                                       ''~7501I~
        optFormat = Popt                                                 ''~7501I~
        menuUndo = PbtnUndo                                            ''~7501R~
        menuRedo = PbtnRedo                                            ''~7501R~
        setUndoEnable(False)                                           ''~7501I~
        setRedoEnable(False)                                           ''~7501I~
        swSaved = False                                                  ''~7501I~
        '       dlgOptions = Form1.MainForm.dlgOptions                                  ''~7513I~''~7521R~''~7525R~
        dlgSpecialKey = Form1.MainForm.dlgSpecialKey                            ''~7515I~''~7521R~
        fmtBES = Form1.MainForm.fmtBES                                          ''~7513I~''~7521R~
    End Sub                                                            ''~7501I~
    Public Sub setTBText(Ptext As String, PswUndo As Boolean)          ''~7429I~
        Dim cpos As Rectangle                                          ''~7506R~
        Dim swtextchng As Boolean = True                                 ''~7508I~
        If Not PswUndo Then   'not stack text when it is from undoText ''~7508I~
            swtextchng = prepareUndoCheck(Ptext)                         ''~7508I~
        End If                                                         ''~7508I~
        cpos = getCaretPosLen()        'pos before TB.Text               ''~7506I~
        swSetText = True                                               ''~7429M~
        '       TB.Clear()           'also call textchanged handler            ''~7429M~''~7506R~
        TB.Text = Ptext                                                ''~7429M~
        swSetText = False                                              ''~7429M~
        If swtextchng Then                                                  ''~7508I~
            swSaved = False                                                  ''~7429I~''~7508I~
            If Not PswUndo Then   'not stack text when it is from undoText ''~7429I~''~7508R~
                prepareUndo(cpos)                                              ''~7429M~''~7506R~''~7508R~
            End If                                                         ''~7429M~''~7508R~
        End If                                                         ''~7508I~
    End Sub                                                            ''~7429M~
    Public Sub setTBTextRepAllStart()                                  ''~7612R~
        '       cposRepAll=getCaretPosLen()        'pos before TB.Text         ''~7612R~
    End Sub                                                            ''~7612I~
    Private Sub setTBTextRepAll(Ptext As String)                       ''~7612R~
        swSetText = True                                               ''~7612I~
        TB.Text = Ptext                                                ''~7612I~
        swSetText = False                                              ''~7612I~
        swSaved = False                                                ''~7612I~
    End Sub                                                            ''~7612I~
    Private Sub setTBTextRepAllAfterAll(Ptext As String)               ''~7612R~
        Dim cpos As Rectangle                                          ''~7612I~
        cpos = getCaretPosLen()        'pos after last rep               ''~7612I~
        prepareUndo(cpos)                                              ''~7612I~
    End Sub                                                            ''~7612I~
    Private Sub setTBTextRepAll(Ptext As String, PcaseRepAll As Integer) ''~7612R~
        If PcaseRepAll = 1 Then  'first of repall                             ''~7612I~
            setTBTextRepAllStart()                                     ''~7612R~
            Exit Sub                                                   ''~7612I~
        End If                                                         ''~7612I~
        If PcaseRepAll = 0 Then  'not first or last of repall                 ''~7612I~
            setTBTextRepAll(Ptext)                                     ''~7612R~
            Exit Sub                                                   ''~7612I~
        End If                                                         ''~7612I~
        setTBTextRepAllAfterAll(Ptext)                                 ''~7612I~
    End Sub                                                            ''~7612I~
    Public Sub setTBText(Ptext As String, PswUndo As Boolean, Pswchnghirakata As Boolean) ''~7506I~
        Dim cpos As Rectangle                                          ''~7506I~
        Dim swtextchng As Boolean = True                                 ''~7508I~
        If Not PswUndo Then   'not stack text when it is from undoText ''~7508I~
            swtextchng = prepareUndoCheck(Ptext)                         ''~7508I~
        End If                                                         ''~7508I~
        cpos = getCaretPosLen(Pswchnghirakata)        'pos before TB.Text''~7506I~
        swSetText = True                                               ''~7506I~
        TB.Text = Ptext                                                ''~7506I~
        swSetText = False                                              ''~7506I~
        If swtextchng Then                                                  ''~7508I~
            swSaved = False                                                ''~7506I~''~7508I~
            If Not PswUndo Then   'not stack text when it is from undoText ''~7506I~''~7508R~
                prepareUndo(cpos)                                          ''~7506I~''~7508R~
            End If                                                         ''~7506I~''~7508R~
        End If                                                         ''~7508I~
    End Sub                                                            ''~7506I~
    Public Sub showText(Ptext As String)                               ''~7429I~
        'initial set                                                       ''~7429I~
        Dim txt As String                                              ''~7429I~
        txt = appendCRLF(Ptext)                                            ''~7429I~
        setTBText(txt, False)                                          ''~7429I~
    End Sub                                                            ''~7429I~
    Public Function getTextToSave() As String                          ''~7429I~
        Dim txt As String                                              ''~7429I~
        txt = dropCRLF(TB.Text)                                        ''~7429I~
        Return txt                                                     ''~7429I~
    End Function                                                           ''~7429I~
    Public Sub saved()                                                 ''~7429I~
        swSaved = True                                                   ''~7429R~
    End Sub                                                            ''~7429I~
    Public Function isUpdated()                                        ''~7429I~
        If swSaved Then                                                     ''~7429I~
            Return False                                               ''~7429I~
        End If                                                         ''~7429I~
        If isUndoEnable() Then                                             ''~7429I~''~7501R~
            Return True                                                ''~7429I~
        End If                                                         ''~7429I~
        Return False                                                   ''~7429I~
    End Function                                                    ''~7429I~
    Public Sub TBChanged()                                             ''~7429I~
        Dim txt As String                                              ''~7429M~
        Dim vpos As Integer                                            ''~7429M~''~7502R~''~7506R~
        Dim cpos As Rectangle
        vpos = getVScrollPos()                                         ''~7502I~
        If Not swSetText Then                                          ''~7429I~
            cpos = getCaretPosLen()                                    ''~7506R~
            txt = dropCRLF(TB.Text)                                    ''~7429M~''~7502R~
            txt = appendCRLF(txt)                                        ''~7429R~''~7502R~
            If Not IsNothing(txt) Then
                resetRedo()                                            ''~7508R~
                setTBText(txt, False)                                  ''~7508R~
            End If                                                     ''~7508I~
            restoreCaretPosLen(cpos)                                   ''~7506R~
        End If                                                         ''~7429M~
        setVScrollPos(vpos)                                            ''~7502I~
    End Sub                                                            ''~7429M~
    Public Sub TBChanged(Ptext As String)                              ''~7501I~
        Dim txt As String                                              ''~7429M~
        Dim cpos As Rectangle                                            ''~7429M~''~7506R~
        If Not swSetText Then                                          ''~7501I~
            cpos = getCaretPosLen()                                    ''~7506I~
            txt = dropCRLF(Ptext)                                      ''~7501I~
            txt = appendCRLF(txt)                                      ''~7501I~
            setTBText(txt, False)                                      ''~7501I~
            resetRedo()                                                ''~7501I~''~7508M~
            restoreCaretPosLen(cpos)                                   ''~7506I~
        End If                                                         ''~7501I~
    End Sub                                                            ''~7501I~
    Private Sub TBChangedRepAll(Ptext As String, PcaseRepAll As Integer) ''~7612R~
        setTBTextRepAll(Ptext, PcaseRepAll)                              ''~7612R~
    End Sub                                                            ''~7612I~
    Public Sub TBChanged(Ptext As String, Pswchnghirakata As Boolean)   ''~7506I~
        Dim txt As String                                              ''~7506I~
        Dim cpos As Rectangle                                          ''~7506I~
        If Not swSetText Then                                          ''~7506I~
            cpos = getCaretPosLen(Pswchnghirakata)   'restore also scrollpos                                 ''~7506I~''~7507R~
            resetRedo()                                                ''~7506I~
            txt = dropCRLF(Ptext)                                      ''~7506I~
            txt = appendCRLF(txt)                                      ''~7506I~
            setTBText(txt, False, Pswchnghirakata)                      ''~7506I~
            restoreCaretPosLen(cpos)                                   ''~7506I~
        End If                                                         ''~7506I~
    End Sub                                                            ''~7506I~
    Private Function dropCRLF(Ptext As String) As String               ''~7429M~
        Dim txt As String                                              ''~7429M~
        If optFormat = OPT_BESTEXT Then                                ''~7501I~
            Return Ptext                                               ''~7501I~
        End If                                                         ''~7501I~
        If Ptext.IndexOf(FormatBES.SIGN_CRLF) < 0 Then                           ''~7429M~''~7506R~
            Return Ptext                                               ''~7429M~
        End If                                                         ''~7429M~
        txt = Ptext.Replace(FormatBES.SIGN_CRLF, "")                             ''~7429M~''~7506R~
        Return txt                                                     ''~7429M~
    End Function                                                       ''~7429M~
    Private Function appendCRLF(Ptext As String) As String             ''~7429R~
        Dim txt, strCRLF As String                                     ''~7429M~
        If optFormat = OPT_BESTEXT Then                                ''~7501I~
            Return Ptext                                               ''~7501I~
        End If                                                         ''~7501I~
        txt = dropCRLF(Ptext)                                          ''~7429M~
        strCRLF = FormatBES.SIGN_CRLF & vbNewLine                                ''~7429M~''~7506R~
        txt = txt.Replace(vbNewLine, strCRLF)                          ''~7429M~
        Return txt                                                     ''~7429I~
    End Function                                                            ''~7429M~
    Private Sub prepareUndo(Ppos As Rectangle)                                          ''~7429I~''~7506R~
        'stack current status                                          ''~7429M~
        undoStack.Push(TB.Text)                                        ''~7429M~
        '       If undoStack.Count=1 Then                                      ''~7513R~
        '           Dim pos As Rectangle                                       ''~7513R~
        '       	pos = New Rectangle(0,0, 0, -1)                            ''~7513R~
        '       	undoStackPos.Push(pos)                                     ''~7513R~
        '       else                                                           ''~7513R~
        If swCut Then                                                       ''~7514I~
            setPosCut(Ppos)                                            ''~7514I~
        End If                                                         ''~7514I~
        undoStackPos.Push(Ppos)                                      ''~7506R~''~7513R~
        '       end if                                                         ''~7513R~
        If undoStack.Count > 1 Then                                    ''~7429M~
            setUndoEnable(True)                                     ''~7429M~''~7501R~
        End If                                                         ''~7429M~
    End Sub                                                            ''~7429M~
    Private Function prepareUndoCheck(Ptext As String) As Boolean      ''~7508I~
        '** check undo stack required, if no text change return false      ''~7508I~
        Dim txt As String                                              ''~7508I~
        If undoStack.Count > 0 Then                                    ''~7508R~
            txt = undoStack.Peek()                                       ''~7508R~
            Return Ptext.CompareTo(txt) <> 0                             ''~7508R~
        End If                                                         ''~7508I~
        Return True                                                    ''~7508I~
    End Function                                                            ''~7508I~
    Public Sub undoText()                                              ''~7429M~
        Dim txt As String                                              ''~7429M~
        Dim cpos As Rectangle                                          ''~7506R~''~7514R~
        If undoStack.Count > 1 Then                                    ''~7429M~
            txt = undoStack.Pop()   'current                           ''~7429M~
            cpos = undoStackPos.Pop()                                    ''~7506R~
            prepareRedo(txt, cpos)                                           ''~7429M~''~7506R~
            txt = undoStack.Peek()   'previous                         ''~7429M~
            If undoStack.Count = 1 Then                                ''~7514I~
                If Not isPosCut(cpos) Then                                  ''~7514R~
                    cpos.X -= Math.Min(cpos.X, Math.Max(1, cpos.Y)) 'SelectionStart should be >=0                      ''~7514R~''~7519R~
                End If                                                 ''~7514I~
                cpos.Y = 0                                             ''~7514I~
            Else                                                       ''~7514I~
                cpos = undoStackPos.Peek() 'previous                       ''~7508I~''~7514R~
            End If                                                     ''~7514I~
            setTBText(txt, True)     'true:from undo,don't prepareUndo                   ''~7429I~''~7506R~
            restoreCaretPosLen(cpos)                                   ''~7506I~
        End If                                                         ''~7429M~
        If undoStack.Count <= 1 Then                                   ''~7429M~
            setUndoEnable(False)                                    ''~7429M~''~7501R~
        End If                                                         ''~7429M~
    End Sub                                                            ''~7429M~
    Private Sub prepareRedo(Ptext As String, Ppos As Rectangle)                           ''~7429I~''~7506R~
        'save current status                                           ''~7429M~
        Dim cpos As Rectangle                                          ''~7506R~
        redoStack.Push(Ptext)                                          ''~7429M~
        cpos = getCaretPosLen(Ppos.Width = 1)                            ''~7506R~
        redoStackPos.Push(cpos)                                        ''~7506R~
        setRedoEnable(True)                                         ''~7429M~''~7501R~
    End Sub                                                            ''~7429M~
    Public Sub redoText()                                              ''~7429I~
        Dim txt As String                                              ''~7429I~
        Dim cpos As Rectangle                                          ''~7506R~
        If redoStack.Count > 0 Then                                    ''~7429I~
            txt = redoStack.Pop()                                      ''~7429I~
            cpos = redoStackPos.Pop()                                  ''~7506R~
            setTBText(txt, False, cpos.Width = 1) 'keep hirakata change                                     ''~7429I~''~7506R~''~7507R~
            restoreCaretPosLen(cpos)                                   ''~7506R~
        End If                                                         ''~7430R~
        If redoStack.Count = 0 Then                                    ''~7430I~
            setRedoEnable(False)                                    ''~7430I~''~7501R~
        End If                                                         ''~7429I~
    End Sub                                                            ''~7429I~
    Private Sub resetRedo()                                            ''~7429I~
        'set not redoable                                              ''~7429R~
        redoStack.Clear()                                              ''~7429I~
        redoStackPos.Clear()                                           ''~7506I~
        setRedoEnable(False)                                        ''~7429R~''~7501R~
    End Sub                                                            ''~7429I~
    Private Sub setUndoEnable(Penable As Boolean)                      ''~7501I~
        If btnType Then                                                     ''~7513I~
            btnUndo.Enabled = Penable                                     ''~7501I~
        Else                                                           ''~7501I~
            menuUndo.Enabled = Penable                                    ''~7501I~
        End If                                                          ''~7501I~
    End Sub                                                            ''~7501I~
    Private Sub setRedoEnable(Penable As Boolean)                      ''~7501I~
        If btnType Then                                                     ''~7513I~
            btnRedo.Enabled = Penable                                     ''~7501I~
        Else                                                           ''~7501I~
            menuRedo.Enabled = Penable                                    ''~7501I~
        End If                                                          ''~7501I~
    End Sub                                                            ''~7501I~
    Private Function isUndoEnable() As Boolean                         ''~7501I~
        If btnType Then                                                     ''~7513I~
            Return btnUndo.Enabled                                      ''~7501I~
        Else                                                           ''~7501I~
            Return menuUndo.Enabled                                     ''~7501I~
        End If                                                          ''~7501I~
    End Function                                                       ''~7501I~
    Private Function isRedoEnable() As Boolean                         ''~7501I~
        If btnType Then                                                     ''~7513I~
            Return btnRedo.Enabled                                      ''~7501I~
        Else                                                           ''~7501I~
            Return menuRedo.Enabled                                     ''~7501I~
        End If                                                          ''~7501I~
    End Function                                                       ''~7501I~
    Private Function getVScrollPos() As Integer                        ''~7502I~
        Return TB.SelectionStart                                     ''~7502I~
    End Function                                                       ''~7502I~
    Private Sub setVScrollPos(Ppos As Integer)                         ''~7502I~
        TB.ScrollToCaret()                                    ''~7502R~
    End Sub                                                            ''~7502I~
    Public Sub CMCut(Pafter As Integer)      'Cut&Paste                ''~7514R~
        Dim rect As Rectangle                                          ''~7514I~
        Dim pos, len As Integer                                        ''~7514I~
        If Pafter = 0 Then                                                    ''~7514I~
            rect = getCaretPosLen()                                    ''~7514R~
            pos = rect.X                                               ''~7514R~
            len = rect.Y                                               ''~7514R~
            If len > 0 Then                                            ''~7514R~
                pos += len - 1                                         ''~7514R~
            End If                                                     ''~7514R~
            swDeleteCRLF = chkCRLFDeleted(pos, len, False)                     ''~7514R~''~7525R~
            If swDeleteCRLF Then                                            ''~7514R~
                posCut = rect.X                                        ''~7514M~
                TB.SelectionStart = posCut                             ''~7514R~
                TB.SelectionLength = len + vbCrLf.Length               ''~7514I~
            End If                                                     ''~7514R~
            swCut = True                                                 ''~7514I~
        Else                                                           ''~7514I~
            If swDeleteCRLF Then                                            ''~7514I~
                TB.SelectionStart = posCut                               ''~7514I~
            End If                                                     ''~7514I~
            swCut = False                                                ''~7514I~
        End If                                                         ''~7514I~
    End Sub                                                            ''~7514I~
    Private Sub setPosCut(ByRef Ppos As Rectangle)                     ''~7514R~
        Ppos.Height = Ppos.Height Or POSFLAG_CUT                     ''~7525R~
    End Sub                                                            ''~7514I~
    Private Function isPosCut(Ppos As Rectangle) As Boolean            ''~7514I~
        Return (Ppos.Height And POSFLAG_CUT) <> 0                        ''~7514R~
    End Function                                                            ''~7514I~
    Public Sub TB_KeyDown(e As System.Windows.Forms.KeyEventArgs)     ''~7506M~
        Dim rect As Rectangle                                          ''~7514R~
        Dim pos, len As Integer                                         ''~7514I~
        rect = getCaretPosLen()                                          ''~7514I~
        pos = rect.X                                                     ''~7514I~
        len = rect.Y                                                     ''~7514I~
        swKeyBS = False                                                  ''~7506I~
        swDeleteCRLF = False                                             ''~7513I~
        Select Case e.KeyCode                                          ''~7506M~
            Case Keys.None                                             ''~7521I~
            Case Keys.Delete                                           ''~7506M~
                If len > 0 Then                                        ''~7514I~
                    pos += len - 1                                     ''~7514I~
                End If                                                 ''~7514I~
                swDeleteCRLF = chkCRLFDeleted(pos, len, False)                                    ''~7506M~''~7513R~''~7514R~''~7525R~
            Case Keys.Back                                             ''~7506M~
                If len > 0 Then                                        ''~7514I~
                    pos += len - 1                                     ''~7514I~
                Else                                                   ''~7514I~
                    pos -= 1                                             ''~7514I~
                End If                                                 ''~7514I~
                swDeleteCRLF = chkCRLFDeleted(pos, len, True)                  ''~7513R~''~7514R~''~7525R~
                If swDeleteCRLF Then                                   ''~7513I~
                    swKeyBS = True                                       ''~7506I~
                End If                                                 ''~7506I~
            Case Keys.F                                                ''~7516I~
                If (e.Modifiers And Keys.Control) = Keys.Control Then  'Ctrl+F''~7516I~
                    If swForm1 Then                                         ''~7516I~
                        Form1.MainForm.showFindDialog()                         ''~7516I~''~7521R~
                    Else                                               ''~7516I~
                        Form1.formText.showFindDialog()                         ''~7516I~''~7521R~
                    End If                                             ''~7516I~
                End If                                                 ''~7516I~
            Case Keys.F3                                               ''~7519I~
                Dim swUp As Boolean = ((e.Modifiers And Keys.Shift) = Keys.Shift) ''~7521I~''~7609R~
                If swForm1 Then                                        ''~7521I~
                    Form1.MainForm.findNext(swUp)                      ''~7521R~
                Else                                                   ''~7521I~
                    Form1.formText.findNext(swUp)             ''~7521R~
                End If                                                 ''~7521I~
        End Select                                                     ''~7506M~
        If swDeleteCRLF AndAlso len > 0 Then                                        ''~7514I~
            swCut = True                                               ''~7514I~
        Else                                                           ''~7514I~
            swCut = False                                              ''~7514I~
        End If                                                         ''~7514I~
    End Sub                                                            ''~7506M~
    Public Sub TB_KeyUp(e As System.Windows.Forms.KeyEventArgs)       ''~7501I~''~7506M~
        Dim pos As Integer = getCaretPos()                               ''~7501I~''~7506M~
        Dim txt As String = TB.Text                                ''~7501I~''~7506I~
        Dim ch, cvch As Char                                            ''~7501I~''~7506M~
        Dim swconcatline As Boolean = False                            ''~7506M~
        '       Dim swRepeat As Boolean = False                                ''~7525I~''~7608R~
        Dim key As Keys                                                ''~7525I~
        Dim specialStrIndex As Integer = -1                              ''~7525I~
        Dim str As String                                              ''~7525I~
        If pos < 0 OrElse pos >= txt.Length Then                                ''~7501I~''~7506M~
            Return                                                     ''~7501I~''~7506M~
        End If                                                         ''~7501I~''~7506M~
        ch = txt.Chars(pos)                                             ''~7501I~''~7506M~
        cvch = FormatBES.SIGN_CHAR_NOTHING                                         ''~7501I~''~7506M~
        key = e.KeyCode                                                  ''~7525I~
        Select Case key                                                     ''~7525R~
            Case Keys.None                                             ''~7521I~
            Case FormOptions.keySmallKeyQ                              ''+v037I~
                fmtBES.queryLetterSmallLarge(ch, swForm1)               ''+v037I~
            Case FormOptions.keySmallKey                               ''~7525I~
                If (e.Modifiers And Keys.Shift) = Keys.Shift Then 'with shift key''~7525I~''~7608R~
#If False Then                                                              ''~7608I~
	                if fmtBES.changeLetterOther(ch, cvch)=1            ''~7525I~
                    	swRepeat=true                                  ''~7525I~
                    end if                                             ''~7525I~
#Else                                                                  ''~7608I~
                    fmtBES.changeLetterOther(ch, cvch)                 ''~7608I~
#End If                                                                ''~7608I~
                Else                                                   ''~7525I~
                    '                   fmtBES.changeLetterSmallLarge(ch, cvch)                ''~7515I~''~7525R~''~v026R~
                    fmtBES.changeLetterSmallLarge(ch, cvch, swForm1)    ''~v026I~
                End If                                                 ''~7525I~
            Case FormOptions.keySpecialCharKey                         ''~7525I~
                showDialogSpecialKey(cvch)                             ''~7515I~
            Case Else                                                  ''~7515I~
                If key >= Keys.D0 AndAlso key <= Keys.D9 Then                   ''~7525I~
                    If (e.Modifiers And Keys.Control) = Keys.Control Then 'with shift key''~7525I~''~7608R~
                        If key = Keys.D0 Then                                 ''~7525R~
                            specialStrIndex = 9                          ''~7525R~
                        Else                                           ''~7525R~
                            specialStrIndex = key - Keys.D1                ''~7525R~
                        End If                                         ''~7525R~
                    End If                                             ''~7525I~
                End If                                                 ''~7525I~
        End Select                                                     ''~7501M~''~7506M~
        If swDeleteCRLF AndAlso Not swCut Then                                                ''~7513I~
            TB.SelectionStart = pos - 1                                  ''~7513I~
        End If                                                         ''~7513I~
        If specialStrIndex >= 0 Then                                          ''~7525I~
            str = Form1.MainForm.getSpecialStr(specialStrIndex)          ''~7525I~
            If Not isNothing(str) Then                                      ''~7525I~
                setSpecialChar(str)                                    ''~7525I~
                Exit Sub                                               ''~7525I~
            End If                                                     ''~7525I~
#If False Then                                                              ''~7608I~
        elseif swRepeat                                                ''~7525R~
	    	str=fmtBES.getRepeatStr(txt,pos)                           ''~7525R~
            if Not isNothing(str)                                      ''~7525I~
                If pos + 1 = txt.Length Then                           ''~7525I~
                    txt = txt.Substring(0, pos) & str                  ''~7525I~
                Else                                                   ''~7525I~
                    txt = txt.Substring(0, pos) & str & txt.Substring(pos + 1)''~7525I~
                End If                                                 ''~7525I~
                TBChanged(txt)                                         ''~7525I~
            end if                                                     ''~7525I~
#End If                                                                ''~7608I~
        Else                                                           ''~7525I~
            If cvch <> FormatBES.SIGN_CHAR_NOTHING Then                    ''~7501R~''~7506M~
                If pos + 1 = txt.Length Then                               ''~7501R~''~7506M~
                    txt = txt.Substring(0, pos) & cvch                     ''~7501R~''~7506M~
                Else                                                       ''~7501R~''~7506M~
                    txt = txt.Substring(0, pos) & cvch & txt.Substring(pos + 1) ''~7501R~''~7506M~
                End If                                                     ''~7501R~''~7506M~
                TBChanged(txt)                                             ''~7501I~''~7506M~
            End If                                                         ''~7501R~''~7506M~
        End If                                                         ''~7525I~
    End Sub                                                            ''~7501I~''~7506M~
    Public Sub TB_KeyPress(e As System.Windows.Forms.KeyPressEventArgs) ''~7506M~
        Dim pos As Integer = getCaretPos()                             ''~7506M~
        Dim txt As String = TB.Text                                    ''~7506I~
        If pos < 0 OrElse pos >= txt.Length Then                       ''~7506M~
            Return                                                     ''~7506M~
        End If                                                         ''~7506M~
        If e.KeyChar = FormatBES.CHAR_CR Then  'enter key                     ''~7525R~
            If txt.Chars(pos) = FormatBES.CHAR_LF Then                        ''~7525R~
                TB.SelectionStart = pos + 1 'pos after LF                  ''~7525R~
            End If                                                     ''~7525I~
        ElseIf swKeyBS Then   'delete CRLF(after SIGN_CRLF)           ''~7525I~
        Else     'ignore input after CRLF except Enter and BackSpace   ''~7525I~
            If txt.Chars(pos) = FormatBES.CHAR_CR OrElse txt.Chars(pos) = FormatBES.CHAR_LF Then ''~7525I~
                e.Handled = True  'ignore char key                     ''~7525R~
            End If                                                     ''~7525I~
        End If                                                         ''~7525I~
    End Sub                                                            ''~7506M~
    Private Function chkCRLFDeleted(Ppos As Integer, Plen As Integer, PkeyBS As Boolean) As Boolean        ''~7506R~''~7514R~''~7525R~
        Dim rc As Boolean = False                                        ''~7506R~
        Dim txt As String = TB.Text                                    ''~7506I~
        Dim ch As Char                                                 ''~7506M~
        Dim pos As Integer                                             ''~7506M~
        pos = Ppos                                                     ''~7506M~
        If pos < 0 OrElse pos >= txt.Length Then                       ''~7506M~
            Return rc                                                     ''~7506M~
        End If                                                         ''~7506M~
        ch = txt.Chars(pos)                                            ''~7506M~
        If ch = FormatBES.SIGN_CRLF Then                   ''~7506M~   ''~7525R~
            If pos + 1 < txt.Length AndAlso txt.IndexOf(vbCrLf, pos + 1) = pos + 1 Then ''~7506M~
                '               txt = txt.Remove(pos + 1, vbCrLf.Length)''~7506M~
                '               TBChanged(txt)                         ''~7506M~
                If Plen = 0 Then  ' selected length                           ''~7514I~
                    TB.SelectionStart = pos + 1                            ''~7506I~''~7513R~''~7514R~
                End If                                                 ''~7514I~
                TB.SelectionLength += vbCrLf.Length                     ''~7506I~''~7513R~
                rc = True                                                ''~7506I~
            End If                                                     ''~7506M~
        Else                                                           ''~7525R~
            If PkeyBS Then                                                  ''~7525I~
                If ch = FormatBES.CHAR_LF Then   'del by backspace     ''~7525I~
                    TB.SelectionStart = pos - 1 'pos of CHAR_CR        ''~7525R~
                    TB.SelectionLength = vbCrLf.Length                 ''~7525I~
                    rc = True                                          ''~7525R~
                ElseIf ch = FormatBES.CHAR_CR Then   'del by backspace ''~7525I~
                    TB.SelectionLength = vbCrLf.Length                 ''~7525R~
                    rc = True                                          ''~7525R~
                End If                                                 ''~7525R~
            End If                                                     ''~7525I~
        End If                                                         ''~7525I~
        Return rc                                                      ''~7506I~
    End Function                                                       ''~7506R~
    Private Function getCaretPos() As Integer                          ''~7514R~
        Return TB.SelectionStart                                 ''~7501I~''~7506I~
    End Function                                                       ''~7501I~''~7506M~
    Private Function getCaretPosLen() As Rectangle                     ''~7506R~
        Dim rect As Rectangle                                          ''~7507I~
        rect = New Rectangle(TB.SelectionStart, TB.SelectionLength, 0, 0)  'X/Y''~7506R~''~7507R~''~7525R~
        Dim scrollpos As Integer = GetScrollPos(TB.Handle, SB_VERT)    ''~7507M~
        rect.Height = scrollpos Or POSFLAG_VSCROLL                                       ''~7507M~''~7525R~
        Return rect                                                    ''~7507I~
    End Function                                                       ''~7506I~
    Private Function getCaretPosLen(Pswchnghirakata As Boolean) As Rectangle ''~7506I~
        Dim rect As Rectangle = getCaretPosLen()                         ''~7506I~
        If Pswchnghirakata Then                                             ''~7506I~
            rect.Width = 1
        End If ''~7506I~
        Return rect                                                    ''~7506I~
    End Function                                                       ''~7506I~
    Private Sub restoreCaretPosLen(Ppoint As Rectangle)                     ''~7506R~
        TB.SelectionStart = Ppoint.X                                     ''~7506I~
        TB.SelectionLength = Ppoint.Y                                    ''~7506I~
        If Ppoint.X < TB.Text.Length Then                                     ''~7525R~
            If TB.Text.Chars(Ppoint.X) = FormatBES.CHAR_CR Then               ''~7525I~
                TB.SelectionStart += vbCrLf.Length  'move caret at top of next line''~7525R~
                TB.SelectionLength = 0                                 ''~7525R~
            End If                                                     ''~7525R~
            If TB.Text.Chars(Ppoint.X) = FormatBES.CHAR_LF Then               ''~7525I~
                TB.SelectionStart += 1  'move caret at top of next line''~7525I~
                TB.SelectionLength = 0                                 ''~7525I~
            End If                                                     ''~7525I~
        End If                                                         ''~7525I~
        If optFormat = OPT_KANATEXT Then                                    ''~7508R~
            Form1.MainForm.formkanaText.setHirakata(Ppoint.Width = 1)  ''~7522I~
            If (Ppoint.Height And POSFLAG_VSCROLL) = POSFLAG_VSCROLL Then                                        ''~7507I~''~7525R~''~7609R~
                scrollTB(Ppoint.Height And POSFLAG_VSCROLL_CTR)                                ''~7507I~''~7525R~
            End If                                                     ''~7507I~
        End If                                                         ''~7508I~
    End Sub                                                            ''~7507R~
    Private Sub scrollTB(Ppos As Integer)                              ''~7507I~
        '       TB.ScrollToCaret()                                             ''~7507R~
        Dim pos As Integer = Ppos                                        ''~7507R~
        '        SetScrollPos(TB.Handle, SB_VERT, pos, True)                    ''~7507I~
        pos = (pos << 16) + SB_THUMBPOSITION                                 ''~7507R~
        Dim rc = SendMessage(TB.Handle, WM_VSCROLL, pos, 0)                 ''~7507R~
    End Sub                                                            ''~7507I~
    '***************************************************************************''~7507I~
    Private Const SB_VERT = 1                                          ''~7507R~
    Private Const WM_VSCROLL = &H115                                    ''~7507I~
    '   Private Const SB_BOTTOM = 7                                        ''~7507R~
    Private Const SB_THUMBPOSITION = 4                                  ''~7507I~
    Declare Auto Function GetScrollPos Lib "user32.dll" (hWnd As IntPtr, nBar As Integer) As Integer ''~7507I~
    '   Declare Auto Sub SetScrollPos Lib "user32.dll" (hWnd As IntPtr, nBar As Integer, nPos As Integer, bRedraw As Boolean)''~7507R~
    '   Declare Auto Function ScrollWindowEx Lib "user32.dll" (hWnd As IntPtr, dx As Integer, dy As Integer, prcScroll As IntPtr, prcClip As IntPtr, hrgnUpdate As IntPtr, ByRef prcUpdate As Intptr, flags As Integer) As Integer''~7507R~
    '   Declare Auto Function GetLastError Lib "user32.dll" () As Integer  ''~7507R~
    Declare Auto Function SendMessage Lib "user32.dll" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lparam As Integer) As Integer ''~7507I~''~7526R~
    Private Sub showDialogSpecialKey(ByRef Pch As Char)                ''~7515R~
        If swForm1 Then                                                     ''~7515R~
            Form1.MainForm.showSpecialKeyDialog()                               ''~7515R~''~7521R~
        Else                                                           ''~7515I~
            Form1.formText.showSpecialKeyDialog()                               ''~7515I~''~7521R~
        End If                                                         ''~7515I~
    End Sub                                                            ''~7515I~
    Public Sub setSpecialChar(Pstr As String)                          ''~7515R~
        Dim pos As Integer = TB.SelectionStart                           ''~7515I~
        Dim txt As String = TB.Text                                     ''~7515I~
        Dim len As Integer = TB.SelectionLength                           ''~7515I~
        If pos + len >= txt.Length Then                                  ''~7515I~
            txt = txt.Substring(0, pos) & Pstr                         ''~7515R~
        Else                                                           ''~7515I~
            txt = txt.Substring(0, pos) & Pstr & txt.Substring(pos + len) ''~7515R~
        End If                                                         ''~7515I~
        TBChanged(txt)                                                 ''~7515I~
        TB.Select(pos + Pstr.Length, 0)                                   ''~7523R~
        TB.Focus()                                                     ''~7523R~
    End Sub                                                            ''~7515I~
    Public Sub repWord(Prepword As String, PswRepAll As Boolean, PcaseRepAll As Integer)                             ''~7524I~''~7612R~
        Dim pos As Integer = TB.SelectionStart                         ''~7524I~
        Dim txt As String = TB.Text                                    ''~7524I~
        Dim len As Integer = TB.SelectionLength                        ''~7524I~
        txt = txt.Substring(0, pos) & Prepword & txt.Substring(pos + len) ''~7524I~
        If PswRepAll Then                                                   ''~7612I~
            TBChangedRepAll(txt, PcaseRepAll)                           ''~7612R~
            If PcaseRepAll = 2 Then 'last of all                             ''~7612I~
                TB.Select(pos, Prepword.Length)                        ''~7612I~
                TB.Focus()                                             ''~7612I~
            End If                                                     ''~7612I~
        Else                                                           ''~7612I~
            TBChanged(txt)                                                 ''~7524I~''~7612R~
            TB.Select(pos, Prepword.Length)                                     ''~7524I~''~7612I~
            TB.Focus()                                                     ''~7524I~''~7612I~
        End If                                                         ''~7612I~
    End Sub                                                            ''~7524I~
    Public Function getLinePos(Ppos As Integer, ByRef Ppline As Integer, ByRef Pppos As Integer) As Boolean ''~7519R~
        Try                                                            ''~7519I~
            Dim line As Integer = TB.GetLineFromCharIndex(Ppos)          ''~7519I~
            Dim linetop As Integer = TB.GetFirstCharIndexFromLine(line)  ''~7519I~
            Dim posinline = Ppos - linetop                               ''~7519R~
            Ppline = line                                                ''~7519I~
            Pppos = posinline                                            ''~7519I~
            Return True                                                 ''~7519I~
        Catch ex As Exception                                          ''~7519I~
        End Try                                                        ''~7519I~
        Return False                                                   ''~7519I~
    End Function                                                            ''~7519I~
End Class
