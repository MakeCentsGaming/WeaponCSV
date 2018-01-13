using MakeCents;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace WeaponsCSV
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      /// <summary>
      /// 
      /// </summary>
      public MainViewModel MVM { get { return this.DataContext as MainViewModel; } }
      /// <summary>
      /// 
      /// </summary>
      public ObservableCollection<clsWeaponCSV> db;
      /// <summary>
      /// 
      /// </summary>
      public MainWindow()
      {
         InitializeComponent();
         
         InitControls();
         Version v = Assembly.GetExecutingAssembly().GetName().Version;
         MVM.About = string.Format(CultureInfo.InvariantCulture, @"Version {0}.{1}.{2} (r{3})", v.Major, v.Minor, v.Build, v.Revision);
         spreadsheet.EnableRowVirtualization = true;
         spreadsheet.EnableColumnVirtualization = true;
         
      }
      
      private void InitControls()
      {
         MVM.AllLines = new ObservableCollection<clsWeaponCSV>();
         //form drag and drop
         clsDragNDrop.TextBoxDragNDrop(filefoldername, this);
         //textbox drag and drop
         clsDragNDrop.TextBoxDragNDrop(filefoldername);
         //source default options
         MVM.Cost = new string[]{ "","0", "50", "250", "500", "750", "1000", "1100",
            "1250", "1300", "1400", "1500", "1600", "1750", "2000", "3000", "5000" };
         MVM.TrueFalse = new string[] { "","TRUE", "FALSE" };
         MVM.WVO = new string[] { "","betty", "dual", "energy_pistol", "grenade",
            "launcher", "lmg", "monkey", "octobomb", "pistol", "ray3", "rifle", "shotgun",
            "smg", "sniper", "tesla", "thundergun", "wpck_bowie", "wpck_ray" };
         MVM.WClass = new string[] { "","grenade", "lmg", "pistol", "rifle", "shotgun",
            "smg", "sniper", "special" };
         
         MVM.WeaponNames = new List<string>();
      }

      private void filefoldername_TextChanged(object sender, TextChangedEventArgs e)
      {
         if (badfile()) return;
         ClearAll();
         //MVM.AllLines = new List<clsWeaponCSV>();
         Mouse.OverrideCursor = Cursors.Wait;
         
         PopulateAllList();
         UpdatePreview();
      }
      
      private void PopulateAllList()
      {         
         if (MVM.duplicating) return;
         
         Dictionary<string, string> kvps = new Dictionary<string, string>();
         string[] order = new string[] { };
         string[] lines = File.ReadAllLines(MVM.FileFolderName);
         db = new ObservableCollection<clsWeaponCSV>();
         foreach (String line in lines)
         {
            
            if (line.Contains("weapon_name") && line.Contains("cost") && line.Contains("upgrade_name"))
            {
               order = line.Split(',');
               //spreadsheet.Items.Clear();
               
               foreach(string o in order)
               {
                  DataGridTextColumn textColumn = new DataGridTextColumn();
                  textColumn.Header = o.Replace("_"," ");
                  if (o == "class")
                  {
                     textColumn.Binding = new Binding("classs");
                  }
                  else
                  {
                     textColumn.Binding = new Binding(o);
                  }
                  //Console.WriteLine(o);
                  spreadsheet.Columns.Add(textColumn);
               }
               continue;
            }
            string[] csvline = line.Split(',');
            kvps = new Dictionary<string, string>();
            List<string> row = new List<string>();
            for (int i = 0; i < csvline.Count(); i++)
            {
               kvps[order[i]] = csvline[i];
               row.Add(csvline[i]);
            }
            
            clsWeaponCSV tb = new clsWeaponCSV();
            tb.Update(kvps);
            
            db.Add(tb);
            
            //spreadsheet.Items.Add(tb);
            //db.Add(tb);
            //Console.WriteLine(line);
         }
         //MVM.mspreadsheet = MVM.AllLines;
         tabs.SelectedIndex = 0;
         MVM.AllLines = db;
         MVM.WeaponNames = clsWeaponCSV.UpdateWeaponNames(MVM.AllLines);
         MVM.NewLine = false;
         Mouse.OverrideCursor = Cursors.Arrow;
      }

      private void ClearAll()
      {
         MVM.AllLines = new ObservableCollection<clsWeaponCSV>();
         MVM.WeaponNames = new List<string>();
         MVM.clearing = true;
         MVM.weapon_name = "";
         MVM.upgrade_name = "";
         MVM.hint = "";
         MVM.cost = "";
         MVM.weaponVO = "";
         MVM.weaponVOresp = "";
         MVM.ammo_cost = "";
         MVM.create_vox = "";
         MVM.obsolete_false = "";
         MVM.in_box = "";
         MVM.upgrade_in_box = "";
         MVM.is_limited = "";
         MVM.limit = "";
         MVM.upgrade_limit = "";
         MVM.obsolete2_false = "";
         MVM.wallbuy_autospawn = "";
         MVM.classs = "";
         MVM.is_aat_exempt = "";
         MVM.is_wonder_weapon = "";
         MVM.force_attachments = "";
         MVM.clearing = false;
         MVM.duplicating = false;
      }

      private bool SetAdd()
      {
         if (MVM.weapon_name=="" || MVM.WeaponNames.Contains(MVM.weapon_name))
         {            
            MVM.NewLine = false;
            if (MVM.weapon_name == "")
               MVM.CommentOut = false;
            else
               if (MVM.duplicating) return false;
               MVM.CommentOut = true;
            return false;
         }
         else
         {
            MVM.CommentOut = false;
            MVM.NewLine = true;
            return true;
         }
      }

      /*private void CleanFile()
      {
         MVM.FileFolderName = Regex.Replace(MVM.FileFolderName, @"(\s+|@|&|'|,|\(|\)|<|>|#)", "");         
      }*/

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
         //MVM.limit = Regex.Replace(MVM.limit, @"[^\d]", "");
         if (MVM.duplicating) return;
         UpdateDB(sender, e);
      }

      private void comboBox_TextChanged(object sender, TextChangedEventArgs e)
      {

         if (MVM.duplicating)
         {
            MVM.upgrade_name = MVM.weapon_name + "_upgraded";
         }
         if (SetAdd()) return;
         
         UpdateFormVars();
      }

      private void UpdateFormVars()
      {
         if (MVM.duplicating) return;
         MVM.clearing = true;
         //update to this objects info
         var cv = MVM.AllLines.Where(p => p.weapon_name == MVM.weapon_name);
         foreach (clsWeaponCSV p in cv)
         {
            MVM.upgrade_name = p.upgrade_name;
            MVM.hint = p.hint;
            MVM.cost = p.cost;
            MVM.weaponVO = p.weaponVO;
            MVM.weaponVOresp = p.weaponVOresp;
            MVM.ammo_cost = p.ammo_cost;
            MVM.create_vox = p.create_vox;
            MVM.obsolete_false = p.obsolete_false;
            MVM.in_box = p.in_box;
            MVM.upgrade_in_box = p.upgrade_in_box;
            MVM.is_limited = p.is_limited;
            MVM.limit = p.limit;
            MVM.upgrade_limit = p.upgrade_limit;
            MVM.obsolete2_false = p.obsolete2_false;
            MVM.wallbuy_autospawn = p.wallbuy_autospawn;
            MVM.classs = p.classs;
            MVM.is_aat_exempt = p.is_aat_exempt;
            MVM.is_wonder_weapon = p.is_wonder_weapon;
            MVM.force_attachments = p.force_attachments;
         }
         MVM.clearing = false;
         UpdatePreview();
      }

      private void UpdatePreview()
      {
         StringBuilder sb = new StringBuilder();
         sb.AppendLine(clsWeaponCSV.GetHeaders());
         foreach (clsWeaponCSV tb in MVM.AllLines)
         {
            sb.AppendLine(clsWeaponCSV.GetLine(tb));
         }
         MVM.Preview = sb.ToString();
      }

      private void UpdateDB(object sender, TextChangedEventArgs e)
      {
         if (MVM.duplicating) return;
         UpdateItem();
         //spreadsheet.ItemsSource = null;
         //spreadsheet.ItemsSource = MVM.mspreadsheet;
         
         spreadsheet.Items.Refresh();
         
      }

      private void UpdateItem()
      {
         if (MVM.duplicating) return;
         if (MVM.clearing) return;
         foreach (var item in MVM.AllLines.Where(p => p.weapon_name == MVM.weapon_name))
         {
            item.upgrade_name = MVM.upgrade_name;
            item.hint = MVM.hint;
            item.cost = MVM.cost;
            item.weaponVO = MVM.weaponVO;
            item.weaponVOresp = MVM.weaponVOresp;
            item.ammo_cost = MVM.ammo_cost;
            item.create_vox = MVM.create_vox;
            item.obsolete_false = MVM.obsolete_false;
            item.in_box = MVM.in_box;
            item.upgrade_in_box = MVM.upgrade_in_box;
            item.is_limited = MVM.is_limited;
            item.limit = MVM.limit;
            item.upgrade_limit = MVM.upgrade_limit;
            item.obsolete2_false = MVM.obsolete2_false;
            item.wallbuy_autospawn = MVM.wallbuy_autospawn;
            item.classs = MVM.classs;
            item.is_aat_exempt = MVM.is_aat_exempt;
            item.is_wonder_weapon = MVM.is_wonder_weapon;
            item.force_attachments = MVM.force_attachments;
         }
         UpdatePreview();
      }


      private void spreadsheet_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
      {
         UpdateFormVars();
         
      }

      private void spreadsheet_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
      {
         UpdateFormVars();
      }


      private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
      {
         UpdateFormVars();
      }

      private void TabControl_MouseEnter(object sender, MouseEventArgs e)
      {
         
      }

      private void spreadsheet_MouseLeave(object sender, MouseEventArgs e)
      {
         filefoldername.Focus();
         MVM.WeaponNames = clsWeaponCSV.UpdateWeaponNames(MVM.AllLines);
      }

      private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
      {
         StringBuilder sb = new StringBuilder();
         sb.AppendLine(clsWeaponCSV.GetHeaders());
         foreach (clsWeaponCSV tb in MVM.AllLines)
         {
            sb.AppendLine(clsWeaponCSV.GetLine(tb));
         }
         try
         {
            if (Directory.Exists(MVM.FileFolderName))
            {
               MessageBox.Show("Invalid File Name\n\nFile not saved.", "File Name?",
              MessageBoxButton.OK, MessageBoxImage.Error);
               return;
            }
            /* if no root dir was added and just a name was given it will save at application root
             * if(!Directory.Exists(Path.GetDirectoryName(FileFolderName)))
            {
               MessageBox.Show("Invalid File Name\n\nFile not saved.", "File Name?",
               MessageBoxButton.OK, MessageBoxImage.Error);
               return;
            }*/
            if (Path.GetFileName(MVM.FileFolderName) == "")
            {
               MessageBox.Show("Invalid File Name\n\nFile not saved.", "File Name?",
               MessageBoxButton.OK, MessageBoxImage.Error);
               return;
            }
            File.WriteAllText(MVM.FileFolderName, sb.ToString());
            MessageBox.Show("File saved as:\n\n" + MVM.FileFolderName, "File Saved",
               MessageBoxButton.OK, MessageBoxImage.Information);
         }
         catch (UnauthorizedAccessException)
         {
            MessageBox.Show("I couldn't write the file.\n\nMake sure you don't have it open for some reason.", "Read Only?",
               MessageBoxButton.OK, MessageBoxImage.Error);
            return;
         }
         catch (ArgumentNullException)
         {
            MessageBox.Show("You need a path and file name in order to save.\n\nFile not saved.", "File Name?",
               MessageBoxButton.OK, MessageBoxImage.Error);
            return;
         }
      }
   }
}
