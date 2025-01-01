using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PRL
{

    public partial class FormCamera : Form
    {
        public FormCamera()
        {
            InitializeComponent();
        }




        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "D:\\3.2-Du An 1";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void FormCamera_Load(object sender, EventArgs e)
        {

        }
    }
}
