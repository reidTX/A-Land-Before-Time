using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame (){
        SceneManager.LoadScene("InstructionScene");
    }
    public void playGameReal (){
        SceneManager.LoadScene("MainContent");
    }
    public void quitGame() {
        Debug.Log("quitted");
        Application.Quit();
    }
    public void creditScene(){
        SceneManager.LoadScene("CreditScroller");
    }
    public void PlayMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
