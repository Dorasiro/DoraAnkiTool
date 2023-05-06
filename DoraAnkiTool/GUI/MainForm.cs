using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoraAnkiTool.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = new AnkiToolMain();
            var l = a.GetAllThemeDictionalies();
            foreach(var elem in l)
            {
                Debug.WriteLine("単語：" + elem.Word + "　　　意味：" + elem.Mean);
            }
        }
    }
}
