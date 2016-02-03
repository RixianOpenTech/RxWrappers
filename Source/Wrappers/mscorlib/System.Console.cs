using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Console
    {
        
        public static IObservable<System.Reactive.Unit> Beep()
        {
            return ObservableExt.Factory(() => System.Console.Beep());
        }


        public static IObservable<System.Reactive.Unit> Beep(IObservable<System.Int32> frequency, IObservable<System.Int32> duration)
        {
            return ObservableExt.ZipExecute(frequency, duration, (frequencyLambda, durationLambda) => System.Console.Beep(frequencyLambda, durationLambda));
        }


        public static IObservable<System.Reactive.Unit> Clear()
        {
            return ObservableExt.Factory(() => System.Console.Clear());
        }


        public static IObservable<System.Reactive.Unit> ResetColor()
        {
            return ObservableExt.Factory(() => System.Console.ResetColor());
        }


        public static IObservable<System.Reactive.Unit> MoveBufferArea(IObservable<System.Int32> sourceLeft, IObservable<System.Int32> sourceTop, IObservable<System.Int32> sourceWidth, IObservable<System.Int32> sourceHeight, IObservable<System.Int32> targetLeft, IObservable<System.Int32> targetTop)
        {
            return ObservableExt.ZipExecute(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, (sourceLeftLambda, sourceTopLambda, sourceWidthLambda, sourceHeightLambda, targetLeftLambda, targetTopLambda) => System.Console.MoveBufferArea(sourceLeftLambda, sourceTopLambda, sourceWidthLambda, sourceHeightLambda, targetLeftLambda, targetTopLambda));
        }


        public static IObservable<System.Reactive.Unit> MoveBufferArea(IObservable<System.Int32> sourceLeft, IObservable<System.Int32> sourceTop, IObservable<System.Int32> sourceWidth, IObservable<System.Int32> sourceHeight, IObservable<System.Int32> targetLeft, IObservable<System.Int32> targetTop, IObservable<System.Char> sourceChar, IObservable<System.ConsoleColor> sourceForeColor, IObservable<System.ConsoleColor> sourceBackColor)
        {
            return ObservableExt.ZipExecute(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor, (sourceLeftLambda, sourceTopLambda, sourceWidthLambda, sourceHeightLambda, targetLeftLambda, targetTopLambda, sourceCharLambda, sourceForeColorLambda, sourceBackColorLambda) => System.Console.MoveBufferArea(sourceLeftLambda, sourceTopLambda, sourceWidthLambda, sourceHeightLambda, targetLeftLambda, targetTopLambda, sourceCharLambda, sourceForeColorLambda, sourceBackColorLambda));
        }


        public static IObservable<System.Reactive.Unit> SetBufferSize(IObservable<System.Int32> width, IObservable<System.Int32> height)
        {
            return ObservableExt.ZipExecute(width, height, (widthLambda, heightLambda) => System.Console.SetBufferSize(widthLambda, heightLambda));
        }


        public static IObservable<System.Reactive.Unit> SetWindowSize(IObservable<System.Int32> width, IObservable<System.Int32> height)
        {
            return ObservableExt.ZipExecute(width, height, (widthLambda, heightLambda) => System.Console.SetWindowSize(widthLambda, heightLambda));
        }


        public static IObservable<System.Reactive.Unit> SetWindowPosition(IObservable<System.Int32> left, IObservable<System.Int32> top)
        {
            return ObservableExt.ZipExecute(left, top, (leftLambda, topLambda) => System.Console.SetWindowPosition(leftLambda, topLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCursorPosition(IObservable<System.Int32> left, IObservable<System.Int32> top)
        {
            return ObservableExt.ZipExecute(left, top, (leftLambda, topLambda) => System.Console.SetCursorPosition(leftLambda, topLambda));
        }


        public static IObservable<System.ConsoleKeyInfo> ReadKey()
        {
            return ObservableExt.Factory(() => System.Console.ReadKey());
        }


        public static IObservable<System.ConsoleKeyInfo> ReadKey(IObservable<System.Boolean> intercept)
        {
            return Observable.Select(intercept, (interceptLambda) => System.Console.ReadKey(interceptLambda));
        }


        public static IObservable<System.IO.Stream> OpenStandardError()
        {
            return ObservableExt.Factory(() => System.Console.OpenStandardError());
        }


        public static IObservable<System.IO.Stream> OpenStandardError(IObservable<System.Int32> bufferSize)
        {
            return Observable.Select(bufferSize, (bufferSizeLambda) => System.Console.OpenStandardError(bufferSizeLambda));
        }


        public static IObservable<System.IO.Stream> OpenStandardInput()
        {
            return ObservableExt.Factory(() => System.Console.OpenStandardInput());
        }


        public static IObservable<System.IO.Stream> OpenStandardInput(IObservable<System.Int32> bufferSize)
        {
            return Observable.Select(bufferSize, (bufferSizeLambda) => System.Console.OpenStandardInput(bufferSizeLambda));
        }


        public static IObservable<System.IO.Stream> OpenStandardOutput()
        {
            return ObservableExt.Factory(() => System.Console.OpenStandardOutput());
        }


        public static IObservable<System.IO.Stream> OpenStandardOutput(IObservable<System.Int32> bufferSize)
        {
            return Observable.Select(bufferSize, (bufferSizeLambda) => System.Console.OpenStandardOutput(bufferSizeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetIn(IObservable<System.IO.TextReader> newIn)
        {
            return Observable.Do(newIn, (newInLambda) => System.Console.SetIn(newInLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> SetOut(IObservable<System.IO.TextWriter> newOut)
        {
            return Observable.Do(newOut, (newOutLambda) => System.Console.SetOut(newOutLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> SetError(IObservable<System.IO.TextWriter> newError)
        {
            return Observable.Do(newError, (newErrorLambda) => System.Console.SetError(newErrorLambda)).ToUnit();
        }


        public static IObservable<System.Int32> Read()
        {
            return ObservableExt.Factory(() => System.Console.Read());
        }


        public static IObservable<System.String> ReadLine()
        {
            return ObservableExt.Factory(() => System.Console.ReadLine());
        }


        public static IObservable<System.Reactive.Unit> WriteLine()
        {
            return ObservableExt.Factory(() => System.Console.WriteLine());
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.Boolean> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WriteLine(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.Char> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WriteLine(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.Char[]> buffer)
        {
            return Observable.Do(buffer, (bufferLambda) => System.Console.WriteLine(bufferLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return ObservableExt.ZipExecute(buffer, index, count, (bufferLambda, indexLambda, countLambda) => System.Console.WriteLine(bufferLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.Decimal> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WriteLine(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.Double> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WriteLine(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.Single> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WriteLine(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.Int32> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WriteLine(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.UInt32> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WriteLine(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.Int64> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WriteLine(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.UInt64> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WriteLine(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.Object> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WriteLine(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.String> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WriteLine(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.String> format, IObservable<System.Object> arg0)
        {
            return ObservableExt.ZipExecute(format, arg0, (formatLambda, arg0Lambda) => System.Console.WriteLine(formatLambda, arg0Lambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1)
        {
            return ObservableExt.ZipExecute(format, arg0, arg1, (formatLambda, arg0Lambda, arg1Lambda) => System.Console.WriteLine(formatLambda, arg0Lambda, arg1Lambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1, IObservable<System.Object> arg2)
        {
            return ObservableExt.ZipExecute(format, arg0, arg1, arg2, (formatLambda, arg0Lambda, arg1Lambda, arg2Lambda) => System.Console.WriteLine(formatLambda, arg0Lambda, arg1Lambda, arg2Lambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1, IObservable<System.Object> arg2, IObservable<System.Object> arg3)
        {
            return ObservableExt.ZipExecute(format, arg0, arg1, arg2, arg3, (formatLambda, arg0Lambda, arg1Lambda, arg2Lambda, arg3Lambda) => System.Console.WriteLine(formatLambda, arg0Lambda, arg1Lambda, arg2Lambda, arg3Lambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(IObservable<System.String> format, IObservable<System.Object[]> arg)
        {
            return ObservableExt.ZipExecute(format, arg, (formatLambda, argLambda) => System.Console.WriteLine(formatLambda, argLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.String> format, IObservable<System.Object> arg0)
        {
            return ObservableExt.ZipExecute(format, arg0, (formatLambda, arg0Lambda) => System.Console.Write(formatLambda, arg0Lambda));
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1)
        {
            return ObservableExt.ZipExecute(format, arg0, arg1, (formatLambda, arg0Lambda, arg1Lambda) => System.Console.Write(formatLambda, arg0Lambda, arg1Lambda));
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1, IObservable<System.Object> arg2)
        {
            return ObservableExt.ZipExecute(format, arg0, arg1, arg2, (formatLambda, arg0Lambda, arg1Lambda, arg2Lambda) => System.Console.Write(formatLambda, arg0Lambda, arg1Lambda, arg2Lambda));
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1, IObservable<System.Object> arg2, IObservable<System.Object> arg3)
        {
            return ObservableExt.ZipExecute(format, arg0, arg1, arg2, arg3, (formatLambda, arg0Lambda, arg1Lambda, arg2Lambda, arg3Lambda) => System.Console.Write(formatLambda, arg0Lambda, arg1Lambda, arg2Lambda, arg3Lambda));
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.String> format, IObservable<System.Object[]> arg)
        {
            return ObservableExt.ZipExecute(format, arg, (formatLambda, argLambda) => System.Console.Write(formatLambda, argLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.Boolean> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.Write(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.Char> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.Write(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.Char[]> buffer)
        {
            return Observable.Do(buffer, (bufferLambda) => System.Console.Write(bufferLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return ObservableExt.ZipExecute(buffer, index, count, (bufferLambda, indexLambda, countLambda) => System.Console.Write(bufferLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.Double> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.Write(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.Decimal> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.Write(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.Single> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.Write(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.Int32> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.Write(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.UInt32> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.Write(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.Int64> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.Write(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.UInt64> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.Write(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.Object> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.Write(valueLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Write(IObservable<System.String> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.Write(valueLambda)).ToUnit();
        }


        public static IObservable<System.Boolean> get_IsInputRedirected()
        {
            return ObservableExt.Factory(() => System.Console.IsInputRedirected);
        }


        public static IObservable<System.Boolean> get_IsOutputRedirected()
        {
            return ObservableExt.Factory(() => System.Console.IsOutputRedirected);
        }


        public static IObservable<System.Boolean> get_IsErrorRedirected()
        {
            return ObservableExt.Factory(() => System.Console.IsErrorRedirected);
        }


        public static IObservable<System.IO.TextReader> get_In()
        {
            return ObservableExt.Factory(() => System.Console.In);
        }


        public static IObservable<System.IO.TextWriter> get_Out()
        {
            return ObservableExt.Factory(() => System.Console.Out);
        }


        public static IObservable<System.IO.TextWriter> get_Error()
        {
            return ObservableExt.Factory(() => System.Console.Error);
        }


        public static IObservable<System.Text.Encoding> get_InputEncoding()
        {
            return ObservableExt.Factory(() => System.Console.InputEncoding);
        }


        public static IObservable<System.Text.Encoding> get_OutputEncoding()
        {
            return ObservableExt.Factory(() => System.Console.OutputEncoding);
        }


        public static IObservable<System.ConsoleColor> get_BackgroundColor()
        {
            return ObservableExt.Factory(() => System.Console.BackgroundColor);
        }


        public static IObservable<System.ConsoleColor> get_ForegroundColor()
        {
            return ObservableExt.Factory(() => System.Console.ForegroundColor);
        }


        public static IObservable<System.Int32> get_BufferHeight()
        {
            return ObservableExt.Factory(() => System.Console.BufferHeight);
        }


        public static IObservable<System.Int32> get_BufferWidth()
        {
            return ObservableExt.Factory(() => System.Console.BufferWidth);
        }


        public static IObservable<System.Int32> get_WindowHeight()
        {
            return ObservableExt.Factory(() => System.Console.WindowHeight);
        }


        public static IObservable<System.Int32> get_WindowWidth()
        {
            return ObservableExt.Factory(() => System.Console.WindowWidth);
        }


        public static IObservable<System.Int32> get_LargestWindowWidth()
        {
            return ObservableExt.Factory(() => System.Console.LargestWindowWidth);
        }


        public static IObservable<System.Int32> get_LargestWindowHeight()
        {
            return ObservableExt.Factory(() => System.Console.LargestWindowHeight);
        }


        public static IObservable<System.Int32> get_WindowLeft()
        {
            return ObservableExt.Factory(() => System.Console.WindowLeft);
        }


        public static IObservable<System.Int32> get_WindowTop()
        {
            return ObservableExt.Factory(() => System.Console.WindowTop);
        }


        public static IObservable<System.Int32> get_CursorLeft()
        {
            return ObservableExt.Factory(() => System.Console.CursorLeft);
        }


        public static IObservable<System.Int32> get_CursorTop()
        {
            return ObservableExt.Factory(() => System.Console.CursorTop);
        }


        public static IObservable<System.Int32> get_CursorSize()
        {
            return ObservableExt.Factory(() => System.Console.CursorSize);
        }


        public static IObservable<System.Boolean> get_CursorVisible()
        {
            return ObservableExt.Factory(() => System.Console.CursorVisible);
        }


        public static IObservable<System.String> get_Title()
        {
            return ObservableExt.Factory(() => System.Console.Title);
        }


        public static IObservable<System.Boolean> get_KeyAvailable()
        {
            return ObservableExt.Factory(() => System.Console.KeyAvailable);
        }


        public static IObservable<System.Boolean> get_NumberLock()
        {
            return ObservableExt.Factory(() => System.Console.NumberLock);
        }


        public static IObservable<System.Boolean> get_CapsLock()
        {
            return ObservableExt.Factory(() => System.Console.CapsLock);
        }


        public static IObservable<System.Boolean> get_TreatControlCAsInput()
        {
            return ObservableExt.Factory(() => System.Console.TreatControlCAsInput);
        }


        public static IObservable<System.Reactive.Unit> set_InputEncoding(IObservable<System.Text.Encoding> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.InputEncoding = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_OutputEncoding(IObservable<System.Text.Encoding> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.OutputEncoding = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_BackgroundColor(IObservable<System.ConsoleColor> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.BackgroundColor = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_ForegroundColor(IObservable<System.ConsoleColor> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.ForegroundColor = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_BufferHeight(IObservable<System.Int32> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.BufferHeight = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_BufferWidth(IObservable<System.Int32> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.BufferWidth = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_WindowHeight(IObservable<System.Int32> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WindowHeight = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_WindowWidth(IObservable<System.Int32> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WindowWidth = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_WindowLeft(IObservable<System.Int32> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WindowLeft = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_WindowTop(IObservable<System.Int32> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.WindowTop = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_CursorLeft(IObservable<System.Int32> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.CursorLeft = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_CursorTop(IObservable<System.Int32> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.CursorTop = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_CursorSize(IObservable<System.Int32> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.CursorSize = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_CursorVisible(IObservable<System.Boolean> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.CursorVisible = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_Title(IObservable<System.String> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.Title = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_TreatControlCAsInput(IObservable<System.Boolean> value)
        {
            return Observable.Do(value, (valueLambda) => System.Console.TreatControlCAsInput = valueLambda).ToUnit();
        }

    }
}