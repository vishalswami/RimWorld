﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using HarmonyLib;
using Verse;
using UnityEngine;
using Verse.Sound;

/*
namespace DTimeControl.Parallel_Nightmare
{
    [HarmonyPatch(typeof(Thing))]
    [HarmonyPatch("Destroy")]
    class Patch_ThingDestroy
    {
        public static bool Prefix(ref object __instance)
        {
            //Log.Message("destroy lock");
            LockUtility.LockObject(ref __instance);
            return true;
        }

        public static void Postfix(ref object __instance)
        {
            //Log.Message("destroy unlock");
            LockUtility.UnLockObject(ref __instance);
        }
    }
}
*/