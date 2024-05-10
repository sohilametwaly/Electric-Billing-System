namespace WindowsFormsApp2
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            this.name_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.service_number_box = new System.Windows.Forms.TextBox();
            this.phone_box = new System.Windows.Forms.TextBox();
            this.address_box = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.goToLogin_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(313, 34);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(100, 22);
            this.name_box.TabIndex = 0;
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(313, 79);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(100, 22);
            this.id_box.TabIndex = 1;
            // 
            // service_number_box
            // 
            this.service_number_box.Location = new System.Drawing.Point(313, 166);
            this.service_number_box.Name = "service_number_box";
            this.service_number_box.Size = new System.Drawing.Size(100, 22);
            this.service_number_box.TabIndex = 2;
            // 
            // phone_box
            // 
            this.phone_box.Location = new System.Drawing.Point(313, 220);
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(100, 22);
            this.phone_box.TabIndex = 3;
            // 
            // address_box
            // 
            this.address_box.Location = new System.Drawing.Point(313, 278);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(100, 22);
            this.address_box.TabIndex = 4;
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(295, 347);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(139, 37);
            this.register_btn.TabIndex = 5;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Service Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(313, 123);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(100, 22);
            this.password_box.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Already Have An Account?";
            // 
            // goToLogin_btn
            // 
            this.goToLogin_btn.Location = new System.Drawing.Point(383, 404);
            this.goToLogin_btn.Name = "goToLogin_btn";
            this.goToLogin_btn.Size = new System.Drawing.Size(75, 32);
            this.goToLogin_btn.TabIndex = 16;
            this.goToLogin_btn.Text = "Login";
            this.goToLogin_btn.UseVisualStyleBackColor = true;
            this.goToLogin_btn.Click += new System.EventHandler(this.goToLogin_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(12, 12);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(75, 26);
            this.Back_btn.TabIndex = 17;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.goToLogin_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.address_box);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.service_number_box);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.name_box);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.TextBox service_number_box;
        private System.Windows.Forms.TextBox phone_box;
        private System.Windows.Forms.TextBox address_box;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button goToLogin_btn;
        private System.Windows.Forms.Button Back_btn;
    }
}