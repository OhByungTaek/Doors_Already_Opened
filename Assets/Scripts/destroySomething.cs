using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySomething : MonoBehaviour
{
    public GameObject gimik;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gimik.SetActive(false);
        }
    }
}
