using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day20_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitm = new Bitmap("test.jpg");
            SetClientSizeCore(bitm.Width, bitm.Height); // client 영역 설정(이미지의 너비, 높이)
            e.Graphics.DrawImage(bitm, 0, 0);
        }
    }
}
