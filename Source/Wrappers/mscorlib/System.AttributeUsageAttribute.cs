using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _AttributeUsageAttribute
{
    
public static IObservable<System.AttributeTargets> get_ValidOn(this IObservable<System.AttributeUsageAttribute> AttributeUsageAttributeValue)
{
    return Observable.Select(AttributeUsageAttributeValue, (AttributeUsageAttributeValueLambda) => AttributeUsageAttributeValueLambda.ValidOn);
}


public static IObservable<System.Boolean> get_AllowMultiple(this IObservable<System.AttributeUsageAttribute> AttributeUsageAttributeValue)
{
    return Observable.Select(AttributeUsageAttributeValue, (AttributeUsageAttributeValueLambda) => AttributeUsageAttributeValueLambda.AllowMultiple);
}


public static IObservable<System.Boolean> get_Inherited(this IObservable<System.AttributeUsageAttribute> AttributeUsageAttributeValue)
{
    return Observable.Select(AttributeUsageAttributeValue, (AttributeUsageAttributeValueLambda) => AttributeUsageAttributeValueLambda.Inherited);
}


public static IObservable<System.Reactive.Unit> set_AllowMultiple(this IObservable<System.AttributeUsageAttribute> AttributeUsageAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(AttributeUsageAttributeValue, value, (AttributeUsageAttributeValueLambda, valueLambda) => AttributeUsageAttributeValueLambda.AllowMultiple = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Inherited(this IObservable<System.AttributeUsageAttribute> AttributeUsageAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(AttributeUsageAttributeValue, value, (AttributeUsageAttributeValueLambda, valueLambda) => AttributeUsageAttributeValueLambda.Inherited = valueLambda);
}

}
}