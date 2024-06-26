using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

// INHERITANCE» 
public class BeerToxic : FoodFall
{

    void Start()
    {
        cilindro = GameObject.Find("Capsule");
        GameObject textObject = GameObject.Find("mood");
        if (textObject != null)
        {
            moodParki = textObject.GetComponent<TMP_Text>();
        }
        StartCoroutine(FinJuego());
    }

    // Update is called once per frame

    // INHERITANCE» 
    void Update()
    {
        
            FoodController();
            DestroyFood();

        
    }
// POLYMORPHISM
    public override void BarController()
    {
        if (foodFalling.CompareTag("Bad"))
        {
            newScale.y = 0.0f;
            cilindro.transform.localScale = newScale;
            Destroy(gameObject);
            moodParki.text = "Toxic...";
            
        }
    }

// INHERITANCE»
    IEnumerator FinJuego()
    {
        while (true)
        {
            if (moodParki.text == "Toxic..." || moodParki.text == "Good Game")
            {
                
                yield return new WaitForSeconds(1);
                ChangeSceneMenu();
            }
            yield return null;  
        }
    }

    public void ChangeSceneMenu()
    {
        SceneManager.LoadScene("MenU");
    }

    


}
