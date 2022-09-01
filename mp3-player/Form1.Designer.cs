namespace mp3_player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSongs = new System.Windows.Forms.Label();
            this.lbxSongs = new System.Windows.Forms.ListBox();
            this.lbxAdresses = new System.Windows.Forms.ListBox();
            this.lblAdresses = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.volUp = new System.Windows.Forms.Button();
            this.volDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(135, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 95);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Şarkı Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSongs.Location = new System.Drawing.Point(-3, 52);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(105, 16);
            this.lblSongs.TabIndex = 2;
            this.lblSongs.Text = "Ses Dosyaları";
            // 
            // lbxSongs
            // 
            this.lbxSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxSongs.FormattingEnabled = true;
            this.lbxSongs.ItemHeight = 16;
            this.lbxSongs.Location = new System.Drawing.Point(0, 85);
            this.lbxSongs.Name = "lbxSongs";
            this.lbxSongs.Size = new System.Drawing.Size(120, 84);
            this.lbxSongs.TabIndex = 3;
            this.lbxSongs.SelectedIndexChanged += new System.EventHandler(this.lbxSongs_SelectedIndexChanged);
            // 
            // lbxAdresses
            // 
            this.lbxAdresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxAdresses.FormattingEnabled = true;
            this.lbxAdresses.ItemHeight = 16;
            this.lbxAdresses.Location = new System.Drawing.Point(228, 85);
            this.lbxAdresses.Name = "lbxAdresses";
            this.lbxAdresses.Size = new System.Drawing.Size(120, 84);
            this.lbxAdresses.TabIndex = 6;
            // 
            // lblAdresses
            // 
            this.lblAdresses.AutoSize = true;
            this.lblAdresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdresses.Location = new System.Drawing.Point(225, 52);
            this.lblAdresses.Name = "lblAdresses";
            this.lblAdresses.Size = new System.Drawing.Size(110, 16);
            this.lblAdresses.TabIndex = 5;
            this.lblAdresses.Text = "Dosya Konumu";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(135, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Contact Me";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(345, 49);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPause.Location = new System.Drawing.Point(0, 186);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(120, 23);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Duraklat";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.Location = new System.Drawing.Point(229, 186);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(119, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Durdur";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // volUp
            // 
            this.volUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.volUp.Location = new System.Drawing.Point(0, 215);
            this.volUp.Name = "volUp";
            this.volUp.Size = new System.Drawing.Size(120, 23);
            this.volUp.TabIndex = 9;
            this.volUp.Text = "Ses Arttır";
            this.volUp.UseVisualStyleBackColor = true;
            this.volUp.Click += new System.EventHandler(this.volUp_Click);
            // 
            // volDown
            // 
            this.volDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.volDown.Location = new System.Drawing.Point(230, 215);
            this.volDown.Name = "volDown";
            this.volDown.Size = new System.Drawing.Size(120, 23);
            this.volDown.TabIndex = 10;
            this.volDown.Text = "Ses Azalt";
            this.volDown.UseVisualStyleBackColor = true;
            this.volDown.Click += new System.EventHandler(this.volDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(357, 253);
            this.Controls.Add(this.volDown);
            this.Controls.Add(this.volUp);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lbxAdresses);
            this.Controls.Add(this.lblAdresses);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbxSongs);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "MP3 Player";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.ListBox lbxSongs;
        private System.Windows.Forms.ListBox lbxAdresses;
        private System.Windows.Forms.Label lblAdresses;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button volUp;
        private System.Windows.Forms.Button volDown;
    }
}

