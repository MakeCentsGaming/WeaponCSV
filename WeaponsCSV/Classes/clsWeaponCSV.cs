using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeCents
{
   /// <summary>
   /// 
   /// </summary>
   public class clsWeaponCSV
   {
      /// <summary>
      /// 
      /// </summary>
      public string weapon_name { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string upgrade_name { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string hint { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string cost { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string weaponVO { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string weaponVOresp { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string ammo_cost { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string create_vox { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string obsolete_false { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string in_box { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string upgrade_in_box { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string is_limited { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string limit { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string upgrade_limit { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string obsolete2_false { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string wallbuy_autospawn { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string classs { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string is_aat_exempt { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string is_wonder_weapon { get; set; }
      /// <summary>
      /// 
      /// </summary>
      public string force_attachments { get; set; }
      /// <summary>
      /// 
      /// </summary>
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
      /// <summary>
      /// 
      /// </summary>
      /// <param name="weapon_name"></param>
      /// <param name="upgrade_name"></param>
      /// <param name="hint"></param>
      /// <param name="cost"></param>
      /// <param name="weaponVO"></param>
      /// <param name="weaponVOresp"></param>
      /// <param name="ammo_cost"></param>
      /// <param name="create_vox"></param>
      /// <param name="obsolete_false"></param>
      /// <param name="in_box"></param>
      /// <param name="upgrade_in_box"></param>
      /// <param name="is_limited"></param>
      /// <param name="limit"></param>
      /// <param name="upgrade_limit"></param>
      /// <param name="obsolete2_false"></param>
      /// <param name="wallbuy_autospawn"></param>
      /// <param name="classs"></param>
      /// <param name="is_aat_exempt"></param>
      /// <param name="is_wonder_weapon"></param>
      /// <param name="force_attachments"></param>
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
      /// <summary>
      /// 
      /// </summary>
      /// <param name="tb"></param>
      /// <returns></returns>
      internal static string GetLine(clsWeaponCSV tb)
      {
         StringBuilder sb = new StringBuilder();
         sb.Append(tb.weapon_name);
         sb.Append(",");
         sb.Append(tb.upgrade_name);
         sb.Append(",");
         sb.Append(tb.hint);
         sb.Append(",");
         sb.Append(tb.cost);
         sb.Append(",");
         sb.Append(tb.weaponVO);
         sb.Append(",");
         sb.Append(tb.weaponVOresp);
         sb.Append(",");
         sb.Append(tb.ammo_cost);
         sb.Append(",");
         sb.Append(tb.create_vox);
         sb.Append(",");
         sb.Append(tb.obsolete_false);
         sb.Append(",");
         sb.Append(tb.in_box);
         sb.Append(",");
         sb.Append(tb.upgrade_in_box);
         sb.Append(",");
         sb.Append(tb.is_limited);
         sb.Append(",");
         sb.Append(tb.limit);
         sb.Append(",");
         sb.Append(tb.upgrade_limit);
         sb.Append(",");
         sb.Append(tb.obsolete2_false);
         sb.Append(",");
         sb.Append(tb.wallbuy_autospawn);
         sb.Append(",");
         sb.Append(tb.classs);
         sb.Append(",");
         sb.Append(tb.is_aat_exempt);
         sb.Append(",");
         sb.Append(tb.is_wonder_weapon);
         sb.Append(",");
         sb.Append(tb.force_attachments);
         return sb.ToString();

      }
      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      public static string GetHeaders()
      {
         string result = String.Join(",",new string[]{"weapon_name", "upgrade_name", "hint", "cost", "weaponVO", "weaponVOresp", "ammo_cost", "create_vox", "obsolete_false", "in_box", "upgrade_in_box", "is_limited", "limit", "upgrade_limit", "obsolete2_false", "wallbuy_autospawn", "class", "is_aat_exempt", "is_wonder_weapon", "force_attachments"});
         return result;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="kvps"></param>
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
      /// <summary>
      /// 
      /// </summary>
      /// <param name="allLines"></param>
      /// <returns></returns>
      public static List<string> UpdateWeaponNames(ObservableCollection<clsWeaponCSV> allLines)
      {
         //WeaponNames = new List<string>();
         List<string> test = new List<string>();
         foreach (clsWeaponCSV c in allLines)
         {
            //Console.WriteLine(c.weapon_name);
            if(!c.weapon_name.StartsWith("//"))
            {
               test.Add(c.weapon_name);
            }
            

         }
         test.Sort();
         return test;
      }
   }
}
