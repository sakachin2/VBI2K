﻿'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはツールによって生成されました。
'     ランタイム バージョン:4.0.30319.42000
'
'     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
'     コードが再生成されるときに損失したりします。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings 自動保存機能"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300")>  _
        Public Property CfgFormSizeWText() As Integer
            Get
                Return CType(Me("CfgFormSizeWText"),Integer)
            End Get
            Set
                Me("CfgFormSizeWText") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300")>  _
        Public Property CfgFormSizeHText() As Integer
            Get
                Return CType(Me("CfgFormSizeHText"),Integer)
            End Get
            Set
                Me("CfgFormSizeHText") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property CfgFormSizeWImage() As Integer
            Get
                Return CType(Me("CfgFormSizeWImage"),Integer)
            End Get
            Set
                Me("CfgFormSizeWImage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property CfgFormSizeHImage() As Integer
            Get
                Return CType(Me("CfgFormSizeHImage"),Integer)
            End Get
            Set
                Me("CfgFormSizeHImage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CfgMRUImage() As String
            Get
                Return CType(Me("CfgMRUImage"),String)
            End Get
            Set
                Me("CfgMRUImage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300")>  _
        Public Property CfgFormSizeWKanaText() As Integer
            Get
                Return CType(Me("CfgFormSizeWKanaText"),Integer)
            End Get
            Set
                Me("CfgFormSizeWKanaText") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300")>  _
        Public Property CfgFormSizeHKanaText() As Integer
            Get
                Return CType(Me("CfgFormSizeHKanaText"),Integer)
            End Get
            Set
                Me("CfgFormSizeHKanaText") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300")>  _
        Public Property CfgFormSizeWMain() As Integer
            Get
                Return CType(Me("CfgFormSizeWMain"),Integer)
            End Get
            Set
                Me("CfgFormSizeWMain") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300")>  _
        Public Property CfgFormSizeHMain() As Integer
            Get
                Return CType(Me("CfgFormSizeHMain"),Integer)
            End Get
            Set
                Me("CfgFormSizeHMain") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CfgMRUtext() As String
            Get
                Return CType(Me("CfgMRUtext"),String)
            End Get
            Set
                Me("CfgMRUtext") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CfgMRUKanaText() As String
            Get
                Return CType(Me("CfgMRUKanaText"),String)
            End Get
            Set
                Me("CfgMRUKanaText") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ＭＳ 明朝")>  _
        Public Property CFGF5_FontName() As String
            Get
                Return CType(Me("CFGF5_FontName"),String)
            End Get
            Set
                Me("CFGF5_FontName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("12")>  _
        Public Property CFGF5_FontSize() As Integer
            Get
                Return CType(Me("CFGF5_FontSize"),Integer)
            End Get
            Set
                Me("CFGF5_FontSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Regular")>  _
        Public Property CFGF5_FontStyle() As Global.System.Drawing.FontStyle
            Get
                Return CType(Me("CFGF5_FontStyle"),Global.System.Drawing.FontStyle)
            End Get
            Set
                Me("CFGF5_FontStyle") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property CFGF5_KeySmall() As Integer
            Get
                Return CType(Me("CFGF5_KeySmall"),Integer)
            End Get
            Set
                Me("CFGF5_KeySmall") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("32")>  _
        Public Property CFGF5_LineWidth() As Integer
            Get
                Return CType(Me("CFGF5_LineWidth"),Integer)
            End Get
            Set
                Me("CFGF5_LineWidth") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ＭＳ 明朝")>  _
        Public Property CFGF5_FontNameScr() As String
            Get
                Return CType(Me("CFGF5_FontNameScr"),String)
            End Get
            Set
                Me("CFGF5_FontNameScr") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("12")>  _
        Public Property CFGF5_FontSizeScr() As String
            Get
                Return CType(Me("CFGF5_FontSizeScr"),String)
            End Get
            Set
                Me("CFGF5_FontSizeScr") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Regular")>  _
        Public Property CFGF5_FontStyleScr() As Global.System.Drawing.FontStyle
            Get
                Return CType(Me("CFGF5_FontStyleScr"),Global.System.Drawing.FontStyle)
            End Get
            Set
                Me("CFGF5_FontStyleScr") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property CFGF5_PrintFontSame() As Boolean
            Get
                Return CType(Me("CFGF5_PrintFontSame"),Boolean)
            End Get
            Set
                Me("CFGF5_PrintFontSame") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("6")>  _
        Public Property CFGF5_KeySpecialChar() As Integer
            Get
                Return CType(Me("CFGF5_KeySpecialChar"),Integer)
            End Get
            Set
                Me("CFGF5_KeySpecialChar") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CfgSpecialKeys() As String
            Get
                Return CType(Me("CfgSpecialKeys"),String)
            End Get
            Set
                Me("CfgSpecialKeys") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CfgFindWord() As String
            Get
                Return CType(Me("CfgFindWord"),String)
            End Get
            Set
                Me("CfgFindWord") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CfgRepWord() As String
            Get
                Return CType(Me("CfgRepWord"),String)
            End Get
            Set
                Me("CfgRepWord") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CfgCase() As Boolean
            Get
                Return CType(Me("CfgCase"),Boolean)
            End Get
            Set
                Me("CfgCase") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CfgFindUp() As Boolean
            Get
                Return CType(Me("CfgFindUp"),Boolean)
            End Get
            Set
                Me("CfgFindUp") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property CfgTestOption() As Integer
            Get
                Return CType(Me("CfgTestOption"),Integer)
            End Get
            Set
                Me("CfgTestOption") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property CFGF12_swBES99() As Boolean
            Get
                Return CType(Me("CFGF12_swBES99"),Boolean)
            End Get
            Set
                Me("CFGF12_swBES99") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property CFGF5_LangID() As Integer
            Get
                Return CType(Me("CFGF5_LangID"),Integer)
            End Get
            Set
                Me("CFGF5_LangID") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CFGF12_swKatakanaDoc() As Boolean
            Get
                Return CType(Me("CFGF12_swKatakanaDoc"),Boolean)
            End Get
            Set
                Me("CFGF12_swKatakanaDoc") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CFGF9_Dictionary() As String
            Get
                Return CType(Me("CFGF9_Dictionary"),String)
            End Get
            Set
                Me("CFGF9_Dictionary") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CfgMRUDictionary() As String
            Get
                Return CType(Me("CfgMRUDictionary"),String)
            End Get
            Set
                Me("CfgMRUDictionary") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CFGF12_swEnglishDoc() As Boolean
            Get
                Return CType(Me("CFGF12_swEnglishDoc"),Boolean)
            End Get
            Set
                Me("CFGF12_swEnglishDoc") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4")>  _
        Public Property CFGF5_KeySmallQ() As Integer
            Get
                Return CType(Me("CFGF5_KeySmallQ"),Integer)
            End Get
            Set
                Me("CFGF5_KeySmallQ") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.WindowsApplication1.My.MySettings
            Get
                Return Global.WindowsApplication1.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
