using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_tool_of_Automatic_design_ver1._0
{
    public partial class Automatic_design : Form
    {

        public Automatic_design()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //콤보박스의 인덱스 변경시 폼의 내용 변경
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = null;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Properties.Resources.shop2;
            }
        }

    }
}

