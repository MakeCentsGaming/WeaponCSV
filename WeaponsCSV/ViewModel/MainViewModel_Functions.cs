using MakeCents;
using System;
using System.Collections.Generic;
using System.IO;
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
      /// <summary>
      /// 
      /// </summary>
      public bool duplicating;
      /// <summary>
      /// 
      /// </summary>
      public bool clearing;
      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      private void clearall(object obj=null)
      {
         clearing = true;
         weapon_name = "";
         upgrade_name = "";
         hint = "";
         cost = "";
         weaponVO = "";
         weaponVOresp = "";
         ammo_cost = "";
         create_vox = "";
         obsolete_false = "";
         in_box = "";
         upgrade_in_box = "";
         is_limited = "";
         limit = "";
         upgrade_limit = "";
         obsolete2_false = "";
         wallbuy_autospawn = "";
         classs = "";
         is_aat_exempt = "";
         is_wonder_weapon = "";
         force_attachments = "";
         clearing = false;
         duplicating = false;
        
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      private void aDD(object obj)
      {
         //add the current vars to an object list
         clsWeaponCSV tb = new clsWeaponCSV();
         tb.Update(weapon_name,
            upgrade_name,
            hint,
            cost,
            weaponVO,
            weaponVOresp,
            ammo_cost,
            create_vox,
            obsolete_false,
            in_box,
            upgrade_in_box,
            is_limited,
            limit,
            upgrade_limit,
            obsolete2_false,
            wallbuy_autospawn,
            classs,
            is_aat_exempt,
            is_wonder_weapon,
            force_attachments);

         AllLines.Add(tb);
         //mspreadsheet.Add(tb);
         //WeaponNames.Add(tb.weapon_name);
         WeaponNames = clsWeaponCSV.UpdateWeaponNames(AllLines);
         NewLine = false;
         CommentOut = true;
         duplicating = false;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      public void cOmment(object obj)
      {
         foreach(var item in AllLines.Where(p => p.weapon_name == weapon_name))
         {
            if(!item.weapon_name.StartsWith("//"))
            {
               item.weapon_name = "//" + item.weapon_name;
            }
         }
         UpdateNames();
         
      }
      /// <summary>
      /// 
      /// </summary>
      private void UpdateNames()
      {
         clearall();
         WeaponNames = clsWeaponCSV.UpdateWeaponNames(AllLines);
         NewLine = false;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      public void dElete(object obj)
      {
         int c = 0;
         clsWeaponCSV item = new clsWeaponCSV();
         foreach(clsWeaponCSV co in AllLines)
         {
            if(co.weapon_name==weapon_name)
            {
               item = co;
               break;
            }
            c++;
         }
         AllLines.Remove(item);
         UpdateNames();
      }
      
      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      private void cOpy(object obj)
      {
         CommentOut = false;
         duplicating = true;
      }


   }
}
