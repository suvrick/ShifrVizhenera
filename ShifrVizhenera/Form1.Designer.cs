namespace ShifrVizhenera
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
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            groupBox4 = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 650);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Исходный текст";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(6, 26);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Барнаул - столица Алтая!";
            textBox2.Size = new Size(366, 618);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox_TextChanged;
            textBox2.Validating += textBox1_Validating;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(397, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(401, 650);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Зашифрованный текст";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(6, 26);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "ЛМжшМйцИэжЮищШ_4МЫКШикгь";
            textBox3.Size = new Size(389, 618);
            textBox3.TabIndex = 0;
            textBox3.TextChanged += textBox_TextChanged;
            textBox3.Validating += textBox1_Validating;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(textBox1);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 66);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Кодовое слово";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(6, 26);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ключ";
            textBox1.Size = new Size(764, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox_TextChanged;
            textBox1.Validating += textBox1_Validating;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Enabled = false;
            button1.Location = new Point(396, 865);
            button1.Name = "button1";
            button1.Size = new Size(392, 29);
            button1.TabIndex = 3;
            button1.Text = "Зашифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Enabled = false;
            button2.Location = new Point(12, 865);
            button2.Name = "button2";
            button2.Size = new Size(378, 29);
            button2.TabIndex = 4;
            button2.Text = "Разшифровать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(516, 836);
            label1.Name = "label1";
            label1.Size = new Size(275, 20);
            label1.TabIndex = 5;
            label1.Text = "Текст содержит запрещенный символ";
            label1.Visible = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBox4);
            groupBox4.Controls.Add(checkBox3);
            groupBox4.Controls.Add(checkBox2);
            groupBox4.Controls.Add(checkBox1);
            groupBox4.Location = new Point(13, 85);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(775, 92);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Словари";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(140, 56);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(163, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Знаки препинания";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(140, 26);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(53, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "0-9";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(15, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(53, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "а-я";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(56, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "А-Я";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 903);
            Controls.Add(groupBox4);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximumSize = new Size(819, 950);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private GroupBox groupBox4;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}