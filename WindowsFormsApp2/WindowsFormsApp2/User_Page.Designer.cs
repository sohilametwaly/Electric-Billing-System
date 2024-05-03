namespace WindowsFormsApp2
{
    partial class User_Page
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
            this.label1 = new System.Windows.Forms.Label();
            this.add_meters_btn = new System.Windows.Forms.Button();
            this.pay_btn = new System.Windows.Forms.Button();
            this.view_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Page";
            // 
            // add_meters_btn
            // 
            this.add_meters_btn.Location = new System.Drawing.Point(281, 96);
            this.add_meters_btn.Name = "add_meters_btn";
            this.add_meters_btn.Size = new System.Drawing.Size(164, 50);
            this.add_meters_btn.TabIndex = 1;
            this.add_meters_btn.Text = "Add Meters Info";
            this.add_meters_btn.UseVisualStyleBackColor = true;
            this.add_meters_btn.Click += new System.EventHandler(this.add_meters_btn_Click);
            // 
            // pay_btn
            // 
            this.pay_btn.Location = new System.Drawing.Point(281, 172);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(164, 43);
            this.pay_btn.TabIndex = 2;
            this.pay_btn.Text = "Pay Bill";
            this.pay_btn.UseVisualStyleBackColor = true;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // view_btn
            // 
            this.view_btn.Location = new System.Drawing.Point(281, 257);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(164, 46);
            this.view_btn.TabIndex = 3;
            this.view_btn.Text = "View Bill";
            this.view_btn.UseVisualStyleBackColor = true;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // User_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.add_meters_btn);
            this.Controls.Add(this.label1);
            this.Name = "User_Page";
            this.Text = "User_Page";
            this.Load += new System.EventHandler(this.User_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_meters_btn;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.Button view_btn;
    }
}