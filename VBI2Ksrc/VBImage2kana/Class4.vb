''*CID:''+dateR~:#72                          update#=   11;          ''~7522R~
Public Class ClassMRU                                                  ''~7522R~
'localization not required                                             ''+7618R~
    Public Const MRULISTSZ = 10                                        ''~7522R~
    Private MRUList As New List(Of String)                         ''~7421R~''~7522M~
    Private MRUListImage As New List(Of String)                            ''~7411I~''~7421R~''~7522M~
    Private MRUListText As New List(Of String)                             ''~7411I~''~7421R~''~7522M~
    Private MRUListKanaText As New List(Of String)                         ''~7411I~''~7421R~''~7522M~
    Private MRUListBESText As New List(Of String)                          ''~7412I~''~7421R~''~7522M~
    Public Sub New()                                                   ''~7522I~
        '        loadMRUList()                                                  ''~7522M~
    End Sub                                                            ''~7522I~
    Public Function selectMRUList(Pcase As Integer) As List(Of String) ''~7522I~
        Select Case Pcase                                              ''~7411I~''~7522M~
            Case 1 'Image                                              ''~7411I~''~7522M~
                MRUList = MRUListImage                                   ''~7411I~''~7522M~
            Case 2 'KanjiText                                          ''~7411I~''~7522M~
                MRUList = MRUListText                                    ''~7411I~''~7522M~
            Case Else '3 'KanaText                                           ''~7411I~''~7522I~
                MRUList = MRUListKanaText                                ''~7411I~''~7522M~
        End Select                                                     ''~7411I~''~7522M~
        Return MRUList                                                 ''~7522I~
    End Function                                                            ''~7522M~
    Private Function deleteMRUList(Pfnm As String) As Boolean          ''~7522M~
        Try                                                            ''~7522M~
            If MRUList.Count = 0 Then                                  ''~7522M~
                Return False                                           ''~7522M~
            End If                                                     ''~7522M~
            If Pfnm.CompareTo(MRUList(0)) = 0 Then                     ''~7522M~
                Return True 'top of list no need to delete             ''~7522M~
            End If                                                     ''~7522M~
            MRUList.Remove(Pfnm)                                       ''~7522M~
        Catch ex As Exception                                          ''~7522M~
            MessageBox.Show(String.Format("deleteMRUList Exception Pfnm={0},MRUList.count={1}", Pfnm, MRUList.Count)) ''~7522M~
            Return False                                               ''~7522M~
        End Try                                                        ''~7522M~
        Return False                                                   ''~7522M~
    End Function                                                       ''~7522M~
    Private Sub saveMRUListCfg(Pcase As Integer, Pstr As String)        ''~7411I~''~7522M~
        Select Case Pcase                                              ''~7411I~''~7522M~
            Case 1 'Image                                              ''~7411I~''~7522M~
                My.Settings.CfgMRUImage = Pstr                           ''~7411I~''~7522M~
            Case 2 'KanjiText                                          ''~7411I~''~7522M~
                My.Settings.CfgMRUtext = Pstr                            ''~7411I~''~7522M~
            Case 3 'KanaText                                           ''~7411I~''~7522M~
                My.Settings.CfgMRUKanaText = Pstr                        ''~7411I~''~7522M~
        End Select                                                     ''~7411I~''~7522M~
    End Sub                                                            ''~7411I~''~7522M~
    Public Sub insertMRUList(Pcase As Integer, Pfnm As String)        ''~7411I~''~7429R~''~7522M~
        selectMRUList(Pcase)                                           ''~7411I~''~7522M~
        If deleteMRUList(Pfnm) Then  'already on top of list           ''~7411I~''~7522M~
            Exit Sub                                                   ''~7411I~''~7522M~
        End If                                                         ''~7411I~''~7522M~
        MRUList.Insert(0, Pfnm)                                        ''~7411I~''~7522M~
        '       If Debug Then                                                  ''~7411I~''~7522I~
        '           Console.WriteLine("add MRU={0}={1}", MRUList.Count, Pfnm)  ''~7411I~''~7522I~
        '       End If                                                         ''~7411I~''~7522I~
        '       setMRUListMenu(Pcase)                                          ''~7411I~''~7522I~
        '       Form1.MainForm.setMRUListMenu(Pcase)                           ''~7522I~
        '       saveMRUList(Pcase)                                             ''~7411I~''~7522I~
    End Sub                                                            ''~7411I~''~7522M~
    Public Sub loadMRUListSub(Pcase As Integer)                       ''~7522I~
        Dim str As String                                              ''~7522I~
        selectMRUList(Pcase)                                           ''~7522I~
        if Form1.TestOption=1                                          ''~7522I~
        	My.Settings.CfgMRUImage=""                                 ''~7522I~
            My.Settings.CfgMRUtext=""                                  ''~7522I~
            My.Settings.CfgMRUKanaText=""                              ''~7522I~
        end if                                                         ''~7522I~
        Select Case Pcase                                              ''~7522I~
            Case 1 'Image                                              ''~7522I~
                str = My.Settings.CfgMRUImage                            ''~7522I~
            Case 2 'KanjiText                                          ''~7522I~
                str = My.Settings.CfgMRUtext                             ''~7522I~
            Case Else '3 'KanaText                                     ''~7522I~
                str = My.Settings.CfgMRUKanaText                         ''~7522I~
        End Select                                                     ''~7522I~
        Dim fnmlist() As String = str.Split("|"c)                      ''~7522I~
        Dim ctrlist = fnmlist.Length()                                 ''~7522I~
        For ii As Integer = 0 To ctrlist - 1                           ''~7522I~
            Dim fnm As String = fnmlist(ii)                            ''~7522I~
            If (fnm.Length() > 0) Then                                 ''~7522I~
                MRUList.Add(fnm)                                       ''~7522I~
            End If                                                     ''~7522I~
        Next                                                           ''~7522I~
    End Sub                                                            ''~7522I~
    Public Sub saveMRUList(Pcase As Integer)                          ''~7411R~''~7522M~
        selectMRUList(Pcase)                                           ''~7411I~''~7522M~
        Dim sb = New System.Text.StringBuilder()                       ''~7522M~
        Dim ctr As Integer = 0                                         ''~7522M~
        Dim ctrlist As Integer = MRUList.Count                         ''~7522M~
        For ii As Integer = 0 To ctrlist - 1                           ''~7522M~
            Dim fnm As String = MRUList.Item(ii)                       ''~7522M~
            sb.Append(fnm & "|")                                       ''~7522M~
            ctr += 1                                                   ''~7522M~
            If ctr > MRULISTSZ Then                                    ''~7522R~
                Exit For                                               ''~7522M~
            End If                                                     ''~7522M~
        Next                                                           ''~7522M~
        Dim str = sb.ToString()                                        ''~7411R~''~7522M~
        saveMRUListCfg(Pcase, str)                                      ''~7411I~''~7522M~
    End Sub                                                            ''~7522M~
End Class
