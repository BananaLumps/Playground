using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    public string id; //item id in form of unique name.
    public bool edible;
    public int attack;
    public int defence;
    public string type; //Helmet, Sword, Food, Material etc.
    public bool equipable;
    public bool level; //Level required to use/equip item.
    public string itemName;
    public double actionStrength; //used in action calculations
    public string iconB64;

    public Item(string id, string type, string itemName)
    {
        this.id = id;
        this.type = type;
        this.itemName = itemName;
        //this.iconB64 = icon;
    }
}
