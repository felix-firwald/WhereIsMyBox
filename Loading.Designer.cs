namespace WhereIsMyBox
{
    partial class Loading
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textProcess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 53);
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(270, 16);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 40;
            // 
            // textProcess
            // 
            this.textProcess.AutoSize = true;
            this.textProcess.Location = new System.Drawing.Point(13, 13);
            this.textProcess.Name = "textProcess";
            this.textProcess.Size = new System.Drawing.Size(202, 13);
            this.textProcess.TabIndex = 1;
            this.textProcess.Text = "Выполняется загрузка базы данных...";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 81);
            this.ControlBox = false;
            this.Controls.Add(this.textProcess);
            this.Controls.Add(this.progressBar1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Enabled = false;
            this.MaximumSize = new System.Drawing.Size(310, 120);
            this.MinimumSize = new System.Drawing.Size(310, 120);
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Загрузка";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label textProcess;
    }
}