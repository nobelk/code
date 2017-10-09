Design
-----------------------------------------------------------------------------------------------
The LRUcache is designed to optimize constant time reads to the stored string key value pairs.
An array is used to store the cache items and a dictionary is used to map the key of the cache
item to its index in the array.  An integer is used to store the usage count (GET/SET) for all
cache items.
The cache element with the smallest usage count is replaced as the implementation of
the LRU replacement strategy.


Classes
-----------------------------------------------------------------------------------------------
CacheItem - items within the cache
LRUcache - cache
CacheDriver - driver class that validates user inputs prints output to console

Assumptions
-----------------------------------------------------------------------------------------------
LRUcache needs to be initialized (by setting the size) before GET/SET operations can be performed.
Cache size should be in the range [1,int.MaxValue]
LRUcache will be run in a single threaded manner, i.e., GET/SET operations are not threadsafe. 


Build and Run
-----------------------------------------------------------------------------------------------

Dotnet core sdk is required to build and run the program.

https://www.microsoft.com/net/core

1. Open a command prompt and create a new folder
2. Navigate to the folder you created and run the following
   dotnet new console
3. Replace the generated Program.cs file with the attached Program.cs file and run the following
   dotnet restore
   dotnet build
   dotnet run


Worst Case Runtime Complexity
-----------------------------------------------------------------------------------------------
GET operation - O(1)
SET operation - O(n) [n is the cachesize]