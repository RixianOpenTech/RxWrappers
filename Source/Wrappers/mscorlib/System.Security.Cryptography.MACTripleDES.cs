using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __MACTripleDES
    {
        
        public static IObservable<System.Reactive.Unit> Initialize(this IObservable<System.Security.Cryptography.MACTripleDES> MACTripleDESValue)
        {
            return Observable.Do(MACTripleDESValue, (MACTripleDESValueLambda) => MACTripleDESValueLambda.Initialize()).ToUnit();
        }


        public static IObservable<System.Security.Cryptography.PaddingMode> get_Padding(this IObservable<System.Security.Cryptography.MACTripleDES> MACTripleDESValue)
        {
            return Observable.Select(MACTripleDESValue, (MACTripleDESValueLambda) => MACTripleDESValueLambda.Padding);
        }


        public static IObservable<System.Reactive.Unit> set_Padding(this IObservable<System.Security.Cryptography.MACTripleDES> MACTripleDESValue, IObservable<System.Security.Cryptography.PaddingMode> value)
        {
            return ObservableExt.ZipExecute(MACTripleDESValue, value, (MACTripleDESValueLambda, valueLambda) => MACTripleDESValueLambda.Padding = valueLambda);
        }

    }
}