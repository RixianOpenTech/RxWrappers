using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class ___EventInfo
    {
        
        public static IObservable<System.UInt32> GetTypeInfoCount(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => {
System.UInt32 pcTInfoOutput = default(System.UInt32);
_EventInfoValueLambda.GetTypeInfoCount(out pcTInfoOutput);
return pcTInfoOutput;
});
        }


        public static IObservable<System.Reactive.Unit> GetTypeInfo(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue, IObservable<System.UInt32> iTInfo, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> ppTInfo)
        {
            return ObservableExt.ZipExecute(_EventInfoValue, iTInfo, lcid, ppTInfo, (_EventInfoValueLambda, iTInfoLambda, lcidLambda, ppTInfoLambda) => _EventInfoValueLambda.GetTypeInfo(iTInfoLambda, lcidLambda, ppTInfoLambda));
        }


        public static IObservable<System.Guid> GetIDsOfNames(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue, IObservable<System.Guid> riid, IObservable<System.IntPtr> rgszNames, IObservable<System.UInt32> cNames, IObservable<System.UInt32> lcid, IObservable<System.IntPtr> rgDispId)
        {
            return Observable.Zip(_EventInfoValue, riid, rgszNames, cNames, lcid, rgDispId, (_EventInfoValueLambda, riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda) => {
_EventInfoValueLambda.GetIDsOfNames(ref riidLambda, rgszNamesLambda, cNamesLambda, lcidLambda, rgDispIdLambda);
return riidLambda;
});
        }


        public static IObservable<System.Guid> Invoke(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue, IObservable<System.UInt32> dispIdMember, IObservable<System.Guid> riid, IObservable<System.UInt32> lcid, IObservable<System.Int16> wFlags, IObservable<System.IntPtr> pDispParams, IObservable<System.IntPtr> pVarResult, IObservable<System.IntPtr> pExcepInfo, IObservable<System.IntPtr> puArgErr)
        {
            return Observable.Zip(_EventInfoValue, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr, (_EventInfoValueLambda, dispIdMemberLambda, riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda) => {
_EventInfoValueLambda.Invoke(dispIdMemberLambda, ref riidLambda, lcidLambda, wFlagsLambda, pDispParamsLambda, pVarResultLambda, pExcepInfoLambda, puArgErrLambda);
return riidLambda;
});
        }


        public static IObservable<System.String> ToString(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => _EventInfoValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue, IObservable<System.Object> other)
        {
            return Observable.Zip(_EventInfoValue, other, (_EventInfoValueLambda, otherLambda) => _EventInfoValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => _EventInfoValueLambda.GetHashCode());
        }


        public static IObservable<System.Type> GetType(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => _EventInfoValueLambda.GetType());
        }


        public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_EventInfoValue, attributeType, inherit, (_EventInfoValueLambda, attributeTypeLambda, inheritLambda) => _EventInfoValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_EventInfoValue, inherit, (_EventInfoValueLambda, inheritLambda) => _EventInfoValueLambda.GetCustomAttributes(inheritLambda));
        }


        public static IObservable<System.Boolean> IsDefined(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
        {
            return Observable.Zip(_EventInfoValue, attributeType, inherit, (_EventInfoValueLambda, attributeTypeLambda, inheritLambda) => _EventInfoValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetAddMethod(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue, IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(_EventInfoValue, nonPublic, (_EventInfoValueLambda, nonPublicLambda) => _EventInfoValueLambda.GetAddMethod(nonPublicLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetRemoveMethod(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue, IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(_EventInfoValue, nonPublic, (_EventInfoValueLambda, nonPublicLambda) => _EventInfoValueLambda.GetRemoveMethod(nonPublicLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetRaiseMethod(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue, IObservable<System.Boolean> nonPublic)
        {
            return Observable.Zip(_EventInfoValue, nonPublic, (_EventInfoValueLambda, nonPublicLambda) => _EventInfoValueLambda.GetRaiseMethod(nonPublicLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> GetAddMethod(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => _EventInfoValueLambda.GetAddMethod());
        }


        public static IObservable<System.Reflection.MethodInfo> GetRemoveMethod(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => _EventInfoValueLambda.GetRemoveMethod());
        }


        public static IObservable<System.Reflection.MethodInfo> GetRaiseMethod(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => _EventInfoValueLambda.GetRaiseMethod());
        }


        public static IObservable<System.Reactive.Unit> AddEventHandler(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue, IObservable<System.Object> target, IObservable<System.Delegate> handler)
        {
            return ObservableExt.ZipExecute(_EventInfoValue, target, handler, (_EventInfoValueLambda, targetLambda, handlerLambda) => _EventInfoValueLambda.AddEventHandler(targetLambda, handlerLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveEventHandler(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue, IObservable<System.Object> target, IObservable<System.Delegate> handler)
        {
            return ObservableExt.ZipExecute(_EventInfoValue, target, handler, (_EventInfoValueLambda, targetLambda, handlerLambda) => _EventInfoValueLambda.RemoveEventHandler(targetLambda, handlerLambda));
        }


        public static IObservable<System.Reflection.MemberTypes> get_MemberType(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => _EventInfoValueLambda.MemberType);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => _EventInfoValueLambda.Name);
        }


        public static IObservable<System.Type> get_DeclaringType(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => _EventInfoValueLambda.DeclaringType);
        }


        public static IObservable<System.Type> get_ReflectedType(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => _EventInfoValueLambda.ReflectedType);
        }


        public static IObservable<System.Reflection.EventAttributes> get_Attributes(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => _EventInfoValueLambda.Attributes);
        }


        public static IObservable<System.Type> get_EventHandlerType(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => _EventInfoValueLambda.EventHandlerType);
        }


        public static IObservable<System.Boolean> get_IsSpecialName(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => _EventInfoValueLambda.IsSpecialName);
        }


        public static IObservable<System.Boolean> get_IsMulticast(this IObservable<System.Runtime.InteropServices._EventInfo> _EventInfoValue)
        {
            return Observable.Select(_EventInfoValue, (_EventInfoValueLambda) => _EventInfoValueLambda.IsMulticast);
        }

    }
}