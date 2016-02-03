using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __OptionalFieldAttribute
    {
        
        public static IObservable<System.Int32> get_VersionAdded(this IObservable<System.Runtime.Serialization.OptionalFieldAttribute> OptionalFieldAttributeValue)
        {
            return Observable.Select(OptionalFieldAttributeValue, (OptionalFieldAttributeValueLambda) => OptionalFieldAttributeValueLambda.VersionAdded);
        }


        public static IObservable<System.Reactive.Unit> set_VersionAdded(this IObservable<System.Runtime.Serialization.OptionalFieldAttribute> OptionalFieldAttributeValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(OptionalFieldAttributeValue, value, (OptionalFieldAttributeValueLambda, valueLambda) => OptionalFieldAttributeValueLambda.VersionAdded = valueLambda);
        }

    }
}