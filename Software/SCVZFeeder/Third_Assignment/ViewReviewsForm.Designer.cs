namespace Third_Assignment
{
    partial class ViewReviewsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.Button EditBtn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReviews
            // 
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Location = new System.Drawing.Point(16, 15);
            this.dgvReviews.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.RowHeadersWidth = 51;
            this.dgvReviews.Size = new System.Drawing.Size(747, 369);
            this.dgvReviews.TabIndex = 0;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(16, 391);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(100, 28);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(143, 391);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(100, 28);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.button1_Click);
            this.DeleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);

            // 
            // ViewReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.dgvReviews);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewReviewsForm";
            this.Text = "View Reviews";
            this.Load += new System.EventHandler(this.ViewReviewsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button DeleteBtn;
    }

}
