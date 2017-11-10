using System;
using System.Windows.Forms;

namespace Hex0x
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			string out_text = "";
			string buffer;

			try {
				string[] bin_data = textBox1.Text.Split(',');

				foreach(var data in bin_data) {
					buffer = data;
					buffer = buffer.Trim();
					buffer = buffer.Replace("0x", "");
					out_text += buffer + " ";
				}
			} catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}

			out_text = out_text.Trim();
			textBox2.Text = out_text;
		}

		private void button2_Click(object sender, EventArgs e) {
			string out_text = "";

			try {
				string[] bin_data = textBox3.Text.Split(' ');

				foreach(var data in bin_data) {
					out_text += "0x" + data + ", ";
				}
			} catch(Exception ex) {
				MessageBox.Show(ex.ToString());
			}

			out_text = out_text.Trim();
			out_text = out_text.Trim(',');
			textBox4.Text = out_text;
		}

		void textbox_SelectAll(TextBox textbox, KeyEventArgs e) {
			if(e.Control && (e.KeyCode == Keys.A)) {
				textbox.SelectAll();
			}
		}

		private void textBox2_KeyDown(object sender, KeyEventArgs e) {
			textbox_SelectAll((TextBox)sender, e);
		}

		private void textBox4_KeyDown(object sender, KeyEventArgs e) {
			textbox_SelectAll((TextBox)sender, e);
		}
	}
}
