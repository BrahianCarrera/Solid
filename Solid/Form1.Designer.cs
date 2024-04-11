namespace Solid
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
            Shapebox = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            resultbox = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // Shapebox
            // 
            Shapebox.FormattingEnabled = true;
            Shapebox.Items.AddRange(new object[] { "Circle", "Rectangle", "Triangle" });
            Shapebox.Location = new Point(56, 133);
            Shapebox.Name = "Shapebox";
            Shapebox.Size = new Size(121, 23);
            Shapebox.TabIndex = 0;
            Shapebox.SelectedIndexChanged += Shapebox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(645, 105);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 102);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Shape";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(419, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 4;
            // 
            // resultbox
            // 
            resultbox.Location = new Point(579, 134);
            resultbox.Name = "resultbox";
            resultbox.ReadOnly = true;
            resultbox.Size = new Size(200, 23);
            resultbox.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(320, 283);
            button2.Name = "button2";
            button2.Size = new Size(157, 23);
            button2.TabIndex = 8;
            button2.Text = "Calculate Total Area";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(resultbox);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Shapebox);
            Name = "Form1";
            Text = "Area Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Shapebox;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox resultbox;
        private Button button2;
    }
}
