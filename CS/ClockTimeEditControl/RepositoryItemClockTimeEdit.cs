using System;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace ClockTimeEditControl
{
    public class RepositoryItemClockTimeEdit : RepositoryItemPictureEdit
    {
        private RepositoryItemDateEdit innerDateEditProperties;
        private ClockTimeCalendar innerCalendar;
        internal const string EditorName = "ClockTimeEdit";

        static RepositoryItemClockTimeEdit()
        {
            Register();
        }
        public RepositoryItemClockTimeEdit()
        {
            innerDateEditProperties = new RepositoryItemDateEdit();
            innerDateEditProperties.VistaEditTime = DefaultBoolean.True;
            innerCalendar = new ClockTimeCalendar(innerDateEditProperties, DateTime.Now);
        }

        protected virtual Size CalcClockSize()
        {
            Size tempSize = new Size(1000, 1000);
            Bitmap bmp = new Bitmap(tempSize.Width, tempSize.Height);
            Graphics g = Graphics.FromImage(bmp);

            innerCalendar.ClientSize = tempSize;
            return innerCalendar.CalcBestSize(g);
        }

        public virtual Bitmap ConvertTimeToClockImage(DateTime timeToConvert)
        {
            innerCalendar.DateTime = timeToConvert;

            Size calendarSize = CalcClockSize();
            Bitmap bmp = new Bitmap(calendarSize.Width, calendarSize.Height);
            Graphics graphics = Graphics.FromImage(bmp);

            innerCalendar.ClientSize = calendarSize;
            ClockTimeEditInfoArgs args = new ClockTimeEditInfoArgs(innerCalendar);
            args.Graphics = graphics;
            args.CalcLayout(new Rectangle(new Point(0, 0), calendarSize), null);

            VistaDateEditClockPainter painter = new VistaDateEditClockPainter(innerCalendar);
            painter.DrawObject(args);

            return bmp;
        }

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(ClockTimeEdit),
                typeof(RepositoryItemClockTimeEdit), typeof(ClockTimeEditViewInfo),
                    new PictureEditPainter(), true, null));
        }

        public override string EditorTypeName
        {
            get { return EditorName; }
        }
    }
}
