using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Type tip = typeof(int);
            MethodInfo[] metotlar = tip.GetMethods();
            int toplamMetot = 0;
            foreach (MethodInfo bilgi in metotlar)
            {
                listBox1.Items.Add("Metot adı:" + bilgi.Name);
                listBox1.Items.Add("Metot geri dönüş tipi:"+bilgi.ReturnType);
                if (bilgi.IsStatic)
                {
                    listBox1.Items.Add("Metot tipi sitatic");
                }
                else
                {
                    listBox1.Items.Add("Metot tipi instance");

                }
                toplamMetot++;
               


            }
            MessageBox.Show("Toplam metot sayısı:" + toplamMetot.ToString());
        }
    }
}
