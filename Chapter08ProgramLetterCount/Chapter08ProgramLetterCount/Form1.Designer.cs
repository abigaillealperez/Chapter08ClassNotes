namespace Chapter08ProgramLetterCount
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
            this.lblEnterText = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEnterText
            // 
            this.lblEnterText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEnterText.Location = new System.Drawing.Point(11, 12);
            this.lblEnterText.Name = "lblEnterText";
            this.lblEnterText.Size = new System.Drawing.Size(250, 25);
            this.lblEnterText.TabIndex = 0;
            this.lblEnterText.Text = "Enter Text:";
            this.lblEnterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnterText.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblText
            // 
            this.lblText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblText.Location = new System.Drawing.Point(12, 222);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(125, 20);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Letter";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Location = new System.Drawing.Point(136, 222);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(125, 20);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Count";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 185);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 20);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(186, 184);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 51);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(250, 120);
            this.txtInput.TabIndex = 5;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 254);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(250, 108);
            this.lstOutput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 381);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblEnterText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

