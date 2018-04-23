Imports Microsoft.VisualBasic
Imports System
Namespace ClockTimeEditControl
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.clockTimeEdit1 = New ClockTimeEditControl.ClockTimeEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.clockTimeEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.gridControl1.Location = New System.Drawing.Point(0, 152)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(547, 384)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
'			Me.gridControl1.Load += New System.EventHandler(Me.Form1_Load);
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.RowAutoHeight = True
			' 
			' clockTimeEdit1
			' 
			Me.clockTimeEdit1.EditValue = (CObj(resources.GetObject("clockTimeEdit1.EditValue")))
			Me.clockTimeEdit1.Location = New System.Drawing.Point(0, 12)
			Me.clockTimeEdit1.Name = "clockTimeEdit1"
			Me.clockTimeEdit1.Size = New System.Drawing.Size(137, 134)
			Me.clockTimeEdit1.TabIndex = 1
			Me.clockTimeEdit1.Time = New System.DateTime(2010, 8, 25, 3, 39, 55, 924)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(547, 536)
			Me.Controls.Add(Me.clockTimeEdit1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.clockTimeEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private clockTimeEdit1 As ClockTimeEdit
	End Class
End Namespace