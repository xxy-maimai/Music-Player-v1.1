namespace MusicPlayer
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            label1 = new Label();
            trackBar1 = new TrackBar();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            button5 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(button1, 3, 4);
            tableLayoutPanel1.Controls.Add(button2, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(trackBar1, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 2, 3);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(listBox1, 3, 0);
            tableLayoutPanel1.Controls.Add(button5, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(778, 584);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("等线", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(585, 467);
            button1.Name = "button1";
            button1.Size = new Size(190, 114);
            button1.TabIndex = 0;
            button1.Text = "添加音乐";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.Font = new Font("等线", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.Location = new Point(3, 366);
            button2.Name = "button2";
            button2.Size = new Size(80, 80);
            button2.TabIndex = 1;
            button2.Text = "播放";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button4, 1, 0);
            tableLayoutPanel2.Controls.Add(button3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(197, 351);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(188, 110);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("等线", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button4.Location = new Point(97, 3);
            button4.Name = "button4";
            button4.Size = new Size(88, 104);
            button4.TabIndex = 1;
            button4.Text = "下一首";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("等线", 10F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(88, 104);
            button3.TabIndex = 0;
            button3.Text = "上一首";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Font = new Font("等线", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(3, 41);
            label1.Name = "label1";
            label1.Size = new Size(175, 33);
            label1.TabIndex = 3;
            label1.Text = "正在播放：";
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(trackBar1, 3);
            trackBar1.Location = new Point(3, 489);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(576, 69);
            trackBar1.TabIndex = 4;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.MouseUp += trackBar1_MouseUp;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(391, 392);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 119);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel1.SetRowSpan(pictureBox1, 2);
            pictureBox1.Size = new Size(382, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(224, 224, 224);
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("等线", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(585, 3);
            listBox1.Name = "listBox1";
            tableLayoutPanel1.SetRowSpan(listBox1, 4);
            listBox1.Size = new Size(190, 458);
            listBox1.TabIndex = 7;
            listBox1.MouseClick += listBox1_MouseClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "音频文件 (*.mp3)|*.mp3";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("等线", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button5.Location = new Point(391, 3);
            button5.Name = "button5";
            button5.Size = new Size(188, 110);
            button5.TabIndex = 8;
            button5.Text = "设置";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(778, 584);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "音乐播放器";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button4;
        private Button button3;
        private Label label1;
        private TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button button5;
    }
}
