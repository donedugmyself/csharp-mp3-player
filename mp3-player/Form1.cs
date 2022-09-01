using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mp3_player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            for (int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
            {
                lbxSongs.Items.Add(openFileDialog1.SafeFileNames[i].ToString());
                lbxAdresses.Items.Add(openFileDialog1.FileNames[i].ToString());
            }
        }

        private void lbxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxAdresses.SelectedIndex = lbxSongs.SelectedIndex;
            axWindowsMediaPlayer1.URL = lbxAdresses.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/umtyurdugul");
        }

        private void volUp_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume += 10;
        }

        private void volDown_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume -= 10;
        }
    }
    }

