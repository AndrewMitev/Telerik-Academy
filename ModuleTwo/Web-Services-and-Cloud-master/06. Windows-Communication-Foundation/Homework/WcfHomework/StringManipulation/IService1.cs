using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace StringManipulation
{

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int NumberOfOccurances(string str1, string str2);
    }
}
