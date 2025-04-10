using System;
using System.Windows.Forms;

namespace CISP.UI
{
	public partial class Start : Form
	{
		public Start()
		{
			InitializeComponent();
		}

		#region handle button, click events

		// handle david button, click event
		private void button1_Click(object sender, EventArgs e)
		{	
			this.Close();
		}

		// handle them button, click event
		private void button2_Click(object sender, EventArgs e)
		{	// dialog result of cancel, means opponent going first
			this.Close();
		}

        #endregion

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
