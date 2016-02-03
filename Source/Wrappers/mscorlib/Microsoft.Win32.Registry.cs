using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Microsoft.Win32
{
    public static class __Registry
    {
        
        public static IObservable<System.Object> GetValue(IObservable<System.String> keyName, IObservable<System.String> valueName, IObservable<System.Object> defaultValue)
        {
            return Observable.Zip(keyName, valueName, defaultValue, (keyNameLambda, valueNameLambda, defaultValueLambda) => Microsoft.Win32.Registry.GetValue(keyNameLambda, valueNameLambda, defaultValueLambda));
        }


        public static IObservable<System.Reactive.Unit> SetValue(IObservable<System.String> keyName, IObservable<System.String> valueName, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(keyName, valueName, value, (keyNameLambda, valueNameLambda, valueLambda) => Microsoft.Win32.Registry.SetValue(keyNameLambda, valueNameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> SetValue(IObservable<System.String> keyName, IObservable<System.String> valueName, IObservable<System.Object> value, IObservable<Microsoft.Win32.RegistryValueKind> valueKind)
        {
            return ObservableExt.ZipExecute(keyName, valueName, value, valueKind, (keyNameLambda, valueNameLambda, valueLambda, valueKindLambda) => Microsoft.Win32.Registry.SetValue(keyNameLambda, valueNameLambda, valueLambda, valueKindLambda));
        }

    }
}