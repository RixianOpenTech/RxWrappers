using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __ObfuscationAttribute
    {
        
        public static IObservable<System.Boolean> get_StripAfterObfuscation(this IObservable<System.Reflection.ObfuscationAttribute> ObfuscationAttributeValue)
        {
            return Observable.Select(ObfuscationAttributeValue, (ObfuscationAttributeValueLambda) => ObfuscationAttributeValueLambda.StripAfterObfuscation);
        }


        public static IObservable<System.Boolean> get_Exclude(this IObservable<System.Reflection.ObfuscationAttribute> ObfuscationAttributeValue)
        {
            return Observable.Select(ObfuscationAttributeValue, (ObfuscationAttributeValueLambda) => ObfuscationAttributeValueLambda.Exclude);
        }


        public static IObservable<System.Boolean> get_ApplyToMembers(this IObservable<System.Reflection.ObfuscationAttribute> ObfuscationAttributeValue)
        {
            return Observable.Select(ObfuscationAttributeValue, (ObfuscationAttributeValueLambda) => ObfuscationAttributeValueLambda.ApplyToMembers);
        }


        public static IObservable<System.String> get_Feature(this IObservable<System.Reflection.ObfuscationAttribute> ObfuscationAttributeValue)
        {
            return Observable.Select(ObfuscationAttributeValue, (ObfuscationAttributeValueLambda) => ObfuscationAttributeValueLambda.Feature);
        }


        public static IObservable<System.Reactive.Unit> set_StripAfterObfuscation(this IObservable<System.Reflection.ObfuscationAttribute> ObfuscationAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(ObfuscationAttributeValue, value, (ObfuscationAttributeValueLambda, valueLambda) => ObfuscationAttributeValueLambda.StripAfterObfuscation = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Exclude(this IObservable<System.Reflection.ObfuscationAttribute> ObfuscationAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(ObfuscationAttributeValue, value, (ObfuscationAttributeValueLambda, valueLambda) => ObfuscationAttributeValueLambda.Exclude = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ApplyToMembers(this IObservable<System.Reflection.ObfuscationAttribute> ObfuscationAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(ObfuscationAttributeValue, value, (ObfuscationAttributeValueLambda, valueLambda) => ObfuscationAttributeValueLambda.ApplyToMembers = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Feature(this IObservable<System.Reflection.ObfuscationAttribute> ObfuscationAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(ObfuscationAttributeValue, value, (ObfuscationAttributeValueLambda, valueLambda) => ObfuscationAttributeValueLambda.Feature = valueLambda);
        }

    }
}