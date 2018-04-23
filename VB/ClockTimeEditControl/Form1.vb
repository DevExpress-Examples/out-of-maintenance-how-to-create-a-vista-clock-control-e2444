Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace ClockTimeEditControl
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles gridControl1.Load
			gridControl1.DataSource = CreateTable(5)
			gridView1.Columns(1).ColumnEdit = New RepositoryItemClockTimeEdit()
		End Sub

		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("Time", GetType(DateTime))

			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), DateTime.Now.AddHours(i) })
			Next i

			Return tbl
		End Function
	End Class
End Namespace