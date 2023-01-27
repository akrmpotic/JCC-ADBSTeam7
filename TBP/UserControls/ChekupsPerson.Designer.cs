namespace TBP
{
    partial class ChekupsPerson
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnPregnancyHistory = new System.Windows.Forms.Button();
            this.btnColorDoppler = new System.Windows.Forms.Button();
            this.btnExamination = new System.Windows.Forms.Button();
            this.btnUltrasound = new System.Windows.Forms.Button();
            this.btnCTG = new System.Windows.Forms.Button();
            this.btnBlood = new System.Windows.Forms.Button();
            this.btnPAP = new System.Windows.Forms.Button();
            this.btnUrinary = new System.Windows.Forms.Button();
            this.btnTumors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAddPerson);
            this.splitContainer1.Panel1.Controls.Add(this.btnPregnancyHistory);
            this.splitContainer1.Panel1.Controls.Add(this.btnColorDoppler);
            this.splitContainer1.Panel1.Controls.Add(this.btnExamination);
            this.splitContainer1.Panel1.Controls.Add(this.btnUltrasound);
            this.splitContainer1.Panel1.Controls.Add(this.btnCTG);
            this.splitContainer1.Panel1.Controls.Add(this.btnBlood);
            this.splitContainer1.Panel1.Controls.Add(this.btnPAP);
            this.splitContainer1.Panel1.Controls.Add(this.btnUrinary);
            this.splitContainer1.Panel1.Controls.Add(this.btnTumors);
            this.splitContainer1.Size = new System.Drawing.Size(1149, 693);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(108, 606);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(130, 65);
            this.btnAddPerson.TabIndex = 16;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnPregnancyHistory
            // 
            this.btnPregnancyHistory.Location = new System.Drawing.Point(12, 504);
            this.btnPregnancyHistory.Name = "btnPregnancyHistory";
            this.btnPregnancyHistory.Size = new System.Drawing.Size(341, 82);
            this.btnPregnancyHistory.TabIndex = 15;
            this.btnPregnancyHistory.Text = "Pregnancy history";
            this.btnPregnancyHistory.UseVisualStyleBackColor = true;
            this.btnPregnancyHistory.Click += new System.EventHandler(this.btnPregnancyHistory_Click);
            // 
            // btnColorDoppler
            // 
            this.btnColorDoppler.Location = new System.Drawing.Point(12, 260);
            this.btnColorDoppler.Name = "btnColorDoppler";
            this.btnColorDoppler.Size = new System.Drawing.Size(147, 99);
            this.btnColorDoppler.TabIndex = 14;
            this.btnColorDoppler.Text = "Color Doppler";
            this.btnColorDoppler.UseVisualStyleBackColor = true;
            this.btnColorDoppler.Click += new System.EventHandler(this.btnColorDoppler_Click);
            // 
            // btnExamination
            // 
            this.btnExamination.Location = new System.Drawing.Point(12, 389);
            this.btnExamination.Name = "btnExamination";
            this.btnExamination.Size = new System.Drawing.Size(147, 83);
            this.btnExamination.TabIndex = 13;
            this.btnExamination.Text = "Gynecological examination";
            this.btnExamination.UseVisualStyleBackColor = true;
            this.btnExamination.Click += new System.EventHandler(this.btnExamination_Click);
            // 
            // btnUltrasound
            // 
            this.btnUltrasound.Location = new System.Drawing.Point(196, 389);
            this.btnUltrasound.Name = "btnUltrasound";
            this.btnUltrasound.Size = new System.Drawing.Size(157, 83);
            this.btnUltrasound.TabIndex = 12;
            this.btnUltrasound.Text = "Ultrasound";
            this.btnUltrasound.UseVisualStyleBackColor = true;
            this.btnUltrasound.Click += new System.EventHandler(this.btnUltrasound_Click);
            // 
            // btnCTG
            // 
            this.btnCTG.Location = new System.Drawing.Point(196, 260);
            this.btnCTG.Name = "btnCTG";
            this.btnCTG.Size = new System.Drawing.Size(157, 99);
            this.btnCTG.TabIndex = 11;
            this.btnCTG.Text = "CTG";
            this.btnCTG.UseVisualStyleBackColor = true;
            this.btnCTG.Click += new System.EventHandler(this.btnCTG_Click);
            // 
            // btnBlood
            // 
            this.btnBlood.Location = new System.Drawing.Point(196, 138);
            this.btnBlood.Name = "btnBlood";
            this.btnBlood.Size = new System.Drawing.Size(157, 99);
            this.btnBlood.TabIndex = 10;
            this.btnBlood.Text = "Blood tests";
            this.btnBlood.UseVisualStyleBackColor = true;
            this.btnBlood.Click += new System.EventHandler(this.btnBlood_Click);
            // 
            // btnPAP
            // 
            this.btnPAP.Location = new System.Drawing.Point(12, 12);
            this.btnPAP.Name = "btnPAP";
            this.btnPAP.Size = new System.Drawing.Size(147, 99);
            this.btnPAP.TabIndex = 9;
            this.btnPAP.Text = "PAP test";
            this.btnPAP.UseVisualStyleBackColor = true;
            this.btnPAP.Click += new System.EventHandler(this.btnPAP_Click);
            // 
            // btnUrinary
            // 
            this.btnUrinary.Location = new System.Drawing.Point(12, 138);
            this.btnUrinary.Name = "btnUrinary";
            this.btnUrinary.Size = new System.Drawing.Size(147, 99);
            this.btnUrinary.TabIndex = 8;
            this.btnUrinary.Text = "Urinary Incontinence";
            this.btnUrinary.UseVisualStyleBackColor = true;
            this.btnUrinary.Click += new System.EventHandler(this.btnUrinary_Click);
            // 
            // btnTumors
            // 
            this.btnTumors.Location = new System.Drawing.Point(196, 12);
            this.btnTumors.Name = "btnTumors";
            this.btnTumors.Size = new System.Drawing.Size(157, 99);
            this.btnTumors.TabIndex = 7;
            this.btnTumors.Text = "Detection of gynecological tumor";
            this.btnTumors.UseVisualStyleBackColor = true;
            this.btnTumors.Click += new System.EventHandler(this.btnTumors_Click);
            // 
            // ChekupsPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 693);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ChekupsPerson";
            this.Text = "ChekupsPerson";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnExamination;
        private System.Windows.Forms.Button btnUltrasound;
        private System.Windows.Forms.Button btnCTG;
        private System.Windows.Forms.Button btnBlood;
        private System.Windows.Forms.Button btnPAP;
        private System.Windows.Forms.Button btnUrinary;
        private System.Windows.Forms.Button btnTumors;
        private System.Windows.Forms.Button btnColorDoppler;
        private System.Windows.Forms.Button btnPregnancyHistory;
        private System.Windows.Forms.Button btnAddPerson;
    }
}