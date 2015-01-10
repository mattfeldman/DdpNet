﻿namespace DdpNet.Collections
{
    using System.Collections.Generic;
    using Messages;
    using Newtonsoft.Json.Linq;

    internal class CollectionManager
    {
        private readonly Dictionary<string, IDdpCollection> collections;

        public CollectionManager()
        {
            this.collections = new Dictionary<string, IDdpCollection>();
        }

        public void Add(Added message)
        {
            if (!this.collections.ContainsKey(message.Collection))
            {
                this.collections.Add(message.Collection, new UntypedCollection(message.Collection));
            }

            this.collections[message.Collection].Add(message.ID, message.Fields);
        }

        public DdpSubscription<T> GetSubscription<T>(string subscriptionName) where T: DdpObject
        {
            return this.GetSubscription<T>(subscriptionName, subscriptionName);
        }

        public DdpSubscription<T> GetSubscription<T>(string subscriptionName, string collectionName) where T: DdpObject
        {
            IDdpCollection collection;

            if (!this.collections.TryGetValue(collectionName, out collection))
            {
                collection = new TypedCollection<T>(collectionName);
                this.collections.Add(collectionName, collection);
            }
            else if (collection is UntypedCollection)
            {
                var convertedCollection = this.ConvertToTypedCollection<T>((UntypedCollection) collection);
                this.collections[collectionName] = convertedCollection;
                collection = convertedCollection;
            }

            var typedCollection = (TypedCollection<T>) collection;

            return typedCollection.GetSubscription(subscriptionName);
        }

        private TypedCollection<T> ConvertToTypedCollection<T>(UntypedCollection collection) where T: DdpObject
        {
            var typedCollection = new TypedCollection<T>(collection.CollectionName);

            foreach (var item in collection.Objects)
            {
                typedCollection.Add(item.Key, item.Value);
            }

            return typedCollection;
        }
    }
}
