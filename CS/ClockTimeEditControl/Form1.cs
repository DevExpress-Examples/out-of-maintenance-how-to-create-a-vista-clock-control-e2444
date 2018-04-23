using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ClockTimeEditControl {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            gridControl1.DataSource = CreateTable(5);
            this.gridView1.Columns[1].OptionsColumn.AllowEdit = false;
            this.gridView1.CustomDrawCell += gridView1_CustomDrawCell;
        }

        void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if(e.Column != null && e.Column.FieldName == "Time") {
                e.DisplayText = string.Empty;
                e.DefaultDraw();
                VistaClockPainter painter = new VistaClockPainter();
                CalendarControl calendarControl = new CalendarControl() {
                    CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True,
                    CalendarDateEditing = false,
                    Bounds = e.Bounds
                };
                calendarControl.DateTime = (DateTime)this.gridView1.GetRowCellValue(e.RowHandle, e.Column);
                VistaCalendarViewInfo vi = new VistaCalendarViewInfo(calendarControl);
                vi.Appearance.Assign(e.Appearance);
                vi.CalcViewInfo(e.Cache.Graphics);
                int clockWidth = (vi.RightArea as VistaCalendarRightAreaViewInfo).ClockBounds.Width;
                Rectangle drawBounds = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                drawBounds.X = e.Bounds.X + (e.Bounds.Width / 2) - (clockWidth / 2);
                vi.RightArea.CalcViewInfo(drawBounds);
                if(e.Bounds.Width > clockWidth) {
                    painter.Draw(new CalendarControlInfoArgs(vi, e.Cache, drawBounds));
                    e.Handled = true;
                }
            }
        }
        private DataTable CreateTable(int RowCount) {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("Time", typeof(DateTime));
            for(int i = 0; i < RowCount; i++) {
                DateTime date = DateTime.Now.AddDays(i).AddHours(i);
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), date });
            }
            return tbl;
        }
    }
}