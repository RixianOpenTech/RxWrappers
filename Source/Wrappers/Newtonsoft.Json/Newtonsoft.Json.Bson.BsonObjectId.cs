using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Bson
{
    public static class __BsonObjectId
    {
        
        public static IObservable<System.Byte[]> get_Value(this IObservable<Newtonsoft.Json.Bson.BsonObjectId> BsonObjectIdValue)
        {
            return Observable.Select(BsonObjectIdValue, (BsonObjectIdValueLambda) => BsonObjectIdValueLambda.Value);
        }

    }
}