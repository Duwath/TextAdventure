﻿namespace AdventureGame
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
            rtb0 = new RichTextBox();
            rtb2 = new RichTextBox();
            rtb4 = new RichTextBox();
            rtb3 = new RichTextBox();
            rtb1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 33F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(229, 9);
            label1.Name = "label1";
            label1.Size = new Size(355, 52);
            label1.TabIndex = 0;
            label1.Text = "Curse of the Hills";
            // 
            // rtb0
            // 
            rtb0.Location = new Point(51, 79);
            rtb0.Name = "rtb0";
            rtb0.Size = new Size(681, 124);
            rtb0.TabIndex = 5;
            rtb0.Text = "";
            // 
            // rtb2
            // 
            rtb2.Location = new Point(428, 233);
            rtb2.Name = "rtb2";
            rtb2.Size = new Size(304, 96);
            rtb2.TabIndex = 7;
            rtb2.Text = "";
            rtb2.Click += OnClick2;
            // 
            // rtb4
            // 
            rtb4.Location = new Point(428, 342);
            rtb4.Name = "rtb4";
            rtb4.Size = new Size(304, 96);
            rtb4.TabIndex = 10;
            rtb4.Text = "";
            rtb4.Click += OnClick4;
            // 
            // rtb3
            // 
            rtb3.Location = new Point(51, 342);
            rtb3.Name = "rtb3";
            rtb3.Size = new Size(304, 96);
            rtb3.TabIndex = 11;
            rtb3.Text = "";
            rtb3.Click += OnClick3;
            // 
            // rtb1
            // 
            rtb1.Location = new Point(51, 233);
            rtb1.Name = "rtb1";
            rtb1.Size = new Size(304, 96);
            rtb1.TabIndex = 12;
            rtb1.Text = "";
            rtb1.Click += OnClick1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fog_5137477_1280;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb1);
            Controls.Add(rtb3);
            Controls.Add(rtb4);
            Controls.Add(rtb2);
            Controls.Add(rtb0);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtb0;
        private RichTextBox rtb2;
        private RichTextBox rtb4;
        private RichTextBox rtb3;
        private RichTextBox rtb1;
    }
}