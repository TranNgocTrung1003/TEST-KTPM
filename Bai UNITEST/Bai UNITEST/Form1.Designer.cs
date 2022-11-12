namespace Bai_UNITEST
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbso1 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.lbso2 = new System.Windows.Forms.Label();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btcong = new System.Windows.Forms.Button();
            this.bttru = new System.Windows.Forms.Button();
            this.btnhan = new System.Windows.Forms.Button();
            this.btchia = new System.Windows.Forms.Button();
            this.lbKQ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(352, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuong trinh tinh toan don gian";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbKQ);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtso2);
            this.groupBox1.Controls.Add(this.lbso2);
            this.groupBox1.Controls.Add(this.txtso1);
            this.groupBox1.Controls.Add(this.lbso1);
            this.groupBox1.Location = new System.Drawing.Point(127, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tính toán đơn giản";
            // 
            // lbso1
            // 
            this.lbso1.AutoSize = true;
            this.lbso1.Location = new System.Drawing.Point(6, 45);
            this.lbso1.Name = "lbso1";
            this.lbso1.Size = new System.Drawing.Size(142, 29);
            this.lbso1.TabIndex = 0;
            this.lbso1.Text = "Số thứ nhất";
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(193, 38);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(347, 36);
            this.txtso1.TabIndex = 1;
            // 
            // lbso2
            // 
            this.lbso2.AutoSize = true;
            this.lbso2.Location = new System.Drawing.Point(6, 87);
            this.lbso2.Name = "lbso2";
            this.lbso2.Size = new System.Drawing.Size(127, 29);
            this.lbso2.TabIndex = 0;
            this.lbso2.Text = "Số thứ hai";
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(193, 80);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(347, 36);
            this.txtso2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả";
            // 
            // btcong
            // 
            this.btcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcong.Location = new System.Drawing.Point(320, 364);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(106, 33);
            this.btcong.TabIndex = 2;
            this.btcong.Text = "cộng ";
            this.btcong.UseVisualStyleBackColor = true;
            this.btcong.Click += new System.EventHandler(this.btcong_Click);
            // 
            // bttru
            // 
            this.bttru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttru.Location = new System.Drawing.Point(442, 364);
            this.bttru.Name = "bttru";
            this.bttru.Size = new System.Drawing.Size(100, 33);
            this.bttru.TabIndex = 2;
            this.bttru.Text = "trừ";
            this.bttru.UseVisualStyleBackColor = true;
            // 
            // btnhan
            // 
            this.btnhan.Location = new System.Drawing.Point(567, 364);
            this.btnhan.Name = "btnhan";
            this.btnhan.Size = new System.Drawing.Size(100, 33);
            this.btnhan.TabIndex = 2;
            this.btnhan.Text = "Nhân";
            this.btnhan.UseVisualStyleBackColor = true;
            // 
            // btchia
            // 
            this.btchia.Location = new System.Drawing.Point(673, 364);
            this.btchia.Name = "btchia";
            this.btchia.Size = new System.Drawing.Size(100, 33);
            this.btchia.TabIndex = 2;
            this.btchia.Text = "chia";
            this.btchia.UseVisualStyleBackColor = true;
            // 
            // lbKQ
            // 
            this.lbKQ.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbKQ.Location = new System.Drawing.Point(193, 129);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(347, 29);
            this.lbKQ.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 816);
            this.Controls.Add(this.btchia);
            this.Controls.Add(this.btnhan);
            this.Controls.Add(this.bttru);
            this.Controls.Add(this.btcong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Tinh toan ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.Label lbso2;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.Label lbso1;
        private System.Windows.Forms.Button btcong;
        private System.Windows.Forms.Button bttru;
        private System.Windows.Forms.Button btnhan;
        private System.Windows.Forms.Button btchia;
    }
}

