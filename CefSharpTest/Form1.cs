using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CefSharpTest
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        public Form1()
        {
            InitializeComponent();

            // At the inicialization, start chromium
            InitializeChromium();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();

            // Initialize Cef with the provided settings
            Cef.Initialize(settings);

            // Create a browser component and provide a start web URL
            chromeBrowser = new ChromiumWebBrowser("http://www.uol.com.br");

            // Add the browser to form
            this.Controls.Add(chromeBrowser);

            // Make the browser fill the form
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
