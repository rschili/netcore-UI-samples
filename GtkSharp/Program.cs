using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gtk;

namespace GtkSharp
    {
    class Program
        {
        static void Main(string[] args)
            {
            Application.Init();
            Window myWin = new Window("NetCoreSample");
            myWin.Resize(300, 200);
            myWin.DeleteEvent += new DeleteEventHandler(Window_Delete);

            VBox vBox = new VBox(true, 3);
            Entry text = new Entry("Initial Text");

            //Add the label to the form
            vBox.Add(text);

            Button button = new Button("Call .NET Core");
            vBox.Add(button);
            button.Clicked += (sender, e) => text.Text = NetCoreLibrary.NetCoreClass.DoSomething();

            myWin.Add(vBox);
            //Show Everything
            myWin.ShowAll();

            Application.Run();
            }

        static void Window_Delete(object obj, DeleteEventArgs args)
            {
            Application.Quit();
            args.RetVal = true;
            }
        }
    }
