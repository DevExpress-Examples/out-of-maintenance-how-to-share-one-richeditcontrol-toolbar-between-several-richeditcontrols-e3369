Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit

Namespace RichEditTwoControlsOneToolbar
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub richEditControl_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl1.Enter, richEditControl2.Enter
			Dim richEditControl As RichEditControl = CType(sender, RichEditControl)
			richEditBarController1.RichEditControl = richEditControl
		End Sub
	End Class
End Namespace