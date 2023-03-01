using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace carProject
{
    public partial class formHome : Form
    {
        private SoundPlayer soundPlayer;
        public formHome()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("Call On Me.wav");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buyoptionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void SedanBtn_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            this.Hide();
            formSedan sedan = new formSedan();
            sedan.Show();


        }

        private void SunBtn_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            this.Hide();
            formSuv suv = new formSuv();
            suv.Show();
        }

        private void MotorBtn_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            this.Hide();
            formMotor motor = new formMotor();
            motor.Show();
        }
    }
}
