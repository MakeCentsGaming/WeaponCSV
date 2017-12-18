using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WeaponsCSV;

namespace MakeCents
{
    class clsDragNDrop
    {
      //private bool firstfile;//removed when gone to stat
      //private TextBox tb;

      /// <summary>
      /// <para></para>
      /// When you want a textbox to use drag and drop
      /// </summary>
      /// <param name="tb">The textbox</param>
      /// <param name="firstfile">Grab the first file in the array of args</param>
      public static void TextBoxDragNDrop(TextBox tb,bool firstfile = true)
      {
         //this.firstfile = firstfile;
         //this.tb = tb;
         tb.AllowDrop = true;
         tb.Drop += textBox_Drop;
         tb.PreviewDragOver += textBox_DragOver;
      }

      public static void TextBoxDragNDrop(TextBox tb, MainWindow mainWindow, bool firstfile = true)
      {
         mainWindow.AllowDrop = true;
         mainWindow.Drop += Window_Drop;
         mainWindow.PreviewDragOver += textBox_DragOver;
      }

      private static void textBox_DragOver(object sender, DragEventArgs e)
      {
         if (e.Data.GetDataPresent(DataFormats.FileDrop))
            e.Effects = DragDropEffects.Copy;
         else
            e.Effects = DragDropEffects.None;

         e.Handled = true;
      }

      private static void textBox_Drop(object sender, DragEventArgs e)
      {
         string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
         if (files != null && files.Length != 0)
         {
            TextBox tb = (TextBox)sender;
            tb.Text = files[0];
            /*if (firstfile)
            {
               this.tb.Text = files[0];
            }
            else
            {
               this.tb.Text = string.Join(",", files);
            }*/
         }
      }
      private static void Window_Drop(object sender, DragEventArgs e)
      {
         string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
         if (files != null && files.Length != 0)
         {
            MainWindow tb = (MainWindow)sender;
            tb.filefoldername.Text = files[0];
            /*if (firstfile)
            {
               this.tb.Text = files[0];
            }
            else
            {
               this.tb.Text = string.Join(",", files);
            }*/
         }
      }
   }
}
