using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __FormatterServices
    {
        
        public static IObservable<System.Reflection.MemberInfo[]> GetSerializableMembers(IObservable<System.Type> type)
        {
            return Observable.Select(type, (typeLambda) => System.Runtime.Serialization.FormatterServices.GetSerializableMembers(typeLambda));
        }


        public static IObservable<System.Reflection.MemberInfo[]> GetSerializableMembers(IObservable<System.Type> type, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return Observable.Zip(type, context, (typeLambda, contextLambda) => System.Runtime.Serialization.FormatterServices.GetSerializableMembers(typeLambda, contextLambda));
        }


        public static IObservable<System.Reactive.Unit> CheckTypeSecurity(IObservable<System.Type> t, IObservable<System.Runtime.Serialization.Formatters.TypeFilterLevel> securityLevel)
        {
            return ObservableExt.ZipExecute(t, securityLevel, (tLambda, securityLevelLambda) => System.Runtime.Serialization.FormatterServices.CheckTypeSecurity(tLambda, securityLevelLambda));
        }


        public static IObservable<System.Object> GetUninitializedObject(IObservable<System.Type> type)
        {
            return Observable.Select(type, (typeLambda) => System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeLambda));
        }


        public static IObservable<System.Object> GetSafeUninitializedObject(IObservable<System.Type> type)
        {
            return Observable.Select(type, (typeLambda) => System.Runtime.Serialization.FormatterServices.GetSafeUninitializedObject(typeLambda));
        }


        public static IObservable<System.Object> PopulateObjectMembers(IObservable<System.Object> obj, IObservable<System.Reflection.MemberInfo[]> members, IObservable<System.Object[]> data)
        {
            return Observable.Zip(obj, members, data, (objLambda, membersLambda, dataLambda) => System.Runtime.Serialization.FormatterServices.PopulateObjectMembers(objLambda, membersLambda, dataLambda));
        }


        public static IObservable<System.Object[]> GetObjectData(IObservable<System.Object> obj, IObservable<System.Reflection.MemberInfo[]> members)
        {
            return Observable.Zip(obj, members, (objLambda, membersLambda) => System.Runtime.Serialization.FormatterServices.GetObjectData(objLambda, membersLambda));
        }


        public static IObservable<System.Runtime.Serialization.ISerializationSurrogate> GetSurrogateForCyclicalReference(IObservable<System.Runtime.Serialization.ISerializationSurrogate> innerSurrogate)
        {
            return Observable.Select(innerSurrogate, (innerSurrogateLambda) => System.Runtime.Serialization.FormatterServices.GetSurrogateForCyclicalReference(innerSurrogateLambda));
        }


        public static IObservable<System.Type> GetTypeFromAssembly(IObservable<System.Reflection.Assembly> assem, IObservable<System.String> name)
        {
            return Observable.Zip(assem, name, (assemLambda, nameLambda) => System.Runtime.Serialization.FormatterServices.GetTypeFromAssembly(assemLambda, nameLambda));
        }

    }
}