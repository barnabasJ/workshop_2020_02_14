using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    [SerializeField] private GameObject key;
    [SerializeField] private GameObject player;

    public void OnTriggerEnter(Collider other)
    {
    }
}
