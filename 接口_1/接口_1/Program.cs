using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口_1
{
    interface IControl
    {
        void Paint();
    }
    interface ITextBox : IControl
    {
        void SetText(string text);
    }
    interface IListBox : IControl
    {
        void SetItems(string[] items);
    }
    interface IComboBox : ITextBox, IListBox
    {
        //
    }

    public class MyImages : IPict
    {
        public int DeleterImage()
        {
            Console.WriteLine("删除图像");
            return 3;
        }
        public void DisplayImage()
        {
            Console.WriteLine("显示图像");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyImages myimages = new MyImages();
            myimages.DisplayImage();
            Console.WriteLine("删除了"+myimages.DisplayImage()+"张图像!");
        }
    }
}
