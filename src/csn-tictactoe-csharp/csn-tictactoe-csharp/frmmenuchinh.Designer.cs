﻿
namespace csn_tictactoe_csharp
{
    partial class frmmenuchinh
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
            this.lbchonchedochoi = new System.Windows.Forms.Label();
            this.lbchonkytu = new System.Windows.Forms.Label();
            this.btnx = new System.Windows.Forms.Button();
            this.btno = new System.Windows.Forms.Button();
            this.btn3x3 = new System.Windows.Forms.Button();
            this.btn5x5 = new System.Windows.Forms.Button();
            this.btn7x7 = new System.Windows.Forms.Button();
            this.btnbatdau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbchonchedochoi
            // 
            this.lbchonchedochoi.AutoSize = true;
            this.lbchonchedochoi.Location = new System.Drawing.Point(329, 190);
            this.lbchonchedochoi.Name = "lbchonchedochoi";
            this.lbchonchedochoi.Size = new System.Drawing.Size(141, 20);
            this.lbchonchedochoi.TabIndex = 0;
            this.lbchonchedochoi.Text = "Chọn Chế Độ Chơi";
            // 
            // lbchonkytu
            // 
            this.lbchonkytu.AutoSize = true;
            this.lbchonkytu.Location = new System.Drawing.Point(352, 34);
            this.lbchonkytu.Name = "lbchonkytu";
            this.lbchonkytu.Size = new System.Drawing.Size(90, 20);
            this.lbchonkytu.TabIndex = 1;
            this.lbchonkytu.Text = "Chọn Ký Tự";
            // 
            // btnx
            // 
            this.btnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx.ForeColor = System.Drawing.Color.Blue;
            this.btnx.Location = new System.Drawing.Point(285, 93);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(75, 75);
            this.btnx.TabIndex = 2;
            this.btnx.Text = "X";
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // btno
            // 
            this.btno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btno.ForeColor = System.Drawing.Color.Red;
            this.btno.Location = new System.Drawing.Point(446, 93);
            this.btno.Name = "btno";
            this.btno.Size = new System.Drawing.Size(75, 75);
            this.btno.TabIndex = 3;
            this.btno.Text = "O";
            this.btno.UseVisualStyleBackColor = true;
            this.btno.Click += new System.EventHandler(this.btno_Click);
            // 
            // btn3x3
            // 
            this.btn3x3.Location = new System.Drawing.Point(241, 248);
            this.btn3x3.Name = "btn3x3";
            this.btn3x3.Size = new System.Drawing.Size(75, 75);
            this.btn3x3.TabIndex = 4;
            this.btn3x3.Text = "3x3";
            this.btn3x3.UseVisualStyleBackColor = true;
            this.btn3x3.Click += new System.EventHandler(this.btn3x3_Click);
            // 
            // btn5x5
            // 
            this.btn5x5.Location = new System.Drawing.Point(356, 248);
            this.btn5x5.Name = "btn5x5";
            this.btn5x5.Size = new System.Drawing.Size(75, 75);
            this.btn5x5.TabIndex = 5;
            this.btn5x5.Text = "5x5";
            this.btn5x5.UseVisualStyleBackColor = true;
            this.btn5x5.Click += new System.EventHandler(this.btn5x5_Click);
            // 
            // btn7x7
            // 
            this.btn7x7.Location = new System.Drawing.Point(469, 248);
            this.btn7x7.Name = "btn7x7";
            this.btn7x7.Size = new System.Drawing.Size(75, 75);
            this.btn7x7.TabIndex = 6;
            this.btn7x7.Text = "7x7";
            this.btn7x7.UseVisualStyleBackColor = true;
            this.btn7x7.Click += new System.EventHandler(this.btn7x7_Click);
            // 
            // btnbatdau
            // 
            this.btnbatdau.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnbatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbatdau.Location = new System.Drawing.Point(315, 353);
            this.btnbatdau.Name = "btnbatdau";
            this.btnbatdau.Size = new System.Drawing.Size(175, 75);
            this.btnbatdau.TabIndex = 7;
            this.btnbatdau.Text = "Bắt đầu chơi";
            this.btnbatdau.UseVisualStyleBackColor = false;
            this.btnbatdau.Click += new System.EventHandler(this.btnbatdau_Click);
            // 
            // frmmenuchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbatdau);
            this.Controls.Add(this.btn7x7);
            this.Controls.Add(this.btn5x5);
            this.Controls.Add(this.btn3x3);
            this.Controls.Add(this.btno);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.lbchonkytu);
            this.Controls.Add(this.lbchonchedochoi);
            this.Name = "frmmenuchinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trò chơi tic-tac-toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbchonchedochoi;
        private System.Windows.Forms.Label lbchonkytu;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Button btno;
        private System.Windows.Forms.Button btn3x3;
        private System.Windows.Forms.Button btn5x5;
        private System.Windows.Forms.Button btn7x7;
        private System.Windows.Forms.Button btnbatdau;
    }
}