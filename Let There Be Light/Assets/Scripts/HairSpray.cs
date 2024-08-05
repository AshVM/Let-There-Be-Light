using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairSpray : MonoBehaviour
{
    public GameObject spray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
        {
            Instantiate(spray);
        }
      if (Input.GetMouseButtonUp(0)) 
        {
            Destroy(spray);
        }
    }

  
}
