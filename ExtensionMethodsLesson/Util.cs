using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsLesson
{
    public class Util
    {
        public static void CallAll(OperationService service )
        {
            service.Operation1();
            service.Operation2();
            service.Operation3();
            service.Operation4();
        }
    }
}
