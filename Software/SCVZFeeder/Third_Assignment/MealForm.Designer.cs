namespace Third_Assignment
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.BindingSource mealsBindingSource;
        private System.Windows.Forms.TextBox searchTextBox;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.ReviewBtn = new System.Windows.Forms.Button();
            this.dvgmeal = new System.Windows.Forms.DataGridView();
            this.ViewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgmeal)).BeginInit();
            this.SuspendLayout();

            // searchTextBox
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 22);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);

            // ReviewBtn
            this.ReviewBtn.Location = new System.Drawing.Point(12, 386);
            this.ReviewBtn.Name = "ReviewBtn";
            this.ReviewBtn.Size = new System.Drawing.Size(100, 52);
            this.ReviewBtn.TabIndex = 2;
            this.ReviewBtn.Text = "Review";
            this.ReviewBtn.UseVisualStyleBackColor = true;
            this.ReviewBtn.Click += new System.EventHandler(this.ReviewBtn_Click);

            // dvgmeal
            this.dvgmeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgmeal.Location = new System.Drawing.Point(12, 50);
            this.dvgmeal.Name = "dvgmeal";
            this.dvgmeal.RowHeadersWidth = 51;
            this.dvgmeal.RowTemplate.Height = 24;
            this.dvgmeal.Size = new System.Drawing.Size(1292, 330);
            this.dvgmeal.TabIndex = 3;
            this.dvgmeal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmeal_CellContentClick);

            // ViewBtn
            this.ViewBtn.Location = new System.Drawing.Point(135, 386);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(97, 52);
            this.ViewBtn.TabIndex = 4;
            this.ViewBtn.Text = "View Review";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 450);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.dvgmeal);
            this.Controls.Add(this.ReviewBtn);
            this.Controls.Add(this.searchTextBox);
            this.Name = "MainForm";
            this.Text = "MealForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgmeal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button ReviewBtn;
        private System.Windows.Forms.DataGridView dvgmeal;
        private System.Windows.Forms.Button ViewBtn;
    }
}
