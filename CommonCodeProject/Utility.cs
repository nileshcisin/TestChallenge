using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCodeProject
{
    public sealed class Utility
    {

        private static Utility? _UtilityObj;

        public static Utility GetUtilityInstant
        {
            get
            {
                _UtilityObj ??= new Utility();                
                return _UtilityObj;

            }            
        }
        private Utility()
        {            
            //do nothing
        }
 
        public string[] ReadTxtFile(string FilePath)
        {
            string[] lines = File.ReadAllLines(FilePath);
            return lines;
        }

    }
}
