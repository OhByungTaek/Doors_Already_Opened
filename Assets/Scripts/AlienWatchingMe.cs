using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienWatchingMe : MonoBehaviour
{
    public GameObject alien;
    public GameObject player;

    /*(private void Update()
    {
        // alien�� player�� �ٶ󺸵��� ����
        alien.transform.LookAt(player.transform);
    }*/

    private void Update()
    {
        // WathcingAlien �� �ڽĵ��� ��ȸ�ϸ� player�� �ٶ󺸵��� ����
        for (int i = 0; i < alien.transform.childCount; i++)
        {
            alien.transform.GetChild(i).LookAt(player.transform);
        }
    }
}
