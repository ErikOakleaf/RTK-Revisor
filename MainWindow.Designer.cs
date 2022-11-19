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
            this.kanjiListBox.Location = new System.Drawing.Point(87, 139);
            this.kanjiListBox.Name = "kanjiListBox";
            this.kanjiListBox.Size = new System.Drawing.Size(282, 283);
            this.kanjiListBox.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 451);
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
    }
}