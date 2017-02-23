using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SendKey
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			textBox1.Text = @"%+{F14}";
			label1.Text = "^ = CTRL\n% = ALT\n+ = SHIFT\n{KEY}";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SendKeys.Send(textBox1.Text);
			GC.Collect();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
