using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
    public static class __NamedPermissionSet
    {
        
        public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.NamedPermissionSet> NamedPermissionSetValue)
        {
            return Observable.Select(NamedPermissionSetValue, (NamedPermissionSetValueLambda) => NamedPermissionSetValueLambda.ToXml());
        }


        public static IObservable<System.Security.PermissionSet> Copy(this IObservable<System.Security.NamedPermissionSet> NamedPermissionSetValue)
        {
            return Observable.Select(NamedPermissionSetValue, (NamedPermissionSetValueLambda) => NamedPermissionSetValueLambda.Copy());
        }


        public static IObservable<System.Security.NamedPermissionSet> Copy(this IObservable<System.Security.NamedPermissionSet> NamedPermissionSetValue, IObservable<System.String> name)
        {
            return Observable.Zip(NamedPermissionSetValue, name, (NamedPermissionSetValueLambda, nameLambda) => NamedPermissionSetValueLambda.Copy(nameLambda));
        }


        public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.NamedPermissionSet> NamedPermissionSetValue, IObservable<System.Security.SecurityElement> et)
        {
            return ObservableExt.ZipExecute(NamedPermissionSetValue, et, (NamedPermissionSetValueLambda, etLambda) => NamedPermissionSetValueLambda.FromXml(etLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.NamedPermissionSet> NamedPermissionSetValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(NamedPermissionSetValue, obj, (NamedPermissionSetValueLambda, objLambda) => NamedPermissionSetValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.NamedPermissionSet> NamedPermissionSetValue)
        {
            return Observable.Select(NamedPermissionSetValue, (NamedPermissionSetValueLambda) => NamedPermissionSetValueLambda.GetHashCode());
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Security.NamedPermissionSet> NamedPermissionSetValue)
        {
            return Observable.Select(NamedPermissionSetValue, (NamedPermissionSetValueLambda) => NamedPermissionSetValueLambda.Name);
        }


        public static IObservable<System.String> get_Description(this IObservable<System.Security.NamedPermissionSet> NamedPermissionSetValue)
        {
            return Observable.Select(NamedPermissionSetValue, (NamedPermissionSetValueLambda) => NamedPermissionSetValueLambda.Description);
        }


        public static IObservable<System.Reactive.Unit> set_Name(this IObservable<System.Security.NamedPermissionSet> NamedPermissionSetValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NamedPermissionSetValue, value, (NamedPermissionSetValueLambda, valueLambda) => NamedPermissionSetValueLambda.Name = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Description(this IObservable<System.Security.NamedPermissionSet> NamedPermissionSetValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NamedPermissionSetValue, value, (NamedPermissionSetValueLambda, valueLambda) => NamedPermissionSetValueLambda.Description = valueLambda);
        }

    }
}