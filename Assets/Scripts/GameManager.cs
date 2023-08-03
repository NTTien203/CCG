using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public List<GameObject> deck = new List<GameObject>();
    public List<GameObject> gra = new List<GameObject>();
   

    public void DrawCard(){
        if(deck.Count>=1){
            GameObject randCard =deck[Random.Range(0,deck.Count)];
                    GameObject CanvasObj=Instantiate(randCard,transform.position,Quaternion.identity) as GameObject;
                    CanvasObj.transform.SetParent(GameObject.FindGameObjectWithTag("Slots").transform,false);
                    deck.Remove(randCard);
                    return;
            }
        }

     
    
}
  
    
    

    

