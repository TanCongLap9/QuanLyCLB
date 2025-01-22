using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.Utils
{
    public static class TaskWindowUtils
    {
        public static PoisonTaskWindow Show(Control c, string title, int ms = 5000)
        {
            PoisonTaskWindow taskWindow = new PoisonTaskWindow(ms / 1000, c)
            {
                Text = title,
                DisplayHeader = false,
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,
                Resizable = false,
                Movable = true
            };
            taskWindow.Show();
            taskWindow.HandleDestroyed += TaskWindow_HandleDestroyed;
            return taskWindow;
        }
        
        private static void TaskWindow_HandleDestroyed(object sender, System.EventArgs e)
        {
            PoisonTaskWindow tw = (PoisonTaskWindow)sender;

        }
    }
}
