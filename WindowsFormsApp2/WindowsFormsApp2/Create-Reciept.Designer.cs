namespace WindowsFormsApp2
{
    partial class Form3
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
            this.service_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.consumer_name = new System.Windows.Forms.TextBox();
            this.create_btn = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Number";
            // 
            // service_no
            // 
            this.service_no.Location = new System.Drawing.Point(286, 53);
            this.service_no.Name = "service_no";
            this.service_no.Size = new System.Drawing.Size(100, 22);
            this.service_no.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consumer name";
            // 
            // consumer_name
            // 
            this.consumer_name.Location = new System.Drawing.Point(286, 118);
            this.consumer_name.Name = "consumer_name";
            this.consumer_name.Size = new System.Drawing.Size(100, 22);
            this.consumer_name.TabIndex = 4;
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(277, 264);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(119, 28);
            this.create_btn.TabIndex = 5;
            this.create_btn.Text = "Create";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(286, 180);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 22);
            this.price.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Meter Price";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.consumer_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.service_no);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Create Reciept";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox service_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox consumer_name;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label3;
    }
}