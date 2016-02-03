using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Microsoft.Win32
{
public static class _RegistryKey
{
    
public static IObservable<System.Reactive.Unit> Close(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue)
{
    return Observable.Do(RegistryKeyValue, (RegistryKeyValueLambda) => RegistryKeyValueLambda.Close()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Flush(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue)
{
    return Observable.Do(RegistryKeyValue, (RegistryKeyValueLambda) => RegistryKeyValueLambda.Flush()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue)
{
    return Observable.Do(RegistryKeyValue, (RegistryKeyValueLambda) => RegistryKeyValueLambda.Dispose()).ToUnit();
}


public static IObservable<Microsoft.Win32.RegistryKey> CreateSubKey(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> subkey)
{
    return Observable.Zip(RegistryKeyValue, subkey, (RegistryKeyValueLambda, subkeyLambda) => RegistryKeyValueLambda.CreateSubKey(subkeyLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> CreateSubKey(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> subkey, IObservable<Microsoft.Win32.RegistryKeyPermissionCheck> permissionCheck)
{
    return Observable.Zip(RegistryKeyValue, subkey, permissionCheck, (RegistryKeyValueLambda, subkeyLambda, permissionCheckLambda) => RegistryKeyValueLambda.CreateSubKey(subkeyLambda, permissionCheckLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> CreateSubKey(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> subkey, IObservable<Microsoft.Win32.RegistryKeyPermissionCheck> permissionCheck, IObservable<Microsoft.Win32.RegistryOptions> options)
{
    return Observable.Zip(RegistryKeyValue, subkey, permissionCheck, options, (RegistryKeyValueLambda, subkeyLambda, permissionCheckLambda, optionsLambda) => RegistryKeyValueLambda.CreateSubKey(subkeyLambda, permissionCheckLambda, optionsLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> CreateSubKey(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> subkey, IObservable<System.Boolean> writable)
{
    return Observable.Zip(RegistryKeyValue, subkey, writable, (RegistryKeyValueLambda, subkeyLambda, writableLambda) => RegistryKeyValueLambda.CreateSubKey(subkeyLambda, writableLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> CreateSubKey(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> subkey, IObservable<System.Boolean> writable, IObservable<Microsoft.Win32.RegistryOptions> options)
{
    return Observable.Zip(RegistryKeyValue, subkey, writable, options, (RegistryKeyValueLambda, subkeyLambda, writableLambda, optionsLambda) => RegistryKeyValueLambda.CreateSubKey(subkeyLambda, writableLambda, optionsLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> CreateSubKey(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> subkey, IObservable<Microsoft.Win32.RegistryKeyPermissionCheck> permissionCheck, IObservable<System.Security.AccessControl.RegistrySecurity> registrySecurity)
{
    return Observable.Zip(RegistryKeyValue, subkey, permissionCheck, registrySecurity, (RegistryKeyValueLambda, subkeyLambda, permissionCheckLambda, registrySecurityLambda) => RegistryKeyValueLambda.CreateSubKey(subkeyLambda, permissionCheckLambda, registrySecurityLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> CreateSubKey(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> subkey, IObservable<Microsoft.Win32.RegistryKeyPermissionCheck> permissionCheck, IObservable<Microsoft.Win32.RegistryOptions> registryOptions, IObservable<System.Security.AccessControl.RegistrySecurity> registrySecurity)
{
    return Observable.Zip(RegistryKeyValue, subkey, permissionCheck, registryOptions, registrySecurity, (RegistryKeyValueLambda, subkeyLambda, permissionCheckLambda, registryOptionsLambda, registrySecurityLambda) => RegistryKeyValueLambda.CreateSubKey(subkeyLambda, permissionCheckLambda, registryOptionsLambda, registrySecurityLambda));
}


public static IObservable<System.Reactive.Unit> DeleteSubKey(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> subkey)
{
    return ObservableExt.ZipExecute(RegistryKeyValue, subkey, (RegistryKeyValueLambda, subkeyLambda) => RegistryKeyValueLambda.DeleteSubKey(subkeyLambda));
}


public static IObservable<System.Reactive.Unit> DeleteSubKey(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> subkey, IObservable<System.Boolean> throwOnMissingSubKey)
{
    return ObservableExt.ZipExecute(RegistryKeyValue, subkey, throwOnMissingSubKey, (RegistryKeyValueLambda, subkeyLambda, throwOnMissingSubKeyLambda) => RegistryKeyValueLambda.DeleteSubKey(subkeyLambda, throwOnMissingSubKeyLambda));
}


public static IObservable<System.Reactive.Unit> DeleteSubKeyTree(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> subkey)
{
    return ObservableExt.ZipExecute(RegistryKeyValue, subkey, (RegistryKeyValueLambda, subkeyLambda) => RegistryKeyValueLambda.DeleteSubKeyTree(subkeyLambda));
}


public static IObservable<System.Reactive.Unit> DeleteSubKeyTree(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> subkey, IObservable<System.Boolean> throwOnMissingSubKey)
{
    return ObservableExt.ZipExecute(RegistryKeyValue, subkey, throwOnMissingSubKey, (RegistryKeyValueLambda, subkeyLambda, throwOnMissingSubKeyLambda) => RegistryKeyValueLambda.DeleteSubKeyTree(subkeyLambda, throwOnMissingSubKeyLambda));
}


public static IObservable<System.Reactive.Unit> DeleteValue(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> name)
{
    return ObservableExt.ZipExecute(RegistryKeyValue, name, (RegistryKeyValueLambda, nameLambda) => RegistryKeyValueLambda.DeleteValue(nameLambda));
}


public static IObservable<System.Reactive.Unit> DeleteValue(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> name, IObservable<System.Boolean> throwOnMissingValue)
{
    return ObservableExt.ZipExecute(RegistryKeyValue, name, throwOnMissingValue, (RegistryKeyValueLambda, nameLambda, throwOnMissingValueLambda) => RegistryKeyValueLambda.DeleteValue(nameLambda, throwOnMissingValueLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> OpenBaseKey(IObservable<Microsoft.Win32.RegistryHive> hKey, IObservable<Microsoft.Win32.RegistryView> view)
{
    return Observable.Zip(hKey, view, (hKeyLambda, viewLambda) => Microsoft.Win32.RegistryKey.OpenBaseKey(hKeyLambda, viewLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> OpenRemoteBaseKey(IObservable<Microsoft.Win32.RegistryHive> hKey, IObservable<System.String> machineName)
{
    return Observable.Zip(hKey, machineName, (hKeyLambda, machineNameLambda) => Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(hKeyLambda, machineNameLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> OpenRemoteBaseKey(IObservable<Microsoft.Win32.RegistryHive> hKey, IObservable<System.String> machineName, IObservable<Microsoft.Win32.RegistryView> view)
{
    return Observable.Zip(hKey, machineName, view, (hKeyLambda, machineNameLambda, viewLambda) => Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(hKeyLambda, machineNameLambda, viewLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> OpenSubKey(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> name, IObservable<System.Boolean> writable)
{
    return Observable.Zip(RegistryKeyValue, name, writable, (RegistryKeyValueLambda, nameLambda, writableLambda) => RegistryKeyValueLambda.OpenSubKey(nameLambda, writableLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> OpenSubKey(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> name, IObservable<Microsoft.Win32.RegistryKeyPermissionCheck> permissionCheck)
{
    return Observable.Zip(RegistryKeyValue, name, permissionCheck, (RegistryKeyValueLambda, nameLambda, permissionCheckLambda) => RegistryKeyValueLambda.OpenSubKey(nameLambda, permissionCheckLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> OpenSubKey(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> name, IObservable<System.Security.AccessControl.RegistryRights> rights)
{
    return Observable.Zip(RegistryKeyValue, name, rights, (RegistryKeyValueLambda, nameLambda, rightsLambda) => RegistryKeyValueLambda.OpenSubKey(nameLambda, rightsLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> OpenSubKey(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> name, IObservable<Microsoft.Win32.RegistryKeyPermissionCheck> permissionCheck, IObservable<System.Security.AccessControl.RegistryRights> rights)
{
    return Observable.Zip(RegistryKeyValue, name, permissionCheck, rights, (RegistryKeyValueLambda, nameLambda, permissionCheckLambda, rightsLambda) => RegistryKeyValueLambda.OpenSubKey(nameLambda, permissionCheckLambda, rightsLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> OpenSubKey(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> name)
{
    return Observable.Zip(RegistryKeyValue, name, (RegistryKeyValueLambda, nameLambda) => RegistryKeyValueLambda.OpenSubKey(nameLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> FromHandle(IObservable<Microsoft.Win32.SafeHandles.SafeRegistryHandle> handle)
{
    return Observable.Select(handle, (handleLambda) => Microsoft.Win32.RegistryKey.FromHandle(handleLambda));
}


public static IObservable<Microsoft.Win32.RegistryKey> FromHandle(IObservable<Microsoft.Win32.SafeHandles.SafeRegistryHandle> handle, IObservable<Microsoft.Win32.RegistryView> view)
{
    return Observable.Zip(handle, view, (handleLambda, viewLambda) => Microsoft.Win32.RegistryKey.FromHandle(handleLambda, viewLambda));
}


public static IObservable<System.String[]> GetSubKeyNames(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue)
{
    return Observable.Select(RegistryKeyValue, (RegistryKeyValueLambda) => RegistryKeyValueLambda.GetSubKeyNames());
}


public static IObservable<System.String[]> GetValueNames(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue)
{
    return Observable.Select(RegistryKeyValue, (RegistryKeyValueLambda) => RegistryKeyValueLambda.GetValueNames());
}


public static IObservable<System.Object> GetValue(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> name)
{
    return Observable.Zip(RegistryKeyValue, name, (RegistryKeyValueLambda, nameLambda) => RegistryKeyValueLambda.GetValue(nameLambda));
}


public static IObservable<System.Object> GetValue(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> name, IObservable<System.Object> defaultValue)
{
    return Observable.Zip(RegistryKeyValue, name, defaultValue, (RegistryKeyValueLambda, nameLambda, defaultValueLambda) => RegistryKeyValueLambda.GetValue(nameLambda, defaultValueLambda));
}


public static IObservable<System.Object> GetValue(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> name, IObservable<System.Object> defaultValue, IObservable<Microsoft.Win32.RegistryValueOptions> options)
{
    return Observable.Zip(RegistryKeyValue, name, defaultValue, options, (RegistryKeyValueLambda, nameLambda, defaultValueLambda, optionsLambda) => RegistryKeyValueLambda.GetValue(nameLambda, defaultValueLambda, optionsLambda));
}


public static IObservable<Microsoft.Win32.RegistryValueKind> GetValueKind(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> name)
{
    return Observable.Zip(RegistryKeyValue, name, (RegistryKeyValueLambda, nameLambda) => RegistryKeyValueLambda.GetValueKind(nameLambda));
}


public static IObservable<System.Reactive.Unit> SetValue(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> name, IObservable<System.Object> value)
{
    return ObservableExt.ZipExecute(RegistryKeyValue, name, value, (RegistryKeyValueLambda, nameLambda, valueLambda) => RegistryKeyValueLambda.SetValue(nameLambda, valueLambda));
}


public static IObservable<System.Reactive.Unit> SetValue(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.String> name, IObservable<System.Object> value, IObservable<Microsoft.Win32.RegistryValueKind> valueKind)
{
    return ObservableExt.ZipExecute(RegistryKeyValue, name, value, valueKind, (RegistryKeyValueLambda, nameLambda, valueLambda, valueKindLambda) => RegistryKeyValueLambda.SetValue(nameLambda, valueLambda, valueKindLambda));
}


public static IObservable<System.String> ToString(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue)
{
    return Observable.Select(RegistryKeyValue, (RegistryKeyValueLambda) => RegistryKeyValueLambda.ToString());
}


public static IObservable<System.Security.AccessControl.RegistrySecurity> GetAccessControl(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue)
{
    return Observable.Select(RegistryKeyValue, (RegistryKeyValueLambda) => RegistryKeyValueLambda.GetAccessControl());
}


public static IObservable<System.Security.AccessControl.RegistrySecurity> GetAccessControl(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.Security.AccessControl.AccessControlSections> includeSections)
{
    return Observable.Zip(RegistryKeyValue, includeSections, (RegistryKeyValueLambda, includeSectionsLambda) => RegistryKeyValueLambda.GetAccessControl(includeSectionsLambda));
}


public static IObservable<System.Reactive.Unit> SetAccessControl(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue, IObservable<System.Security.AccessControl.RegistrySecurity> registrySecurity)
{
    return ObservableExt.ZipExecute(RegistryKeyValue, registrySecurity, (RegistryKeyValueLambda, registrySecurityLambda) => RegistryKeyValueLambda.SetAccessControl(registrySecurityLambda));
}


public static IObservable<System.Int32> get_SubKeyCount(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue)
{
    return Observable.Select(RegistryKeyValue, (RegistryKeyValueLambda) => RegistryKeyValueLambda.SubKeyCount);
}


public static IObservable<Microsoft.Win32.RegistryView> get_View(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue)
{
    return Observable.Select(RegistryKeyValue, (RegistryKeyValueLambda) => RegistryKeyValueLambda.View);
}


public static IObservable<Microsoft.Win32.SafeHandles.SafeRegistryHandle> get_Handle(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue)
{
    return Observable.Select(RegistryKeyValue, (RegistryKeyValueLambda) => RegistryKeyValueLambda.Handle);
}


public static IObservable<System.Int32> get_ValueCount(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue)
{
    return Observable.Select(RegistryKeyValue, (RegistryKeyValueLambda) => RegistryKeyValueLambda.ValueCount);
}


public static IObservable<System.String> get_Name(this IObservable<Microsoft.Win32.RegistryKey> RegistryKeyValue)
{
    return Observable.Select(RegistryKeyValue, (RegistryKeyValueLambda) => RegistryKeyValueLambda.Name);
}

}
}