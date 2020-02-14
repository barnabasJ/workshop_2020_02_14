using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "new Inventory", menuName = "Inventory", order = 0)]
    public class Inventory : ScriptableObject
    {
        public List<GameObject> inventory;

        public bool hasItem(GameObject item)
        {
            return inventory.Contains(item);
        }
        
        public bool addItem(GameObject item)
        {
            return inventory.Contains(item);
        }
        
        public bool removeItem(GameObject item)
        {
            return inventory.Contains(item);
        }
    }
}