﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBird : Bird
{
   //重写方法
   public override void ShowSkill()
   {
      base.ShowSkill();
      rg.velocity *= 2;
   }
}
