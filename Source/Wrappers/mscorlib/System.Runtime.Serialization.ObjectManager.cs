using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
public static class _ObjectManager
{
    
public static IObservable<System.Reactive.Unit> RecordFixup(this IObservable<System.Runtime.Serialization.ObjectManager> ObjectManagerValue, IObservable<System.Int64> objectToBeFixed, IObservable<System.Reflection.MemberInfo> member, IObservable<System.Int64> objectRequired)
{
    return ObservableExt.ZipExecute(ObjectManagerValue, objectToBeFixed, member, objectRequired, (ObjectManagerValueLambda, objectToBeFixedLambda, memberLambda, objectRequiredLambda) => ObjectManagerValueLambda.RecordFixup(objectToBeFixedLambda, memberLambda, objectRequiredLambda));
}


public static IObservable<System.Reactive.Unit> RecordDelayedFixup(this IObservable<System.Runtime.Serialization.ObjectManager> ObjectManagerValue, IObservable<System.Int64> objectToBeFixed, IObservable<System.String> memberName, IObservable<System.Int64> objectRequired)
{
    return ObservableExt.ZipExecute(ObjectManagerValue, objectToBeFixed, memberName, objectRequired, (ObjectManagerValueLambda, objectToBeFixedLambda, memberNameLambda, objectRequiredLambda) => ObjectManagerValueLambda.RecordDelayedFixup(objectToBeFixedLambda, memberNameLambda, objectRequiredLambda));
}


public static IObservable<System.Reactive.Unit> RecordArrayElementFixup(this IObservable<System.Runtime.Serialization.ObjectManager> ObjectManagerValue, IObservable<System.Int64> arrayToBeFixed, IObservable<System.Int32[]> indices, IObservable<System.Int64> objectRequired)
{
    return ObservableExt.ZipExecute(ObjectManagerValue, arrayToBeFixed, indices, objectRequired, (ObjectManagerValueLambda, arrayToBeFixedLambda, indicesLambda, objectRequiredLambda) => ObjectManagerValueLambda.RecordArrayElementFixup(arrayToBeFixedLambda, indicesLambda, objectRequiredLambda));
}


public static IObservable<System.Object> GetObject(this IObservable<System.Runtime.Serialization.ObjectManager> ObjectManagerValue, IObservable<System.Int64> objectID)
{
    return Observable.Zip(ObjectManagerValue, objectID, (ObjectManagerValueLambda, objectIDLambda) => ObjectManagerValueLambda.GetObject(objectIDLambda));
}


public static IObservable<System.Reactive.Unit> RegisterObject(this IObservable<System.Runtime.Serialization.ObjectManager> ObjectManagerValue, IObservable<System.Object> obj, IObservable<System.Int64> objectID)
{
    return ObservableExt.ZipExecute(ObjectManagerValue, obj, objectID, (ObjectManagerValueLambda, objLambda, objectIDLambda) => ObjectManagerValueLambda.RegisterObject(objLambda, objectIDLambda));
}


public static IObservable<System.Reactive.Unit> RegisterObject(this IObservable<System.Runtime.Serialization.ObjectManager> ObjectManagerValue, IObservable<System.Object> obj, IObservable<System.Int64> objectID, IObservable<System.Runtime.Serialization.SerializationInfo> info)
{
    return ObservableExt.ZipExecute(ObjectManagerValue, obj, objectID, info, (ObjectManagerValueLambda, objLambda, objectIDLambda, infoLambda) => ObjectManagerValueLambda.RegisterObject(objLambda, objectIDLambda, infoLambda));
}


public static IObservable<System.Reactive.Unit> RegisterObject(this IObservable<System.Runtime.Serialization.ObjectManager> ObjectManagerValue, IObservable<System.Object> obj, IObservable<System.Int64> objectID, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Int64> idOfContainingObj, IObservable<System.Reflection.MemberInfo> member)
{
    return ObservableExt.ZipExecute(ObjectManagerValue, obj, objectID, info, idOfContainingObj, member, (ObjectManagerValueLambda, objLambda, objectIDLambda, infoLambda, idOfContainingObjLambda, memberLambda) => ObjectManagerValueLambda.RegisterObject(objLambda, objectIDLambda, infoLambda, idOfContainingObjLambda, memberLambda));
}


public static IObservable<System.Reactive.Unit> RegisterObject(this IObservable<System.Runtime.Serialization.ObjectManager> ObjectManagerValue, IObservable<System.Object> obj, IObservable<System.Int64> objectID, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Int64> idOfContainingObj, IObservable<System.Reflection.MemberInfo> member, IObservable<System.Int32[]> arrayIndex)
{
    return ObservableExt.ZipExecute(ObjectManagerValue, obj, objectID, info, idOfContainingObj, member, arrayIndex, (ObjectManagerValueLambda, objLambda, objectIDLambda, infoLambda, idOfContainingObjLambda, memberLambda, arrayIndexLambda) => ObjectManagerValueLambda.RegisterObject(objLambda, objectIDLambda, infoLambda, idOfContainingObjLambda, memberLambda, arrayIndexLambda));
}


public static IObservable<System.Reactive.Unit> DoFixups(this IObservable<System.Runtime.Serialization.ObjectManager> ObjectManagerValue)
{
    return Observable.Do(ObjectManagerValue, (ObjectManagerValueLambda) => ObjectManagerValueLambda.DoFixups()).ToUnit();
}


public static IObservable<System.Reactive.Unit> RecordArrayElementFixup(this IObservable<System.Runtime.Serialization.ObjectManager> ObjectManagerValue, IObservable<System.Int64> arrayToBeFixed, IObservable<System.Int32> index, IObservable<System.Int64> objectRequired)
{
    return ObservableExt.ZipExecute(ObjectManagerValue, arrayToBeFixed, index, objectRequired, (ObjectManagerValueLambda, arrayToBeFixedLambda, indexLambda, objectRequiredLambda) => ObjectManagerValueLambda.RecordArrayElementFixup(arrayToBeFixedLambda, indexLambda, objectRequiredLambda));
}


public static IObservable<System.Reactive.Unit> RaiseDeserializationEvent(this IObservable<System.Runtime.Serialization.ObjectManager> ObjectManagerValue)
{
    return Observable.Do(ObjectManagerValue, (ObjectManagerValueLambda) => ObjectManagerValueLambda.RaiseDeserializationEvent()).ToUnit();
}


public static IObservable<System.Reactive.Unit> RaiseOnDeserializingEvent(this IObservable<System.Runtime.Serialization.ObjectManager> ObjectManagerValue, IObservable<System.Object> obj)
{
    return ObservableExt.ZipExecute(ObjectManagerValue, obj, (ObjectManagerValueLambda, objLambda) => ObjectManagerValueLambda.RaiseOnDeserializingEvent(objLambda));
}

}
}