using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace ClockTimeEditControl
{
    public class ClockTimeCalendar : VistaDateEditCalendar
    {
        public ClockTimeCalendar(RepositoryItemDateEdit item, object editDate)
            : base(item, editDate)
        {
        }

        public override Size CalcBestSize(Graphics g)
        {
            Size sz = base.CalcBestSize(g);

            return VistaCalendar.ClockRect.Size;
        }
    }
}
