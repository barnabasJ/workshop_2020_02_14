using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    [SerializeField] private GameObject key;
    [SerializeField] private Inventory playerInventory;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerInventory.hasItem(key))
            {
                gameObject.SetActive(false);
            }
        }
    }
}
