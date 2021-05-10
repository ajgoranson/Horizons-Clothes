
namespace SuperMarketManagmentFINAL
{
    partial class Animaton
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animaton));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myprogressbar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(152, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "HORIZONS CLOTHES MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(435, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Version 1.0";
            // 
            // myprogressbar
            // 
            this.myprogressbar.BackColor = System.Drawing.Color.Silver;
            this.myprogressbar.BorderRadius = 5;
            this.myprogressbar.Location = new System.Drawing.Point(-1, 616);
            this.myprogressbar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.myprogressbar.MaximumValue = 100;
            this.myprogressbar.Name = "myprogressbar";
            this.myprogressbar.ProgressColor = System.Drawing.Color.DarkOrange;
            this.myprogressbar.Size = new System.Drawing.Size(1093, 19);
            this.myprogressbar.TabIndex = 8;
            this.myprogressbar.Value = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(396, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Animaton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1092, 635);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.myprogressbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Animaton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuProgressBar myprogressbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}