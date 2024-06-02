namespace Third_Assignment
{
    partial class ReviewForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.NumericUpDown scoreNumericUpDown;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button CancleBtn;

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
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.scoreNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.submitButton = new System.Windows.Forms.Button();
            this.CancleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(12, 40);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(316, 116);
            this.commentTextBox.TabIndex = 0;
            // 
            // scoreNumericUpDown
            // 
            this.scoreNumericUpDown.Location = new System.Drawing.Point(12, 12);
            this.scoreNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.scoreNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scoreNumericUpDown.Name = "scoreNumericUpDown";
            this.scoreNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.scoreNumericUpDown.TabIndex = 1;
            this.scoreNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 162);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // CancleBtn
            // 
            this.CancleBtn.Location = new System.Drawing.Point(93, 162);
            this.CancleBtn.Name = "CancleBtn";
            this.CancleBtn.Size = new System.Drawing.Size(75, 23);
            this.CancleBtn.TabIndex = 3;
            this.CancleBtn.Text = "Cancel";
            this.CancleBtn.UseVisualStyleBackColor = true;
            this.CancleBtn.Click += new System.EventHandler(this.CancleBtn_Click);
            // 
            // ReviewForm
            // 
            this.ClientSize = new System.Drawing.Size(453, 226);
            this.Controls.Add(this.CancleBtn);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.scoreNumericUpDown);
            this.Controls.Add(this.commentTextBox);
            this.Name = "ReviewForm";
            this.Text = "Review Form";
            ((System.ComponentModel.ISupportInitialize)(this.scoreNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
