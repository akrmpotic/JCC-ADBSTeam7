namespace TBP.AddForms
{
    partial class AddPregnancyHistory
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
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDoctorID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxOutcome = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pickerDateAndTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumberOfBornChildren = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfUnbornChildren = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Location = new System.Drawing.Point(89, 267);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(172, 68);
            this.buttonSaveData.TabIndex = 35;
            this.buttonSaveData.Text = "Save Data";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Doctor_ID:";
            // 
            // comboBoxDoctorID
            // 
            this.comboBoxDoctorID.FormattingEnabled = true;
            this.comboBoxDoctorID.Location = new System.Drawing.Point(58, 61);
            this.comboBoxDoctorID.Name = "comboBoxDoctorID";
            this.comboBoxDoctorID.Size = new System.Drawing.Size(237, 24);
            this.comboBoxDoctorID.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Number Of Born Children:";
            // 
            // richTextBoxOutcome
            // 
            this.richTextBoxOutcome.Location = new System.Drawing.Point(374, 61);
            this.richTextBoxOutcome.Name = "richTextBoxOutcome";
            this.richTextBoxOutcome.Size = new System.Drawing.Size(405, 356);
            this.richTextBoxOutcome.TabIndex = 45;
            this.richTextBoxOutcome.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Blood Test Outcome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Enter Date:";
            // 
            // pickerDateAndTime
            // 
            this.pickerDateAndTime.Location = new System.Drawing.Point(151, 119);
            this.pickerDateAndTime.Name = "pickerDateAndTime";
            this.pickerDateAndTime.Size = new System.Drawing.Size(143, 22);
            this.pickerDateAndTime.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Number Of Unborn Children:";
            // 
            // textBoxNumberOfBornChildren
            // 
            this.textBoxNumberOfBornChildren.Location = new System.Drawing.Point(197, 171);
            this.textBoxNumberOfBornChildren.Name = "textBoxNumberOfBornChildren";
            this.textBoxNumberOfBornChildren.Size = new System.Drawing.Size(149, 22);
            this.textBoxNumberOfBornChildren.TabIndex = 49;
            // 
            // textBoxNumberOfUnbornChildren
            // 
            this.textBoxNumberOfUnbornChildren.Location = new System.Drawing.Point(197, 204);
            this.textBoxNumberOfUnbornChildren.Name = "textBoxNumberOfUnbornChildren";
            this.textBoxNumberOfUnbornChildren.Size = new System.Drawing.Size(149, 22);
            this.textBoxNumberOfUnbornChildren.TabIndex = 50;
            // 
            // AddPregnancyHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNumberOfUnbornChildren);
            this.Controls.Add(this.textBoxNumberOfBornChildren);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pickerDateAndTime);
            this.Controls.Add(this.richTextBoxOutcome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxDoctorID);
            this.Name = "AddPregnancyHistory";
            this.Text = "AddPregnancyHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDoctorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxOutcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker pickerDateAndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumberOfBornChildren;
        private System.Windows.Forms.TextBox textBoxNumberOfUnbornChildren;
    }
}