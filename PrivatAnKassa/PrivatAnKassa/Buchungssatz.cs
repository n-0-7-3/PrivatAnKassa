using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections;

using System.Linq;

namespace PrivatAnKassa
{
    public class Buchungssatz 
    {
        
		public List<Tuple<string, double>> BS { get; set; }
		public int SLASH { get; set; }

        public void DisplayStats(){
			if (BS.Count == 2)
            {
                Console.WriteLine($"Soll: {BS[0].ToString()} \n Haben: {BS[1].ToString()} \nSlash ist nach dem {SLASH} Wort");
            }
            else
            {
				if (SLASH == 2)
				{
					Console.WriteLine($"Soll: {BS[0].ToString()} \nHaben: {BS[1].ToString()} \nSteuer: {BS[2]}\nSlash ist nach dem {SLASH}ten Wert");
                }
				else if (SLASH == 4)
				{
					Console.WriteLine($"Soll: {BS[0].ToString()} \nHaben: {BS[2].ToString()} \nSteuer: {BS[1]}\nSlash ist nach dem {SLASH}ten Wert");
				}
			}
		}
        

		public Buchungssatz(){}
		public Buchungssatz(string bsstring)
        {
			this.SLASH = Array.IndexOf(bsstring.Split(' '), "/");
            bsstring = Regex.Replace(bsstring, @"(,-|/)", "");
			List<string> siff3 = bsstring.Split(' ').ToList();
            siff3.RemoveAt(siff3.IndexOf(""));
            int i2 = 0;
            List<Tuple<string, double>> BS = new List<Tuple<string, double>>(3);
            for (int i = 0; i < siff3.Count; i += 2)
            {
				try
				{
					BS.Add(new Tuple<string, double>(siff3[i], double.Parse(siff3[i + 1])));
                }
                catch (Exception)
                {
					Console.Clear();
                    Console.WriteLine("Der Wert muss ein int sein!");
                }
				i2++;               
            }
            this.BS = BS;
        }

    }
}
