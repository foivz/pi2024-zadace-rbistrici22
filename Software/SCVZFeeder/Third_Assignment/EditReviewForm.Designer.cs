namespace Third_Assignment
{
    partial class EditReviewForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox scoreComboBox;
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
            this.scoreComboBox = new System.Windows.Forms.ComboBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoreComboBox
            // 
            this.scoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scoreComboBox.FormattingEnabled = true;
            this.scoreComboBox.Location = new System.Drawing.Point(16, 15);
            this.scoreComboBox.Name = "scoreComboBox";
            this.scoreComboBox.Size = new System.Drawing.Size(160, 24);
            this.scoreComboBox.TabIndex = 0;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(16, 47);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(345, 122);
            this.commentTextBox.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(263, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 220);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.scoreComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditReviewForm";
            this.Text = "Edit Review";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
