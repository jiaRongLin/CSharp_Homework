using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloPage
{
	public partial class HelloPage : Form
	{
		public HelloPage()
		{
			InitializeComponent();
			this.Load += HelloPage_Load;
		}

		private void HelloPage_Load(object sender, EventArgs e)
		{
			
		}
	}
}
