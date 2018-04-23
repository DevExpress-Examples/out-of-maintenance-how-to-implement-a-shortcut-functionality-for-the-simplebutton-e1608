Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports System
Imports System.Windows.Forms

Namespace DXSample
	Public Class MySimpleButton
		Inherits SimpleButton
		Public Sub New()
			MyBase.New()
		End Sub

		Private manager_Renamed As BarManager
		Public Property Manager() As BarManager
			Get
				Return manager_Renamed
			End Get
			Set(ByVal value As BarManager)
				manager_Renamed = value
			End Set
		End Property

		Private shortcut_Renamed As Keys
		Public Property Shortcut() As Keys
			Get
				Return shortcut_Renamed
			End Get
			Set(ByVal value As Keys)
				shortcut_Renamed = value
			End Set
		End Property

		Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
			MyBase.OnHandleCreated(e)
			If manager_Renamed Is Nothing OrElse shortcut_Renamed = Keys.None Then
				Return
			End If
			Dim item As Integer = manager_Renamed.Items.Add(New BarButtonItem(manager_Renamed, String.Concat("bbi_", Name), -1, New BarShortcut(Shortcut)))
			AddHandler manager_Renamed.Items(item).ItemClick, AddressOf OnBarButtonItemItemClick
		End Sub

		Private Sub OnBarButtonItemItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Me.PerformClick()
		End Sub
	End Class
End Namespace