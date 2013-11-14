/*
 * Created by SharpDevelop.
 * User: Sokolov
 * Date: 06.11.2013
 * Time: 16:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ikvch
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.resultLog = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.lblInfo = new System.Windows.Forms.Label();
			this.comMenu = new System.Windows.Forms.MenuStrip();
			this.ikvchCom = new System.Windows.Forms.ToolStripMenuItem();
			this.ikvchCom1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ikvchCom2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ikvchCom3 = new System.Windows.Forms.ToolStripMenuItem();
			this.ikvchCom4 = new System.Windows.Forms.ToolStripMenuItem();
			this.ikvchCom5 = new System.Windows.Forms.ToolStripMenuItem();
			this.senecaCom = new System.Windows.Forms.ToolStripMenuItem();
			this.senecaCom1 = new System.Windows.Forms.ToolStripMenuItem();
			this.senecaCom2 = new System.Windows.Forms.ToolStripMenuItem();
			this.senecaCom3 = new System.Windows.Forms.ToolStripMenuItem();
			this.senecaCom4 = new System.Windows.Forms.ToolStripMenuItem();
			this.senecaCom5 = new System.Windows.Forms.ToolStripMenuItem();
			this.lblLastDate = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblIkvchConnect = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblSenecaConnect = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.comMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(367, 277);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Включить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// resultLog
			// 
			this.resultLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.resultLog.Location = new System.Drawing.Point(12, 115);
			this.resultLog.MaxLength = 327670000;
			this.resultLog.Multiline = true;
			this.resultLog.Name = "resultLog";
			this.resultLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.resultLog.Size = new System.Drawing.Size(430, 156);
			this.resultLog.TabIndex = 2;
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(12, 277);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(349, 23);
			this.progressBar1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Текущее значение:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblInfo
			// 
			this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblInfo.Location = new System.Drawing.Point(129, 64);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(313, 20);
			this.lblInfo.TabIndex = 5;
			this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comMenu
			// 
			this.comMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ikvchCom,
									this.senecaCom});
			this.comMenu.Location = new System.Drawing.Point(0, 0);
			this.comMenu.Name = "comMenu";
			this.comMenu.Size = new System.Drawing.Size(454, 24);
			this.comMenu.TabIndex = 6;
			this.comMenu.Text = "ИКВЧ-ВЗ";
			// 
			// ikvchCom
			// 
			this.ikvchCom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ikvchCom1,
									this.ikvchCom2,
									this.ikvchCom3,
									this.ikvchCom4,
									this.ikvchCom5});
			this.ikvchCom.Name = "ikvchCom";
			this.ikvchCom.Size = new System.Drawing.Size(69, 20);
			this.ikvchCom.Text = "ИКВЧ-ВЗ";
			// 
			// ikvchCom1
			// 
			this.ikvchCom1.Checked = true;
			this.ikvchCom1.CheckOnClick = true;
			this.ikvchCom1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ikvchCom1.Name = "ikvchCom1";
			this.ikvchCom1.Size = new System.Drawing.Size(108, 22);
			this.ikvchCom1.Text = "COM1";
			this.ikvchCom1.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// ikvchCom2
			// 
			this.ikvchCom2.CheckOnClick = true;
			this.ikvchCom2.Name = "ikvchCom2";
			this.ikvchCom2.Size = new System.Drawing.Size(108, 22);
			this.ikvchCom2.Text = "COM2";
			this.ikvchCom2.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// ikvchCom3
			// 
			this.ikvchCom3.CheckOnClick = true;
			this.ikvchCom3.Name = "ikvchCom3";
			this.ikvchCom3.Size = new System.Drawing.Size(108, 22);
			this.ikvchCom3.Text = "COM3";
			this.ikvchCom3.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// ikvchCom4
			// 
			this.ikvchCom4.CheckOnClick = true;
			this.ikvchCom4.Name = "ikvchCom4";
			this.ikvchCom4.Size = new System.Drawing.Size(108, 22);
			this.ikvchCom4.Text = "COM4";
			this.ikvchCom4.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// ikvchCom5
			// 
			this.ikvchCom5.CheckOnClick = true;
			this.ikvchCom5.Name = "ikvchCom5";
			this.ikvchCom5.Size = new System.Drawing.Size(108, 22);
			this.ikvchCom5.Text = "COM5";
			this.ikvchCom5.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// senecaCom
			// 
			this.senecaCom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.senecaCom1,
									this.senecaCom2,
									this.senecaCom3,
									this.senecaCom4,
									this.senecaCom5});
			this.senecaCom.Name = "senecaCom";
			this.senecaCom.Size = new System.Drawing.Size(62, 20);
			this.senecaCom.Text = "SENECA";
			// 
			// senecaCom1
			// 
			this.senecaCom1.CheckOnClick = true;
			this.senecaCom1.Name = "senecaCom1";
			this.senecaCom1.Size = new System.Drawing.Size(108, 22);
			this.senecaCom1.Text = "COM1";
			this.senecaCom1.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// senecaCom2
			// 
			this.senecaCom2.Checked = true;
			this.senecaCom2.CheckOnClick = true;
			this.senecaCom2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.senecaCom2.Name = "senecaCom2";
			this.senecaCom2.Size = new System.Drawing.Size(108, 22);
			this.senecaCom2.Text = "COM2";
			this.senecaCom2.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// senecaCom3
			// 
			this.senecaCom3.CheckOnClick = true;
			this.senecaCom3.Name = "senecaCom3";
			this.senecaCom3.Size = new System.Drawing.Size(108, 22);
			this.senecaCom3.Text = "COM3";
			this.senecaCom3.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// senecaCom4
			// 
			this.senecaCom4.CheckOnClick = true;
			this.senecaCom4.Name = "senecaCom4";
			this.senecaCom4.Size = new System.Drawing.Size(108, 22);
			this.senecaCom4.Text = "COM4";
			this.senecaCom4.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// senecaCom5
			// 
			this.senecaCom5.CheckOnClick = true;
			this.senecaCom5.Name = "senecaCom5";
			this.senecaCom5.Size = new System.Drawing.Size(108, 22);
			this.senecaCom5.Text = "COM5";
			this.senecaCom5.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// lblLastDate
			// 
			this.lblLastDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLastDate.Location = new System.Drawing.Point(129, 92);
			this.lblLastDate.Name = "lblLastDate";
			this.lblLastDate.Size = new System.Drawing.Size(313, 20);
			this.lblLastDate.TabIndex = 8;
			this.lblLastDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Последний запрос:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblIkvchConnect
			// 
			this.lblIkvchConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblIkvchConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblIkvchConnect.Location = new System.Drawing.Point(129, 24);
			this.lblIkvchConnect.Name = "lblIkvchConnect";
			this.lblIkvchConnect.Size = new System.Drawing.Size(313, 20);
			this.lblIkvchConnect.TabIndex = 10;
			this.lblIkvchConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "ИКВЧ-ВЗ:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSenecaConnect
			// 
			this.lblSenecaConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSenecaConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSenecaConnect.Location = new System.Drawing.Point(129, 44);
			this.lblSenecaConnect.Name = "lblSenecaConnect";
			this.lblSenecaConnect.Size = new System.Drawing.Size(313, 20);
			this.lblSenecaConnect.TabIndex = 12;
			this.lblSenecaConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "SENECA:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 309);
			this.Controls.Add(this.lblSenecaConnect);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblIkvchConnect);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblLastDate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.resultLog);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comMenu);
			this.MainMenuStrip = this.comMenu;
			this.Name = "MainForm";
			this.Text = "ИКВЧ-ВЗ и SENECA";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.comMenu.ResumeLayout(false);
			this.comMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblSenecaConnect;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblIkvchConnect;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblLastDate;
		private System.Windows.Forms.ToolStripMenuItem senecaCom5;
		private System.Windows.Forms.ToolStripMenuItem senecaCom4;
		private System.Windows.Forms.ToolStripMenuItem senecaCom3;
		private System.Windows.Forms.ToolStripMenuItem senecaCom2;
		private System.Windows.Forms.ToolStripMenuItem senecaCom1;
		private System.Windows.Forms.ToolStripMenuItem ikvchCom5;
		private System.Windows.Forms.ToolStripMenuItem ikvchCom4;
		private System.Windows.Forms.ToolStripMenuItem ikvchCom3;
		private System.Windows.Forms.ToolStripMenuItem ikvchCom2;
		private System.Windows.Forms.ToolStripMenuItem ikvchCom1;
		private System.Windows.Forms.MenuStrip comMenu;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TextBox resultLog;
		private System.Windows.Forms.Button button1;
		
	}
}
