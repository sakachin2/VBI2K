'CID:''+v008R~:#72                             update#=   13;         ''~v008I~
'************************************************************************************''~v008I~
'v008 2017/09/12 dictionary support                                    ''~v008I~
'************************************************************************************''~v008I~
'*** Discarded by Form11 **************                                ''+v008I~
Public Class Form10                                                    ''~v008R~
    Public strKanji, strKana As String                                  ''~v008R~
    Sub New()                                                          ''~v008I~
        initDlg()                                                      ''~v008I~
    End Sub                                                            ''~v008I~
    Private Sub initDlg()                                              ''~v008I~
        setLang()   'should set CurrentUICulture before InitializeComponent''~v008I~
        InitializeComponent()                                          ''~v008I~
        Form1.setupTitlebarIcon(Me)                                    ''~v008I~
    End Sub                                                            ''~v008I~
    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click ''~v008I~
        Dim str1 As String = TextBoxKanji.Text                         ''~v008I~
        Dim str2 As String = TextBoxKana.Text                          ''~v008I~
        Me.DialogResult = DialogResult.None                            ''~v008I~
        If Not chkInput(str1, str2) Then                                     ''~v008I~
            Exit Sub                                                   ''~v008I~
        End If                                                         ''~v008I~
        strKanji = str1                                                ''~v008I~
        strKana = str2                                                 ''~v008I~
        Me.DialogResult = DialogResult.OK                              ''~v008I~
        Me.Close()                                                     ''~v008I~
    End Sub 'resize                                                    ''~v008I~
    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click ''~v008R~
        Me.DialogResult = DialogResult.CANCEL                          ''~v008I~
        Me.Close()                                                     ''~v008I~
    End Sub                                                            ''~v008I~
    Private Sub ButtonHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp.Click ''~v008I~
        showHelp()                                                     ''~v008I~
    End Sub                                                            ''~v008I~
    Private Sub showHelp()                                             ''~v008I~
        Dim txt As String                                              ''~v008I~
        If FormOptions.swLangEN Then                                   ''~v008I~
            txt = My.Resources.help_form10E                            ''~v008I~
        Else                                                           ''~v008I~
            txt = My.Resources.help_form10                             ''~v008I~
        End If                                                         ''~v008I~
        MessageBox.Show(txt, Me.Text)                                  ''~v008I~
    End Sub                                                            ''~v008I~
    Private Sub setLang()                                              ''~v008I~
        FormOptions.setLang()                                          ''~v008I~
    End Sub                                                            ''~v008I~
    Private Function chkInput(Pkanji As String, Pkana As String) As Boolean ''~v008I~
        If Pkanji.CompareTo("") = 0 OrElse Pkana.CompareTo("") = 0 Then    ''~v008R~
            Return errmsg(1)                                           ''~v008I~
        End If                                                         ''~v008I~
        Return True                                                   ''~v008I~
    End Function                                                       ''~v008I~
    Private Function errmsg(Perrno As Integer) As Boolean              ''~v008I~
        MessageBox.Show(Rstr.getStr("STR_MSG_ERR_ADDDICTIONARY"), Me.Text) ''~v008R~
        Return False                                                   ''~v008I~
    End Function                                                       ''~v008I~
End Class