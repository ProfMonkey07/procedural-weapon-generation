using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTerrain : MonoBehaviour
{
    public Transform blade;
    public int hilt1;
    public int hilt2;
    public int hilt3;
    public int blade1;
    public int blade2;
    public int blade3;
    // Start is called before the first frame update
    public void now()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
             hilt1 = Random.Range(10, 100);
             hilt2 = Random.Range(10, 100);
             hilt3 = Random.Range(10, 100);
             blade1 = Random.Range(10, 100);
             blade2 = Random.Range(10, 100);
            blade3 = Random.Range(10, 100);
            if ((blade1 <= hilt1) && blade2 >= hilt3)
            transform.localScale = new Vector3(hilt1, hilt2, hilt3);
            blade.localScale = new Vector3(blade1, blade2, blade3);


        }
        else
        {
            hilt1 = Random.Range(10, 100);
             hilt2 = Random.Range(10, 100);
            hilt3 = Random.Range(10, 100);
            blade1 = Random.Range(10, 100);
           blade2 = Random.Range(10, 100);
            blade3 = Random.Range(10, 100);

            if ((blade1 <= hilt1) && blade2 >= hilt3)
            {
                transform.localScale = new Vector3(hilt1, hilt2, hilt3);
                blade.localScale = new Vector3(blade1, blade2, blade3);
            
            
            }


            else
            {
                hilt1 = Random.Range(10, 100);
                hilt2 = Random.Range(10, 100);
                hilt3 = Random.Range(10, 100);
                blade1 = Random.Range(10, 100);
                blade2 = Random.Range(10, 100);
                blade3 = Random.Range(10, 100);


            }

        }
    }
}
