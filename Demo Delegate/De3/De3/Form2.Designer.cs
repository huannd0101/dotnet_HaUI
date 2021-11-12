
namespace De3
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemToanKhoa = new System.Windows.Forms.TextBox();
            this.txtNamTotNghiep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 38);
            this.label3.TabIndex = 16;
            this.label3.Text = "Form two";
            // 
            // txtDiemToanKhoa
            // 
            this.txtDiemToanKhoa.Location = new System.Drawing.Point(309, 214);
            this.txtDiemToanKhoa.Name = "txtDiemToanKhoa";
            this.txtDiemToanKhoa.Size = new System.Drawing.Size(328, 22);
            this.txtDiemToanKhoa.TabIndex = 1;
            // 
            // txtNamTotNghiep
            // 
            this.txtNamTotNghiep.Location = new System.Drawing.Point(312, 158);
            this.txtNamTotNghiep.Name = "txtNamTotNghiep";
            this.txtNamTotNghiep.Size = new System.Drawing.Size(328, 22);
            this.txtNamTotNghiep.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Điểm toàn khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Năm tốt nghiệp";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(529, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 49);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(164, 362);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(111, 49);
            this.btnReceive.TabIndex = 2;
            this.btnReceive.Text = "Nhận";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 509);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiemToanKhoa);
            this.Controls.Add(this.txtNamTotNghiep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReceive);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiemToanKhoa;
        private System.Windows.Forms.TextBox txtNamTotNghiep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReceive;
    }
}