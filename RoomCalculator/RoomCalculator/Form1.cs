using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variables

            float roomLength;
            float roomWidth;
            float roomArea;

            //Input length

            roomLength = float.Parse(txtRoomLength.Text);

            //Input width

            roomWidth = float.Parse(txtRoomWidth.Text);

            //Calculate room area

            roomArea = roomLength * roomWidth;

            //Output room area

            txtRoomArea.Text = roomArea.ToString();
        }

        private void btnCalculateVolume_Click(object sender, EventArgs e)
        {
            //Variables

            float roomLength;
            float roomWidth;
            float roomHeight;
            float roomVolume;

            //Input length

            roomLength = float.Parse(txtRoomLength.Text);

            //Input width

            roomWidth = float.Parse(txtRoomWidth.Text);

            //Input height

            roomHeight = float.Parse(txtRoomHeight.Text);

            //Calculate room volume

            roomVolume = roomLength * roomWidth * roomHeight;

            //Output room volume

            txtRoomVolume.Text = roomVolume.ToString();
        }
    }
}
