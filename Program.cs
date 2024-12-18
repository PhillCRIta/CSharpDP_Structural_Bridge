using System.Diagnostics;

namespace Structural_Bridge
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 The bridge design pattern decouple an abstraction from its implementation , to make possibile manage the two independently
			 Make simplier managing the inheritance structure make its more adaptabile.
			 Prevent exponential growth of class hierarchy.
			 Use also to refactor code get out of hand.

			 The bridge separates a large class or a set of classes in two separate hierarchies.

			 */
			/*
			 * EXAMPLE
			 * Get correct scuba diving equipments
			 * You must chose the correct SUIT for the correct ambient and temperture (dry suit threelayers, dry suit neoprene, wet suyt);
			 * after that you must choose the accessories for the immersion, like regulator, jacket, cylinder and submarine computer
			 */
			Accessory accessory = new RegulatorAccessory();
			ScubaDivingEquipment regWet = new SuitWet(25, AmbientWater.FrozenLake, accessory);
			ScubaDivingEquipment regThreeL = new SuitDryThreeLayers(25, AmbientWater.FrozenLake, accessory);
			ScubaDivingEquipment regNeop = new SuitDryNeoprene(25, AmbientWater.FrozenLake, accessory);
			Console.WriteLine(regWet.UseCorrectEquipment());
			Console.WriteLine(regThreeL.UseCorrectEquipment());
			Console.WriteLine(regNeop.UseCorrectEquipment());
            Console.WriteLine("***************");
            Console.WriteLine("");

			accessory = new ComputerScubaAccessory();
			regWet = new SuitWet(25, AmbientWater.Sea, accessory);
			regThreeL = new SuitDryThreeLayers(25, AmbientWater.Sea, accessory);
			regNeop = new SuitDryNeoprene(25, AmbientWater.Sea, accessory);
			Console.WriteLine(regWet.UseCorrectEquipment());
			Console.WriteLine(regThreeL.UseCorrectEquipment());
			Console.WriteLine(regNeop.UseCorrectEquipment());
			Console.WriteLine("***************");
			Console.WriteLine("");

			accessory = new JacketAccessory();
			regWet = new SuitWet(25, AmbientWater.Sea, accessory);
			regThreeL = new SuitDryThreeLayers(25, AmbientWater.Sea, accessory);
			regNeop = new SuitDryNeoprene(25, AmbientWater.Sea, accessory);
			Console.WriteLine(regWet.UseCorrectEquipment());
			Console.WriteLine(regThreeL.UseCorrectEquipment());
			Console.WriteLine(regNeop.UseCorrectEquipment());
			Console.WriteLine("***************");
			Console.WriteLine("");

			Debug.WriteLine("");

		}
	}
}
