namespace Third_Assignment
{
    partial class EditReviewForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.NumericUpDown scoreNumericUpDown;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button btnSave;

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
            this.scoreNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreNumericUpDown)).BeginInit();
            this.SuspendLayout();

            // scoreNumericUpDown
            this.scoreNumericUpDown.Location = new System.Drawing.Point(12, 12);
            this.scoreNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.scoreNumericUpDown.Name = "scoreNumericUpDown";
            this.scoreNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.scoreNumericUpDown.TabIndex = 0;

            // commentTextBox
            this.commentTextBox.Location = new System.Drawing.Point(12, 38);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(260, 100);
            this.commentTextBox.TabIndex = 1;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(197, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // EditReviewForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.scoreNumericUpDown);
            this.Name = "EditReviewForm";
            this.Text = "Edit Review";
            ((System.ComponentModel.ISupportInitialize)(this.scoreNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
