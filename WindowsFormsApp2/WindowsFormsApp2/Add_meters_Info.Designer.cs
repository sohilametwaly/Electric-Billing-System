namespace WindowsFormsApp2
{
    partial class Add_meters_Info
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
            this.button1 = new System.Windows.Forms.Button();
            this.AddMeterInfoButton = new System.Windows.Forms.Button();
            this.metersNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // AddMeterInfoButton
            // 
            this.AddMeterInfoButton.Location = new System.Drawing.Point(318, 320);
            this.AddMeterInfoButton.Name = "AddMeterInfoButton";
            this.AddMeterInfoButton.Size = new System.Drawing.Size(75, 23);
            this.AddMeterInfoButton.TabIndex = 1;
            this.AddMeterInfoButton.Text = "Add";
            this.AddMeterInfoButton.UseVisualStyleBackColor = true;
            this.AddMeterInfoButton.Click += new System.EventHandler(this.AddMeterInfoButton_Click);
            // 
            // metersNumberTextBox
            // 
            this.metersNumberTextBox.Location = new System.Drawing.Point(318, 233);
            this.metersNumberTextBox.Name = "metersNumberTextBox";
            this.metersNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.metersNumberTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Meters";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Add_meters_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metersNumberTextBox);
            this.Controls.Add(this.AddMeterInfoButton);
            this.Controls.Add(this.button1);
            this.Name = "Add_meters_Info";
            this.Text = "Add_meters_Info";
            this.Load += new System.EventHandler(this.Add_meters_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddMeterInfoButton;
        private System.Windows.Forms.TextBox metersNumberTextBox;
        private System.Windows.Forms.Label label1;
    }
}