namespace GetFiles
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PathInputValue = new System.Windows.Forms.TextBox();
            this.ExtInputValue = new System.Windows.Forms.TextBox();
            this.StringInputValue = new System.Windows.Forms.TextBox();
            this.ResultsBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(124, 422);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(99, 35);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(333, 422);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(113, 35);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "CANCEL";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "PATH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "EXT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "TEXT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "RESULTS";
            // 
            // PathInputValue
            // 
            this.PathInputValue.AutoCompleteCustomSource.AddRange(new string[] {
            ".txt",
            ".json",
            ".xml",
            ".doc"});
            this.PathInputValue.Location = new System.Drawing.Point(124, 41);
            this.PathInputValue.Name = "PathInputValue";
            this.PathInputValue.Size = new System.Drawing.Size(286, 22);
            this.PathInputValue.TabIndex = 6;
            this.PathInputValue.Text = "C:\\Users\\ClevelandCodes\\Desktop\\HWFiles";
            // 
            // ExtInputValue
            // 
            this.ExtInputValue.AutoCompleteCustomSource.AddRange(new string[] {
            ".txt",
            ".json",
            ".xml",
            ".doc"});
            this.ExtInputValue.Location = new System.Drawing.Point(124, 102);
            this.ExtInputValue.Name = "ExtInputValue";
            this.ExtInputValue.Size = new System.Drawing.Size(286, 22);
            this.ExtInputValue.TabIndex = 7;
            // 
            // StringInputValue
            // 
            this.StringInputValue.Location = new System.Drawing.Point(124, 158);
            this.StringInputValue.Name = "StringInputValue";
            this.StringInputValue.Size = new System.Drawing.Size(286, 22);
            this.StringInputValue.TabIndex = 8;
            // 
            // ResultsBox
            // 
            this.ResultsBox.FormattingEnabled = true;
            this.ResultsBox.ItemHeight = 16;
            this.ResultsBox.Location = new System.Drawing.Point(124, 220);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.Size = new System.Drawing.Size(467, 180);
            this.ResultsBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 487);
            this.Controls.Add(this.ResultsBox);
            this.Controls.Add(this.StringInputValue);
            this.Controls.Add(this.ExtInputValue);
            this.Controls.Add(this.PathInputValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PathInputValue;
        private System.Windows.Forms.TextBox ExtInputValue;
        private System.Windows.Forms.TextBox StringInputValue;
        private System.Windows.Forms.ListBox ResultsBox;
    }
}

