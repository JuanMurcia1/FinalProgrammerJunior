using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BadEnding : MonoBehaviour
{
    public TextMeshPro messageBadEnding;
    public TextMeshPro messageBadEnding2;

    // ENCAPSULATION
    public FoodFall foodFallInstance;
   

    // Update is called once per frame
    void Update()
    {
        NoWay();
    }


// ENCAPSULATION
    public void NoWay()
    { 
        if(messageBadEnding2.text=="Toxic...")
        {
            messageBadEnding.text ="NO WAY";
            messageBadEnding.transform.Translate(Vector3.down * Time.deltaTime *foodFallInstance.VelFood);
        }


        
    }
}
