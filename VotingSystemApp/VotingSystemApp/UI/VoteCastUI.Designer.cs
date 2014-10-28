namespace VotingSystemApp
{
    partial class VoteCastUI
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
            this.voteSymbolComboBox = new System.Windows.Forms.ComboBox();
            this.castButton = new System.Windows.Forms.Button();
            this.voteremailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // voteSymbolComboBox
            // 
            this.voteSymbolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voteSymbolComboBox.FormattingEnabled = true;
            this.voteSymbolComboBox.Location = new System.Drawing.Point(171, 79);
            this.voteSymbolComboBox.Name = "voteSymbolComboBox";
            this.voteSymbolComboBox.Size = new System.Drawing.Size(254, 21);
            this.voteSymbolComboBox.TabIndex = 10;
            // 
            // castButton
            // 
            this.castButton.Location = new System.Drawing.Point(341, 107);
            this.castButton.Name = "castButton";
            this.castButton.Size = new System.Drawing.Size(84, 23);
            this.castButton.TabIndex = 9;
            this.castButton.Text = "Cast";
            this.castButton.UseVisualStyleBackColor = true;
            this.castButton.Click += new System.EventHandler(this.castButton_Click);
            // 
            // voteremailTextBox
            // 
            this.voteremailTextBox.Location = new System.Drawing.Point(171, 51);
            this.voteremailTextBox.Name = "voteremailTextBox";
            this.voteremailTextBox.Size = new System.Drawing.Size(254, 20);
            this.voteremailTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Symbol Of Candidate ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Voter Email Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cast Your Voter";
            // 
            // VoteCastUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 137);
            this.Controls.Add(this.voteSymbolComboBox);
            this.Controls.Add(this.castButton);
            this.Controls.Add(this.voteremailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VoteCastUI";
            this.Text = "VoteCastUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox voteSymbolComboBox;
        private System.Windows.Forms.Button castButton;
        private System.Windows.Forms.TextBox voteremailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}