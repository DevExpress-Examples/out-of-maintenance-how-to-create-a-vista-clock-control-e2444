Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo

Namespace ClockTimeEditControl
	Public Class ClockTimeEditViewInfo
		Inherits PictureEditViewInfo
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub

		Public Overrides Property EditValue() As Object
			Get
				Return MyBase.EditValue
			End Get
			Set(ByVal value As Object)
				If TypeOf value Is DateTime Then
					value = (CType(Item, RepositoryItemClockTimeEdit)).ConvertTimeToClockImage(CDate(value))
				End If

				MyBase.EditValue = value
			End Set
		End Property
	End Class
End Namespace
