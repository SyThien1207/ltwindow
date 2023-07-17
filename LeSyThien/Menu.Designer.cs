namespace Window
{
    partial class FormMenu
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
            button1 = new Button();
            btCencel = new Button();
            button2 = new Button();
            Article2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(110, 46);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(85, 41);
            button1.TabIndex = 0;
            button1.Text = "Article0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btCencel
            // 
            btCencel.Location = new Point(410, 226);
            btCencel.Margin = new Padding(2, 2, 2, 2);
            btCencel.Name = "btCencel";
            btCencel.Size = new Size(78, 20);
            btCencel.TabIndex = 0;
            btCencel.Text = "Cancel";
            btCencel.UseVisualStyleBackColor = true;
            btCencel.Click += btCencel_Click;
            // 
            // button2
            // 
            button2.Location = new Point(217, 46);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(85, 41);
            button2.TabIndex = 0;
            button2.Text = "Article1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Article2
            // 
            Article2.Location = new Point(343, 46);
            Article2.Margin = new Padding(2, 2, 2, 2);
            Article2.Name = "Article2";
            Article2.Size = new Size(85, 41);
            Article2.TabIndex = 0;
            Article2.Text = "Article2";
            Article2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(110, 106);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(85, 41);
            button4.TabIndex = 0;
            button4.Text = "Article1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(343, 106);
            button5.Margin = new Padding(2, 2, 2, 2);
            button5.Name = "button5";
            button5.Size = new Size(85, 41);
            button5.TabIndex = 0;
            button5.Text = "Article1";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(217, 106);
            button6.Margin = new Padding(2, 2, 2, 2);
            button6.Name = "button6";
            button6.Size = new Size(85, 41);
            button6.TabIndex = 0;
            button6.Text = "Article1";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button4_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btCencel);
            Controls.Add(button5);
            Controls.Add(Article2);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormMenu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btCencel;
        private Button button2;
        private Button Article2;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}