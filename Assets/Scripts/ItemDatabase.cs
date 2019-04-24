using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Xml.Linq;
using System.IO;

public class ItemDatabase : MonoBehaviour {
    public List<Item> itemDatabase = new List<Item>();
    private void Awake()
    {
        BuildDatabase();
    }
    private void BuildDatabase()
    {
        foreach ( string file in Directory.EnumerateFiles("Assets/Resources/Items/"))
        {
            if (file.EndsWith(".xml"))
            {
                XDocument f = XDocument.Load(file);
                Item i = new Item("test",(from el in f.Root.Descendants("type") select el).First().Value, (from el in f.Root.Descendants("name") select el).First().Value);
                itemDatabase.Add(i);
            }
        }
        Debug.Log(itemDatabase[0].itemName);
        Debug.Log(itemDatabase[1].itemName + itemDatabase[1].iconB64);
    }
}
