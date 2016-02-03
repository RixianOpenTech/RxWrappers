using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
public static class _DriveInfo
{
    
public static IObservable<System.IO.DriveInfo[]> GetDrives()
{
    return ObservableExt.Factory(() => System.IO.DriveInfo.GetDrives());
}


public static IObservable<System.String> ToString(this IObservable<System.IO.DriveInfo> DriveInfoValue)
{
    return Observable.Select(DriveInfoValue, (DriveInfoValueLambda) => DriveInfoValueLambda.ToString());
}


public static IObservable<System.String> get_Name(this IObservable<System.IO.DriveInfo> DriveInfoValue)
{
    return Observable.Select(DriveInfoValue, (DriveInfoValueLambda) => DriveInfoValueLambda.Name);
}


public static IObservable<System.IO.DriveType> get_DriveType(this IObservable<System.IO.DriveInfo> DriveInfoValue)
{
    return Observable.Select(DriveInfoValue, (DriveInfoValueLambda) => DriveInfoValueLambda.DriveType);
}


public static IObservable<System.String> get_DriveFormat(this IObservable<System.IO.DriveInfo> DriveInfoValue)
{
    return Observable.Select(DriveInfoValue, (DriveInfoValueLambda) => DriveInfoValueLambda.DriveFormat);
}


public static IObservable<System.Boolean> get_IsReady(this IObservable<System.IO.DriveInfo> DriveInfoValue)
{
    return Observable.Select(DriveInfoValue, (DriveInfoValueLambda) => DriveInfoValueLambda.IsReady);
}


public static IObservable<System.Int64> get_AvailableFreeSpace(this IObservable<System.IO.DriveInfo> DriveInfoValue)
{
    return Observable.Select(DriveInfoValue, (DriveInfoValueLambda) => DriveInfoValueLambda.AvailableFreeSpace);
}


public static IObservable<System.Int64> get_TotalFreeSpace(this IObservable<System.IO.DriveInfo> DriveInfoValue)
{
    return Observable.Select(DriveInfoValue, (DriveInfoValueLambda) => DriveInfoValueLambda.TotalFreeSpace);
}


public static IObservable<System.Int64> get_TotalSize(this IObservable<System.IO.DriveInfo> DriveInfoValue)
{
    return Observable.Select(DriveInfoValue, (DriveInfoValueLambda) => DriveInfoValueLambda.TotalSize);
}


public static IObservable<System.IO.DirectoryInfo> get_RootDirectory(this IObservable<System.IO.DriveInfo> DriveInfoValue)
{
    return Observable.Select(DriveInfoValue, (DriveInfoValueLambda) => DriveInfoValueLambda.RootDirectory);
}


public static IObservable<System.String> get_VolumeLabel(this IObservable<System.IO.DriveInfo> DriveInfoValue)
{
    return Observable.Select(DriveInfoValue, (DriveInfoValueLambda) => DriveInfoValueLambda.VolumeLabel);
}


public static IObservable<System.Reactive.Unit> set_VolumeLabel(this IObservable<System.IO.DriveInfo> DriveInfoValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(DriveInfoValue, value, (DriveInfoValueLambda, valueLambda) => DriveInfoValueLambda.VolumeLabel = valueLambda);
}

}
}