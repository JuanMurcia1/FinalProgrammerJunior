using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    
     private Animator playerAnim;
     public GameObject player;
    private float forceRun= 8.0f;
    // Start is called before the first frame update
    void Start()
    {
         
        playerAnim= GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.A)){

            transform.Translate(Vector3.right*forceRun* Time.deltaTime);
    
            playerAnim.SetFloat("Speed_f", forceRun);
            playerAnim.SetBool("Static_b", true);
            
            
        }else if(Input.GetKey(KeyCode.D)){

            transform.Translate(Vector3.left*forceRun* Time.deltaTime);
    
            playerAnim.SetFloat("Speed_f", forceRun);
            playerAnim.SetBool("Static_b", false);
            

        }else if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)){
        playerAnim.SetFloat("Speed_f", 0.0f);
        playerAnim.SetBool("Static_b", false);

    }
        playerBounds();

        
    }

    private void playerBounds(){
        Vector3 currentPosition= player.transform.position;
        if(player.transform.position.x < -7.0f){
            currentPosition.x=-7.0f;
        }else if(player.transform.position.x > 8.31f){
            currentPosition.x=8.31f;

        }

        player.transform.position = currentPosition;



    }


}
