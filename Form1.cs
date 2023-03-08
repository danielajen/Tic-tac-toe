using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    public partial class Form1 : Form
    {
        string turn = "x";
        int count = 0;
        string [] spots = { "a", "b", "c", "d", "e", "f", "g", "h", "i"}
        char[] board = { 'x' };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void click(object sender, EventArgs e)
        {
            PictureBox picked = (PictureBox)sender;
            count++;
            char[] picname = picked.Name.ToCharArray();
            int numname = int.Parse(picname[1].ToString());
            switch (turn)
            {
                case "x":
                    picked.BackgroundImage = Properties.Resources.png_clipart_black_x_mark_tic_tac_toe_oxo_holiday_tic_tac_toe_game_blue_cross_miscellaneous_angle;
                    picked.Enabled = false;
                    break;
                case "o":
                    picked.BackgroundImage = Properties.Resources.o_300x300;
                    picked.Enabled = false;
                    break;
            }


            }
        }
    }

