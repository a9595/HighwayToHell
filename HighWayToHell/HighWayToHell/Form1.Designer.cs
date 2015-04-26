namespace HighWayToHell
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.StudentsGridView = new System.Windows.Forms.DataGridView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eska = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// StudentsGridView
			// 
			this.StudentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.StudentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.eska,
            this.surname});
			this.StudentsGridView.Location = new System.Drawing.Point(0, 0);
			this.StudentsGridView.Name = "StudentsGridView";
			this.StudentsGridView.Size = new System.Drawing.Size(825, 201);
			this.StudentsGridView.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.eskaDataGridViewTextBoxColumn,
            this.groupIdDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.studentBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 233);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(825, 150);
			this.dataGridView1.TabIndex = 1;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// surnameDataGridViewTextBoxColumn
			// 
			this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
			this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
			this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
			// 
			// eskaDataGridViewTextBoxColumn
			// 
			this.eskaDataGridViewTextBoxColumn.DataPropertyName = "eska";
			this.eskaDataGridViewTextBoxColumn.HeaderText = "eska";
			this.eskaDataGridViewTextBoxColumn.Name = "eskaDataGridViewTextBoxColumn";
			// 
			// groupIdDataGridViewTextBoxColumn
			// 
			this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "groupId";
			this.groupIdDataGridViewTextBoxColumn.HeaderText = "groupId";
			this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
			this.groupIdDataGridViewTextBoxColumn.Visible = false;
			// 
			// groupDataGridViewTextBoxColumn
			// 
			this.groupDataGridViewTextBoxColumn.DataPropertyName = "group";
			this.groupDataGridViewTextBoxColumn.HeaderText = "group";
			this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
			// 
			// studentBindingSource
			// 
			this.studentBindingSource.DataSource = typeof(HighWayToHell.student);
			// 
			// name
			// 
			this.name.DataPropertyName = "name";
			this.name.HeaderText = "name";
			this.name.Name = "name";
			// 
			// eska
			// 
			this.eska.DataPropertyName = "eska";
			this.eska.HeaderText = "eska";
			this.eska.Name = "eska";
			// 
			// surname
			// 
			this.surname.DataPropertyName = "surname";
			this.surname.HeaderText = "surname";
			this.surname.Name = "surname";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 784);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.StudentsGridView);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView StudentsGridView;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource studentBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn eskaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn eska;
		private System.Windows.Forms.DataGridViewTextBoxColumn surname;
	}
}

