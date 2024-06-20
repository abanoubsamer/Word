namespace Word
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            ptext = new Panel();
            text = new RichTextBox();
            cb = new ComboBox();
            label1 = new Label();
            size = new NumericUpDown();
            label2 = new Label();
            Bold = new CheckBox();
            Underline = new CheckBox();
            Italic = new CheckBox();
            green = new Panel();
            yellow = new Panel();
            orange = new Panel();
            black = new Panel();
            coral = new Panel();
            silver = new Panel();
            gray = new Panel();
            white = new Panel();
            teal = new Panel();
            tan = new Panel();
            gold = new Panel();
            red = new Panel();
            violet = new Panel();
            darkblue = new Panel();
            cyan = new Panel();
            lime = new Panel();
            More_Color = new Button();
            pictureBox1 = new PictureBox();
            chtext = new RadioButton();
            chback = new RadioButton();
            ptext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ptext
            // 
            ptext.BorderStyle = BorderStyle.FixedSingle;
            ptext.Controls.Add(text);
            ptext.Location = new Point(15, 201);
            ptext.Margin = new Padding(6);
            ptext.Name = "ptext";
            ptext.Size = new Size(1373, 375);
            ptext.TabIndex = 0;
            // 
            // text
            // 
            text.Dock = DockStyle.Fill;
            text.Location = new Point(0, 0);
            text.Margin = new Padding(6);
            text.Name = "text";
            text.Size = new Size(1371, 373);
            text.TabIndex = 0;
            text.Text = resources.GetString("text.Text");
            // 
            // cb
            // 
            cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb.FormattingEnabled = true;
            cb.Location = new Point(11, 65);
            cb.Name = "cb";
            cb.Size = new Size(556, 45);
            cb.TabIndex = 1;
            cb.SelectedIndexChanged += cb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(181, 38);
            label1.TabIndex = 2;
            label1.Text = "Famly Name";
            label1.Click += label1_Click;
            // 
            // size
            // 
            size.Location = new Point(873, 106);
            size.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            size.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            size.Name = "size";
            size.Size = new Size(189, 43);
            size.TabIndex = 3;
            size.TextAlign = HorizontalAlignment.Center;
            size.Value = new decimal(new int[] { 14, 0, 0, 0 });
            size.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(775, 108);
            label2.Name = "label2";
            label2.Size = new Size(69, 38);
            label2.TabIndex = 4;
            label2.Text = "Size";
            label2.Click += label2_Click;
            // 
            // Bold
            // 
            Bold.AutoSize = true;
            Bold.Location = new Point(765, 58);
            Bold.Name = "Bold";
            Bold.Size = new Size(99, 42);
            Bold.TabIndex = 5;
            Bold.Text = "Bold";
            Bold.UseVisualStyleBackColor = true;
            Bold.CheckedChanged += Bold_CheckedChanged;
            // 
            // Underline
            // 
            Underline.AutoSize = true;
            Underline.Font = new Font("Segoe UI", 16.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Underline.Location = new Point(765, 10);
            Underline.Name = "Underline";
            Underline.Size = new Size(174, 42);
            Underline.TabIndex = 6;
            Underline.Text = "Under LIne";
            Underline.UseVisualStyleBackColor = true;
            Underline.CheckedChanged += Underline_CheckedChanged;
            // 
            // Italic
            // 
            Italic.AutoSize = true;
            Italic.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Italic.Location = new Point(870, 58);
            Italic.Name = "Italic";
            Italic.Size = new Size(96, 42);
            Italic.TabIndex = 7;
            Italic.Text = "Italic";
            Italic.UseVisualStyleBackColor = true;
            Italic.CheckedChanged += Italic_CheckedChanged;
            // 
            // green
            // 
            green.BackColor = Color.Green;
            green.BorderStyle = BorderStyle.FixedSingle;
            green.Location = new Point(1091, 105);
            green.Name = "green";
            green.Size = new Size(25, 25);
            green.TabIndex = 24;
            green.Click += black_Click;
            // 
            // yellow
            // 
            yellow.BackColor = Color.Yellow;
            yellow.BorderStyle = BorderStyle.FixedSingle;
            yellow.Location = new Point(1091, 76);
            yellow.Name = "yellow";
            yellow.Size = new Size(25, 25);
            yellow.TabIndex = 23;
            yellow.Click += black_Click;
            // 
            // orange
            // 
            orange.BackColor = Color.Orange;
            orange.BorderStyle = BorderStyle.FixedSingle;
            orange.Location = new Point(1091, 45);
            orange.Name = "orange";
            orange.Size = new Size(25, 25);
            orange.TabIndex = 22;
            orange.Click += black_Click;
            // 
            // black
            // 
            black.BackColor = Color.Black;
            black.BorderStyle = BorderStyle.FixedSingle;
            black.Location = new Point(1091, 14);
            black.Name = "black";
            black.Size = new Size(25, 25);
            black.TabIndex = 21;
            black.Click += black_Click;
            // 
            // coral
            // 
            coral.BackColor = Color.Coral;
            coral.BorderStyle = BorderStyle.FixedSingle;
            coral.Location = new Point(1184, 105);
            coral.Name = "coral";
            coral.Size = new Size(25, 25);
            coral.TabIndex = 20;
            coral.Click += black_Click;
            // 
            // silver
            // 
            silver.BackColor = Color.Silver;
            silver.BorderStyle = BorderStyle.FixedSingle;
            silver.Location = new Point(1184, 76);
            silver.Name = "silver";
            silver.Size = new Size(25, 25);
            silver.TabIndex = 19;
            silver.Click += black_Click;
            // 
            // gray
            // 
            gray.BackColor = Color.Gray;
            gray.BorderStyle = BorderStyle.FixedSingle;
            gray.Location = new Point(1184, 45);
            gray.Name = "gray";
            gray.Size = new Size(25, 25);
            gray.TabIndex = 18;
            gray.Click += black_Click;
            // 
            // white
            // 
            white.BackColor = Color.White;
            white.BorderStyle = BorderStyle.FixedSingle;
            white.Location = new Point(1184, 14);
            white.Name = "white";
            white.Size = new Size(25, 25);
            white.TabIndex = 17;
            white.Click += black_Click;
            // 
            // teal
            // 
            teal.BackColor = Color.Teal;
            teal.BorderStyle = BorderStyle.FixedSingle;
            teal.Location = new Point(1138, 105);
            teal.Name = "teal";
            teal.Size = new Size(25, 25);
            teal.TabIndex = 16;
            teal.Click += black_Click;
            // 
            // tan
            // 
            tan.BackColor = Color.Tan;
            tan.BorderStyle = BorderStyle.FixedSingle;
            tan.Location = new Point(1138, 76);
            tan.Name = "tan";
            tan.Size = new Size(25, 25);
            tan.TabIndex = 15;
            tan.Click += black_Click;
            // 
            // gold
            // 
            gold.BackColor = Color.Gold;
            gold.BorderStyle = BorderStyle.FixedSingle;
            gold.Location = new Point(1138, 45);
            gold.Name = "gold";
            gold.Size = new Size(25, 25);
            gold.TabIndex = 14;
            gold.Click += black_Click;
            // 
            // red
            // 
            red.BackColor = Color.Red;
            red.BorderStyle = BorderStyle.FixedSingle;
            red.Location = new Point(1138, 14);
            red.Name = "red";
            red.Size = new Size(25, 25);
            red.TabIndex = 13;
            red.Click += black_Click;
            // 
            // violet
            // 
            violet.BackColor = Color.Violet;
            violet.BorderStyle = BorderStyle.FixedSingle;
            violet.Location = new Point(1226, 105);
            violet.Name = "violet";
            violet.Size = new Size(25, 25);
            violet.TabIndex = 12;
            violet.Click += black_Click;
            // 
            // darkblue
            // 
            darkblue.BackColor = Color.DarkBlue;
            darkblue.BorderStyle = BorderStyle.FixedSingle;
            darkblue.Location = new Point(1226, 76);
            darkblue.Name = "darkblue";
            darkblue.Size = new Size(25, 25);
            darkblue.TabIndex = 11;
            darkblue.Click += black_Click;
            // 
            // cyan
            // 
            cyan.BackColor = Color.Cyan;
            cyan.BorderStyle = BorderStyle.FixedSingle;
            cyan.Location = new Point(1226, 45);
            cyan.Name = "cyan";
            cyan.Size = new Size(25, 25);
            cyan.TabIndex = 10;
            cyan.Click += black_Click;
            // 
            // lime
            // 
            lime.BackColor = Color.Lime;
            lime.BorderStyle = BorderStyle.FixedSingle;
            lime.Location = new Point(1226, 14);
            lime.Name = "lime";
            lime.Size = new Size(25, 25);
            lime.TabIndex = 9;
            lime.Click += black_Click;
            // 
            // More_Color
            // 
            More_Color.Location = new Point(1082, 144);
            More_Color.Name = "More_Color";
            More_Color.Size = new Size(305, 53);
            More_Color.TabIndex = 9;
            More_Color.Text = "More Color";
            More_Color.UseVisualStyleBackColor = true;
            More_Color.Click += More_Color_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.file_type_word_icon_130070;
            pictureBox1.Location = new Point(1266, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // chtext
            // 
            chtext.AutoSize = true;
            chtext.Checked = true;
            chtext.Location = new Point(970, 14);
            chtext.Name = "chtext";
            chtext.Size = new Size(92, 42);
            chtext.TabIndex = 13;
            chtext.TabStop = true;
            chtext.Text = "Text";
            chtext.UseVisualStyleBackColor = true;
            // 
            // chback
            // 
            chback.AutoSize = true;
            chback.Location = new Point(968, 58);
            chback.Name = "chback";
            chback.Size = new Size(100, 42);
            chback.TabIndex = 14;
            chback.Text = "Back";
            chback.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1403, 591);
            Controls.Add(green);
            Controls.Add(chback);
            Controls.Add(yellow);
            Controls.Add(chtext);
            Controls.Add(orange);
            Controls.Add(pictureBox1);
            Controls.Add(black);
            Controls.Add(coral);
            Controls.Add(More_Color);
            Controls.Add(silver);
            Controls.Add(gray);
            Controls.Add(Italic);
            Controls.Add(white);
            Controls.Add(Underline);
            Controls.Add(teal);
            Controls.Add(Bold);
            Controls.Add(tan);
            Controls.Add(label2);
            Controls.Add(gold);
            Controls.Add(size);
            Controls.Add(red);
            Controls.Add(label1);
            Controls.Add(violet);
            Controls.Add(cb);
            Controls.Add(darkblue);
            Controls.Add(ptext);
            Controls.Add(cyan);
            Controls.Add(lime);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App";
            Load += Form1_Load;
            ptext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)size).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ptext;
        private RichTextBox text;
        private ComboBox cb;
        private Label label1;
        private NumericUpDown size;
        private Label label2;
        private CheckBox Bold;
        private CheckBox Underline;
        private CheckBox Italic;
        private Panel green;
        private Panel yellow;
        private Panel orange;
        private Panel black;
        private Panel coral;
        private Panel silver;
        private Panel gray;
        private Panel white;
        private Panel teal;
        private Panel tan;
        private Panel gold;
        private Panel red;
        private Panel violet;
        private Panel darkblue;
        private Panel cyan;
        private Panel lime;
        private Button More_Color;
        private PictureBox pictureBox1;
        private RadioButton chtext;
        private RadioButton chback;
    }
}
