﻿namespace Project_Football_Manager
{
    partial class Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hello));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnMember = new System.Windows.Forms.RadioButton();
            this.btnManager = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1033, 631);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 628);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1033, 136);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(481, 644);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(141, 22);
            this.txtUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = global::Project_Football_Manager.Properties.Resources.images;
            this.label1.Location = new System.Drawing.Point(381, 649);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "YOUR ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Image = global::Project_Football_Manager.Properties.Resources.images;
            this.label2.Location = new System.Drawing.Point(381, 677);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(481, 674);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(141, 22);
            this.txtPass.TabIndex = 5;
            // 
            // btnMember
            // 
            this.btnMember.AutoSize = true;
            this.btnMember.BackColor = System.Drawing.Color.Maroon;
            this.btnMember.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMember.Location = new System.Drawing.Point(384, 715);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(80, 21);
            this.btnMember.TabIndex = 6;
            this.btnMember.TabStop = true;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = false;
            // 
            // btnManager
            // 
            this.btnManager.AutoSize = true;
            this.btnManager.BackColor = System.Drawing.Color.Maroon;
            this.btnManager.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnManager.Location = new System.Drawing.Point(523, 715);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(85, 21);
            this.btnManager.TabIndex = 7;
            this.btnManager.TabStop = true;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(762, 662);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 47);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 767);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Hello";
            this.Text = "WELLCOME TO MY TEAM";
            this.Load += new System.EventHandler(this.Hello_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.RadioButton btnMember;
        private System.Windows.Forms.RadioButton btnManager;
        private System.Windows.Forms.Button button1;
    }
}

