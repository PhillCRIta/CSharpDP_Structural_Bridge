﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge
{
	//IMPLEMENTOR
	public abstract class Accessory
	{
		public abstract string GetAccessory(AmbientWater ambientWater); 
	}
}
