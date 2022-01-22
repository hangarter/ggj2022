using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Briefcase : MonoBehaviour
{
    private BoxCollider col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ColEnable()
    {
        col.enabled = true;
    }

    public void ColDisable()
    {
        col.enabled = false;
    }
}
