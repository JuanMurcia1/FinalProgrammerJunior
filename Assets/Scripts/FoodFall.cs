using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodFall : MonoBehaviour
{
    public GameObject foodFalling;
    public GameObject cilindro;
    public TMP_Text moodParki;
    public Vector3 newScale = new Vector3();
    private float _velFood = 4.0f;

    
    

// ENCAPSULATION
    public float VelFood
    {
        get { return _velFood; }
        set
        {
            if (value > 0)
            {
                _velFood = value;
            }
        }
    }

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


    // ABSTRACTION
    void Update()
    {

        FoodController();   
        DestroyFood();   
        
    }

// ABSTRACTION
    private void OnTriggerEnter(Collider other)
    {
        BarController();
    }

    public virtual void BarController()
    {
        newScale = cilindro.transform.localScale;
        if (foodFalling.CompareTag("Bad"))
        {
            newScale.y -= 0.4f;
            cilindro.transform.localScale = newScale;
            Destroy(gameObject);
            
        }
        else if (foodFalling.CompareTag("Good"))
        {
            newScale.y += 0.3f;
            cilindro.transform.localScale = newScale;
            Destroy(gameObject);
            
        }

        if (newScale.y < 5.1)
        {
            moodParki.text = "Hungry Parki";
        }
        else if (newScale.y >5.1f)
        {
            moodParki.text="Good Game";
        }
        
    }

    public void DestroyFood()
    {
        if (foodFalling.transform.position.y < -3.0f)
        {
            Destroy(gameObject);
        }
    }

    public void FoodController()
    {
        if(moodParki.text=="Hungry Parki")
        {
            transform.Translate(Vector3.down * Time.deltaTime * _velFood);

        }else if(moodParki.text== "GoodGame")
        {
            transform.Translate(Vector3.down * Time.deltaTime * 0.0f);
            

        }
       
        
    }
}
