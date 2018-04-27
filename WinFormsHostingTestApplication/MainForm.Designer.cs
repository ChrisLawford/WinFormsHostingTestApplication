namespace WinFormsHostingTestApplication
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
            this.AddWPF_button = new System.Windows.Forms.Button();
            this.AddWinForms_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddWPF_button
            // 
            this.AddWPF_button.Location = new System.Drawing.Point(453, 226);
            this.AddWPF_button.Name = "AddWPF_button";
            this.AddWPF_button.Size = new System.Drawing.Size(317, 156);
            this.AddWPF_button.TabIndex = 0;
            this.AddWPF_button.Text = "Attach WPF control";
            this.AddWPF_button.UseVisualStyleBackColor = true;
            this.AddWPF_button.Click += new System.EventHandler(this.AddWPF_Click);
            // 
            // AddWinForms_button
            // 
            this.AddWinForms_button.Location = new System.Drawing.Point(84, 226);
            this.AddWinForms_button.Name = "AddWinForms_button";
            this.AddWinForms_button.Size = new System.Drawing.Size(317, 156);
            this.AddWinForms_button.TabIndex = 0;
            this.AddWinForms_button.Text = "Attach WinForms control";
            this.AddWinForms_button.UseVisualStyleBackColor = true;
            this.AddWinForms_button.Click += new System.EventHandler(this.AddWinForms_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 594);
            this.Controls.Add(this.AddWinForms_button);
            this.Controls.Add(this.AddWPF_button);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddWPF_button;
        private System.Windows.Forms.Button AddWinForms_button;
    }
}

