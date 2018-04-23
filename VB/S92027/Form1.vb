Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

Namespace S92027
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnShowMessaageClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			XtraMessageBox.Show("Test", "DXSample")
		End Sub

		Private Sub OnCloseClick(ByVal sender As Object, ByVal e As EventArgs) Handles mySimpleButton2.Click
			Close()
		End Sub
	End Class
End Namespace