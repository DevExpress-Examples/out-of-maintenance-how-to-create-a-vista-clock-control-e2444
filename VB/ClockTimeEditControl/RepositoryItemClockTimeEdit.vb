Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository

Namespace ClockTimeEditControl
	Public Class RepositoryItemClockTimeEdit
		Inherits RepositoryItemPictureEdit
		Private innerDateEditProperties As RepositoryItemDateEdit
		Private innerCalendar As ClockTimeCalendar
		Friend Const EditorName As String = "ClockTimeEdit"

		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
			innerDateEditProperties = New RepositoryItemDateEdit()
			innerDateEditProperties.VistaEditTime = DefaultBoolean.True
			innerCalendar = New ClockTimeCalendar(innerDateEditProperties, DateTime.Now)
		End Sub

		Protected Overridable Function CalcClockSize() As Size
			Dim tempSize As New Size(1000, 1000)
			Dim bmp As New Bitmap(tempSize.Width, tempSize.Height)
			Dim g As Graphics = Graphics.FromImage(bmp)

			innerCalendar.ClientSize = tempSize
			Return innerCalendar.CalcBestSize(g)
		End Function

		Public Overridable Function ConvertTimeToClockImage(ByVal timeToConvert As DateTime) As Bitmap
			innerCalendar.DateTime = timeToConvert

			Dim calendarSize As Size = CalcClockSize()
			Dim bmp As New Bitmap(calendarSize.Width, calendarSize.Height)
			Dim graphics As Graphics = Graphics.FromImage(bmp)

			innerCalendar.ClientSize = calendarSize
			Dim args As New ClockTimeEditInfoArgs(innerCalendar)
			args.Graphics = graphics
			args.CalcLayout(New Rectangle(New Point(0, 0), calendarSize), Nothing)

			Dim painter As New VistaDateEditClockPainter(innerCalendar)
			painter.DrawObject(args)

			Return bmp
		End Function

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(ClockTimeEdit), GetType(RepositoryItemClockTimeEdit), GetType(ClockTimeEditViewInfo), New PictureEditPainter(), True))
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property
	End Class
End Namespace
