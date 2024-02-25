using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class pointCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI pointCounterText;
    public static pointCounter singleton;
    int pointCollected = 0;
     void Awake(){
        if(singleton != null){
            Destroy(this.gameObject);
        }
        singleton = this;
    }
    void Start(){

    }

    public void RegisterCoin(int x){
        pointCollected += x;
        pointCounterText.text = "Points: "+pointCollected.ToString();
    }
}
