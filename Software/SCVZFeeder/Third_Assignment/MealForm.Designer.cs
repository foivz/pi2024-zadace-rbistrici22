namespace Third_Assignment
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private PI2324_rbistrici22_DBDataSet pI2324_rbistrici22_DBDataSet;
        private System.Windows.Forms.BindingSource mealsBindingSource;
        private PI2324_rbistrici22_DBDataSetTableAdapters.MealsTableAdapter mealsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientsDataGridViewTextBoxColumn;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI2324_rbistrici22_DBDataSet = new Third_Assignment.PI2324_rbistrici22_DBDataSet();
            this.mealsTableAdapter = new Third_Assignment.PI2324_rbistrici22_DBDataSetTableAdapters.MealsTableAdapter();
            this.ReviewBtn = new System.Windows.Forms.Button();
            this.dvgmeal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_rbistrici22_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgmeal)).BeginInit();
            this.SuspendLayout();
            // 
            // mealsBindingSource
            // 
            this.mealsBindingSource.DataMember = "Meals";
            this.mealsBindingSource.DataSource = this.pI2324_rbistrici22_DBDataSet;
            // 
            // pI2324_rbistrici22_DBDataSet
            // 
            this.pI2324_rbistrici22_DBDataSet.DataSetName = "PI2324_rbistrici22_DBDataSet";
            this.pI2324_rbistrici22_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mealsTableAdapter
            // 
            this.mealsTableAdapter.ClearBeforeFill = true;
            // 
            // ReviewBtn
            // 
            this.ReviewBtn.Location = new System.Drawing.Point(12, 386);
            this.ReviewBtn.Name = "ReviewBtn";
            this.ReviewBtn.Size = new System.Drawing.Size(100, 52);
            this.ReviewBtn.TabIndex = 1;
            this.ReviewBtn.Text = "Review";
            this.ReviewBtn.UseVisualStyleBackColor = true;
            this.ReviewBtn.Click += new System.EventHandler(this.ReviewBtn_Click);
            // 
            // dvgmeal
            // 
            this.dvgmeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgmeal.Location = new System.Drawing.Point(12, 21);
            this.dvgmeal.Name = "dvgmeal";
            this.dvgmeal.RowHeadersWidth = 51;
            this.dvgmeal.RowTemplate.Height = 24;
            this.dvgmeal.Size = new System.Drawing.Size(1292, 359);
            this.dvgmeal.TabIndex = 2;
            this.dvgmeal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 450);
            this.Controls.Add(this.dvgmeal);
            this.Controls.Add(this.ReviewBtn);
            this.Name = "MainForm";
            this.Text = "MealForm";
            this.Load += new System.EventHandler(this.aMealForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_rbistrici22_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgmeal)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button ReviewBtn;
        private System.Windows.Forms.DataGridView dvgmeal;
    }
}
