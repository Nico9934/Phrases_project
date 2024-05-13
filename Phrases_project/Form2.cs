using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phrases_project
{
	public partial class msg : Form
	{

		private string[] ary_list;
		private Form1 form1; 
		public msg(string[] ary_list, Form1 form1)
		{
			InitializeComponent();
			this.ary_list = ary_list;
			this.form1 = form1;
		}

		private void msg_Load(object sender, EventArgs e)
		{

		}

		private void btn_accept_Click(object sender, EventArgs e)
		{
			//ary_list[0] = "Esta es la primer frase";

			form1.list_phrases.Items.Add("");
			

			this.Close();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			
			this.Close(); 
		}
	}
}
