using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BeerToxic : FoodFall
{
    // Start is called before the first frame update
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
    void Update()
    {
        FoodController();
        DestroyFood();
        
        
    }

    public override void BarController ()
    {
        if(foodFalling.CompareTag("Bad")){
        newScale.y=0.0f;
        cilindro.transform.localScale = newScale;
        Destroy(gameObject);
        moodParki.text="Toxic...";
    
        
        }
        
    }
IEnumerator FinJuego()
{
    if(moodParki.text== "Toxic...")
    {
                
        yield return new WaitForSeconds(1);
        ChangeSceneMenu();
    }
    

   
    
}

 public void ChangeSceneMenu(){
        SceneManager.LoadScene("MenU");
    }


    
}
