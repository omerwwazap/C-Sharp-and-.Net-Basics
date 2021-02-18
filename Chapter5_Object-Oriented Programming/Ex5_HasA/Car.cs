using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5_HasA
{
	class Car
	{
		// Car 'has-a' Radio.
		private Radio myRadio = new Radio();
		public void TurnOnRadio(bool onOff)
		{
			// Delegate call to inner object.
			myRadio.Power(onOff);
		}
	}
}
