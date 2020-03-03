using System;
using System.Collections.Generic;
using System.Text;

namespace pokémon
{
    class pokemon
    {
		private int _HP_Base;
		private int _Attack_Base;
		private int _Defense_Base;
		private int _SpecialAttack_Base;
		private int _SpecialDefense_Base;
		private int _Speed_Base;
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
			get { return  _Defense_Base; }
			set {  _Defense_Base = value; }
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


	}
}
