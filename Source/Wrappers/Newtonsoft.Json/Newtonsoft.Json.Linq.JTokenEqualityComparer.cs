using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __JTokenEqualityComparer
    {
        
        public static IObservable<System.Boolean> Equals(this IObservable<Newtonsoft.Json.Linq.JTokenEqualityComparer> JTokenEqualityComparerValue, IObservable<Newtonsoft.Json.Linq.JToken> x, IObservable<Newtonsoft.Json.Linq.JToken> y)
        {
            return Observable.Zip(JTokenEqualityComparerValue, x, y, (JTokenEqualityComparerValueLambda, xLambda, yLambda) => JTokenEqualityComparerValueLambda.Equals(xLambda, yLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<Newtonsoft.Json.Linq.JTokenEqualityComparer> JTokenEqualityComparerValue, IObservable<Newtonsoft.Json.Linq.JToken> obj)
        {
            return Observable.Zip(JTokenEqualityComparerValue, obj, (JTokenEqualityComparerValueLambda, objLambda) => JTokenEqualityComparerValueLambda.GetHashCode(objLambda));
        }

    }
}