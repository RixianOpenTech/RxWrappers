using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Random
    {
        
        public static IObservable<System.Int32> Next(this IObservable<System.Random> RandomValue)
        {
            return Observable.Select(RandomValue, (RandomValueLambda) => RandomValueLambda.Next());
        }


        public static IObservable<System.Int32> Next(this IObservable<System.Random> RandomValue, IObservable<System.Int32> minValue, IObservable<System.Int32> maxValue)
        {
            return Observable.Zip(RandomValue, minValue, maxValue, (RandomValueLambda, minValueLambda, maxValueLambda) => RandomValueLambda.Next(minValueLambda, maxValueLambda));
        }


        public static IObservable<System.Int32> Next(this IObservable<System.Random> RandomValue, IObservable<System.Int32> maxValue)
        {
            return Observable.Zip(RandomValue, maxValue, (RandomValueLambda, maxValueLambda) => RandomValueLambda.Next(maxValueLambda));
        }


        public static IObservable<System.Double> NextDouble(this IObservable<System.Random> RandomValue)
        {
            return Observable.Select(RandomValue, (RandomValueLambda) => RandomValueLambda.NextDouble());
        }


        public static IObservable<System.Reactive.Unit> NextBytes(this IObservable<System.Random> RandomValue, IObservable<System.Byte[]> buffer)
        {
            return ObservableExt.ZipExecute(RandomValue, buffer, (RandomValueLambda, bufferLambda) => RandomValueLambda.NextBytes(bufferLambda));
        }

    }
}