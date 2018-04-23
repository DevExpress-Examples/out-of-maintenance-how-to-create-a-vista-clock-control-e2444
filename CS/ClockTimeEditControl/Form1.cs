using System;
using System.Data;
using System.Windows.Forms;

namespace ClockTimeEditControl
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            gridControl1.DataSource = CreateTable(5);
            gridView1.Columns[1].ColumnEdit = new RepositoryItemClockTimeEdit();
		}

		private DataTable CreateTable(int RowCount)
		{
			DataTable tbl = new DataTable();
			tbl.Columns.Add("Name", typeof(string));
			tbl.Columns.Add("Time", typeof(DateTime));

			for ( int i = 0; i < RowCount; i++ )
				tbl.Rows.Add(new object[] { String.Format("Name{0}", i), DateTime.Now.AddHours(i) });

			return tbl;
		}
	}
}