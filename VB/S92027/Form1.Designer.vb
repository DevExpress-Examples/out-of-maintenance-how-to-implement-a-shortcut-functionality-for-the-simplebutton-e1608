Imports Microsoft.VisualBasic
Imports System
Namespace S92027
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
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.simpleButton1 = New DXSample.MySimpleButton()
			Me.mySimpleButton2 = New DXSample.MySimpleButton()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.MaxItemId = 0
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(22, 238)
			Me.simpleButton1.Manager = Me.barManager1
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Shortcut = System.Windows.Forms.Keys.F3
			Me.simpleButton1.Size = New System.Drawing.Size(120, 23)
			Me.simpleButton1.TabIndex = 4
			Me.simpleButton1.Text = "Show Message (F3)"
'			Me.simpleButton1.Click += New System.EventHandler(Me.OnShowMessaageClick);
			' 
			' mySimpleButton2
			' 
			Me.mySimpleButton2.Location = New System.Drawing.Point(194, 238)
			Me.mySimpleButton2.Manager = Me.barManager1
			Me.mySimpleButton2.Name = "mySimpleButton2"
			Me.mySimpleButton2.Shortcut = (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys))
			Me.mySimpleButton2.Size = New System.Drawing.Size(125, 23)
			Me.mySimpleButton2.TabIndex = 5
			Me.mySimpleButton2.Text = "Exit (Control+X)"
'			Me.mySimpleButton2.Click += New System.EventHandler(Me.OnCloseClick);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(367, 273)
			Me.Controls.Add(Me.mySimpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents mySimpleButton2 As DXSample.MySimpleButton
		Private WithEvents simpleButton1 As DXSample.MySimpleButton
	End Class
End Namespace

