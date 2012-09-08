/*
 * Created by SharpDevelop.
 * User: Miguel
 * Date: 14/08/2012
 * Time: 07:17 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.Example;

namespace CxBrowser2
{
	/// <summary>
	/// Description of fWebBrowser.
	/// </summary>
	public partial class fWebBrowser : Form, IExampleView, ILifeSpanHandler
	{	
		private fWManager fWmag;
		private int IdWindow;
		
		void MnuAboutClick(object sender, EventArgs e)
		{
			fAbout f = new fAbout();
			f.Show();
		}
		
		public event EventHandler ShowDevToolsActivated
        {
            add { mnuDeveloperTools.Click += value; }
            remove { mnuDeveloperTools.Click -= value; }
        }

        public event EventHandler CloseDevToolsActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler ExitActivated
        {
            add { mnuExit.Click += value; }
            remove { mnuExit.Click -= value; }
        }

        public event EventHandler UndoActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler RedoActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler CutActivated
        {
           add {  }
            remove {  }
        }

        public event EventHandler CopyActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler PasteActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler DeleteActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler SelectAllActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler TestResourceLoadActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler TestSchemeLoadActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler TestExecuteScriptActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler TestEvaluateScriptActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler TestBindActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler TestConsoleMessageActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler TestTooltipActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler TestPopupActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler TestLoadStringActivated
        {
            add {  }
            remove {  }
        }

        public event EventHandler TestCookieVisitorActivated
        {
            add {  }
            remove {  }
        }

        public event Action<object, string> UrlActivated;

        public event EventHandler BackActivated
        {
            add { btnBack.Click += value; }
            remove { btnBack.Click -= value; }
        }

        public event EventHandler ForwardActivated
        {
            add { btnForward.Click += value; }
            remove { btnForward.Click -= value; }
        }
        
        private readonly WebView web_view;

        public fWebBrowser(fWManager f, int IdWindowManager, bool IsPopupWnd, string urlpopup)
        {
            InitializeComponent();            
            
            this.fWmag = f;
            this.IdWindow = IdWindowManager;
            
            if (IsPopupWnd==true)
            {
            	web_view = new WebView(urlpopup, new BrowserSettings());
            	web_view.Dock = DockStyle.Fill;
	            web_view.LifeSpanHandler = this;
	            
	            //BrowserSettings s = new BrowserSettings();
	           
	            
	            this.panBrowser.Controls.Add(web_view);
	            
	            var presenter = new ExamplePresenter(web_view, this,
	                invoke => Invoke(invoke));
            }
            else
            {
            	web_view = new WebView("https://www.google.com", new BrowserSettings());
	            web_view.Dock = DockStyle.Fill;
	            web_view.LifeSpanHandler = this;
	            
	            this.panBrowser.Controls.Add(web_view);
	            
	            var presenter = new ExamplePresenter(web_view, this,
	                invoke => Invoke(invoke));
            }

            
        }

        public void SetTitle(string title)
        {
        	Text = title + " - CxBrowser 2";
        }

        public void SetAddress(string address)
        {
            txtURL.Text = address;
        }

        public void SetCanGoBack(bool can_go_back)
        {
            btnBack.Enabled = can_go_back;
        }

        public void SetCanGoForward(bool can_go_forward)
        {
            btnForward.Enabled = can_go_forward;
        }

        public void SetIsLoading(bool is_loading)
        {
            /*goButton.Text = is_loading ?
                "Stop" :
                "Go";
            goButton.Image = is_loading ?
                Properties.Resources.nav_plain_red :
                Properties.Resources.nav_plain_green;

            HandleToolStripLayout();*/
            this.progressBar1.Visible = is_loading;
        }

        public void ExecuteScript(string script)
        {
            web_view.ExecuteScript(script);
        }

        public object EvaluateScript(string script)
        {
            return web_view.EvaluateScript(script);
        }

        public void DisplayOutput(string output)
        {
            //this.txtStatus.Text = output;
        }

        /*private void HandleToolStripLayout(object sender, LayoutEventArgs e)
        {
            HandleToolStripLayout();
        }*/

        /*private void HandleToolStripLayout()
        {
            var width = toolStrip1.Width;
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item != urlTextBox)
                {
                    width -= item.Width - item.Margin.Horizontal;
                }
            }
            urlTextBox.Width = Math.Max(0, width - urlTextBox.Margin.Horizontal - 18);
        }*/

        /*private void HandleGoButtonClick(object sender, EventArgs e)
        {
            var handler = this.UrlActivated;
            if (handler != null)
            {
            	handler(this, txtURL.Text);
            }
        }*/

        /*private void UrlTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            var handler = UrlActivated;
            if (handler != null)
            {
                handler(this, txtURL.Text);
            }
        }*/
		
		void TxtURLKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            var handler = UrlActivated;
            if (handler != null)
            {
            	handler(this, this.txtURL.Text);
            }
		}
		
		void MnuNewWindowClick(object sender, EventArgs e)
		{
			this.fWmag.NewWindow();
		}
		
		public bool OnBeforePopup(IWebBrowser browser, string url, ref int x, ref int y, ref int width, ref int height)
    	{	
			if(url.LastIndexOf("devtools://devtools/devtools.html")>0)
			{
				return false;
			}
			else
			{
				this.fWmag.NewWindow(url,x,y,width,height);
				return true;
			}
    	}
		
		void MnuWindowManagerClick(object sender, EventArgs e)
		{
			this.fWmag.Show();
			this.fWmag.Activate();
		}
		
		void MnuAlwaysOnTopClick(object sender, EventArgs e)
		{
			mnuAlwaysOnTop.Checked = !mnuAlwaysOnTop.Checked;
			this.TopMost = mnuAlwaysOnTop.Checked;
		}
		
		void MnuChangeUserAgentClick(object sender, EventArgs e)
		{
			
		}
	}
}
