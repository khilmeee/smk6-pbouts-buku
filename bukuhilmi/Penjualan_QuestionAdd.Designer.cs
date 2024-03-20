namespace bukuhilmi
{
    partial class Penjualan_QuestionAdd
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
            this.input_penjualanQuestion_add = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_penjualanQuestion_add = new System.Windows.Forms.Button();
            this.button_question_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_penjualanQuestion_add
            // 
            this.input_penjualanQuestion_add.Location = new System.Drawing.Point(205, 194);
            this.input_penjualanQuestion_add.Name = "input_penjualanQuestion_add";
            this.input_penjualanQuestion_add.Size = new System.Drawing.Size(100, 20);
            this.input_penjualanQuestion_add.TabIndex = 0;
            this.input_penjualanQuestion_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_penjualanQuestion_add_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masukkan jumlah buku";
            // 
            // button_penjualanQuestion_add
            // 
            this.button_penjualanQuestion_add.Location = new System.Drawing.Point(219, 230);
            this.button_penjualanQuestion_add.Name = "button_penjualanQuestion_add";
            this.button_penjualanQuestion_add.Size = new System.Drawing.Size(75, 23);
            this.button_penjualanQuestion_add.TabIndex = 2;
            this.button_penjualanQuestion_add.Text = "Next";
            this.button_penjualanQuestion_add.UseVisualStyleBackColor = true;
            this.button_penjualanQuestion_add.Click += new System.EventHandler(this.button_penjualanQuestion_add_Click);
            // 
            // button_question_back
            // 
            this.button_question_back.Location = new System.Drawing.Point(431, 13);
            this.button_question_back.Name = "button_question_back";
            this.button_question_back.Size = new System.Drawing.Size(75, 23);
            this.button_question_back.TabIndex = 3;
            this.button_question_back.Text = "back";
            this.button_question_back.UseVisualStyleBackColor = true;
            this.button_question_back.Click += new System.EventHandler(this.button_question_back_Click);
            // 
            // Penjualan_QuestionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Controls.Add(this.button_question_back);
            this.Controls.Add(this.button_penjualanQuestion_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_penjualanQuestion_add);
            this.Name = "Penjualan_QuestionAdd";
            this.Size = new System.Drawing.Size(522, 303);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_penjualanQuestion_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_penjualanQuestion_add;
        private System.Windows.Forms.Button button_question_back;
    }
}
