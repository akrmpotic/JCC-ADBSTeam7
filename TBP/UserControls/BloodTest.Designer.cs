namespace TBP.UserControls
{
    partial class BloodTest
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
            this.dataGridViewBloodTests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnAddBloodTest = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBloodTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBloodTests
            // 
            this.dataGridViewBloodTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBloodTests.Location = new System.Drawing.Point(57, 108);
            this.dataGridViewBloodTests.Name = "dataGridViewBloodTests";
            this.dataGridViewBloodTests.RowHeadersWidth = 51;
            this.dataGridViewBloodTests.RowTemplate.Height = 24;
            this.dataGridViewBloodTests.Size = new System.Drawing.Size(681, 282);
            this.dataGridViewBloodTests.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blood Tests:";
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(628, 32);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(110, 57);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnAddBloodTest
            // 
            this.btnAddBloodTest.Location = new System.Drawing.Point(57, 397);
            this.btnAddBloodTest.Name = "btnAddBloodTest";
            this.btnAddBloodTest.Size = new System.Drawing.Size(126, 57);
            this.btnAddBloodTest.TabIndex = 3;
            this.btnAddBloodTest.Text = "Add Blood Test";
            this.btnAddBloodTest.UseVisualStyleBackColor = true;
            this.btnAddBloodTest.Click += new System.EventHandler(this.btnAddBloodTest_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 495);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(675, 166);
            this.dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parameter types";
            // 
            // BloodTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddBloodTest);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBloodTests);
            this.Name = "BloodTest";
            this.Size = new System.Drawing.Size(800, 931);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBloodTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBloodTests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnAddBloodTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}
