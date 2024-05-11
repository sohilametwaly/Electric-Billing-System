namespace WindowsFormsApp2
{
    partial class Form2
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
            this.search_btn = new System.Windows.Forms.Button();
            this.bill_btn = new System.Windows.Forms.Button();
            this.reciept_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Page";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(267, 85);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(156, 36);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search For Customer";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // bill_btn
            // 
            this.bill_btn.Location = new System.Drawing.Point(267, 157);
            this.bill_btn.Name = "bill_btn";
            this.bill_btn.Size = new System.Drawing.Size(156, 34);
            this.bill_btn.TabIndex = 2;
            this.bill_btn.Text = "Generate Bill";
            this.bill_btn.UseVisualStyleBackColor = true;
            this.bill_btn.Click += new System.EventHandler(this.bill_btn_Click);
            // 
            // reciept_btn
            // 
            this.reciept_btn.Location = new System.Drawing.Point(267, 235);
            this.reciept_btn.Name = "reciept_btn";
            this.reciept_btn.Size = new System.Drawing.Size(156, 30);
            this.reciept_btn.TabIndex = 3;
            this.reciept_btn.Text = "Create Reciept";
            this.reciept_btn.UseVisualStyleBackColor = true;
            this.reciept_btn.Click += new System.EventHandler(this.reciept_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Users Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "User Bills";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reciept_btn);
            this.Controls.Add(this.bill_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Admin Page";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button bill_btn;
        private System.Windows.Forms.Button reciept_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}