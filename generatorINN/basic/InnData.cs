using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace generatorINN
{
    public class InnData : IEquatable<InnData>/*этот класс можно сравнивать с инндата*/, IComparable<InnData> 

    {
        // private object inn;


        public InnData()
        {

        }
        public InnData(string inn)
        {
            Inn = inn;
        }
        public string Inn { get; set; }



        public bool Equals(InnData other)
        {
            if (Object.ReferenceEquals(other, null)) //если объект с которым сравнивает = null
            {
                return false; // то вернуть , т.к. текущий объект есть и он точно не равен пусто
            }
            if (Object.ReferenceEquals(this, other))// если один и тот же объект (две ссылки на один и тот же объект)
            {
                return true;
            }
            return Inn == other.Inn; //везде сравнивается поле, так как проще
        }

        public override int GetHashCode() //оптимизация))
        {
            return Inn.GetHashCode();
        }


        public int CompareTo(InnData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            return Inn.CompareTo(other.Inn);
        } 
    }
}
