using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading.Tasks
{
public static class _TaskCanceledException
{
    
public static IObservable<System.Reactive.Unit> get_Task(this IObservable<System.Threading.Tasks.TaskCanceledException> TaskCanceledExceptionValue)
{
    return Observable.Select(TaskCanceledExceptionValue, (TaskCanceledExceptionValueLambda) => TaskCanceledExceptionValueLambda.Task.ToObservable()).Flatten().ToUnit();
}

}
}