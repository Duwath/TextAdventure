namespace AdventureGame
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
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Black", 33F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(229, 9);
            label1.Name = "label1";
            label1.Size = new Size(369, 53);
            label1.TabIndex = 0;
            label1.Text = "Curse of the Hills";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(51, 79);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(681, 124);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(428, 233);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(304, 96);
            richTextBox3.TabIndex = 7;
            richTextBox3.Text = "";
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(428, 342);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(304, 96);
            richTextBox6.TabIndex = 10;
            richTextBox6.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(51, 342);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(304, 96);
            richTextBox4.TabIndex = 11;
            richTextBox4.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(51, 233);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(304, 96);
            richTextBox2.TabIndex = 12;
            richTextBox2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fog_5137477_1280;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox6);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox2;
    }
}