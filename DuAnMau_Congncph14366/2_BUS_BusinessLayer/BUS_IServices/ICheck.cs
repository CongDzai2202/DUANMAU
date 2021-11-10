using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface ICheck
    {
        bool checkString(string input);
        bool checkNumber(string input);
        bool checkNull(string text);
    }
}
