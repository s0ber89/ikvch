﻿/*
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
		
		void Button1Click(object sender, EventArgs e)
		{
			
			Control();
			GetData();
			
			myTimer.Tick += new EventHandler(GetDataTimer);

			myTimer.Interval = 300000;
			myTimer.Start();
			
			// Runs the timer, and raises the event.
			while(exitFlag == false) {
			  // Processes all the events in the queue.
			  Application.DoEvents();
			}
			
            
		}
		
		void GetDataTimer(Object myObject, EventArgs myEventArgs)
		{
			Control();
			GetData();
		}
		
		void Control()
        {
			byte[] bb = {0x80};
			
			ToolStripMenuItem ikvchMenuItem = (ToolStripMenuItem) ikvchCom;
			ToolStripMenuItem senecaMenuItem = (ToolStripMenuItem) senecaCom;
			
		    if (ikvchMenuItem != null)
		    {
		        foreach (ToolStripItem item in ikvchMenuItem.DropDownItems)
		        {
		        	if(((ToolStripMenuItem)item).Checked)
		        		this.port = new SerialPort(item.ToString(), 9600, Parity.None, 8, StopBits.One);
		        }
		        
		        foreach (ToolStripItem item in senecaMenuItem.DropDownItems)
		        {
		        	if(((ToolStripMenuItem)item).Checked)
		        		this.portSeneca = new SerialPort(item.ToString(), 9600, Parity.None, 8, StopBits.One);
		        }
		    }
			
			
			
			
			port.Open();
            port.Write(bb, 0, 1);
            port.Close();
        }
        
		void GetData()
        {
            TextBox res = (TextBox) resultLog;
			
			port.Open();
            
            var result = new Stack<byte[]>();
             
        	int Row = 8;
        	int Count = 960 * Row;


            progressBar1.Maximum = Count;
			progressBar1.Value = 0; 
            
			Label lblRes = (Label) lblInfo;
			List<int> IntArr = new List<int>();
			DateTime dateNow = DateTime.Now;
			string Day = String.Format("{0:d }", dateNow).Trim();
			string Month = String.Format("{0:M }", dateNow).Trim();
			string Hour = String.Format("{0:H }", dateNow).Trim();
			string Minute = String.Format("{0:m }", dateNow).Trim();
			int MinuteSearch = Convert.ToInt32(Minute) - 15;
			
			if( int.Parse(Minute) < 5 )
			{
				MinuteSearch = 60 + int.Parse(Minute) - 15;
				Hour = (int.Parse(String.Format("{0:H }", dateNow).Trim()) - 1).ToString();
			}
				
			
			string Log = "";
				
	            for(int i = 0; i < Count; i++)
	            {

					int a = port.ReadByte();
					IntArr.Add(a);
					
					float myFloat = 0;
					double Result = 0;
					string Value = "";
					if((i+1)%Row == 0)
					{
						Value = "Day:" + Day + "^" + String.Format("{0:X}", IntArr[2]) + " Month:" + Month + "^" + String.Format("{0:X}", IntArr[3]);
						
						Log = String.Format("{0:X} ", IntArr[0]) + String.Format("{0:X} ", IntArr[1]) + String.Format("{0:X} ", IntArr[2]) + String.Format("{0:X} ", IntArr[3]) + Environment.NewLine;
						
						byte[] bytes = {Convert.ToByte(IntArr[7]), Convert.ToByte(IntArr[6]), Convert.ToByte(IntArr[5]), Convert.ToByte(IntArr[4])};
        				
						myFloat = BitConverter.ToSingle(bytes, 0) / 2;
        				Result = Math.Round(myFloat, 3);
        				
        				if(Day == String.Format("{0:X}", IntArr[2]) && Month == String.Format("{0:X}", IntArr[3]))
						{
        					if(Hour == String.Format("{0:X}", IntArr[0]) && MinuteSearch <= int.Parse(String.Format("{0:X}", IntArr[1])))
        					{ 
								res.Text += Result + "^" + MinuteSearch + ":" + int.Parse(String.Format("{0:X}", IntArr[1])) +  Environment.NewLine;
								lblRes.Text = String.Format("{0:X}", IntArr[2]) + "-" + String.Format("{0:X}", IntArr[3]) + " " + String.Format("{0:X}", IntArr[0]) + ":" + String.Format("{0:X}", IntArr[1]) + " Значение: " + Result;
        					}
						}
        				
        				IntArr.RemoveRange(0, 8);
					}
					
					
					
					progressBar1.Value++;
         	
	            }

            port.Close();

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
	}
}
