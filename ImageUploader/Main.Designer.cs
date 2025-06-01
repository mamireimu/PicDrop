namespace ImageUploader
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // uploadedUrl
            // 
            uploadedUrl.Font = new Font("Yu Gothic UI", 13F);
            uploadedUrl.Location = new Point(119, 425);
            uploadedUrl.Name = "uploadedUrl";
            uploadedUrl.ReadOnly = true;
            uploadedUrl.Size = new Size(235, 31);
            uploadedUrl.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F);
            label1.Location = new Point(7, 429);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 1;
            label1.Text = "アップロードURL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 13F, FontStyle.Bold);
            label2.Location = new Point(7, 9);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 2;
            label2.Text = "プレビュー";
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 12F);
            button1.Location = new Point(12, 252);
            button1.Name = "button1";
            button1.Size = new Size(424, 46);
            button1.TabIndex = 3;
            button1.Text = "クリップボード";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F);
            label3.Location = new Point(12, 328);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 6;
            label3.Text = "エンドポイント";
            // 
            // endpointBox
            // 
            endpointBox.Font = new Font("Yu Gothic UI", 13F);
            endpointBox.Location = new Point(119, 324);
            endpointBox.Name = "endpointBox";
            endpointBox.Size = new Size(317, 31);
            endpointBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F);
            label4.Location = new Point(49, 372);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 8;
            label4.Text = "APIキー";
            // 
            // apiKeyBox
            // 
            apiKeyBox.Font = new Font("Yu Gothic UI", 13F);
            apiKeyBox.Location = new Point(119, 368);
            apiKeyBox.Name = "apiKeyBox";
            apiKeyBox.PasswordChar = '*';
            apiKeyBox.Size = new Size(317, 31);
            apiKeyBox.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(360, 427);
            button2.Name = "button2";
            button2.Size = new Size(84, 28);
            button2.TabIndex = 9;
            button2.Text = "コピー";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // Main
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 469);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "画像アップローダー";
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
