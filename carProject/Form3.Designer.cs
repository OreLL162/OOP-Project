
namespace carProject
{
    partial class formSedan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSedan));
            this.homeBtn = new System.Windows.Forms.Button();
            this.sedanDetails = new System.Windows.Forms.Label();
            this.DoorsLabel = new System.Windows.Forms.Label();
            this.YEARLABEL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GEARLABEL = new System.Windows.Forms.Label();
            this.LIECENSELABEL = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.colorbox = new System.Windows.Forms.ComboBox();
            this.gearBox = new System.Windows.Forms.ComboBox();
            this.DoorBox = new System.Windows.Forms.ComboBox();
            this.SunRoofBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Addsedan = new System.Windows.Forms.Button();
            this.nolabel = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.sunrooflabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxseadanlplate = new System.Windows.Forms.TextBox();
            this.listboxofsedan = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homeBtn
            // 
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Location = new System.Drawing.Point(127, -102);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(102, 101);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "HOME";
            this.homeBtn.UseVisualStyleBackColor = true;
            // 
            // sedanDetails
            // 
            this.sedanDetails.AutoSize = true;
            this.sedanDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sedanDetails.Location = new System.Drawing.Point(12, 214);
            this.sedanDetails.Name = "sedanDetails";
            this.sedanDetails.Size = new System.Drawing.Size(337, 32);
            this.sedanDetails.TabIndex = 2;
            this.sedanDetails.Text = "Select Sedan car details :";
            // 
            // DoorsLabel
            // 
            this.DoorsLabel.AutoSize = true;
            this.DoorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoorsLabel.Location = new System.Drawing.Point(13, 440);
            this.DoorsLabel.Name = "DoorsLabel";
            this.DoorsLabel.Size = new System.Drawing.Size(113, 29);
            this.DoorsLabel.TabIndex = 4;
            this.DoorsLabel.Text = "DOORS :";
            // 
            // YEARLABEL
            // 
            this.YEARLABEL.AutoSize = true;
            this.YEARLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YEARLABEL.Location = new System.Drawing.Point(17, 557);
            this.YEARLABEL.Name = "YEARLABEL";
            this.YEARLABEL.Size = new System.Drawing.Size(89, 29);
            this.YEARLABEL.TabIndex = 5;
            this.YEARLABEL.Text = "YEAR :";
            this.YEARLABEL.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "COLOR :";
            // 
            // GEARLABEL
            // 
            this.GEARLABEL.AutoSize = true;
            this.GEARLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEARLABEL.Location = new System.Drawing.Point(17, 499);
            this.GEARLABEL.Name = "GEARLABEL";
            this.GEARLABEL.Size = new System.Drawing.Size(85, 29);
            this.GEARLABEL.TabIndex = 9;
            this.GEARLABEL.Text = "GEAR:";
            // 
            // LIECENSELABEL
            // 
            this.LIECENSELABEL.AutoSize = true;
            this.LIECENSELABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIECENSELABEL.Location = new System.Drawing.Point(12, 327);
            this.LIECENSELABEL.Name = "LIECENSELABEL";
            this.LIECENSELABEL.Size = new System.Drawing.Size(225, 29);
            this.LIECENSELABEL.TabIndex = 11;
            this.LIECENSELABEL.Text = "LIECENSE PLATE :";
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.yearBox.Location = new System.Drawing.Point(274, 557);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(121, 33);
            this.yearBox.TabIndex = 12;
            // 
            // colorbox
            // 
            this.colorbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorbox.FormattingEnabled = true;
            this.colorbox.Items.AddRange(new object[] {
            "BLACK",
            "WHITE",
            "BLUE",
            "RED",
            "YELLOW",
            "GREY",
            "GREEN"});
            this.colorbox.Location = new System.Drawing.Point(274, 382);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(121, 33);
            this.colorbox.TabIndex = 13;
            // 
            // gearBox
            // 
            this.gearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gearBox.FormattingEnabled = true;
            this.gearBox.Items.AddRange(new object[] {
            "MANUAL",
            "AUTOMATIC"});
            this.gearBox.Location = new System.Drawing.Point(274, 495);
            this.gearBox.Name = "gearBox";
            this.gearBox.Size = new System.Drawing.Size(121, 33);
            this.gearBox.TabIndex = 14;
            // 
            // DoorBox
            // 
            this.DoorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoorBox.FormattingEnabled = true;
            this.DoorBox.Items.AddRange(new object[] {
            "3",
            "5"});
            this.DoorBox.Location = new System.Drawing.Point(274, 440);
            this.DoorBox.Name = "DoorBox";
            this.DoorBox.Size = new System.Drawing.Size(121, 33);
            this.DoorBox.TabIndex = 15;
            // 
            // SunRoofBox
            // 
            this.SunRoofBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunRoofBox.FormattingEnabled = true;
            this.SunRoofBox.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.SunRoofBox.Location = new System.Drawing.Point(274, 610);
            this.SunRoofBox.Name = "SunRoofBox";
            this.SunRoofBox.Size = new System.Drawing.Size(121, 33);
            this.SunRoofBox.TabIndex = 16;
            // 
            // Addsedan
            // 
            this.Addsedan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addsedan.Location = new System.Drawing.Point(1043, 579);
            this.Addsedan.Name = "Addsedan";
            this.Addsedan.Size = new System.Drawing.Size(102, 101);
            this.Addsedan.TabIndex = 17;
            this.Addsedan.Text = "ADD CAR";
            this.Addsedan.UseVisualStyleBackColor = true;
            this.Addsedan.Click += new System.EventHandler(this.Addsedan_Click);
            // 
            // nolabel
            // 
            this.nolabel.AutoSize = true;
            this.nolabel.BackColor = System.Drawing.Color.Silver;
            this.nolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nolabel.Location = new System.Drawing.Point(1205, 941);
            this.nolabel.Name = "nolabel";
            this.nolabel.Size = new System.Drawing.Size(176, 29);
            this.nolabel.TabIndex = 18;
            this.nolabel.Text = "N  and  O  Cars";
            // 
            // returnBtn
            // 
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.Location = new System.Drawing.Point(1279, 837);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(102, 101);
            this.returnBtn.TabIndex = 19;
            this.returnBtn.Text = "HOME";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // sunrooflabel
            // 
            this.sunrooflabel.AutoSize = true;
            this.sunrooflabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunrooflabel.Location = new System.Drawing.Point(13, 614);
            this.sunrooflabel.Name = "sunrooflabel";
            this.sunrooflabel.Size = new System.Drawing.Size(146, 29);
            this.sunrooflabel.TabIndex = 20;
            this.sunrooflabel.Text = "SUNROOF :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 21;
            // 
            // txtboxseadanlplate
            // 
            this.txtboxseadanlplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxseadanlplate.Location = new System.Drawing.Point(274, 327);
            this.txtboxseadanlplate.Name = "txtboxseadanlplate";
            this.txtboxseadanlplate.Size = new System.Drawing.Size(156, 28);
            this.txtboxseadanlplate.TabIndex = 22;
            // 
            // listboxofsedan
            // 
            this.listboxofsedan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxofsedan.FormattingEnabled = true;
            this.listboxofsedan.ItemHeight = 25;
            this.listboxofsedan.Location = new System.Drawing.Point(22, 685);
            this.listboxofsedan.Name = "listboxofsedan";
            this.listboxofsedan.Size = new System.Drawing.Size(1251, 254);
            this.listboxofsedan.TabIndex = 23;
            this.listboxofsedan.SelectedIndexChanged += new System.EventHandler(this.listofcars_SelectedIndexChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(1151, 579);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(122, 101);
            this.RemoveButton.TabIndex = 24;
            this.RemoveButton.Text = "REMOVE";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(1279, 12);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(102, 101);
            this.savebtn.TabIndex = 44;
            this.savebtn.Text = "SAVE";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.soldbtn_Click);
            // 
            // loadbtn
            // 
            this.loadbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbtn.Location = new System.Drawing.Point(1151, 12);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(102, 101);
            this.loadbtn.TabIndex = 45;
            this.loadbtn.Text = "LOAD";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(935, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 101);
            this.button1.TabIndex = 46;
            this.button1.Text = "SOLD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formSedan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1409, 995);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.listboxofsedan);
            this.Controls.Add(this.txtboxseadanlplate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sunrooflabel);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.nolabel);
            this.Controls.Add(this.Addsedan);
            this.Controls.Add(this.SunRoofBox);
            this.Controls.Add(this.DoorBox);
            this.Controls.Add(this.gearBox);
            this.Controls.Add(this.colorbox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.LIECENSELABEL);
            this.Controls.Add(this.GEARLABEL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YEARLABEL);
            this.Controls.Add(this.DoorsLabel);
            this.Controls.Add(this.sedanDetails);
            this.Controls.Add(this.homeBtn);
            this.Name = "formSedan";
            this.Text = "Form3";
            this.Activated += new System.EventHandler(this.formSedan_Activated);
            this.Load += new System.EventHandler(this.formSedan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label sedanDetails;
        private System.Windows.Forms.Label DoorsLabel;
        private System.Windows.Forms.Label YEARLABEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GEARLABEL;
        private System.Windows.Forms.Label LIECENSELABEL;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.ComboBox colorbox;
        private System.Windows.Forms.ComboBox gearBox;
        private System.Windows.Forms.ComboBox DoorBox;
        private System.Windows.Forms.ComboBox SunRoofBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Addsedan;
        private System.Windows.Forms.Label nolabel;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label sunrooflabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxseadanlplate;
        private System.Windows.Forms.ListBox listboxofsedan;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Button button1;
    }
}