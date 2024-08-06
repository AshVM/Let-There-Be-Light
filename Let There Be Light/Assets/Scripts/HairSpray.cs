using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairSpray : MonoBehaviour
{
    public GameObject spray;
    private GameObject sprayCopy;
 
    // Update is called once per frame
    void Update()
    {
        // if player is pressing down LMB
      if (Input.GetMouseButtonDown(0))
        {
            if (sprayCopy == null)
            {
                sprayCopy = Instantiate(spray);
            }
        }

      //if player lets go of LMB
      if (Input.GetMouseButtonUp(0)) 
        {
            Destroy(sprayCopy);
            if (sprayCopy != null)
            {
                sprayCopy = null;
                Destroy(sprayCopy);
            }
        }
    }

  
}
