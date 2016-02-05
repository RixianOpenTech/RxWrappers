using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Schema
{
    public static class __ValidationEventArgs
    {
        
        public static IObservable<Newtonsoft.Json.Schema.JsonSchemaException> get_Exception(this IObservable<Newtonsoft.Json.Schema.ValidationEventArgs> ValidationEventArgsValue)
        {
            return Observable.Select(ValidationEventArgsValue, (ValidationEventArgsValueLambda) => ValidationEventArgsValueLambda.Exception);
        }


        public static IObservable<System.String> get_Path(this IObservable<Newtonsoft.Json.Schema.ValidationEventArgs> ValidationEventArgsValue)
        {
            return Observable.Select(ValidationEventArgsValue, (ValidationEventArgsValueLambda) => ValidationEventArgsValueLambda.Path);
        }


        public static IObservable<System.String> get_Message(this IObservable<Newtonsoft.Json.Schema.ValidationEventArgs> ValidationEventArgsValue)
        {
            return Observable.Select(ValidationEventArgsValue, (ValidationEventArgsValueLambda) => ValidationEventArgsValueLambda.Message);
        }

    }
}