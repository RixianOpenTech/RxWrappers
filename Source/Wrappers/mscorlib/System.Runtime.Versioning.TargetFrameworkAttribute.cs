using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Versioning
{
    public static class __TargetFrameworkAttribute
    {
        public static IObservable<System.String> get_FrameworkName(
            this IObservable<System.Runtime.Versioning.TargetFrameworkAttribute> TargetFrameworkAttributeValue)
        {
            return Observable.Select(TargetFrameworkAttributeValue,
                (TargetFrameworkAttributeValueLambda) => TargetFrameworkAttributeValueLambda.FrameworkName);
        }


        public static IObservable<System.String> get_FrameworkDisplayName(
            this IObservable<System.Runtime.Versioning.TargetFrameworkAttribute> TargetFrameworkAttributeValue)
        {
            return Observable.Select(TargetFrameworkAttributeValue,
                (TargetFrameworkAttributeValueLambda) => TargetFrameworkAttributeValueLambda.FrameworkDisplayName);
        }


        public static IObservable<System.Reactive.Unit> set_FrameworkDisplayName(
            this IObservable<System.Runtime.Versioning.TargetFrameworkAttribute> TargetFrameworkAttributeValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(TargetFrameworkAttributeValue, value,
                (TargetFrameworkAttributeValueLambda, valueLambda) =>
                    TargetFrameworkAttributeValueLambda.FrameworkDisplayName = valueLambda);
        }
    }
}