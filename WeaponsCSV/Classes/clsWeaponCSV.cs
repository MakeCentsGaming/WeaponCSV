using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeCents
{
   public class clsWeaponCSV
   {
      public string weapon_name { get; set; }
      public string upgrade_name { get; set; }
      public string hint { get; set; }
      public string cost { get; set; }
      public string weaponVO { get; set; }
      public string weaponVOresp { get; set; }
      public string ammo_cost { get; set; }
      public string create_vox { get; set; }
      public string obsolete_false { get; set; }
      public string in_box { get; set; }
      public string upgrade_in_box { get; set; }
      public string is_limited { get; set; }
      public string limit { get; set; }
      public string upgrade_limit { get; set; }
      public string obsolete2_false { get; set; }
      public string wallbuy_autospawn { get; set; }
      public string classs { get; set; }
      public string is_aat_exempt { get; set; }
      public string is_wonder_weapon { get; set; }
      public string force_attachments { get; set; }

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

      internal void Update(Dictionary<string, string> kvps)
      {

         if (kvps.Keys.Contains("weapon_name"))
         {
            this.weapon_name = kvps["weapon_name"];
         }
         if (kvps.Keys.Contains("upgrade_name"))
         {
            this.upgrade_name = kvps["upgrade_name"];
         }
         if (kvps.Keys.Contains("hint"))
         {
            this.hint = kvps["hint"];
         }
         if (kvps.Keys.Contains("cost"))
         {
            this.cost = kvps["cost"];
         }
         if (kvps.Keys.Contains("weaponVO"))
         {
            this.weaponVO = kvps["weaponVO"];
         }
         if (kvps.Keys.Contains("weaponVOresp"))
         {
            this.weaponVOresp = kvps["weaponVOresp"];
         }
         if (kvps.Keys.Contains("ammo_cost"))
         {
            this.ammo_cost = kvps["ammo_cost"];
         }
         if (kvps.Keys.Contains("create_vox"))
         {
            this.create_vox = kvps["create_vox"];
         }
         if (kvps.Keys.Contains("obsolete_false"))
         {
            this.obsolete_false = kvps["obsolete_false"];
         }
         if (kvps.Keys.Contains("in_box"))
         {
            this.in_box = kvps["in_box"];
         }
         if (kvps.Keys.Contains("upgrade_in_box"))
         {
            this.upgrade_in_box = kvps["upgrade_in_box"];
         }
         if (kvps.Keys.Contains("is_limited"))
         {
            this.is_limited = kvps["is_limited"];
         }
         if (kvps.Keys.Contains("limit"))
         {
            this.limit = kvps["limit"];
         }
         if (kvps.Keys.Contains("upgrade_limit"))
         {
            this.upgrade_limit = kvps["upgrade_limit"];
         }
         if (kvps.Keys.Contains("obsolete2_false"))
         {
            this.obsolete2_false = kvps["obsolete2_false"];
         }
         if (kvps.Keys.Contains("wallbuy_autospawn"))
         {
            this.wallbuy_autospawn = kvps["wallbuy_autospawn"];
         }
         if (kvps.Keys.Contains("class"))
         {
            this.classs = kvps["class"];
         }
         if(kvps.Keys.Contains("is_aat_exempt"))
         {
         this.is_aat_exempt = kvps["is_aat_exempt"];
         }
         if(kvps.Keys.Contains("is_wonder_weapon"))
         {
         this.is_wonder_weapon = kvps["is_wonder_weapon"];
         }
         if(kvps.Keys.Contains("force_attachments"))
         {
         this.force_attachments = kvps["force_attachments"];
         }
}

      internal static List<string> UpdateWeaponNames(List<clsWeaponCSV> allLines)
      {
         //WeaponNames = new List<string>();
         List<string> test = new List<string>();
         foreach (clsWeaponCSV c in allLines)
         {
            //Console.WriteLine(c.weapon_name);
            test.Add(c.weapon_name);

         }
         return test;
      }
   }
}
