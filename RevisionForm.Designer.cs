namespace RTK_Revisor
{
    partial class RevisionForm
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
            this.flashCardLabel = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.flipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flashCardLabel
            // 
            this.flashCardLabel.AutoSize = true;
            this.flashCardLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flashCardLabel.Location = new System.Drawing.Point(337, 195);
            this.flashCardLabel.Name = "flashCardLabel";
            this.flashCardLabel.Size = new System.Drawing.Size(99, 45);
            this.flashCardLabel.TabIndex = 0;
            this.flashCardLabel.Text = "Word";
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(172, 409);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(128, 43);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(472, 409);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(128, 43);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            // 
            // flipButton
            // 
            this.flipButton.Location = new System.Drawing.Point(327, 409);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(128, 43);
            this.flipButton.TabIndex = 3;
            this.flipButton.Text = "Flip";
            this.flipButton.UseVisualStyleBackColor = true;
            // 
            // RevisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 498);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.flashCardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RevisionForm";
            this.Text = "RevisionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label flashCardLabel;
        private Button yesButton;
        private Button noButton;
        private Button flipButton;
    }
}