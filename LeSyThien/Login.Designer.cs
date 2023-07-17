namespace LeSyThien
{
    partial class Login
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
            label2 = new Label();
            tbName = new TextBox();
            tbPass = new TextBox();
            btLogin = new Button();
            btCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 68);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 139);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "PassWord";
            // 
            // tbName
            // 
            tbName.Location = new Point(272, 68);
            tbName.Name = "tbName";
            tbName.Size = new Size(214, 31);
            tbName.TabIndex = 2;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(272, 139);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(214, 31);
            tbPass.TabIndex = 2;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(205, 280);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(111, 34);
            btLogin.TabIndex = 3;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(416, 280);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(111, 34);
            btCancel.TabIndex = 3;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 401);
            Controls.Add(btCancel);
            Controls.Add(btLogin);
            Controls.Add(tbPass);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private TextBox tbPass;
        private Button btLogin;
        private Button btCancel;
    }
}