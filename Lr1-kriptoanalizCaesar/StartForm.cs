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

    public partial class StartForm : Form
    {
        Coder coder;
        FileHandler fileHandler;

        public StartForm(Coder c, FileHandler f)
        {
            coder = c;
            fileHandler = f;
            InitializeComponent();
        }

        private void btnShiftMethod_Click(object sender, EventArgs e)
        {
            Form f1 = new FormShift(coder, fileHandler);
            f1.ShowDialog();
        }

        private void btnFrequancyMethod_Click(object sender, EventArgs e)
        {
            Form f1 = new FormFrequancy(coder, fileHandler);
            f1.ShowDialog();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
