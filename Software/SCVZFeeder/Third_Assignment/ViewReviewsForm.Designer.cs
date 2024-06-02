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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            this.SuspendLayout();

            // dgvReviews
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Location = new System.Drawing.Point(12, 12);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.Size = new System.Drawing.Size(560, 300);
            this.dgvReviews.TabIndex = 0;

            // EditBtn
            this.EditBtn.Location = new System.Drawing.Point(12, 318);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);

            // ViewReviewsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.dgvReviews);
            this.Name = "ViewReviewsForm";
            this.Text = "View Reviews";
            this.Load += new System.EventHandler(this.ViewReviewsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.ResumeLayout(false);
        }
    }

}
