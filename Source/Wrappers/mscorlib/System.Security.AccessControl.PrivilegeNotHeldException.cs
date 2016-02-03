using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __PrivilegeNotHeldException
    {
        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.Security.AccessControl.PrivilegeNotHeldException> PrivilegeNotHeldExceptionValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(PrivilegeNotHeldExceptionValue, info, context,
                (PrivilegeNotHeldExceptionValueLambda, infoLambda, contextLambda) =>
                    PrivilegeNotHeldExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.String> get_PrivilegeName(
            this IObservable<System.Security.AccessControl.PrivilegeNotHeldException> PrivilegeNotHeldExceptionValue)
        {
            return Observable.Select(PrivilegeNotHeldExceptionValue,
                (PrivilegeNotHeldExceptionValueLambda) => PrivilegeNotHeldExceptionValueLambda.PrivilegeName);
        }
    }
}