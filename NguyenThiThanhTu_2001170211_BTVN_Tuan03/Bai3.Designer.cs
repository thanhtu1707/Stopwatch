namespace NguyenThiThanhTu_2001170211_BTVN_Tuan03
{
    partial class Bai3
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
            this.runTime1 = new RunTime.RunTime();
            this.SuspendLayout();
            // 
            // runTime1
            // 
            this.runTime1.Location = new System.Drawing.Point(34, 12);
            this.runTime1.Name = "runTime1";
            this.runTime1.Size = new System.Drawing.Size(150, 119);
            this.runTime1.TabIndex = 0;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 133);
            this.Controls.Add(this.runTime1);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private RunTime.RunTime runTime1;
    }
}