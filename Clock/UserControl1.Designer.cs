namespace Clock
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrBlock = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLap = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbl_milisecond = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrBlock
            // 
            this.tmrBlock.Tick += new System.EventHandler(this.tmrBlock_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(33, 79);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLap
            // 
            this.btnLap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLap.Location = new System.Drawing.Point(149, 79);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(75, 32);
            this.btnLap.TabIndex = 1;
            this.btnLap.Text = "Lap";
            this.btnLap.UseVisualStyleBackColor = true;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(54, 28);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(100, 26);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00:00";
            // 
            // lbl_milisecond
            // 
            this.lbl_milisecond.AutoSize = true;
            this.lbl_milisecond.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_milisecond.Location = new System.Drawing.Point(160, 28);
            this.lbl_milisecond.Name = "lbl_milisecond";
            this.lbl_milisecond.Size = new System.Drawing.Size(48, 26);
            this.lbl_milisecond.TabIndex = 3;
            this.lbl_milisecond.Text = "000";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_milisecond);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnLap);
            this.Controls.Add(this.btnStart);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(251, 183);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrBlock;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lbl_milisecond;
    }
}
