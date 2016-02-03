using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.Expando
{
    public static class __IExpando
    {
        public static IObservable<System.Reflection.FieldInfo> AddField(
            this IObservable<System.Runtime.InteropServices.Expando.IExpando> IExpandoValue,
            IObservable<System.String> name)
        {
            return Observable.Zip(IExpandoValue, name,
                (IExpandoValueLambda, nameLambda) => IExpandoValueLambda.AddField(nameLambda));
        }


        public static IObservable<System.Reflection.PropertyInfo> AddProperty(
            this IObservable<System.Runtime.InteropServices.Expando.IExpando> IExpandoValue,
            IObservable<System.String> name)
        {
            return Observable.Zip(IExpandoValue, name,
                (IExpandoValueLambda, nameLambda) => IExpandoValueLambda.AddProperty(nameLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> AddMethod(
            this IObservable<System.Runtime.InteropServices.Expando.IExpando> IExpandoValue,
            IObservable<System.String> name, IObservable<System.Delegate> method)
        {
            return Observable.Zip(IExpandoValue, name, method,
                (IExpandoValueLambda, nameLambda, methodLambda) =>
                    IExpandoValueLambda.AddMethod(nameLambda, methodLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveMember(
            this IObservable<System.Runtime.InteropServices.Expando.IExpando> IExpandoValue,
            IObservable<System.Reflection.MemberInfo> m)
        {
            return ObservableExt.ZipExecute(IExpandoValue, m,
                (IExpandoValueLambda, mLambda) => IExpandoValueLambda.RemoveMember(mLambda));
        }
    }
}