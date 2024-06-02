using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjArrayList1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //Criado lista
        List<int> lst = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lst.Add(5);
            lst.Add(11);
            lst.Add(20);


            lbl2.Text = "";
            for (int i = 0; i < lst.Count; i++)
            {
                lbl2.Text = lbl2.Text + lst.ElementAt(i) + ", ";
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //Mostrar a posição que o elemento esta dentro da lista
            int num = int.Parse(txtValor1.Text);
            int pos = -1;

            for (int i = 0; i < lst.Count; i++)
            {
                if(num == lst.ElementAt(i))
                {
                    pos = i;
                }
            }
            MessageBox.Show(pos + "");

        }
    }
}
