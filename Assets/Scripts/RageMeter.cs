using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RageMeter : MonoBehaviour
{
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
        
    }


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Rage")
        {
            
            rageFill.fillAmount = rageFill.fillAmount + 0.04f;
        }
    }


    //void Rage()
    //{


    //    if (minusRage == true)
    //    {
    //        rageFill.fillAmount = rageFill.fillAmount - 0.05f;
    //    }
}
