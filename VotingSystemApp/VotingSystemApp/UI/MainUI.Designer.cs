namespace VotingSystemApp
{
    partial class MainUI
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
            this.candidateEntryButton = new System.Windows.Forms.Button();
            this.noOfWinnerButton = new System.Windows.Forms.Button();
            this.voteCastButton = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // candidateEntryButton
            // 
            this.candidateEntryButton.Location = new System.Drawing.Point(65, 12);
            this.candidateEntryButton.Name = "candidateEntryButton";
            this.candidateEntryButton.Size = new System.Drawing.Size(233, 42);
            this.candidateEntryButton.TabIndex = 8;
            this.candidateEntryButton.Text = "Candidate Entry";
            this.candidateEntryButton.UseVisualStyleBackColor = true;
            this.candidateEntryButton.Click += new System.EventHandler(this.candidateEntryButton_Click);
            // 
            // noOfWinnerButton
            // 
            this.noOfWinnerButton.Location = new System.Drawing.Point(65, 60);
            this.noOfWinnerButton.Name = "noOfWinnerButton";
            this.noOfWinnerButton.Size = new System.Drawing.Size(233, 44);
            this.noOfWinnerButton.TabIndex = 8;
            this.noOfWinnerButton.Text = "No Of Winners";
            this.noOfWinnerButton.UseVisualStyleBackColor = true;
            this.noOfWinnerButton.Click += new System.EventHandler(this.noOfWinnerButton_Click);
            // 
            // voteCastButton
            // 
            this.voteCastButton.Location = new System.Drawing.Point(65, 110);
            this.voteCastButton.Name = "voteCastButton";
            this.voteCastButton.Size = new System.Drawing.Size(233, 49);
            this.voteCastButton.TabIndex = 8;
            this.voteCastButton.Text = "Vote Cast";
            this.voteCastButton.UseVisualStyleBackColor = true;
            this.voteCastButton.Click += new System.EventHandler(this.voteCastButton_Click);
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(65, 165);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(233, 49);
            this.resultButton.TabIndex = 8;
            this.resultButton.Text = "Result";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 226);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.voteCastButton);
            this.Controls.Add(this.noOfWinnerButton);
            this.Controls.Add(this.candidateEntryButton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button candidateEntryButton;
        private System.Windows.Forms.Button noOfWinnerButton;
        private System.Windows.Forms.Button voteCastButton;
        private System.Windows.Forms.Button resultButton;

    }
}

