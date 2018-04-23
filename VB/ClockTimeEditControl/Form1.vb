Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.CustomEditor
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace ClockTimeEditControl
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles gridControl1.Load
            gridControl1.DataSource = CreateTable(5)
            Me.gridView1.Columns(1).OptionsColumn.AllowEdit = False
            AddHandler Me.gridView1.CustomDrawCell, AddressOf gridView1_CustomDrawCell
        End Sub

        Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
            If e.Column IsNot Nothing AndAlso e.Column.FieldName = "Time" Then
                e.DisplayText = String.Empty
                e.DefaultDraw()
                Dim painter As New VistaClockPainter()
                Dim calendarControl As New CalendarControl() With {.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True, .CalendarDateEditing = False, .Bounds = e.Bounds}
                calendarControl.DateTime = CDate(Me.gridView1.GetRowCellValue(e.RowHandle, e.Column))
                Dim vi As New VistaCalendarViewInfo(calendarControl)
                vi.Appearance.Assign(e.Appearance)
                vi.CalcViewInfo(e.Cache.Graphics)
                Dim clockWidth As Integer = (TryCast(vi.RightArea, VistaCalendarRightAreaViewInfo)).ClockBounds.Width
                Dim drawBounds As New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                drawBounds.X = e.Bounds.X + (e.Bounds.Width \ 2) - (clockWidth \ 2)
                vi.RightArea.CalcViewInfo(drawBounds)
                If e.Bounds.Width > clockWidth Then
                    painter.Draw(New CalendarControlInfoArgs(vi, e.Cache, drawBounds))
                    e.Handled = True
                End If
            End If
        End Sub
        Private Function CreateTable(ByVal RowCount As Integer) As DataTable
            Dim tbl As New DataTable()
            tbl.Columns.Add("Name", GetType(String))
            tbl.Columns.Add("Time", GetType(Date))
            For i As Integer = 0 To RowCount - 1
                Dim [date] As Date = Date.Now.AddDays(i).AddHours(i)
                tbl.Rows.Add(New Object() { String.Format("Name{0}", i), [date] })
            Next i
            Return tbl
        End Function
    End Class
End Namespace