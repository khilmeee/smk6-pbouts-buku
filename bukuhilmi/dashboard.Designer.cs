namespace bukuhilmi
{
    partial class dashboard
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
            this.buku_button_open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.penjualan_button_open = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.logged_as = new System.Windows.Forms.Label();
            this.dashboard_buku1 = new bukuhilmi.dashboard_buku();
            this.SuspendLayout();
            // 
            // buku_button_open
            // 
            this.buku_button_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buku_button_open.Location = new System.Drawing.Point(193, 390);
            this.buku_button_open.Name = "buku_button_open";
            this.buku_button_open.Size = new System.Drawing.Size(139, 51);
            this.buku_button_open.TabIndex = 0;
            this.buku_button_open.Text = "Buku";
            this.buku_button_open.UseVisualStyleBackColor = true;
            this.buku_button_open.Click += new System.EventHandler(this.buku_button_open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logged as";
            // 
            // penjualan_button_open
            // 
            this.penjualan_button_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penjualan_button_open.Location = new System.Drawing.Point(338, 390);
            this.penjualan_button_open.Name = "penjualan_button_open";
            this.penjualan_button_open.Size = new System.Drawing.Size(139, 51);
            this.penjualan_button_open.TabIndex = 2;
            this.penjualan_button_open.Text = "Penjualan";
            this.penjualan_button_open.UseVisualStyleBackColor = true;
            this.penjualan_button_open.Click += new System.EventHandler(this.penjualan_button_open_Click);
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.IndianRed;
            this.logout_button.Location = new System.Drawing.Point(713, 409);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(75, 23);
            this.logout_button.TabIndex = 3;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // logged_as
            // 
            this.logged_as.AutoSize = true;
            this.logged_as.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logged_as.Location = new System.Drawing.Point(112, 402);
            this.logged_as.Name = "logged_as";
            this.logged_as.Size = new System.Drawing.Size(35, 13);
            this.logged_as.TabIndex = 5;
            this.logged_as.Text = "label2";
            // 
            // dashboard_buku1
            // 
            this.dashboard_buku1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dashboard_buku1.Location = new System.Drawing.Point(-1, 0);
            this.dashboard_buku1.Name = "dashboard_buku1";
            this.dashboard_buku1.Size = new System.Drawing.Size(803, 384);
            this.dashboard_buku1.TabIndex = 4;
            this.dashboard_buku1.Load += new System.EventHandler(this.dashboard_buku1_Load);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logged_as);
            this.Controls.Add(this.dashboard_buku1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.penjualan_button_open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buku_button_open);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buku_button_open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button penjualan_button_open;
        private System.Windows.Forms.Button logout_button;
        private dashboard_buku dashboard_buku1;
        private System.Windows.Forms.Label logged_as;
    }
}