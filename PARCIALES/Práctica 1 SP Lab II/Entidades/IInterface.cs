using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IInterface
    {
        bool serializarXml(string path);

        bool deserealizarXml(string path);
    }
}
