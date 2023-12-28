/*form1.designer.cs*/

namespace iilk_form_deneme
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
            this.Btn_Listele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.Btn_Cikart = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Bilet_Al = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Filmid = new System.Windows.Forms.TextBox();
            this.Txt_Filmadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Film_Cikistarihi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_filmara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Listele
            // 
            this.Btn_Listele.BackColor = System.Drawing.Color.Gray;
            this.Btn_Listele.Location = new System.Drawing.Point(525, 105);
            this.Btn_Listele.Name = "Btn_Listele";
            this.Btn_Listele.Size = new System.Drawing.Size(122, 37);
            this.Btn_Listele.TabIndex = 0;
            this.Btn_Listele.Text = "Film Listele";
            this.Btn_Listele.UseVisualStyleBackColor = false;
            this.Btn_Listele.Click += new System.EventHandler(this.Btn_Listele_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(43, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(461, 311);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.BackColor = System.Drawing.Color.Gray;
            this.Btn_Ekle.Location = new System.Drawing.Point(525, 170);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(122, 37);
            this.Btn_Ekle.TabIndex = 0;
            this.Btn_Ekle.Text = "Film Ekle";
            this.Btn_Ekle.UseVisualStyleBackColor = false;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_EkleClick);
            // 
            // Btn_Cikart
            // 
            this.Btn_Cikart.BackColor = System.Drawing.Color.Gray;
            this.Btn_Cikart.Location = new System.Drawing.Point(525, 242);
            this.Btn_Cikart.Name = "Btn_Cikart";
            this.Btn_Cikart.Size = new System.Drawing.Size(122, 37);
            this.Btn_Cikart.TabIndex = 0;
            this.Btn_Cikart.Text = "Film Çıkart";
            this.Btn_Cikart.UseVisualStyleBackColor = false;
            this.Btn_Cikart.Click += new System.EventHandler(this.Btn_CıkartClick);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.BackColor = System.Drawing.Color.Gray;
            this.Btn_Guncelle.Location = new System.Drawing.Point(525, 315);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(122, 37);
            this.Btn_Guncelle.TabIndex = 0;
            this.Btn_Guncelle.Text = "Film Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = false;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_GuncelleClick);
            // 
            // Btn_Bilet_Al
            // 
            this.Btn_Bilet_Al.BackColor = System.Drawing.Color.Gray;
            this.Btn_Bilet_Al.Location = new System.Drawing.Point(525, 384);
            this.Btn_Bilet_Al.Name = "Btn_Bilet_Al";
            this.Btn_Bilet_Al.Size = new System.Drawing.Size(121, 40);
            this.Btn_Bilet_Al.TabIndex = 2;
            this.Btn_Bilet_Al.Text = "Bilet Al";
            this.Btn_Bilet_Al.UseVisualStyleBackColor = false;
            this.Btn_Bilet_Al.Click += new System.EventHandler(this.Btn_Bilet_Al_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.IndianRed;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.textBox1.ForeColor = System.Drawing.Color.FloralWhite;
            this.textBox1.Location = new System.Drawing.Point(272, 12);
            this.textBox1.MaxLength = 42767;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 86);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "SİNEMAYA HOŞGELDİNİZ!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Location = new System.Drawing.Point(659, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Film ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Filmid
            // 
            this.Txt_Filmid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Txt_Filmid.Location = new System.Drawing.Point(783, 181);
            this.Txt_Filmid.Name = "Txt_Filmid";
            this.Txt_Filmid.Size = new System.Drawing.Size(93, 22);
            this.Txt_Filmid.TabIndex = 5;
            // 
            // Txt_Filmadi
            // 
            this.Txt_Filmadi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Txt_Filmadi.Location = new System.Drawing.Point(783, 232);
            this.Txt_Filmadi.Name = "Txt_Filmadi";
            this.Txt_Filmadi.Size = new System.Drawing.Size(93, 22);
            this.Txt_Filmadi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Location = new System.Drawing.Point(659, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Film Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Location = new System.Drawing.Point(659, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Çıkış Tarihi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Film_Cikistarihi
            // 
            this.Txt_Film_Cikistarihi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Txt_Film_Cikistarihi.Location = new System.Drawing.Point(783, 281);
            this.Txt_Film_Cikistarihi.Name = "Txt_Film_Cikistarihi";
            this.Txt_Film_Cikistarihi.Size = new System.Drawing.Size(93, 22);
            this.Txt_Film_Cikistarihi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(659, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Film Ara";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_filmara
            // 
            this.Txt_filmara.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Txt_filmara.Location = new System.Drawing.Point(783, 59);
            this.Txt_filmara.Name = "Txt_filmara";
            this.Txt_filmara.Size = new System.Drawing.Size(93, 22);
            this.Txt_filmara.TabIndex = 9;
            this.Txt_filmara.TextChanged += new System.EventHandler(this.Txt_filmara_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iilk_form_deneme.Properties.Resources.sinema_salonu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.Txt_filmara);
            this.Controls.Add(this.Txt_Film_Cikistarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Filmadi);
            this.Controls.Add(this.Txt_Filmid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Bilet_Al);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Guncelle);
            this.Controls.Add(this.Btn_Cikart);
            this.Controls.Add(this.Btn_Ekle);
            this.Controls.Add(this.Btn_Listele);
            this.Name = "Form1";
            this.Text = "Film Adi:";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Listele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.Button Btn_Cikart;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Button Btn_Bilet_Al;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Txt_Filmid;
        public System.Windows.Forms.TextBox Txt_Filmadi;
        public System.Windows.Forms.TextBox Txt_Film_Cikistarihi;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Txt_filmara;
    }
}

------------------------------------------------------------------------------------------
/*program.cs*/

  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iilk_form_deneme
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}


