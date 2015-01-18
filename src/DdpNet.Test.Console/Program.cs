﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DdpNet.Test.Console
{
    using System.Collections.Specialized;
    using System.Threading;
    using Console = System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            var client = new MeteorClient(new ConsoleLoggingConnection(new WebSocketConnection(new Uri("ws://localhost:3000/websocket"))));
            client.ConnectAsync().Wait();

            client.LoginPassword("chris", "password").Wait();


            client.Subscribe("posts").Wait();
            var posts = client.GetCollection<Post>("posts");

            posts.CollectionChanged += (sender, eventArgs) =>
            {
                Console.WriteLine(posts.Count);
                foreach (var post in posts)
                {
                    Console.WriteLine(post.title);
                }
            };

            var objectToUpdate = posts.First();
            objectToUpdate.title = "updated w00t2";
            posts.UpdateAsync(objectToUpdate).Wait();

            //posts.InsertAsync(new Post {author = "testadd", title = "testadd", url = "testadd"});
            var task = client.Call<string>("testMethod");
            task.Wait();
            Console.WriteLine(task.Result);

            Console.ReadKey();
        }
    }
}
