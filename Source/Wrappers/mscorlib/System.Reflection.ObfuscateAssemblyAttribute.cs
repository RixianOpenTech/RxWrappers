using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __ObfuscateAssemblyAttribute
    {
        public static IObservable<System.Boolean> get_AssemblyIsPrivate(
            this IObservable<System.Reflection.ObfuscateAssemblyAttribute> ObfuscateAssemblyAttributeValue)
        {
            return Observable.Select(ObfuscateAssemblyAttributeValue,
                (ObfuscateAssemblyAttributeValueLambda) => ObfuscateAssemblyAttributeValueLambda.AssemblyIsPrivate);
        }


        public static IObservable<System.Boolean> get_StripAfterObfuscation(
            this IObservable<System.Reflection.ObfuscateAssemblyAttribute> ObfuscateAssemblyAttributeValue)
        {
            return Observable.Select(ObfuscateAssemblyAttributeValue,
                (ObfuscateAssemblyAttributeValueLambda) => ObfuscateAssemblyAttributeValueLambda.StripAfterObfuscation);
        }


        public static IObservable<System.Reactive.Unit> set_StripAfterObfuscation(
            this IObservable<System.Reflection.ObfuscateAssemblyAttribute> ObfuscateAssemblyAttributeValue,
            IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(ObfuscateAssemblyAttributeValue, value,
                (ObfuscateAssemblyAttributeValueLambda, valueLambda) =>
                    ObfuscateAssemblyAttributeValueLambda.StripAfterObfuscation = valueLambda);
        }
    }
}