using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class ___Exception
    {
        public static IObservable<System.String> ToString(
            this IObservable<System.Runtime.InteropServices._Exception> _ExceptionValue)
        {
            return Observable.Select(_ExceptionValue, (_ExceptionValueLambda) => _ExceptionValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Runtime.InteropServices._Exception> _ExceptionValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(_ExceptionValue, obj,
                (_ExceptionValueLambda, objLambda) => _ExceptionValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Runtime.InteropServices._Exception> _ExceptionValue)
        {
            return Observable.Select(_ExceptionValue, (_ExceptionValueLambda) => _ExceptionValueLambda.GetHashCode());
        }


        public static IObservable<System.Type> GetType(
            this IObservable<System.Runtime.InteropServices._Exception> _ExceptionValue)
        {
            return Observable.Select(_ExceptionValue, (_ExceptionValueLambda) => _ExceptionValueLambda.GetType());
        }


        public static IObservable<System.Exception> GetBaseException(
            this IObservable<System.Runtime.InteropServices._Exception> _ExceptionValue)
        {
            return Observable.Select(_ExceptionValue,
                (_ExceptionValueLambda) => _ExceptionValueLambda.GetBaseException());
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.Runtime.InteropServices._Exception> _ExceptionValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(_ExceptionValue, info, context,
                (_ExceptionValueLambda, infoLambda, contextLambda) =>
                    _ExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.String> get_Message(
            this IObservable<System.Runtime.InteropServices._Exception> _ExceptionValue)
        {
            return Observable.Select(_ExceptionValue, (_ExceptionValueLambda) => _ExceptionValueLambda.Message);
        }


        public static IObservable<System.String> get_StackTrace(
            this IObservable<System.Runtime.InteropServices._Exception> _ExceptionValue)
        {
            return Observable.Select(_ExceptionValue, (_ExceptionValueLambda) => _ExceptionValueLambda.StackTrace);
        }


        public static IObservable<System.String> get_HelpLink(
            this IObservable<System.Runtime.InteropServices._Exception> _ExceptionValue)
        {
            return Observable.Select(_ExceptionValue, (_ExceptionValueLambda) => _ExceptionValueLambda.HelpLink);
        }


        public static IObservable<System.String> get_Source(
            this IObservable<System.Runtime.InteropServices._Exception> _ExceptionValue)
        {
            return Observable.Select(_ExceptionValue, (_ExceptionValueLambda) => _ExceptionValueLambda.Source);
        }


        public static IObservable<System.Exception> get_InnerException(
            this IObservable<System.Runtime.InteropServices._Exception> _ExceptionValue)
        {
            return Observable.Select(_ExceptionValue, (_ExceptionValueLambda) => _ExceptionValueLambda.InnerException);
        }


        public static IObservable<System.Reflection.MethodBase> get_TargetSite(
            this IObservable<System.Runtime.InteropServices._Exception> _ExceptionValue)
        {
            return Observable.Select(_ExceptionValue, (_ExceptionValueLambda) => _ExceptionValueLambda.TargetSite);
        }


        public static IObservable<System.Reactive.Unit> set_HelpLink(
            this IObservable<System.Runtime.InteropServices._Exception> _ExceptionValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(_ExceptionValue, value,
                (_ExceptionValueLambda, valueLambda) => _ExceptionValueLambda.HelpLink = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Source(
            this IObservable<System.Runtime.InteropServices._Exception> _ExceptionValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(_ExceptionValue, value,
                (_ExceptionValueLambda, valueLambda) => _ExceptionValueLambda.Source = valueLambda);
        }
    }
}