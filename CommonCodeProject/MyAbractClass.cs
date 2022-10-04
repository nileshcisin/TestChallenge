using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CommonCodeProject
{
    public class Entity
    {
        public string Name { get; set; }
        public int value1 { get; set; }
        public int value2 { get; set; }
        public int Difference { get; set; }

    }
    public abstract class MyAbractClass
    {
        public string DataFilePath;



        public abstract List<Entity> GetData();

        public Entity GetAbsoluteDifferenceEntity(List<Entity> ListofEntity)
        {
            return ListofEntity.OrderBy(o => o.Difference).First();

        }
    }


}
