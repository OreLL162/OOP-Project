using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static carProject.Class1;
using System.IO;
using System.Media;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;
namespace carProject
{
    public partial class formMotor : Form
    {
        private SoundPlayer soundPlayer;
        private SoundPlayer soundPlayerSold;
        static List<Motorcycl> MotorList = new List<Motorcycl>();
        BindingSource motorBindingSource = new BindingSource();
        public formMotor()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("Call On Me.wav");
            soundPlayerSold = new SoundPlayer("Sold.wav");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            this.Hide();
            formHome home = new formHome();
            home.Show();
        }

        private void GEARLABEL_Click(object sender, EventArgs e)
        {

        }

        private void Addsedan_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            Motorcycl motorObject = new Motorcycl();
            motorObject._color = colorbox.Text;
            motorObject._gear = gearBox.Text;
            if (txtboxMOTORlplate.Text == "")
                motorObject._licensPlate = "999999";
            else
                motorObject._licensPlate = (txtboxMOTORlplate.Text);
            if (windshildbox.Text == "")
                motorObject._windshield = "Not Available";
            if (handlebarbox.Text != "")
                motorObject._handlebar = yearBox.Text;
            // listboxofsedan.Items.Add(sedanObject.ToString());
            MotorList.Add(motorObject);
            motorBindingSource.ResetBindings(false);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove the Motorcycle?", "Removing Motorcycle!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (listboxofmotor.SelectedIndex == -1)
                    MessageBox.Show("Must select item");
                if (listboxofmotor.SelectedIndex > -1)
                    MotorList.RemoveAt(listboxofmotor.SelectedIndex);
                motorBindingSource.ResetBindings(false);
            }
            else if (dialogResult == DialogResult.No)
            {
                //
            }
        }

        private void formMotor_Load(object sender, EventArgs e)
        {
            motorBindingSource.DataSource = MotorList;
            listboxofmotor.DataSource = motorBindingSource;

        }

        private void formMotor_Activated(object sender, EventArgs e)
        {
            motorBindingSource.ResetBindings(false);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void soldbtn_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to sell the motorcycle? file of selling details will add auto", "Selling Motorcycle!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (listboxofmotor.SelectedIndex == -1)
                    MessageBox.Show("Must select item");
                if (listboxofmotor.SelectedIndex > -1)
                {
                    soundPlayerSold.Play();
                    StreamWriter sw = new StreamWriter(Application.StartupPath + "\\sold\\" + MotorList[listboxofmotor.SelectedIndex]._licensPlate + ".txt");
                    DateTime now = DateTime.Now;
                    sw.WriteLine("Licens Number:" + MotorList[listboxofmotor.SelectedIndex]._licensPlate);
                    sw.WriteLine("Year:" + MotorList[listboxofmotor.SelectedIndex]._year);
                    sw.WriteLine("Color:" + MotorList[listboxofmotor.SelectedIndex]._color);
                    sw.WriteLine("Handlebar Type:"+MotorList[listboxofmotor.SelectedIndex]._handlebar);
                    sw.WriteLine("Gear Type:" + MotorList[listboxofmotor.SelectedIndex]._gear);
                    sw.WriteLine(MotorList[listboxofmotor.SelectedIndex]._windshield);
                    sw.WriteLine(now.ToString());
                    sw.WriteLine("**********MOTORCYCLE SOLD**********");
                    MotorList.RemoveAt(listboxofmotor.SelectedIndex);
                    sw.Close();

                }
                motorBindingSource.ResetBindings(false);
            }
            else if (dialogResult == DialogResult.No)
            {
                //
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "model files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, MotorList);
                }
            }
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "model files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                MotorList = (List<Motorcycl>)binaryFormatter.Deserialize(stream);
                listboxofmotor.Invalidate();
                motorBindingSource.ResetBindings(false);
                this.Hide();
                formHome home = new formHome();
                home.Show();
            }
        }
    }
}