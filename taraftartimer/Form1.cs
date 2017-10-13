using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taraftartimer
{
    public partial class Form1 : Form
    {
        List<Button> group1, group2;
        List<Color> gscolor = new List<Color>()
        {
            Color.Red,Color.Yellow
        };
        List<Color> Fbcolor = new List<Color>()
        {
            Color.Blue,Color.Yellow
        };
        List<Color> BJKcolor = new List<Color>()
        {
            Color.Black,Color.White
        };
        List<Color> TScolor = new List<Color>()
        {
            Color.Maroon,Color.Blue
        };
        List<Color> currentcolor;

        public Form1()
        {        
            InitializeComponent();
            group1 = new List<Button>()
            {
                button1,button6,button2,button5
            };
            group2 = new List<Button>()
            {
                button3,button4,button7,button8
            };
        }
        int saniye = 0;
 
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(label1.Text);
            saniye++;
            label1.Text = saniye.ToString();
            setcolor(group1, (saniye % 10 < 5 ? currentcolor[0] : currentcolor[1]));
            setcolor(group2, (saniye % 10 < 5 ? currentcolor[1] : currentcolor[0]));
        }

        public void setcolor(List<Button> btnlist, Color color)
        {
            foreach (var item in btnlist)
            {
                item.BackColor = color;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            currentcolor = Fbcolor;
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\Mehmet\\Desktop\\marşlar\\fb.mp3";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            currentcolor = BJKcolor;
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\Mehmet\\Desktop\\marşlar\\bjk.mp3";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            currentcolor = TScolor;
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\Mehmet\\Desktop\\marşlar\\ts.mp3";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            currentcolor = gscolor;
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL="C:\\Users\\Mehmet\\Desktop\\marşlar\\gs.mp3";
        }
    

      
    }
}
