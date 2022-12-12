
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
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
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
            this.portNameTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(66, 232);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(538, 42);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(564, 332);
            this.typeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(0, 13);
            this.typeLbl.TabIndex = 12;
            // 
            // etxLbl
            // 
            this.etxLbl.AutoSize = true;
            this.etxLbl.Location = new System.Drawing.Point(564, 358);
            this.etxLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etxLbl.Name = "etxLbl";
            this.etxLbl.Size = new System.Drawing.Size(0, 13);
            this.etxLbl.TabIndex = 13;
            // 
            // lrcLbl
            // 
            this.lrcLbl.AutoSize = true;
            this.lrcLbl.Location = new System.Drawing.Point(564, 381);
            this.lrcLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lrcLbl.Name = "lrcLbl";
            this.lrcLbl.Size = new System.Drawing.Size(0, 13);
            this.lrcLbl.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Amount:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(133, 88);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(170, 20);
            this.amountTextBox.TabIndex = 16;
            // 
            // invoiceTextBox
            // 
            this.invoiceTextBox.Location = new System.Drawing.Point(501, 88);
            this.invoiceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.invoiceTextBox.Name = "invoiceTextBox";
            this.invoiceTextBox.Size = new System.Drawing.Size(176, 20);
            this.invoiceTextBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Invoice:";
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(204, 125);
            this.processBtn.Margin = new System.Windows.Forms.Padding(2);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(151, 22);
            this.processBtn.TabIndex = 19;
            this.processBtn.Text = "Process";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // dataStringrtxb
            // 
            this.dataStringrtxb.Location = new System.Drawing.Point(149, 189);
            this.dataStringrtxb.Margin = new System.Windows.Forms.Padding(2);
            this.dataStringrtxb.Name = "dataStringrtxb";
            this.dataStringrtxb.Size = new System.Drawing.Size(396, 29);
            this.dataStringrtxb.TabIndex = 20;
            this.dataStringrtxb.Text = "";
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(368, 125);
            this.confirmbtn.Margin = new System.Windows.Forms.Padding(2);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(151, 21);
            this.confirmbtn.TabIndex = 21;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // recievedoutputrtxb
            // 
            this.recievedoutputrtxb.Location = new System.Drawing.Point(66, 296);
            this.recievedoutputrtxb.Margin = new System.Windows.Forms.Padding(2);
            this.recievedoutputrtxb.Name = "recievedoutputrtxb";
            this.recievedoutputrtxb.ReadOnly = true;
            this.recievedoutputrtxb.Size = new System.Drawing.Size(538, 198);
            this.recievedoutputrtxb.TabIndex = 22;
            this.recievedoutputrtxb.Text = "";
            // 
            // portNameTxb
            // 
            this.portNameTxb.Location = new System.Drawing.Point(87, 31);
            this.portNameTxb.Margin = new System.Windows.Forms.Padding(2);
            this.portNameTxb.Name = "portNameTxb";
            this.portNameTxb.Size = new System.Drawing.Size(413, 20);
            this.portNameTxb.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Port Name :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 22);
            this.button1.TabIndex = 25;
            this.button1.Text = "Open Port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(740, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portNameTxb);
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
            this.Controls.Add(this.outputTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(756, 539);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputTextBox;
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
        private System.Windows.Forms.TextBox portNameTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

