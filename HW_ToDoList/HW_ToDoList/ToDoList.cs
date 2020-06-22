using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HW_ToDoList
{

    public partial class ToDoList : Form
    {
        private string[] Category;
        public int IndexCategory { get; set; }
        public string TextToDo { get; set; }

        private int IndexDel { get; set; }

        public ToDoList()
        {
            InitializeComponent();

            Category = new[]
            {
                "Работа",
                "Учёба",
                "Семья",
                "Дом"
            };
            
        }

        private void Button_Exit_Click(object sender, EventArgs e) =>
            EndsTheApplication();

        private void Button_Minimaze_Click(object sender, EventArgs e) =>
            this.WindowState = FormWindowState.Minimized;

        private void ToDoList_FormClosed(object sender, FormClosedEventArgs e) =>
            EndsTheApplication();
        
        private void Button_Add_Click(object sender, EventArgs e)
        {
            WindowToDoAdd toDoAdd = new WindowToDoAdd();
            toDoAdd.ShowDialog();

            TextToDo = toDoAdd.TextToDo;
            IndexCategory = toDoAdd.IndexCategory;

            if (TextToDo == null)
                return;

            ListViewItem item = new ListViewItem(Category[IndexCategory]);
            item.ImageIndex = IndexCategory;
            item.SubItems.Add(TextToDo);
            listView.Items.Add(item);
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {

            if (listView.SelectedItems.Count == 0)
                return;

            listView.Items.RemoveAt(listView.FocusedItem.Index);
        }

        private void PictureBox_Up_Click(object sender, EventArgs e)
        {
            if (listView.FocusedItem.Index == 0)
                return;

            ListViewItem oneItem = listView.FocusedItem;
            ListViewItem twoItem = listView.Items[listView.FocusedItem.Index - 1];

            int indexItemOne = listView.FocusedItem.Index;
            int indexIdenxItemTwo = listView.Items[listView.FocusedItem.Index - 1].Index;


            
            listView.Items.RemoveAt(indexItemOne);
            listView.Items.RemoveAt(indexIdenxItemTwo);


            listView.Items.Insert(indexItemOne - 1, oneItem);
            listView.Items.Insert(indexIdenxItemTwo + 1, twoItem);

            listView.Focus();
            listView.Items[indexItemOne - 1].Focused = true;

        }

        private void PictureBox_Down_Click(object sender, EventArgs e)
        {
            if (listView.FocusedItem.Index >= listView.Items.Count - 1)
                return;

            ListViewItem oneItem = listView.FocusedItem;
            ListViewItem twoItem = listView.Items[listView.FocusedItem.Index + 1];

            int indexItemOne = listView.FocusedItem.Index;
            int indexIdenxItemTwo = listView.Items[listView.FocusedItem.Index + 1].Index;
            
            listView.Items.RemoveAt(indexIdenxItemTwo);
            listView.Items.RemoveAt(indexItemOne);

            listView.Items.Insert(indexIdenxItemTwo - 1, twoItem);
            listView.Items.Insert(indexItemOne + 1, oneItem);
            

            listView.Focus();
            listView.Items[indexItemOne + 1].Focused = true;
        }
        
        private void Button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Документ XML (*.xml)|*.xml";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Task> tasks = new List<Task>();
                foreach(ListViewItem item in listView.Items)
                {
                    Task task = new Task(item.ImageIndex, item.SubItems[1].Text);
                    tasks.Add(task);
                }

                XElement xml = new XElement("Tasks",
                        from b in tasks
                        select new XElement("Task",
                            new XElement("Category", b.ImageIndex),
                            new XElement("Text", b.TextTask)));

                xml.Save(saveFileDialog.FileName);
            }
        }

        private void Button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Документ XML (*.xml)|*.xml";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XElement root = XElement.Load(openFileDialog.FileName);

                IEnumerable<XElement> elements = root.Elements("Task");
                
                foreach(XElement element in elements)
                {
                    int index = (int)element.Element("Category");
                    ListViewItem item = new ListViewItem(Category[index]);
                    item.ImageIndex = index;
                    item.SubItems.Add((string)element.Element("Text"));
                    listView.Items.Add(item);
                }
            }
        }

        private void EndsTheApplication()
        {
            EndWindow endWindow = new EndWindow();
            endWindow.Show();
            Hide();
        }
    }
}
