using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeCents
{
   public class clsWeaponCSV
   {
      public string weapon_name;
      public string upgrade_name;
      public string hint;
      public string cost;
      public string weaponVO;
      public string weaponVOresp;
      public string ammo_cost;
      public string create_vox;
      public string obsolete_false;
      public string in_box;
      public string upgrade_in_box;
      public string is_limited;
      public string limit;
      public string upgrade_limit;
      public string obsolete2_false;
      public string wallbuy_autospawn;
      public string classs;
      public string is_aat_exempt;
      public string is_wonder_weapon;
      public string force_attachments;

      public clsWeaponCSV()
      {
         this.weapon_name = "";
         this.upgrade_name = "";
         this.hint = "";
         this.cost = "";
         this.weaponVO = "";
         this.weaponVOresp = "";
         this.ammo_cost = "";
         this.create_vox = "";
         this.obsolete_false = "";
         this.in_box = "";
         this.upgrade_in_box = "";
         this.is_limited = "";
         this.limit = "";
         this.upgrade_limit = "";
         this.obsolete2_false = "";
         this.wallbuy_autospawn = "";
         this.classs = "";
         this.is_aat_exempt = "";
         this.is_wonder_weapon = "";
         this.force_attachments = "";
      }
      public void Update(string weapon_name, 
         string upgrade_name,
         string hint,
         string cost,
         string weaponVO,
         string weaponVOresp,
         string ammo_cost,
         string create_vox,
         string obsolete_false,
         string in_box,
         string upgrade_in_box,
         string is_limited,
         string limit,
         string upgrade_limit,
         string obsolete2_false,
         string wallbuy_autospawn,
         string classs,
         string is_aat_exempt,
         string is_wonder_weapon,
         string force_attachments)
      {
         this.weapon_name = weapon_name;
         this.upgrade_name = upgrade_name;
         this.hint = hint;
         this.cost = cost;
         this.weaponVO = weaponVO;
         this.weaponVOresp = weaponVOresp;
         this.ammo_cost = ammo_cost;
         this.create_vox = create_vox;
         this.obsolete_false = obsolete_false;
         this.in_box = in_box;
         this.upgrade_in_box = upgrade_in_box;
         this.is_limited = is_limited;
         this.limit = limit;
         this.upgrade_limit = upgrade_limit;
         this.obsolete2_false = obsolete2_false;
         this.wallbuy_autospawn = wallbuy_autospawn;
         this.classs = classs;
         this.is_aat_exempt = is_aat_exempt;
         this.is_wonder_weapon = is_wonder_weapon;
         this.force_attachments = force_attachments;
      }
   }
}
