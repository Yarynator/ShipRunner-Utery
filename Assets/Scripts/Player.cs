using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private Transform player;
    private float playerSpeed;

    [SerializeField] private Transform leftSide;
    [SerializeField] private Transform rightSide;
    [SerializeField] private Transform water;

    private int lastPosY;
    private int playerPositionX;

    void Start()
    {
        player = transform;
        playerSpeed = 2f;
        lastPosY = (int)player.position.y;// 5,6 - 5
        playerPositionX = 0;
    }

    void Update()
    {
        Vector3 pos = player.position;
        pos.y += Time.deltaTime * playerSpeed;

        if((int)pos.y > lastPosY)
        {
            lastPosY = (int)pos.y;
            Instantiate(leftSide, new Vector3(-2.32f, lastPosY + 7, 0), Quaternion.identity);
            Instantiate(rightSide, new Vector3(2.32f, lastPosY + 7, 0), Quaternion.identity);

        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            if(playerPositionX >= 0)
            {
                playerPositionX--;
            }
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            if(playerPositionX <= 0)
            {
                playerPositionX++;
            }
        }
        pos.x = playerPositionX;

        player.position = pos;

        pos.x = 0;
        pos.z = 1;
        water.position = pos;

    }

}
