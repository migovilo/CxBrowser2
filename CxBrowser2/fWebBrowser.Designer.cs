/*
 * Created by SharpDevelop.
 * User: Miguel
 * Date: 14/08/2012
 * Time: 07:17 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CxBrowser2
{
	partial class fWebBrowser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fWebBrowser));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnBack = new System.Windows.Forms.Button();
			this.picReload = new System.Windows.Forms.PictureBox();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnMenu = new System.Windows.Forms.ToolStripDropDownButton();
			this.mnuNewWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuWindowManager = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuAlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
			this.btnTools = new System.Windows.Forms.ToolStripDropDownButton();
			this.mnuDeveloperTools = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.btnForward = new System.Windows.Forms.Button();
			this.panBrowser = new System.Windows.Forms.Panel();
			this.mnuChangeUserAgent = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnBack);
			this.panel1.Controls.Add(this.picReload);
			this.panel1.Controls.Add(this.txtURL);
			this.panel1.Controls.Add(this.progressBar1);
			this.panel1.Controls.Add(this.toolStrip1);
			this.panel1.Controls.Add(this.btnForward);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(762, 34);
			this.panel1.TabIndex = 2;
			// 
			// btnBack
			// 
			this.btnBack.Enabled = false;
			this.btnBack.Location = new System.Drawing.Point(5, 5);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(30, 23);
			this.btnBack.TabIndex = 0;
			this.btnBack.TabStop = false;
			this.btnBack.Text = "<";
			this.btnBack.UseVisualStyleBackColor = true;
			// 
			// picReload
			// 
			this.picReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picReload.BackColor = System.Drawing.Color.Transparent;
			this.picReload.Image = ((System.Drawing.Image)(resources.GetObject("picReload.Image")));
			this.picReload.Location = new System.Drawing.Point(669, 9);
			this.picReload.Name = "picReload";
			this.picReload.Size = new System.Drawing.Size(15, 15);
			this.picReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picReload.TabIndex = 5;
			this.picReload.TabStop = false;
			// 
			// txtURL
			// 
			this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtURL.Location = new System.Drawing.Point(70, 7);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(619, 20);
			this.txtURL.TabIndex = 6;
			this.txtURL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtURLKeyUp);
			// 
			// progressBar1
			// 
			this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.progressBar1.Location = new System.Drawing.Point(0, 29);
			this.progressBar1.MarqueeAnimationSpeed = 10;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(762, 5);
			this.progressBar1.Step = 50;
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar1.TabIndex = 4;
			this.progressBar1.Value = 50;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.btnMenu,
									this.btnTools});
			this.toolStrip1.Location = new System.Drawing.Point(664, 4);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(92, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnMenu
			// 
			this.btnMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mnuNewWindow,
									this.toolStripMenuItem3,
									this.mnuWindowManager,
									this.toolStripMenuItem1,
									this.mnuAlwaysOnTop});
			this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
			this.btnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(29, 22);
			this.btnMenu.Text = "Page";
			// 
			// mnuNewWindow
			// 
			this.mnuNewWindow.Name = "mnuNewWindow";
			this.mnuNewWindow.Size = new System.Drawing.Size(168, 22);
			this.mnuNewWindow.Text = "New Window";
			this.mnuNewWindow.Click += new System.EventHandler(this.MnuNewWindowClick);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(165, 6);
			// 
			// mnuWindowManager
			// 
			this.mnuWindowManager.Name = "mnuWindowManager";
			this.mnuWindowManager.Size = new System.Drawing.Size(168, 22);
			this.mnuWindowManager.Text = "Window Manager";
			this.mnuWindowManager.Click += new System.EventHandler(this.MnuWindowManagerClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
			// 
			// mnuAlwaysOnTop
			// 
			this.mnuAlwaysOnTop.Name = "mnuAlwaysOnTop";
			this.mnuAlwaysOnTop.Size = new System.Drawing.Size(168, 22);
			this.mnuAlwaysOnTop.Text = "Always On Top";
			this.mnuAlwaysOnTop.Click += new System.EventHandler(this.MnuAlwaysOnTopClick);
			// 
			// btnTools
			// 
			this.btnTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mnuChangeUserAgent,
									this.mnuDeveloperTools,
									this.toolStripMenuItem2,
									this.mnuAbout,
									this.toolStripMenuItem4,
									this.mnuExit});
			this.btnTools.Image = ((System.Drawing.Image)(resources.GetObject("btnTools.Image")));
			this.btnTools.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnTools.Name = "btnTools";
			this.btnTools.Size = new System.Drawing.Size(29, 22);
			this.btnTools.Text = "Settings";
			// 
			// mnuDeveloperTools
			// 
			this.mnuDeveloperTools.Name = "mnuDeveloperTools";
			this.mnuDeveloperTools.Size = new System.Drawing.Size(176, 22);
			this.mnuDeveloperTools.Text = "Developer Tools";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 6);
			// 
			// mnuAbout
			// 
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(176, 22);
			this.mnuAbout.Text = "About CxBrowser";
			this.mnuAbout.Click += new System.EventHandler(this.MnuAboutClick);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(173, 6);
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(176, 22);
			this.mnuExit.Text = "Exit";
			// 
			// btnForward
			// 
			this.btnForward.Enabled = false;
			this.btnForward.Location = new System.Drawing.Point(34, 5);
			this.btnForward.Name = "btnForward";
			this.btnForward.Size = new System.Drawing.Size(30, 23);
			this.btnForward.TabIndex = 2;
			this.btnForward.TabStop = false;
			this.btnForward.Text = ">";
			this.btnForward.UseVisualStyleBackColor = true;
			// 
			// panBrowser
			// 
			this.panBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panBrowser.Location = new System.Drawing.Point(0, 34);
			this.panBrowser.Name = "panBrowser";
			this.panBrowser.Size = new System.Drawing.Size(762, 445);
			this.panBrowser.TabIndex = 5;
			// 
			// mnuChangeUserAgent
			// 
			this.mnuChangeUserAgent.Name = "mnuChangeUserAgent";
			this.mnuChangeUserAgent.Size = new System.Drawing.Size(176, 22);
			this.mnuChangeUserAgent.Text = "Change User Agent";
			this.mnuChangeUserAgent.Click += new System.EventHandler(this.MnuChangeUserAgentClick);
			// 
			// fWebBrowser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 479);
			this.Controls.Add(this.panBrowser);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fWebBrowser";
			this.Text = "CxBrowser 2";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picReload)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem mnuChangeUserAgent;
		private System.Windows.Forms.ToolStripMenuItem mnuAlwaysOnTop;
		private System.Windows.Forms.ToolStripMenuItem mnuWindowManager;
		private System.Windows.Forms.Panel panBrowser;
		private System.Windows.Forms.Button btnForward;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.PictureBox picReload;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripDropDownButton btnMenu;
		private System.Windows.Forms.ToolStripMenuItem mnuNewWindow;
		private System.Windows.Forms.ToolStripDropDownButton btnTools;
		private System.Windows.Forms.ToolStripMenuItem mnuDeveloperTools;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
