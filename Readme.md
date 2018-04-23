# How to create a vista clock control


<p>In this example we have created a Vista clock control that can act as a standalone control or can be assigned as an in-place editor to a grid view's data cell. As a basis for the control we took the PictureEdit and enabled it to show our clock as loaded bitmap. The bitmap is drawn by the VistaDateEditClockPainter class instance used to draw the clock in a standard DX DateEdit control.</p>


<h3>Description</h3>

<p>Starting with the version 15.2 of our components, it is possible to use&nbsp;<strong>CalendarControl&nbsp;</strong>for this task. Set the&nbsp;<strong>CalendarDateEditing</strong>&nbsp;and&nbsp;<strong>CalendarTimeEditing</strong>&nbsp;properties to complete this task.<br>To show a clock in a Grid cell, handle the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_CustomDrawCelltopic">CustomDrawCell</a>&nbsp;event and use the&nbsp;<strong>VistaClockPainter</strong>&nbsp;and&nbsp;<strong>VistaCalendarViewInfo&nbsp;</strong>classes to draw the clock.</p>

<br/>


