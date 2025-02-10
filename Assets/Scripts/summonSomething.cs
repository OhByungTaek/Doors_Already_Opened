using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonSomething : MonoBehaviour
{
    public GameObject gimik;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            {
                gimik.SetActive(true);
            }
        }
}

