﻿using System;
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
      private void clearall(object obj)
      {
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
      }

   }
}