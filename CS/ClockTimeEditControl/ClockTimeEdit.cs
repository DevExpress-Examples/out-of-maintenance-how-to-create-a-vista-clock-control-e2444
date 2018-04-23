using System;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ClockTimeEditControl
{
    public class ClockTimeEdit : PictureEdit
    {
        private DateTime time;

        static ClockTimeEdit()
        {
            RepositoryItemClockTimeEdit.Register();
        }
        public ClockTimeEdit()
        {
            time = DateTime.Now;
        }

        protected override void OnEditValueChanged()
        {
            base.OnEditValueChanged();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemClockTimeEdit Properties
        {
            get
            {
                return (RepositoryItemClockTimeEdit)base.Properties;
            }
        }
        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemClockTimeEdit.EditorName;
            }
        }
        public DateTime Time
        {
            get
            {
                return time;
            }
            set
            {
                EditValue = value;
            }
        }
        public override object EditValue
        {
            get
            {
                return base.EditValue;
            }
            set
            {
                if ( time != null && value == null )
                    value = time;

                if ( value is DateTime )
                {
                    time = (DateTime)value;
                    value = Properties.ConvertTimeToClockImage(time);
                }

                base.EditValue = value;
            }
        }
    }

}
