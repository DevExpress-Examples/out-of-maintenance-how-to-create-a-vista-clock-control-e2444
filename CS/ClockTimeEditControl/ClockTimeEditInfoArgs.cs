using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;

namespace ClockTimeEditControl
{
    public class ClockTimeEditInfoArgs : VistaDateEditInfoArgs
    {
        public ClockTimeEditInfoArgs(DateEditCalendarBase calendar)
            : base(calendar)
        {
        }

        protected override void CalcClockInfo()
        {
            base.CalcClockInfo();

            ClockRect = new Rectangle(ClockRect.X - ClockRect.X, ClockRect.Y - ClockRect.Y, ClockRect.Width, ClockRect.Height);
            CalcClockPoints();
        }
    }
}
