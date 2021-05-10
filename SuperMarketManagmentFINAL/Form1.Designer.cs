
namespace SuperMarketManagmentFINAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.UsernameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PasswordTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.LoginBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(-228, -30);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(602, 856);
            this.guna2CircleButton1.TabIndex = 2;
            // 
            // UsernameTb
            // 
            this.UsernameTb.BackColor = System.Drawing.SystemColors.Menu;
            this.UsernameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UsernameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UsernameTb.HintForeColor = System.Drawing.Color.Empty;
            this.UsernameTb.HintText = "";
            this.UsernameTb.isPassword = false;
            this.UsernameTb.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.UsernameTb.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.UsernameTb.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.UsernameTb.LineThickness = 3;
            this.UsernameTb.Location = new System.Drawing.Point(665, 315);
            this.UsernameTb.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.Size = new System.Drawing.Size(402, 66);
            this.UsernameTb.TabIndex = 3;
            this.UsernameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PasswordTb
            // 
            this.PasswordTb.BackColor = System.Drawing.SystemColors.Menu;
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PasswordTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasswordTb.HintForeColor = System.Drawing.Color.Empty;
            this.PasswordTb.HintText = "";
            this.PasswordTb.isPassword = false;
            this.PasswordTb.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.PasswordTb.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.PasswordTb.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.PasswordTb.LineThickness = 3;
            this.PasswordTb.Location = new System.Drawing.Point(665, 483);
            this.PasswordTb.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(402, 66);
            this.PasswordTb.TabIndex = 4;
            this.PasswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(725, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(465, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(460, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "PASSWORD";
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleComboBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.RoleComboBox.Location = new System.Drawing.Point(665, 231);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(402, 44);
            this.RoleComboBox.TabIndex = 8;
            this.RoleComboBox.Text = "Select Role";
            // 
            // LoginBtn
            // 
            this.LoginBtn.ActiveBorderThickness = 1;
            this.LoginBtn.ActiveCornerRadius = 20;
            this.LoginBtn.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.LoginBtn.ActiveForecolor = System.Drawing.SystemColors.Menu;
            this.LoginBtn.ActiveLineColor = System.Drawing.Color.OrangeRed;
            this.LoginBtn.BackColor = System.Drawing.SystemColors.Control;
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.ButtonText = "LOGIN";
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.LoginBtn.IdleBorderThickness = 1;
            this.LoginBtn.IdleCornerRadius = 20;
            this.LoginBtn.IdleFillColor = System.Drawing.SystemColors.Menu;
            this.LoginBtn.IdleForecolor = System.Drawing.Color.DarkOrange;
            this.LoginBtn.IdleLineColor = System.Drawing.Color.DarkOrange;
            this.LoginBtn.Location = new System.Drawing.Point(596, 574);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(5);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(438, 59);
            this.LoginBtn.TabIndex = 10;
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "HORIZONS CLOTHES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(1093, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 44);
            this.label6.TabIndex = 13;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.SystemColors.Menu;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.OrangeRed;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "CLEAR";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.DarkOrange;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.SystemColors.Menu;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.DarkOrange;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkOrange;
            this.bunifuThinButton21.Location = new System.Drawing.Point(596, 643);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(438, 59);
            this.bunifuThinButton21.TabIndex = 14;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 750);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.UsernameTb);
            this.Controls.Add(this.guna2CircleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UsernameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PasswordTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}

