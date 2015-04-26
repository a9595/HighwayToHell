using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighWayToHell
{
	public partial class Form1 : Form
	{
		private ConnectionStringEF context = new ConnectionStringEF();
		public Form1()
		{
			InitializeComponent();
			StudentsGridView.AutoGenerateColumns = false;
			StudentsGridView.DataSource = context.student.ToList();
			
			DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
			comboColumn.DataSource = context.group.ToList();
			comboColumn.ValueMember = "id";
			comboColumn.Name = "group name";
			comboColumn.DisplayMember = "name";
			comboColumn.DataPropertyName = "id";
			StudentsGridView.Columns.Add(comboColumn);

			Random r = new Random();
			int rez = r.Next(1, 100);
			MessageBox.Show(rez.ToString());
		}
	}
}
