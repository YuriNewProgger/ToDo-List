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
    public partial class WindowToDoAdd : Form
    {

        public int IndexCategory { get; set; }
        public string TextToDo { get; set; }

        public WindowToDoAdd()
        {
            InitializeComponent();
        }

        private void Button_Cancel_Click(object sender, EventArgs e) =>
            Close();

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            TextToDo = richTextBox.Text;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {

            IndexCategory = comboBox_category.SelectedIndex;

            if (IndexCategory == -1)
                MessageBox.Show("Не выбрана категория", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (TextToDo == null)
                MessageBox.Show("Введите описание задачи", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                Close();
        }


    }
}
