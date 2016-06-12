using System;
using System.Collections.Generic;
using Eto.Forms;
using Eto.Drawing;
using Eto.Serialization.Xaml;

namespace EtoApp1
{
    public class MainForm : Form
    {
        public MainForm()
        {
            XamlReader.Load(this);
            DataContext = new MainFormViewModel();
        }

        protected void HandleClickMe(object sender, EventArgs e)
        {
            MessageBox.Show("I was clicked!");
            (DataContext as MainFormViewModel).TestLabel = "bbb";
        }

        protected void HandleQuit(object sender, EventArgs e)
        {
            Application.Instance.Quit();
        }
    }
}
