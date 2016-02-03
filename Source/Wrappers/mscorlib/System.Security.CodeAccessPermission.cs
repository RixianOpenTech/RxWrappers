using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
    public static class __CodeAccessPermission
    {
        
        public static IObservable<System.Reactive.Unit> RevertAssert()
        {
            return ObservableExt.Factory(() => System.Security.CodeAccessPermission.RevertAssert());
        }


        public static IObservable<System.Reactive.Unit> RevertDeny()
        {
            return ObservableExt.Factory(() => System.Security.CodeAccessPermission.RevertDeny());
        }


        public static IObservable<System.Reactive.Unit> RevertPermitOnly()
        {
            return ObservableExt.Factory(() => System.Security.CodeAccessPermission.RevertPermitOnly());
        }


        public static IObservable<System.Reactive.Unit> RevertAll()
        {
            return ObservableExt.Factory(() => System.Security.CodeAccessPermission.RevertAll());
        }


        public static IObservable<System.Reactive.Unit> Demand(this IObservable<System.Security.CodeAccessPermission> CodeAccessPermissionValue)
        {
            return Observable.Do(CodeAccessPermissionValue, (CodeAccessPermissionValueLambda) => CodeAccessPermissionValueLambda.Demand()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Assert(this IObservable<System.Security.CodeAccessPermission> CodeAccessPermissionValue)
        {
            return Observable.Do(CodeAccessPermissionValue, (CodeAccessPermissionValueLambda) => CodeAccessPermissionValueLambda.Assert()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Deny(this IObservable<System.Security.CodeAccessPermission> CodeAccessPermissionValue)
        {
            return Observable.Do(CodeAccessPermissionValue, (CodeAccessPermissionValueLambda) => CodeAccessPermissionValueLambda.Deny()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> PermitOnly(this IObservable<System.Security.CodeAccessPermission> CodeAccessPermissionValue)
        {
            return Observable.Do(CodeAccessPermissionValue, (CodeAccessPermissionValueLambda) => CodeAccessPermissionValueLambda.PermitOnly()).ToUnit();
        }


        public static IObservable<System.Security.IPermission> Union(this IObservable<System.Security.CodeAccessPermission> CodeAccessPermissionValue, IObservable<System.Security.IPermission> other)
        {
            return Observable.Zip(CodeAccessPermissionValue, other, (CodeAccessPermissionValueLambda, otherLambda) => CodeAccessPermissionValueLambda.Union(otherLambda));
        }


        public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.CodeAccessPermission> CodeAccessPermissionValue)
        {
            return Observable.Select(CodeAccessPermissionValue, (CodeAccessPermissionValueLambda) => CodeAccessPermissionValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.CodeAccessPermission> CodeAccessPermissionValue, IObservable<System.Security.SecurityElement> elem)
        {
            return ObservableExt.ZipExecute(CodeAccessPermissionValue, elem, (CodeAccessPermissionValueLambda, elemLambda) => CodeAccessPermissionValueLambda.FromXml(elemLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Security.CodeAccessPermission> CodeAccessPermissionValue)
        {
            return Observable.Select(CodeAccessPermissionValue, (CodeAccessPermissionValueLambda) => CodeAccessPermissionValueLambda.ToString());
        }


        public static IObservable<System.Security.IPermission> Copy(this IObservable<System.Security.CodeAccessPermission> CodeAccessPermissionValue)
        {
            return Observable.Select(CodeAccessPermissionValue, (CodeAccessPermissionValueLambda) => CodeAccessPermissionValueLambda.Copy());
        }


        public static IObservable<System.Security.IPermission> Intersect(this IObservable<System.Security.CodeAccessPermission> CodeAccessPermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(CodeAccessPermissionValue, target, (CodeAccessPermissionValueLambda, targetLambda) => CodeAccessPermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Boolean> IsSubsetOf(this IObservable<System.Security.CodeAccessPermission> CodeAccessPermissionValue, IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(CodeAccessPermissionValue, target, (CodeAccessPermissionValueLambda, targetLambda) => CodeAccessPermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.CodeAccessPermission> CodeAccessPermissionValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(CodeAccessPermissionValue, obj, (CodeAccessPermissionValueLambda, objLambda) => CodeAccessPermissionValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.CodeAccessPermission> CodeAccessPermissionValue)
        {
            return Observable.Select(CodeAccessPermissionValue, (CodeAccessPermissionValueLambda) => CodeAccessPermissionValueLambda.GetHashCode());
        }

    }
}