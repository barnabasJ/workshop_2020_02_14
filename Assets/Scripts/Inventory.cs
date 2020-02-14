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
        
        public void addItem(GameObject item)
        {
            inventory.Add(item);
        }
        
        public void removeItem(GameObject item)
        {
            inventory.Remove(item);
        }
    }
}