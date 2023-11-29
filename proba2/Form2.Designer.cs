namespace proba2
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
            components = new System.ComponentModel.Container();
            btnCancel = new Button();
            btnOK = new Button();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            textBoxID = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxCode = new TextBox();
            label4 = new Label();
            textBoxDescr = new TextBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.CausesValidation = false;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(31, 239);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(231, 239);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 2;
            label1.Text = "Tantárgy ID:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(31, 27);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(134, 23);
            textBoxID.TabIndex = 3;
            textBoxID.Validating += textBoxID_Validating;
            textBoxID.Validated += textBoxID_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 53);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 4;
            label2.Text = "Tantárgy neve:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(31, 71);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(134, 23);
            textBoxName.TabIndex = 5;
            textBoxName.Validating += textBoxName_Validating;
            textBoxName.Validated += textBoxName_Validated;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 97);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "Kód:";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(31, 115);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(134, 23);
            textBoxCode.TabIndex = 7;
            textBoxCode.Validating += textBoxCode_Validating;
            textBoxCode.Validated += textBoxCode_Validated;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 141);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 8;
            label4.Text = "Tantárgy rövid leírása:";
            // 
            // textBoxDescr
            // 
            textBoxDescr.Location = new Point(31, 159);
            textBoxDescr.Name = "textBoxDescr";
            textBoxDescr.Size = new Size(275, 23);
            textBoxDescr.TabIndex = 9;
            textBoxDescr.Validating += textBoxDescr_Validating;
            textBoxDescr.Validated += textBoxDescr_Validated;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 185);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 10;
            label5.Text = "Ajánlott félév:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(32, 203);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 302);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(textBoxDescr);
            Controls.Add(label4);
            Controls.Add(textBoxCode);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(textBoxID);
            Controls.Add(label1);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOK;
        private ErrorProvider errorProvider1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public TextBox textBoxID;
        public TextBox textBoxName;
        public TextBox textBoxCode;
        public TextBox textBoxDescr;
        public NumericUpDown numericUpDown1;
    }
}