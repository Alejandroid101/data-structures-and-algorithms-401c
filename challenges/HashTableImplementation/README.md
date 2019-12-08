# Challenge Summary for Hash Tables Implementation(CH30)
Hash tables store key value pairs in arrays and lists to make it easier to find something quicker.
With this method we can easily convert a key into an index to safely store and find things.
-----
## Challenge Description
Implement a hashtable with the next 4 methods into this app:
Add: Takes a key and a value, hashes the key and then stores the key-value pair into the table. Handles collisions as needed.
Get: Takes in the key and returns the value from the table.
Contains: Takes in the key and t=returns a boolean indicating if the key exists in the table.
Hash: Takes a random key and returns an index in the table/collition.

------
## Approach & Efficiency
By first creating the Hash and Contains Methods, we can then use those 2 inside our other 2 methods (Add and Get)
Add will use Hash() to store something, and get will use Hash() to get index and then Contains to see if there is something stored there 
to then retrieve that value.

-------
## Solution
![Image 1](https://github.com/Alejandroid101/data-structures-and-algorithms-401c/blob/master/assets/CH30HashTables.png?raw=true)


