using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField] private Transform[] enemies;
    [SerializeField] private Transform player;

    int lastPosY;

    void Start()
    {
        lastPosY = 0;
    }

    void Update()
    {
        if((int)player.position.y > lastPosY)
        {
            lastPosY++;

            if(lastPosY % 2 == 0)
            {
                int randomIndex = Random.Range(0, enemies.Length);
                int randomPosX = Random.Range(-1, 2);
                Instantiate(enemies[randomIndex], new Vector3(randomPosX, lastPosY + 7, 0), Quaternion.identity);
            }
        }
    }

}
