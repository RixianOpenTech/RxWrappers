using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _CustomAttributeTypedArgument
{
    
public static IObservable<System.String> ToString(this IObservable<System.Reflection.CustomAttributeTypedArgument> CustomAttributeTypedArgumentValue)
{
    return Observable.Select(CustomAttributeTypedArgumentValue, (CustomAttributeTypedArgumentValueLambda) => CustomAttributeTypedArgumentValueLambda.ToString());
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.CustomAttributeTypedArgument> CustomAttributeTypedArgumentValue)
{
    return Observable.Select(CustomAttributeTypedArgumentValue, (CustomAttributeTypedArgumentValueLambda) => CustomAttributeTypedArgumentValueLambda.GetHashCode());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.CustomAttributeTypedArgument> CustomAttributeTypedArgumentValue, IObservable<System.Object> obj)
{
    return Observable.Zip(CustomAttributeTypedArgumentValue, obj, (CustomAttributeTypedArgumentValueLambda, objLambda) => CustomAttributeTypedArgumentValueLambda.Equals(objLambda));
}


public static IObservable<System.Type> get_ArgumentType(this IObservable<System.Reflection.CustomAttributeTypedArgument> CustomAttributeTypedArgumentValue)
{
    return Observable.Select(CustomAttributeTypedArgumentValue, (CustomAttributeTypedArgumentValueLambda) => CustomAttributeTypedArgumentValueLambda.ArgumentType);
}


public static IObservable<System.Object> get_Value(this IObservable<System.Reflection.CustomAttributeTypedArgument> CustomAttributeTypedArgumentValue)
{
    return Observable.Select(CustomAttributeTypedArgumentValue, (CustomAttributeTypedArgumentValueLambda) => CustomAttributeTypedArgumentValueLambda.Value);
}

}
}