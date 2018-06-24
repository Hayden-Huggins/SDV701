// Created by Hayden Huggins 20/06/2018
// This class is our Service client, this communicates to our self hosted application via a URI which is mapped in said 
// Application, this way we can achieve multi user functionality, provided that each application has the required Service Client and DTO classes

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Client_App
{
    public static class ServiceClient
    {   
        internal async static Task<string> DeleteBookAsync(clsAllBook prBook)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
            ($"http://localhost:60064/api/bookstore/DeleteBook?prName=" + prBook.Name);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
            throw new NotImplementedException();
        }

        internal async static Task<string> DeleteOrderAsync(clsOrder prOrder)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
            ($"http://localhost:60064/api/bookstore/DeleteOrder?prcustName=" + prOrder.CustomerName);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
            throw new NotImplementedException();
        }

        internal async static Task<clsAllBook> GetBookAsync(string prBookName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsAllBook>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/bookstore/GetBook?prName=" + prBookName));

        }

        internal async static Task<List<clsAllBook>> GetBookQueryAsync(string prName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsAllBook>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/bookstore/GetBookQuery?prName=" + prName));
        }

        internal async static Task<clsGenre> GetGenreAsync(string prGenreName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsGenre>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/bookstore/GetGenre?prName=" + prGenreName));

        }

        internal async static Task<List<clsAllBook>> GetGenreBooksAsync(string prGenreName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsAllBook>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/bookstore/GetGenreBooks?prGenreName=" + prGenreName));

        }

        internal async static Task<List<string>> GetGenreNamesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/bookstore/GetGenreNames/"));
        }

        internal async static Task<List<clsOrder>> GetOrdersAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsOrder>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/bookstore/GetOrders/"));
        }

        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content =
        new StringContent(JsonConvert.SerializeObject(prItem), Encoding.UTF8, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        internal async static Task<string> InsertBookAsync(clsAllBook _Book)
        {
            return await InsertOrUpdateAsync(_Book, "http://localhost:60064/api/bookstore/PostBook", "POST");
        }

        internal async static Task<string> InsertOrderAsync(clsOrder _Order)
        {
            return await InsertOrUpdateAsync(_Order, "http://localhost:60064/api/bookstore/PostOrder", "POST");
        }

        internal async static Task<string> UpdateBookAsync(clsAllBook _Book)
        {
            return await InsertOrUpdateAsync(_Book, "http://localhost:60064/api/bookstore/PutBook", "PUT");
        }

        internal async static Task<string> UpdateBookQuantityAsync(clsAllBook _Book)
        {
            return await InsertOrUpdateAsync(_Book, "http://localhost:60064/api/bookstore/PutBookQuantity", "PUT");
        }
    }
}
