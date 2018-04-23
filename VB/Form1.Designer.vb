Imports Microsoft.VisualBasic
Imports System
Namespace RichEditTwoControlsOneToolbar
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim superToolTip1 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem1 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem1 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip2 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem2 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem2 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip3 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem3 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem3 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip4 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem4 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem4 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip5 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem5 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem5 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip6 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem6 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem6 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip7 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem7 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem7 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip8 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem8 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem8 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip9 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem9 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem9 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip15 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem15 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem15 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip10 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem10 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem10 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip11 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem11 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem11 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip12 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem12 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem12 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip13 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem13 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem13 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip14 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem14 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem14 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip16 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem16 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem16 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip17 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem17 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem17 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip18 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem18 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem18 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip19 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem19 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem19 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip20 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem20 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem20 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip21 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem21 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem21 As New DevExpress.Utils.ToolTipItem()
			Dim superToolTip22 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem22 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem22 As New DevExpress.Utils.ToolTipItem()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.commonBar1 = New DevExpress.XtraRichEdit.UI.CommonBar()
			Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
			Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
			Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
			Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
			Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
			Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
			Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
			Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
			Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
			Me.clipboardBar1 = New DevExpress.XtraRichEdit.UI.ClipboardBar()
			Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
			Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
			Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
			Me.fontBar1 = New DevExpress.XtraRichEdit.UI.FontBar()
			Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
			Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
			Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
			Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
			Me.richEditControl2 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
			Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
			Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
			Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
			Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
			Me.toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
			Me.toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
			Me.toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
			Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
			Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
			Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
			Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
			Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
			Me.showFontFormItem1 = New DevExpress.XtraRichEdit.UI.ShowFontFormItem()
			Me.paragraphBar1 = New DevExpress.XtraRichEdit.UI.ParagraphBar()
			Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
			Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
			Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
			Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
			Me.changeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem()
			Me.setSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem()
			Me.setSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem()
			Me.setDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem()
			Me.showLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem()
			Me.addSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem()
			Me.removeSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem()
			Me.addSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem()
			Me.removeSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem()
			Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
			Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
			Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
			Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
			Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
			Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
			Me.showParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem()
			Me.editingBar1 = New DevExpress.XtraRichEdit.UI.EditingBar()
			Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
			Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.changeStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeStyleItem()
			Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
			Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
			Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl1.Location = New System.Drawing.Point(0, 0)
			Me.richEditControl1.MenuManager = Me.barManager1
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(1000, 207)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
'			Me.richEditControl1.Enter += New System.EventHandler(Me.richEditControl_Enter);
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.commonBar1, Me.clipboardBar1, Me.fontBar1, Me.paragraphBar1, Me.editingBar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.undoItem1, Me.redoItem1, Me.cutItem1, Me.copyItem1, Me.pasteItem1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.clearFormattingItem1, Me.showFontFormItem1, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.toggleNumberingListItem1, Me.toggleBulletedListItem1, Me.toggleMultiLevelListItem1, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.toggleShowWhitespaceItem1, Me.showParagraphFormItem1, Me.changeStyleItem1, Me.findItem1, Me.replaceItem1})
			Me.barManager1.MaxItemId = 51
			Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemRichEditStyleEdit1})
			' 
			' commonBar1
			' 
			Me.commonBar1.DockCol = 0
			Me.commonBar1.DockRow = 0
			Me.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.commonBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.fileNewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileOpenItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fileSaveAsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.quickPrintItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.undoItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.redoItem1)})
			' 
			' fileNewItem1
			' 
			Me.fileNewItem1.Glyph = (CType(resources.GetObject("fileNewItem1.Glyph"), System.Drawing.Image))
			Me.fileNewItem1.Id = 0
			Me.fileNewItem1.LargeGlyph = (CType(resources.GetObject("fileNewItem1.LargeGlyph"), System.Drawing.Image))
			Me.fileNewItem1.Name = "fileNewItem1"
			' 
			' fileOpenItem1
			' 
			Me.fileOpenItem1.Glyph = (CType(resources.GetObject("fileOpenItem1.Glyph"), System.Drawing.Image))
			Me.fileOpenItem1.Id = 1
			Me.fileOpenItem1.LargeGlyph = (CType(resources.GetObject("fileOpenItem1.LargeGlyph"), System.Drawing.Image))
			Me.fileOpenItem1.Name = "fileOpenItem1"
			' 
			' fileSaveItem1
			' 
			Me.fileSaveItem1.Glyph = (CType(resources.GetObject("fileSaveItem1.Glyph"), System.Drawing.Image))
			Me.fileSaveItem1.Id = 2
			Me.fileSaveItem1.LargeGlyph = (CType(resources.GetObject("fileSaveItem1.LargeGlyph"), System.Drawing.Image))
			Me.fileSaveItem1.Name = "fileSaveItem1"
			' 
			' fileSaveAsItem1
			' 
			Me.fileSaveAsItem1.Glyph = (CType(resources.GetObject("fileSaveAsItem1.Glyph"), System.Drawing.Image))
			Me.fileSaveAsItem1.Id = 3
			Me.fileSaveAsItem1.LargeGlyph = (CType(resources.GetObject("fileSaveAsItem1.LargeGlyph"), System.Drawing.Image))
			Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
			' 
			' quickPrintItem1
			' 
			Me.quickPrintItem1.Glyph = (CType(resources.GetObject("quickPrintItem1.Glyph"), System.Drawing.Image))
			Me.quickPrintItem1.Id = 4
			Me.quickPrintItem1.LargeGlyph = (CType(resources.GetObject("quickPrintItem1.LargeGlyph"), System.Drawing.Image))
			Me.quickPrintItem1.Name = "quickPrintItem1"
			toolTipTitleItem1.Text = "&Quick Print"
			toolTipItem1.Text = "Send the document directly to the default printer without making changes."
			superToolTip1.Items.Add(toolTipTitleItem1)
			superToolTip1.Items.Add(toolTipItem1)
			Me.quickPrintItem1.SuperTip = superToolTip1
			' 
			' printItem1
			' 
			Me.printItem1.Glyph = (CType(resources.GetObject("printItem1.Glyph"), System.Drawing.Image))
			Me.printItem1.Id = 5
			Me.printItem1.LargeGlyph = (CType(resources.GetObject("printItem1.LargeGlyph"), System.Drawing.Image))
			Me.printItem1.Name = "printItem1"
			' 
			' printPreviewItem1
			' 
			Me.printPreviewItem1.Glyph = (CType(resources.GetObject("printPreviewItem1.Glyph"), System.Drawing.Image))
			Me.printPreviewItem1.Id = 6
			Me.printPreviewItem1.LargeGlyph = (CType(resources.GetObject("printPreviewItem1.LargeGlyph"), System.Drawing.Image))
			Me.printPreviewItem1.Name = "printPreviewItem1"
			toolTipTitleItem2.Text = "Print Pre&view"
			toolTipItem2.Text = "Preview and make changes to pages before printing."
			superToolTip2.Items.Add(toolTipTitleItem2)
			superToolTip2.Items.Add(toolTipItem2)
			Me.printPreviewItem1.SuperTip = superToolTip2
			' 
			' undoItem1
			' 
			Me.undoItem1.Glyph = (CType(resources.GetObject("undoItem1.Glyph"), System.Drawing.Image))
			Me.undoItem1.Id = 7
			Me.undoItem1.LargeGlyph = (CType(resources.GetObject("undoItem1.LargeGlyph"), System.Drawing.Image))
			Me.undoItem1.Name = "undoItem1"
			' 
			' redoItem1
			' 
			Me.redoItem1.Glyph = (CType(resources.GetObject("redoItem1.Glyph"), System.Drawing.Image))
			Me.redoItem1.Id = 8
			Me.redoItem1.LargeGlyph = (CType(resources.GetObject("redoItem1.LargeGlyph"), System.Drawing.Image))
			Me.redoItem1.Name = "redoItem1"
			' 
			' clipboardBar1
			' 
			Me.clipboardBar1.DockCol = 1
			Me.clipboardBar1.DockRow = 0
			Me.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.clipboardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.copyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pasteItem1)})
			Me.clipboardBar1.Offset = 275
			' 
			' cutItem1
			' 
			Me.cutItem1.Glyph = (CType(resources.GetObject("cutItem1.Glyph"), System.Drawing.Image))
			Me.cutItem1.Id = 9
			Me.cutItem1.LargeGlyph = (CType(resources.GetObject("cutItem1.LargeGlyph"), System.Drawing.Image))
			Me.cutItem1.Name = "cutItem1"
			' 
			' copyItem1
			' 
			Me.copyItem1.Glyph = (CType(resources.GetObject("copyItem1.Glyph"), System.Drawing.Image))
			Me.copyItem1.Id = 10
			Me.copyItem1.LargeGlyph = (CType(resources.GetObject("copyItem1.LargeGlyph"), System.Drawing.Image))
			Me.copyItem1.Name = "copyItem1"
			' 
			' pasteItem1
			' 
			Me.pasteItem1.Glyph = (CType(resources.GetObject("pasteItem1.Glyph"), System.Drawing.Image))
			Me.pasteItem1.Id = 11
			Me.pasteItem1.LargeGlyph = (CType(resources.GetObject("pasteItem1.LargeGlyph"), System.Drawing.Image))
			Me.pasteItem1.Name = "pasteItem1"
			' 
			' fontBar1
			' 
			Me.fontBar1.DockCol = 0
			Me.fontBar1.DockRow = 1
			Me.fontBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.fontBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.changeFontNameItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeFontSizeItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeFontColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeFontBackColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontBoldItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontItalicItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontUnderlineItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontDoubleUnderlineItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontStrikeoutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontDoubleStrikeoutItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontSuperscriptItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleFontSubscriptItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fontSizeIncreaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.fontSizeDecreaseItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.clearFormattingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showFontFormItem1)})
			' 
			' changeFontNameItem1
			' 
			Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
			Me.changeFontNameItem1.Id = 12
			Me.changeFontNameItem1.Name = "changeFontNameItem1"
			toolTipTitleItem3.Text = "Font"
			toolTipItem3.Text = "Change the font face."
			superToolTip3.Items.Add(toolTipTitleItem3)
			superToolTip3.Items.Add(toolTipItem3)
			Me.changeFontNameItem1.SuperTip = superToolTip3
			Me.changeFontNameItem1.Width = 150
			' 
			' repositoryItemFontEdit1
			' 
			Me.repositoryItemFontEdit1.AutoHeight = False
			Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
			' 
			' changeFontSizeItem1
			' 
			Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
			Me.changeFontSizeItem1.Id = 13
			Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
			toolTipTitleItem4.Text = "Font Size"
			toolTipItem4.Text = "Change the font size."
			superToolTip4.Items.Add(toolTipTitleItem4)
			superToolTip4.Items.Add(toolTipItem4)
			Me.changeFontSizeItem1.SuperTip = superToolTip4
			' 
			' repositoryItemRichEditFontSizeEdit1
			' 
			Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
			Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl2
			Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
			' 
			' richEditControl2
			' 
			Me.richEditControl2.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
			Me.richEditControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl2.Location = New System.Drawing.Point(0, 0)
			Me.richEditControl2.MenuManager = Me.barManager1
			Me.richEditControl2.Name = "richEditControl2"
			Me.richEditControl2.Size = New System.Drawing.Size(1000, 244)
			Me.richEditControl2.TabIndex = 5
			Me.richEditControl2.Text = "richEditControl2"
