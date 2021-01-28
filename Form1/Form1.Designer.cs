namespace Form1
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
            this.listBoxOutPut = new System.Windows.Forms.ListBox();
            this.malebuttom = new System.Windows.Forms.RadioButton();
            this.femalebuttom = new System.Windows.Forms.RadioButton();
            this.SortButtom = new System.Windows.Forms.Button();
            this.MergeButtom = new System.Windows.Forms.Button();
            this.RemoveButtom = new System.Windows.Forms.Button();
            this.Addbuttom = new System.Windows.Forms.Button();
            this.firstnametextbox = new System.Windows.Forms.TextBox();
            this.lastnametextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxOutPut
            // 
            this.listBoxOutPut.FormattingEnabled = true;
            this.listBoxOutPut.Location = new System.Drawing.Point(3, 19);
            this.listBoxOutPut.Name = "listBoxOutPut";
            this.listBoxOutPut.Size = new System.Drawing.Size(268, 108);
            this.listBoxOutPut.TabIndex = 0;
            // 
            // malebuttom
            // 
            this.malebuttom.AutoSize = true;
            this.malebuttom.Location = new System.Drawing.Point(11, 64);
            this.malebuttom.Name = "malebuttom";
            this.malebuttom.Size = new System.Drawing.Size(48, 17);
            this.malebuttom.TabIndex = 5;
            this.malebuttom.TabStop = true;
            this.malebuttom.Text = "Male";
            this.malebuttom.UseVisualStyleBackColor = true;
            // 
            // femalebuttom
            // 
            this.femalebuttom.AutoSize = true;
            this.femalebuttom.Location = new System.Drawing.Point(11, 87);
            this.femalebuttom.Name = "femalebuttom";
            this.femalebuttom.Size = new System.Drawing.Size(59, 17);
            this.femalebuttom.TabIndex = 6;
            this.femalebuttom.TabStop = true;
            this.femalebuttom.Text = "Female";
            this.femalebuttom.UseVisualStyleBackColor = true;
            // 
            // SortButtom
            // 
            this.SortButtom.Location = new System.Drawing.Point(11, 133);
            this.SortButtom.Name = "SortButtom";
            this.SortButtom.Size = new System.Drawing.Size(75, 23);
            this.SortButtom.TabIndex = 7;
            this.SortButtom.Text = "Sort";
            this.SortButtom.UseVisualStyleBackColor = true;
            this.SortButtom.Click += new System.EventHandler(this.SortButtom_Click);
            // 
            // MergeButtom
            // 
            this.MergeButtom.Location = new System.Drawing.Point(101, 135);
            this.MergeButtom.Name = "MergeButtom";
            this.MergeButtom.Size = new System.Drawing.Size(69, 21);
            this.MergeButtom.TabIndex = 8;
            this.MergeButtom.Text = "Merge";
            this.MergeButtom.UseVisualStyleBackColor = true;
            this.MergeButtom.Click += new System.EventHandler(this.MergeButtom_Click);
            // 
            // RemoveButtom
            // 
            this.RemoveButtom.Location = new System.Drawing.Point(188, 133);
            this.RemoveButtom.Name = "RemoveButtom";
            this.RemoveButtom.Size = new System.Drawing.Size(61, 21);
            this.RemoveButtom.TabIndex = 9;
            this.RemoveButtom.Text = "Remove";
            this.RemoveButtom.UseVisualStyleBackColor = true;
            this.RemoveButtom.Click += new System.EventHandler(this.RemoveButtom_Click);
            // 
            // Addbuttom
            // 
            this.Addbuttom.Location = new System.Drawing.Point(165, 61);
            this.Addbuttom.Name = "Addbuttom";
            this.Addbuttom.Size = new System.Drawing.Size(75, 23);
            this.Addbuttom.TabIndex = 10;
            this.Addbuttom.Text = "Add";
            this.Addbuttom.UseVisualStyleBackColor = true;
            this.Addbuttom.Click += new System.EventHandler(this.Addbuttom_Click);
            // 
            // firstnametextbox
            // 
            this.firstnametextbox.Location = new System.Drawing.Point(11, 32);
            this.firstnametextbox.Name = "firstnametextbox";
            this.firstnametextbox.Size = new System.Drawing.Size(100, 20);
            this.firstnametextbox.TabIndex = 11;
           
            // 
            // lastnametextbox
            // 
            this.lastnametextbox.Location = new System.Drawing.Point(140, 32);
            this.lastnametextbox.Name = "lastnametextbox";
            this.lastnametextbox.Size = new System.Drawing.Size(100, 20);
            this.lastnametextbox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lastnametextbox);
            this.groupBox1.Controls.Add(this.firstnametextbox);
            this.groupBox1.Controls.Add(this.Addbuttom);
            this.groupBox1.Controls.Add(this.femalebuttom);
            this.groupBox1.Controls.Add(this.malebuttom);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 110);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New person";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxOutPut);
            this.groupBox2.Controls.Add(this.SortButtom);
            this.groupBox2.Controls.Add(this.RemoveButtom);
            this.groupBox2.Controls.Add(this.MergeButtom);
            this.groupBox2.Location = new System.Drawing.Point(15, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 164);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Persons";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOutPut;
        private System.Windows.Forms.RadioButton malebuttom;
        private System.Windows.Forms.RadioButton femalebuttom;
        private System.Windows.Forms.Button SortButtom;
        private System.Windows.Forms.Button MergeButtom;
        private System.Windows.Forms.Button RemoveButtom;
        private System.Windows.Forms.Button Addbuttom;
        private System.Windows.Forms.TextBox firstnametextbox;
        private System.Windows.Forms.TextBox lastnametextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

