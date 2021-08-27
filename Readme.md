<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128619973/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2444)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ClockTimeEditControl/Form1.cs) (VB: [Form1.vb](./VB/ClockTimeEditControl/Form1.vb))
* [Program.cs](./CS/ClockTimeEditControl/Program.cs) (VB: [Program.vb](./VB/ClockTimeEditControl/Program.vb))
<!-- default file list end -->
# How to create a vista clock control


<p>In this example we have created a Vista clock control that can act as a standalone control or can be assigned as an in-place editor to a grid view's data cell. As a basis for the control we took the PictureEdit and enabled it to show our clock as loaded bitmap. The bitmap is drawn by the VistaDateEditClockPainter class instance used to draw the clock in a standard DX DateEdit control.</p>


<h3>Description</h3>

<p>Starting with the version 15.2 of our components, it is possible to use&nbsp;<strong>CalendarControl&nbsp;</strong>for this task. Set the&nbsp;<strong>CalendarDateEditing</strong>&nbsp;and&nbsp;<strong>CalendarTimeEditing</strong>&nbsp;properties to complete this task.<br>To show a clock in a Grid cell, handle the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_CustomDrawCelltopic">CustomDrawCell</a>&nbsp;event and use the&nbsp;<strong>VistaClockPainter</strong>&nbsp;and&nbsp;<strong>VistaCalendarViewInfo&nbsp;</strong>classes to draw the clock.</p>

<br/>


