using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IColors
{
    private SpriteRenderer thisRenderer;
    private Color colorToSet;
    private SpriteRenderer playerRenderer;
    private PlayerMove player;
    // Start is called before the first frame update

    private void Awake()
    {
    }
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        thisRenderer = GetComponent<SpriteRenderer>();
        colorToSet = thisRenderer.color;
        playerRenderer = GameObject.Find("Player").GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        playerRenderer.color = colorToSet;
    }
    public void Attack()
    {
        Debug.Log("Sword attack");
    }

    public void PickedUp()
    {
        playerRenderer.color = colorToSet;
    }

    public void SetColor()
    {

    }
}
