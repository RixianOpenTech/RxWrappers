using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _Version
{
    
public static IObservable<System.Object> Clone(this IObservable<System.Version> VersionValue)
{
    return Observable.Select(VersionValue, (VersionValueLambda) => VersionValueLambda.Clone());
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.Version> VersionValue, IObservable<System.Object> version)
{
    return Observable.Zip(VersionValue, version, (VersionValueLambda, versionLambda) => VersionValueLambda.CompareTo(versionLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.Version> VersionValue, IObservable<System.Version> value)
{
    return Observable.Zip(VersionValue, value, (VersionValueLambda, valueLambda) => VersionValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Version> VersionValue, IObservable<System.Object> obj)
{
    return Observable.Zip(VersionValue, obj, (VersionValueLambda, objLambda) => VersionValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Version> VersionValue, IObservable<System.Version> obj)
{
    return Observable.Zip(VersionValue, obj, (VersionValueLambda, objLambda) => VersionValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Version> VersionValue)
{
    return Observable.Select(VersionValue, (VersionValueLambda) => VersionValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Version> VersionValue)
{
    return Observable.Select(VersionValue, (VersionValueLambda) => VersionValueLambda.ToString());
}


public static IObservable<System.String> ToString(this IObservable<System.Version> VersionValue, IObservable<System.Int32> fieldCount)
{
    return Observable.Zip(VersionValue, fieldCount, (VersionValueLambda, fieldCountLambda) => VersionValueLambda.ToString(fieldCountLambda));
}


public static IObservable<System.Version> Parse(IObservable<System.String> input)
{
    return Observable.Select(input, (inputLambda) => System.Version.Parse(inputLambda));
}


public static IObservable<Tuple<System.Boolean, System.Version>> TryParse(IObservable<System.String> input)
{
    return Observable.Select(input, (inputLambda) => {
System.Version resultOutput = default(System.Version);
var result = System.Version.TryParse(inputLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
}


public static IObservable<System.Int32> get_Major(this IObservable<System.Version> VersionValue)
{
    return Observable.Select(VersionValue, (VersionValueLambda) => VersionValueLambda.Major);
}


public static IObservable<System.Int32> get_Minor(this IObservable<System.Version> VersionValue)
{
    return Observable.Select(VersionValue, (VersionValueLambda) => VersionValueLambda.Minor);
}


public static IObservable<System.Int32> get_Build(this IObservable<System.Version> VersionValue)
{
    return Observable.Select(VersionValue, (VersionValueLambda) => VersionValueLambda.Build);
}


public static IObservable<System.Int32> get_Revision(this IObservable<System.Version> VersionValue)
{
    return Observable.Select(VersionValue, (VersionValueLambda) => VersionValueLambda.Revision);
}


public static IObservable<System.Int16> get_MajorRevision(this IObservable<System.Version> VersionValue)
{
    return Observable.Select(VersionValue, (VersionValueLambda) => VersionValueLambda.MajorRevision);
}


public static IObservable<System.Int16> get_MinorRevision(this IObservable<System.Version> VersionValue)
{
    return Observable.Select(VersionValue, (VersionValueLambda) => VersionValueLambda.MinorRevision);
}

}
}