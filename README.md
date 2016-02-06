# RxWrappers

## Welcome to Rx Wrappers

This project contains code that wraps common libraries with an Reactive Extension (Rx) facade. The intention is for these wrappers to be used in the MonadSharp language (name tenative). 

## What are Rx Wrappers?

These wrappers are generated for existing libraries that do not use Rx conventions as a common part of their API. For example, the wrapper for mscorlib contains wrappers for classes such as Console and Int32. They exist to facilitate the use of Rx-Unaware APIs and use them exclusivly in the Rx world of Observables. Some examples of what you can find are:
```csharp
void WriteLine(string message) → IObservable<Unit> WriteLine(IObservable<string> message) 
```
```csharp
bool TryParse(string input, out Guid result) → 
     IObservable<Tuple<bool, Guid>> TryParse(IObservable<string> input) 
```
```csharp
StreamReader OpenText(string path) → IObservable<StreamReader> OpenText(IObservable<string> path) 
```
## Example

Here an example of using these wrapper in standard C# code:
```csharp
async public Task Test()
{
    variable<HttpClient> client = new HttpClient();
    variable<string> url = "http://jsonplaceholder.typicode.com/users";
    var result = client.GetStringAsync(url);
    var deserialized = __JsonConvert.DeserializeObject<IEnumerable<User>>(result);
    deserialized = deserialized.FirstAsync();
    var serialized = __JsonConvert.SerializeObject(deserialized);
    await __Console.WriteLine(serialized);
}
```

## Other Information

This project is maintained by Samuel McAravey, and is available under MIT (too much for one person to build). Code for generating these wrappers is an ugly, horrid, incomplete mess. If you are interested in helping clean it up and/or would like to see it in it's current state then let me know, and potential it will be put on GitHub. Otherwise if you have an assembly you would like wrapped then please create a issue for it.
