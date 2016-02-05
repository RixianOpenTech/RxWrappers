using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Microsoft.Net.Http.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        async public Task TestMethod1()
        {
            variable<HttpClient> client = new HttpClient();
            variable<string> url = "http://jsonplaceholder.typicode.com/users";
            variable<Formatting> formatting = Formatting.Indented;
            var result = client.GetStringAsync(url);
            var deserialized = __JsonConvert.DeserializeObject<List<User>>(result);
            await __Console.WriteLine(__JsonConvert.SerializeObject(deserialized, formatting));
        }
    }

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
    }

    public class variable<T> : IObservable<T>
    {
        private readonly IObservable<T> observable;

        private variable(T value)
        {
            this.observable = Observable.Return(value);
        }

        public static implicit operator variable<T>(T value)
        {
            return new variable<T>(value);
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            return observable.Subscribe(observer);
        }
    }
}
