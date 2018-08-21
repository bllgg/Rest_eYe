using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// newly  added imports
using System.Diagnostics;
using System.Windows.Forms;
using Rest_eYe.Properties;

namespace Rest_eYe
{
    /// <summary>
    /// 
    /// </summary>
    class ProcessIcon : IDisposable
    {
        NotifyIcon ni;
        private bool activated = false;
        private bool gameMode = false;

        public ProcessIcon()
        {
            ni = new NotifyIcon();
        }

        public void Display()
        {
            ni.MouseClick += new MouseEventHandler(ni_MouseClick);
            //ni.Icon = Resources.dactvtd;

            if (activated && gameMode)
            {
                ni.Icon = Resources.GM;
            }
            else if(activated && !gameMode)
            {
                ni.Icon = Resources.actvtd;
            }
            else
            {
                ni.Icon = Resources.dactvtd;
            }

            ni.Text = "Rest_eYe";
            ni.Visible = true;

            ni.ContextMenuStrip = new ContextMenus().create();
        }

        public void Dispose()
        {
            ni.Dispose();
        }

        void ni_MouseClick(object sender, MouseEventArgs e)
        {
            if (!activated)
            {
                active();
            }
            else
            {
                deactive();
            }
        }

        void active()
        {
            activated = true;
        }

        void deactive()
        {
            activated = false;
        }

    }
}
