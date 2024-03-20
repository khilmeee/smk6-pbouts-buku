namespace bukuhilmi
{
    partial class Penjualan_DialogEdit
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
            this.label_tanggal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_jumlah = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_tanggal = new System.Windows.Forms.DateTimePicker();
            this.comboBox_buku = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_tanggal
            // 
            this.label_tanggal.AutoSize = true;
            this.label_tanggal.Location = new System.Drawing.Point(178, 96);
            this.label_tanggal.Name = "label_tanggal";
            this.label_tanggal.Size = new System.Drawing.Size(46, 13);
            this.label_tanggal.TabIndex = 1;
            this.label_tanggal.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jumlah";
            // 
            // input_jumlah
            // 
            this.input_jumlah.Location = new System.Drawing.Point(231, 133);
            this.input_jumlah.Name = "input_jumlah";
            this.input_jumlah.Size = new System.Drawing.Size(100, 20);
            this.input_jumlah.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buku";
            // 
            // dateTimePicker_tanggal
            // 
            this.dateTimePicker_tanggal.Location = new System.Drawing.Point(231, 96);
            this.dateTimePicker_tanggal.Name = "dateTimePicker_tanggal";
            this.dateTimePicker_tanggal.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker_tanggal.TabIndex = 6;
            // 
            // comboBox_buku
            // 
            this.comboBox_buku.FormattingEnabled = true;
            this.comboBox_buku.Location = new System.Drawing.Point(231, 173);
            this.comboBox_buku.Name = "comboBox_buku";
            this.comboBox_buku.Size = new System.Drawing.Size(121, 21);
            this.comboBox_buku.TabIndex = 7;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(181, 263);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(277, 263);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Penjualan_DialogEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.comboBox_buku);
            this.Controls.Add(this.dateTimePicker_tanggal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_jumlah);
            this.Controls.Add(this.label_tanggal);
            this.Name = "Penjualan_DialogEdit";
            this.Size = new System.Drawing.Size(563, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_tanggal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_jumlah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tanggal;
        private System.Windows.Forms.ComboBox comboBox_buku;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
    }
}
