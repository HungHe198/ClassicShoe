﻿namespace ClassicShoe.APP.VIEWS.Hung
{
    partial class AddToOrder
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F);
            label1.Location = new Point(113, 9);
            label1.Name = "label1";
            label1.Size = new Size(376, 46);
            label1.TabIndex = 0;
            label1.Text = "Vui lòng nhập số lượng!";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F);
            textBox1.Location = new Point(113, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 51);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(207, 162);
            button1.Name = "button1";
            button1.Size = new Size(168, 58);
            button1.TabIndex = 2;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddToOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 254);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AddToOrder";
            Text = "AddToOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}