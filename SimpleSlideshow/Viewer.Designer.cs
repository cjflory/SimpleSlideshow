namespace SimpleSlideshow
{
    partial class Viewer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.playPauseButton = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.PictureBox();
            this.prevButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playPauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.playPauseButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.prevButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 262);
            this.panel1.TabIndex = 0;
            // 
            // playPauseButton
            // 
            this.playPauseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playPauseButton.BackColor = System.Drawing.Color.Transparent;
            this.playPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playPauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playPauseButton.Image = global::SimpleSlideshow.Properties.Resources.PauseButton;
            this.playPauseButton.Location = new System.Drawing.Point(123, 218);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(32, 32);
            this.playPauseButton.TabIndex = 5;
            this.playPauseButton.TabStop = false;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Image = global::SimpleSlideshow.Properties.Resources.NextArrow;
            this.nextButton.Location = new System.Drawing.Point(161, 218);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(32, 32);
            this.nextButton.TabIndex = 4;
            this.nextButton.TabStop = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prevButton.BackColor = System.Drawing.Color.Transparent;
            this.prevButton.BackgroundImage = global::SimpleSlideshow.Properties.Resources.PrevArrow;
            this.prevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.prevButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevButton.Location = new System.Drawing.Point(85, 218);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(32, 32);
            this.prevButton.TabIndex = 3;
            this.prevButton.TabStop = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::SimpleSlideshow.Properties.Resources.CloseButton;
            this.closeButton.Location = new System.Drawing.Point(240, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = global::SimpleSlideshow.Properties.Resources.ajax_loader;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panel1);
            this.Name = "Viewer";
            this.Text = "Viewer";
            this.Load += new System.EventHandler(this.Viewer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Viewer_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playPauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox nextButton;
        private System.Windows.Forms.PictureBox prevButton;
        private System.Windows.Forms.PictureBox playPauseButton;


    }
}