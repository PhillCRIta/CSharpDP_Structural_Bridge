using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge
{
	internal class JacketAccessory : Accessory
	{
		//ConcreteImplementor
		public override string GetAccessory(AmbientWater ambientWater)
		{
			return "Jacket accessory";
		}
	}
}
