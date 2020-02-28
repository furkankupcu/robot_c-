namespace proje2mfk
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.robotÜretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.özelliklerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çeşitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kumandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(146, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Robot Üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(128, 365);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(182, 36);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robotÜretToolStripMenuItem,
            this.kumandaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // robotÜretToolStripMenuItem
            // 
            this.robotÜretToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.özelliklerToolStripMenuItem1,
            this.çeşitToolStripMenuItem1});
            this.robotÜretToolStripMenuItem.Name = "robotÜretToolStripMenuItem";
            this.robotÜretToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.robotÜretToolStripMenuItem.Text = "Robot";
            // 
            // özelliklerToolStripMenuItem1
            // 
            this.özelliklerToolStripMenuItem1.Name = "özelliklerToolStripMenuItem1";
            this.özelliklerToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.özelliklerToolStripMenuItem1.Text = "Özellikler";
            this.özelliklerToolStripMenuItem1.Click += new System.EventHandler(this.özelliklerToolStripMenuItem1_Click);
            // 
            // çeşitToolStripMenuItem1
            // 
            this.çeşitToolStripMenuItem1.Name = "çeşitToolStripMenuItem1";
            this.çeşitToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.çeşitToolStripMenuItem1.Text = "Çeşit";
            this.çeşitToolStripMenuItem1.Click += new System.EventHandler(this.çeşitToolStripMenuItem1_Click);
            // 
            // kumandaToolStripMenuItem
            // 
            this.kumandaToolStripMenuItem.Name = "kumandaToolStripMenuItem";
            this.kumandaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.kumandaToolStripMenuItem.Text = "Kumanda";
            this.kumandaToolStripMenuItem.Click += new System.EventHandler(this.kumandaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem robotÜretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kumandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem özelliklerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çeşitToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

