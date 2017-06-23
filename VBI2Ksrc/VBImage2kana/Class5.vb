''*CID:''+dateR~:#72                          update#=   84;          ''~7618R~
Imports System.Runtime.InteropServices                                 ''~7522I~
Public Class ClassKanaText                                             ''~7522R~
    'localization done                                                     ''~7618I~
    '**Kanji-->Kana Conversion                                             ''~7525I~
    ''~7522I~
    Private Const FONTSIZE_INCREASE = 5                                        ''~7522I~''~7608R~
    Private Const FUSEJI_FOLLOWING = "まみむめもマミムメモﾏﾐﾑﾒﾓ"         ''~7608I~
    Private imageFilename As String = ""                               ''~7522I~
    Private textFilename As String = ""                                ''~7522I~
    Private formWidth As Integer = My.Settings.CfgFormSizeWKanaText    ''~7522I~
    Private formHeight As Integer = My.Settings.CfgFormSizeHKanaText   ''~7522I~
    Private fel As Object                                              ''~7522I~
    Private strKana As String                                          ''~7522I~
    Private undoRedo As ClassUndoRedo                                  ''~7522I~
    Public swViewKatakana As Boolean = False                           ''~7522I~
    '   Private dlgOptions As FormOptions                                  ''~7522I~''~7525R~
    Private fmtBES As FormatBES                                        ''~7522I~
    Private swSource As Integer = 0                                    ''~7522I~
    '   Private TB As TextBox '@@@@                                        ''~7522I~''~7618R~
    Private title As String                                            ''~7522I~
    Private swRead As Boolean = False                                    ''~7612I~
    Private repeatChars As Char() = FormatBES.STR_REPEAT.ToCharArray()  ''~7607I~
    Private swEnglishDoc As Boolean                                    ''~7619I~
    '   Private swChngByUndoRedo As Boolean                            ''~7522I~
    ''~7522I~
    Sub setText(PstrText As String, PswImage As Integer, Pfnm As String) ''~7522I~
        swRead = False                                                   ''~7612I~
        '       If PswImage = 1 Then                                           ''~7522I~''~7615R~
        '           title = "読取りかな変換=" & Pfnm                           ''~7522I~''~7615R~
        '       Else                                                           ''~7522I~''~7615R~
        '           title = "テキストかな変換=" & Pfnm                         ''~7522I~''~7615R~
        '       End If                                                         ''~7522I~''~7615R~
        title = Rstr.FORM1_TITLE_KANJI2KANA_FILE & Form1.TITLE_SEP & Pfnm ''~7615R~
        swSource = 1  'received                                        ''~7522I~
        textFilename = Pfnm                                            ''~7522I~
        swEnglishDoc = Form1.chkExt(Pfnm, Form1.FILTER_DEFAULT_ENGLISHTEXT) ''~7619R~
        If swEnglishDoc Then                                                ''~7619I~
            strKana = convEnglish(PstrText)                            ''~7618I~
        Else                                                           ''~7618I~
            fel = Activator.CreateInstance(Type.GetTypeFromProgID("MSIME.Japan")) ''~7522I~''~7618R~
            JPReverseConv.Main(1, fel, "")  'open                          ''~7522I~''~7618R~
            strKana = conv2Kana(PstrText)                                  ''~7522I~''~7618R~
            JPReverseConv.Main(3, fel, "")    'close                       ''~7522I~''~7618R~
        End If                                                         ''~7618I~
        showKanaText(strKana)                                          ''~7522I~
    End Sub                                                            ''~7522I~
    ''~7522I~
    Public Sub readText(Pfnm As String)                                ''~7522I~
        swSource = 0  'read file                                       ''~7522I~''~7612M~
        swRead = False                                                   ''~7612I~
        If Pfnm.compareTo("") = 0 Then                                        ''~7612I~
            Dim fnm As String = Form1.changeExt(Rstr.MENU_NEWTEXT_FILE, Form1.FILTER_DEFAULT_KANATEXT) ''~7612I~
            '       	title = "かなテキスト=" & fnm                              ''~7612R~''~7615R~
            title = Rstr.FORM1_TITLE_KANA_FILE & Form1.TITLE_SEP & fnm ''~7615R~
            textFilename = fnm                                         ''~7612I~
            showKanaText(vbCrlf)                                       ''~7612I~
        Else                                                           ''~7612I~
            '       	title = "かなテキスト=" & Pfnm                                 ''~7522I~''~7612R~''~7615R~
            title = Rstr.FORM1_TITLE_KANA_FILE & Form1.TITLE_SEP & Pfnm ''~7615R~
            textFilename = Pfnm                                            ''~7522I~''~7612I~
            If (Not (System.IO.File.Exists(textFilename))) Then            ''~7522I~''~7612R~
                Form1.NotFound(Pfnm)                                       ''~7522I~''~7612R~
                Exit Sub                                                   ''~7522I~''~7612R~
            End If                                                         ''~7522I~''~7612R~
            Try                                                            ''~7522I~''~7612R~
                Dim text As String = System.IO.File.ReadAllText(textFilename, System.Text.Encoding.Default) ''~7522I~''~7612R~
                showKanaText(text)                                         ''~7522I~''~7612R~
                swRead = True                                            ''~7612I~
            Catch ex As Exception                                          ''~7522I~''~7612R~
                Form1.ReadError(Pfnm, ex)                                  ''~7522I~''~7612R~
            End Try                                                        ''~7522I~''~7612R~
        End If                                                         ''~7612I~
    End Sub                                                            ''~7522I~
    ''~7522I~
    Private Sub showKanaText(Pstr As String)                           ''~7522I~
        undoRedo = Form1.MainForm.undoRedo                             ''~7522I~
        fmtBES = Form1.MainForm.fmtBES                                 ''~7522I~
        '       dlgOptions = Form1.MainForm.dlgOptions                         ''~7522I~''~7525R~
        '       undoRedo = New ClassUndoRedo(ClassUndoRedo.OPT_KANATEXT, TextBox1, ToolStripButtonUndo, ToolStripButtonRedo)''~7522I~
        '       swViewKatakana = dlgOptions.swKatakana                 ''~7522I~
        '        setkatakanaBtn()                                      ''~7522I~
        Form1.MainForm.receiveText(Pstr, title, swSource)              ''~7522I~
    End Sub                                                            ''~7522I~
    ''~7522I~
    Public Function chkDiscard(e As System.EventArgs) As Boolean       ''~7522I~
        ' from from3:kana button                                       ''~7522I~
        ' rc:true=continue process                                     ''~7522I~
        Dim rc As Boolean = True                                       ''~7522I~
        If IsNothing(undoRedo) Then      'file not found or read err            ''~7617I~''~7619R~
            Return True                                                ''~7617I~
        End If                                                         ''~7617I~
        If Not Form1.MainForm.TBBES.Enabled Then                            ''~7619I~
            Return True                                                ''~7619I~
        End If                                                         ''~7619I~
        If Not IsNothing(e) Then 'from form1,new read                  ''~7522I~
            rc = Form1.confirmDiscard(e, Form1.MainForm.Text)          ''~7522I~
        Else                     '                                     ''~7522I~
            If undoRedo.isUpdated() Then                               ''~7522I~
                '           rc = Form1.confirmDiscard(e, Me.Text)      ''~7522I~
                rc = Form1.confirmDiscard(e, Form1.MainForm.Text)      ''~7522I~
            End If                                                     ''~7522I~
        End If                                                         ''~7522I~
        If rc Then                                                     ''~7522I~
            undoRedo.resetForm1()                                      ''~7522I~
        End If                                                         ''~7522I~
        Return rc                                                      ''~7522I~
    End Function                                                       ''~7522I~
    Public Function chkDiscard()                                       ''~7522I~
        ' from Form1(read file)                                        ''~7522I~
        ' rc:true:continue process                                     ''~7522I~
        Return chkDiscard(Nothing)                                     ''~7522I~
    End Function                                                       ''~7522I~
    Public Sub save() 'from Form1                                      ''~7522I~
        If swSource = 1 Then    'from imagefile/kanjitext              ''~7522I~
            If Not Form1.confirmReceivedSave(textFilename) Then        ''~7522I~
                Exit Sub                                               ''~7522I~
            End If                                                     ''~7522I~
        End If                                                         ''~7522I~
        If Not swRead Then                                                  ''~7612I~
            If Not Form1.confirmNewText(textFilename) Then                  ''~7612R~
                Exit Sub                                               ''~7612I~
            End If                                                     ''~7612I~
        End If                                                         ''~7612I~
        saveFile(textFilename)                                         ''~7522I~
    End Sub                                                            ''~7522I~
    ''~7522I~
    Public Sub SaveAs() 'from Form1                                    ''~7522I~
        Dim dlg = Form1.MainForm.SaveFileDialog1                         ''~7522R~
        If dlg.ShowDialog() = DialogResult.OK Then                     ''~7522I~
            Dim fnm As String = dlg.FileName                           ''~7522I~
            saveFile(fnm)                                              ''~7522I~
        End If                                                         ''~7522I~
    End Sub                                                            ''~7522I~
    ''~7522I~
    Private Sub saveFile(Pfnm As String)                               ''~7522I~
        Dim txt As String                                              ''~7522I~
        txt = undoRedo.getTextToSave()                                 ''~7522I~
        Try                                                            ''~7522I~
            System.IO.File.WriteAllText(Pfnm, txt, System.Text.Encoding.Default) ''~7522I~
            Form1.MainForm.insertMRUList(3, Pfnm)                      ''~7522I~
            undoRedo.saved()                                           ''~7522I~
            '           MessageBox.Show(Pfnm & " を保存しました")                  ''~7522I~''~7618R~
            Form1.FileSaved(Pfnm)                                      ''~7618I~
        Catch ex As Exception                                          ''~7522I~
            Form1.WriteError(Pfnm, ex)                                 ''~7522I~
        End Try                                                        ''~7522I~
    End Sub                                                            ''~7522I~
    ''~7522I~
    ''~7522I~
    Function conv2Kana(Pfiletext As String) As String                  ''~7522I~
        Dim sb = New System.Text.StringBuilder()                       ''~7522I~
        Dim chars() As Char = Pfiletext.ToCharArray()                  ''~7522I~
        Dim charctr As Integer = chars.Length()                        ''~7522I~
        Dim ii As Integer = 0, wordctr As Integer = 0, cvctr As Integer = 0, poskanji As Integer = 0 ''~7522I~
        Dim kanastr As String                                          ''~7522I~
        Dim chcode As Integer                                          ''~7522I~''~7525R~
        Dim ch, chii, chiiprev As Char                                                 ''~7522I~''~7607R~
        Dim swkanji As Boolean = False                                 ''~7525R~
        Dim swprevkana As Boolean                                      ''~7525I~
        Dim swprevhiragana, swprevkatakana As Boolean                   ''~7608I~
        Dim nextpos As Integer                                         ''~7604R~
        Try                                                            ''~7522I~
            chii = Chr(&H0)                                              ''~7607I~
            Do While ii < charctr                                      ''~7522I~
                chiiprev = chii                                          ''~7607I~
                chii = chars(ii)                                        ''~7607I~
                If (ii + 1 < charctr) Then                             ''~7522I~
                    ch = getCharType(chii, chars(ii + 1))         ''~7522I~''~7607R~
                Else                                                   ''~7522I~
                    ch = getCharType(chii, Chr(&H0))              ''~7522I~''~7607R~
                End If                                                 ''~7522I~
                swprevhiragana = chcode = 2                            ''~7608R~
                swprevkatakana = chcode = 4                            ''~7608I~
                swprevkana = swprevhiragana OrElse swprevkatakana   'hiragana or katakana''~7608I~
                chcode = AscW(ch)                                      ''~7522I~
                '           If (debug) Then                            ''~7522I~
                '               stdout(String.Format("ch={0} chtype={1}", chii, chcode), 1)''~7522I~''~7607R~
                '           End If                                     ''~7522I~
                Select Case chcode                                     ''~7522I~
                    Case 1 'kanji                                      ''~7522I~
                        If swprevkana Then 'after hiragana''~7525R~    ''~7607R~
                            If swkanji Then 'after kanji+kana          ''~7607I~
                                kanastr = strConv(sb, Pfiletext.Substring(poskanji, cvctr)) ''~7522I~''~7525R~''~7605R~''~7607R~''~7608R~
                                sb.Append(kanastr)                         ''~7522I~''~7525R~''~7607R~
                                swkanji = False                            ''~7522I~''~7525R~''~7607R~
                            End If                                     ''~7608I~
                            If FormOptions.swWinBES99 Then             ''~7608I~
                                appendSpace(sb, 1)                      ''~7607I~''~7608R~
                            End If                                         ''~7522I~''~7525R~''~7607R~''~7608R~
                        End If                                         ''~7607I~
                        If (swkanji) Then                              ''~7522I~
                            cvctr += 1                                 ''~7522I~
                        Else                                           ''~7522I~
                            poskanji = ii                              ''~7522I~
                            cvctr = 1                                  ''~7522I~
                            swkanji = True                             ''~7522I~
                        End If                                         ''~7522I~
                    Case 3 'surrogate(ucs4) kanji                      ''~7522I~
                        '*** SJIS code point dose not correspond to any surrogate-pair char ***''~7608I~
                        '*** Shift_JIS-2004 code point has corresponding surrogate-pair char,but it is not Windows SJIS ***''~7608I~
                        If swprevkana Then 'after hiragana             ''~7607I~
                            If swkanji Then 'after kanji+kana          ''~7607I~
                                kanastr = strConv(sb, Pfiletext.Substring(poskanji, cvctr)) ''~7522I~''~7525R~''~7605R~''~7607R~''~7608R~
                                sb.Append(kanastr)                         ''~7522I~''~7525R~''~7607R~
                                swkanji = False                            ''~7522I~''~7525R~''~7607R~
                            End If                                     ''~7608R~
                            If FormOptions.swWinBES99 Then             ''~7608I~
                                appendSpace(sb, 1)                      ''~7607I~
                            End If                                     ''~7607I~
                        End If                                         ''~7522I~''~7525R~
                        If (swkanji) Then                              ''~7522I~
                            cvctr += 2                                 ''~7522I~
                        Else                                           ''~7522I~
                            poskanji = ii                              ''~7522I~
                            cvctr = 2                                  ''~7522I~
                            swkanji = True                             ''~7522I~
                        End If                                         ''~7522I~
                        ii += 1                                        ''~7522I~
                    Case 2  'hiraganaOkurigana                         ''~7522I~
                        chii = chkRepeatKana(chii, chiiprev)              ''~7607I~
                        If swprevkatakana AndAlso FormOptions.swWinBES99 Then ''~7608R~
                            If (swkanji) Then                          ''~7608I~
                                kanastr = strConv(sb, Pfiletext.Substring(poskanji, cvctr)) ''~7608I~
                                sb.Append(kanastr)                     ''~7608I~
                                swkanji = False                        ''~7608I~
                            End If                                     ''~7608I~
                            appendSpace(sb, 1)                          ''~7608I~
                            sb.Append(chii)                            ''~7608I~
                        Else                                           ''~7608I~
                            If (swkanji) Then                              ''~7522I~''~7608R~
                                cvctr += 1                                 ''~7522I~''~7608R~
                            Else                                           ''~7522I~''~7608R~
                                sb.Append(chii)                       ''~7522I~''~7607R~''~7608R~
                            End If                                         ''~7522I~''~7608R~
                        End If                                         ''~7608I~
                    Case 4  'katakana                                  ''~7525I~
                        chii = chkRepeatKana(chii, chiiprev)              ''~7607I~
                        If swprevhiragana AndAlso FormOptions.swWinBES99 Then ''~7608R~
                            If (swkanji) Then                          ''~7608I~
                                kanastr = strConv(sb, Pfiletext.Substring(poskanji, cvctr)) ''~7608I~
                                sb.Append(kanastr)                     ''~7608I~
                                swkanji = False                        ''~7608I~
                            End If                                     ''~7608I~
                            appendSpace(sb, 1)                          ''~7608I~
                            sb.Append(chii)                            ''~7608I~
                        Else                                           ''~7608I~
                            If (swkanji) Then                              ''~7525I~''~7608R~
                                cvctr += 1                                 ''~7525I~''~7608R~
                            Else                                           ''~7525I~''~7608R~
                                sb.Append(chii)                       ''~7525I~''~7607R~''~7608R~
                            End If                                         ''~7525I~''~7608R~
                        End If                                         ''~7608I~
                    Case Else                                          ''~7522I~
                        If (swkanji) Then                              ''~7522I~
                            kanastr = strConv(sb, Pfiletext.Substring(poskanji, cvctr)) ''~7522I~''~7605R~''~7607R~''~7608R~
                            sb.Append(kanastr)                         ''~7522I~
                        End If                                         ''~7522I~
                        If (chcode = 0) Then                           ''~7522I~
                            If chkBES99Style(chars, ii, sb, nextpos) Then ''~7604R~
                                ii = nextpos                             ''~7604I~
                            Else                                       ''~7604I~
                                Dim asc As Integer = AscW(chii)       ''~7522I~''~7604R~''~7607R~
                                If (asc >= 32) Then                        ''~7522I~''~7604R~
                                    sb.Append(chii)                   ''~7522I~''~7604R~''~7607R~
                                ElseIf asc = 13 OrElse asc = 10 OrElse asc = 9 Then '0d0a,tab''~7522I~''~7604R~
                                    sb.Append(chii)                   ''~7522I~''~7604R~''~7607R~
                                End If                                     ''~7411R~)''~7522I~''~7604R~
                            End If                                     ''~7411R~)''~7604I~
                        Else                                           ''~7522I~
                            sb.Append(ch)                              ''~7522I~
                        End If                                         ''~7522I~
                        ''~7522I~
                        swkanji = False                                ''~7522I~
                        '                       swkana = False                                 ''~7522I~''~7525R~
                        poskanji = 0                                   ''~7522I~
                        cvctr = 0                                      ''~7522I~
                End Select                                             ''~7522I~
                ii += 1                                                ''~7522I~
            Loop                                                       ''~7522I~
        Catch ex As Exception                                          ''~7522I~
            '           MessageBox.Show(String.Format("かな/カナ変換に失敗 Source={0},stack={1}", ex.Source, ex.StackTrace.ToString())) ''~7522I~''~7618R~
            MessageBox.Show(String.Format("Source={0},stack={1}", ex.Source, ex.StackTrace.ToString()), Rstr.MSG_ERR_FAILED_KANJI2KANA_CONV) ''~7618I~
            Return ""                                                  ''~7522I~
        End Try                                                        ''~7522I~
        Return sb.ToString()                                       ''~7522I~''~7618I~
    End Function                                                       ''~7522I~
    Function convEnglish(Pfiletext As String) As String                ''~7618I~
