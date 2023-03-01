
namespace carProject
{
    partial class formSuv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSuv));
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxseadanlplate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DoorBox = new System.Windows.Forms.ComboBox();
            this.gearBox = new System.Windows.Forms.ComboBox();
            this.colorbox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.LIECENSELABEL = new System.Windows.Forms.Label();
            this.GEARLABEL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YEARLABEL = new System.Windows.Forms.Label();
            this.DoorsLabel = new System.Windows.Forms.Label();
            this.suvDetails = new System.Windows.Forms.Label();
            this.listofsuv = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.ComboBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.Addsedan = new System.Windows.Forms.Button();
            this.nolabel = new System.Windows.Forms.Label();
            this.soldbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1276, 880);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 101);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxseadanlplate
            // 
            this.txtboxseadanlplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxseadanlplate.Location = new System.Drawing.Point(390, 327);
            this.txtboxseadanlplate.Name = "txtboxseadanlplate";
            this.txtboxseadanlplate.Size = new System.Drawing.Size(156, 28);
            this.txtboxseadanlplate.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 35;
            // 
            // DoorBox
            // 
            this.DoorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoorBox.FormattingEnabled = true;
            this.DoorBox.Items.AddRange(new object[] {
            "3",
            "5"});
            this.DoorBox.Location = new System.Drawing.Point(390, 467);
            this.DoorBox.Name = "DoorBox";
            this.DoorBox.Size = new System.Drawing.Size(121, 33);
            this.DoorBox.TabIndex = 32;
            // 
            // gearBox
            // 
            this.gearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gearBox.FormattingEnabled = true;
            this.gearBox.Items.AddRange(new object[] {
            "MANUAL",
            "AUTOMATIC"});
            this.gearBox.Location = new System.Drawing.Point(390, 536);
            this.gearBox.Name = "gearBox";
            this.gearBox.Size = new System.Drawing.Size(121, 33);
            this.gearBox.TabIndex = 31;
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
            this.colorbox.Location = new System.Drawing.Point(390, 395);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(121, 33);
            this.colorbox.TabIndex = 30;
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
            this.yearBox.Location = new System.Drawing.Point(390, 612);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(121, 33);
            this.yearBox.TabIndex = 29;
            this.yearBox.SelectedIndexChanged += new System.EventHandler(this.yearBox_SelectedIndexChanged);
            // 
            // LIECENSELABEL
            // 
            this.LIECENSELABEL.AutoSize = true;
            this.LIECENSELABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIECENSELABEL.Location = new System.Drawing.Point(63, 325);
            this.LIECENSELABEL.Name = "LIECENSELABEL";
            this.LIECENSELABEL.Size = new System.Drawing.Size(225, 29);
            this.LIECENSELABEL.TabIndex = 28;
            this.LIECENSELABEL.Text = "LIECENSE PLATE :";
            // 
            // GEARLABEL
            // 
            this.GEARLABEL.AutoSize = true;
            this.GEARLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEARLABEL.Location = new System.Drawing.Point(63, 540);
            this.GEARLABEL.Name = "GEARLABEL";
            this.GEARLABEL.Size = new System.Drawing.Size(85, 29);
            this.GEARLABEL.TabIndex = 27;
            this.GEARLABEL.Text = "GEAR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "COLOR :";
            // 
            // YEARLABEL
            // 
            this.YEARLABEL.AutoSize = true;
            this.YEARLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YEARLABEL.Location = new System.Drawing.Point(64, 616);
            this.YEARLABEL.Name = "YEARLABEL";
            this.YEARLABEL.Size = new System.Drawing.Size(89, 29);
            this.YEARLABEL.TabIndex = 25;
            this.YEARLABEL.Text = "YEAR :";
            // 
            // DoorsLabel
            // 
            this.DoorsLabel.AutoSize = true;
            this.DoorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoorsLabel.Location = new System.Drawing.Point(64, 467);
            this.DoorsLabel.Name = "DoorsLabel";
            this.DoorsLabel.Size = new System.Drawing.Size(113, 29);
            this.DoorsLabel.TabIndex = 24;
            this.DoorsLabel.Text = "DOORS :";
            // 
            // suvDetails
            // 
            this.suvDetails.AutoSize = true;
            this.suvDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suvDetails.Location = new System.Drawing.Point(62, 247);
            this.suvDetails.Name = "suvDetails";
            this.suvDetails.Size = new System.Drawing.Size(303, 32);
            this.suvDetails.TabIndex = 23;
            this.suvDetails.Text = "Select Suv car details :";
            // 
            // listofsuv
            // 
            this.listofsuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listofsuv.FormattingEnabled = true;
            this.listofsuv.ItemHeight = 25;
            this.listofsuv.Location = new System.Drawing.Point(12, 720);
            this.listofsuv.Name = "listofsuv";
            this.listofsuv.Size = new System.Drawing.Size(1258, 254);
            this.listofsuv.TabIndex = 37;
            this.listofsuv.SelectedIndexChanged += new System.EventHandler(this.listofsuv_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 681);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "HEIGHT :";
            // 
            // heightBox
            // 
            this.heightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightBox.FormattingEnabled = true;
            this.heightBox.Items.AddRange(new object[] {
            "19",
            "17"});
            this.heightBox.Location = new System.Drawing.Point(390, 677);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(121, 33);
            this.heightBox.TabIndex = 39;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(1148, 613);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(122, 101);
            this.RemoveButton.TabIndex = 40;
            this.RemoveButton.Text = "REMOVE";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // Addsedan
            // 
            this.Addsedan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addsedan.Location = new System.Drawing.Point(1040, 613);
            this.Addsedan.Name = "Addsedan";
            this.Addsedan.Size = new System.Drawing.Size(102, 101);
            this.Addsedan.TabIndex = 41;
            this.Addsedan.Text = "ADD CAR";
            this.Addsedan.UseVisualStyleBackColor = true;
            this.Addsedan.Click += new System.EventHandler(this.Addsedan_Click);
            // 
            // nolabel
            // 
            this.nolabel.AutoSize = true;
            this.nolabel.BackColor = System.Drawing.Color.Silver;
            this.nolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nolabel.Location = new System.Drawing.Point(1202, 984);
            this.nolabel.Name = "nolabel";
            this.nolabel.Size = new System.Drawing.Size(176, 29);
            this.nolabel.TabIndex = 42;
            this.nolabel.Text = "N  and  O  Cars";
            // 
            // soldbtn
            // 
            this.soldbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldbtn.Location = new System.Drawing.Point(932, 613);
            this.soldbtn.Name = "soldbtn";
            this.soldbtn.Size = new System.Drawing.Size(102, 101);
            this.soldbtn.TabIndex = 43;
            this.soldbtn.Text = "SOLD";
            this.soldbtn.UseVisualStyleBackColor = true;
            this.soldbtn.Click += new System.EventHandler(this.soldbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(1304, 12);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(102, 101);
            this.savebtn.TabIndex = 45;
            this.savebtn.Text = "SAVE";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // loadbtn
            // 
            this.loadbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbtn.Location = new System.Drawing.Point(1187, 12);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(102, 101);
            this.loadbtn.TabIndex = 46;
            this.loadbtn.Text = "LOAD";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // formSuv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1418, 1055);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.soldbtn);
            this.Controls.Add(this.nolabel);
            this.Controls.Add(this.Addsedan);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listofsuv);
            this.Controls.Add(this.txtboxseadanlplate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DoorBox);
            this.Controls.Add(this.gearBox);
            this.Controls.Add(this.colorbox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.LIECENSELABEL);
            this.Controls.Add(this.GEARLABEL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YEARLABEL);
            this.Controls.Add(this.DoorsLabel);
            this.Controls.Add(this.suvDetails);
            this.Controls.Add(this.button1);
            this.Name = "formSuv";
            this.Text = "Form2";
            this.Activated += new System.EventHandler(this.formSuv_Activated);
            this.Load += new System.EventHandler(this.formSuv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtboxseadanlplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DoorBox;
        private System.Windows.Forms.ComboBox gearBox;
        private System.Windows.Forms.ComboBox colorbox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.Label LIECENSELABEL;
        private System.Windows.Forms.Label GEARLABEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label YEARLABEL;
        private System.Windows.Forms.Label DoorsLabel;
        private System.Windows.Forms.Label suvDetails;
        private System.Windows.Forms.ListBox listofsuv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox heightBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button Addsedan;
        private System.Windows.Forms.Label nolabel;
        private System.Windows.Forms.Button soldbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button loadbtn;
    }
}