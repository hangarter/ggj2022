using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody playerRb;
    public bool isGrounded;
    float horizontalMovement;
    float verticalMovement;
    float playerHeight = 2f;
    public float jumpForce;
    Vector3 moveDirection;

    public float airMultiplier = 0.4f;
    public Image rageFill;
    public bool addRage;
    public bool minusRage;

    // Start is called before the first frame update
    void Start()
    {
        rageFill.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, playerHeight / 2 + 0.1f);

        MyInput();
        MovePlayer();

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();

        }

       




    }



    void MyInput()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");

        moveDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;
    }

    void MovePlayer()
    {

        if (isGrounded)
        {
            playerRb.AddForce(moveDirection * speed , ForceMode.Acceleration);  
        }
        else if (!isGrounded)
        {
            playerRb.AddForce(moveDirection * speed * airMultiplier, ForceMode.Force);
        }
    }

    void Jump()
    {
        playerRb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Rage")
        {
            rageFill.fillAmount = rageFill.fillAmount + 0.1f;
        }
    }

    //void Rage()
    //{
        

    //    if (minusRage == true)
    //    {
    //        rageFill.fillAmount = rageFill.fillAmount - 0.05f;
    //    }

    //}
}