#if false                                                              ''+7619I~
        Dim chars() As Char = Pfiletext.ToCharArray()                  ''~7618I~
        Dim charctr As Integer = chars.Length()                        ''~7618I~
        Dim sb = New System.Text.StringBuilder(charctr * 2)              ''~7618I~
        Dim chii, chnext As Char                                 ''~7618I~
        Dim ii As Integer = 0                                          ''~7618I~
        Do While ii < charctr                                      ''~7618I~
            chii = chars(ii)                                       ''~7618I~
            If (ii + 1 < charctr) Then                             ''~7618I~
                chnext = chars(ii + 1)                             ''~7618I~
            Else                                                   ''~7618I~
                chnext = Chr(&H0)                                    ''~7618I~
            End If                                                 ''~7618I~
            sb.Append(chii)                                          ''~7618I~
            Select Case chii                                       ''~7618I~
                Case "."c, ","c                                            ''~7618R~
                    If chnext <> " "c Then                                      ''~7618R~
                        appendSpaceSBCS(sb, 1)                             ''~7618R~
                    End If                                                 ''~7618R~
            End Select                                             ''~7618I~
            ii += 1                                                ''~7618I~
        Loop                                                       ''~7618I~
        Return sb.ToString()                                           ''~7618I~
#else                                                                  ''+7619I~
		Return Pfiletext                                               ''+7619I~
