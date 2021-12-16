using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_8
{
    class Chisla : IComparable, ICloneable
    {
         public int val,kol;
        public Chisla()
        {
            
            val = 0;
            kol = 0;
        }
        //public int Next
        //{
        //   get { return GetNext(int kol); }
        //}
        public int GetNext(int val,int kol)
        {
            //Random rnd = new Random();
            for (int i = 0; i < kol; i++)
            {
                //val = rnd.Next(2, 100);
                if (val % val != 0) return val=0; 
            }
            return val;
        }
        
        public Chisla ShallowClone()
        {
            return (Chisla)this.MemberwiseClone();
        }
        public object Clone()
        {
            Chisla chislo = new Chisla();
            chislo.val = this.val;
            return chislo;
        }
        public int CompareTo(object obj)
        {

           Chisla temp = (Chisla)obj;

            if (this.val > temp.val) return 1;
            if (this.val < temp.val) return -1;
            return 0;
        }
    }
}
