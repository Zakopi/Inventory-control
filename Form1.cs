using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Tom\source\repos\Inventory control\test.txt";

            // ファイルを書き込みモード開く
            StreamWriter writer = new StreamWriter(filePath, true, Encoding.GetEncoding("Shift_JIS"));

            string str = Console.ReadLine();

            // ファイルに書き込む
            writer.WriteLine(str);
            // ファイルを閉じる
            writer.Close();

            StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding("Shift_JIS"));

            while (reader.Peek() >= 0)
            {
                string[] cols = reader.ReadLine().Split(',');
                for (int n = 0; n < cols.Length; n++)
                    Console.Write(cols[n] + "\t");
                Console.WriteLine("");
            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
