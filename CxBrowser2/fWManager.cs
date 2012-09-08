/*
 * Created by SharpDevelop.
 * User: Miguel
 * Date: 15/08/2012
 * Time: 10:42 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CxBrowser2
{
	/// <summary>
	/// Description of fWManager.
	/// </summary>
	public partial class fWManager : Form
	{
		private Dictionary<int, fWebBrowser> wManager = new Dictionary<int, fWebBrowser>();
		private int nWindow = 0;
		private string userAgent="";
		
		public string UserAgentString
		{
			get{ return this.userAgent;}
			set{ userAgent = value;}
		}
		
		public fWManager()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FWManagerLoad(object sender, EventArgs e)
		{
			this.NewWindow();
		}
		
		public void NewWindow()
		{
			nWindow++;
			
			fWebBrowser f = new fWebBrowser(this, nWindow, false,"");
			
			this.wManager.Add(nWindow,f);
			
			f.Show();			
		}
		public void NewWindow(string purl, int px, int py, int pheight, int pwidth)
		{
			nWindow++;
			
			fWebBrowser f = new fWebBrowser(this, nWindow, true, purl);
			
			this.wManager.Add(nWindow,f);
			
			//f.Height = pheight;
			//f.Width = pwidth;
			f.Top = px;
			f.Left = py;
			
			f.Show();			
			
		}
		
		public void DisposeWindow(int id)
		{
			fWebBrowser f;
			f = this.wManager[id];
			f.Dispose();
			
			this.wManager.Remove(id);
		}
		
		private void ReloadWindowList()	
		{
			try {
				this.lstWindowsList.DataSource = new BindingSource(this.wManager,null);
				this.lstWindowsList.DisplayMember = "";
				this.lstWindowsList.ValueMember = "Key";		
			} catch (Exception) {
				this.lstWindowsList.DataSource = null;
				this.lstWindowsList.Items.Clear();
			}
			
		}
		
		void BtnNewWindowClick(object sender, EventArgs e)
		{
			this.NewWindow();
			this.ReloadWindowList();
		}
		
		void BtnKillWindowsClick(object sender, EventArgs e)
		{
			int id;
			
			try {
				id = (Int32) this.lstWindowsList.SelectedValue;	
			} catch (Exception) {
				return;
			}
			
			this.DisposeWindow(id);
			this.ReloadWindowList();
		}
		
		void BtnRefreshListClick(object sender, EventArgs e)
		{
			this.ReloadWindowList();
		}
		
		void BtnShowClick(object sender, EventArgs e)
		{
			int id;
			
			try {
				id = (int) this.lstWindowsList.SelectedValue;
				this.ShowWindow(id);
			} catch (Exception) {
				
			}
		}
		
		private void ShowWindow(int id)
		{
			fWebBrowser f;
			f = this.wManager[id];
			f.Activate();
		}
		
		private void ClearEmptyWindow()
		{
			fWebBrowser f;
			int i;
			
			foreach (var par in this.wManager)
			{
				i = par.Key;
				f = par.Value;
				
				if (f.IsDisposed == true)
				{
					this.wManager.Remove(i);
				}
			}			
			
			/*for (;i <= this.wManager.Count - 1;i++ ) {
				f = this.wManager[i];
				if (f.IsDisposed == true)
				{
					this.wManager.Remove(i);
				}
			}*/
		}
		
		void TimTimerTick(object sender, EventArgs e)
		{
			//tick: 60 seconds
			try {
				this.ClearEmptyWindow();
			} catch (Exception) {
				
			}
		}
		
		void FWManagerActivated(object sender, EventArgs e)
		{
			if (this.Visible==true)
			{
				this.ReloadWindowList();	
			}
		}
	}
}
