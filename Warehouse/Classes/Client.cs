using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Warehouse.Classes
{
    public static class Client
    {
        public static T SendGetRequest<T>(HttpClient client, string url)
        {
            HttpResponseMessage response;
            T obj = default(T);
            Task task = Task.Run(new Func<Task>(async () =>
            {
                response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode) obj = await response.Content.ReadAsAsync<T>();
            }));
            try
            {
                task.Wait();
            }
            catch (AggregateException)
            {

            }
            return obj;
        }
        public static T SendPostRequest<T>(HttpClient client, string url, T obj)
        {
            HttpResponseMessage response = null;
            Task task = Task.Run(new Func<Task>(async () =>
            {
                response = await client.PostAsJsonAsync(url, obj);
                if (response.IsSuccessStatusCode) obj = await response.Content.ReadAsAsync<T>();
            }));
            try
            {
                task.Wait();
            }
            catch (AggregateException)
            {

            }
            return obj;
        }
        public static void SendPutRequest<T>(HttpClient client, string url, T obj)
        {
            HttpResponseMessage response = null;
            Task task = Task.Run(new Func<Task>(async () =>
            {
                response = await client.PutAsJsonAsync<T>(url, obj);
                response.EnsureSuccessStatusCode();
            }));
            try
            {
                task.Wait();
            }
            catch (AggregateException)
            {

            }
        }
        public static void SendDeleteRequest<T>(HttpClient client, string url)
        {
            HttpResponseMessage response = null;
            Task task = Task.Run(new Func<Task>(async () =>
            {
                response = await client.DeleteAsync(url);
            }));
            try
            {
                task.Wait();
            }
            catch (AggregateException)
            {

            }
        }
    }
}
