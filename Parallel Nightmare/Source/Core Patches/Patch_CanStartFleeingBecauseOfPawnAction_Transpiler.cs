﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using RimWorld;
using Verse;
using UnityEngine;
using System.Reflection.Emit;
using System.Reflection;
using UnityEngine.UI;
using Verse.AI;

namespace DTimeControl.Core_Patches
{
	[HarmonyPatch(typeof(Pawn_MindState))]
	[HarmonyPatch("CanStartFleeingBecauseOfPawnAction")]
	class Patch_CanStartFleeingBecauseOfPawnAction_Transpiler
    {
		static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
		{
			return GenericTickReplacer.ReplaceTicks(instructions, "CanStartFleeingBecauseOfPawnAction");
		}

	}
}
