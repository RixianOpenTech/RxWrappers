using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
public static class _ParameterBuilder
{
    
public static IObservable<System.Reactive.Unit> SetMarshal(this IObservable<System.Reflection.Emit.ParameterBuilder> ParameterBuilderValue, IObservable<System.Reflection.Emit.UnmanagedMarshal> unmanagedMarshal)
{
    return ObservableExt.ZipExecute(ParameterBuilderValue, unmanagedMarshal, (ParameterBuilderValueLambda, unmanagedMarshalLambda) => ParameterBuilderValueLambda.SetMarshal(unmanagedMarshalLambda));
}


public static IObservable<System.Reactive.Unit> SetConstant(this IObservable<System.Reflection.Emit.ParameterBuilder> ParameterBuilderValue, IObservable<System.Object> defaultValue)
{
    return ObservableExt.ZipExecute(ParameterBuilderValue, defaultValue, (ParameterBuilderValueLambda, defaultValueLambda) => ParameterBuilderValueLambda.SetConstant(defaultValueLambda));
}


public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.ParameterBuilder> ParameterBuilderValue, IObservable<System.Reflection.ConstructorInfo> con, IObservable<System.Byte[]> binaryAttribute)
{
    return ObservableExt.ZipExecute(ParameterBuilderValue, con, binaryAttribute, (ParameterBuilderValueLambda, conLambda, binaryAttributeLambda) => ParameterBuilderValueLambda.SetCustomAttribute(conLambda, binaryAttributeLambda));
}


public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.ParameterBuilder> ParameterBuilderValue, IObservable<System.Reflection.Emit.CustomAttributeBuilder> customBuilder)
{
    return ObservableExt.ZipExecute(ParameterBuilderValue, customBuilder, (ParameterBuilderValueLambda, customBuilderLambda) => ParameterBuilderValueLambda.SetCustomAttribute(customBuilderLambda));
}


public static IObservable<System.Reflection.Emit.ParameterToken> GetToken(this IObservable<System.Reflection.Emit.ParameterBuilder> ParameterBuilderValue)
{
    return Observable.Select(ParameterBuilderValue, (ParameterBuilderValueLambda) => ParameterBuilderValueLambda.GetToken());
}


public static IObservable<System.String> get_Name(this IObservable<System.Reflection.Emit.ParameterBuilder> ParameterBuilderValue)
{
    return Observable.Select(ParameterBuilderValue, (ParameterBuilderValueLambda) => ParameterBuilderValueLambda.Name);
}


public static IObservable<System.Int32> get_Position(this IObservable<System.Reflection.Emit.ParameterBuilder> ParameterBuilderValue)
{
    return Observable.Select(ParameterBuilderValue, (ParameterBuilderValueLambda) => ParameterBuilderValueLambda.Position);
}


public static IObservable<System.Int32> get_Attributes(this IObservable<System.Reflection.Emit.ParameterBuilder> ParameterBuilderValue)
{
    return Observable.Select(ParameterBuilderValue, (ParameterBuilderValueLambda) => ParameterBuilderValueLambda.Attributes);
}


public static IObservable<System.Boolean> get_IsIn(this IObservable<System.Reflection.Emit.ParameterBuilder> ParameterBuilderValue)
{
    return Observable.Select(ParameterBuilderValue, (ParameterBuilderValueLambda) => ParameterBuilderValueLambda.IsIn);
}


public static IObservable<System.Boolean> get_IsOut(this IObservable<System.Reflection.Emit.ParameterBuilder> ParameterBuilderValue)
{
    return Observable.Select(ParameterBuilderValue, (ParameterBuilderValueLambda) => ParameterBuilderValueLambda.IsOut);
}


public static IObservable<System.Boolean> get_IsOptional(this IObservable<System.Reflection.Emit.ParameterBuilder> ParameterBuilderValue)
{
    return Observable.Select(ParameterBuilderValue, (ParameterBuilderValueLambda) => ParameterBuilderValueLambda.IsOptional);
}

}
}