using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Instaniate Controls
        //create a button at runtime
        Button btnDisplay = new System.Windows.Forms.Button();
        //create a label at runtime
        Label lblDisplay = new System.Windows.Forms.Label();
        Label lblName = new Label();
        TextBox txtName = new TextBox();
        Label lblPrgm = new Label();
        TextBox txtPrgm = new TextBox();
        Label lblEmail = new Label();
        TextBox txtEmail = new TextBox();
        Label lblSem = new Label();
        TextBox txtSem = new TextBox();
        private void btnShow_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();
            form2.ClientSize = new System.Drawing.Size(800, 400);
            form2.Name = "Form2";
            form2.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form2.Text = "Dynamic Form";
            //position and set other properties of the label
            lblName.Text = "Student Name:";
            lblName.Size = new System.Drawing.Size(200, 60);
            lblName.Location = new System.Drawing.Point(20, 80);

            lblPrgm.Text = "Program Name:";
            lblPrgm.Size = new System.Drawing.Size(200, 60);
            lblPrgm.Location = new System.Drawing.Point(20, 80);

            lblEmail.Text = "Email:";
            lblEmail.Size = new System.Drawing.Size(200, 60);
            lblEmail.Location = new System.Drawing.Point(20, 80);

            lblSem.Text = "Semester:";
            lblSem.Size = new System.Drawing.Size(200, 60);
            lblSem.Location = new System.Drawing.Point(20, 80);
            //position textbox
            txtName.Text = "";
            txtName.Size = new System.Drawing.Size(201, 60);
            txtName.Location = new System.Drawing.Point(260, 60);


            //position and set other properties of the button at runtime
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new System.Drawing.Size(201, 60);
            btnDisplay.Location = new System.Drawing.Point(160, 60);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            //register the click event with an event handler
            btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            //position and set other properties of the label at runtime
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDisplay.ForeColor = System.Drawing.SystemColors.HotTrack;
            lblDisplay.Location = new System.Drawing.Point(376, 60);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new System.Drawing.Size(120, 32);
            lblDisplay.Text = "display";
            //add the controls to the form
            form2.Controls.Add(btnDisplay);
            form2.Controls.Add(lblDisplay);
            form2.Controls.Add(lblName);
            form2.Controls.Add(txtName);
            form2.Controls.Add(lblEmail);
            form2.Controls.Add(txtEmail);
            form2.Controls.Add(lblSem;
            form2.Controls.Add(txtSem);
            form2.Show();
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text = txtName.Text;
        }
    }
}
