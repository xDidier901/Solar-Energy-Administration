namespace Solar_Energy_Administration
{
    partial class Introduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Introduction));
            this.btnData = new System.Windows.Forms.Button();
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.White;
            this.btnData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnData.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.Location = new System.Drawing.Point(302, 460);
            this.btnData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(175, 82);
            this.btnData.TabIndex = 2;
            this.btnData.Text = "Next";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            this.btnData.MouseEnter += new System.EventHandler(this.btnData_MouseEnter);
            this.btnData.MouseLeave += new System.EventHandler(this.btnData_MouseLeave);
            // 
            // videoPlayer
            // 
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(12, 69);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(550, 294);
            this.videoPlayer.TabIndex = 3;
            this.videoPlayer.StatusChange += new System.EventHandler(this.videoPlayer_StatusChange);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(111, 18);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(527, 48);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "How do solar panels work?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Solar_Energy_Administration.Properties.Resources.fondoIntroduction;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.videoPlayer);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Introduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introduction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Introduction_FormClosing);
            this.Load += new System.EventHandler(this.Introduction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnData;
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private System.Windows.Forms.Label labelTitulo;
    }
}