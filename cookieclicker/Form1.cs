using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cookieclicker
{
    public partial class bg : Form
    {
        int cookiesx = 376;
        int cookiesy = 401;
        int counter1 = 0;
        int counter2 = 0;
        Int64 cookiecounter = 0;
        int autoclick;
        int sec = 0;
        int cookies = 0;
        int speed = 1000;
        int multiplier = 1;
        int cookiesperclick = 1;
        int clickcounter = 0;
        int style = 1;

        public bg()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loop.Start();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void cookie_Click(object sender, EventArgs e)
        {
            cookiesize.Start();
            cookiecounter += cookiesperclick * multiplier;
            cookiecountertext.Text = cookiecounter.ToString() + " cookies";
            clickcounter++;
            label1.Text = "You have clicked the cookie " + clickcounter.ToString() + " time(s)";
        }

        private void cookiesize_Tick(object sender, EventArgs e)
        {
            counter1++;
            if(counter1 < 5)
            {
                cookiesx += 10;
                cookiesy += 10;
                Size size = new Size(cookiesx, cookiesy);
                cookie.Size = size;
            }
            else
            {
                counter2++;
                if(counter2 < 5)
                {
                    cookiesx -= 10;
                    cookiesy -= 10;
                    Size size = new Size(cookiesx, cookiesy);
                    cookie.Size = size;
                }
                else
                {
                    counter2 = 0;
                    counter1 = 0;
                    cookiesize.Stop();
                }
            }
        }

        void buttonpask()
        {
            Point pask = new Point(1, 16);
            gamel.Location = pask;
            upgadesl.Location = pask;
            statsl.Location = pask;
            settingsl.Location = pask;
            aboutl.Location = pask;

            gamel.Text = "GAME";
            upgadesl.Text = "UPGRADES";
            statsl.Text = "STATISTICS";
            settingsl.Text = "SETTINGS";
            aboutl.Text = "ABOUT";
        }
        private void gameb_Click(object sender, EventArgs e)
        {
            buttonpask();
            game1.BringToFront();
            game2.BringToFront();
            gamel.Text = "GAME <";
            Point s = new Point(gamel.Location.X + 10, gamel.Location.Y);
            gamel.Location = s;
        }

        private void gamel_Click(object sender, EventArgs e)
        {
            buttonpask();
            game1.BringToFront();
            game2.BringToFront();
            gamel.Text = "GAME <";
            Point s = new Point(gamel.Location.X + 10, gamel.Location.Y);
            gamel.Location = s;
        }

        private void upgradesb_Click(object sender, EventArgs e)
        {
            buttonpask();
            upgrades1.BringToFront();
            upgrades2.BringToFront();
            upgadesl.Text = "UPGRADES <";
            Point s = new Point(upgadesl.Location.X + 10, upgadesl.Location.Y);
            upgadesl.Location = s;
        }

        private void upgadesl_Click(object sender, EventArgs e)
        {
            buttonpask();
            upgrades1.BringToFront();
            upgrades2.BringToFront();
            upgadesl.Text = "UPGRADES <";
            Point s = new Point(upgadesl.Location.X + 10, upgadesl.Location.Y);
            upgadesl.Location = s;
        }

        private void statsb_Click(object sender, EventArgs e)
        {
            buttonpask();
            statistics1.BringToFront();
            statistics2.BringToFront();
            statsl.Text = "STATISTICS <";
            Point s = new Point(statsl.Location.X + 10, statsl.Location.Y);
            statsl.Location = s;
        }

        private void statsl_Click(object sender, EventArgs e)
        {
            buttonpask();
            statistics1.BringToFront();
            statistics2.BringToFront();
            statsl.Text = "STATISTICS <";
            Point s = new Point(statsl.Location.X + 10, statsl.Location.Y);
            statsl.Location = s;
        }

        private void settingsb_Click(object sender, EventArgs e)
        {
            buttonpask();
            settings1.BringToFront();
            settings2.BringToFront();
            settingsl.Text = "SETTINGS <";
            Point s = new Point(settingsl.Location.X + 10, settingsl.Location.Y);
            settingsl.Location = s;
        }

        private void settingsl_Click(object sender, EventArgs e)
        {
            buttonpask();
            settings1.BringToFront();
            settings2.BringToFront();
            settingsl.Text = "SETTINGS <";
            Point s = new Point(settingsl.Location.X + 10, settingsl.Location.Y);
            settingsl.Location = s;
        }

        private void aboutb_Click(object sender, EventArgs e)
        {
            buttonpask();
            about1.BringToFront();
            about2.BringToFront();
            aboutl.Text = "ABOUT <";
            Point s = new Point(aboutl.Location.X + 10, aboutl.Location.Y);
            aboutl.Location = s;
        }

        private void aboutl_Click(object sender, EventArgs e)
        {
            buttonpask();
            about1.BringToFront();
            about2.BringToFront();
            aboutl.Text = "ABOUT <";
            Point s = new Point(aboutl.Location.X + 10, aboutl.Location.Y);
            aboutl.Location = s;
        }

        private void loop_Tick(object sender, EventArgs e)
        {
            sec++;
            if(sec > speed)
            {
                cookiecounter += autoclick;
                cookiecountertext.Text = cookiecounter.ToString() + " cookies";
                label2.Text = cookiecounter.ToString() + " cookies";
                sec = 0;
            }
            label5.Text = DateTime.Now.ToString("HH:mm:ss"); 
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if(cookiecounter >= 350)
            {
                autoclick += 1;
                cookiecounter -= 350;
                label10.Text = "Automatic clicks per second: " + autoclick.ToString();
                label2.Text = cookiecounter.ToString() + " cookies";
            }
            else
            {
                MessageBox.Show("You don't have enough cookies for that", "ERROR",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (cookiecounter >= 1500)
            {
                autoclick += 5;
                cookiecounter -= 1500;
                label10.Text = "Automatic clicks per second: " + autoclick.ToString();
                label2.Text = cookiecounter.ToString() + " cookies";
            }
            else
            {
                MessageBox.Show("You don't have enough cookies for that", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (cookiecounter >= 8000)
            {
                autoclick += 25;
                cookiecounter -= 8000;
                label10.Text = "Automatic clicks per second: " + autoclick.ToString();
                label2.Text = cookiecounter.ToString() + " cookies";
            }
            else
            {
                MessageBox.Show("You don't have enough cookies for that", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (cookiecounter >= 20000)
            {
                autoclick += 100;
                cookiecounter -= 20000;
                label10.Text = "Automatic clicks per second: " + autoclick.ToString();
                label2.Text = cookiecounter.ToString() + " cookies";
            }
            else
            {
                MessageBox.Show("You don't have enough cookies for that", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (cookiecounter >= 500000)
            {
                autoclick += 500;
                cookiecounter -= 500000;
                label10.Text = "Automatic clicks per second: " + autoclick.ToString();
                label2.Text = cookiecounter.ToString() + " cookies";
            }
            else
            {
                MessageBox.Show("You don't have enough cookies for that", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (cookiecounter >= 3000000)
            {
                autoclick += 6000;
                cookiecounter -= 3000000;
                label10.Text = "Automatic clicks per second: " + autoclick.ToString();
                label2.Text = cookiecounter.ToString() + " cookies";
            }
            else
            {
                MessageBox.Show("You don't have enough cookies for that", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (cookiecounter >= 20000000)
            {
                autoclick += 70000;
                cookiecounter -= 20000000;
                label10.Text = "Automatic clicks per second: " + autoclick.ToString();
                label2.Text = cookiecounter.ToString() + " cookies";
            }
            else
            {
                MessageBox.Show("You don't have enough cookies for that", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (cookiecounter >= 300000000)
            {
                autoclick += 1000000;
                cookiecounter -= 300000000;
                label10.Text = "Automatic clicks per second: " + autoclick.ToString();
                label2.Text = cookiecounter.ToString() + " cookies";
            }
            else
            {
                MessageBox.Show("You don't have enough cookies for that", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (cookiecounter >= 5000)
            {
                if(speed >= 0)
                {
                    speed -= 1;
                    cookiecounter -= 5000;
                    label20.Text = "Autoclick speed: " + speed.ToString() + "(ms)";
                    label2.Text = cookiecounter.ToString() + " cookies";
                }    
                else
                {
                    MessageBox.Show("Speed cannot go under 0ms, dumbass", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You don't have enough cookies for that", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (cookiecounter >= 20000)
            {
                if (speed > 0)
                {
                    speed -= 5;
                    cookiecounter -= 20000;
                    label20.Text = "Autoclick speed: " + speed.ToString() + "(ms)";
                    label2.Text = cookiecounter.ToString() + " cookies";
                }
                else
                {
                    MessageBox.Show("Speed cannot go under 0ms, dumbass", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You don't have enough cookies for that", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label32_Click(object sender, EventArgs e)
        {
            if (cookiecounter >= 5000)
            {
                multiplier += 1;
                cookiecounter -= 5000;
                label33.Text = "Manual clicker multiplier: x" + multiplier.ToString();
                label2.Text = cookiecounter.ToString() + " cookies";
            }
            else
            {
                MessageBox.Show("You don't have enough cookies for that", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {
            if (cookiecounter >= 22000)
            {
                multiplier += 5;
                cookiecounter -= 22000;
                label33.Text = "Manual clicker multiplier: x" + multiplier.ToString();
                label2.Text = cookiecounter.ToString() + " cookies";
            }
            else
            {
                MessageBox.Show("You don't have enough cookies for that", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            style++;
            if(style == 1)
            {
                label5.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label4.Text = "DARKMODE:OFF";
                this.BackColor = Color.White;
                upmenu.BackColor = Color.FromArgb(200,200,200);
                menu.BackColor = Color.FromArgb(200, 200, 200);
                gameb.BackColor = Color.White;
                upgradesb.BackColor = Color.White;
                statsb.BackColor = Color.White;
                settingsb.BackColor = Color.White;
                aboutb.BackColor = Color.White;
                gamel.ForeColor = Color.Black;

                upgadesl.ForeColor = Color.Black;
                statsl.ForeColor = Color.Black;
                settingsl.ForeColor = Color.Black;
                aboutl.ForeColor = Color.Black;

                game1.BackColor = Color.FromArgb(200, 200, 200);
                game2.BackColor = Color.FromArgb(200, 200, 200);
                cookiecountertext.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                upgrades1.BackColor = Color.FromArgb(200, 200, 200);
                panel1.BackColor = Color.White;
                label11.ForeColor = Color.Black;
                foreach (Panel p in panel1.Controls.OfType<Panel>())
                {
                    p.BackColor = Color.FromArgb(200, 200, 200);
                }
                label12.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label15.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;
                label17.ForeColor = Color.Black;
                label18.ForeColor = Color.Black;
                label20.ForeColor = Color.Black;
                label19.ForeColor = Color.Black;
                label21.ForeColor = Color.Black;
                foreach (Panel p in panel12.Controls.OfType<Panel>())
                {
                    p.BackColor = Color.FromArgb(200, 200, 200);
                }
                panel12.BackColor = Color.White;
                label34.ForeColor = Color.Black;
                label33.ForeColor = Color.Black;
                label32.ForeColor = Color.Black; 
                label31.ForeColor = Color.Black;
                upgrades2.BackColor = Color.FromArgb(200, 200, 200);
                statistics1.BackColor = Color.FromArgb(200, 200, 200);
                statistics2.BackColor = Color.FromArgb(200, 200, 200);
                label1.ForeColor = Color.Black;
                settings1.BackColor = Color.FromArgb(200, 200, 200);
                settings2.BackColor = Color.FromArgb(200, 200, 200);
                panel13.BackColor = Color.White;
                label4.ForeColor = Color.Black;
                about1.BackColor = Color.FromArgb(200, 200, 200);
                about2.BackColor = Color.FromArgb(200, 200, 200);
                //light mode
            }
            else
            {
                //dark mode
                label5.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label4.Text = "DARKMODE:ON";
                this.BackColor = Color.FromArgb(35, 35, 35);
                upmenu.BackColor = Color.FromArgb(45, 45, 45);
                menu.BackColor = Color.FromArgb(45, 45, 45);
                gameb.BackColor = Color.FromArgb(35, 35, 35);
                upgradesb.BackColor = Color.FromArgb(35, 35, 35);
                statsb.BackColor = Color.FromArgb(35, 35, 35);
                settingsb.BackColor = Color.FromArgb(35, 35, 35);
                aboutb.BackColor = Color.FromArgb(35, 35, 35);
                gamel.ForeColor = Color.White;
                upgadesl.ForeColor = Color.White;
                statsl.ForeColor = Color.White;
                settingsl.ForeColor = Color.White;
                aboutl.ForeColor = Color.White;
                game1.BackColor = Color.FromArgb(45, 45, 45);
                game2.BackColor = Color.FromArgb(45, 45, 45);
                cookiecountertext.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                upgrades1.BackColor = Color.FromArgb(45, 45, 45);
                panel1.BackColor = Color.FromArgb(35, 35, 35);
                label11.ForeColor = Color.White;
                foreach(Panel p in panel1.Controls.OfType<Panel>())
                {
                    p.BackColor = Color.FromArgb(45, 45, 45);
                }
                label12.ForeColor = Color.White;
                label13.ForeColor = Color.White;
                label14.ForeColor = Color.White;
                label15.ForeColor = Color.White;
                label16.ForeColor = Color.White;
                label17.ForeColor = Color.White;
                label18.ForeColor = Color.White;
                label20.ForeColor = Color.White;
                label19.ForeColor = Color.White;
                label21.ForeColor = Color.White;
                foreach (Panel p in panel12.Controls.OfType<Panel>())
                {
                    p.BackColor = Color.FromArgb(45, 45, 45);
                }
                panel12.BackColor = Color.FromArgb(35, 35, 35);
                label34.ForeColor = Color.White;
                label33.ForeColor = Color.White;
                label32.ForeColor = Color.White;
                label31.ForeColor = Color.White;
                upgrades2.BackColor = Color.FromArgb(45, 45, 45);
                statistics1.BackColor = Color.FromArgb(45, 45, 45);
                statistics2.BackColor = Color.FromArgb(45, 45, 45);
                label1.ForeColor = Color.White;
                settings1.BackColor = Color.FromArgb(45, 45, 45);
                settings2.BackColor = Color.FromArgb(45, 45, 45);
                panel13.BackColor = Color.FromArgb(35, 35, 35);
                label4.ForeColor = Color.White;
                about1.BackColor = Color.FromArgb(45,45,45);
                about2.BackColor = Color.FromArgb(45,45,45);

                style = 0;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
