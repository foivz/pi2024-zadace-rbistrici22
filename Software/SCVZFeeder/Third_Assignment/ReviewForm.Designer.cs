namespace Third_Assignment
{
    partial class ReviewForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.ComboBox scoreComboBox;
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
            this.scoreComboBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.CancleBtn = new System.Windows.Forms.Button();
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
            // scoreComboBox
            // 
            this.scoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scoreComboBox.FormattingEnabled = true;
            this.scoreComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.scoreComboBox.Location = new System.Drawing.Point(12, 12);
            this.scoreComboBox.Name = "scoreComboBox";
            this.scoreComboBox.Size = new System.Drawing.Size(121, 24);
            this.scoreComboBox.TabIndex = 1;
            this.scoreComboBox.SelectedIndexChanged += new System.EventHandler(this.scoreComboBox_SelectedIndexChanged);
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
            this.Controls.Add(this.scoreComboBox);
            this.Controls.Add(this.commentTextBox);
            this.Name = "ReviewForm";
            this.Text = "Review Form";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
