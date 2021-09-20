namespace GabrielMatosevicKlasaProcess
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
            this.InternetExplorerButton = new System.Windows.Forms.Button();
            this.WordButton = new System.Windows.Forms.Button();
            this.ExcelButton = new System.Windows.Forms.Button();
            this.StartInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InternetExplorerButton
            // 
            this.InternetExplorerButton.Location = new System.Drawing.Point(204, 190);
            this.InternetExplorerButton.Name = "InternetExplorerButton";
            this.InternetExplorerButton.Size = new System.Drawing.Size(93, 23);
            this.InternetExplorerButton.TabIndex = 0;
            this.InternetExplorerButton.Text = "Internet Explorer";
            this.InternetExplorerButton.UseVisualStyleBackColor = true;
            this.InternetExplorerButton.Click += new System.EventHandler(this.InternetExplorerButton_Click);
            // 
            // WordButton
            // 
            this.WordButton.Location = new System.Drawing.Point(303, 190);
            this.WordButton.Name = "WordButton";
            this.WordButton.Size = new System.Drawing.Size(75, 23);
            this.WordButton.TabIndex = 1;
            this.WordButton.Text = "Word";
            this.WordButton.UseVisualStyleBackColor = true;
            this.WordButton.Click += new System.EventHandler(this.WordButton_Click);
            // 
            // ExcelButton
            // 
            this.ExcelButton.Location = new System.Drawing.Point(384, 190);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(75, 23);
            this.ExcelButton.TabIndex = 2;
            this.ExcelButton.Text = "Excel";
            this.ExcelButton.UseVisualStyleBackColor = true;
            this.ExcelButton.Click += new System.EventHandler(this.ExcelButton_Click);
            // 
            // StartInfoButton
            // 
            this.StartInfoButton.Location = new System.Drawing.Point(465, 190);
            this.StartInfoButton.Name = "StartInfoButton";
            this.StartInfoButton.Size = new System.Drawing.Size(75, 23);
            this.StartInfoButton.TabIndex = 3;
            this.StartInfoButton.Text = "StartInfo";
            this.StartInfoButton.UseVisualStyleBackColor = true;
            this.StartInfoButton.Click += new System.EventHandler(this.StartInfoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartInfoButton);
            this.Controls.Add(this.ExcelButton);
            this.Controls.Add(this.WordButton);
            this.Controls.Add(this.InternetExplorerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InternetExplorerButton;
        private System.Windows.Forms.Button WordButton;
        private System.Windows.Forms.Button ExcelButton;
        private System.Windows.Forms.Button StartInfoButton;
    }
}

