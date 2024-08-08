using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugBehavior : MonoBehaviour
{
   public ScoreManager scoreManager;
    //public bool bugClicked = false;

    // Update is called once per frame
    void Update()
    {
         
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        scoreManager.ChangeScore(1);
        /*bugClicked = true;
        if (bugClicked)
        {
            Debug.Log("bug was clicked");
            Debug.Log(bugClicked.ToString());
        } */
    }
}
