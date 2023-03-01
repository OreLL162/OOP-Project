using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static carProject.Class1;
using System.Media;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;
namespace carProject
{
    public partial class formSuv : Form
    {
        //static List<String> Suvlist = new List<string>();
        private SoundPlayer soundPlayer;
        private SoundPlayer soundPlayerSold;
        static List<Suv> SuvObjectlist = new List<Suv>();
        BindingSource suvBindingSource = new BindingSource();
         Suv one = new Suv();
        
        public formSuv()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("Call On Me.wav");
            soundPlayerSold = new SoundPlayer("Sold.wav");
            one._licensPlate = "A342F3";
            one._color = "Red";
            one._doors = 5; 
            one._height = 19;
            SuvObjectlist.Add(one);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            this.Hide();
            formHome home = new formHome();
            home.Show();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove the car?", "Removing Sedan Car!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (listofsuv.SelectedIndex == -1)
                    MessageBox.Show("Must select item");
                if (listofsuv.SelectedIndex > -1)
                    SuvObjectlist.RemoveAt(listofsuv.SelectedIndex);
                suvBindingSource.ResetBindings(false);
            }
            else if (dialogResult == DialogResult.No)
            {
                //
            }
        }

        private void Addsedan_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            Suv suvObject = new Suv();
            suvObject._color = colorbox.Text;
            if (DoorBox.Text == "")
                suvObject._doors = 0;
            else
                suvObject._doors = (Convert.ToInt32(DoorBox.Text));
            suvObject._gear = gearBox.Text;
            if (txtboxseadanlplate.Text == "")
                suvObject._licensPlate = "999999";
            else
                suvObject._licensPlate = (txtboxseadanlplate.Text);
            if (heightBox.Text == "")
                suvObject._height = 0.0;
            else
                suvObject._height= Convert.ToInt32(heightBox.Text);
            if (yearBox.Text != "")
                suvObject._year = Convert.ToInt32(yearBox.Text);
            //listofsuv.Items.Add(suvObject.ToString());
           // Suvlist.Add(suvObject.ToString());
            SuvObjectlist.Add(suvObject);
            suvBindingSource.ResetBindings(false);

        }



        private void listofsuv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void yearBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formSuv_Load(object sender, EventArgs e)
        {
            suvBindingSource.DataSource = SuvObjectlist;
            listofsuv.DataSource = suvBindingSource;
        }

        private void formSuv_Activated(object sender, EventArgs e)
        {
            suvBindingSource.ResetBindings(false);
        }

        private void soldbtn_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to sell the car? file of selling details will add auto", "Selling Suv Car!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (listofsuv.SelectedIndex == -1)
                    MessageBox.Show("Must select item");
                if (listofsuv.SelectedIndex > -1)
                {
                    soundPlayerSold.Play();
                    StreamWriter sw = new StreamWriter(Application.StartupPath + "\\sold\\" + SuvObjectlist[listofsuv.SelectedIndex]._licensPlate + ".txt");
                    DateTime now = DateTime.Now;
                    sw.WriteLine("Licens Number:" + SuvObjectlist[listofsuv.SelectedIndex]._licensPlate);
                    sw.WriteLine("Year:" + SuvObjectlist[listofsuv.SelectedIndex]._year);
                    sw.WriteLine("Color:" + SuvObjectlist[listofsuv.SelectedIndex]._color);
                    sw.WriteLine("Doors number:" + SuvObjectlist[listofsuv.SelectedIndex]._doors);
                    sw.WriteLine("Gear Type:"+SuvObjectlist[listofsuv.SelectedIndex]._gear);
                    sw.WriteLine("Height:"+SuvObjectlist[listofsuv.SelectedIndex]._height);
                    sw.WriteLine(now.ToString());
                    sw.WriteLine("**********SUV SOLD**********");
                    SuvObjectlist.RemoveAt(listofsuv.SelectedIndex);
                    sw.Close();

                }
                suvBindingSource.ResetBindings(false);
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
                    formatter.Serialize(stream, listofsuv);
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
                SuvObjectlist = (List<Suv>)binaryFormatter.Deserialize(stream);
                listofsuv.Invalidate();
                suvBindingSource.ResetBindings(false);
                this.Hide();
                formHome home = new formHome();
                home.Show();
            }
        }
    }
}