#end if                                                                ''+7619I~
    End Function                                                       ''~7618I~
    ''~7522I~
    Function getCharType(Pchar As Char, Pchar2 As Char) As Char        ''~7522I~
        'rc 2:hiraganaOkurigana,1:kanji-ucs2,3:kanji-ucs4,4:katakana,0:no conversion,else converted to char''~7522I~''~7525R~
        Dim chtype As Integer = 0                                      ''~7522I~
        ''~7522I~
        If (isHiraganaOkurigana(Pchar)) Then 'hiragana                 ''~7522I~
            Return Chr(&H2) ' hiragana                                 ''~7522I~
        End If                                                         ''~7522I~
        If (isKatakana(Pchar)) Then 'hiragana                          ''~7525I~
            Return Chr(&H4) ' hiragana                                 ''~7525I~
        End If                                                         ''~7525I~
        If (Char.IsHighSurrogate(Pchar)) Then 'surrogate high          ''~7522I~
            If (isKanji4(Pchar, Pchar2)) Then                          ''~7522I~
                Return Chr(&H3) 'surrogate kanji                       ''~7522I~
            End If                                                     ''~7522I~
        End If                                                         ''~7522I~
        If (isKanji2(Pchar)) Then 'kanji                               ''~7522I~
            Return Chr(&H1) 'kanji                                     ''~7522I~
        End If                                                         ''~7522I~
        Return Chr(&H0)                                                ''~7522I~
    End Function                                                       ''~7522I~
    ''~7522I~
    Function strConv(Psb As System.Text.StringBuilder, Pstr As String) As String ''~7605R~''~7607R~''~7608R~
        Dim kanastr, kanjistr As String                                          ''~7522I~''~7607R~
        kanjistr = chkRepeatKanji(Pstr)                                  ''~7607I~
        kanastr = JPReverseConv.Main(2, fel, kanjistr) 'conv               ''~7522I~''~7607R~
