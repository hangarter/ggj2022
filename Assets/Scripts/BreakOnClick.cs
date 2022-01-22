using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BreakableDoor))]
public class BreakOnClick : MonoBehaviour
{
    private BreakableDoor breakableDoor;

    void Start()
    {
        breakableDoor = GetComponent<BreakableDoor>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                //Select stage    
                if (hit.transform.name == "Door")
                {
                    breakableDoor.HitDoor();
                }
            }
        }
    }
}
