using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkDAL;

namespace HighWayToHell
{
	public partial class Form1 : Form
	{
		private readonly ConnectionStringEF _context = new ConnectionStringEF();
		private ContextEntityFramework _contextEntityFramework = new ContextEntityFramework();
		public Form1()
		{
			InitializeComponent();
			StudentsGridView.AutoGenerateColumns = false;
			StudentsGridView.DataSource = _context.student.ToList();


		

			DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn
			{
				DataSource = _context.@group.ToList(),
				ValueMember = "id",
				Name = "group name",
				DisplayMember = "name",
				DataPropertyName = "id"
			};
			StudentsGridView.Columns.Add(comboColumn);

			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
//			//((DbSet)_contextEntityFramework.student).Load();
//			BindingSource bi = new BindingSource();
//			bi.DataSource = _contextEntityFramework.student.ToList();
//			DALdataGridView2.DataSource = bi;

			studentBindingSource.DataSource = _contextEntityFramework.student.ToList();
		}
	}
}
