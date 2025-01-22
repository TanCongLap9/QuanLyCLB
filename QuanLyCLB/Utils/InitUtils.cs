using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.Utils
{
    public static class InitUtils
    {
        public static void Init(PoisonStyleManager poisonStyleManager, PoisonUserControl userControl, Action initializeComponent)
        {
            DockStyle oldDock = userControl.Dock;
            userControl.Dock = DockStyle.None;
            Size oldSize = userControl.Size;
            initializeComponent.Invoke();
            userControl.Size = oldSize;
            userControl.Dock = oldDock;
            poisonStyleManager.Update();
            userControl.Style = poisonStyleManager.Style;
            userControl.Theme = poisonStyleManager.Theme;
        }
    }
}
