using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PhotoCapture : MonoBehaviour
{
    [Header("Photo Taker")]
    [SerializeField] private Image photoDisplayArea;
    [SerializeField] private GameObject photoFrame;
    [SerializeField] private GameObject cameraUI;
    [Header("Flash Effect")]
    [SerializeField] private GameObject cameraFlash;
    [SerializeField] private float flashTime;
    [Header("Photo Fader Effect")]
    [SerializeField] private Animator faderAnim;
    [Header("Audio")]
    [SerializeField] private AudioSource cameraAudio;
    [Header("Timer & Points")]
    [SerializeField] private TextMeshProUGUI points;
    [SerializeField] private TextMeshProUGUI timer;
   private Texture2D screenCapture;
   private bool viewPhoto;
   private void Start(){
    screenCapture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24,false);
   }

   private void Update(){
    if(Input.GetMouseButtonDown(0)){
        if(!viewPhoto){
        StartCoroutine(CapturePhoto());
    }
   }
   }
   IEnumerator CapturePhoto(){
    cameraUI.SetActive(false);
    timer.enabled = false;
    points.enabled = false;
    viewPhoto = true;
    yield return new WaitForEndOfFrame();

    Rect regionToRead = new Rect(0,0, Screen.width, Screen.height);

    screenCapture.ReadPixels(regionToRead, 0, 0, false);
    screenCapture.Apply();
    ShowPhoto();
    yield return new WaitForSeconds(1);
    RemovePhoto();
   }
   void ShowPhoto(){
    Sprite photoSprite = Instantiate(Sprite.Create(screenCapture, new Rect(0.0f,0.0f, screenCapture.width, screenCapture.height), new Vector2(0.5f,0.5f),100.0f));
    photoDisplayArea.sprite = photoSprite;
    photoFrame.SetActive(true);
    StartCoroutine(CameraFlashEffect());
    faderAnim.Play("photoFade");
   }
   IEnumerator CameraFlashEffect(){
    cameraAudio.Play();
    cameraFlash.SetActive(true);
    yield return new WaitForSeconds(flashTime);
    cameraFlash.SetActive(false);
   }
    void RemovePhoto(){
        viewPhoto = false;
        photoFrame.SetActive(false);
        cameraUI.SetActive(true);
        timer.enabled = true;
        points.enabled = true;
    }
}