'			Me.richEditControl2.Enter += New System.EventHandler(Me.richEditControl_Enter);
			' 
			' changeFontColorItem1
			' 
			Me.changeFontColorItem1.Glyph = (CType(resources.GetObject("changeFontColorItem1.Glyph"), System.Drawing.Image))
			Me.changeFontColorItem1.Id = 14
			Me.changeFontColorItem1.LargeGlyph = (CType(resources.GetObject("changeFontColorItem1.LargeGlyph"), System.Drawing.Image))
			Me.changeFontColorItem1.Name = "changeFontColorItem1"
			toolTipTitleItem5.Text = "Font Color"
			toolTipItem5.Text = "Change the font color."
			superToolTip5.Items.Add(toolTipTitleItem5)
			superToolTip5.Items.Add(toolTipItem5)
			Me.changeFontColorItem1.SuperTip = superToolTip5
			' 
			' changeFontBackColorItem1
			' 
			Me.changeFontBackColorItem1.Glyph = (CType(resources.GetObject("changeFontBackColorItem1.Glyph"), System.Drawing.Image))
			Me.changeFontBackColorItem1.Id = 15
			Me.changeFontBackColorItem1.LargeGlyph = (CType(resources.GetObject("changeFontBackColorItem1.LargeGlyph"), System.Drawing.Image))
			Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
			toolTipTitleItem6.Text = "Text Highlight Color"
			toolTipItem6.Text = "Make text look like it was marked with a highlighter pen."
			superToolTip6.Items.Add(toolTipTitleItem6)
			superToolTip6.Items.Add(toolTipItem6)
			Me.changeFontBackColorItem1.SuperTip = superToolTip6
			' 
			' toggleFontBoldItem1
			' 
			Me.toggleFontBoldItem1.Glyph = (CType(resources.GetObject("toggleFontBoldItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontBoldItem1.Id = 16
			Me.toggleFontBoldItem1.LargeGlyph = (CType(resources.GetObject("toggleFontBoldItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
			' 
			' toggleFontItalicItem1
			' 
			Me.toggleFontItalicItem1.Glyph = (CType(resources.GetObject("toggleFontItalicItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontItalicItem1.Id = 17
			Me.toggleFontItalicItem1.LargeGlyph = (CType(resources.GetObject("toggleFontItalicItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
			' 
			' toggleFontUnderlineItem1
			' 
			Me.toggleFontUnderlineItem1.Glyph = (CType(resources.GetObject("toggleFontUnderlineItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontUnderlineItem1.Id = 18
			Me.toggleFontUnderlineItem1.LargeGlyph = (CType(resources.GetObject("toggleFontUnderlineItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
			' 
			' toggleFontDoubleUnderlineItem1
			' 
			Me.toggleFontDoubleUnderlineItem1.Glyph = (CType(resources.GetObject("toggleFontDoubleUnderlineItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontDoubleUnderlineItem1.Id = 19
			Me.toggleFontDoubleUnderlineItem1.LargeGlyph = (CType(resources.GetObject("toggleFontDoubleUnderlineItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
			' 
			' toggleFontStrikeoutItem1
			' 
			Me.toggleFontStrikeoutItem1.Glyph = (CType(resources.GetObject("toggleFontStrikeoutItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontStrikeoutItem1.Id = 20
			Me.toggleFontStrikeoutItem1.LargeGlyph = (CType(resources.GetObject("toggleFontStrikeoutItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
			toolTipTitleItem7.Text = "Strikethrough"
			toolTipItem7.Text = "Draw a line through the middle of the selected text."
			superToolTip7.Items.Add(toolTipTitleItem7)
			superToolTip7.Items.Add(toolTipItem7)
			Me.toggleFontStrikeoutItem1.SuperTip = superToolTip7
			' 
			' toggleFontDoubleStrikeoutItem1
			' 
			Me.toggleFontDoubleStrikeoutItem1.Glyph = (CType(resources.GetObject("toggleFontDoubleStrikeoutItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontDoubleStrikeoutItem1.Id = 21
			Me.toggleFontDoubleStrikeoutItem1.LargeGlyph = (CType(resources.GetObject("toggleFontDoubleStrikeoutItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
			toolTipTitleItem8.Text = "Double Strikethrough"
			toolTipItem8.Text = "Double strikethrough"
			superToolTip8.Items.Add(toolTipTitleItem8)
			superToolTip8.Items.Add(toolTipItem8)
			Me.toggleFontDoubleStrikeoutItem1.SuperTip = superToolTip8
			' 
			' toggleFontSuperscriptItem1
			' 
			Me.toggleFontSuperscriptItem1.Glyph = (CType(resources.GetObject("toggleFontSuperscriptItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontSuperscriptItem1.Id = 22
			Me.toggleFontSuperscriptItem1.LargeGlyph = (CType(resources.GetObject("toggleFontSuperscriptItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
			' 
			' toggleFontSubscriptItem1
			' 
			Me.toggleFontSubscriptItem1.Glyph = (CType(resources.GetObject("toggleFontSubscriptItem1.Glyph"), System.Drawing.Image))
			Me.toggleFontSubscriptItem1.Id = 23
			Me.toggleFontSubscriptItem1.LargeGlyph = (CType(resources.GetObject("toggleFontSubscriptItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
			' 
			' fontSizeIncreaseItem1
			' 
			Me.fontSizeIncreaseItem1.Glyph = (CType(resources.GetObject("fontSizeIncreaseItem1.Glyph"), System.Drawing.Image))
			Me.fontSizeIncreaseItem1.Id = 24
			Me.fontSizeIncreaseItem1.LargeGlyph = (CType(resources.GetObject("fontSizeIncreaseItem1.LargeGlyph"), System.Drawing.Image))
			Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
			' 
			' fontSizeDecreaseItem1
			' 
			Me.fontSizeDecreaseItem1.Glyph = (CType(resources.GetObject("fontSizeDecreaseItem1.Glyph"), System.Drawing.Image))
			Me.fontSizeDecreaseItem1.Id = 25
			Me.fontSizeDecreaseItem1.LargeGlyph = (CType(resources.GetObject("fontSizeDecreaseItem1.LargeGlyph"), System.Drawing.Image))
			Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
			' 
			' clearFormattingItem1
			' 
			Me.clearFormattingItem1.Glyph = (CType(resources.GetObject("clearFormattingItem1.Glyph"), System.Drawing.Image))
			Me.clearFormattingItem1.Id = 26
			Me.clearFormattingItem1.LargeGlyph = (CType(resources.GetObject("clearFormattingItem1.LargeGlyph"), System.Drawing.Image))
			Me.clearFormattingItem1.Name = "clearFormattingItem1"
			toolTipTitleItem9.Text = "Clear Formatting"
			toolTipItem9.Text = "Clear all the formatting from the selection, leaving only plain text."
			superToolTip9.Items.Add(toolTipTitleItem9)
			superToolTip9.Items.Add(toolTipItem9)
			Me.clearFormattingItem1.SuperTip = superToolTip9
			' 
			' showFontFormItem1
			' 
			Me.showFontFormItem1.Glyph = (CType(resources.GetObject("showFontFormItem1.Glyph"), System.Drawing.Image))
			Me.showFontFormItem1.Id = 27
			Me.showFontFormItem1.LargeGlyph = (CType(resources.GetObject("showFontFormItem1.LargeGlyph"), System.Drawing.Image))
			Me.showFontFormItem1.Name = "showFontFormItem1"
			' 
			' paragraphBar1
			' 
			Me.paragraphBar1.DockCol = 2
			Me.paragraphBar1.DockRow = 0
			Me.paragraphBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.paragraphBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphAlignmentLeftItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphAlignmentCenterItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphAlignmentRightItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphAlignmentJustifyItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeParagraphLineSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleNumberingListItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleBulletedListItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleMultiLevelListItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.decreaseIndentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.increaseIndentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleShowWhitespaceItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showParagraphFormItem1)})
			Me.paragraphBar1.Offset = 378
			' 
			' toggleParagraphAlignmentLeftItem1
			' 
			Me.toggleParagraphAlignmentLeftItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.Glyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentLeftItem1.Id = 28
			Me.toggleParagraphAlignmentLeftItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
			' 
			' toggleParagraphAlignmentCenterItem1
			' 
			Me.toggleParagraphAlignmentCenterItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.Glyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentCenterItem1.Id = 29
			Me.toggleParagraphAlignmentCenterItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
			' 
			' toggleParagraphAlignmentRightItem1
			' 
			Me.toggleParagraphAlignmentRightItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentRightItem1.Glyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentRightItem1.Id = 30
			Me.toggleParagraphAlignmentRightItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentRightItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
			' 
			' toggleParagraphAlignmentJustifyItem1
			' 
			Me.toggleParagraphAlignmentJustifyItem1.Glyph = (CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.Glyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentJustifyItem1.Id = 31
			Me.toggleParagraphAlignmentJustifyItem1.LargeGlyph = (CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
			' 
			' changeParagraphLineSpacingItem1
			' 
			Me.changeParagraphLineSpacingItem1.Id = 32
			Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1)})
			Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
			toolTipTitleItem15.Text = "Line Spacing"
			toolTipItem15.Text = "Change the spacing between lines of text." & Constants.vbCrLf & Constants.vbCrLf & "You can also customize the amount of" & " space added before and after paragraphs."
			superToolTip15.Items.Add(toolTipTitleItem15)
			superToolTip15.Items.Add(toolTipItem15)
			Me.changeParagraphLineSpacingItem1.SuperTip = superToolTip15
			' 
			' setSingleParagraphSpacingItem1
			' 
			Me.setSingleParagraphSpacingItem1.Id = 33
			Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
			' 
			' setSesquialteralParagraphSpacingItem1
			' 
			Me.setSesquialteralParagraphSpacingItem1.Id = 34
			Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
			' 
			' setDoubleParagraphSpacingItem1
			' 
			Me.setDoubleParagraphSpacingItem1.Id = 35
			Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
			' 
			' showLineSpacingFormItem1
			' 
			Me.showLineSpacingFormItem1.Id = 36
			Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
			toolTipTitleItem10.Text = "Line Spacing Options..."
			toolTipItem10.Text = " "
			superToolTip10.Items.Add(toolTipTitleItem10)
			superToolTip10.Items.Add(toolTipItem10)
			Me.showLineSpacingFormItem1.SuperTip = superToolTip10
			' 
			' addSpacingBeforeParagraphItem1
			' 
			Me.addSpacingBeforeParagraphItem1.Id = 37
			Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
			toolTipTitleItem11.Text = "Add Space &Before Paragraph"
			toolTipItem11.Text = " "
			superToolTip11.Items.Add(toolTipTitleItem11)
			superToolTip11.Items.Add(toolTipItem11)
			Me.addSpacingBeforeParagraphItem1.SuperTip = superToolTip11
			' 
			' removeSpacingBeforeParagraphItem1
			' 
			Me.removeSpacingBeforeParagraphItem1.Id = 38
			Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
			toolTipTitleItem12.Text = "Remove Space &Before Paragraph"
			toolTipItem12.Text = " "
			superToolTip12.Items.Add(toolTipTitleItem12)
			superToolTip12.Items.Add(toolTipItem12)
			Me.removeSpacingBeforeParagraphItem1.SuperTip = superToolTip12
			' 
			' addSpacingAfterParagraphItem1
			' 
			Me.addSpacingAfterParagraphItem1.Id = 39
			Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
			toolTipTitleItem13.Text = "Add Space &After Paragraph"
			toolTipItem13.Text = " "
			superToolTip13.Items.Add(toolTipTitleItem13)
			superToolTip13.Items.Add(toolTipItem13)
			Me.addSpacingAfterParagraphItem1.SuperTip = superToolTip13
			' 
			' removeSpacingAfterParagraphItem1
			' 
			Me.removeSpacingAfterParagraphItem1.Id = 40
			Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
			toolTipTitleItem14.Text = "Remove Space &After Paragraph"
			toolTipItem14.Text = " "
			superToolTip14.Items.Add(toolTipTitleItem14)
			superToolTip14.Items.Add(toolTipItem14)
			Me.removeSpacingAfterParagraphItem1.SuperTip = superToolTip14
			' 
			' toggleNumberingListItem1
			' 
			Me.toggleNumberingListItem1.Glyph = (CType(resources.GetObject("toggleNumberingListItem1.Glyph"), System.Drawing.Image))
			Me.toggleNumberingListItem1.Id = 41
			Me.toggleNumberingListItem1.LargeGlyph = (CType(resources.GetObject("toggleNumberingListItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
			toolTipTitleItem16.Text = "Numbering"
			toolTipItem16.Text = "Start a numbered list."
			superToolTip16.Items.Add(toolTipTitleItem16)
			superToolTip16.Items.Add(toolTipItem16)
			Me.toggleNumberingListItem1.SuperTip = superToolTip16
			' 
			' toggleBulletedListItem1
			' 
			Me.toggleBulletedListItem1.Glyph = (CType(resources.GetObject("toggleBulletedListItem1.Glyph"), System.Drawing.Image))
			Me.toggleBulletedListItem1.Id = 42
			Me.toggleBulletedListItem1.LargeGlyph = (CType(resources.GetObject("toggleBulletedListItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
			toolTipTitleItem17.Text = "Bullets"
			toolTipItem17.Text = "Start a bulleted list."
			superToolTip17.Items.Add(toolTipTitleItem17)
			superToolTip17.Items.Add(toolTipItem17)
			Me.toggleBulletedListItem1.SuperTip = superToolTip17
			' 
			' toggleMultiLevelListItem1
			' 
			Me.toggleMultiLevelListItem1.Glyph = (CType(resources.GetObject("toggleMultiLevelListItem1.Glyph"), System.Drawing.Image))
			Me.toggleMultiLevelListItem1.Id = 43
			Me.toggleMultiLevelListItem1.LargeGlyph = (CType(resources.GetObject("toggleMultiLevelListItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
			toolTipTitleItem18.Text = "Multilevel list"
			toolTipItem18.Text = "Start a multilevel list."
			superToolTip18.Items.Add(toolTipTitleItem18)
			superToolTip18.Items.Add(toolTipItem18)
			Me.toggleMultiLevelListItem1.SuperTip = superToolTip18
			' 
			' decreaseIndentItem1
			' 
			Me.decreaseIndentItem1.Glyph = (CType(resources.GetObject("decreaseIndentItem1.Glyph"), System.Drawing.Image))
			Me.decreaseIndentItem1.Id = 44
			Me.decreaseIndentItem1.LargeGlyph = (CType(resources.GetObject("decreaseIndentItem1.LargeGlyph"), System.Drawing.Image))
			Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
			toolTipTitleItem19.Text = "Decrease Indent"
			toolTipItem19.Text = "Decrease the indent level of the paragraph."
			superToolTip19.Items.Add(toolTipTitleItem19)
			superToolTip19.Items.Add(toolTipItem19)
			Me.decreaseIndentItem1.SuperTip = superToolTip19
			' 
			' increaseIndentItem1
			' 
			Me.increaseIndentItem1.Glyph = (CType(resources.GetObject("increaseIndentItem1.Glyph"), System.Drawing.Image))
			Me.increaseIndentItem1.Id = 45
			Me.increaseIndentItem1.LargeGlyph = (CType(resources.GetObject("increaseIndentItem1.LargeGlyph"), System.Drawing.Image))
			Me.increaseIndentItem1.Name = "increaseIndentItem1"
			toolTipTitleItem20.Text = "Increase Indent"
			toolTipItem20.Text = "Increase the indent level of the paragraph."
			superToolTip20.Items.Add(toolTipTitleItem20)
			superToolTip20.Items.Add(toolTipItem20)
			Me.increaseIndentItem1.SuperTip = superToolTip20
			' 
			' toggleShowWhitespaceItem1
			' 
			Me.toggleShowWhitespaceItem1.Glyph = (CType(resources.GetObject("toggleShowWhitespaceItem1.Glyph"), System.Drawing.Image))
			Me.toggleShowWhitespaceItem1.Id = 46
			Me.toggleShowWhitespaceItem1.LargeGlyph = (CType(resources.GetObject("toggleShowWhitespaceItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
			' 
			' showParagraphFormItem1
			' 
			Me.showParagraphFormItem1.Glyph = (CType(resources.GetObject("showParagraphFormItem1.Glyph"), System.Drawing.Image))
			Me.showParagraphFormItem1.Id = 47
			Me.showParagraphFormItem1.LargeGlyph = (CType(resources.GetObject("showParagraphFormItem1.LargeGlyph"), System.Drawing.Image))
			Me.showParagraphFormItem1.Name = "showParagraphFormItem1"
			toolTipTitleItem21.Text = "Paragraph"
			toolTipItem21.Text = "Show the Paragraph dialog box."
			superToolTip21.Items.Add(toolTipTitleItem21)
			superToolTip21.Items.Add(toolTipItem21)
			Me.showParagraphFormItem1.SuperTip = superToolTip21
			' 
			' editingBar1
			' 
			Me.editingBar1.DockCol = 1
			Me.editingBar1.DockRow = 1
			Me.editingBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.editingBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.findItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.replaceItem1)})
			Me.editingBar1.Offset = 549
			' 
			' findItem1
			' 
			Me.findItem1.Glyph = (CType(resources.GetObject("findItem1.Glyph"), System.Drawing.Image))
			Me.findItem1.Id = 49
			Me.findItem1.LargeGlyph = (CType(resources.GetObject("findItem1.LargeGlyph"), System.Drawing.Image))
			Me.findItem1.Name = "findItem1"
			' 
			' replaceItem1
			' 
			Me.replaceItem1.Glyph = (CType(resources.GetObject("replaceItem1.Glyph"), System.Drawing.Image))
			Me.replaceItem1.Id = 50
			Me.replaceItem1.LargeGlyph = (CType(resources.GetObject("replaceItem1.LargeGlyph"), System.Drawing.Image))
			Me.replaceItem1.Name = "replaceItem1"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(1000, 61)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 516)
			Me.barDockControlBottom.Size = New System.Drawing.Size(1000, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 61)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 455)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(1000, 61)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 455)
			' 
			' changeStyleItem1
			' 
			Me.changeStyleItem1.Edit = Me.repositoryItemRichEditStyleEdit1
			Me.changeStyleItem1.Id = 48
			Me.changeStyleItem1.Name = "changeStyleItem1"
			toolTipTitleItem22.Text = "Quick Styles"
			toolTipItem22.Text = "Format titles, quotes, and other text using this gallery of styles."
			superToolTip22.Items.Add(toolTipTitleItem22)
			superToolTip22.Items.Add(toolTipItem22)
			Me.changeStyleItem1.SuperTip = superToolTip22
			' 
			' repositoryItemRichEditStyleEdit1
			' 
			Me.repositoryItemRichEditStyleEdit1.AutoHeight = False
			Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl2
			Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
			' 
			' richEditBarController1
			' 
			Me.richEditBarController1.BarItems.Add(Me.fileNewItem1)
			Me.richEditBarController1.BarItems.Add(Me.fileOpenItem1)
			Me.richEditBarController1.BarItems.Add(Me.fileSaveItem1)
			Me.richEditBarController1.BarItems.Add(Me.fileSaveAsItem1)
			Me.richEditBarController1.BarItems.Add(Me.quickPrintItem1)
			Me.richEditBarController1.BarItems.Add(Me.printItem1)
			Me.richEditBarController1.BarItems.Add(Me.printPreviewItem1)
			Me.richEditBarController1.BarItems.Add(Me.undoItem1)
			Me.richEditBarController1.BarItems.Add(Me.redoItem1)
			Me.richEditBarController1.BarItems.Add(Me.cutItem1)
			Me.richEditBarController1.BarItems.Add(Me.copyItem1)
			Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeFontNameItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeFontSizeItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeFontColorItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeFontBackColorItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleFontBoldItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleFontItalicItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleFontUnderlineItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleUnderlineItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleFontStrikeoutItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleStrikeoutItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleFontSuperscriptItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleFontSubscriptItem1)
			Me.richEditBarController1.BarItems.Add(Me.fontSizeIncreaseItem1)
			Me.richEditBarController1.BarItems.Add(Me.fontSizeDecreaseItem1)
			Me.richEditBarController1.BarItems.Add(Me.clearFormattingItem1)
			Me.richEditBarController1.BarItems.Add(Me.showFontFormItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentJustifyItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeParagraphLineSpacingItem1)
			Me.richEditBarController1.BarItems.Add(Me.setSingleParagraphSpacingItem1)
			Me.richEditBarController1.BarItems.Add(Me.setSesquialteralParagraphSpacingItem1)
			Me.richEditBarController1.BarItems.Add(Me.setDoubleParagraphSpacingItem1)
			Me.richEditBarController1.BarItems.Add(Me.showLineSpacingFormItem1)
			Me.richEditBarController1.BarItems.Add(Me.addSpacingBeforeParagraphItem1)
			Me.richEditBarController1.BarItems.Add(Me.removeSpacingBeforeParagraphItem1)
			Me.richEditBarController1.BarItems.Add(Me.addSpacingAfterParagraphItem1)
			Me.richEditBarController1.BarItems.Add(Me.removeSpacingAfterParagraphItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleNumberingListItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleBulletedListItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
			Me.richEditBarController1.BarItems.Add(Me.decreaseIndentItem1)
			Me.richEditBarController1.BarItems.Add(Me.increaseIndentItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
			Me.richEditBarController1.BarItems.Add(Me.showParagraphFormItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeStyleItem1)
			Me.richEditBarController1.BarItems.Add(Me.findItem1)
			Me.richEditBarController1.BarItems.Add(Me.replaceItem1)
			Me.richEditBarController1.RichEditControl = Me.richEditControl2
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainer1.Location = New System.Drawing.Point(0, 61)
			Me.splitContainer1.Name = "splitContainer1"
			Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.richEditControl1)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.richEditControl2)
			Me.splitContainer1.Size = New System.Drawing.Size(1000, 455)
			Me.splitContainer1.SplitterDistance = 207
			Me.splitContainer1.TabIndex = 10
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1000, 516)
			Me.Controls.Add(Me.splitContainer1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private commonBar1 As DevExpress.XtraRichEdit.UI.CommonBar
		Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
		Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
		Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
		Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
		Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
		Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
		Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
		Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
		Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
		Private clipboardBar1 As DevExpress.XtraRichEdit.UI.ClipboardBar
		Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
		Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
		Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
		Private fontBar1 As DevExpress.XtraRichEdit.UI.FontBar
		Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
		Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
		Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
		Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
		Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
		Private changeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
		Private toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
		Private toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
		Private toggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
		Private toggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
		Private toggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
		Private toggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
		Private toggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
		Private toggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
		Private fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
		Private fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
		Private clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
		Private showFontFormItem1 As DevExpress.XtraRichEdit.UI.ShowFontFormItem
		Private paragraphBar1 As DevExpress.XtraRichEdit.UI.ParagraphBar
		Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
		Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
		Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
		Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
		Private changeParagraphLineSpacingItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem
		Private setSingleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem
		Private setSesquialteralParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
		Private setDoubleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem
		Private showLineSpacingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem
		Private addSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem
		Private removeSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
		Private addSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem
		Private removeSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
		Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
		Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
		Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
		Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
		Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
		Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
		Private showParagraphFormItem1 As DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
		Private changeStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeStyleItem
		Private repositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
		Private editingBar1 As DevExpress.XtraRichEdit.UI.EditingBar
		Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
		Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
		Private WithEvents richEditControl2 As DevExpress.XtraRichEdit.RichEditControl
		Private splitContainer1 As System.Windows.Forms.SplitContainer
	End Class
End Namespace

