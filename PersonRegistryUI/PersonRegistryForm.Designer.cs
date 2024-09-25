namespace PersonRegistryUI
{
    partial class PersonRegistryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreatePerson_GroupBox = new GroupBox();
            Add_Button = new Button();
            Female_RadioButton = new RadioButton();
            Male_RadioButton = new RadioButton();
            lastname_textbox = new TextBox();
            firstname_textbox = new TextBox();
            label = new Label();
            f = new Label();
            Persons_GroupBox = new GroupBox();
            listBoxOutPut = new ListBox();
            SortButton = new Button();
            MergeButton = new Button();
            Remove_Button = new Button();
            CreatePerson_GroupBox.SuspendLayout();
            Persons_GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CreatePerson_GroupBox
            // 
            CreatePerson_GroupBox.Controls.Add(Add_Button);
            CreatePerson_GroupBox.Controls.Add(Female_RadioButton);
            CreatePerson_GroupBox.Controls.Add(Male_RadioButton);
            CreatePerson_GroupBox.Controls.Add(lastname_textbox);
            CreatePerson_GroupBox.Controls.Add(firstname_textbox);
            CreatePerson_GroupBox.Controls.Add(label);
            CreatePerson_GroupBox.Controls.Add(f);
            CreatePerson_GroupBox.Location = new Point(24, 28);
            CreatePerson_GroupBox.Name = "CreatePerson_GroupBox";
            CreatePerson_GroupBox.Size = new Size(261, 141);
            CreatePerson_GroupBox.TabIndex = 0;
            CreatePerson_GroupBox.TabStop = false;
            CreatePerson_GroupBox.Text = "New person";
            // 
            // Add_Button
            // 
            Add_Button.Location = new Point(132, 96);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(75, 23);
            Add_Button.TabIndex = 6;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = true;
            Add_Button.Click += Add_Button_Click;
            // 
            // Female_RadioButton
            // 
            Female_RadioButton.AutoSize = true;
            Female_RadioButton.Location = new Point(12, 100);
            Female_RadioButton.Name = "Female_RadioButton";
            Female_RadioButton.Size = new Size(63, 19);
            Female_RadioButton.TabIndex = 5;
            Female_RadioButton.TabStop = true;
            Female_RadioButton.Text = "Female";
            Female_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Male_RadioButton
            // 
            Male_RadioButton.AutoSize = true;
            Male_RadioButton.Location = new Point(12, 75);
            Male_RadioButton.Name = "Male_RadioButton";
            Male_RadioButton.Size = new Size(51, 19);
            Male_RadioButton.TabIndex = 4;
            Male_RadioButton.TabStop = true;
            Male_RadioButton.Text = "Male";
            Male_RadioButton.UseVisualStyleBackColor = true;
            // 
            // lastname_textbox
            // 
            lastname_textbox.Location = new Point(132, 39);
            lastname_textbox.Name = "lastname_textbox";
            lastname_textbox.Size = new Size(100, 23);
            lastname_textbox.TabIndex = 3;
            // 
            // firstname_textbox
            // 
            firstname_textbox.Location = new Point(6, 37);
            firstname_textbox.Name = "firstname_textbox";
            firstname_textbox.Size = new Size(100, 23);
            firstname_textbox.TabIndex = 2;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(132, 21);
            label.Name = "label";
            label.Size = new Size(61, 15);
            label.TabIndex = 1;
            label.Text = "Last name";
            // 
            // f
            // 
            f.AutoSize = true;
            f.Location = new Point(6, 19);
            f.Name = "f";
            f.Size = new Size(62, 15);
            f.TabIndex = 0;
            f.Text = "First name";
            // 
            // Persons_GroupBox
            // 
            Persons_GroupBox.Controls.Add(listBoxOutPut);
            Persons_GroupBox.Location = new Point(24, 192);
            Persons_GroupBox.Name = "Persons_GroupBox";
            Persons_GroupBox.Size = new Size(261, 177);
            Persons_GroupBox.TabIndex = 1;
            Persons_GroupBox.TabStop = false;
            Persons_GroupBox.Text = "Persons";
            // 
            // listBoxOutPut
            // 
            listBoxOutPut.FormattingEnabled = true;
            listBoxOutPut.ItemHeight = 15;
            listBoxOutPut.Location = new Point(6, 22);
            listBoxOutPut.Name = "listBoxOutPut";
            listBoxOutPut.Size = new Size(238, 139);
            listBoxOutPut.TabIndex = 0;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(24, 375);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(75, 23);
            SortButton.TabIndex = 2;
            SortButton.Text = "Sort";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // MergeButton
            // 
            MergeButton.Location = new Point(105, 375);
            MergeButton.Name = "MergeButton";
            MergeButton.Size = new Size(75, 23);
            MergeButton.TabIndex = 3;
            MergeButton.Text = "Merge";
            MergeButton.UseVisualStyleBackColor = true;
            MergeButton.Click += MergeButton_Click;
            // 
            // Remove_Button
            // 
            Remove_Button.Location = new Point(186, 375);
            Remove_Button.Name = "Remove_Button";
            Remove_Button.Size = new Size(75, 23);
            Remove_Button.TabIndex = 4;
            Remove_Button.Text = "Remove";
            Remove_Button.UseVisualStyleBackColor = true;
            Remove_Button.Click += Remove_Button_Click;
            // 
            // PersonRegistryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 422);
            Controls.Add(Remove_Button);
            Controls.Add(MergeButton);
            Controls.Add(SortButton);
            Controls.Add(Persons_GroupBox);
            Controls.Add(CreatePerson_GroupBox);
            Name = "PersonRegistryForm";
            Text = "PersonRegistry";
            CreatePerson_GroupBox.ResumeLayout(false);
            CreatePerson_GroupBox.PerformLayout();
            Persons_GroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CreatePerson_GroupBox;
        private Label f;
        private Label label;
        private TextBox lastname_textbox;
        private TextBox firstname_textbox;
        private RadioButton Female_RadioButton;
        private RadioButton Male_RadioButton;
        private Button Add_Button;
        private GroupBox Persons_GroupBox;
        private ListBox listBoxOutPut;
        private Button SortButton;
        private Button MergeButton;
        private Button Remove_Button;
    }
}
