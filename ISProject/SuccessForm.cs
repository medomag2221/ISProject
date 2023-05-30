using ISProject.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISProject
{
    public partial class SuccessForm : Form
    {
        public SuccessForm(Form owner, string message)
        {
            InitializeComponent();
            Owner = owner;
            TextLabel.Text = message;
        }

        private void OkButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
