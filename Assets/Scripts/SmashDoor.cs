using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashDoor : MonoBehaviour
{
    private RageMeter rageMeter;


    // Start is called before the first frame update
    void Start()
    {
        rageMeter = gameObject.GetComponent<RageMeter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Door")
        { if (rageMeter.rageFill.fillAmount == 1)
            {
                other.gameObject.GetComponent<BreakableDoor>().HitDoor();

                rageMeter.rageFill.fillAmount = 0;
            }
            else
            {
                Debug.Log("need more rage");
            }
        }
    }
}
