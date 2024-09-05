using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour, IColors
{
    private PlayerMove player;
    private Transform playerTransform;
    // Start is called before the first frame update

    private void Awake()
    {

    }
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Attack()
    {
        Debug.Log("Gun attack");
    }

    public void PickedUp()
    {

    if (!player.HasGun)
        {
            playerTransform.localScale *= 2;

        }

        player.HasGun = true;
        Debug.Log("Picked Up");

    }

    public void SetColor()
    {
        player.HasGun = false;
        if (player.HasGun)
        {
        playerTransform.localScale = player.scale;

        }
    }
}
