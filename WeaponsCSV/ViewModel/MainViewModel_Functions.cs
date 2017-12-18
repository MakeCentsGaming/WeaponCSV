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
      private void clearall(object obj)
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
         //WeaponNames.Add(tb.weapon_name);
         UpdateWeaponNames();
      }

      private void UpdateWeaponNames()
      {
         WeaponNames = new List<string>();
         List<string> test = new List<string>();
         foreach(clsWeaponCSV c in AllLines)
         {
            //Console.WriteLine(c.weapon_name);
            test.Add(c.weapon_name);
            
         }
         WeaponNames = test;
         NewLine = false;
      }
   }
}
