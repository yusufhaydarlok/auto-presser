using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_presser
{
    public class NavigationControl
    {
        List<UserControl> autoPresserControlList = new List<UserControl>();
        Panel panel;

        public NavigationControl(List<UserControl> autoPresserControlList, Panel panel)
        {
            this.autoPresserControlList = autoPresserControlList;
            this.panel = panel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for (int i = 0; i < autoPresserControlList.Count; i++)
            {
                autoPresserControlList[i].Dock = DockStyle.Fill;
                panel.Controls.Add(autoPresserControlList[i]);
            }
        }

        public void Display(int index)
        {
            if (index < autoPresserControlList.Count())
            {
                autoPresserControlList[index].BringToFront();
            }
        }
    }
}
