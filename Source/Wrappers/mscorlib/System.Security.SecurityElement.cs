using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
    public static class __SecurityElement
    {
        
        public static IObservable<System.Reactive.Unit> AddAttribute(this IObservable<System.Security.SecurityElement> SecurityElementValue, IObservable<System.String> name, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SecurityElementValue, name, value, (SecurityElementValueLambda, nameLambda, valueLambda) => SecurityElementValueLambda.AddAttribute(nameLambda, valueLambda));
        }


        public static IObservable<System.String> Attribute(this IObservable<System.Security.SecurityElement> SecurityElementValue, IObservable<System.String> name)
        {
            return Observable.Zip(SecurityElementValue, name, (SecurityElementValueLambda, nameLambda) => SecurityElementValueLambda.Attribute(nameLambda));
        }


        public static IObservable<System.Security.SecurityElement> FromString(IObservable<System.String> xml)
        {
            return Observable.Select(xml, (xmlLambda) => System.Security.SecurityElement.FromString(xmlLambda));
        }


        public static IObservable<System.Reactive.Unit> AddChild(this IObservable<System.Security.SecurityElement> SecurityElementValue, IObservable<System.Security.SecurityElement> child)
        {
            return ObservableExt.ZipExecute(SecurityElementValue, child, (SecurityElementValueLambda, childLambda) => SecurityElementValueLambda.AddChild(childLambda));
        }


        public static IObservable<System.Boolean> Equal(this IObservable<System.Security.SecurityElement> SecurityElementValue, IObservable<System.Security.SecurityElement> other)
        {
            return Observable.Zip(SecurityElementValue, other, (SecurityElementValueLambda, otherLambda) => SecurityElementValueLambda.Equal(otherLambda));
        }


        public static IObservable<System.Security.SecurityElement> Copy(this IObservable<System.Security.SecurityElement> SecurityElementValue)
        {
            return Observable.Select(SecurityElementValue, (SecurityElementValueLambda) => SecurityElementValueLambda.Copy());
        }


        public static IObservable<System.Boolean> IsValidTag(IObservable<System.String> tag)
        {
            return Observable.Select(tag, (tagLambda) => System.Security.SecurityElement.IsValidTag(tagLambda));
        }


        public static IObservable<System.Boolean> IsValidText(IObservable<System.String> text)
        {
            return Observable.Select(text, (textLambda) => System.Security.SecurityElement.IsValidText(textLambda));
        }


        public static IObservable<System.Boolean> IsValidAttributeName(IObservable<System.String> name)
        {
            return Observable.Select(name, (nameLambda) => System.Security.SecurityElement.IsValidAttributeName(nameLambda));
        }


        public static IObservable<System.Boolean> IsValidAttributeValue(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Security.SecurityElement.IsValidAttributeValue(valueLambda));
        }


        public static IObservable<System.String> Escape(IObservable<System.String> str)
        {
            return Observable.Select(str, (strLambda) => System.Security.SecurityElement.Escape(strLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Security.SecurityElement> SecurityElementValue)
        {
            return Observable.Select(SecurityElementValue, (SecurityElementValueLambda) => SecurityElementValueLambda.ToString());
        }


        public static IObservable<System.Security.SecurityElement> SearchForChildByTag(this IObservable<System.Security.SecurityElement> SecurityElementValue, IObservable<System.String> tag)
        {
            return Observable.Zip(SecurityElementValue, tag, (SecurityElementValueLambda, tagLambda) => SecurityElementValueLambda.SearchForChildByTag(tagLambda));
        }


        public static IObservable<System.String> SearchForTextOfTag(this IObservable<System.Security.SecurityElement> SecurityElementValue, IObservable<System.String> tag)
        {
            return Observable.Zip(SecurityElementValue, tag, (SecurityElementValueLambda, tagLambda) => SecurityElementValueLambda.SearchForTextOfTag(tagLambda));
        }


        public static IObservable<System.String> get_Tag(this IObservable<System.Security.SecurityElement> SecurityElementValue)
        {
            return Observable.Select(SecurityElementValue, (SecurityElementValueLambda) => SecurityElementValueLambda.Tag);
        }


        public static IObservable<System.Collections.Hashtable> get_Attributes(this IObservable<System.Security.SecurityElement> SecurityElementValue)
        {
            return Observable.Select(SecurityElementValue, (SecurityElementValueLambda) => SecurityElementValueLambda.Attributes);
        }


        public static IObservable<System.String> get_Text(this IObservable<System.Security.SecurityElement> SecurityElementValue)
        {
            return Observable.Select(SecurityElementValue, (SecurityElementValueLambda) => SecurityElementValueLambda.Text);
        }


        public static IObservable<System.Collections.ArrayList> get_Children(this IObservable<System.Security.SecurityElement> SecurityElementValue)
        {
            return Observable.Select(SecurityElementValue, (SecurityElementValueLambda) => SecurityElementValueLambda.Children);
        }


        public static IObservable<System.Reactive.Unit> set_Tag(this IObservable<System.Security.SecurityElement> SecurityElementValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SecurityElementValue, value, (SecurityElementValueLambda, valueLambda) => SecurityElementValueLambda.Tag = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Attributes(this IObservable<System.Security.SecurityElement> SecurityElementValue, IObservable<System.Collections.Hashtable> value)
        {
            return ObservableExt.ZipExecute(SecurityElementValue, value, (SecurityElementValueLambda, valueLambda) => SecurityElementValueLambda.Attributes = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Text(this IObservable<System.Security.SecurityElement> SecurityElementValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SecurityElementValue, value, (SecurityElementValueLambda, valueLambda) => SecurityElementValueLambda.Text = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Children(this IObservable<System.Security.SecurityElement> SecurityElementValue, IObservable<System.Collections.ArrayList> value)
        {
            return ObservableExt.ZipExecute(SecurityElementValue, value, (SecurityElementValueLambda, valueLambda) => SecurityElementValueLambda.Children = valueLambda);
        }

    }
}