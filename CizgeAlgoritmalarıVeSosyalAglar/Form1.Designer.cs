namespace CizgeAlgoritmalarıVeSosyalAglar
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKoseSayisi = new System.Windows.Forms.Button();
            this.txtKoseSayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKose1 = new System.Windows.Forms.TextBox();
            this.txtKose2 = new System.Windows.Forms.TextBox();
            this.txtKoselerArasıAgırlık = new System.Windows.Forms.TextBox();
            this.btnKenarBilGir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENÜToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijktraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genişlikÖncelikliDolaşmaProblemiBFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kruskalAlgoritmasıTabanlıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primAlgoritmasıTabanlıEnKüçükAğaçKapsayanProblemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDijktra = new System.Windows.Forms.GroupBox();
            this.btnDijktra = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDijktra2 = new System.Windows.Forms.TextBox();
            this.txtDijktra1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbBFS = new System.Windows.Forms.GroupBox();
            this.listBFS = new System.Windows.Forms.ListBox();
            this.btnBFSHesapla = new System.Windows.Forms.Button();
            this.txtBFS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbKruskal = new System.Windows.Forms.GroupBox();
            this.txtKruskal = new System.Windows.Forms.TextBox();
            this.gbPrim = new System.Windows.Forms.GroupBox();
            this.txtPrim = new System.Windows.Forms.TextBox();
            this.sosyalAğToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gbDijktra.SuspendLayout();
            this.gbBFS.SuspendLayout();
            this.gbKruskal.SuspendLayout();
            this.gbPrim.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Köşe Sayısı :";
            // 
            // btnKoseSayisi
            // 
            this.btnKoseSayisi.Location = new System.Drawing.Point(54, 80);
            this.btnKoseSayisi.Name = "btnKoseSayisi";
            this.btnKoseSayisi.Size = new System.Drawing.Size(101, 29);
            this.btnKoseSayisi.TabIndex = 1;
            this.btnKoseSayisi.Text = "Köşe Sayısı Gir";
            this.btnKoseSayisi.UseVisualStyleBackColor = true;
            this.btnKoseSayisi.Click += new System.EventHandler(this.btnKoseSayisi_Click);
            // 
            // txtKoseSayisi
            // 
            this.txtKoseSayisi.Location = new System.Drawing.Point(116, 40);
            this.txtKoseSayisi.Multiline = true;
            this.txtKoseSayisi.Name = "txtKoseSayisi";
            this.txtKoseSayisi.Size = new System.Drawing.Size(76, 21);
            this.txtKoseSayisi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kenar Özellikleri :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Köşe 1 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Köşe 2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Köşeler Arası Ağırlık :";
            // 
            // txtKose1
            // 
            this.txtKose1.Location = new System.Drawing.Point(164, 179);
            this.txtKose1.Multiline = true;
            this.txtKose1.Name = "txtKose1";
            this.txtKose1.Size = new System.Drawing.Size(76, 21);
            this.txtKose1.TabIndex = 7;
            // 
            // txtKose2
            // 
            this.txtKose2.Location = new System.Drawing.Point(164, 224);
            this.txtKose2.Multiline = true;
            this.txtKose2.Name = "txtKose2";
            this.txtKose2.Size = new System.Drawing.Size(76, 21);
            this.txtKose2.TabIndex = 8;
            // 
            // txtKoselerArasıAgırlık
            // 
            this.txtKoselerArasıAgırlık.Location = new System.Drawing.Point(164, 265);
            this.txtKoselerArasıAgırlık.Multiline = true;
            this.txtKoselerArasıAgırlık.Name = "txtKoselerArasıAgırlık";
            this.txtKoselerArasıAgırlık.Size = new System.Drawing.Size(76, 21);
            this.txtKoselerArasıAgırlık.TabIndex = 9;
            // 
            // btnKenarBilGir
            // 
            this.btnKenarBilGir.Location = new System.Drawing.Point(54, 317);
            this.btnKenarBilGir.Name = "btnKenarBilGir";
            this.btnKenarBilGir.Size = new System.Drawing.Size(123, 32);
            this.btnKenarBilGir.TabIndex = 10;
            this.btnKenarBilGir.Text = "Kenar Bilgilerini Gir";
            this.btnKenarBilGir.UseVisualStyleBackColor = true;
            this.btnKenarBilGir.Click += new System.EventHandler(this.btnKenarBilGir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENÜToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(299, 31);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(173, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENÜToolStripMenuItem
            // 
            this.mENÜToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dijktraToolStripMenuItem,
            this.genişlikÖncelikliDolaşmaProblemiBFSToolStripMenuItem,
            this.kruskalAlgoritmasıTabanlıToolStripMenuItem,
            this.primAlgoritmasıTabanlıEnKüçükAğaçKapsayanProblemiToolStripMenuItem,
            this.sosyalAğToolStripMenuItem});
            this.mENÜToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mENÜToolStripMenuItem.Name = "mENÜToolStripMenuItem";
            this.mENÜToolStripMenuItem.Size = new System.Drawing.Size(165, 20);
            this.mENÜToolStripMenuItem.Text = "                 MENÜ                    ";
            // 
            // dijktraToolStripMenuItem
            // 
            this.dijktraToolStripMenuItem.Name = "dijktraToolStripMenuItem";
            this.dijktraToolStripMenuItem.Size = new System.Drawing.Size(402, 22);
            this.dijktraToolStripMenuItem.Text = "Dijktra\'nın En Kısa Yol Problemi";
            this.dijktraToolStripMenuItem.Click += new System.EventHandler(this.dijktraToolStripMenuItem_Click);
            // 
            // genişlikÖncelikliDolaşmaProblemiBFSToolStripMenuItem
            // 
            this.genişlikÖncelikliDolaşmaProblemiBFSToolStripMenuItem.Name = "genişlikÖncelikliDolaşmaProblemiBFSToolStripMenuItem";
            this.genişlikÖncelikliDolaşmaProblemiBFSToolStripMenuItem.Size = new System.Drawing.Size(402, 22);
            this.genişlikÖncelikliDolaşmaProblemiBFSToolStripMenuItem.Text = "Genişlik Öncelikli Dolaşma problemi (BFS)";
            this.genişlikÖncelikliDolaşmaProblemiBFSToolStripMenuItem.Click += new System.EventHandler(this.genişlikÖncelikliDolaşmaProblemiBFSToolStripMenuItem_Click);
            // 
            // kruskalAlgoritmasıTabanlıToolStripMenuItem
            // 
            this.kruskalAlgoritmasıTabanlıToolStripMenuItem.Name = "kruskalAlgoritmasıTabanlıToolStripMenuItem";
            this.kruskalAlgoritmasıTabanlıToolStripMenuItem.Size = new System.Drawing.Size(402, 22);
            this.kruskalAlgoritmasıTabanlıToolStripMenuItem.Text = "Kruskal Algoritması Tabanlı En Küçük Ağaç Kapyan Problemi";
            this.kruskalAlgoritmasıTabanlıToolStripMenuItem.Click += new System.EventHandler(this.kruskalAlgoritmasıTabanlıToolStripMenuItem_Click);
            // 
            // primAlgoritmasıTabanlıEnKüçükAğaçKapsayanProblemiToolStripMenuItem
            // 
            this.primAlgoritmasıTabanlıEnKüçükAğaçKapsayanProblemiToolStripMenuItem.Name = "primAlgoritmasıTabanlıEnKüçükAğaçKapsayanProblemiToolStripMenuItem";
            this.primAlgoritmasıTabanlıEnKüçükAğaçKapsayanProblemiToolStripMenuItem.Size = new System.Drawing.Size(402, 22);
            this.primAlgoritmasıTabanlıEnKüçükAğaçKapsayanProblemiToolStripMenuItem.Text = "Prim Algoritması Tabanlı En Küçük Ağaç Kapsayan Problemi";
            this.primAlgoritmasıTabanlıEnKüçükAğaçKapsayanProblemiToolStripMenuItem.Click += new System.EventHandler(this.primAlgoritmasıTabanlıEnKüçükAğaçKapsayanProblemiToolStripMenuItem_Click);
            // 
            // gbDijktra
            // 
            this.gbDijktra.Controls.Add(this.btnDijktra);
            this.gbDijktra.Controls.Add(this.label8);
            this.gbDijktra.Controls.Add(this.txtDijktra2);
            this.gbDijktra.Controls.Add(this.txtDijktra1);
            this.gbDijktra.Controls.Add(this.label7);
            this.gbDijktra.Controls.Add(this.label6);
            this.gbDijktra.Location = new System.Drawing.Point(658, 12);
            this.gbDijktra.Name = "gbDijktra";
            this.gbDijktra.Size = new System.Drawing.Size(237, 178);
            this.gbDijktra.TabIndex = 12;
            this.gbDijktra.TabStop = false;
            this.gbDijktra.Visible = false;
            // 
            // btnDijktra
            // 
            this.btnDijktra.Location = new System.Drawing.Point(31, 137);
            this.btnDijktra.Name = "btnDijktra";
            this.btnDijktra.Size = new System.Drawing.Size(101, 29);
            this.btnDijktra.TabIndex = 13;
            this.btnDijktra.Text = "Dijktra Hesapla";
            this.btnDijktra.UseVisualStyleBackColor = true;
            this.btnDijktra.Click += new System.EventHandler(this.btnDijktra_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dijktra Hesabı İçin Köşe Çiftleri";
            // 
            // txtDijktra2
            // 
            this.txtDijktra2.Location = new System.Drawing.Point(98, 99);
            this.txtDijktra2.Multiline = true;
            this.txtDijktra2.Name = "txtDijktra2";
            this.txtDijktra2.Size = new System.Drawing.Size(76, 21);
            this.txtDijktra2.TabIndex = 13;
            // 
            // txtDijktra1
            // 
            this.txtDijktra1.Location = new System.Drawing.Point(98, 55);
            this.txtDijktra1.Multiline = true;
            this.txtDijktra1.Name = "txtDijktra1";
            this.txtDijktra1.Size = new System.Drawing.Size(76, 21);
            this.txtDijktra1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Köşe 2 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Köşe 1 :";
            // 
            // gbBFS
            // 
            this.gbBFS.Controls.Add(this.listBFS);
            this.gbBFS.Controls.Add(this.btnBFSHesapla);
            this.gbBFS.Controls.Add(this.txtBFS);
            this.gbBFS.Controls.Add(this.label10);
            this.gbBFS.Controls.Add(this.label9);
            this.gbBFS.Location = new System.Drawing.Point(926, 12);
            this.gbBFS.Name = "gbBFS";
            this.gbBFS.Size = new System.Drawing.Size(217, 387);
            this.gbBFS.TabIndex = 13;
            this.gbBFS.TabStop = false;
            this.gbBFS.Visible = false;
            // 
            // listBFS
            // 
            this.listBFS.FormattingEnabled = true;
            this.listBFS.Location = new System.Drawing.Point(44, 167);
            this.listBFS.Name = "listBFS";
            this.listBFS.Size = new System.Drawing.Size(120, 134);
            this.listBFS.TabIndex = 19;
            this.listBFS.Visible = false;
            // 
            // btnBFSHesapla
            // 
            this.btnBFSHesapla.Location = new System.Drawing.Point(40, 100);
            this.btnBFSHesapla.Name = "btnBFSHesapla";
            this.btnBFSHesapla.Size = new System.Drawing.Size(101, 29);
            this.btnBFSHesapla.TabIndex = 18;
            this.btnBFSHesapla.Text = "BFS Hesapla";
            this.btnBFSHesapla.UseVisualStyleBackColor = true;
            this.btnBFSHesapla.Click += new System.EventHandler(this.btnBFSHesapla_Click);
            // 
            // txtBFS
            // 
            this.txtBFS.Location = new System.Drawing.Point(88, 61);
            this.txtBFS.Multiline = true;
            this.txtBFS.Name = "txtBFS";
            this.txtBFS.Size = new System.Drawing.Size(76, 21);
            this.txtBFS.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(19, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Köşe  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(19, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "BFS İçin  Köşe Numarası";
            // 
            // gbKruskal
            // 
            this.gbKruskal.Controls.Add(this.txtKruskal);
            this.gbKruskal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbKruskal.Location = new System.Drawing.Point(676, 12);
            this.gbKruskal.Name = "gbKruskal";
            this.gbKruskal.Size = new System.Drawing.Size(200, 252);
            this.gbKruskal.TabIndex = 14;
            this.gbKruskal.TabStop = false;
            this.gbKruskal.Text = "Kruskal Algoritması";
            this.gbKruskal.Visible = false;
            // 
            // txtKruskal
            // 
            this.txtKruskal.Location = new System.Drawing.Point(15, 37);
            this.txtKruskal.Multiline = true;
            this.txtKruskal.Name = "txtKruskal";
            this.txtKruskal.Size = new System.Drawing.Size(166, 154);
            this.txtKruskal.TabIndex = 0;
            this.txtKruskal.TextChanged += new System.EventHandler(this.txtKruskal_TextChanged);
            // 
            // gbPrim
            // 
            this.gbPrim.Controls.Add(this.txtPrim);
            this.gbPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbPrim.Location = new System.Drawing.Point(629, 31);
            this.gbPrim.Name = "gbPrim";
            this.gbPrim.Size = new System.Drawing.Size(213, 359);
            this.gbPrim.TabIndex = 15;
            this.gbPrim.TabStop = false;
            this.gbPrim.Text = "Prim Algoritması";
            this.gbPrim.Visible = false;
            // 
            // txtPrim
            // 
            this.txtPrim.Location = new System.Drawing.Point(17, 27);
            this.txtPrim.Multiline = true;
            this.txtPrim.Name = "txtPrim";
            this.txtPrim.Size = new System.Drawing.Size(166, 154);
            this.txtPrim.TabIndex = 1;
            // 
            // sosyalAğToolStripMenuItem
            // 
            this.sosyalAğToolStripMenuItem.Name = "sosyalAğToolStripMenuItem";
            this.sosyalAğToolStripMenuItem.Size = new System.Drawing.Size(402, 22);
            this.sosyalAğToolStripMenuItem.Text = "Sosyal Ağ";
            this.sosyalAğToolStripMenuItem.Click += new System.EventHandler(this.sosyalAğToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 450);
            this.Controls.Add(this.gbPrim);
            this.Controls.Add(this.gbKruskal);
            this.Controls.Add(this.gbBFS);
            this.Controls.Add(this.gbDijktra);
            this.Controls.Add(this.btnKenarBilGir);
            this.Controls.Add(this.txtKoselerArasıAgırlık);
            this.Controls.Add(this.txtKose2);
            this.Controls.Add(this.txtKose1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKoseSayisi);
            this.Controls.Add(this.btnKoseSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbDijktra.ResumeLayout(false);
            this.gbDijktra.PerformLayout();
            this.gbBFS.ResumeLayout(false);
            this.gbBFS.PerformLayout();
            this.gbKruskal.ResumeLayout(false);
            this.gbKruskal.PerformLayout();
            this.gbPrim.ResumeLayout(false);
            this.gbPrim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKoseSayisi;
        private System.Windows.Forms.TextBox txtKoseSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKose1;
        private System.Windows.Forms.TextBox txtKose2;
        private System.Windows.Forms.TextBox txtKoselerArasıAgırlık;
        private System.Windows.Forms.Button btnKenarBilGir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENÜToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijktraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genişlikÖncelikliDolaşmaProblemiBFSToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbDijktra;
        private System.Windows.Forms.Button btnDijktra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDijktra2;
        private System.Windows.Forms.TextBox txtDijktra1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbBFS;
        private System.Windows.Forms.ListBox listBFS;
        private System.Windows.Forms.Button btnBFSHesapla;
        private System.Windows.Forms.TextBox txtBFS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem kruskalAlgoritmasıTabanlıToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbKruskal;
        private System.Windows.Forms.TextBox txtKruskal;
        private System.Windows.Forms.ToolStripMenuItem primAlgoritmasıTabanlıEnKüçükAğaçKapsayanProblemiToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbPrim;
        private System.Windows.Forms.TextBox txtPrim;
        private System.Windows.Forms.ToolStripMenuItem sosyalAğToolStripMenuItem;
    }
}

