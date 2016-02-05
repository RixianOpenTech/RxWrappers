using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __JPropertyDescriptor
    {
        
        public static IObservable<System.Boolean> CanResetValue(this IObservable<Newtonsoft.Json.Linq.JPropertyDescriptor> JPropertyDescriptorValue, IObservable<System.Object> component)
        {
            return Observable.Zip(JPropertyDescriptorValue, component, (JPropertyDescriptorValueLambda, componentLambda) => JPropertyDescriptorValueLambda.CanResetValue(componentLambda));
        }


        public static IObservable<System.Object> GetValue(this IObservable<Newtonsoft.Json.Linq.JPropertyDescriptor> JPropertyDescriptorValue, IObservable<System.Object> component)
        {
            return Observable.Zip(JPropertyDescriptorValue, component, (JPropertyDescriptorValueLambda, componentLambda) => JPropertyDescriptorValueLambda.GetValue(componentLambda));
        }


        public static IObservable<System.Reactive.Unit> ResetValue(this IObservable<Newtonsoft.Json.Linq.JPropertyDescriptor> JPropertyDescriptorValue, IObservable<System.Object> component)
        {
            return ObservableExt.ZipExecute(JPropertyDescriptorValue, component, (JPropertyDescriptorValueLambda, componentLambda) => JPropertyDescriptorValueLambda.ResetValue(componentLambda));
        }


        public static IObservable<System.Reactive.Unit> SetValue(this IObservable<Newtonsoft.Json.Linq.JPropertyDescriptor> JPropertyDescriptorValue, IObservable<System.Object> component, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(JPropertyDescriptorValue, component, value, (JPropertyDescriptorValueLambda, componentLambda, valueLambda) => JPropertyDescriptorValueLambda.SetValue(componentLambda, valueLambda));
        }


        public static IObservable<System.Boolean> ShouldSerializeValue(this IObservable<Newtonsoft.Json.Linq.JPropertyDescriptor> JPropertyDescriptorValue, IObservable<System.Object> component)
        {
            return Observable.Zip(JPropertyDescriptorValue, component, (JPropertyDescriptorValueLambda, componentLambda) => JPropertyDescriptorValueLambda.ShouldSerializeValue(componentLambda));
        }


        public static IObservable<System.Type> get_ComponentType(this IObservable<Newtonsoft.Json.Linq.JPropertyDescriptor> JPropertyDescriptorValue)
        {
            return Observable.Select(JPropertyDescriptorValue, (JPropertyDescriptorValueLambda) => JPropertyDescriptorValueLambda.ComponentType);
        }


        public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<Newtonsoft.Json.Linq.JPropertyDescriptor> JPropertyDescriptorValue)
        {
            return Observable.Select(JPropertyDescriptorValue, (JPropertyDescriptorValueLambda) => JPropertyDescriptorValueLambda.IsReadOnly);
        }


        public static IObservable<System.Type> get_PropertyType(this IObservable<Newtonsoft.Json.Linq.JPropertyDescriptor> JPropertyDescriptorValue)
        {
            return Observable.Select(JPropertyDescriptorValue, (JPropertyDescriptorValueLambda) => JPropertyDescriptorValueLambda.PropertyType);
        }

    }
}