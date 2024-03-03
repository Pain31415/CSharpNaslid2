using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNaslid2
{
    public interface IOutput
    {
        void Show();
        void Show(string info);
    }
}
