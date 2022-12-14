namespace forms_app
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.órákBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kurzusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sávDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teremDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.órákBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(19, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 229);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kurzusDataGridViewTextBoxColumn,
            this.napDataGridViewTextBoxColumn,
            this.sávDataGridViewTextBoxColumn,
            this.teremDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.órákBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(178, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(434, 229);
            this.dataGridView1.TabIndex = 2;
            // 
            // órákBindingSource
            // 
            this.órákBindingSource.DataSource = typeof(forms_app.Órák);
            // 
            // kurzusDataGridViewTextBoxColumn
            // 
            this.kurzusDataGridViewTextBoxColumn.DataPropertyName = "Kurzus";
            this.kurzusDataGridViewTextBoxColumn.HeaderText = "Kurzus";
            this.kurzusDataGridViewTextBoxColumn.Name = "kurzusDataGridViewTextBoxColumn";
            // 
            // napDataGridViewTextBoxColumn
            // 
            this.napDataGridViewTextBoxColumn.DataPropertyName = "Nap";
            this.napDataGridViewTextBoxColumn.HeaderText = "Nap";
            this.napDataGridViewTextBoxColumn.Name = "napDataGridViewTextBoxColumn";
            // 
            // sávDataGridViewTextBoxColumn
            // 
            this.sávDataGridViewTextBoxColumn.DataPropertyName = "Sáv";
            this.sávDataGridViewTextBoxColumn.HeaderText = "Sáv";
            this.sávDataGridViewTextBoxColumn.Name = "sávDataGridViewTextBoxColumn";
            // 
            // teremDataGridViewTextBoxColumn
            // 
            this.teremDataGridViewTextBoxColumn.DataPropertyName = "Terem";
            this.teremDataGridViewTextBoxColumn.HeaderText = "Terem";
            this.teremDataGridViewTextBoxColumn.Name = "teremDataGridViewTextBoxColumn";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(615, 404);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.órákBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kurzusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn napDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sávDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teremDataGridViewTextBoxColumn;
        private BindingSource órákBindingSource;
    }
}
