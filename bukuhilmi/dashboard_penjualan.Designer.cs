namespace bukuhilmi
{
    partial class dashboard_penjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard_penjualan));
            this.button_penjualan_delete = new System.Windows.Forms.Button();
            this.button_penjualan_edit = new System.Windows.Forms.Button();
            this.button_penjualan_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combo_buku = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_detailBuku = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.input_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_penjualan_delete
            // 
            this.button_penjualan_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_penjualan_delete.Location = new System.Drawing.Point(540, 298);
            this.button_penjualan_delete.Name = "button_penjualan_delete";
            this.button_penjualan_delete.Size = new System.Drawing.Size(102, 46);
            this.button_penjualan_delete.TabIndex = 33;
            this.button_penjualan_delete.Text = "Delete";
            this.button_penjualan_delete.UseVisualStyleBackColor = true;
            this.button_penjualan_delete.Click += new System.EventHandler(this.button_penjualan_delete_Click);
            // 
            // button_penjualan_edit
            // 
            this.button_penjualan_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_penjualan_edit.Location = new System.Drawing.Point(619, 230);
            this.button_penjualan_edit.Name = "button_penjualan_edit";
            this.button_penjualan_edit.Size = new System.Drawing.Size(102, 46);
            this.button_penjualan_edit.TabIndex = 32;
            this.button_penjualan_edit.Text = "Edit";
            this.button_penjualan_edit.UseVisualStyleBackColor = true;
            this.button_penjualan_edit.Click += new System.EventHandler(this.button_penjualan_edit_Click);
            // 
            // button_penjualan_add
            // 
            this.button_penjualan_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_penjualan_add.Location = new System.Drawing.Point(460, 230);
            this.button_penjualan_add.Name = "button_penjualan_add";
            this.button_penjualan_add.Size = new System.Drawing.Size(102, 46);
            this.button_penjualan_add.TabIndex = 31;
            this.button_penjualan_add.Text = "Add";
            this.button_penjualan_add.UseVisualStyleBackColor = true;
            this.button_penjualan_add.Click += new System.EventHandler(this.button_penjualan_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buku";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // combo_buku
            // 
            this.combo_buku.FormattingEnabled = true;
            this.combo_buku.Location = new System.Drawing.Point(83, 217);
            this.combo_buku.Name = "combo_buku";
            this.combo_buku.Size = new System.Drawing.Size(121, 21);
            this.combo_buku.TabIndex = 34;
            this.combo_buku.SelectedIndexChanged += new System.EventHandler(this.combo_buku_SelectedIndexChanged);
            this.combo_buku.Click += new System.EventHandler(this.combo_buku_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_detailBuku);
            this.panel1.Location = new System.Drawing.Point(28, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 122);
            this.panel1.TabIndex = 35;
            // 
            // label_detailBuku
            // 
            this.label_detailBuku.AutoEllipsis = true;
            this.label_detailBuku.AutoSize = true;
            this.label_detailBuku.Location = new System.Drawing.Point(12, 14);
            this.label_detailBuku.Name = "label_detailBuku";
            this.label_detailBuku.Size = new System.Drawing.Size(10, 13);
            this.label_detailBuku.TabIndex = 0;
            this.label_detailBuku.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "detail buku";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(59, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 37;
            this.button4.Text = "🔃";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Cari";
            // 
            // input_search
            // 
            this.input_search.Location = new System.Drawing.Point(43, 14);
            this.input_search.Name = "input_search";
            this.input_search.Size = new System.Drawing.Size(127, 20);
            this.input_search.TabIndex = 38;
            this.input_search.TextChanged += new System.EventHandler(this.input_search_TextChanged);
            // 
            // dashboard_penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.input_search);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.combo_buku);
            this.Controls.Add(this.button_penjualan_delete);
            this.Controls.Add(this.button_penjualan_edit);
            this.Controls.Add(this.button_penjualan_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "dashboard_penjualan";
            this.Size = new System.Drawing.Size(808, 382);
            this.Load += new System.EventHandler(this.dashboard_penjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_penjualan_delete;
        private System.Windows.Forms.Button button_penjualan_edit;
        private System.Windows.Forms.Button button_penjualan_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_buku;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_detailBuku;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox input_search;
    }
}
