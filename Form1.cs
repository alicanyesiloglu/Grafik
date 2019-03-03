using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d_57_Chart_Grafik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
            // Chart ekledikten sonra proportiesten Series yanındaki 3 noktayı seçip uygun grafiği seçiyoruz.
        {
            chart1.Series["Kitap"].Points.AddXY("Akdeniz", 5);

            chart1.Series["Kitap"].Points.AddXY("Karadeniz", 8);
            chart1.Series["Kitap"].Points.AddXY("Marmara", 15);
        }
    }
}
