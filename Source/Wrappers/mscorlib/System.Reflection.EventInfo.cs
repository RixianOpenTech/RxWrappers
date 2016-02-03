using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __EventInfo
    {
        public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.EventInfo> EventInfoValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(EventInfoValue, obj,
                (EventInfoValueLambda, objLambda) => EventInfoValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.EventInfo> EventInfoValue)
        {
            return Observable.Select(EventInfoValue, (EventInfoValueLambda) => EventInfoValueLambda.GetHashCode());
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetOtherMethods(
            this IObservable<System.Reflection.EventInfo> EventInfoValue, IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(EventInfoValue, nonPublic,
                (EventInfoValueLambda, nonPublicLambda) => EventInfoValueLambda.GetOtherMethods(nonPublicLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetAddMethod(
            this IObservable<System.Reflection.EventInfo> EventInfoValue, IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(EventInfoValue, nonPublic,
                (EventInfoValueLambda, nonPublicLambda) => EventInfoValueLambda.GetAddMethod(nonPublicLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetRemoveMethod(
            this IObservable<System.Reflection.EventInfo> EventInfoValue, IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(EventInfoValue, nonPublic,
                (EventInfoValueLambda, nonPublicLambda) => EventInfoValueLambda.GetRemoveMethod(nonPublicLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetRaiseMethod(
            this IObservable<System.Reflection.EventInfo> EventInfoValue, IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(EventInfoValue, nonPublic,
                (EventInfoValueLambda, nonPublicLambda) => EventInfoValueLambda.GetRaiseMethod(nonPublicLambda));
        }


        public static IObservable<System.Reflection.MethodInfo[]> GetOtherMethods(
            this IObservable<System.Reflection.EventInfo> EventInfoValue)
        {
            return Observable.Select(EventInfoValue, (EventInfoValueLambda) => EventInfoValueLambda.GetOtherMethods());
        }


        public static IObservable<System.Reflection.MethodInfo> GetAddMethod(
            this IObservable<System.Reflection.EventInfo> EventInfoValue)
        {
            return Observable.Select(EventInfoValue, (EventInfoValueLambda) => EventInfoValueLambda.GetAddMethod());
        }


        public static IObservable<System.Reflection.MethodInfo> GetRemoveMethod(
            this IObservable<System.Reflection.EventInfo> EventInfoValue)
        {
            return Observable.Select(EventInfoValue, (EventInfoValueLambda) => EventInfoValueLambda.GetRemoveMethod());
        }


        public static IObservable<System.Reflection.MethodInfo> GetRaiseMethod(
            this IObservable<System.Reflection.EventInfo> EventInfoValue)
        {
            return Observable.Select(EventInfoValue, (EventInfoValueLambda) => EventInfoValueLambda.GetRaiseMethod());
        }


        public static IObservable<System.Reactive.Unit> AddEventHandler(
            this IObservable<System.Reflection.EventInfo> EventInfoValue, IObservable<System.Object> target,
            IObservable<System.Delegate> handler)
        {
            return ObservableExt.ZipExecute(EventInfoValue, target, handler,
                (EventInfoValueLambda, targetLambda, handlerLambda) =>
                    EventInfoValueLambda.AddEventHandler(targetLambda, handlerLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveEventHandler(
            this IObservable<System.Reflection.EventInfo> EventInfoValue, IObservable<System.Object> target,
            IObservable<System.Delegate> handler)
        {
            return ObservableExt.ZipExecute(EventInfoValue, target, handler,
                (EventInfoValueLambda, targetLambda, handlerLambda) =>
                    EventInfoValueLambda.RemoveEventHandler(targetLambda, handlerLambda));
        }


        public static IObservable<System.Reflection.MemberTypes> get_MemberType(
            this IObservable<System.Reflection.EventInfo> EventInfoValue)
        {
            return Observable.Select(EventInfoValue, (EventInfoValueLambda) => EventInfoValueLambda.MemberType);
        }


        public static IObservable<System.Reflection.EventAttributes> get_Attributes(
            this IObservable<System.Reflection.EventInfo> EventInfoValue)
        {
            return Observable.Select(EventInfoValue, (EventInfoValueLambda) => EventInfoValueLambda.Attributes);
        }


        public static IObservable<System.Reflection.MethodInfo> get_AddMethod(
            this IObservable<System.Reflection.EventInfo> EventInfoValue)
        {
            return Observable.Select(EventInfoValue, (EventInfoValueLambda) => EventInfoValueLambda.AddMethod);
        }


        public static IObservable<System.Reflection.MethodInfo> get_RemoveMethod(
            this IObservable<System.Reflection.EventInfo> EventInfoValue)
        {
            return Observable.Select(EventInfoValue, (EventInfoValueLambda) => EventInfoValueLambda.RemoveMethod);
        }


        public static IObservable<System.Reflection.MethodInfo> get_RaiseMethod(
            this IObservable<System.Reflection.EventInfo> EventInfoValue)
        {
            return Observable.Select(EventInfoValue, (EventInfoValueLambda) => EventInfoValueLambda.RaiseMethod);
        }


        public static IObservable<System.Type> get_EventHandlerType(
            this IObservable<System.Reflection.EventInfo> EventInfoValue)
        {
            return Observable.Select(EventInfoValue, (EventInfoValueLambda) => EventInfoValueLambda.EventHandlerType);
        }


        public static IObservable<System.Boolean> get_IsSpecialName(
            this IObservable<System.Reflection.EventInfo> EventInfoValue)
        {
            return Observable.Select(EventInfoValue, (EventInfoValueLambda) => EventInfoValueLambda.IsSpecialName);
        }


        public static IObservable<System.Boolean> get_IsMulticast(
            this IObservable<System.Reflection.EventInfo> EventInfoValue)
        {
            return Observable.Select(EventInfoValue, (EventInfoValueLambda) => EventInfoValueLambda.IsMulticast);
        }
    }
}