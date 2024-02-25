using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenFader : MonoBehaviour
{
    [SerializeField] Image fadeImage;
    [SerializeField] private Color FadeColor = Color.black;
    [SerializeField] private float fadeTime = 1;
    [SerializeField] private bool fadeInOnStart = true;

    void Start(){
        if(fadeInOnStart)
{    FadeToClear();
}
    }
    void FadeToClear(){
        fadeImage.color = FadeColor;
        StartCoroutine(FadeToClearRoutine());
        IEnumerator FadeToClearRoutine(){
            float timer = 0;
            while(timer < fadeTime){
                yield return null;
                timer+=Time.deltaTime;
                fadeImage.color = new Color(FadeColor.r,FadeColor.g,FadeColor.b,1f - (timer/fadeTime));
            }
            fadeImage.color = Color.clear;
        }
    }
  /*      public void FadeToColor(string newScene =""){
            fadeImage.color = new Color(FadeColor.r,FadeColor.g,FadeColor.b,0);
            StartCoroutine(FadeToColorRoutine());
            IEnumerator FadeToColorRoutine(){
            float timer = 0;
            while(timer < fadeTime){
                yield return null;
                timer+=Time.deltaTime;
                fadeImage.color = new Color(FadeColor.r,FadeColor.g,FadeColor.b,(timer/fadeTime));
            }
            fadeImage.color = FadeColor;
            if(newScene != ""){
                SceneManager.LoadScene(newScene);
            }
        }
        }*/
        public void diagonal(string newScene = ""){
            Vector3 start = new Vector3(10, 10, 0);
            Vector3 end = new Vector3(0, 0, 0);
            float timer = 3;
            StartCoroutine(Move(start, end, timer));
            IEnumerator Move(Vector3 start, Vector3 end, float timer){
                for(float x = 0; x < 1; x += Time.deltaTime / timer){
                transform.position = Vector3.Lerp(start, end, x);
                yield return null;
    } 
            fadeImage.color = FadeColor;
            if(newScene != ""){
                SceneManager.LoadScene(newScene);
            }
            }
        }
        }
