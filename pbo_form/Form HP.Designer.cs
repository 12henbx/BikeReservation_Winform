namespace pbo_form
{
    partial class Form_HP
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
            this.tampilBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(122, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 137);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Code!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tampilBox
            // 
            this.tampilBox.Location = new System.Drawing.Point(27, 123);
            this.tampilBox.Name = "tampilBox";
            this.tampilBox.ReadOnly = true;
            this.tampilBox.Size = new System.Drawing.Size(428, 26);
            this.tampilBox.TabIndex = 1;
            // 
            // Form_HP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 507);
            this.Controls.Add(this.tampilBox);
            this.Controls.Add(this.button1);
            this.Name = "Form_HP";
            this.Text = "Form_HP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tampilBox;
    }
}