using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Math
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        double Add(double no1,double no2);

        [OperationContract]
        double Sub(double no1, double no2);

        [OperationContract]
        double Mul(double no1, double no2);

       
    }


}
