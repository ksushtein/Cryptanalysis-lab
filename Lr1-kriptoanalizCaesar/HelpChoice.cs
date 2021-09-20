using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr1_kriptoanalizCaesar
{
    public partial class HelpChoice : Form
    {

        public HelpChoice(Coder coder, string message)
        {
            InitializeComponent();
            richTextBox1.Text = coder.HelpChooseByFrequancyTable(message);
        }

        private void HelpChoice_Load(object sender, EventArgs e)
        {
            
        }
    }
}
