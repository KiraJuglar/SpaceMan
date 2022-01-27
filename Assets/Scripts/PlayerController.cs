using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //CONSTANTES
    const string IS_ALIVE = "isAlive";
    const string IS_ON_THE_GROUND = "isOnTheGround";

    //Variables del movimiento del jugador
    public float jumpForce = 6f;
    public float runningSpeed = 2f;
    Rigidbody2D rigidBody; 
    public LayerMask groundMask; //Variable que identifica los objetos que pertenecen a la capa de suelo
    Animator animator;

    private void Awake()
    {
        //Estos métodos nos permiten obtener una referencia de los objetos de la clase
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool(IS_ALIVE, true);   
        animator.SetBool(IS_ON_THE_GROUND, true);   
    }

    private void FixedUpdate()
    {
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }

        animator.SetBool(IS_ON_THE_GROUND, isTouchingTheGround());
      
        Debug.DrawRay(this.transform.position, Vector2.down*1.5f, Color.red);
    }

    void Jump()
    {
        if (isTouchingTheGround())
        {
            rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void Move()
    {
        rigidBody.velocity = new Vector2(Input.GetAxis("Horizontal") * runningSpeed, rigidBody.velocity.y);
        if (Input.GetAxis("Horizontal") < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    bool isTouchingTheGround()
    {
        return Physics2D.Raycast(this.transform.position, Vector2.down, 1.5f, groundMask);
    }
}
