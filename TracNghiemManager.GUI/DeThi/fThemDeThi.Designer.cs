﻿namespace TracNghiemManager.GUI.DeThi
{
    partial class fThemDeThi
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
			this.txtTenlop = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnThem = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.nud = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.lblChonMonHoc = new System.Windows.Forms.Label();
			this.cbMonHoc = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(47, 106);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập tên đề thi:";
			// 
			// txtTenlop
			// 
			this.txtTenlop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenlop.Location = new System.Drawing.Point(297, 106);
			this.txtTenlop.Margin = new System.Windows.Forms.Padding(4);
			this.txtTenlop.Name = "txtTenlop";
			this.txtTenlop.Size = new System.Drawing.Size(311, 34);
			this.txtTenlop.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(216, 25);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(256, 50);
			this.label2.TabIndex = 2;
			this.label2.Text = "THÊM ĐỀ THI";
			// 
			// btnThem
			// 
			this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(464, 291);
			this.btnThem.Margin = new System.Windows.Forms.Padding(4);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(144, 42);
			this.btnThem.TabIndex = 3;
			this.btnThem.Text = "Lưu ";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(47, 170);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(221, 28);
			this.label3.TabIndex = 0;
			this.label3.Text = "Nhập thời gian làm bài: ";
			// 
			// nud
			// 
			this.nud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nud.Location = new System.Drawing.Point(297, 168);
			this.nud.Name = "nud";
			this.nud.Size = new System.Drawing.Size(66, 34);
			this.nud.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(382, 170);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 28);
			this.label4.TabIndex = 0;
			this.label4.Text = "phút";
			// 
			// lblChonMonHoc
			// 
			this.lblChonMonHoc.AutoSize = true;
			this.lblChonMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChonMonHoc.Location = new System.Drawing.Point(47, 225);
			this.lblChonMonHoc.Name = "lblChonMonHoc";
			this.lblChonMonHoc.Size = new System.Drawing.Size(149, 28);
			this.lblChonMonHoc.TabIndex = 5;
			this.lblChonMonHoc.Text = "Chọn môn học: ";
			// 
			// cbMonHoc
			// 
			this.cbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMonHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMonHoc.FormattingEnabled = true;
			this.cbMonHoc.Location = new System.Drawing.Point(297, 222);
			this.cbMonHoc.Name = "cbMonHoc";
			this.cbMonHoc.Size = new System.Drawing.Size(312, 36);
			this.cbMonHoc.TabIndex = 6;
			this.cbMonHoc.SelectedValueChanged += new System.EventHandler(this.cbMonHoc_SelectedValueChanged);
			// 
			// fThemDeThi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(661, 346);
			this.Controls.Add(this.cbMonHoc);
			this.Controls.Add(this.lblChonMonHoc);
			this.Controls.Add(this.nud);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTenlop);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "fThemDeThi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thêm đề thi";
			((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenlop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblChonMonHoc;
		private System.Windows.Forms.ComboBox cbMonHoc;
	}
}