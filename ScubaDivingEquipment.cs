using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Bridge
{
	//ABSTRACTION
	public abstract class ScubaDivingEquipment
	{
		private readonly Accessory _accessory;

		public ScubaDivingEquipment(int temperature, AmbientWater ambientWater, Accessory accessory)
        {
			Temperature = temperature;
			AmbientWater = ambientWater;
			_accessory = accessory;
		}

		public int Temperature { get; }
		public AmbientWater AmbientWater { get; }

		public string UseCorrectEquipment()
		{
			return $"My accutal equipment is: {GetSuit()} with this accessory: {_accessory.GetAccessory(AmbientWater)}";
		}

		//GetEquipment is not coupled with Suit Type
		//GetEquipment is a protected method, accesible only inside a class hierarchy
		protected abstract string GetSuit(); 
    }
}
