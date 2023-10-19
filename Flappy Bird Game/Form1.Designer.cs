
namespace Flappy_Bird_Game
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
            this.kus = new System.Windows.Forms.PictureBox();
            this.boruÜst = new System.Windows.Forms.PictureBox();
            this.boruAlt = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.lblscore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruÜst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            this.SuspendLayout();
            // 
            // kus
            // 
            this.kus.Image = ((System.Drawing.Image)(resources.GetObject("kus.Image")));
            this.kus.Location = new System.Drawing.Point(63, 273);
            this.kus.Name = "kus";
            this.kus.Size = new System.Drawing.Size(121, 73);
            this.kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kus.TabIndex = 0;
            this.kus.TabStop = false;
            // 
            // boruÜst
            // 
            this.boruÜst.Image = ((System.Drawing.Image)(resources.GetObject("boruÜst.Image")));
            this.boruÜst.Location = new System.Drawing.Point(818, 1);
            this.boruÜst.Name = "boruÜst";
            this.boruÜst.Size = new System.Drawing.Size(104, 94);
            this.boruÜst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruÜst.TabIndex = 1;
            this.boruÜst.TabStop = false;
            // 
            // boruAlt
            // 
            this.boruAlt.Image = ((System.Drawing.Image)(resources.GetObject("boruAlt.Image")));
            this.boruAlt.Location = new System.Drawing.Point(655, 422);
            this.boruAlt.Name = "boruAlt";
            this.boruAlt.Size = new System.Drawing.Size(104, 121);
            this.boruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruAlt.TabIndex = 2;
            this.boruAlt.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Image = ((System.Drawing.Image)(resources.GetObject("zemin.Image")));
            this.zemin.Location = new System.Drawing.Point(13, 540);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(935, 99);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 3;
            this.zemin.TabStop = false;
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(39, 22);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(103, 29);
            this.lblscore.TabIndex = 6;
            this.lblscore.Text = "Score:0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 640);
            this.Controls.Add(this.kus);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.boruAlt);
            this.Controls.Add(this.boruÜst);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.kus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruÜst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kus;
        private System.Windows.Forms.PictureBox boruÜst;
        private System.Windows.Forms.PictureBox boruAlt;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

