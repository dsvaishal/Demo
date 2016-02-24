using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Math
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }



        public double Add(double no1, double no2)
        {
            no1 = 30;
            return no1 + no2;
        }

        public double Sub(double no1, double no2)
        {
            return no1 - no2;
        }

        public double Mul(double no1, double no2)
        {
            return no1 * no2;
        }
    }
}
