using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
// newly  added imports
//using System.Diagnostics;
using System.Windows.Forms;
using Rest_eYe.Properties;

namespace Rest_eYe
{
    class ProcessIcon : IDisposable
    {
        private static System.Timers.Timer aTimer = new System.Timers.Timer(1200000);
        NotifyIcon ni;
        //public static bool activated = false;
        //private bool gameMode = false;

        public ProcessIcon()
        {
            ni = new NotifyIcon();
        }

        public void Display()
        {
            ni.MouseClick += new MouseEventHandler(ni_MouseClick);
            ni.Icon = Resources.dactvtd;
            ni.Text = "Rest_eYe Deactivated";
            ni.Visible = true;

            ni.ContextMenuStrip = new ContextMenus().create();
        }

        public void Dispose()
        {
            ni.Dispose();
        }

        void ni_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!checkActivated.actvtd)
                {
                    activeFunction(true,"Rest_eYe Activated");
                }
                else
                {
                    activeFunction(false,"Rest_eYe Deactivated");
                }
            }
        }

        void activeFunction(bool status, String txtmessage)
        {
            checkActivated.actvtd = status;
            ni.Text = txtmessage;
            if (status == true)
            {
                ni.Icon = Resources.GM;
                aTimer.Elapsed += send;
                aTimer.AutoReset = true;
                aTimer.Enabled = true;
            }
            else
            {
                ni.Icon = Resources.dactvtd;
                aTimer.AutoReset = false;
                aTimer.Enabled = false;
            }
        }

        public static void send(Object o, EventArgs e)
        {
            MessageBox.Show("Please follow 20x20x20 rule. Look far more than 20 meters for 20 seconds to keep your eyes healthy.", "Rest_eYe", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
