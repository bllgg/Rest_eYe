using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics;
using System.Windows.Forms;
using Rest_eYe.Properties;
using System.Drawing;

namespace Rest_eYe
{
    class ContextMenus
    {
        bool isActivated = false;
        bool isGameMode = false;
        bool isAboutLoaded = false;

        public ContextMenuStrip create()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator sep;

            item = new ToolStripMenuItem();
            item.Text = "Activate";
            item.Click += new EventHandler(Activate_Click);
            item.Image = Resources.actvtdp;
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Text = "Deactivate";
            item.Click += new EventHandler(Deactivate_Click);
            item.Image = Resources.dactvtdp;
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Text = "Game Mode";
            item.Click += new EventHandler(GameMode_Click);
            item.Image = Resources.GMp;
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Text = "About";
            item.Click += new EventHandler(About_Click);
            item.Image = Resources.About;
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Text = "Quit";
            item.Click += new EventHandler(Exit_Click);
            item.Image = Resources.Exit;
            menu.Items.Add(item);

            return menu;
        }

        void Activate_Click(object sender,EventArgs e)
        {

        }

        void Deactivate_Click(object sender,EventArgs e)
        {

        }

        void GameMode_Click(object sender,EventArgs e)
        {

        }

        void About_Click(object sender,EventArgs e)
        {
            if (!isAboutLoaded)
            {
                isAboutLoaded = true;
                new aboutForm().ShowDialog();
                isAboutLoaded = false;
            }
        }

        void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
