using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __JsonISerializableContract
    {
        
        public static IObservable<Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>> get_ISerializableCreator(this IObservable<Newtonsoft.Json.Serialization.JsonISerializableContract> JsonISerializableContractValue)
        {
            return Observable.Select(JsonISerializableContractValue, (JsonISerializableContractValueLambda) => JsonISerializableContractValueLambda.ISerializableCreator);
        }


        public static IObservable<System.Reactive.Unit> set_ISerializableCreator(this IObservable<Newtonsoft.Json.Serialization.JsonISerializableContract> JsonISerializableContractValue, IObservable<Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>> value)
        {
            return ObservableExt.ZipExecute(JsonISerializableContractValue, value, (JsonISerializableContractValueLambda, valueLambda) => JsonISerializableContractValueLambda.ISerializableCreator = valueLambda);
        }

    }
}