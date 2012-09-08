/*
 * Created by SharpDevelop.
 * User: Miguel
 * Date: 15/08/2012
 * Time: 10:42 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CxBrowser2
{
	partial class fWManager
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fWManager));
			this.lstWindowsList = new System.Windows.Forms.ListBox();
			this.btnKillWindows = new System.Windows.Forms.Button();
			this.btnNewWindow = new System.Windows.Forms.Button();
			this.btnShow = new System.Windows.Forms.Button();
			this.btnRefreshList = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.timTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lstWindowsList
			// 
			this.lstWindowsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lstWindowsList.FormattingEnabled = true;
			this.lstWindowsList.Location = new System.Drawing.Point(12, 25);
			this.lstWindowsList.Name = "lstWindowsList";
			this.lstWindowsList.Size = new System.Drawing.Size(525, 251);
			this.lstWindowsList.TabIndex = 0;
			// 
			// btnKillWindows
			// 
			this.btnKillWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnKillWindows.Location = new System.Drawing.Point(462, 291);
			this.btnKillWindows.Name = "btnKillWindows";
			this.btnKillWindows.Size = new System.Drawing.Size(75, 23);
			this.btnKillWindows.TabIndex = 1;
			this.btnKillWindows.Text = "Kill Window";
			this.btnKillWindows.UseVisualStyleBackColor = true;
			this.btnKillWindows.Click += new System.EventHandler(this.BtnKillWindowsClick);
			// 
			// btnNewWindow
			// 
			this.btnNewWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNewWindow.Location = new System.Drawing.Point(12, 291);
			this.btnNewWindow.Name = "btnNewWindow";
			this.btnNewWindow.Size = new System.Drawing.Size(91, 23);
			this.btnNewWindow.TabIndex = 2;
			this.btnNewWindow.Text = "New Window";
			this.btnNewWindow.UseVisualStyleBackColor = true;
			this.btnNewWindow.Click += new System.EventHandler(this.BtnNewWindowClick);
			// 
			// btnShow
			// 
			this.btnShow.Location = new System.Drawing.Point(109, 291);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(75, 23);
			this.btnShow.TabIndex = 3;
			this.btnShow.Text = "Show";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.BtnShowClick);
			// 
			// btnRefreshList
			// 
			this.btnRefreshList.Location = new System.Drawing.Point(190, 291);
			this.btnRefreshList.Name = "btnRefreshList";
			this.btnRefreshList.Size = new System.Drawing.Size(75, 23);
			this.btnRefreshList.TabIndex = 4;
			this.btnRefreshList.Text = "Refresh List";
			this.btnRefreshList.UseVisualStyleBackColor = true;
			this.btnRefreshList.Click += new System.EventHandler(this.BtnRefreshListClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Browsers:";
			// 
			// timTimer
			// 
			this.timTimer.Enabled = true;
			this.timTimer.Interval = 60000;
			this.timTimer.Tick += new System.EventHandler(this.TimTimerTick);
			// 
			// fWManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(549, 323);
			this.Controls.Add(this.lstWindowsList);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRefreshList);
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.btnNewWindow);
			this.Controls.Add(this.btnKillWindows);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fWManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Window Manager";
			this.Load += new System.EventHandler(this.FWManagerLoad);
			this.Activated += new System.EventHandler(this.FWManagerActivated);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Timer timTimer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRefreshList;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Button btnNewWindow;
		private System.Windows.Forms.Button btnKillWindows;
		private System.Windows.Forms.ListBox lstWindowsList;
	}
}
