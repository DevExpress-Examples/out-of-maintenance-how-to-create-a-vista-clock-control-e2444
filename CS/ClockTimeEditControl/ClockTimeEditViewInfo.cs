using System;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace ClockTimeEditControl
{
    public class ClockTimeEditViewInfo : PictureEditViewInfo
    {
        public ClockTimeEditViewInfo(RepositoryItem item)
            : base(item)
        {
        }

        public override object EditValue
        {
            get { return base.EditValue; }
            set
            {
                if ( value is DateTime )
                    value = ((RepositoryItemClockTimeEdit)Item).ConvertTimeToClockImage((DateTime)value);

                base.EditValue = value;
            }
        }
    }
}
