﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge
{
	internal class SuitDryNeoprene : ScubaDivingEquipment
	{
		public SuitDryNeoprene(int temperature, AmbientWater ambientWater, Accessory accessory) : base(temperature, ambientWater, accessory)
		{
		}

		protected override string GetSuit()
		{
			return "DRY NEOPRENE Suit";
		}
	}
}
