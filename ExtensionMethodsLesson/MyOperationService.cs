using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsLesson
{
    public class MyOperationService
    {

        OperationService service;

        public MyOperationService()
        {
            service = new OperationService();
        }
        public void DoAll()
        {
            Operation1();
            Operation2();
            Operation3();
            Operation4();
        }
    }
}
