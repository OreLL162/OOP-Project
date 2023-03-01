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
using System.Media;
using System.IO;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;
namespace carProject
{
    
    public partial class formSedan : Form
    {
        private SoundPlayer soundPlayer;
        private SoundPlayer soundPlayerSold;
         static List<Sedan> SedanObjectList = new List<Sedan>();
        // static List<Sedan> SedanObjectList=new List<Sedan>
        BindingSource sedanBindingSource = new BindingSource();
        public formSedan()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("Call On Me.wav");
            soundPlayerSold = new SoundPlayer("Sold.wav");
            //SedanList.Add("CHECK");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Addsedan_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            Sedan sedanObject = new Sedan();
            sedanObject._color = colorbox.Text;
            if (DoorBox.Text != "")
                sedanObject._doors = Convert.ToInt32(DoorBox.Text);
            sedanObject._gear = gearBox.Text;
            if (txtboxseadanlplate.Text == "")
                sedanObject._licensPlate = "999999";
            else
                sedanObject._licensPlate = (txtboxseadanlplate.Text);
            if (SunRoofBox.Text == "")
                sedanObject._sunroof = "Not Available";
            if (SunRoofBox.Text != "")
                sedanObject._year = Convert.ToInt32(yearBox.Text);
            // listboxofsedan.Items.Add(sedanObject.ToString());
            SedanObjectList.Add(sedanObject);
            sedanBindingSource.ResetBindings(false);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove the car?", "Removing Sedan Car!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (listboxofsedan.SelectedIndex == -1)
                    MessageBox.Show("Must select item");
                if (listboxofsedan.SelectedIndex > -1)
                    SedanObjectList.RemoveAt(listboxofsedan.SelectedIndex);
                sedanBindingSource.ResetBindings(false);
            }
            else if (dialogResult == DialogResult.No)
            {
                //
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            this.Hide();
            formHome home = new formHome();
            home.Show();

        }

        private void listofcars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formSedan_Load(object sender, EventArgs e)
        {
            //add the sedans in to the list box

            //set the data source for the binding
             sedanBindingSource.DataSource = SedanObjectList;
            //set the binding to the listbox
            listboxofsedan.DataSource = sedanBindingSource;
            
        }

        private void formSedan_Activated(object sender, EventArgs e)
        {
            sedanBindingSource.ResetBindings(false);
            soundPlayer.Play();

        }

        private void soldbtn_Click(object sender, EventArgs e)
        {
            //soundPlayer.Play();
            //DialogResult dialogResult = MessageBox.Show("Are you sure you want to sell the car? file of selling details will add auto", "Selling Sedan Car!", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    if (listboxofsedan.SelectedIndex == -1)
            //        MessageBox.Show("Must select item");
            //    if (listboxofsedan.SelectedIndex > -1)
            //    {
            //        soundPlayerSold.Play();
            //        StreamWriter sw = new StreamWriter(Application.StartupPath + "\\sold\\" + SedanObjectList[listboxofsedan.SelectedIndex]._licensPlate + ".txt");
            //        DateTime now = DateTime.Now;
            //        sw.WriteLine("Licens Number:"+SedanObjectList[listboxofsedan.SelectedIndex]._licensPlate);
            //        sw.WriteLine("Year:"+SedanObjectList[listboxofsedan.SelectedIndex]._year);
            //        sw.WriteLine("Color:"+SedanObjectList[listboxofsedan.SelectedIndex]._color);
            //        sw.WriteLine("Doors number:"+SedanObjectList[listboxofsedan.SelectedIndex]._doors);
            //        sw.WriteLine("Gear Type:"+SedanObjectList[listboxofsedan.SelectedIndex]._gear);
            //        sw.WriteLine(SedanObjectList[listboxofsedan.SelectedIndex]._sunroof);
            //        sw.WriteLine(now.ToString());
            //        sw.WriteLine("**********SEDAN SOLD**********");
            //        SedanObjectList.RemoveAt(listboxofsedan.SelectedIndex);
            //        sw.Close();

            //    }
            //    sedanBindingSource.ResetBindings(false);
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    //
            //}
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
                    formatter.Serialize(stream, SedanObjectList);
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
                SedanObjectList = (List<Sedan>)binaryFormatter.Deserialize(stream);
                listboxofsedan.Invalidate();
                sedanBindingSource.ResetBindings(false);
                this.Hide();
                formHome home = new formHome();
                home.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to sell the car? file of selling details will add auto", "Selling Sedan Car!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (listboxofsedan.SelectedIndex == -1)
                    MessageBox.Show("Must select item");
                if (listboxofsedan.SelectedIndex > -1)
                {
                    soundPlayerSold.Play();
                    StreamWriter sw = new StreamWriter(Application.StartupPath + "\\sold\\" + SedanObjectList[listboxofsedan.SelectedIndex]._licensPlate + ".txt");
                    DateTime now = DateTime.Now;
                    sw.WriteLine("Licens Number:" + SedanObjectList[listboxofsedan.SelectedIndex]._licensPlate);
                    sw.WriteLine("Year:" + SedanObjectList[listboxofsedan.SelectedIndex]._year);
                    sw.WriteLine("Color:" + SedanObjectList[listboxofsedan.SelectedIndex]._color);
                    sw.WriteLine("Doors number:" + SedanObjectList[listboxofsedan.SelectedIndex]._doors);
                    sw.WriteLine("Gear Type:" + SedanObjectList[listboxofsedan.SelectedIndex]._gear);
                    sw.WriteLine(SedanObjectList[listboxofsedan.SelectedIndex]._sunroof);
                    sw.WriteLine(now.ToString());
                    sw.WriteLine("**********SEDAN SOLD**********");
                    SedanObjectList.RemoveAt(listboxofsedan.SelectedIndex);
                    sw.Close();

                }
                sedanBindingSource.ResetBindings(false);
            }
            else if (dialogResult == DialogResult.No)
            {
                //
            }

        }
    }
}
