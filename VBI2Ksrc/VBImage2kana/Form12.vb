'CID:''+v030R~:#72                             update#=   7;          ''~v030I~
'************************************************************************************''~v030I~
'v030 2017/09/21 new option dialog for each document                   ''~v030I~
'************************************************************************************''~v030I~
'*** Document option     **************                                ''~v030I~
Public Class DocOptions                                                ''~v030R~
    Public Shared swBES99 As Boolean                                   ''~v030I~
    Public Shared swKatakanaDoc As Boolean                             ''~v030I~
    Public Shared swEnglishDoc As Boolean                              ''~v030I~
    '****************************************************************      ''~v030I~
    Public Shared Sub showDlg(Pform3 As Form3)                         ''~v030R~
        '*** from Form3                                                    ''~v030I~
        Dim dlg As DocOptions = New DocOptions()                         ''~v030I~
        dlg.show()                                                     ''~v030I~
    End Sub                                                            ''~v030I~
    Sub New()                                                          ''~v030I~
        setLang()   'should set CurrentUICulture before InitializeComponent''~v030I~
        InitializeComponent()                                          ''~v030I~
        Form1.setupTitlebarIcon(Me)                                    ''~v030I~
        initByCFG()                                                    ''~v030I~
        showOptions()                                                  ''~v030I~
    End Sub                                                            ''~v030I~
    Private Sub setLang()                                              ''~v030I~
        FormOptions.setLang()                                          ''~v030I~
    End Sub                                                            ''~v030I~
    Public shared Sub initByCFG()                                      ''+v030R~
        swBES99 = My.Settings.CFGF12_swBES99                            ''~v030I~
        swKatakanaDoc = My.Settings.CFGF12_swKatakanaDoc                ''~v030I~
        swEnglishDoc = My.Settings.CFGF12_swEnglishDoc                 ''~v030I~
    End Sub                                                            ''~v030I~
    Private Sub saveCFG()                                              ''~v030I~
        My.Settings.CFGF12_swBES99 = swBES99                             ''~v030I~
        My.Settings.CFGF12_swKatakanaDoc = swKatakanaDoc                 ''~v030I~
        My.Settings.CFGF12_swEnglishDoc = swEnglishDoc                 ''~v030I~
    End Sub                                                            ''~v030I~
    Private Sub FormOptions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load ''~v030I~
        Me.ActiveControl = Me.ButtonOK    'set focus at Load time      ''~v030I~
    End Sub                                                            ''~v030I~
    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click ''~v030I~
        getOptions()  'also saveCFG                                    ''~v030I~
        Me.Close()                                                     ''~v030I~
    End Sub 'resize                                                    ''~v030I~
    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click ''~v030I~
        Me.Close()                                                     ''~v030I~
    End Sub                                                            ''~v030I~
    Private Sub ButtonHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHelp.Click ''~v030I~
        showHelp()                                                     ''~v030I~
    End Sub                                                            ''~v030I~
    Private Sub showOptions()                                          ''~v030I~
        CheckBoxBES99.Checked = swBES99                                ''~v030I~
        CheckBoxKatakanaDoc.Checked = swKatakanaDoc                    ''~v030I~
        CheckBoxEnglishDoc.Checked = swEnglishDoc                      ''~v030I~
    End Sub 'resize                                                    ''~v030I~
    Private Function getOptions() As Boolean                           ''~v030I~
        swBES99 = CheckBoxBES99.Checked                                ''~v030I~
        swKatakanaDoc = CheckBoxKatakanaDoc.Checked                    ''~v030I~
        swEnglishDoc = CheckBoxEnglishDoc.Checked                      ''~v030I~
        saveCFG()                                                      ''~v030I~
        Return True                                                    ''~v030I~
    End Function                                                       ''~v030I~
    Private Sub showHelp()                                             ''~v030I~
        Dim txt As String                                              ''~v030I~
        If FormOptions.swLangEN Then                                   ''~v030I~
            txt = My.Resources.help_form12E                            ''~v030I~
        Else                                                           ''~v030I~
            txt = My.Resources.help_form12                             ''~v030I~
        End If                                                         ''~v030I~
        MessageBox.Show(txt, Me.Text)                                  ''~v030I~
    End Sub                                                            ''~v030I~

End Class