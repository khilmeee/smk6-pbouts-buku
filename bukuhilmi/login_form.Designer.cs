﻿namespace bukuhilmi
{
    partial class login_form
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
            this.username_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.exitApp_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(332, 160);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(100, 20);
            this.username_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(332, 199);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(100, 20);
            this.password_input.TabIndex = 2;
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(325, 242);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(118, 30);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // exitApp_button
            // 
            this.exitApp_button.Location = new System.Drawing.Point(694, 12);
            this.exitApp_button.Name = "exitApp_button";
            this.exitApp_button.Size = new System.Drawing.Size(75, 23);
            this.exitApp_button.TabIndex = 5;
            this.exitApp_button.Text = "exit app";
            this.exitApp_button.UseVisualStyleBackColor = true;
            this.exitApp_button.Click += new System.EventHandler(this.exitApp_button_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitApp_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username_input);
            this.Name = "login_form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button exitApp_button;
    }
}

