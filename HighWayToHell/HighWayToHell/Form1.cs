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
			StudentsGridView.DataSource = context.student.ToList();
		}
	}
}
