
V1.01 : 2017/06/21 (初版)

zip ファイルを展開し、setup.exe でインストール、証明書はテスト用のもので、公開元は不明とでます
同じバージョンは1度しかインストールできません(上書きしません)

文書読み取り機能＋かな変換機能で
スキャナーで読み取ったイメージファイルから漢字かな混じり文を読み取って
WinBES99 のためのかな入力ファイルを作成するツールです
イメージファイルは "Windows Fax と スキャン" で スキャナーからイメージファイルを得ることができます
英語文書も読み取れますが"かな変換"では特になにもしません

要件：文書読み取り機能を使用する場合は
      "Microsoft Office Document Imaging"(MODI) がインストールされている必要があります
      下記 (注) 参照

操作方法はトップ画面のヘルプボタンで表示されます

尚、Microsoft Office Document Imaging や MicrosoftOffice Document Scanning で
文書をスキャンして Image ファイルに保存したり、読み取ったテキストを Word に送る
ことができます
Microsoft OneNote(無料) でも イメージファイルからテキストを読み取ることができます

*************************************************************************************
(注)MODIのインストール
    ここで(https://support.microsoft.com/ja-jp/help/982760/install-modi-for-use-with-microsoft-office-2010)
    方法が記述されています
    (1)"MDI to TIFF File Converter"をインストール(http://www.microsoft.com/en-us/download/details.aspx?id=30328)
    (2)"SharePoint Designer 2007"のMODIをインストールする
       (http://www.microsoft.com/ja-jp/download/details.aspx?id=21581)
          Office の 他のバージョンと衝突を避けるため MODI のみインストールする("今すぐインストール"ではインストールされない)
            "ユーザー設定" で すべて(SharePointDesigner,Office共通機能,Office ツール) を "インストールしない"にしたあと
            Officeツールの "Microsoft Office Document Imaging" を "マイコンピューターからすべて実行"にセット
       .rtf ファイルは説明文書です
       SharePointDesigner2007 のサポート期限は 2017/10/10 だそうです 
       SP3+LanguagePack-Japanese(sharepointdesigner2007sp3-kb2526089-fullfile-ja-jp.exe)もインストールが必要です。
       (http://www.microsoft.com/ja-jp/download/details.aspx?id=27815)

    但、OneNote（Windows10ではインストール済み)で画像から読み取ったテキストを処理する場合は
    MODIのインストールは不要です。OneNoteの品質は良くないようです

