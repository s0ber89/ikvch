/*
 * Created by SharpDevelop.
 * User: Sokolov
 * Date: 06.11.2013
 * Time: 16:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace ikvch
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		System.Windows.Forms.ToolStripMenuItem ikvchCom;
		System.Windows.Forms.ToolStripMenuItem senecaCom;
		
		SerialPort port = new SerialPort();
		SerialPort portSeneca = new SerialPort();
		
		static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
	    static bool exitFlag = false;
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		private void Button1Click(object sender, EventArgs e)
		{
			
			Control();
			GetData();
			
			myTimer.Tick += new EventHandler(GetDataTimer);

			myTimer.Interval = 240000;
			myTimer.Start();
			
			// Runs the timer, and raises the event.
			while(exitFlag == false) {
			  // Processes all the events in the queue.
			  Application.DoEvents();
			}
			
		}
		
		private void Alarm(bool status)
		{
			ToolStripMenuItem senecaMenuItem = (ToolStripMenuItem) senecaCom;
			
			foreach (ToolStripItem item in senecaMenuItem.DropDownItems)
	        {
	        	if(((ToolStripMenuItem)item).Checked)
	        		this.portSeneca = new SerialPort(item.ToString(), 9600, Parity.None, 8, StopBits.One);
	        }
            
			byte[] bOn = {0x01, 0x06, 0x00, 0x02, 0x02, 0x00, 0x29, 0x6A};
			byte[] bOff = {0x01, 0x06, 0x00, 0x02, 0x01, 0xE0, 0x28, 0x12};
			
			try
	        {
	            portSeneca.Open();
	            
	            if (portSeneca.IsOpen == true)
	            {
	                lblSenecaConnect.Text = "CONNECTED";
	            }
	            
	            portSeneca.Write((status == true ? bOn : bOff), 0, 8);

            	System.Threading.Thread.Sleep(2000);
                if (portSeneca.BytesToRead == 0)
	            {
                	lblSenecaConnect.Text = "NOT CONNECTED";
                	MessageBox.Show("Error: SENECA NOT CONNECTED", "ERROR");
		        }
                portSeneca.Close();
			}
	        catch (Exception ex)
	        {
	            
	            if (portSeneca.IsOpen == false)
	            {
	                lblSenecaConnect.Text = "NOT CONNECTED";
	            }
	        	
	        	MessageBox.Show("Error: " + ex.ToString(), "ERROR");
	        }

		}
		
		private void GetDataTimer(Object myObject, EventArgs myEventArgs)
		{
			Control();
			GetData();
		}
		
		private void Control()
        {
			lblIkvchConnect.Text = "CONNECTED";
			byte[] bb = {0x80};
			
			ToolStripMenuItem ikvchMenuItem = (ToolStripMenuItem) ikvchCom;
			
		    if (ikvchMenuItem != null)
		    {
		        foreach (ToolStripItem item in ikvchMenuItem.DropDownItems)
		        {
		        	if(((ToolStripMenuItem)item).Checked)
		        		this.port = new SerialPort(item.ToString(), 9600, Parity.None, 8, StopBits.One);
		        }
		    }
		    
            port.Open();
            port.Write(bb, 0, 1);
        	port.Close();         
        }
        
		private void GetData()
        {
            TextBox res = (TextBox) resultLog;
            port.Open();
            System.Threading.Thread.Sleep(1000);
            
            if (port.BytesToRead > 0)
            {
                
               	var result = new Stack<byte[]>();
             
	        	int Row = 8;
	        	int Count = 960 * Row;
	
	
	            progressBar1.Maximum = Count;
				progressBar1.Value = 0; 
	            
				Label lblRes = (Label) lblInfo;
				Label lastDate = (Label) lblLastDate;
				List<int> IntArr = new List<int>();
				DateTime dateNow = DateTime.Now;
				string Day = String.Format("{0:d }", dateNow).Trim();
				string Month = String.Format("{0:M }", dateNow).Trim();
				string Hour = String.Format("{0:H }", dateNow).Trim();
				string Minute = String.Format("{0:m }", dateNow).Trim();
				int MinuteSearch = Convert.ToInt32(Minute) - 5;	
				
				double Result = 0;
					
	            for(int i = 0; i < Count; i++)
	            {
	
					int a = port.ReadByte();
					
					IntArr.Add(a);
					
					float myFloat = 0;
					
					if((i+1)%Row == 0)
					{
						
	    				if(Day == String.Format("{0:X}", IntArr[2]) && Month == String.Format("{0:X}", IntArr[3]))
						{
	    					if( int.Parse(Minute) < 5 )
							{							
								if((int.Parse(String.Format("{0:H }", dateNow).Trim()) - 1).ToString() == String.Format("{0:X}", IntArr[0]) && (60 + int.Parse(Minute) - 5) <= int.Parse(String.Format("{0:X}", IntArr[1])))
		    					{ 
									byte[] bytes = {Convert.ToByte(IntArr[7]), Convert.ToByte(IntArr[6]), Convert.ToByte(IntArr[5]), Convert.ToByte(IntArr[4])};
		    						myFloat = BitConverter.ToSingle(bytes, 0) / 2;
		    						Result = Math.Round(myFloat, 3);
		    						
		    						res.Text += String.Format("{0:X} ", IntArr[0]) + String.Format("{0:X} ", IntArr[1]) + String.Format("{0:X} ", IntArr[2]) + String.Format("{0:X} ", IntArr[3]) + String.Format("{0:X} ", IntArr[4]) + String.Format("{0:X} ", IntArr[5])  + String.Format("{0:X} ", IntArr[6]) + String.Format("{0:X} ", IntArr[7]) + Environment.NewLine;
		    						lblRes.Text = String.Format("{0:X}", IntArr[2]) + "-" + String.Format("{0:X}", IntArr[3]) + " " + String.Format("{0:X}", IntArr[0]) + ":" + String.Format("{0:X}", IntArr[1]) + " Значение: " + Result.ToString();
		    					}
							}
	    					
	    					if(Hour == String.Format("{0:X}", IntArr[0]) && MinuteSearch <= int.Parse(String.Format("{0:X}", IntArr[1])))
	    					{ 
								byte[] bytes = {Convert.ToByte(IntArr[7]), Convert.ToByte(IntArr[6]), Convert.ToByte(IntArr[5]), Convert.ToByte(IntArr[4])};
	    						myFloat = BitConverter.ToSingle(bytes, 0) / 2;
	    						Result = Math.Round(myFloat, 3);
	    						
	    						res.Text += String.Format("{0:X} ", IntArr[0]) + String.Format("{0:X} ", IntArr[1]) + String.Format("{0:X} ", IntArr[2]) + String.Format("{0:X} ", IntArr[3]) + String.Format("{0:X} ", IntArr[4]) + String.Format("{0:X} ", IntArr[5])  + String.Format("{0:X} ", IntArr[6]) + String.Format("{0:X} ", IntArr[7]) + Environment.NewLine;
	    						lblRes.Text = String.Format("{0:X}", IntArr[2]) + "-" + String.Format("{0:X}", IntArr[3]) + " " + String.Format("{0:X}", IntArr[0]) + ":" + String.Format("{0:X}", IntArr[1]) + " Значение: " + Result.ToString();
	    					}
						}
	
	    				IntArr.RemoveRange(0, 8);
					}
					
					progressBar1.Value++;

	            }
	            
	            if(Result >= 0.1)
	            	Alarm(true);
	            else 
	            	Alarm(false);
	
	            port.Close();
				
	            lastDate.Text = Day + "-" + Month + " " + Hour + ":" + Minute;
	            
	            progressBar1.Value = 0;
            }
            else
            {
            	port.Close();
            	lblIkvchConnect.Text = "NOT CONNECTED";
            	MessageBox.Show("Error: ИКВЧ-ВЗ NOT CONNECTED", "ERROR");
            }

      
        }
		
			
		private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem selectedItem = sender as ToolStripMenuItem;
            
            ToolStrip ownerItem = selectedItem.GetCurrentParent();
		    
		    if (ownerItem != null)
		    {
		        //uncheck all item
		        foreach (ToolStripMenuItem item in ownerItem.Items)
		        {
		            item.Checked = false;
		        }
		    }
            
            selectedItem.CheckState = CheckState.Checked;
        }
		
		private void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			myTimer.Stop();
		}
		
	}
}
