using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    public static BGMusic instance;

    void Awake(){
        if(instance != null){
            Destroy(gameObject);
        }else{
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
