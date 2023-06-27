
namespace Hwid_changer
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bilgi = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pcid = new System.Windows.Forms.Label();
            this.sisteminfo = new System.Windows.Forms.Label();
            this.macid = new System.Windows.Forms.Label();
            this.hwidid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hddno = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cpuno = new System.Windows.Forms.Label();
            this.Bilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bilgi
            // 
            this.Bilgi.Controls.Add(this.cpuno);
            this.Bilgi.Controls.Add(this.label6);
            this.Bilgi.Controls.Add(this.hddno);
            this.Bilgi.Controls.Add(this.label5);
            this.Bilgi.Controls.Add(this.hwidid);
            this.Bilgi.Controls.Add(this.macid);
            this.Bilgi.Controls.Add(this.sisteminfo);
            this.Bilgi.Controls.Add(this.pcid);
            this.Bilgi.Controls.Add(this.label4);
            this.Bilgi.Controls.Add(this.label3);
            this.Bilgi.Controls.Add(this.label2);
            this.Bilgi.Controls.Add(this.label1);
            this.Bilgi.Location = new System.Drawing.Point(21, 33);
            this.Bilgi.Name = "Bilgi";
            this.Bilgi.Size = new System.Drawing.Size(980, 326);
            this.Bilgi.TabIndex = 0;
            this.Bilgi.TabStop = false;
            this.Bilgi.Text = "Bilgi";
            this.Bilgi.Enter += new System.EventHandler(this.Bilgi_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cihaz Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(90, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "MAC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(80, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "HWID:";
            // 
            // pcid
            // 
            this.pcid.AutoSize = true;
            this.pcid.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcid.ForeColor = System.Drawing.Color.RosyBrown;
            this.pcid.Location = new System.Drawing.Point(170, 39);
            this.pcid.Name = "pcid";
            this.pcid.Size = new System.Drawing.Size(176, 27);
            this.pcid.TabIndex = 4;
            this.pcid.Text = "Windows 10 Pro";
            this.pcid.Click += new System.EventHandler(this.pcid_Click);
            // 
            // sisteminfo
            // 
            this.sisteminfo.AutoSize = true;
            this.sisteminfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sisteminfo.ForeColor = System.Drawing.Color.RosyBrown;
            this.sisteminfo.Location = new System.Drawing.Point(170, 81);
            this.sisteminfo.Name = "sisteminfo";
            this.sisteminfo.Size = new System.Drawing.Size(176, 27);
            this.sisteminfo.TabIndex = 5;
            this.sisteminfo.Text = "Windows 10 Pro";
            // 
            // macid
            // 
            this.macid.AutoSize = true;
            this.macid.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macid.ForeColor = System.Drawing.Color.RosyBrown;
            this.macid.Location = new System.Drawing.Point(170, 125);
            this.macid.Name = "macid";
            this.macid.Size = new System.Drawing.Size(176, 27);
            this.macid.TabIndex = 6;
            this.macid.Text = "Windows 10 Pro";
            // 
            // hwidid
            // 
            this.hwidid.AutoSize = true;
            this.hwidid.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hwidid.ForeColor = System.Drawing.Color.RosyBrown;
            this.hwidid.Location = new System.Drawing.Point(170, 246);
            this.hwidid.Name = "hwidid";
            this.hwidid.Size = new System.Drawing.Size(161, 25);
            this.hwidid.TabIndex = 7;
            this.hwidid.Text = "Windows 10 Pro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "HDD Seri No:";
            // 
            // hddno
            // 
            this.hddno.AutoSize = true;
            this.hddno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddno.ForeColor = System.Drawing.Color.RosyBrown;
            this.hddno.Location = new System.Drawing.Point(170, 165);
            this.hddno.Name = "hddno";
            this.hddno.Size = new System.Drawing.Size(176, 27);
            this.hddno.TabIndex = 9;
            this.hddno.Text = "Windows 10 Pro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "İşlemci Seri No:";
            // 
            // cpuno
            // 
            this.cpuno.AutoSize = true;
            this.cpuno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuno.ForeColor = System.Drawing.Color.RosyBrown;
            this.cpuno.Location = new System.Drawing.Point(170, 208);
            this.cpuno.Name = "cpuno";
            this.cpuno.Size = new System.Drawing.Size(176, 27);
            this.cpuno.TabIndex = 11;
            this.cpuno.Text = "Windows 10 Pro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 393);
            this.Controls.Add(this.Bilgi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Bilgi.ResumeLayout(false);
            this.Bilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Bilgi;
        private System.Windows.Forms.Label hwidid;
        private System.Windows.Forms.Label macid;
        private System.Windows.Forms.Label sisteminfo;
        private System.Windows.Forms.Label pcid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hddno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cpuno;
        private System.Windows.Forms.Label label6;
    }
}

