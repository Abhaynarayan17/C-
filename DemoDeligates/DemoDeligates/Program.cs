using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeligates

{
    internal class program {
        public delegate void MyDeligate(long val1, long val2);

        public delegate double DeliMul(double val1, double val2);
        public static void Main(string[] args)
        {
            Calculator ObjC = new Calculator();

            MyDeligate ObjMD = new MyDeligate(ObjC.AddNos);

            DeliMul ObjDM = new DeliMul(ObjC.Multiply);
            ObjDM += new DeliMul(ObjC.Divide);

            // ObjMD.Invoke(101, 5); (or)
            //ObjMD(12, 12);
            ObjDM(10, 5);

            // action predicate and func <read this and find definitons>

        }
    }
    
    
    
    

}
