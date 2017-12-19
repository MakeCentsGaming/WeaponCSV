using MakeCents;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WeaponsCSV
{
   /// <summary>
   /// 
   /// </summary>
   public partial class MainViewModel
   {
      private static MainViewModel _instance;
      /// <summary>
      /// 
      /// </summary>
      public static MainViewModel Instance
      {
         get { return _instance; }
         set
         {
            _instance = value;
            if (_instance != null)
               _instance.OnPropertyChanged("Instance");
         }
      }
      /// <summary>
      /// 
      /// </summary>
      public Window MyParentWindow { get; set; }



      /* Example property
      /// <summary>
      /// 
      /// </summary>
      public string WelcomeMessage
      {
         get { return _WelcomeMessage; }
         set
         {
            _WelcomeMessage = value;
            OnPropertyChanged("WelcomeMessage");
            
         }
      }
      */
      
      public string _FileFolderName;
      /// <summary>
      /// 
      /// </summary>
      public string FileFolderName
      {
         get { return _FileFolderName; }
         set
         {
            _FileFolderName = value;
            OnPropertyChanged("FileFolderName");

         }
      }

      public List<string> _WeaponNames;
      /// <summary>
      /// 
      /// </summary>
      public List<string> WeaponNames
      {
         get { return _WeaponNames; }
         set
         {
            _WeaponNames = value;
            OnPropertyChanged("WeaponNames");

         }
      }

      public string[] _Cost;
      /// <summary>
      /// 
      /// </summary>
      public string[] Cost
      {
         get { return _Cost; }
         set
         {
            _Cost = value;
            OnPropertyChanged("Cost");

         }
      }

      public string[] _TrueFalse;
      /// <summary>
      /// 
      /// </summary>
      public string[] TrueFalse
      {
         get { return _TrueFalse; }
         set
         {
            _TrueFalse = value;
            OnPropertyChanged("TrueFalse");

         }
      }

      public string[] _WClass;
      /// <summary>
      /// 
      /// </summary>
      public string[] WClass
      {
         get { return _WClass; }
         set
         {
            _WClass = value;
            OnPropertyChanged("WClass");

         }
      }

      public string[] _WVO;
      /// <summary>
      /// 
      /// </summary>
      public string[] WVO
      {
         get { return _WVO; }
         set
         {
            _WVO = value;
            OnPropertyChanged("WVO");

         }
      }

      public string _weapon_name;
      /// <summary>
      /// 
      /// </summary>
      public string weapon_name
      {
         get { return _weapon_name; }
         set
         {
            _weapon_name = value;
            OnPropertyChanged("weapon_name");

         }
      }

      public string _upgrade_name;
      /// <summary>
      /// 
      /// </summary>
      public string upgrade_name
      {
         get { return _upgrade_name; }
         set
         {
            _upgrade_name = value;
            OnPropertyChanged("upgrade_name");

         }
      }
      public string _limit;
      /// <summary>
      /// 
      /// </summary>
      public string limit
      {
         get { return _limit; }
         set
         {
            _limit = value;
            OnPropertyChanged("limit");

         }
      }

      public string _hint;
      /// <summary>
      /// 
      /// </summary>
      public string hint
      {
         get { return _hint; }
         set
         {
            _hint = value;
            OnPropertyChanged("hint");
         }
      }

      public string _cost;
      /// <summary>
      /// 
      /// </summary>
      public string cost
      {
         get { return _cost; }
         set
         {
            _cost = value;
            OnPropertyChanged("cost");
         }
      }

      public string _weaponVO;
      /// <summary>
      /// 
      /// </summary>
      public string weaponVO
      {
         get { return _weaponVO; }
         set
         {
            _weaponVO = value;
            OnPropertyChanged("weaponVO");

         }
      }

      public string _weaponVOresp;
      /// <summary>
      /// 
      /// </summary>
      public string weaponVOresp
      {
         get { return _weaponVOresp; }
         set
         {
            _weaponVOresp = value;
            OnPropertyChanged("weaponVOresp");

         }
      }


      public string _ammo_cost;
      /// <summary>
      /// 
      /// </summary>
      public string ammo_cost
      {
         get { return _ammo_cost; }
         set
         {
            _ammo_cost = value;
            OnPropertyChanged("ammo_cost");

         }
      }

      public string _create_vox;
      /// <summary>
      /// 
      /// </summary>
      public string create_vox
      {
         get { return _create_vox; }
         set
         {
            _create_vox = value;
            OnPropertyChanged("create_vox");

         }
      }

      public string _obsolete_false;
      /// <summary>
      /// 
      /// </summary>
      public string obsolete_false
      {
         get { return _obsolete_false; }
         set
         {
            _obsolete_false = value;
            OnPropertyChanged("obsolete_false");

         }
      }

      public string _in_box;
      /// <summary>
      /// 
      /// </summary>
      public string in_box
      {
         get { return _in_box; }
         set
         {
            _in_box = value;
            OnPropertyChanged("in_box");

         }
      }

      public string _upgrade_in_box;
      /// <summary>
      /// 
      /// </summary>
      public string upgrade_in_box
      {
         get { return _upgrade_in_box; }
         set
         {
            _upgrade_in_box = value;
            OnPropertyChanged("upgrade_in_box");

         }
      }

      public string _is_limited;
      /// <summary>
      /// 
      /// </summary>
      public string is_limited
      {
         get { return _is_limited; }
         set
         {
            _is_limited = value;
            OnPropertyChanged("is_limited");

         }
      }

      public string _upgrade_limit;
      /// <summary>
      /// 
      /// </summary>
      public string upgrade_limit
      {
         get { return _upgrade_limit; }
         set
         {
            _upgrade_limit = value;
            OnPropertyChanged("upgrade_limit");

         }
      }

      public string _obsolete2_false;
      /// <summary>
      /// 
      /// </summary>
      public string obsolete2_false
      {
         get { return _obsolete2_false; }
         set
         {
            _obsolete2_false = value;
            OnPropertyChanged("obsolete2_false");

         }
      }

      public string _wallbuy_autospawn;
      /// <summary>
      /// 
      /// </summary>
      public string wallbuy_autospawn
      {
         get { return _wallbuy_autospawn; }
         set
         {
            _wallbuy_autospawn = value;
            OnPropertyChanged("wallbuy_autospawn");

         }
      }

      public string _classs;
      /// <summary>
      /// 
      /// </summary>
      public string classs
      {
         get { return _classs; }
         set
         {
            _classs = value;
            OnPropertyChanged("classs");

         }
      }

      public string _is_aat_exempt;
      /// <summary>
      /// 
      /// </summary>
      public string is_aat_exempt
      {
         get { return _is_aat_exempt; }
         set
         {
            _is_aat_exempt = value;
            OnPropertyChanged("is_aat_exempt");

         }
      }

      public string _is_wonder_weapon;
      /// <summary>
      /// 
      /// </summary>
      public string is_wonder_weapon
      {
         get { return _is_wonder_weapon; }
         set
         {
            _is_wonder_weapon = value;
            OnPropertyChanged("is_wonder_weapon");

         }
      }

      public string _force_attachments;
      /// <summary>
      /// 
      /// </summary>
      public string force_attachments
      {
         get { return _force_attachments; }
         set
         {
            _force_attachments = value;
            OnPropertyChanged("force_attachments");

         }
      }

      public bool _NewLine;
      /// <summary>
      /// 
      /// </summary>
      public bool NewLine
      {
         get { return _NewLine; }
         set
         {
            _NewLine = value;
            OnPropertyChanged("NewLine");

         }
      }

      public bool _CommentOut;
      /// <summary>
      /// 
      /// </summary>
      public bool CommentOut
      {
         get { return _CommentOut; }
         set
         {
            _CommentOut = value;
            OnPropertyChanged("CommentOut");

         }
      }


      public ObservableCollection<clsWeaponCSV> _AllLines;
      /// <summary>
      /// 
      /// </summary>
      public ObservableCollection<clsWeaponCSV> AllLines
      {
         get { return _AllLines; }
         set
         {
            _AllLines = value;
            OnPropertyChanged("AllLines");

         }
      }

   }//end Class
}
