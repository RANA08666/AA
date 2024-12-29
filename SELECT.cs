using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace RS
{
    public partial class SELECT : Form
    {

        // List of colors to cycle through
        private List<Color> colors = new List<Color>
    {
        Color.Red,      // Red
        Color.Blue,     // Blue
        Color.Green,    // Green
        Color.Yellow,   // Yellow
        Color.Purple,   // Purple
        Color.Orange,   // Orange
        Color.Black,    // Black
        Color.White     // White
    };


        private int currentColorIndex = 0; // To keep track of the current color


        public SELECT()
        {
            InitializeComponent();

            // Start the color cycling process
            StartColorCycle();


        }
        // Method to start cycling through colors
        private async void StartColorCycle()
        {
            while (true) // Infinite loop to keep cycling through the colors
            {
                // Change the label's color to the next color in the list
                label7.ForeColor = colors[currentColorIndex];
                label2.ForeColor = colors[currentColorIndex];
                label3.ForeColor = colors[currentColorIndex];
                label4.ForeColor = colors[currentColorIndex];

                // Wait for 1 second (1000 milliseconds) asynchronously (non-blocking)
                await Task.Delay(300);

                // Update the index to point to the next color, cycling back to the start
                currentColorIndex = (currentColorIndex + 1) % colors.Count;
            }
        }
        static bool selection1 = false;
        static bool selection2 = false;
        static bool selection3 = false;
        
        private void SELECT_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Button2.FillColor = System.Drawing.Color.Red;
            if (selection1)
            {
                //MessageBox.Show("selected Headshort panel!");

                Form1 main = new Form1();
                main.Show();
                this.Hide();
                this.Hide();
            }
            else if (selection2)
            {
                //MessageBox.Show("Selected Premium Panel");
                Form2 main = new Form2();
                main.Show();
                this.Hide();
                this.Hide();
            }
            else if (selection3)
            {
                //MessageBox.Show("selected Leged Plan!");
                Form1 main = new Form1();
                main.Show();
                this.Hide();
                this.Hide();
            }
            else
            {
                MessageBox.Show("First select Your plan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            selection1 = false;
            selection2 = false;
            selection3 = true;            
            guna2Button5.Text = "SELECTED";
            guna2Button1.Text = "SELEACT";
            guna2Button12.Text = "SELEACT";
            guna2Button5.BackColor = System.Drawing.Color.Red ;
            guna2Button12.BackColor = System.Drawing.Color.FromArgb(215, 220, 226);
            guna2Button1.BackColor = System.Drawing.Color.FromArgb(215, 220, 226);

            guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(64, 0, 0);
            guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(64, 0, 0);
            guna2Panel3.BorderColor = System.Drawing.Color.Red;
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            selection1 = true;
            selection2 = false;
            selection3 = false;
            guna2Button5.Text = "SELEACT";
            guna2Button1.Text = "SELEACT";
            guna2Button12.Text = "SELECTED";
            guna2Button5.BackColor = System.Drawing.Color.FromArgb(215, 220, 226);
            guna2Button12.BackColor = System.Drawing.Color.Red;
            guna2Button1.BackColor = System.Drawing.Color.FromArgb(215, 220, 226);

            guna2Panel2.BorderColor = System.Drawing.Color.Red;
            guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(64, 0, 0);
           
            guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(64, 0, 0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            selection1 = false;
            selection2 = true;
            selection3 = false;
            guna2Button5.Text = "SELEACT";
            guna2Button1.Text = "SELECTED";
            guna2Button12.Text = "SELEACT";
            guna2Button5.BackColor = System.Drawing.Color.FromArgb(215, 220, 226);
            guna2Button12.BackColor = System.Drawing.Color.FromArgb(215, 220, 226);
            guna2Button1.BackColor = System.Drawing.Color.Red;

            guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(64, 0, 0);
            guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(64, 0, 0);
            guna2Panel1.BorderColor = System.Drawing.Color.Red;

           

        }
        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
