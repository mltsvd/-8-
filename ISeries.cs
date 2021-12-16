using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_8
{
    public interface ISeries
    {
        
        int GetNext();
        void Reset();
        void SetStart(int x);

    }
}




