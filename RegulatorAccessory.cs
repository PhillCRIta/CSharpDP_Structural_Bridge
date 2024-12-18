using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge
{
	internal class RegulatorAccessory : Accessory
	{
		//ConcreteImplementor
		public override string GetAccessory(AmbientWater ambientWater)
		{
			switch (ambientWater)
			{
				case AmbientWater.FrozenLake:
					return "STRONG Glacier Regulator accessory";
					break;
				default:
					return "Regulator accessory";
					break;
			}

		}
	}
}