#If False Then                                                         ''~7608I~
        If FormOptions.swWinBES99 Then                                ''~7525I~''~7604R~
#If False Then                                                              ''~7607I~
            If Psb.length = 0 Then                                            ''~7605I~
                Return kanastr                                         ''~7605I~
            End If                                                     ''~7605I~
            Dim chars(2) As Char                                       ''~7605I~
            Psb.copyTo(Psb.Length - 1, chars, 0, 1)                         ''~7605I~
            If chars(0) = FormatBES.CHAR_SPACE Then                            ''~7605I~
                Return kanastr                                         ''~7605I~
            End If                                                     ''~7605I~
            Return FormatBES.CHAR_SPACE & kanastr                      ''~7525I~
#Else                                                                  ''~7607I~
            If (Pswnextkanji) Then                                          ''~7607I~
                kanastr = kanastr & FormatBES.CHAR_SPACE                 ''~7607R~
            End If                                                     ''~7607I~
#End If                                                                ''~7607I~
        End If                                                         ''~7525I~
#End If                                                                ''~7608I~
        Return kanastr                                                 ''~7522I~
    End Function                                                       ''~7522I~
    Function chkRepeatKanji(Pstr As String) As String                  ''~7607I~
#If False Then                                                              ''~7608I~
        If Not FormOptions.swWinBES99 Then                             ''~7608I~
        	return Pstr                                                ''~7608I~
        end if                                                         ''~7608I~
        Dim pos1 As Integer                                            ''~7607I~
        Dim chRepeat As Char                                           ''~7607I~
        Dim strRepeat, strBefore, strAfter As String                     ''~7607I~
        pos1 = Pstr.IndexOf(repeatChars(FormatBES.STR_REPEAT_INDEX_KANJI))                              ''~7607I~''~7608R~
        If pos1 <= 0 Then     'will not starting char                         ''~7607I~
            Return Pstr                                                ''~7607I~
        End If                                                         ''~7607I~
        chRepeat = Pstr.Chars(pos1 - 1)                                    ''~7607I~
        strBefore = Pstr.substring(0, pos1)                            ''~7607R~
        strAfter = Pstr.substring(pos1 + 1)                                ''~7607I~
        strRepeat = strBefore & chRepeat & strAfter
        Return strRepeat ''~7607I~
