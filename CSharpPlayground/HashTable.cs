namespace CSharpPlayground;
using System;
using System.Collections;

public class HashTable
{
    public void getHashTable()
    {
        Hashtable htbl = new Hashtable();
        htbl.Add("msg", "Welcome");
        htbl.Add("site", "Tutlane");
        htbl.Add(1, 20.5);
        htbl.Add(2, null);
        // Another way to add elements. If key not exist, then that key adds a new key/value pair.
        htbl[3] = "Tutorials";
        // Add method will throws an exception if key already exists in hash table
        try
        {
            htbl.Add(2, 100);
        }
        catch
        {
            Console.WriteLine("An element with Key = '2' already exists.");
        }
        Console.WriteLine("*********HashTable Elements********");
        // It will return elements as KeyValuePair objects.
        foreach (DictionaryEntry item in htbl)
        {
            Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
        }
        Console.ReadLine();
        
        Hashtable htbl2 = new Hashtable(){
            {"msg", "Welcome"},
            {"site", "Tutlane"},
            {1, 20.5},
            {2, null}
        };
    }
}