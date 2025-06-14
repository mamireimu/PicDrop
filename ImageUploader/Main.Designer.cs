namespace PicDrop
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            uploadedUrl = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            endpointBox = new TextBox();
            label4 = new Label();
            apiKeyBox = new TextBox();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            公式サイトToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // uploadedUrl
            // 
            uploadedUrl.Font = new Font("Yu Gothic UI", 13F);
            uploadedUrl.Location = new Point(119, 449);
            uploadedUrl.Name = "uploadedUrl";
            uploadedUrl.ReadOnly = true;
            uploadedUrl.Size = new Size(235, 31);
            uploadedUrl.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F);
            label1.Location = new Point(7, 453);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 1;
            label1.Text = "アップロードURL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 13F, FontStyle.Bold);
            label2.Location = new Point(7, 33);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 2;
            label2.Text = "プレビュー";
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 12F);
            button1.Location = new Point(12, 276);
            button1.Name = "button1";
            button1.Size = new Size(424, 46);
            button1.TabIndex = 3;
            button1.Text = "クリップボード";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(12, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F);
            label3.Location = new Point(12, 352);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 6;
            label3.Text = "エンドポイント";
            // 
            // endpointBox
            // 
            endpointBox.Font = new Font("Yu Gothic UI", 13F);
            endpointBox.Location = new Point(119, 348);
            endpointBox.Name = "endpointBox";
            endpointBox.Size = new Size(317, 31);
            endpointBox.TabIndex = 5;
            endpointBox.Text = "https://piba.mamisrv.net";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F);
            label4.Location = new Point(49, 396);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 8;
            label4.Text = "APIキー";
            // 
            // apiKeyBox
            // 
            apiKeyBox.Font = new Font("Yu Gothic UI", 13F);
            apiKeyBox.Location = new Point(119, 392);
            apiKeyBox.Name = "apiKeyBox";
            apiKeyBox.PasswordChar = '*';
            apiKeyBox.Size = new Size(317, 31);
            apiKeyBox.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(360, 451);
            button2.Name = "button2";
            button2.Size = new Size(84, 28);
            button2.TabIndex = 9;
            button2.Text = "コピー";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;


            // 
            // menuStrip1
            // 
            menuStrip1 = new MenuStrip();
            menuStrip1.Dock = DockStyle.Top;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(448, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Items.AddRange(new ToolStripItem[] {
                new ToolStripMenuItem("PicBasket公式ページ", null, (_, __) => OpenUrl("https://vrc.mamisrv.net/piba")),
                new ToolStripMenuItem("PicBasket FANBOX", null, (_, __) => OpenUrl("https://mamireimu.fanbox.cc/")),
                new ToolStripMenuItem("体験版 APIキー取得", null, (_, __) => OpenUrl("https://vrc.mamisrv.net/piba_trial_redirect.html")),
                new ToolStripMenuItem("ライセンス", null, (_, __) => OpenUrl("https://github.com/mamireimu/PicDrop/blob/picbasket-dev/LICENSE.txt"))
            });
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;


            // 
            // Main
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 493);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(apiKeyBox);
            Controls.Add(label3);
            Controls.Add(endpointBox);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(uploadedUrl);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PicDrop v{version} PicBasket.Edition";
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox uploadedUrl;
        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox endpointBox;
        private Label label4;
        private TextBox apiKeyBox;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 公式サイトToolStripMenuItem;
    }
}
