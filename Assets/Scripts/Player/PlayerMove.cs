using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public List<IColors> colors = new List<IColors>(); 
    private Rigidbody2D rb;
    public Gun gun;
    public Sword sword;

    [HideInInspector] public Vector2 scale;
    [SerializeField] public bool HasGun;

    public IColors currentWeapon;
    void Start()
    {
        scale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frames
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);

        interFace();
    }


    public void interFace()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentWeapon?.Attack();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = gun;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = sword;
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sword"))
        {
        
            currentWeapon = sword;
            currentWeapon.SetColor();
            sword.PickedUp();
        }
        if (collision.CompareTag("Gun"))
        {
 
            currentWeapon = gun;
            gun.PickedUp();
        }
    }
}
