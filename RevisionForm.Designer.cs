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
            this.rtkIndexLabel = new System.Windows.Forms.Label();
            this.shuffleCheckBox = new System.Windows.Forms.CheckBox();
            this.answerInEnglishCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // flashCardLabel
            // 
            this.flashCardLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flashCardLabel.Location = new System.Drawing.Point(172, 195);
            this.flashCardLabel.Name = "flashCardLabel";
            this.flashCardLabel.Size = new System.Drawing.Size(428, 45);
            this.flashCardLabel.TabIndex = 0;
            this.flashCardLabel.Text = "Word";
            this.flashCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(172, 409);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(128, 43);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(472, 409);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(128, 43);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // flipButton
            // 
            this.flipButton.Location = new System.Drawing.Point(327, 409);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(128, 43);
            this.flipButton.TabIndex = 3;
            this.flipButton.Text = "Flip";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // rtkIndexLabel
            // 
            this.rtkIndexLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtkIndexLabel.Location = new System.Drawing.Point(172, 319);
            this.rtkIndexLabel.Name = "rtkIndexLabel";
            this.rtkIndexLabel.Size = new System.Drawing.Size(428, 45);
            this.rtkIndexLabel.TabIndex = 4;
            this.rtkIndexLabel.Text = "<rtk index>";
            this.rtkIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shuffleCheckBox
            // 
            this.shuffleCheckBox.AutoSize = true;
            this.shuffleCheckBox.Location = new System.Drawing.Point(31, 26);
            this.shuffleCheckBox.Name = "shuffleCheckBox";
            this.shuffleCheckBox.Size = new System.Drawing.Size(126, 42);
            this.shuffleCheckBox.TabIndex = 5;
            this.shuffleCheckBox.Text = "Shuffle";
            this.shuffleCheckBox.UseVisualStyleBackColor = true;
            this.shuffleCheckBox.CheckedChanged += new System.EventHandler(this.shuffleCheckBox_CheckedChanged);
            // 
            // answerInEnglishCheckBox
            // 
            this.answerInEnglishCheckBox.AutoSize = true;
            this.answerInEnglishCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerInEnglishCheckBox.Location = new System.Drawing.Point(31, 86);
            this.answerInEnglishCheckBox.Name = "answerInEnglishCheckBox";
            this.answerInEnglishCheckBox.Size = new System.Drawing.Size(166, 27);
            this.answerInEnglishCheckBox.TabIndex = 6;
            this.answerInEnglishCheckBox.Text = "Answer In English";
            this.answerInEnglishCheckBox.UseVisualStyleBackColor = true;
            this.answerInEnglishCheckBox.CheckedChanged += new System.EventHandler(this.answerInEnglishCheckBox_CheckedChanged);
            // 
            // RevisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 498);
            this.Controls.Add(this.answerInEnglishCheckBox);
            this.Controls.Add(this.shuffleCheckBox);
            this.Controls.Add(this.rtkIndexLabel);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.flashCardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RevisionForm";
            this.Text = "Revise";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RevisionForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label flashCardLabel;
        private Button yesButton;
        private Button noButton;
        private Button flipButton;
        private Label rtkIndexLabel;
        private CheckBox shuffleCheckBox;
        private CheckBox answerInEnglishCheckBox;
    }
}