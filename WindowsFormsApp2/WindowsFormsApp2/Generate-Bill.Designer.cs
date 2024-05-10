namespace WindowsFormsApp2
{
    partial class Form1
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
            this.bill_generation_btn = new System.Windows.Forms.Button();
            this.service_number = new System.Windows.Forms.TextBox();
            this.consumer_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bill_generation_btn
            // 
            this.bill_generation_btn.Location = new System.Drawing.Point(298, 253);
            this.bill_generation_btn.Name = "bill_generation_btn";
            this.bill_generation_btn.Size = new System.Drawing.Size(152, 34);
            this.bill_generation_btn.TabIndex = 0;
            this.bill_generation_btn.Text = "Create";
            this.bill_generation_btn.UseVisualStyleBackColor = true;
            this.bill_generation_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // service_number
            // 
            this.service_number.Location = new System.Drawing.Point(283, 83);
            this.service_number.Name = "service_number";
            this.service_number.Size = new System.Drawing.Size(167, 22);
            this.service_number.TabIndex = 1;
            // 
            // consumer_name
            // 
            this.consumer_name.Location = new System.Drawing.Point(283, 161);
            this.consumer_name.Name = "consumer_name";
            this.consumer_name.Size = new System.Drawing.Size(167, 22);
            this.consumer_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Service Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consumer Name";
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(12, 12);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(75, 23);
            this.Back_btn.TabIndex = 5;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consumer_name);
            this.Controls.Add(this.service_number);
            this.Controls.Add(this.bill_generation_btn);
            this.Name = "Form1";
            this.Text = "Generate Bill";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bill_generation_btn;
        private System.Windows.Forms.TextBox service_number;
        private System.Windows.Forms.TextBox consumer_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Back_btn;
    }
}

