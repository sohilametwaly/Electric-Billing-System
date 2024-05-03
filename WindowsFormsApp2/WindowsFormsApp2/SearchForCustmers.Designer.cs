namespace WindowsFormsApp2
{
    partial class SearchForCustmers
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
            this.id_comboBox = new System.Windows.Forms.ComboBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.address_box = new System.Windows.Forms.TextBox();
            this.service_box = new System.Windows.Forms.TextBox();
            this.phone_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_comboBox
            // 
            this.id_comboBox.FormattingEnabled = true;
            this.id_comboBox.Location = new System.Drawing.Point(214, 73);
            this.id_comboBox.Name = "id_comboBox";
            this.id_comboBox.Size = new System.Drawing.Size(121, 24);
            this.id_comboBox.TabIndex = 0;
            this.id_comboBox.SelectedIndexChanged += new System.EventHandler(this.id_comboBox_SelectedIndexChanged);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(258, 166);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(155, 22);
            this.name_box.TabIndex = 1;
            // 
            // address_box
            // 
            this.address_box.Location = new System.Drawing.Point(258, 214);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(155, 22);
            this.address_box.TabIndex = 2;
            // 
            // service_box
            // 
            this.service_box.Location = new System.Drawing.Point(258, 275);
            this.service_box.Name = "service_box";
            this.service_box.Size = new System.Drawing.Size(155, 22);
            this.service_box.TabIndex = 3;
            // 
            // phone_box
            // 
            this.phone_box.Location = new System.Drawing.Point(258, 323);
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(155, 22);
            this.phone_box.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Service Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number";
            // 
            // SearchForCustmers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.service_box);
            this.Controls.Add(this.address_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.id_comboBox);
            this.Name = "SearchForCustmers";
            this.Text = "SearchForCustmers";
            this.Load += new System.EventHandler(this.SearchForCustmers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox id_comboBox;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox address_box;
        private System.Windows.Forms.TextBox service_box;
        private System.Windows.Forms.TextBox phone_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}