using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_ToDoList
{
    public partial class EndWindow : Form
    {
        private int Time { get; set; }

        public EndWindow()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Time++;

            if (Time == 3)
            {
                timer.Stop();
                Application.Exit();
            }
        }
    }
}
