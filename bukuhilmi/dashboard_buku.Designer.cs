namespace bukuhilmi
{
    partial class dashboard_buku
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.input_buku_judul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_buku_penulis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_buku_penerbit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.input_buku_tahun = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_buku_stok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.input_buku_harga = new System.Windows.Forms.TextBox();
            this.button_buku_add = new System.Windows.Forms.Button();
            this.button_buku_edit = new System.Windows.Forms.Button();
            this.button_buku_delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.input_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // input_buku_judul
            // 
            this.input_buku_judul.Location = new System.Drawing.Point(84, 218);
            this.input_buku_judul.Name = "input_buku_judul";
            this.input_buku_judul.Size = new System.Drawing.Size(100, 20);
            this.input_buku_judul.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Judul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Penulis";
            // 
            // input_buku_penulis
            // 
            this.input_buku_penulis.Location = new System.Drawing.Point(84, 244);
            this.input_buku_penulis.Name = "input_buku_penulis";
            this.input_buku_penulis.Size = new System.Drawing.Size(100, 20);
            this.input_buku_penulis.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Penerbit";
            // 
            // input_buku_penerbit
            // 
            this.input_buku_penerbit.Location = new System.Drawing.Point(84, 270);
            this.input_buku_penerbit.Name = "input_buku_penerbit";
            this.input_buku_penerbit.Size = new System.Drawing.Size(100, 20);
            this.input_buku_penerbit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tahun";
            // 
            // input_buku_tahun
            // 
            this.input_buku_tahun.Location = new System.Drawing.Point(285, 218);
            this.input_buku_tahun.Name = "input_buku_tahun";
            this.input_buku_tahun.Size = new System.Drawing.Size(100, 20);
            this.input_buku_tahun.TabIndex = 9;
            this.input_buku_tahun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_buku_tahun_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stok";
            // 
            // input_buku_stok
            // 
            this.input_buku_stok.Location = new System.Drawing.Point(285, 247);
            this.input_buku_stok.Name = "input_buku_stok";
            this.input_buku_stok.Size = new System.Drawing.Size(100, 20);
            this.input_buku_stok.TabIndex = 11;
            this.input_buku_stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_buku_stok_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Harga";
            // 
            // input_buku_harga
            // 
            this.input_buku_harga.Location = new System.Drawing.Point(285, 273);
            this.input_buku_harga.Name = "input_buku_harga";
            this.input_buku_harga.Size = new System.Drawing.Size(100, 20);
            this.input_buku_harga.TabIndex = 13;
            this.input_buku_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_buku_harga_KeyPress);
            // 
            // button_buku_add
            // 
            this.button_buku_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buku_add.Location = new System.Drawing.Point(461, 230);
            this.button_buku_add.Name = "button_buku_add";
            this.button_buku_add.Size = new System.Drawing.Size(102, 46);
            this.button_buku_add.TabIndex = 15;
            this.button_buku_add.Text = "Add";
            this.button_buku_add.UseVisualStyleBackColor = true;
            this.button_buku_add.Click += new System.EventHandler(this.button_buku_add_Click);
            // 
            // button_buku_edit
            // 
            this.button_buku_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buku_edit.Location = new System.Drawing.Point(620, 230);
            this.button_buku_edit.Name = "button_buku_edit";
            this.button_buku_edit.Size = new System.Drawing.Size(102, 46);
            this.button_buku_edit.TabIndex = 16;
            this.button_buku_edit.Text = "Edit";
            this.button_buku_edit.UseVisualStyleBackColor = true;
            this.button_buku_edit.Click += new System.EventHandler(this.button_buku_edit_Click);
            // 
            // button_buku_delete
            // 
            this.button_buku_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buku_delete.Location = new System.Drawing.Point(541, 298);
            this.button_buku_delete.Name = "button_buku_delete";
            this.button_buku_delete.Size = new System.Drawing.Size(102, 46);
            this.button_buku_delete.TabIndex = 17;
            this.button_buku_delete.Text = "Delete";
            this.button_buku_delete.UseVisualStyleBackColor = true;
            this.button_buku_delete.Click += new System.EventHandler(this.button_buku_delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cari";
            // 
            // input_search
            // 
            this.input_search.Location = new System.Drawing.Point(57, 14);
            this.input_search.Name = "input_search";
            this.input_search.Size = new System.Drawing.Size(127, 20);
            this.input_search.TabIndex = 18;
            this.input_search.TextChanged += new System.EventHandler(this.input_search_TextChanged);
            // 
            // dashboard_buku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.input_search);
            this.Controls.Add(this.button_buku_delete);
            this.Controls.Add(this.button_buku_edit);
            this.Controls.Add(this.button_buku_add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.input_buku_harga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_buku_stok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_buku_tahun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_buku_penerbit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_buku_penulis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_buku_judul);
            this.Controls.Add(this.dataGridView1);
            this.Name = "dashboard_buku";
            this.Size = new System.Drawing.Size(796, 389);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox input_buku_judul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_buku_penulis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_buku_penerbit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_buku_tahun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_buku_stok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox input_buku_harga;
        private System.Windows.Forms.Button button_buku_add;
        private System.Windows.Forms.Button button_buku_edit;
        private System.Windows.Forms.Button button_buku_delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox input_search;
    }
}
