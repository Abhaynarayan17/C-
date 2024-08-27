using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirtelCaseStudy1
{
    public enum TypeOfCall
    {
        MM, ML, MSTD, MISD
    }
    public abstract class AirtelCustomer1
    {
        // protected >> Abstraction

        protected string strName, strAdd;
        protected string strCustID;
        protected long lPh, lBal;

        // wrapping protected with public >> Encapsulation

        public string CustomerName { get { return strName; } set { strName = value; } }
        public string CustomerAddress { get { return strAdd; } set { strAdd = value; } }
        public long Balance { get { return lBal; } }
        public long Phone { get { return lPh; } }
        public string CustID { get { return strCustID; } }

        public abstract void RecordCall(long Duration, TypeOfCall TOC);
        public class PrePaid : AirtelCustomer1
        {
            //Fields
            long lVal;
            public long Validity { get { return lVal; } set { lVal = value; } }

            //Method Overloading
            public override void RecordCall(long Duration, TypeOfCall TOC)
            {
                switch (TOC)
                {
                    case TypeOfCall.MM:
                        base.lBal -= (Duration * 1);
                        break;
                    case TypeOfCall.ML:
                        base.lBal -= (Duration * 5);
                        break;
                    case TypeOfCall.MSTD:
                        base.lBal -= (Duration * 10);
                        break;
                    case TypeOfCall.MISD:
                        base.lBal -= (Duration * 15);
                        break;
                    default:
                        break;

                }
            }
            public void Recharge(long Amount)
            {
                lBal += Amount;
            }

        }
        
        public class PostPaid : AirtelCustomer1
        {
            //Fields
            long lCrdtLmt;
            public long CreditLimit { get { return lCrdtLmt; } set { lCrdtLmt = value; } }
            
            public override void RecordCall(long Duration, TypeOfCall TOC)
            {
                switch (TOC)
                {
                    case TypeOfCall.MM:
                        base.lBal += (Duration * 1);
                        break;
                    case TypeOfCall.ML:
                        base.lBal += (Duration * 5);
                        break;
                    case TypeOfCall.MSTD:
                        base.lBal += (Duration * 10);
                        break;
                    case TypeOfCall.MISD:
                        base.lBal += (Duration * 15);
                        break;
                    default:
                        break;
                }
            }
            public void PayBill(long Amount)
            {
                lBal -= Amount;
            }
        }
        

    }
}
