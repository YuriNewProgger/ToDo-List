using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_ToDoList
{
    public class Task
    {
        public int ImageIndex { get; set; }
        public string TextTask { get; set; }

        public Task(int imageIndex, string textTask)
        {
            ImageIndex = imageIndex;
            TextTask = textTask;
        }


        public static Task FromXml(XElement node) =>
                new Task(
                        (int)node.Element("Category"),
                        (string)node.Element("Text")
                                                    );
    }
}
