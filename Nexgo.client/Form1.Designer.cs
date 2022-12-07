
namespace Nexgo.client
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
            this.dataFieldTextBox = new System.Windows.Forms.RichTextBox();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stxlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lenLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.etxLbl = new System.Windows.Forms.Label();
            this.lrcLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.invoiceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.processBtn = new System.Windows.Forms.Button();
            this.dataStringrtxb = new System.Windows.Forms.RichTextBox();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.recievedoutputrtxb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dataFieldTextBox
            // 
            this.dataFieldTextBox.Location = new System.Drawing.Point(49, 52);
            this.dataFieldTextBox.Name = "dataFieldTextBox";
            this.dataFieldTextBox.Size = new System.Drawing.Size(789, 52);
            this.dataFieldTextBox.TabIndex = 0;
            this.dataFieldTextBox.Text = "A0020000|B00TK|B01156|Y0090|U0001";
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Location = new System.Drawing.Point(863, 52);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(302, 110);
            this.ConvertBtn.TabIndex = 1;
            this.ConvertBtn.Text = "Convert to Hex";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(67, 318);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(1072, 77);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stx:";
            // 
            // stxlbl
            // 
            this.stxlbl.AutoSize = true;
            this.stxlbl.Location = new System.Drawing.Point(195, 527);
            this.stxlbl.Name = "stxlbl";
            this.stxlbl.Size = new System.Drawing.Size(0, 25);
            this.stxlbl.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Len:";
            // 
            // lenLbl
            // 
            this.lenLbl.AutoSize = true;
            this.lenLbl.Location = new System.Drawing.Point(195, 582);
            this.lenLbl.Name = "lenLbl";
            this.lenLbl.Size = new System.Drawing.Size(0, 25);
            this.lenLbl.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data:";
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Location = new System.Drawing.Point(195, 633);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(0, 25);
            this.dataLbl.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(955, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(955, 559);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Etx:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(955, 604);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Lrc:";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(1063, 509);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(0, 25);
            this.typeLbl.TabIndex = 12;
            // 
            // etxLbl
            // 
            this.etxLbl.AutoSize = true;
            this.etxLbl.Location = new System.Drawing.Point(1063, 559);
            this.etxLbl.Name = "etxLbl";
            this.etxLbl.Size = new System.Drawing.Size(0, 25);
            this.etxLbl.TabIndex = 13;
            // 
            // lrcLbl
            // 
            this.lrcLbl.AutoSize = true;
            this.lrcLbl.Location = new System.Drawing.Point(1063, 604);
            this.lrcLbl.Name = "lrcLbl";
            this.lrcLbl.Size = new System.Drawing.Size(0, 25);
            this.lrcLbl.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Amount:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(147, 187);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(337, 31);
            this.amountTextBox.TabIndex = 16;
            // 
            // invoiceTextBox
            // 
            this.invoiceTextBox.Location = new System.Drawing.Point(817, 187);
            this.invoiceTextBox.Name = "invoiceTextBox";
            this.invoiceTextBox.Size = new System.Drawing.Size(348, 31);
            this.invoiceTextBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(725, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Invoice:";
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(261, 251);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(302, 42);
            this.processBtn.TabIndex = 19;
            this.processBtn.Text = "Process";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // dataStringrtxb
            // 
            this.dataStringrtxb.Location = new System.Drawing.Point(49, 110);
            this.dataStringrtxb.Name = "dataStringrtxb";
            this.dataStringrtxb.Size = new System.Drawing.Size(789, 52);
            this.dataStringrtxb.TabIndex = 20;
            this.dataStringrtxb.Text = "";
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(588, 252);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(302, 41);
            this.confirmbtn.TabIndex = 21;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // recievedoutputrtxb
            // 
            this.recievedoutputrtxb.Location = new System.Drawing.Point(67, 401);
            this.recievedoutputrtxb.Name = "recievedoutputrtxb";
            this.recievedoutputrtxb.ReadOnly = true;
            this.recievedoutputrtxb.Size = new System.Drawing.Size(1072, 77);
            this.recievedoutputrtxb.TabIndex = 22;
            this.recievedoutputrtxb.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1470, 1229);
            this.Controls.Add(this.recievedoutputrtxb);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.dataStringrtxb);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.invoiceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lrcLbl);
            this.Controls.Add(this.etxLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lenLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stxlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.dataFieldTextBox);
            this.MinimumSize = new System.Drawing.Size(1496, 1300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox dataFieldTextBox;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stxlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lenLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label etxLbl;
        private System.Windows.Forms.Label lrcLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox invoiceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.RichTextBox dataStringrtxb;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.RichTextBox recievedoutputrtxb;
    }
}

