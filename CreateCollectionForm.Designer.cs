namespace RTK_Revisor
{
    partial class CreateCollectionForm
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
            this.addedLessonsListBox = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.availableLessonsListBox = new System.Windows.Forms.ListBox();
            this.addLessonButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.removeLessonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addedLessonsListBox
            // 
            this.addedLessonsListBox.FormattingEnabled = true;
            this.addedLessonsListBox.ItemHeight = 31;
            this.addedLessonsListBox.Location = new System.Drawing.Point(42, 77);
            this.addedLessonsListBox.Name = "addedLessonsListBox";
            this.addedLessonsListBox.Size = new System.Drawing.Size(261, 283);
            this.addedLessonsListBox.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(42, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(188, 31);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Create Collection";
            // 
            // availableLessonsListBox
            // 
            this.availableLessonsListBox.FormattingEnabled = true;
            this.availableLessonsListBox.ItemHeight = 31;
            this.availableLessonsListBox.Location = new System.Drawing.Point(377, 77);
            this.availableLessonsListBox.Name = "availableLessonsListBox";
            this.availableLessonsListBox.Size = new System.Drawing.Size(261, 283);
            this.availableLessonsListBox.TabIndex = 2;
            // 
            // addLessonButton
            // 
            this.addLessonButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addLessonButton.Location = new System.Drawing.Point(461, 387);
            this.addLessonButton.Name = "addLessonButton";
            this.addLessonButton.Size = new System.Drawing.Size(111, 29);
            this.addLessonButton.TabIndex = 3;
            this.addLessonButton.Text = "Add Lesson";
            this.addLessonButton.UseVisualStyleBackColor = true;
            this.addLessonButton.Click += new System.EventHandler(this.addLessonButton_Click);
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createButton.Location = new System.Drawing.Point(287, 378);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(111, 47);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // removeLessonButton
            // 
            this.removeLessonButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeLessonButton.Location = new System.Drawing.Point(119, 387);
            this.removeLessonButton.Name = "removeLessonButton";
            this.removeLessonButton.Size = new System.Drawing.Size(111, 29);
            this.removeLessonButton.TabIndex = 5;
            this.removeLessonButton.Text = "Remove Lesson";
            this.removeLessonButton.UseVisualStyleBackColor = true;
            this.removeLessonButton.Click += new System.EventHandler(this.removeLessonButton_Click);
            // 
            // CreateCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 464);
            this.Controls.Add(this.removeLessonButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.addLessonButton);
            this.Controls.Add(this.availableLessonsListBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addedLessonsListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateCollectionForm";
            this.Text = "CreateCollectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox addedLessonsListBox;
        private Label titleLabel;
        private ListBox availableLessonsListBox;
        private Button addLessonButton;
        private Button createButton;
        private Button removeLessonButton;
    }
}