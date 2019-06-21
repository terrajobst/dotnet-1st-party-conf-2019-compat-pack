namespace Fabrikam.AssetManager
{
    partial class MainForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.loggingListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(585, 392);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(203, 46);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // loggingListBox
            // 
            this.loggingListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loggingListBox.FormattingEnabled = true;
            this.loggingListBox.ItemHeight = 24;
            this.loggingListBox.Location = new System.Drawing.Point(12, 12);
            this.loggingListBox.Name = "loggingListBox";
            this.loggingListBox.Size = new System.Drawing.Size(776, 364);
            this.loggingListBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loggingListBox);
            this.Controls.Add(this.closeButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabrikam Asset Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox loggingListBox;
    }
}

