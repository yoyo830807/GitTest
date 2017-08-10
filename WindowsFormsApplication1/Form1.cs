using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private bool _IsWorking = false;
        private bool _IsCalucuateSummary = false;
        private bool[] flag = new bool[] { false, false };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int n = 7;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int i = n - 1; i < n; i--)
            {
                for (int j = i - 1; j <= i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }







            //_IsWorking = false;
            //this.timer1.Interval = 1000 * 5;
            //this.timer1.Enabled = true;

            //int width = 5;
            //if (width % 2 == 0)
            //{
            //    return;
            //}

            //var count = 0;
            //for (var i = width; i > 0; i = i - 2)
            //{
            //    print(i, count);
            //    count++;
            //}



            //List<string> tmp = new List<string>();
            //tmp.Add("1");
            //tmp.Add("2");
            //tmp.Add("A");
            //tmp.Add("a");
            //tmp.Add("B");
            //tmp.Add("b");
            //var obj = tmp.OrderBy(x => x, StringComparer.Ordinal).ToList();

            //List<string> tmp = new List<string>();
            //tmp.Add("012/");
            //tmp.Add("012.11/");
            //tmp.Add("012.12/");
            //var obj = tmp.OrderBy(x => x, StringComparer.InvariantCultureIgnoreCase).ToList();

            //List<string> tmp = new List<string>();
            //tmp.Add("012/12");
            //tmp.Add("012\\11/12");
            //tmp.Add("012\\12/12");

            //var obj = tmp.OrderBy(x=>x).ToList();
            //var nobj = obj.Select(x => x.Replace("\\", ".")).ToList();


            //List<string> tmp1 = new List<string>();
            //tmp1.Add("012\\");
            //tmp1.Add("012.11\\");
            //tmp1.Add("012.12\\");

            //var obj1 = tmp1.OrderBy(x => x).ToList();
        }

        public void print(int total,int count)
        {
            for (var i = 0; i < count; i++)
            {
                Console.Write(" ");
            }

            for (var i = 0; i < total; i++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            _IsCalucuateSummary = (now.Hours == 10);

            if (now.Seconds == 0)
            {
                flag[0] = false;
                flag[1] = false;
            }

            Do();

            //if ((now.Seconds == 10 || now.Seconds == 40) && now.Minutes < 5) Do();
        }

        private void Do()
        {
            if (_IsWorking) return;
            if (flag[0]) return;

            _IsWorking = true;

            System.Threading.Thread.Sleep(10000);

            flag[0] = true;
            _IsWorking = false;

        }
    }
}
