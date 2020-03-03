using System;
using System.Collections.Generic;
using System.Text;

namespace poketester
{
	class pokemon
	{
		private int _HP_Base;
		private int _Attack_Base;
		private int _Defense_Base;
		private int _SpecialAttack_Base;
		private int _SpecialDefense_Base;
		private int _Speed_Base;

		//stats
		public int HP_Base
		{
			get { return _HP_Base; }
			set { _HP_Base = value; }
		}



		public int Attack_Base
		{
			get { return _Attack_Base; }
			set { _Attack_Base = value; }
		}


		public int Defense_Base
		{
			get { return _Defense_Base; }
			set { _Defense_Base = value; }
		}


		public int SpecialAttack_Base
		{
			get { return _SpecialAttack_Base; }
			set { _SpecialAttack_Base = value; }
		}


		public int SpecialDefense_Base
		{
			get { return _SpecialDefense_Base; }
			set { _SpecialDefense_Base = value; }
		}


		public int Speed_Base
		{
			get { return _Speed_Base; }
			set { _Speed_Base = value; }
		}

		//info

		public string Naam { get; set; }
		public string Type { get; set; }
		public int Nummer { get; set; }
		//level
		private int level=1;

		public int Level
		{
			get { return level; }
			private set { level = value; }
		}
		public void Verhooglevel()
		{
			level++;
		}
		//average+total
		public int Average { 
			get { return (HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base) / 6; } 
		}
		public int Total
		{
			get { return (HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base); }
		}

		//Fullstats
		public int HP_Full {
			get {return ((((HP_Base + 50) * Level) / 50) + 10 ); }

				}
		public int Attack_Full
		{
			get { return ((((Attack_Base + 50) * Level) / 50) + 5); }

		}

		public int Defense_Full
		{
			get { return ((((Defense_Base + 50) * Level) / 50) + 5); }

		}

		public int SpecialAttack_Full
		{
			get { return ((((SpecialAttack_Base + 50) * Level) / 50) + 5); }

		}

		public int SpecialDefense_Full
		{
			get { return ((((SpecialDefense_Base + 50) * Level) / 50) + 5); }

		}
		public int Speed_Full
		{
			get { return ((((Speed_Base + 50) * Level) / 50) + 5); }

		}
		public void ShowInfo()
		{
			Console.WriteLine($"{Naam} (level {Level})");
			Console.WriteLine($"Base stats: \n \t * Health = {HP_Base} \n \t * Speed = {Speed_Base} \n \t etc");
			Console.WriteLine($"Full stats: \n\t * Health = {HP_Full} \n\t etc.");
		}

	}

}

