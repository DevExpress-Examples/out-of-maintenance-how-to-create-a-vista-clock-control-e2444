Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace ClockTimeEditControl
	Public Class ClockTimeEdit
		Inherits PictureEdit
		Private _time As DateTime

		Shared Sub New()
			RepositoryItemClockTimeEdit.Register()
		End Sub
		Public Sub New()
			_time = DateTime.Now
		End Sub

		Protected Overrides Sub OnEditValueChanged()
			MyBase.OnEditValueChanged()
		End Sub

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemClockTimeEdit
			Get
				Return CType(MyBase.Properties, RepositoryItemClockTimeEdit)
			End Get
		End Property
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemClockTimeEdit.EditorName
			End Get
		End Property
		Public Property Time() As DateTime
			Get
				Return _time
			End Get
			Set(ByVal value As DateTime)
				EditValue = value
			End Set
		End Property
		Public Overrides Property EditValue() As Object
			Get
				Return MyBase.EditValue
			End Get
			Set(ByVal value As Object)
                If _time <> Nothing AndAlso value Is Nothing Then
                    value = _time
                End If

				If TypeOf value Is DateTime Then
					_time = CDate(value)
					value = Properties.ConvertTimeToClockImage(_time)
				End If

				MyBase.EditValue = value
			End Set
		End Property
	End Class

End Namespace
