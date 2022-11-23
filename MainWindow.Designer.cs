namespace RTK_Revisor
{
    partial class MainWindow
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
            this.kanjiSearchBox = new System.Windows.Forms.TextBox();
            this.kanjiListBox = new System.Windows.Forms.ListBox();
            this.searchKanjiLabel = new System.Windows.Forms.Label();
            this.collectionListBox = new System.Windows.Forms.ListBox();
            this.reviseCollectionButton = new System.Windows.Forms.Button();
            this.createCollectionButton = new System.Windows.Forms.Button();
            this.initializeConnectionButton = new System.Windows.Forms.Button();
            this.reseedCollectionButton = new System.Windows.Forms.Button();
            this.removeCollectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kanjiSearchBox
            // 
            this.kanjiSearchBox.Location = new System.Drawing.Point(87, 45);
            this.kanjiSearchBox.Name = "kanjiSearchBox";
            this.kanjiSearchBox.Size = new System.Drawing.Size(282, 38);
            this.kanjiSearchBox.TabIndex = 0;
            this.kanjiSearchBox.TextChanged += new System.EventHandler(this.kanjiSearchBox_TextChanged);
            // 
            // kanjiListBox
            // 
            this.kanjiListBox.FormattingEnabled = true;
            this.kanjiListBox.ItemHeight = 31;
            this.kanjiListBox.Location = new System.Drawing.Point(87, 107);
            this.kanjiListBox.Name = "kanjiListBox";
            this.kanjiListBox.Size = new System.Drawing.Size(282, 283);
            this.kanjiListBox.TabIndex = 1;
            // 
            // searchKanjiLabel
            // 
            this.searchKanjiLabel.AutoSize = true;
            this.searchKanjiLabel.Location = new System.Drawing.Point(87, 9);
            this.searchKanjiLabel.Name = "searchKanjiLabel";
            this.searchKanjiLabel.Size = new System.Drawing.Size(138, 31);
            this.searchKanjiLabel.TabIndex = 2;
            this.searchKanjiLabel.Text = "Search Kanji";
            // 
            // collectionListBox
            // 
            this.collectionListBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.collectionListBox.FormattingEnabled = true;
            this.collectionListBox.ItemHeight = 17;
            this.collectionListBox.Location = new System.Drawing.Point(539, 96);
            this.collectionListBox.Name = "collectionListBox";
            this.collectionListBox.Size = new System.Drawing.Size(258, 225);
            this.collectionListBox.TabIndex = 3;
            // 
            // reviseCollectionButton
            // 
            this.reviseCollectionButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reviseCollectionButton.Location = new System.Drawing.Point(586, 410);
            this.reviseCollectionButton.Name = "reviseCollectionButton";
            this.reviseCollectionButton.Size = new System.Drawing.Size(158, 29);
            this.reviseCollectionButton.TabIndex = 4;
            this.reviseCollectionButton.Text = "Revise Collection";
            this.reviseCollectionButton.UseVisualStyleBackColor = true;
            this.reviseCollectionButton.Click += new System.EventHandler(this.reviseCollectionButton_Click);
            // 
            // createCollectionButton
            // 
            this.createCollectionButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createCollectionButton.Location = new System.Drawing.Point(586, 9);
            this.createCollectionButton.Name = "createCollectionButton";
            this.createCollectionButton.Size = new System.Drawing.Size(158, 29);
            this.createCollectionButton.TabIndex = 5;
            this.createCollectionButton.Text = "Create Collection";
            this.createCollectionButton.UseVisualStyleBackColor = true;
            this.createCollectionButton.Click += new System.EventHandler(this.createCollectionButton_Click);
            // 
            // initializeConnectionButton
            // 
            this.initializeConnectionButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.initializeConnectionButton.Location = new System.Drawing.Point(586, 327);
            this.initializeConnectionButton.Name = "initializeConnectionButton";
            this.initializeConnectionButton.Size = new System.Drawing.Size(158, 29);
            this.initializeConnectionButton.TabIndex = 6;
            this.initializeConnectionButton.Text = "Initialize Collection";
            this.initializeConnectionButton.UseVisualStyleBackColor = true;
            this.initializeConnectionButton.Click += new System.EventHandler(this.initializeConnectionButton_Click);
            // 
            // reseedCollectionButton
            // 
            this.reseedCollectionButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reseedCollectionButton.Location = new System.Drawing.Point(586, 365);
            this.reseedCollectionButton.Name = "reseedCollectionButton";
            this.reseedCollectionButton.Size = new System.Drawing.Size(158, 29);
            this.reseedCollectionButton.TabIndex = 7;
            this.reseedCollectionButton.Text = "Re-seed Collection";
            this.reseedCollectionButton.UseVisualStyleBackColor = true;
            this.reseedCollectionButton.Click += new System.EventHandler(this.reseedCollectionButton_Click);
            // 
            // removeCollectionButton
            // 
            this.removeCollectionButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeCollectionButton.Location = new System.Drawing.Point(586, 45);
            this.removeCollectionButton.Name = "removeCollectionButton";
            this.removeCollectionButton.Size = new System.Drawing.Size(158, 29);
            this.removeCollectionButton.TabIndex = 8;
            this.removeCollectionButton.Text = "Remove Collection";
            this.removeCollectionButton.UseVisualStyleBackColor = true;
            this.removeCollectionButton.Click += new System.EventHandler(this.removeCollectionButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 451);
            this.Controls.Add(this.removeCollectionButton);
            this.Controls.Add(this.reseedCollectionButton);
            this.Controls.Add(this.initializeConnectionButton);
            this.Controls.Add(this.createCollectionButton);
            this.Controls.Add(this.reviseCollectionButton);
            this.Controls.Add(this.collectionListBox);
            this.Controls.Add(this.searchKanjiLabel);
            this.Controls.Add(this.kanjiListBox);
            this.Controls.Add(this.kanjiSearchBox);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainWindow";
            this.Text = "RTK Revisor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox kanjiSearchBox;
        private ListBox kanjiListBox;
        private Label searchKanjiLabel;
        private ListBox collectionListBox;
        private Button reviseCollectionButton;
        private Button createCollectionButton;
        private Button initializeConnectionButton;
        private Button reseedCollectionButton;
        private Button removeCollectionButton;
    }
}