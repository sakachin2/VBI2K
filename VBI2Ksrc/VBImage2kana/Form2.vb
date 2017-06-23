'CID:''+dateR~:#72                             update#=  146;         ''+7619R~
Public Class Form2
    'localize done                                                         ''~7617I~
    Const SCROLLBAR_MARGIN = 0                                            ''~7408R~
    Const SCALELIMIT_LOW = 100     'smallest pixcell                  ''~7408I~
    Private formWidth As Integer = My.Settings.CfgFormSizeWImage            ''~7411I~''~7430R~
    Private formHeight As Integer = My.Settings.CfgFormSizeHImage           ''~7411I~''~7430R~
    ''~7411I~
    Private bitmapZoom As Bitmap                                           ''~7409I~''~7430R~
    Private imageFilename As String = ""                               ''~7430R~
    Private image As System.Drawing.Image                              ''~7430R~
    Private imageH As Integer, imageW As Integer                       ''~7430R~
    Private imageHorg As Integer, imageWorg As Integer                 ''~7430R~
    Private posPanelY As Integer                                           ''~7409R~''~7430R~
    Private borderSize As Integer '= 0 ' SystemInformation.FrameBorderSize.Height''~7409R~''~7430R~
    Private captionHeight As Integer = SystemInformation.CaptionHeight     ''~7408R~''~7430R~
    Private resizeBeginW, resizeBeginH As Integer                           ''~7407I~''~7430R~
    Private scaleNew As Double = 1.0                                   ''~7430R~
    Private scaleRate As Double = 0.1      ' 10%                       ''~7430R~
    Private scrollbarH As Integer = SystemInformation.HorizontalScrollBarHeight ''~7430R~
    Private scrollbarW As Integer = SystemInformation.VerticalScrollBarWidth ''~7430R~
    Private Debug As Boolean = True                                    ''~7430R~
    Private rotation As Integer = 0                                          ''~7409I~''~7430R~
    Private titlePrefix As String = ""                                   ''~7613R~
    Private Shared extractingEnglishDoc As Boolean = False               ''~7618I~
    '************************************************
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load''~7619R~
        '       called at show                                                 ''~7408R~
        Form1.setupTitlebarIcon(Me)                                    ''~7612I~
        setLocale(False)                                                    ''~7613I~''~7619R~
        titlePrefix = Me.Text                                            ''~7613R~
        Me.Text = titlePrefix & " : " & imageFilename                  ''~7613R~
    End Sub
    Private Sub Form2_Shown(sender As System.Object, e As System.EventArgs) Handles Me.Shown''~7619I~
        Me.Width = formWidth                                           ''~7619I~
        Me.Height = formHeight                                         ''~7619I~
    End Sub                                                            ''~7619I~
    Private Sub Form1_Disposed(sender As System.Object, e As System.EventArgs) Handles Me.Disposed ''~7428I~
        If Not isNothing(image) Then                                        ''~7428I~
            image.dispose()                                            ''~7428R~
        End If                                                          ''~7428I~
        disposePictureBox()                                            ''~7513I~
    End Sub                                                            ''~7428I~
    Private Function CreateImage(Pfnm As String) As Boolean 'for sharing vioration at readtext caused by Image.FromFile''~7428I~
        '       image = System.Drawing.Image.FromFile(imageFilename)           ''~7428I~
        Dim rc As Boolean = False                                        ''~7428I~
        If (Not (System.IO.File.Exists(Pfnm))) Then                    ''~7428I~
            Form1.NotFound(Pfnm)                                             ''~7428I~
            Return False                                               ''~7428I~
        End If                                                         ''~7428I~
        Try                                                            ''~7428I~
            Dim fs As New System.IO.FileStream(imageFilename, System.IO.FileMode.Open, System.IO.FileAccess.Read) ''~7428I~
            image = System.Drawing.Image.FromStream(fs)                 ''~7428I~
            fs.Close()                                                 ''~7428I~
            rc = True                                                    ''~7428I~
        Catch ex As Exception                                          ''~7428I~
            '           MessageBox.Show("イメージファイル（" & Pfnm & "）からのテキスト読み取り失敗:" & ex.Message) ''~7428I~''~7617R~
            Form1.ReadError(Pfnm, ex)                                   ''~7617I~
        End Try                                                        ''~7428I~
        Return rc                                                      ''~7428I~
    End Function                                                       ''~7428I~
    Function setImage(Pfnm As String) As Boolean                       ''~7428R~
        If titlePrefix.CompareTo("") <> 0 Then  'opened image file already opened''~7613I~
            Me.Text = titlePrefix & " : " & Pfnm                       ''~7613R~
        End If                                                         ''~7613I~
        imageFilename = Pfnm                                            ''~7411R~
        If Not CreateImage(Pfnm) Then                                           ''~7428I~
            Return False
        End If ''~7428I~
        imageH = image.Height
        imageW = image.Width
        imageHorg = imageH
        imageWorg = imageW
        getTitleHeight()                                               ''~7408I~
        If (formHeight = 0) Then                                              ''~7411I~
            formWidth = My.Computer.Screen.Bounds.Size.Width / 2           ''~7411I~
            formHeight = My.Computer.Screen.Bounds.Size.Height / 2         ''~7411I~
        End If                                                         ''~7411I~
        setLayout(formWidth, formHeight)                                      ''~7408I~''~7411R~
        Dim rh As Double = formHeight / imageH                            ''~7513I~
        Dim rw As Double = formWidth / imageW                            ''~7513I~
        scaleNew = math.Min(rh, rw)                                     ''~7513R~
        zoomImage(0)                                                   ''~7513I~
        Return True                                                    ''~7428I~
    End Function                                                       ''~7428R~

    Private Sub getTitleHeight()                                       ''~7408I~
        posPanelY = Me.Height - Me.ClientSize.Height + Panel1.Bounds.Y   ''~7409R~
        borderSize = (Me.Width - Panel1.Width) / 2                       ''~7409I~
    End Sub                                                            ''~7408I~
    ''~7408I~
    Private Sub setLayout(Pww As Integer, Phh As Integer)
        Dim ww As Integer = System.Math.Min(imageW, Pww)
        Dim hh As Integer = System.Math.Min(imageH, Phh - posPanelY)        ''~7408R~''~7409R~
        '        Dim rc As Integer                                     ''~7407R~
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize             ''~7408R~
        Panel1.AutoScroll = True                                       ''~7408I~
        Panel1.SetAutoScrollMargin(SCROLLBAR_MARGIN / 2, SCROLLBAR_MARGIN / 2)  ''~7408I~
        scrollbarH += SCROLLBAR_MARGIN
        scrollbarW += SCROLLBAR_MARGIN
        Panel1.Height = hh                                             ''~7408M~
        Panel1.Width = ww                                              ''~7408M~
        Me.Width = ww + borderSize * 2
        Me.Height = hh + posPanelY                                     ''~7409R~
    End Sub    'setLayout                                              ''~7408R~

    Private Sub Form2_ResizeBegin(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeBegin ''~7407I~
        Dim this As Control = sender                                   ''~7407I~
        resizeBeginW = this.Size.Width                                  ''~7407I~
        resizeBeginH = this.Size.Height                                 ''~7407I~
    End Sub                                                            ''~7407I~
    ''~7408R~
    Private Sub Form2_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd
        '        Dim rc As Integer                                              ''~7407M~
        Dim this As Control = sender
        Dim ww As Integer = this.Size.Width
        Dim hh As Integer = this.Size.Height
        My.Settings.CfgFormSizeWImage = ww                               ''~7411I~
        My.Settings.CfgFormSizeHImage = hh                               ''~7411I~
        Dim diffH = hh - resizeBeginH         'expanded H              ''~7408R~
        Dim diffW = ww - resizeBeginW         'expanded W                           ''~7407I~''~7408R~
        '        Dim visibleVS, visibleHS As Boolean                              ''~7408I~
        ''~7408I~
        If diffH = 0 AndAlso diffW = 0 Then                                ''~7407M~''~7411R~
            Exit Sub 'not resize but form moved                        ''~7407M~
        End If
        '        Exit Sub ''~7407M~
        ww -= borderSize * 2   'panel width                           ''~7408R~''~7409R~
        hh -= posPanelY        'panel height                ''~7408R~  ''~7409R~
        '       ww = Me.ClientSize.Width                                         ''~7408R~''~7409R~
        '       hh = Me.ClientSize.Height-Panel1.Bounds.Y                      ''~7408R~''~7409R~
        Panel1.Height = hh                                             ''~7407M~
        Panel1.Width = ww                                              ''~7407M~
        Panel1.Refresh()                                               ''~7408I~
    End Sub 'resize                                                    ''~7408R~

    '    Private Sub PictureBox1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize''~7408R~
    '        Dim this As Control = sender                                  ''~7408R~
    '        '        PictureBox1.Size = New System.Drawing.Size(New Point(this.Width, this.Height))''~7408R~
    '    End Sub                                                           ''~7408R~
    ''~7408I~
    Private Function chkScrollbar(Pww As Integer, Phh As Integer) As Integer ''~7408R~
        'rc 1:Vertical 2,horizontal,3 both
        Dim rc As Integer = 0
        If Pww < imageW Then                              ''~7408R~
            rc += 2         'Horizontal scrollbar required             ''~7408R~
        End If
        If Phh < imageH Then                              ''~7408R~
            rc += 1         'Vertical scrollbar required               ''~7408R~
        End If
        Return rc
    End Function

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripButton1.Click ''~7408I~
        zoomImage(1)                                                   ''~7408I~
        If rotation > 0 Then                                                  ''~7513I~
            rotateImage(0)                                             ''~7513I~
        End If                                                         ''~7513I~
    End Sub                                                            ''~7408I~
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripButton2.Click ''~7408I~
        zoomImage(-1)                                                  ''~7408I~
        If rotation > 0 Then                                                  ''~7513I~
            rotateImage(0)                                             ''~7513I~
        End If                                                         ''~7513I~
    End Sub                                                            ''~7408I~
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripButton3.Click ''~7409I~
        rotateImage(3)   '90*3                                         ''~7409R~
    End Sub                                                            ''~7409I~
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripButton4.Click ''~7409I~
        rotateImage(1)   '90*1                                         ''~7409R~
    End Sub                                                            ''~7409I~
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripButton5.Click ''~7410R~
        Image2Text(imageFilename, False)                                      ''~7410R~''~7619R~
    End Sub                                                            ''~7410I~
    Private Sub ToolStripButtonEnglishDoc_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripButtonEnglishDoc.Click ''~7619I~
        Image2Text(imageFilename, True)                                 ''~7619I~
    End Sub                                                            ''~7619I~
    Private Sub ToolStripButtonHelp_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripButtonHelp.Click ''~7429I~
        showHelp()                                                     ''~7429I~
    End Sub                                                            ''~7429I~

    Private Function drawImage(Pww As Integer, Phh As Integer) As Boolean ''~7409M~
        '                                                              ''~7409M~
        'draw zoomed image                                             ''~7409M~
        '                                                              ''~7409M~
        Dim rc As Boolean = True                                       ''~7409M~
        Try                                                            ''~7409M~
            disposePictureBox()                                        ''~7513M~
            bitmapZoom = New Bitmap(image, Pww, Phh)               ''~7408R~''~7409M~
            PictureBox1.Image = bitmapZoom                             ''~7409M~
            '           If (Debug) Then                                            ''~7407R~''~7409M~
            '               Dim msg As String = String.Format("scaleNew={0},new imageH={1},new imageW={2}", scaleNew, Phh, Pww)''~7407R~''~7408R~''~7409M~
            '               MessageBox.Show(msg)                                   ''~7407R~''~7409M~
            '           End If                                                     ''~7407R~''~7409M~
        Catch ex As Exception                                          ''~7409M~
            '           MessageBox.Show("ズームできません:" & ex.Message)  ''~7409M~''~7428R~''~7617R~
            MessageBox.Show(ex.Message, Rstr.MSG_ERR_ZOOM)              ''~7617I~
            rc = False                                                 ''~7409M~
        End Try                                                        ''~7409M~
        Return rc                                                      ''~7409M~
    End Function                                                       ''~7409M~
    ''~7409I~
    Private Sub zoomImage(Pzoom As Integer)                            ''~7408I~
        '                                                                  ''~7408I~
        Dim scaleNext, scaleBoundary As Double                          ''~7408R~
        Dim hh, ww As Integer                                           ''~7408I~
        ''~7408I~
        ''~7408I~
        If Pzoom > 0 Then                                            ''~7408I~''~7513R~
            scaleNext = scaleNew + scaleRate                           ''~7408I~
        ElseIf Pzoom < 0 Then                                          ''~7513R~
            scaleNext = scaleNew - scaleRate                           ''~7408I~
        Else                                                           ''~7513I~
            scaleNext = scaleNew                                       ''~7513I~
        End If                                                         ''~7408I~
        hh = imageHorg * scaleNext                                         ''~7408I~
        ww = imageWorg * scaleNext                                         ''~7408I~
        '* stop at boundary                                                    ''~7408I~
        scaleBoundary = chkZoomBoundary(Pzoom, scaleNext)                 ''~7408I~
        If (scaleBoundary <> 0 AndAlso scaleBoundary <> scaleNew) Then                                           ''~7408I~''~7409R~''~7411R~
            scaleNext = scaleBoundary                                  ''~7408M~
            hh = imageHorg * scaleNext                                 ''~7408I~
            ww = imageWorg * scaleNext                                 ''~7408I~
        End If                                                         ''~7408I~
        If hh < SCALELIMIT_LOW Then                                           ''~7408I~
            Exit Sub                                                   ''~7408I~
        End If                                                          ''~7408I~
        If drawImage(ww, hh) Then                                ''~7408I~
            scaleNew = scaleNext                                       ''~7408I~
            imageH = hh                                                ''~7408I~
            imageW = ww                                                ''~7408I~
        End If                                                         ''~7408I~
    End Sub                                                            ''~7408I~


    Private Function chkZoomBoundary(Pzoom As Integer, Pscale As Double) As Double ''~7408I~
        ' stop at fit to just rectangle                                    ''~7408I~
        Dim scaleNew As Double = 0                                       ''~7409M~
        Dim swH, swW As Boolean                                         ''~7409M~
        Dim hh, ww As Integer                                          ''~7408I~''~7409R~
        Dim hhPanel As Integer = Panel1.Height                          ''~7409R~
        Dim wwPanel As Integer = Panel1.Width                           ''~7409I~
        hh = imageHorg * Pscale                                        ''~7408I~
        ww = imageWorg * Pscale                                        ''~7408I~
        ''~7408I~
        swH = False : swW = False                                            ''~7409I~
        If (Pzoom > 0) Then     'enlarge                               ''~7408I~
            If imageH < hhPanel AndAlso hh >= hhPanel Then    'stop at hhPanel                    ''~7408I~''~7409R~''~7411R~
                swH = True                                              ''~7409I~
            End If                                                      ''~7409I~
            If imageW < wwPanel AndAlso ww >= wwPanel Then  'stop at wwPanel''~7409I~''~7411R~
                swW = True                                              ''~7409I~
            End If                                                      ''~7409I~
            If (swH) Then                                                   ''~7409I~
                If (swW) Then                                               ''~7409I~
                    Dim scaleH = adjustZoomH()                       ''~7409I~
                    Dim scaleW = adjustZoomW()                       ''~7409I~
                    scaleNew = Math.Min(scaleH, scaleW)                   ''~7409I~
                Else                                                   ''~7409I~
                    scaleNew = adjustZoomH()                         ''~7409I~
                End If                                                  ''~7409I~
            Else                                                       ''~7409I~
                If (swW) Then                                               ''~7409I~
                    scaleNew = adjustZoomW()                         ''~7409I~
                End If                                                  ''~7409I~
            End If                                                      ''~7409I~
        Else                   'shrink                                 ''~7408I~
            If imageH > hhPanel AndAlso hh <= hhPanel Then                        ''~7408I~''~7411R~
                swH = True                                              ''~7409I~
            End If                                                     ''~7409I~
            If imageW > wwPanel AndAlso ww <= wwPanel Then                 ''~7409I~''~7411R~
                swW = True                                               ''~7409I~
            End If                                                     ''~7409I~
            If (swH) Then                                                   ''~7409I~
                If (swW) Then                                               ''~7409I~
                    Dim scaleH = adjustZoomH()                       ''~7409I~
                    Dim scaleW = adjustZoomW()                       ''~7409I~
                    scaleNew = Math.Min(scaleH, scaleW)                   ''~7409I~
                Else                                                   ''~7409I~
                    scaleNew = adjustZoomH()                         ''~7409I~
                End If                                                  ''~7409I~
            Else                                                       ''~7409I~
                If (swW) Then                                               ''~7409I~
                    scaleNew = adjustZoomW()                         ''~7409I~
                End If                                                  ''~7409I~
            End If                                                      ''~7409I~
        End If                                                         ''~7408I~
        Return scaleNew                                               ''~7408I~
    End Function                                                       ''~7408I~
    ''~7409I~
    Private Function adjustZoomH() As Double                           ''~7409I~
        '** rate when HH=panelH                                            ''~7409I~
        Dim hhPanel As Integer = Panel1.Height                          ''~7409I~
        Dim wwPanel As Integer = Panel1.Width                           ''~7409I~
        Dim imageHW As Double = imageHorg / imageWorg                      ''~7409I~
        Dim hh, ww As Integer                                           ''~7409I~
        ''~7409I~
        hh = hhPanel                                                     ''~7409I~
        ww = hh / imageHW                                                  ''~7409I~
        If ww > wwPanel Then   'Hscallvar exist                               ''~7409I~
            hh -= scrollbarH                                             ''~7409I~
            ww = hh / imageHW                                              ''~7409I~
        End If                                                          ''~7409I~
        Return ww / imageWorg                                            ''~7409I~
    End Function                                                       ''~7409I~
    ''~7409I~
    Private Function adjustZoomW() As Double                           ''~7409I~
        '** rate when WW=panelW                                            ''~7409I~
        Dim hhPanel As Integer = Panel1.Height                          ''~7409I~
        Dim wwPanel As Integer = Panel1.Width                           ''~7409I~
        Dim imageHW As Double = imageHorg / imageWorg                      ''~7409I~
        Dim hh, ww As Integer                                           ''~7409I~
        ''~7409I~
        ww = wwPanel                                                     ''~7409I~
        hh = ww * imageHW                                                  ''~7409I~
        If hh > hhPanel Then   'Vscallvar exist                               ''~7409I~
            ww -= scrollbarW                                             ''~7409I~
            hh = ww * imageHW                                              ''~7409I~
        End If                                                         ''~7409I~
        Return ww / imageWorg                                            ''~7409I~
    End Function                                                       ''~7409I~
    ''~7409I~
    Private Sub rotateImage(Pclockwise As Integer)                     ''~7409I~
        '** rotate image                                                   ''~7409I~
        Dim rt As System.Drawing.RotateFlipType                        ''~7409I~
        If Pclockwise = 0 Then 'restore rotation                              ''~7513I~
            Select Case rotation Mod 4                                 ''~7513I~
                Case 0                                                     ''~7513I~
                    Exit Sub                                               ''~7513I~
                Case 1                                                     ''~7513I~
                    rt = RotateFlipType.Rotate90FlipNone                   ''~7513I~
                Case 2                                                     ''~7513I~
                    rt = RotateFlipType.Rotate180FlipNone                  ''~7513I~
                Case 3                                                     ''~7513I~
                    rt = RotateFlipType.Rotate270FlipNone                  ''~7513I~
            End Select                                                 ''~7513I~
        Else                                                           ''~7513I~
            rotation += Pclockwise                                           ''~7409I~''~7513R~
            If (Pclockwise = 1) Then                                              ''~7409I~''~7513R~
                rt = RotateFlipType.Rotate90FlipNone                         ''~7409R~''~7513R~
            Else                                                           ''~7409I~''~7513R~
                rt = RotateFlipType.Rotate270FlipNone                        ''~7409R~''~7513R~
            End If                                                         ''~7409I~''~7513R~
        End If                                                         ''~7513I~
        bitmapZoom.RotateFlip(rt)                                      ''~7409I~
        PictureBox1.Image = bitmapZoom                                 ''~7409I~
    End Sub                                                            ''~7409I~
    '*************************************************************         ''~7410I~
    Private Sub Image2Text(Pfnm As String, PenglishDoc As Boolean)                             ''~7410I~''~7619R~
        If Form1.formText Is Nothing OrElse Form1.formText.IsDisposed Then ''~7411R~''~7521R~
            Form1.formText = New Form3()                                          ''~7410I~''~7411R~''~7521R~
        Else                                                           ''~7508I~
            If Not Form1.formText.chkDiscard(Nothing) Then                   ''~7508I~''~7521R~
                Exit Sub                                               ''~7508I~
            End If                                                     ''~7508I~
        End If                                                          ''~7411I~
        If dupError(Pfnm, PenglishDoc) Then                                              ''~7618I~''~7619R~
            Exit Sub                                                   ''~7618I~
        End If                                                         ''~7618I~

        Dim rc as Boolean=Form1.formText.setImage(Pfnm, PenglishDoc)                                          ''~7410R~''~7411R~''~7521R~''~7619R~
        Trace.W("Image2Text setImagerc=" & rc)                         ''~7619I~
        if rc                                                          ''~7619I~
        	Form1.formText.Show()                                          ''~7410R~''~7411R~''~7521R~''~7619R~
	        Trace.W("Image2Text after Show")                           ''~7619I~
        end if                                                         ''~7619I~
    End Sub                                                            ''~7410I~
    Private Function dupError(Pfnm As String, PenglishDoc As Boolean) As Boolean               ''~7618I~''~7619R~
        If PenglishDoc = extractingEnglishDoc Then               ''~7618I~''~7619R~
            Dim fnmtxt As String = Form3.getTitleFilename()            ''~7618R~
            Dim fnmimg As String                                       ''~7619R~
            If PenglishDoc Then                                             ''~7619I~
                fnmimg = Form1.changeExt(Pfnm, Form1.FILTER_DEFAULT_ENGLISHTEXT) ''~7619I~
            Else                                                       ''~7619I~
                fnmimg = Form1.changeExt(Pfnm, Form1.FILTER_DEFAULT_KANJITEXT) ''~7619I~
            End If                                                     ''~7619I~
            If (Not IsNothing(fnmtxt)) AndAlso (fnmimg.CompareTo(fnmtxt) = 0) Then ''~7618R~
                MessageBox.Show(Pfnm, Rstr.MSG_ERR_ALREADY_EXTRACTED)   ''~7618I~
                Return True                                            ''~7618I~
            End If                                                     ''~7618I~
        End If                                                         ''~7618I~
        extractingEnglishDoc = PenglishDoc                             ''~7619R~
        Return False                                                   ''~7618I~
    End Function                                                       ''~7618I~
    Private Sub showHelp()                                             ''~7429I~
        Dim txt As String                                              ''~7429I~
        If FormOptions.swLangEN Then                                   ''~7613I~
            txt = My.Resources.help_form2E                             ''~7613I~
        Else                                                           ''~7613I~
            txt = My.Resources.help_form2                                  ''~7429I~''~7613R~
        End If                                                         ''~7613I~
        MessageBox.Show(txt, titlePrefix)                                           ''~7429I~''~7613R~
    End Sub                                                            ''~7429I~
    Private Sub disposePictureBox()                                         ''~7513I~
        If Not IsNothing(bitmapZoom) Then                                   ''~7513I~
            bitmapZoom.Dispose()                                       ''~7513R~
        End If                                                         ''~7513I~
    End Sub                                                            ''~7513I~
    Public Sub setLocale(Prefresh As Boolean)                                            ''~7613I~''~7619R~
        Dim title As String = Me.Text                                  ''~7619I~
        FormOptions.setLang(Me, GetType(Form2)) 'reset control language                       ''~7613I~''~7619R~
        updateTitle(title)                                             ''~7619I~
    End Sub                                                            ''~7613I~
    Private Sub updateTitle(Pold As String)                            ''~7619I~
        Dim pos As Integer                                             ''~7619I~
        pos = Pold.IndexOf(Form1.TITLE_SEP)                            ''~7619R~
        If pos >= 0 Then                                               ''~7619I~
            Me.Text = Rstr.FORM2_TITLE & Pold.Substring(pos)           ''~7619I~
        End If                                                         ''~7619I~
    End Sub                                                            ''~7619I~
End Class