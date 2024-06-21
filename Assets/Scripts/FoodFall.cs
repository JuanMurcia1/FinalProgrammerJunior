using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodFall : MonoBehaviour
{
    public GameObject  foodFalling;
    public GameObject cilindro;
    public TMP_Text moodParki;
    public Vector3 newScale = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
       cilindro = GameObject.Find("Capsule");
       GameObject textObject = GameObject.Find("mood");
        if (textObject != null)
    {
        moodParki = textObject.GetComponent<TMP_Text>();
    }
       
    }

    // Update is called once per frame
    void Update()
    {
        // Here we can see the functions, after apply the abstraction.
        FoodController();
        DestroyFood();

        
    }

    private void OnTriggerEnter(Collider other)
    {
        BarController();
       
    }

    public virtual void BarController()
    {
        newScale = cilindro.transform.localScale;
        if(foodFalling.CompareTag("Bad")){

            newScale.y -= 0.1f; 
            cilindro.transform.localScale = newScale;
            Destroy(gameObject);
            
        }else if(foodFalling.CompareTag("Good")){
            
            newScale.y += 0.1f; 
            cilindro.transform.localScale = newScale;
            Destroy(gameObject);
        }

        if(newScale.y < 2)
        {
            moodParki.text= "Hungry Parki";
        }else if(newScale.y > 2 & newScale.y < 3)
        {
            moodParki.text="Normal Parki";
        }
        else if(newScale.y >3)
        {
            moodParki.text=" Satisfied parki";
        }
    }

    public void DestroyFood(){
        if(foodFalling.transform.position.y < -3.0f){
            Destroy(gameObject);
        }
    }

    public void FoodController()
    {
        float velFood = 4.0f;
        transform.Translate(Vector3.down * Time.deltaTime*velFood);

    }

    

}
