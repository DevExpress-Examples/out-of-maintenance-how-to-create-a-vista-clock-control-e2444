Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.ViewInfo

Namespace ClockTimeEditControl
	Public Class ClockTimeEditInfoArgs
		Inherits VistaDateEditInfoArgs
		Public Sub New(ByVal calendar As DateEditCalendarBase)
			MyBase.New(calendar)
		End Sub

		Protected Overrides Sub CalcClockInfo()
			MyBase.CalcClockInfo()

			ClockRect = New Rectangle(ClockRect.X - ClockRect.X, ClockRect.Y - ClockRect.Y, ClockRect.Width, ClockRect.Height)
			CalcClockPoints()
		End Sub
	End Class
End Namespace
