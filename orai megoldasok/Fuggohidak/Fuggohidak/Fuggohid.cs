using System;

namespace Fuggohidak_linq_2026
{
    public class Fuggohid
	{
		public string Helyezes { get; set; }
		public string Hid { get; set; }
		public string Hely { get; set; }
		public string Orszag { get; set; }
		public int Hossz { get; set; }
		public int Ev { get; set; }

		public Fuggohid(string sor)
		{
			string[] reszek = sor.Split('\t');
			Helyezes = reszek[0];
			Hid = reszek[1];
			Hely = reszek[2];
			Orszag = reszek[3];
			Hossz = Convert.ToInt32(reszek[4]);
			Ev = Convert.ToInt32(reszek[5]);
		}
	}
}