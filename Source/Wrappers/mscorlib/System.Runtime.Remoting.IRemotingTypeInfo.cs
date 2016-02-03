using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
    public static class __IRemotingTypeInfo
    {
        
        public static IObservable<System.Boolean> CanCastTo(this IObservable<System.Runtime.Remoting.IRemotingTypeInfo> IRemotingTypeInfoValue, IObservable<System.Type> fromType, IObservable<System.Object> o)
        {
            return Observable.Zip(IRemotingTypeInfoValue, fromType, o, (IRemotingTypeInfoValueLambda, fromTypeLambda, oLambda) => IRemotingTypeInfoValueLambda.CanCastTo(fromTypeLambda, oLambda));
        }


        public static IObservable<System.String> get_TypeName(this IObservable<System.Runtime.Remoting.IRemotingTypeInfo> IRemotingTypeInfoValue)
        {
            return Observable.Select(IRemotingTypeInfoValue, (IRemotingTypeInfoValueLambda) => IRemotingTypeInfoValueLambda.TypeName);
        }


        public static IObservable<System.Reactive.Unit> set_TypeName(this IObservable<System.Runtime.Remoting.IRemotingTypeInfo> IRemotingTypeInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(IRemotingTypeInfoValue, value, (IRemotingTypeInfoValueLambda, valueLambda) => IRemotingTypeInfoValueLambda.TypeName = valueLambda);
        }

    }
}