﻿namespace TBP.AddForms
{
    partial class AddUltrasound
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
            this.richTextBoxOutcome = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPersonID = new System.Windows.Forms.ComboBox();
            this.comboBoxDoctorID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInfirmary = new System.Windows.Forms.TextBox();
            this.pickerDateAndTime = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxPicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxOutcome
            // 
            this.richTextBoxOutcome.Location = new System.Drawing.Point(78, 58);
            this.richTextBoxOutcome.Name = "richTextBoxOutcome";
            this.richTextBoxOutcome.Size = new System.Drawing.Size(316, 307);
            this.richTextBoxOutcome.TabIndex = 43;
            this.richTextBoxOutcome.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ultrasound Description:";
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Location = new System.Drawing.Point(577, 534);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(157, 57);
            this.buttonSaveData.TabIndex = 41;
            this.buttonSaveData.Text = "Save Data";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Person_ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Doctor_ID:";
            // 
            // comboBoxPersonID
            // 
            this.comboBoxPersonID.FormattingEnabled = true;
            this.comboBoxPersonID.Location = new System.Drawing.Point(497, 476);
            this.comboBoxPersonID.Name = "comboBoxPersonID";
            this.comboBoxPersonID.Size = new System.Drawing.Size(222, 24);
            this.comboBoxPersonID.TabIndex = 38;
            // 
            // comboBoxDoctorID
            // 
            this.comboBoxDoctorID.FormattingEnabled = true;
            this.comboBoxDoctorID.Location = new System.Drawing.Point(497, 406);
            this.comboBoxDoctorID.Name = "comboBoxDoctorID";
            this.comboBoxDoctorID.Size = new System.Drawing.Size(222, 24);
            this.comboBoxDoctorID.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Infirmary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Enter Date:";
            // 
            // textBoxInfirmary
            // 
            this.textBoxInfirmary.Location = new System.Drawing.Point(195, 446);
            this.textBoxInfirmary.Name = "textBoxInfirmary";
            this.textBoxInfirmary.Size = new System.Drawing.Size(128, 22);
            this.textBoxInfirmary.TabIndex = 34;
            // 
            // pickerDateAndTime
            // 
            this.pickerDateAndTime.Location = new System.Drawing.Point(195, 389);
            this.pickerDateAndTime.Name = "pickerDateAndTime";
            this.pickerDateAndTime.Size = new System.Drawing.Size(128, 22);
            this.pickerDateAndTime.TabIndex = 33;
            // 
            // pictureBoxPicture
            // 
            this.pictureBoxPicture.Location = new System.Drawing.Point(450, 68);
            this.pictureBoxPicture.Name = "pictureBoxPicture";
            this.pictureBoxPicture.Size = new System.Drawing.Size(315, 297);
            this.pictureBoxPicture.TabIndex = 44;
            this.pictureBoxPicture.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Add Picture:";
            // 
            // AddUltrasound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxPicture);
            this.Controls.Add(this.richTextBoxOutcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxPersonID);
            this.Controls.Add(this.comboBoxDoctorID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxInfirmary);
            this.Controls.Add(this.pickerDateAndTime);
            this.Name = "AddUltrasound";
            this.Text = "AddUltrasound";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxOutcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPersonID;
        private System.Windows.Forms.ComboBox comboBoxDoctorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInfirmary;
        private System.Windows.Forms.DateTimePicker pickerDateAndTime;
        private System.Windows.Forms.PictureBox pictureBoxPicture;
        private System.Windows.Forms.Label label2;
    }
}