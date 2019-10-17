namespace pbo_form
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
            this.sambut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outKunci = new System.Windows.Forms.TextBox();
            this.datangBox = new System.Windows.Forms.TextBox();
            this.inputBtn = new System.Windows.Forms.Button();
            this.datangButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // sambut
            // 
            this.sambut.AutoSize = true;
            this.sambut.Location = new System.Drawing.Point(12, 9);
            this.sambut.Name = "sambut";
            this.sambut.Size = new System.Drawing.Size(142, 20);
            this.sambut.TabIndex = 0;
            this.sambut.Text = "Selamat datang di ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nomor Kunci :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masukan kode :";
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputBox.Location = new System.Drawing.Point(196, 54);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(168, 35);
            this.inputBox.TabIndex = 3;
            // 
            // outKunci
            // 
            this.outKunci.Location = new System.Drawing.Point(196, 112);
            this.outKunci.Name = "outKunci";
            this.outKunci.ReadOnly = true;
            this.outKunci.Size = new System.Drawing.Size(100, 26);
            this.outKunci.TabIndex = 4;
            // 
            // datangBox
            // 
            this.datangBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datangBox.Location = new System.Drawing.Point(183, 331);
            this.datangBox.Name = "datangBox";
            this.datangBox.Size = new System.Drawing.Size(148, 35);
            this.datangBox.TabIndex = 5;
            // 
            // inputBtn
            // 
            this.inputBtn.Location = new System.Drawing.Point(70, 171);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(105, 54);
            this.inputBtn.TabIndex = 6;
            this.inputBtn.Text = "Generate";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
            // 
            // datangButton
            // 
            this.datangButton.Location = new System.Drawing.Point(70, 395);
            this.datangButton.Name = "datangButton";
            this.datangButton.Size = new System.Drawing.Size(108, 43);
            this.datangButton.TabIndex = 7;
            this.datangButton.Text = "button2";
            this.datangButton.UseVisualStyleBackColor = true;
            this.datangButton.Click += new System.EventHandler(this.datangButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Masukan Kode Acak :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pengembalian Kunci";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(441, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "================================================";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(433, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(355, 426);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No Kunci";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datangButton);
            this.Controls.Add(this.inputBtn);
            this.Controls.Add(this.datangBox);
            this.Controls.Add(this.outKunci);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sambut);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sambut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outKunci;
        private System.Windows.Forms.TextBox datangBox;
        private System.Windows.Forms.Button inputBtn;
        private System.Windows.Forms.Button datangButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}