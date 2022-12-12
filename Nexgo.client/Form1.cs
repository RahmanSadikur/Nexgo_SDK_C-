using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nexgo.Com.APIx4._5.IRepo;
using Nexgo.Com.APIx4._5.Repo;
using Nexgo.Data;
using Nexgo.Helper;


namespace Nexgo.client
{
    public partial class Form1 : Form
    {
        private ICityECRPrtocolController cityECRProtoclController;


        // delegate is used to write to a UI control from a non-UI thread
        private delegate void SetTextDeleg(string text);

        public Form1()
        {
            InitializeComponent();
            
                  
            this.cityECRProtoclController = new CityECRProtoclController("COM10");
            this.cityECRProtoclController.RecieverModel.PropertyChanged += new PropertyChangedEventHandler(sp_DataReceived);      

        }


        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            
            this.cityECRProtoclController.SendingMessageToPos(amountTextBox.Text.ToString(), invoiceTextBox.Text.ToString());
            if (this.cityECRProtoclController.RecieverModel.IsError)
            {
                MessageBox.Show(this.cityECRProtoclController.RecieverModel.ErrorMessage);
                return;
            }
            
            outputTextBox.Text = cityECRProtoclController.FinalhexString;
            dataStringrtxb.Text = cityECRProtoclController.dataString;
        }


        void sp_DataReceived(object sender, PropertyChangedEventArgs e)
        {
           

            try
            {


                this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { this.cityECRProtoclController.RecieverModel.FullString });
               




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                LogHelper.Log(ex.StackTrace);
            }



        }

        private void si_DataReceived(string data)
        {
            
            try
            {
                recievedoutputrtxb.Text = data.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                LogHelper.Log(ex.StackTrace);
            }
            
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            
            cityECRProtoclController.SendingAcknowledgeToPos();
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(portNameTxb.Text) && !String.IsNullOrEmpty(portNameTxb.Text))
            {
                cityECRProtoclController.OpenPort(portNameTxb.Text);
            }
            else
            {
                MessageBox.Show("Please enter a valid port name first");
                LogHelper.Log("Invalid port selected");
            }
            

        }

        
    }
}
