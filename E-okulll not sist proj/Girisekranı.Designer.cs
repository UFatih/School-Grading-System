
namespace E_okulll_not_sist_proj
{
    partial class Girisekranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Girisekranı));
            this.ogrencipng = new System.Windows.Forms.PictureBox();
            this.ogretmenpng = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencipng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenpng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrencipng
            // 
            this.ogrencipng.BackColor = System.Drawing.SystemColors.Window;
            this.ogrencipng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogrencipng.Image = ((System.Drawing.Image)(resources.GetObject("ogrencipng.Image")));
            this.ogrencipng.Location = new System.Drawing.Point(189, 69);
            this.ogrencipng.Name = "ogrencipng";
            this.ogrencipng.Size = new System.Drawing.Size(154, 99);
            this.ogrencipng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ogrencipng.TabIndex = 0;
            this.ogrencipng.TabStop = false;
            this.ogrencipng.Click += new System.EventHandler(this.ogrencipng_Click);
            // 
            // ogretmenpng
            // 
            this.ogretmenpng.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ogretmenpng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogretmenpng.Image = ((System.Drawing.Image)(resources.GetObject("ogretmenpng.Image")));
            this.ogretmenpng.Location = new System.Drawing.Point(470, 69);
            this.ogretmenpng.Name = "ogretmenpng";
            this.ogretmenpng.Size = new System.Drawing.Size(149, 99);
            this.ogretmenpng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ogretmenpng.TabIndex = 1;
            this.ogretmenpng.TabStop = false;
            this.ogretmenpng.Click += new System.EventHandler(this.ogretmenpng_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 224);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 29);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(124, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(749, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(221, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öğrenci";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(491, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Öğretmen";
            // 
            // Girisekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ogretmenpng);
            this.Controls.Add(this.ogrencipng);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Girisekranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisEkranı";
            ((System.ComponentModel.ISupportInitialize)(this.ogrencipng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenpng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ogrencipng;
        private System.Windows.Forms.PictureBox ogretmenpng;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

