using MakeCents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsCSV
{
   /// <summary>
   /// 
   /// </summary>
   public partial class MainViewModel
   {
      public bool clearing;
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
      }
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

      }

      public void deLete(object obj)
      {
         foreach(var item in AllLines.Where(p => p.weapon_name == weapon_name))
         {
            if(!item.weapon_name.StartsWith("//"))
            {
               item.weapon_name = "//" + item.weapon_name;
            }
         }
         clearall();
         WeaponNames = clsWeaponCSV.UpdateWeaponNames(AllLines);
         NewLine = false;
      }

      public void sAve(object obj)
      {
         foreach(clsWeaponCSV tb in AllLines)
         {

         }
      }

   }
}
