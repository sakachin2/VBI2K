(UTF8 encoding)

V1.16 : Update                               2017/12/31

. KanjiText->KanaText conversion hungs by combination of Chuten(・)
. Show string enclosed by Error() when Kanji->Kana translation error.

V1.15 : Update                               2017/10/27

. Place "Send" button to each lines on Symbol Input Dialog.
. Bug of Cut & Paste on Words Dfinition Dialog.

V1.14 : Update                               2017/09/27

. Support Kanji file of encoding = UTF-8.
. Words Definition support.
    On Kanji text form, register those words repeatedly used in the document.
    Candidates are kanji character sometimes misrecognition occurs
    at extracting from image, e.g. "三" may be recognized as "一二" 
    When "Key"(One Alphabet Char,Case InSensitive) is registered,
    Ctrl+Key sends "Phrase" to text box.
    When the dialog is opened, "Send" button also send the "Phrase".
. Miscellaneous.
   .Cursor and Caret shape was changed.
   .(Bug)It may scroll to top by Enter key at Kanji Form.
   .(Bug)Form size is not restored at re-open.

V1.03 : Update                               2017/09/23

・Added some characters resembling in shape for Char-Replacing-Key(F5 as Default), 
    ソ(katakana:so) <--> ン(katakana:n)
    十(kanji) <--> ＋(Plus) 

V1.02 : Update                               2017/09/20

・(Bug)Translating line by line on kanji text caused errornouse output at end of line.
・Collectly translates such words  as 3ヵ月,霞ヶ浦 or 三ツ which includes カケヵヶ or ツッ.
・Supports simple dictionary.
・Added some characters resembling in shape for Char-Replacing-Key(F5 as Default), 
  extracting character from image sometimes mis-understands.
  Confirmation Key(Default:F4) reports the charcter type.
    Ri:リ(katakana)<-->り(hiragana)
    He:ヘ(katakana)<-->へ(hiragana)
    Be:ベ(katakana)<-->べ(hiragana)
    工(業:kougyou=industry:kanji) --> エ(ネルギー:e=Energy:katakana) -->ェ(small e:katakana) -->工(業) (back to kanji)
    力(士:rikisi=Sumo wrestler:kanji) --> カ(エル:kaeru=frog:katakana) -->ヵ(small ka:katakana) --> 力(士) (back to kanji)
    夕(焼け:yuuyake=sunset glow:kanji) <--> タ(オル:taoru=towel:katakana)                  
    一(kanji) --> ー(katakana) --> ─(HorizontalBar) --> 一(kanji)  (WrapAround)
    夕(kanji) <--> タ(katakana)                                     
    二(kanji) <--> ニ(katakana) 
    八(kanji) <--> ハ(katakana) 
    口(kanji) <--> ロ(katakana) 

*********************************************************************************************

V1.01 : 2017/06/21 (1st release)

Expand zip file, then execute setup.exe to install, the certificate is test version and issues unknown publisher.
It is installable only once if version number is same.

By "TextExtraction function" + "Kana translation function",
generate Japanese Kana file for WinBES99 extracting text from document file
created by scanner device.
English Document can be extracted, and "Kana translation" do nothing paticularly.

Kana is a collection of Japanese Letter excludes Kanji.
WinBES99 is a text translation tool into Braille.
Windows app "Windows Fax and Scan" can be used to create image file. 
Application may crash depending quality of image file, in that case try re-scan the document.
And displayiong some number of image files may cause memory shortage.

Requirement：To extranct text from image file,
      This app requires "Microsoft Office Document Imaging"(MODI) installed.
      See (Note) bellow.

Push Help button on top panel to see usage.

("Microsoft Office Document Imaging" or "MicrosoftOffice Document Scanning"
also enable to scan documents and save to image file, and send extracted text string to "Microsoft Word".)
"Microsoft OneNote"(Free) also supports extracting text from document file.

GitHub sakachin2/VBI2K contains MSVS2010Express project source

Please send your suggestion or bug reports to mail:sakachin2@yahoo.co.jp

*************************************************************************************
(Note)How to install MODI.
    See this site(https://support.microsoft.com/ja-jp/help/982760/install-modi-for-use-with-microsoft-office-2010).
    (1)install "MDI to TIFF File Converter"(http://www.microsoft.com/en-us/download/details.aspx?id=30328)
    or 
    (2)install "SharePoint Designer 2007"
       (http://www.microsoft.com/ja-jp/download/details.aspx?id=21581)
          Install MODI ony to avoid other version of Office("Install Now" skips installing of MODI).
            By "Custom Install",set all(SharepointDesigner,Office Common,Office Tool) to "No install".
            Then set "Microsoft Office Document Imaging" of Office tool to "execute all from My Computer".
       .rtf file is  Word Document.
       SharePointDesigner2007 is supported until 2017/10/10.
       (It is saved in GitHub sakachin2/VBI2K)
       SP3+languagePack-Japanese(sharepointdesigner2007sp3-kb2526089-fullfile-ja-jp.exe) is also required to install.
       (http://www.microsoft.com/ja-jp/download/details.aspx?id=27815)

    MODI is not required if you have Text Extracting such as OneNote.
    Windows10 preinstalls OneNote, OneNote's quality may be poor.
------------------------------------------------------------
    See staff folder for Win-BES99 and if link-(2) was lost
