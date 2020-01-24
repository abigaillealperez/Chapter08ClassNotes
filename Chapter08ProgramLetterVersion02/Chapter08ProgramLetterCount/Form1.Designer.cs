namespace Chapter08ProgramLetterCount
{
    partial class CountLetters
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
            this.lblEnterText = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lsvOutput = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblEnterText
            // 
            this.lblEnterText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEnterText.Location = new System.Drawing.Point(12, 9);
            this.lblEnterText.Name = "lblEnterText";
            this.lblEnterText.Size = new System.Drawing.Size(249, 25);
            this.lblEnterText.TabIndex = 0;
            this.lblEnterText.Text = "Enter Text:";
            this.lblEnterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnterText.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(11, 168);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 20);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(180, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 20);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(11, 42);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(249, 120);
            this.txtInput.TabIndex = 5;
            // 
            // lsvOutput
            // 
            this.lsvOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvOutput.HideSelection = false;
            this.lsvOutput.Location = new System.Drawing.Point(12, 214);
            this.lsvOutput.Name = "lsvOutput";
            this.lsvOutput.Size = new System.Drawing.Size(249, 116);
            this.lsvOutput.TabIndex = 6;
            this.lsvOutput.UseCompatibleStateImageBehavior = false;
            this.lsvOutput.View = System.Windows.Forms.View.Details;
            this.lsvOutput.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Letter";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 110;
            // 
            // CountLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 350);
            this.Controls.Add(this.lsvOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblEnterText);
            this.Name = "CountLetters";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterText;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListView lsvOutput;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

