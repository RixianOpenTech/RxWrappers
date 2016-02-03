using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
public static class _FileIOPermission
{
    
public static IObservable<System.Reactive.Unit> SetPathList(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue, IObservable<System.Security.Permissions.FileIOPermissionAccess> access, IObservable<System.String> path)
{
    return ObservableExt.ZipExecute(FileIOPermissionValue, access, path, (FileIOPermissionValueLambda, accessLambda, pathLambda) => FileIOPermissionValueLambda.SetPathList(accessLambda, pathLambda));
}


public static IObservable<System.Reactive.Unit> SetPathList(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue, IObservable<System.Security.Permissions.FileIOPermissionAccess> access, IObservable<System.String[]> pathList)
{
    return ObservableExt.ZipExecute(FileIOPermissionValue, access, pathList, (FileIOPermissionValueLambda, accessLambda, pathListLambda) => FileIOPermissionValueLambda.SetPathList(accessLambda, pathListLambda));
}


public static IObservable<System.Reactive.Unit> AddPathList(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue, IObservable<System.Security.Permissions.FileIOPermissionAccess> access, IObservable<System.String> path)
{
    return ObservableExt.ZipExecute(FileIOPermissionValue, access, path, (FileIOPermissionValueLambda, accessLambda, pathLambda) => FileIOPermissionValueLambda.AddPathList(accessLambda, pathLambda));
}


public static IObservable<System.Reactive.Unit> AddPathList(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue, IObservable<System.Security.Permissions.FileIOPermissionAccess> access, IObservable<System.String[]> pathList)
{
    return ObservableExt.ZipExecute(FileIOPermissionValue, access, pathList, (FileIOPermissionValueLambda, accessLambda, pathListLambda) => FileIOPermissionValueLambda.AddPathList(accessLambda, pathListLambda));
}


public static IObservable<System.String[]> GetPathList(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue, IObservable<System.Security.Permissions.FileIOPermissionAccess> access)
{
    return Observable.Zip(FileIOPermissionValue, access, (FileIOPermissionValueLambda, accessLambda) => FileIOPermissionValueLambda.GetPathList(accessLambda));
}


public static IObservable<System.Boolean> IsUnrestricted(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue)
{
    return Observable.Select(FileIOPermissionValue, (FileIOPermissionValueLambda) => FileIOPermissionValueLambda.IsUnrestricted());
}


public static IObservable<System.Boolean> IsSubsetOf(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue, IObservable<System.Security.IPermission> target)
{
    return Observable.Zip(FileIOPermissionValue, target, (FileIOPermissionValueLambda, targetLambda) => FileIOPermissionValueLambda.IsSubsetOf(targetLambda));
}


public static IObservable<System.Security.IPermission> Intersect(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue, IObservable<System.Security.IPermission> target)
{
    return Observable.Zip(FileIOPermissionValue, target, (FileIOPermissionValueLambda, targetLambda) => FileIOPermissionValueLambda.Intersect(targetLambda));
}


public static IObservable<System.Security.IPermission> Union(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue, IObservable<System.Security.IPermission> other)
{
    return Observable.Zip(FileIOPermissionValue, other, (FileIOPermissionValueLambda, otherLambda) => FileIOPermissionValueLambda.Union(otherLambda));
}


public static IObservable<System.Security.IPermission> Copy(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue)
{
    return Observable.Select(FileIOPermissionValue, (FileIOPermissionValueLambda) => FileIOPermissionValueLambda.Copy());
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue)
{
    return Observable.Select(FileIOPermissionValue, (FileIOPermissionValueLambda) => FileIOPermissionValueLambda.ToXml());
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue, IObservable<System.Security.SecurityElement> esd)
{
    return ObservableExt.ZipExecute(FileIOPermissionValue, esd, (FileIOPermissionValueLambda, esdLambda) => FileIOPermissionValueLambda.FromXml(esdLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue, IObservable<System.Object> obj)
{
    return Observable.Zip(FileIOPermissionValue, obj, (FileIOPermissionValueLambda, objLambda) => FileIOPermissionValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue)
{
    return Observable.Select(FileIOPermissionValue, (FileIOPermissionValueLambda) => FileIOPermissionValueLambda.GetHashCode());
}


public static IObservable<System.Security.Permissions.FileIOPermissionAccess> get_AllLocalFiles(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue)
{
    return Observable.Select(FileIOPermissionValue, (FileIOPermissionValueLambda) => FileIOPermissionValueLambda.AllLocalFiles);
}


public static IObservable<System.Security.Permissions.FileIOPermissionAccess> get_AllFiles(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue)
{
    return Observable.Select(FileIOPermissionValue, (FileIOPermissionValueLambda) => FileIOPermissionValueLambda.AllFiles);
}


public static IObservable<System.Reactive.Unit> set_AllLocalFiles(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue, IObservable<System.Security.Permissions.FileIOPermissionAccess> value)
{
    return ObservableExt.ZipExecute(FileIOPermissionValue, value, (FileIOPermissionValueLambda, valueLambda) => FileIOPermissionValueLambda.AllLocalFiles = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_AllFiles(this IObservable<System.Security.Permissions.FileIOPermission> FileIOPermissionValue, IObservable<System.Security.Permissions.FileIOPermissionAccess> value)
{
    return ObservableExt.ZipExecute(FileIOPermissionValue, value, (FileIOPermissionValueLambda, valueLambda) => FileIOPermissionValueLambda.AllFiles = valueLambda);
}

}
}