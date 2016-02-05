using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonConvert
    {
        
        public static IObservable<System.String> ToString(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.DateTime> value, IObservable<Newtonsoft.Json.DateFormatHandling> format, IObservable<Newtonsoft.Json.DateTimeZoneHandling> timeZoneHandling)
        {
            return Observable.Zip(value, format, timeZoneHandling, (valueLambda, formatLambda, timeZoneHandlingLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda, formatLambda, timeZoneHandlingLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.DateTimeOffset> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.DateTimeOffset> value, IObservable<Newtonsoft.Json.DateFormatHandling> format)
        {
            return Observable.Zip(value, format, (valueLambda, formatLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda, formatLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Enum> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Guid> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.TimeSpan> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Uri> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.String> value, IObservable<System.Char> delimiter)
        {
            return Observable.Zip(value, delimiter, (valueLambda, delimiterLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda, delimiterLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.String> value, IObservable<System.Char> delimiter, IObservable<Newtonsoft.Json.StringEscapeHandling> stringEscapeHandling)
        {
            return Observable.Zip(value, delimiter, stringEscapeHandling, (valueLambda, delimiterLambda, stringEscapeHandlingLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda, delimiterLambda, stringEscapeHandlingLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.ToString(valueLambda));
        }


        public static IObservable<System.String> SerializeObject(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.SerializeObject(valueLambda));
        }


        public static IObservable<System.String> SerializeObject(IObservable<System.Object> value, IObservable<Newtonsoft.Json.Formatting> formatting)
        {
            return Observable.Zip(value, formatting, (valueLambda, formattingLambda) => Newtonsoft.Json.JsonConvert.SerializeObject(valueLambda, formattingLambda));
        }


        public static IObservable<System.String> SerializeObject(IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonConverter[]> converters)
        {
            return Observable.Zip(value, converters, (valueLambda, convertersLambda) => Newtonsoft.Json.JsonConvert.SerializeObject(valueLambda, convertersLambda));
        }


        public static IObservable<System.String> SerializeObject(IObservable<System.Object> value, IObservable<Newtonsoft.Json.Formatting> formatting, IObservable<Newtonsoft.Json.JsonConverter[]> converters)
        {
            return Observable.Zip(value, formatting, converters, (valueLambda, formattingLambda, convertersLambda) => Newtonsoft.Json.JsonConvert.SerializeObject(valueLambda, formattingLambda, convertersLambda));
        }


        public static IObservable<System.String> SerializeObject(IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return Observable.Zip(value, settings, (valueLambda, settingsLambda) => Newtonsoft.Json.JsonConvert.SerializeObject(valueLambda, settingsLambda));
        }


        public static IObservable<System.String> SerializeObject(IObservable<System.Object> value, IObservable<System.Type> type, IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return Observable.Zip(value, type, settings, (valueLambda, typeLambda, settingsLambda) => Newtonsoft.Json.JsonConvert.SerializeObject(valueLambda, typeLambda, settingsLambda));
        }


        public static IObservable<System.String> SerializeObject(IObservable<System.Object> value, IObservable<Newtonsoft.Json.Formatting> formatting, IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return Observable.Zip(value, formatting, settings, (valueLambda, formattingLambda, settingsLambda) => Newtonsoft.Json.JsonConvert.SerializeObject(valueLambda, formattingLambda, settingsLambda));
        }


        public static IObservable<System.String> SerializeObject(IObservable<System.Object> value, IObservable<System.Type> type, IObservable<Newtonsoft.Json.Formatting> formatting, IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return Observable.Zip(value, type, formatting, settings, (valueLambda, typeLambda, formattingLambda, settingsLambda) => Newtonsoft.Json.JsonConvert.SerializeObject(valueLambda, typeLambda, formattingLambda, settingsLambda));
        }


        public static IObservable<System.String> SerializeObjectAsync(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.SerializeObjectAsync(valueLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.String> SerializeObjectAsync(IObservable<System.Object> value, IObservable<Newtonsoft.Json.Formatting> formatting)
        {
            return Observable.Zip(value, formatting, (valueLambda, formattingLambda) => Newtonsoft.Json.JsonConvert.SerializeObjectAsync(valueLambda, formattingLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.String> SerializeObjectAsync(IObservable<System.Object> value, IObservable<Newtonsoft.Json.Formatting> formatting, IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return Observable.Zip(value, formatting, settings, (valueLambda, formattingLambda, settingsLambda) => Newtonsoft.Json.JsonConvert.SerializeObjectAsync(valueLambda, formattingLambda, settingsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Object> DeserializeObject(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.DeserializeObject(valueLambda));
        }


        public static IObservable<System.Object> DeserializeObject(IObservable<System.String> value, IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return Observable.Zip(value, settings, (valueLambda, settingsLambda) => Newtonsoft.Json.JsonConvert.DeserializeObject(valueLambda, settingsLambda));
        }


        public static IObservable<System.Object> DeserializeObject(IObservable<System.String> value, IObservable<System.Type> type)
        {
            return Observable.Zip(value, type, (valueLambda, typeLambda) => Newtonsoft.Json.JsonConvert.DeserializeObject(valueLambda, typeLambda));
        }


        public static IObservable<T> DeserializeObject<T>(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.DeserializeObject<T>(valueLambda));
        }


        public static IObservable<T> DeserializeAnonymousType<T>(IObservable<System.String> value, IObservable<T> anonymousTypeObject)
        {
            return Observable.Zip(value, anonymousTypeObject, (valueLambda, anonymousTypeObjectLambda) => Newtonsoft.Json.JsonConvert.DeserializeAnonymousType(valueLambda, anonymousTypeObjectLambda));
        }


        public static IObservable<T> DeserializeAnonymousType<T>(IObservable<System.String> value, IObservable<T> anonymousTypeObject, IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return Observable.Zip(value, anonymousTypeObject, settings, (valueLambda, anonymousTypeObjectLambda, settingsLambda) => Newtonsoft.Json.JsonConvert.DeserializeAnonymousType(valueLambda, anonymousTypeObjectLambda, settingsLambda));
        }


        public static IObservable<T> DeserializeObject<T>(IObservable<System.String> value, IObservable<Newtonsoft.Json.JsonConverter[]> converters)
        {
            return Observable.Zip(value, converters, (valueLambda, convertersLambda) => Newtonsoft.Json.JsonConvert.DeserializeObject<T>(valueLambda, convertersLambda));
        }


        public static IObservable<T> DeserializeObject<T>(IObservable<System.String> value, IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return Observable.Zip(value, settings, (valueLambda, settingsLambda) => Newtonsoft.Json.JsonConvert.DeserializeObject<T>(valueLambda, settingsLambda));
        }


        public static IObservable<System.Object> DeserializeObject(IObservable<System.String> value, IObservable<System.Type> type, IObservable<Newtonsoft.Json.JsonConverter[]> converters)
        {
            return Observable.Zip(value, type, converters, (valueLambda, typeLambda, convertersLambda) => Newtonsoft.Json.JsonConvert.DeserializeObject(valueLambda, typeLambda, convertersLambda));
        }


        public static IObservable<System.Object> DeserializeObject(IObservable<System.String> value, IObservable<System.Type> type, IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return Observable.Zip(value, type, settings, (valueLambda, typeLambda, settingsLambda) => Newtonsoft.Json.JsonConvert.DeserializeObject(valueLambda, typeLambda, settingsLambda));
        }


        public static IObservable<T> DeserializeObjectAsync<T>(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.DeserializeObjectAsync<T>(valueLambda).ToObservable()).Flatten();
        }


        public static IObservable<T> DeserializeObjectAsync<T>(IObservable<System.String> value, IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return Observable.Zip(value, settings, (valueLambda, settingsLambda) => Newtonsoft.Json.JsonConvert.DeserializeObjectAsync<T>(valueLambda, settingsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Object> DeserializeObjectAsync(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.DeserializeObjectAsync(valueLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Object> DeserializeObjectAsync(IObservable<System.String> value, IObservable<System.Type> type, IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return Observable.Zip(value, type, settings, (valueLambda, typeLambda, settingsLambda) => Newtonsoft.Json.JsonConvert.DeserializeObjectAsync(valueLambda, typeLambda, settingsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> PopulateObject(IObservable<System.String> value, IObservable<System.Object> target)
        {
            return ObservableExt.ZipExecute(value, target, (valueLambda, targetLambda) => Newtonsoft.Json.JsonConvert.PopulateObject(valueLambda, targetLambda));
        }


        public static IObservable<System.Reactive.Unit> PopulateObject(IObservable<System.String> value, IObservable<System.Object> target, IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return ObservableExt.ZipExecute(value, target, settings, (valueLambda, targetLambda, settingsLambda) => Newtonsoft.Json.JsonConvert.PopulateObject(valueLambda, targetLambda, settingsLambda));
        }


        public static IObservable<System.Reactive.Unit> PopulateObjectAsync(IObservable<System.String> value, IObservable<System.Object> target, IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return Observable.Zip(value, target, settings, (valueLambda, targetLambda, settingsLambda) => Newtonsoft.Json.JsonConvert.PopulateObjectAsync(valueLambda, targetLambda, settingsLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.String> SerializeXmlNode(IObservable<System.Xml.XmlNode> node)
        {
            return Observable.Select(node, (nodeLambda) => Newtonsoft.Json.JsonConvert.SerializeXmlNode(nodeLambda));
        }


        public static IObservable<System.String> SerializeXmlNode(IObservable<System.Xml.XmlNode> node, IObservable<Newtonsoft.Json.Formatting> formatting)
        {
            return Observable.Zip(node, formatting, (nodeLambda, formattingLambda) => Newtonsoft.Json.JsonConvert.SerializeXmlNode(nodeLambda, formattingLambda));
        }


        public static IObservable<System.String> SerializeXmlNode(IObservable<System.Xml.XmlNode> node, IObservable<Newtonsoft.Json.Formatting> formatting, IObservable<System.Boolean> omitRootObject)
        {
            return Observable.Zip(node, formatting, omitRootObject, (nodeLambda, formattingLambda, omitRootObjectLambda) => Newtonsoft.Json.JsonConvert.SerializeXmlNode(nodeLambda, formattingLambda, omitRootObjectLambda));
        }


        public static IObservable<System.Xml.XmlDocument> DeserializeXmlNode(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.DeserializeXmlNode(valueLambda));
        }


        public static IObservable<System.Xml.XmlDocument> DeserializeXmlNode(IObservable<System.String> value, IObservable<System.String> deserializeRootElementName)
        {
            return Observable.Zip(value, deserializeRootElementName, (valueLambda, deserializeRootElementNameLambda) => Newtonsoft.Json.JsonConvert.DeserializeXmlNode(valueLambda, deserializeRootElementNameLambda));
        }


        public static IObservable<System.Xml.XmlDocument> DeserializeXmlNode(IObservable<System.String> value, IObservable<System.String> deserializeRootElementName, IObservable<System.Boolean> writeArrayAttribute)
        {
            return Observable.Zip(value, deserializeRootElementName, writeArrayAttribute, (valueLambda, deserializeRootElementNameLambda, writeArrayAttributeLambda) => Newtonsoft.Json.JsonConvert.DeserializeXmlNode(valueLambda, deserializeRootElementNameLambda, writeArrayAttributeLambda));
        }


        public static IObservable<System.String> SerializeXNode(IObservable<System.Xml.Linq.XObject> node)
        {
            return Observable.Select(node, (nodeLambda) => Newtonsoft.Json.JsonConvert.SerializeXNode(nodeLambda));
        }


        public static IObservable<System.String> SerializeXNode(IObservable<System.Xml.Linq.XObject> node, IObservable<Newtonsoft.Json.Formatting> formatting)
        {
            return Observable.Zip(node, formatting, (nodeLambda, formattingLambda) => Newtonsoft.Json.JsonConvert.SerializeXNode(nodeLambda, formattingLambda));
        }


        public static IObservable<System.String> SerializeXNode(IObservable<System.Xml.Linq.XObject> node, IObservable<Newtonsoft.Json.Formatting> formatting, IObservable<System.Boolean> omitRootObject)
        {
            return Observable.Zip(node, formatting, omitRootObject, (nodeLambda, formattingLambda, omitRootObjectLambda) => Newtonsoft.Json.JsonConvert.SerializeXNode(nodeLambda, formattingLambda, omitRootObjectLambda));
        }


        public static IObservable<System.Xml.Linq.XDocument> DeserializeXNode(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.JsonConvert.DeserializeXNode(valueLambda));
        }


        public static IObservable<System.Xml.Linq.XDocument> DeserializeXNode(IObservable<System.String> value, IObservable<System.String> deserializeRootElementName)
        {
            return Observable.Zip(value, deserializeRootElementName, (valueLambda, deserializeRootElementNameLambda) => Newtonsoft.Json.JsonConvert.DeserializeXNode(valueLambda, deserializeRootElementNameLambda));
        }


        public static IObservable<System.Xml.Linq.XDocument> DeserializeXNode(IObservable<System.String> value, IObservable<System.String> deserializeRootElementName, IObservable<System.Boolean> writeArrayAttribute)
        {
            return Observable.Zip(value, deserializeRootElementName, writeArrayAttribute, (valueLambda, deserializeRootElementNameLambda, writeArrayAttributeLambda) => Newtonsoft.Json.JsonConvert.DeserializeXNode(valueLambda, deserializeRootElementNameLambda, writeArrayAttributeLambda));
        }


        public static IObservable<System.Func<Newtonsoft.Json.JsonSerializerSettings>> get_DefaultSettings()
        {
            return ObservableExt.Factory(() => Newtonsoft.Json.JsonConvert.DefaultSettings);
        }


        public static IObservable<System.Reactive.Unit> set_DefaultSettings(IObservable<System.Func<Newtonsoft.Json.JsonSerializerSettings>> value)
        {
            return Observable.Do(value, (valueLambda) => Newtonsoft.Json.JsonConvert.DefaultSettings = valueLambda).ToUnit();
        }

    }
}