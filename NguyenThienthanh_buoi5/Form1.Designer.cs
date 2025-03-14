namespace NguyenThienthanh_buoi5
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
            this.btTinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBatDau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCuoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btTinh
            // 
            this.btTinh.Location = new System.Drawing.Point(271, 107);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(75, 23);
            this.btTinh.TabIndex = 0;
            this.btTinh.Text = "tính";
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "tính các số tổng chẳn lẻ";
            // 
            // txtBatDau
            // 
            this.txtBatDau.Location = new System.Drawing.Point(173, 67);
            this.txtBatDau.Name = "txtBatDau";
            this.txtBatDau.Size = new System.Drawing.Size(100, 20);
            this.txtBatDau.TabIndex = 2;
            this.txtBatDau.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "số đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "số cuối";
            // 
            // txtCuoi
            // 
            this.txtCuoi.Location = new System.Drawing.Point(380, 70);
            this.txtCuoi.Name = "txtCuoi";
            this.txtCuoi.Size = new System.Drawing.Size(100, 20);
            this.txtCuoi.TabIndex = 2;
            this.txtCuoi.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "tổng";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(173, 148);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(100, 20);
            this.txtTong.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "tổng chẵn";
            // 
            // txtTongChan
            // 
            this.txtTongChan.Location = new System.Drawing.Point(173, 174);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.ReadOnly = true;
            this.txtTongChan.Size = new System.Drawing.Size(100, 20);
            this.txtTongChan.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "tổng lẻ";
            // 
            // txtTongLe
            // 
            this.txtTongLe.Location = new System.Drawing.Point(173, 200);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.ReadOnly = true;
            this.txtTongLe.Size = new System.Drawing.Size(100, 20);
            this.txtTongLe.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 247);
            this.Controls.Add(this.txtCuoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongLe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongChan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBatDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTinh);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCuoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongLe;
    }
}

