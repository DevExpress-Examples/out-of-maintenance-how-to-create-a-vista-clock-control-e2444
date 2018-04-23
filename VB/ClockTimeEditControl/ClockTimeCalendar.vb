Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository

Namespace ClockTimeEditControl
	Public Class ClockTimeCalendar
		Inherits VistaDateEditCalendar
		Public Sub New(ByVal item As RepositoryItemDateEdit, ByVal editDate As Object)
			MyBase.New(item, editDate)
		End Sub

		Public Overrides Function CalcBestSize(ByVal g As Graphics) As Size
			Dim sz As Size = MyBase.CalcBestSize(g)

			Return VistaCalendar.ClockRect.Size
		End Function
	End Class
End Namespace
