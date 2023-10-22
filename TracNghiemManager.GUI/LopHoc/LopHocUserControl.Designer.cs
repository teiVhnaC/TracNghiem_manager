﻿using System.Drawing;
using System.Windows.Forms;

namespace TracNghiemManager.GUI.LopHoc
{
    partial class LopHocUserControl
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
			this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panelHeading = new System.Windows.Forms.TableLayoutPanel();
			this.btnThem = new System.Windows.Forms.Button();
			this.lblHeading = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.mainPanel.SuspendLayout();
			this.panelHeading.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
			this.mainPanel.ColumnCount = 1;
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
			this.mainPanel.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.mainPanel.Controls.Add(this.panelHeading, 0, 0);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Margin = new System.Windows.Forms.Padding(17, 18, 17, 18);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.RowCount = 2;
			this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.56185F));
			this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.43815F));
			this.mainPanel.Size = new System.Drawing.Size(1180, 671);
			this.mainPanel.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 94);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1174, 574);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// panelHeading
			// 
			this.panelHeading.ColumnCount = 2;
			this.panelHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.47734F));
			this.panelHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.52266F));
			this.panelHeading.Controls.Add(this.lblHeading, 0, 0);
			this.panelHeading.Controls.Add(this.btnThem, 1, 0);
			this.panelHeading.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelHeading.Location = new System.Drawing.Point(2, 2);
			this.panelHeading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelHeading.Name = "panelHeading";
			this.panelHeading.RowCount = 1;
			this.panelHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.panelHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.panelHeading.Size = new System.Drawing.Size(1176, 87);
			this.panelHeading.TabIndex = 2;
			// 
			// btnThem
			// 
			this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(215)))), ((int)(((byte)(251)))));
			this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnThem.FlatAppearance.BorderSize = 0;
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(990, 20);
			this.btnThem.Margin = new System.Windows.Forms.Padding(3, 3, 56, 3);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(130, 46);
			this.btnThem.TabIndex = 1;
			this.btnThem.Text = "Tạo lớp học";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// lblHeading
			// 
			this.lblHeading.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblHeading.AutoSize = true;
			this.lblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
			this.lblHeading.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold);
			this.lblHeading.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblHeading.Location = new System.Drawing.Point(2, 14);
			this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblHeading.Name = "lblHeading";
			this.lblHeading.Size = new System.Drawing.Size(539, 58);
			this.lblHeading.TabIndex = 2;
			this.lblHeading.Text = "Các lớp học đã tham gia";
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.button2.ForeColor = System.Drawing.Color.SteelBlue;
			this.button2.Location = new System.Drawing.Point(5, 0);
			this.button2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.button2.Size = new System.Drawing.Size(173, 155);
			this.button2.TabIndex = 2;
			this.button2.Text = "THÊM";
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			// 
			// LopHocUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainPanel);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "LopHocUserControl";
			this.Size = new System.Drawing.Size(1180, 671);
			this.mainPanel.ResumeLayout(false);
			this.panelHeading.ResumeLayout(false);
			this.panelHeading.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel mainPanel;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TableLayoutPanel panelHeading;
        private Button btnThem;
        private Label lblHeading;
    }
}
