using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MCDelta_Plus
{
    public abstract class Heart
    {
       public static List<Heart> hearts = new List<Heart>();
		public abstract string URL { get; }
		public abstract string Prepare();
		public virtual string OnPump(StreamReader responseStreamReader)
		{
			string line = ""; int i = 0;
			string URL = "";

            while (line != null)
            {
                i++;
                line = responseStreamReader.ReadLine();
                if (line != null)
                    URL = line;
            }
            responseStreamReader.Close();
            return URL;
		}
	}    
}
