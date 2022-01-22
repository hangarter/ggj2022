using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatorController : MonoBehaviour
{
    public Animator hit;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hit.SetBool("Hit", Mouse.current.leftButton.ReadValue()==1);

        Debug.Log(Mouse.current.leftButton.ReadValue());
    }


    //public void OnHit(InputValue Value)
    //{
    //    Debug.Log("yes");

    //    hit.SetBool("Hit", true);


    //}

    //public void OnTest(InputValue Value)
    //{
    //    Debug.Log(Value.isPressed);

    //    hit.SetBool("Hit", true);


    //}
}
