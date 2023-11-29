namespace proba2
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textStudent = new TextBox();
            listBoxStudent = new ListBox();
            dataGridView1 = new DataGridView();
            textBoxSubject = new TextBox();
            listBoxSubject = new ListBox();
            buttonAddNewSubject = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textStudent
            // 
            textStudent.Location = new Point(3, 18);
            textStudent.Name = "textStudent";
            textStudent.Size = new Size(178, 23);
            textStudent.TabIndex = 0;
            textStudent.TextChanged += textStudent_TextChanged;
            // 
            // listBoxStudent
            // 
            listBoxStudent.FormattingEnabled = true;
            listBoxStudent.ItemHeight = 15;
            listBoxStudent.Location = new Point(3, 61);
            listBoxStudent.Name = "listBoxStudent";
            listBoxStudent.Size = new Size(178, 319);
            listBoxStudent.TabIndex = 1;
            listBoxStudent.SelectedIndexChanged += listBoxStudent_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(243, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(468, 319);
            dataGridView1.TabIndex = 2;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(736, 18);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(189, 23);
            textBoxSubject.TabIndex = 3;
            textBoxSubject.TextChanged += textBoxSubject_TextChanged;
            // 
            // listBoxSubject
            // 
            listBoxSubject.FormattingEnabled = true;
            listBoxSubject.ItemHeight = 15;
            listBoxSubject.Location = new Point(736, 61);
            listBoxSubject.Name = "listBoxSubject";
            listBoxSubject.Size = new Size(189, 319);
            listBoxSubject.TabIndex = 4;
            // 
            // buttonAddNewSubject
            // 
            buttonAddNewSubject.Location = new Point(736, 398);
            buttonAddNewSubject.Name = "buttonAddNewSubject";
            buttonAddNewSubject.Size = new Size(189, 23);
            buttonAddNewSubject.TabIndex = 5;
            buttonAddNewSubject.Text = "Új tantárgy felvétele";
            buttonAddNewSubject.UseVisualStyleBackColor = true;
            buttonAddNewSubject.Click += buttonAddNewSubject_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(buttonAddNewSubject);
            Controls.Add(listBoxSubject);
            Controls.Add(textBoxSubject);
            Controls.Add(dataGridView1);
            Controls.Add(listBoxStudent);
            Controls.Add(textStudent);
            Name = "UserControl1";
            Size = new Size(953, 537);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textStudent;
        private ListBox listBoxStudent;
        private DataGridView dataGridView1;
        private TextBox textBoxSubject;
        private ListBox listBoxSubject;
        private Button buttonAddNewSubject;
    }
}
