using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
public static class _ISecurityEncodable
{
    
public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.ISecurityEncodable> ISecurityEncodableValue)
{
    return Observable.Select(ISecurityEncodableValue, (ISecurityEncodableValueLambda) => ISecurityEncodableValueLambda.ToXml());
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.ISecurityEncodable> ISecurityEncodableValue, IObservable<System.Security.SecurityElement> e)
{
    return ObservableExt.ZipExecute(ISecurityEncodableValue, e, (ISecurityEncodableValueLambda, eLambda) => ISecurityEncodableValueLambda.FromXml(eLambda));
}

}
}