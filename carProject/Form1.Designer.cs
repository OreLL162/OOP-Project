
namespace carProject
{
    partial class formHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.SunBtn = new System.Windows.Forms.Button();
            this.MotorBtn = new System.Windows.Forms.Button();
            this.SedanBtn = new System.Windows.Forms.Button();
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.nolabel = new System.Windows.Forms.Label();
            this.buyoptionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SunBtn
            // 
            this.SunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunBtn.Location = new System.Drawing.Point(946, 444);
            this.SunBtn.Name = "SunBtn";
            this.SunBtn.Size = new System.Drawing.Size(139, 110);
            this.SunBtn.TabIndex = 0;
            this.SunBtn.Text = "Suv";
            this.SunBtn.UseVisualStyleBackColor = true;
            this.SunBtn.Click += new System.EventHandler(this.SunBtn_Click);
            // 
            // MotorBtn
            // 
            this.MotorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotorBtn.Location = new System.Drawing.Point(104, 444);
            this.MotorBtn.Name = "MotorBtn";
            this.MotorBtn.Size = new System.Drawing.Size(139, 110);
            this.MotorBtn.TabIndex = 1;
            this.MotorBtn.Text = "Motorcycle";
            this.MotorBtn.UseVisualStyleBackColor = true;
            this.MotorBtn.Click += new System.EventHandler(this.MotorBtn_Click);
            // 
            // SedanBtn
            // 
            this.SedanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SedanBtn.Location = new System.Drawing.Point(520, 444);
            this.SedanBtn.Name = "SedanBtn";
            this.SedanBtn.Size = new System.Drawing.Size(139, 110);
            this.SedanBtn.TabIndex = 2;
            this.SedanBtn.Text = "Sedan";
            this.SedanBtn.UseVisualStyleBackColor = true;
            this.SedanBtn.Click += new System.EventHandler(this.SedanBtn_Click);
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.AutoSize = true;
            this.Welcomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelabel.Location = new System.Drawing.Point(498, 9);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(192, 44);
            this.Welcomelabel.TabIndex = 3;
            this.Welcomelabel.Text = "welcome !";
            // 
            // nolabel
            // 
            this.nolabel.AutoSize = true;
            this.nolabel.BackColor = System.Drawing.Color.Silver;
            this.nolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nolabel.Location = new System.Drawing.Point(1074, 582);
            this.nolabel.Name = "nolabel";
            this.nolabel.Size = new System.Drawing.Size(176, 29);
            this.nolabel.TabIndex = 4;
            this.nolabel.Text = "N  and  O  Cars";
            // 
            // buyoptionsLabel
            // 
            this.buyoptionsLabel.AutoSize = true;
            this.buyoptionsLabel.BackColor = System.Drawing.Color.Silver;
            this.buyoptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyoptionsLabel.Location = new System.Drawing.Point(396, 305);
            this.buyoptionsLabel.Name = "buyoptionsLabel";
            this.buyoptionsLabel.Size = new System.Drawing.Size(399, 32);
            this.buyoptionsLabel.TabIndex = 8;
            this.buyoptionsLabel.Text = "Choose what you want to buy :";
            this.buyoptionsLabel.Click += new System.EventHandler(this.buyoptionsLabel_Click);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 629);
            this.Controls.Add(this.buyoptionsLabel);
            this.Controls.Add(this.nolabel);
            this.Controls.Add(this.Welcomelabel);
            this.Controls.Add(this.SedanBtn);
            this.Controls.Add(this.MotorBtn);
            this.Controls.Add(this.SunBtn);
            this.Name = "formHome";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SunBtn;
        private System.Windows.Forms.Button MotorBtn;
        private System.Windows.Forms.Button SedanBtn;
        private System.Windows.Forms.Label Welcomelabel;
        private System.Windows.Forms.Label nolabel;
        private System.Windows.Forms.Label buyoptionsLabel;
    }
}

