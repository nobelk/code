using System;
using System.Collections.Generic;

namespace LRUcache
{
    /** Cache items */
    public class CacheItem
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public int LastUsed { get; set; }
    }

    /** LRUcache */
    public class LRUcache
    {

        public const string ErrorResponse = "ERROR";

        public const string SizeOkResponse = "SIZE OK";

        public const string GetOkResponse = "GOT ";

        public const string SetOkResponse = "SET OK";

        public const string GetNotFoundResponse = "NOTFOUND";

        private int usageCounter = 0;

        /** Stores all cache items */
        private CacheItem[] cache;

        /** Stores the key-index mapping */
        private Dictionary<string,int> keyValueMapping;

        /** Finds the index of the least recently used cache item */
        private int FindLeastRecentlyUsedIndex()
        {
            int leastRecentlyUsedIndex = 0;
            for(int index=0; index < this.cache.Length; index++)
            {
                if(this.cache[index].LastUsed < this.cache[leastRecentlyUsedIndex].LastUsed)
                {
                    leastRecentlyUsedIndex = index;
                }
            }

            return leastRecentlyUsedIndex;
        }

        /** Finds the index of the empty cache slot */
        private int FindEmptyCacheSlotIndex()
        {
            for(int index=0; index<this.cache.Length; index++)
            {
                if(this.cache[index]==null)
                {
                    return index;
                }
            }

            return -1;
        }

        /** Returns the value for the supplied key in GOT <value> format */
        public string Get(string key)
        {
            // validate input
            if(string.IsNullOrEmpty(key))
            {
                return LRUcache.ErrorResponse;
            }

            // Cache hit
            int foundValueIndex;
            if(this.keyValueMapping.TryGetValue(key, out foundValueIndex))
            {
                //update cache item's last used counter
                this.usageCounter++;
                this.cache[foundValueIndex].LastUsed = this.usageCounter;

                // return value
                return LRUcache.GetOkResponse+this.cache[foundValueIndex].Value;
            }

            // Cache miss
            return LRUcache.GetNotFoundResponse;
        }

        /** Stores the key-value pair in the cache */
        public string Set(string itemKey, string itemValue)
        {
            // validate input
            if(string.IsNullOrEmpty(itemKey)
            ||
            string.IsNullOrEmpty(itemValue))
            {
                return LRUcache.ErrorResponse;
            }

            // update item if exists
            int foundCacheIndex = 0;
            if(this.keyValueMapping.TryGetValue(itemKey, out foundCacheIndex))
            {
                this.usageCounter++;
                this.cache[foundCacheIndex].Value = itemValue;
                this.cache[foundCacheIndex].LastUsed = this.usageCounter;

                return LRUcache.SetOkResponse;
            }

            // store item in empty cache slot if exists
            int emptyCacheSlotIndex = this.FindEmptyCacheSlotIndex();
            if(emptyCacheSlotIndex >= 0)
            {
                // update counter and store item in cache
                this.usageCounter++;
                this.cache[emptyCacheSlotIndex] = new CacheItem{ 
                    Key = itemKey,
                    Value = itemValue,
                    LastUsed = this.usageCounter };
                
                // update index
                this.keyValueMapping.Add(itemKey, emptyCacheSlotIndex);
            }
            else
            {
                // replace least recently used item with lowest usage counter value
                int leastRecentlyUsedIndex = this.FindLeastRecentlyUsedIndex();
                string replaceKey = this.cache[leastRecentlyUsedIndex].Key;
                
                // update counter and store item in cache
                this.usageCounter++;
                this.cache[leastRecentlyUsedIndex] = new CacheItem{ 
                    Key = itemKey,
                    Value = itemValue,
                    LastUsed = this.usageCounter };
                
                // update index
                this.keyValueMapping.Remove(replaceKey);
                this.keyValueMapping.Add(itemKey, leastRecentlyUsedIndex);
            }

            return LRUcache.SetOkResponse;
        }


        /** Initializes cache */
        public string InitializeCache(int size)
        {
            // initialize object
            this.cache = new CacheItem[size];
            this.keyValueMapping = new Dictionary<string,int>();

            return LRUcache.SizeOkResponse;
        }

        /** Default constructor */
        public LRUcache()
        {            
        }
    }

    /** Driver class for processing user I/O */
    class CacheDriver
    {
        static void Main(string[] args)
        {
            LRUcache lRUcache = null;
            string userInput = string.Empty;
            while(true)
            {
                userInput = Console.ReadLine();
                string[] userInputArray = userInput.Split(' ');

                if(userInputArray[0].Equals("SIZE"))
                {
                    if(userInputArray.Length != 2
                    ||
                    lRUcache != null)
                    {
                        Console.WriteLine(LRUcache.ErrorResponse);
                        continue;
                    }

                    int cacheSize = 1;
                    if(Int32.TryParse(userInputArray[1], out cacheSize))
                    {
                        if(cacheSize <= 0)
                        {
                            Console.WriteLine(LRUcache.ErrorResponse);
                            continue;                            
                        }
                        
                        lRUcache = new LRUcache();
                        Console.WriteLine(lRUcache.InitializeCache(cacheSize));                   
                    }
                    else
                    {
                        Console.WriteLine(LRUcache.ErrorResponse);
                        continue;
                    }                    
                }
                else if(userInputArray[0].Equals("GET"))
                {
                    if(userInputArray.Length != 2
                    ||
                    lRUcache == null)
                    {
                        Console.WriteLine(LRUcache.ErrorResponse);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(lRUcache.Get(userInputArray[1]));
                    }

                }
                else if(userInputArray[0].Equals("SET"))
                {
                    if(userInputArray.Length != 3
                    ||
                    lRUcache == null)
                    {
                        Console.WriteLine(LRUcache.ErrorResponse);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(lRUcache.Set(userInputArray[1], userInputArray[2]));
                    }
                }
                else if(userInputArray[0].Equals("EXIT"))
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine(LRUcache.ErrorResponse);
                    continue;
                }
            }           
        }
    }
}