#Else                                                                  ''~7608I~
        Return Pstr 'MicroSoft supports kanji odoriji                  ''~7608I~
#End If                                                                ''~7608I~
    End Function                                                       ''~7607I~
    Function chkRepeatKana(Pch As Char, PchPrev As Char) As Char        ''~7607R~
        If Not FormOptions.swWinBES99 Then                             ''~7608I~
            Return Pch                                                 ''~7608I~
        End If                                                         ''~7608I~
        Dim pos2, pos3 As Integer                                       ''~7607R~
        Dim cvch As Char                                               ''~7607I~
        cvch = Pch                                                       ''~7607I~
        pos2 = FormatBES.STR_REPEAT.indexOf(Pch)                       ''~7607R~
        Select Case pos2                                               ''~7607I~
            Case FormatBES.STR_REPEAT_INDEX_HIRAGANA            'U309d hira                                ''~7607I~''~7608R~
                cvch = PchPrev                                           ''~7607R~
            Case FormatBES.STR_REPEAT_INDEX_HIRAGANA_DAKUON              'U309d hira dakuon                         ''~7607I~''~7608R~
                pos3 = FormatBES.STR_DAKUON_SRC.IndexOf(PchPrev)       ''~7607R~
                If pos3 >= 0 Then                                                 ''~7607I~
                    cvch = FormatBES.STR_DAKUON_TGT.Chars(pos3)          ''~7607R~
                End If                                                     ''~7607I~
            Case FormatBES.STR_REPEAT_INDEX_KATAKANA              'U309d kata                                ''~7607I~''~7608R~
                cvch = PchPrev                                           ''~7607I~
            Case FormatBES.STR_REPEAT_INDEX_KATAKANA_DAKUON             'U309d kata dakuon                         ''~7607I~''~7608R~
                pos3 = FormatBES.STR_DAKUON_SRC_KATAKANA.IndexOf(PchPrev) ''~7607R~
                If pos3 >= 0 Then                                                 ''~7607I~
                    cvch = FormatBES.STR_DAKUON_TGT_KATAKANA.Chars(pos3) ''~7607R~
                End If                                                     ''~7607I~
        End Select                                                     ''~7607I~
        Return cvch                                                    ''~7607R~
    End Function                                                       ''~7607I~
    ''~7522I~
    Function isHiraganaOkurigana(ByVal c As Char) As Boolean           ''~7522I~
        If c = repeatChars(FormatBES.STR_REPEAT_INDEX_HIRAGANA) OrElse c = repeatChars(FormatBES.STR_REPEAT_INDEX_HIRAGANA_DAKUON) Then                    ''~7607I~''~7608R~
            Return True                                                ''~7607I~
        End If                                                         ''~7607I~
        '「ぁ」(u-3041)～「ゖ」(u-3096)まで、conv with kanji                           ''~7522I~''~7525R~
        Return (ChrW(&H3041) <= c AndAlso c <= ChrW(&H3096))           ''~7522I~
    End Function                                                       ''~7522I~
    Function isKatakana(ByVal Pch As Char) As Boolean                  ''~7525R~
        If Pch = repeatChars(FormatBES.STR_REPEAT_INDEX_KATAKANA) OrElse Pch = repeatChars(FormatBES.STR_REPEAT_INDEX_KATAKANA_DAKUON) Then                    ''~7607I~''~7608R~
            Return True                                                ''~7607I~
        End If                                                         ''~7607I~
        '「ァ」(u030a1)～「ヶ」(u-30f6)まで、conv with kanji           ''~7525R~
        If ChrW(&H30A1) <= Pch AndAlso Pch <= ChrW(&H30F6) Then          ''~7525R~Pch
            Return True
        End If ''~7525I~
        '「ｦ」(uff66) ～「ﾟ」(u-ff9f)まで、conv with kanji             ''~7525I~''~7604R~
        If (ChrW(&HFF66) <= Pch AndAlso Pch <= ChrW(&HFF9F)) Then           ''~7525I~
            Return True
        End If ''~7525I~
        Return False                                                   ''~7525I~
    End Function                                                       ''~7525I~
    Function isKanji2(ByVal c As Char) As Boolean                      ''~7522I~
        'CJK統合漢字、CJK互換漢字、CJK統合漢字拡張Aの範囲にあるか調べる''~7522I~
        Return (ChrW(&H4E00) <= c AndAlso c <= ChrW(&H9FCF)) OrElse _
            (ChrW(&HF900) <= c AndAlso c <= ChrW(&HFAFF)) OrElse _
            (ChrW(&H3300) <= c AndAlso c <= ChrW(&H33FF)) OrElse _
            (ChrW(&H3400) <= c AndAlso c <= ChrW(&H4DBF)) OrElse _
            (ChrW(&H3005) = c)          'odoriji
    End Function                                                       ''~7522I~
    Function isKanji4(ByVal c1 As Char, ByVal c2 As Char) As Boolean   ''~7522I~
        'CJK統合漢字拡張Bの範囲にあるか調べるH20000-H2A6DF             ''~7522I~
        Return ((ChrW(&HD840) <= c1 AndAlso c1 <= ChrW(&HD868)) AndAlso _
                Char.IsLowSurrogate(c2)) OrElse _
            (c1 = ChrW(&HD869) AndAlso (ChrW(&HDC00) <= c2 AndAlso c2 <= ChrW(&HDEDF))) ''~7522I~
    End Function                                                       ''~7522I~
    Private Function chkBES99Style(Pcharray As Char(), Ppos As Integer, Psb As System.Text.StringBuilder, ByRef Ppnextpos As Integer) As Boolean ''~7604I~
        Dim ch As Char = Pcharray(Ppos)                                  ''~7604I~
        Dim ctr As Integer                                             ''~7604I~
        If Not FormOptions.swWinBES99 Then                             ''~7604I~
            Return False                                               ''~7604I~
        End If                                                         ''~7604I~
        If ch = FormatBES.CHAR_KUTEN OrElse ch = FormatBES.CHAR_KUTEN_HANKANA Then ''~7604I~
            Psb.Append(FormatBES.CHAR_KUTEN)                           ''~7605I~
            ctr = getSpaceCtrForKuten(Pcharray, Ppos, 2)                   ''~7604I~
            Ppnextpos = Ppos + ctr                                       ''~7604R~
            appendSpace(Psb, 2)                                         ''~7604I~
            Return True                                               ''~7604R~
        End If                                                         ''~7604I~
        If ch = FormatBES.CHAR_TOUTEN OrElse ch = FormatBES.CHAR_TOUTEN_HANKANA Then ''~7604I~
            Psb.Append(FormatBES.CHAR_TOUTEN)                          ''~7605I~
            ctr = getSpaceCtrForKuten(Pcharray, Ppos, 1)                   ''~7604I~
            Ppnextpos = Ppos + ctr                                       ''~7604R~
            appendSpace(Psb, 1)                                         ''~7604I~
            Return True                                                ''~7604R~
        End If                                                         ''~7604I~
        If ch = FormatBES.CHAR_CHUTEN OrElse ch = FormatBES.CHAR_CHUTEN_HANKANA Then ''~7605I~
            If isCont3Chuten(Pcharray, Ppos) Then                            ''~7608I~
                Psb.Append(FormatBES.CHAR_CHUTEN)                      ''~7608I~
                Psb.Append(FormatBES.CHAR_CHUTEN)                      ''~7608I~
                Psb.Append(FormatBES.CHAR_CHUTEN)                      ''~7608I~
                Ppnextpos = Ppos + 3                                   ''~7608I~
                '#if false                                                              ''~7608I~''~7610R~
            ElseIf isFuseji(Pcharray, Ppos) Then                             ''~7608I~
                Psb.Append(FormatBES.CHAR_CHUTEN)                      ''~7608I~
                '#end if                                                                ''~7608I~''~7610R~
            Else                                                       ''~7608I~
                Psb.Append(FormatBES.CHAR_CHUTEN)                          ''~7605I~''~7608R~
                ctr = getSpaceCtrForKuten(Pcharray, Ppos, 1)               ''~7605I~''~7608R~
                Ppnextpos = Ppos + ctr                                       ''~7605I~''~7608R~
                appendSpace(Psb, 1)                                        ''~7605I~''~7608R~
            End If                                                     ''~7608I~
            Return True                                                ''~7605I~
        End If                                                         ''~7605I~
        If ch = FormatBES.CHAR_EXCLAMATION OrElse ch = FormatBES.CHAR_EXCLAMATION_ASCII Then ''~7605I~
            Psb.Append(FormatBES.CHAR_EXCLAMATION)                     ''~7605I~
            ctr = getSpaceCtrForKuten(Pcharray, Ppos, 1)               ''~7605I~
            Ppnextpos = Ppos + ctr                                     ''~7605I~
            appendSpace(Psb, 1)                                        ''~7605I~
            Return True                                                ''~7605I~
        End If                                                         ''~7605I~
        If ch = FormatBES.CHAR_QUESTION OrElse ch = FormatBES.CHAR_QUESTION_ASCII Then ''~7605I~
            Psb.Append(FormatBES.CHAR_QUESTION)                        ''~7605I~
            ctr = getSpaceCtrForKuten(Pcharray, Ppos, 1)               ''~7605I~
            Ppnextpos = Ppos + ctr                                     ''~7605I~
            appendSpace(Psb, 1)                                        ''~7605I~
            Return True                                                ''~7605I~
        End If                                                         ''~7605I~
        Return False                                                   ''~7604R~
    End Function                                                       ''~7604I~
    Private Function isCont3Chuten(Pcharray As Char(), Ppos As Integer) As Boolean ''~7608I~
        'chk 3 continued chuten	                                           ''~7608I~
        If Ppos + 3 > Pcharray.Length Then                                      ''~7608I~
            Return False                                               ''~7608I~
        End If                                                         ''~7608I~
        Dim ch = Pcharray(Ppos + 1)                                        ''~7608I~
        If ch = FormatBES.CHAR_CHUTEN OrElse ch = FormatBES.CHAR_CHUTEN_HANKANA Then ''~7608I~
            ch = Pcharray(Ppos + 2)                                        ''~7608I~
            If ch = FormatBES.CHAR_CHUTEN OrElse ch = FormatBES.CHAR_CHUTEN_HANKANA Then ''~7608I~
                Return True                                            ''~7608I~
            End If                                                     ''~7608I~
        End If                                                         ''~7608I~
        Return False                                                   ''~7608I~
    End Function                                                       ''~7608I~
    '#if false                                                              ''~7608I~''~7610R~
    Private Function isFuseji(Pcharray As Char(), Ppos As Integer) As Boolean ''~7608I~
        'chk chuten is preceding of fuseji                                 ''~7608I~
        If Ppos + 1 > Pcharray.Length Then                                      ''~7608I~
            Return False                                               ''~7608I~
        End If                                                         ''~7608I~
        Dim ch = Pcharray(Ppos + 1)                                        ''~7608I~
        If FUSEJI_FOLLOWING.IndexOf(ch) >= 0 Then                             ''~7608I~
            Return True                                                ''~7608I~
        End If                                                         ''~7608I~
        Return False                                                   ''~7608I~
    End Function                                                       ''~7608I~
    '#end if                                                                ''~7608I~''~7610R~
    Private Function getSpaceCtrForKuten(Pcharray As Char(), Ppos As Integer, Pmax As Integer) As Integer ''~7604I~
        Dim ctr As Integer = 0                                           ''~7604I~
        Dim ch As Char                                                 ''~7604I~
        For ii As Integer = Ppos + 1 To Pcharray.Length - 1                                       ''~7604I~
            ch = Pcharray(ii)                                            ''~7604I~
            If ch <> FormatBES.CHAR_SPACE AndAlso ch <> FormatBES.CHAR_SPACE_SBCS Then ''~7604I~
                Exit For                                               ''~7604I~
            End If                                                     ''~7604I~
            ctr += 1                                                     ''~7604I~
            If ctr = Pmax Then                                                ''~7604I~
                Exit For                                               ''~7604I~
            End If                                                     ''~7604I~
        Next                                                           ''~7604I~
        Return ctr                                                     ''~7604I~
    End Function                                                       ''~7604I~
    Private Sub appendSpace(Psb As System.Text.StringBuilder, Pctr As Integer) ''~7604I~
        For ii As Integer = 0 To Pctr - 1                                  ''~7604I~
            Psb.Append(FormatBES.CHAR_SPACE)                           ''~7604I~
        Next                                                           ''~7604I~
    End Sub                                                            ''~7604I~
    Private Sub appendSpaceSBCS(Psb As System.Text.StringBuilder, Pctr As Integer) ''~7618I~
        For ii As Integer = 0 To Pctr - 1                              ''~7618I~
            Psb.Append(FormatBES.CHAR_SPACE_SBCS)                      ''~7618I~
        Next                                                           ''~7618I~
    End Sub                                                            ''~7618I~
    '**********************************************                    ''~7522I~
    <ComImport()>
    <Guid("019F7152-E6DB-11D0-83C3-00C04FDDB82E")>
    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
    Private Interface IFELanguage
        Sub Open()
        Sub Close()
        Sub Dummy5()
        ' DO NOT CALL                                                  
        Sub Dummy6()
        ' DO NOT CALL                                                  
        Function GetPhonetic(<MarshalAs(UnmanagedType.BStr)> str As String, start As Integer, length As Integer) As <MarshalAs(UnmanagedType.BStr)> String
        Sub Dummy8()
        ' DO NOT CALL
    End Interface
    Class JPReverseConv
        Public Shared Function Main(Pcase As Integer, Pfel As Object, args As String)
            Dim str As String = ""
            Dim fel = TryCast(Pfel, IFELanguage)
            Select Case Pcase
                Case 1
                    fel.Open()
                Case 2
                    str = fel.GetPhonetic(args, 1, -1)
                Case 3
                    fel.Close()
            End Select
            Return str
        End Function
    End Class
    '**********************************************                   
    Private Sub TBChanged()                                            ''~7522I~
        undoRedo.TBChanged()                                           ''~7522I~
    End Sub                                                            ''~7522I~
    Private Sub TBChanged(Ptext As String)                             ''~7522I~
        undoRedo.TBChanged(Ptext)                                      ''~7522I~
    End Sub                                                            ''~7522I~
    Private Sub TBChanged(Ptext As String, Pswchnghirakata As Boolean) ''~7522I~
        undoRedo.TBChanged(Ptext, Pswchnghirakata) 'reverse swViewKatakana when undo''~7522I~
    End Sub                                                            ''~7522I~
    Public Sub setHirakata(Pswchngkatahira As Boolean)                 ''~7522I~
        'from undroredo                                                ''~7522I~
        If Pswchngkatahira Then                                        ''~7522I~
            '           chngkatakanaSW()    'swap                      ''~7522I~
        End If                                                         ''~7522I~
    End Sub                                                            ''~7522I~
End Class
