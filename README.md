# Nexgo_SDK_C# -City Bank payment intregation using Nexgo pos
___

This solution divided into four project
+ Nexgo.Clients <br/>
Nexgo.Client is windows form project.Its just a interface that communicate with user
+ Nexgo.Api.4.5 <br/>
All Interface and Business logic  are located in the Nexgo.Api.4.5 project.
+ Nexgo.Entity <br/>
Nexgo.Entity consist only model and model mapper class
+ Nexgo.helper <br/>
Nexgo.helper consist the static function that labeled as a helper class like Data convertor or Logger class.
---
## To intregate this dll into your project you just need to communicate with Nexgo.Api.4.5 project's ICityECRPrtocolController
### this controller contain the Model which consist all the information that recieved from the city bank pos machine

- using **SendingMessageToPos** method you can send amount and invoice to the city bank pos machine.this method consist two parameter amount and invoice. <br/>
Example:
```c#
 this.cityECRProtoclController.SendingMessageToPos(amountTextBox.Text.ToString(), invoiceTextBox.Text.ToString());
```
- using **SendingAcknowledgeToPos** method you can send acknowledge to the city bank pos mechine. <br/>
Example:
```c#
 this.cityECRProtoclController.SendingAcknowledgeToPos();
```
- using **OpenPort method** you can open the port in which your pos mechine is connected. <br/>
Example:
```c#
 this.cityECRProtoclController.OpenPort("COM10");
```
-To get the recieved data into client side you need to **PropertyChangedHendler** <br/>
Example:
```c#
 this.cityECRProtoclController = new CityECRProtoclController("COM10");
 this.cityECRProtoclController.RecieverModel.PropertyChanged += new PropertyChangedEventHandler(ReceivedData);  
  private void ReceivedData (object sender, PropertyChangedEventArgs e)
        {
            try
            {  
            this.BeginInvoke(new SetTextDeleg(InvokeUIComponent), new object[] { this.cityECRProtoclController.RecieverModel.FullString });             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                LogHelper.Log(ex.StackTrace);
            }
        }

        private void InvokeUIComponent(string data)
        {
            
            try
            {
                DialogResult dialogResult = MessageBox.Show(data.Trim(), "Is all this ok?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cityECRProtoclController.SendingAcknowledgeToPos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                LogHelper.Log(ex.StackTrace);
            }
            
        }

```
