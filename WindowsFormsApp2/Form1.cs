using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        Level level1 = new Level("Level 1", 100, 100, 0, 20);
        Level level2 = new Level("Level 2", 100, 200, 0, 20);
        Level level3 = new Level("Level 3", 100, 300, 0, 20);
        Level break1 = new Level("Break 1", 100, 300, 300, 10);
        Level level4 = new Level("Level 4", 100, 300, 300, 20);
        Level level5 = new Level("Level 5", 200, 400, 400, 20);
        Level level6 = new Level("Level 6", 300, 600, 600, 20);
        Level break2 = new Level("Break 2", 400, 800, 800, 10);
        Level level7 = new Level("Level 7", 400, 800, 800, 15); 
        Level level8 = new Level("Level 8", 500, 1000, 1000, 15);
        Level level9 = new Level("Level 9", 600, 1200, 1200, 15);
        Level level10 = new Level("Level 10", 800, 1600, 1600, 15);
        Level break3 = new Level("Break 3", 1000, 2000, 2000, 10);
        Level level11 = new Level("Level 11", 1000, 2000, 2000, 15);
        Level level12 = new Level("Level 12", 1000, 3000, 3000, 15);
        Level level13 = new Level("Level 13", 2000, 4000, 4000, 15);
        Level level14 = new Level("Level 14", 3000, 6000, 6000, 15);
        Level break4 = new Level("Break 4", 4000, 8000, 8000, 10);
        Level level15 = new Level("Level 15", 4000, 8000, 8000, 15);
        Level level16 = new Level("Level 16", 5000, 10000, 10000, 15);
        Level level17 = new Level("Level 17", 8000, 16000, 16000, 15);
        Level level18 = new Level("Level 18", 10000, 20000, 20000, 15);
        Level level19 = new Level("Level 19", 15000, 30000, 30000, 15);
        Level level20 = new Level("Level 20", 20000, 40000, 40000, 15);
        Level level21 = new Level("Level 21", 30000, 60000, 60000, 15);
        Level level22 = new Level("Level 22", 40000, 80000, 80000, 15);
        Level level23 = new Level("Level 23", 50000, 100000, 100000, 15);

        private int quick = 1200000;
       

        public Form1()
        {
            InitializeComponent();

    }


        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            quick--;
            int sec = (quick / 1000) % 60;
            int min = (quick / 1000) / 60;
            label2.Text = min + " : " + sec;


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
