using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TellMeDayService
{
    [ServiceContract]
    public interface IDateService
    {

        [OperationContract]
        string TellMeTheDay(DateTime date);
    }
}