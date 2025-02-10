using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienWatchingMe : MonoBehaviour
{
    public GameObject alien;
    public GameObject player;

    /*(private void Update()
    {
        // alien이 player를 바라보도록 설정
        alien.transform.LookAt(player.transform);
    }*/

    private void Update()
    {
        // WathcingAlien 의 자식들을 순회하며 player를 바라보도록 설정
        for (int i = 0; i < alien.transform.childCount; i++)
        {
            alien.transform.GetChild(i).LookAt(player.transform);
        }
    }
}
