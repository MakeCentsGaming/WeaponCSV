using MakeCents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeaponsCSV
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainViewModel MVM { get { return this.DataContext as MainViewModel; } }

      public MainWindow()
      {
         InitializeComponent();
         InitControls();
      }

      private void InitControls()
      {
         //form drag and drop
         clsDragNDrop.TextBoxDragNDrop(filefoldername, this);
         //textbox drag and drop
         clsDragNDrop.TextBoxDragNDrop(filefoldername);
         //cost source defaul options
         MVM.Cost = new string[]{ "","0", "50", "250", "500", "750", "1000", "1100",
            "1250", "1300", "1400", "1500", "1600", "1750", "2000", "3000", "5000" };
         MVM.TrueFalse = new string[] { "","TRUE", "FALSE" };
         MVM.WVO = new string[] { "","betty", "dual", "energy_pistol", "grenade",
            "launcher", "lmg", "monkey", "octobomb", "pistol", "ray3", "rifle", "shotgun",
            "smg", "sniper", "tesla", "thundergun", "wpck_bowie", "wpck_ray" };
         MVM.WClass = new string[] { "","grenade", "lmg", "pistol", "rifle", "shotgun",
            "smg", "sniper", "special" };

      }

      private void filefoldername_TextChanged(object sender, TextChangedEventArgs e)
      {
         MVM.limit = "";
         CleanFile();
         if (badfile()) return;
         Console.WriteLine(MVM.hint + " " + MVM.cost);
      }

      private void CleanFile()
      {
         MVM.FileFolderName = Regex.Replace(MVM.FileFolderName, @"(\s+|@|&|'|,|\(|\)|<|>|#)", "");
         
      }

      private bool badfile()
      {
         if (!File.Exists(MVM.FileFolderName)) return true;
         if (MVM.FileFolderName == "") return true;
         if (!MVM.FileFolderName.Contains(".csv"))
         {
            MVM.FileFolderName = "";
            return true;
         }
         return false;
      }

      private void OnlyNumeric(object sender, TextChangedEventArgs e)
      {
         MVM.limit = Regex.Replace(MVM.limit, @"[^\d]", "");
      }
   }
}
