using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;
using TMPro;
public class CardDisplay : MonoBehaviour
{
    public CardSO card;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI description;
    public Image artworkImage;
    public TextMeshProUGUI atkText;
    public TextMeshProUGUI healthText;
    public bool hasBeenPlayed;
    [SerializeField] bool Flip;
    GameManager gm;
    
    void Start()
    {
        gm=FindObjectOfType<GameManager>();
        nameText.text=card.CardName;
        description.text=card.description;
        artworkImage.sprite=card.artwork;
        atkText.text=card.attack.ToString();
        healthText.text=card.health.ToString();
    }
    void Stage(){
        var X =transform.GetChild(1).gameObject.GetComponent<Image>();
        if(Flip){
            X.color=new Color(255,255,255,0);
        }else{
            X.color=new Color(255,255,255,255);
        }
    }
    private void Update() {
        Stage();
    }
    
    public void Summon(){
      if(!hasBeenPlayed){
         hasBeenPlayed=true;
            GameObject CanvasObj=Instantiate(gameObject,transform.position,Quaternion.identity) as GameObject;
            CanvasObj.transform.SetParent(GameObject.FindGameObjectWithTag("field").transform,false);
            gm.gra.Add(CanvasObj);
            Destroy(gameObject);
      }
    }
   
    
    
}
