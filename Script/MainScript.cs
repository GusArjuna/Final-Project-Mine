using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    public String forBack;
    // Start is called before the first frame update
    public void QuitApl()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void Semaphorebtn()
    {
        SceneManager.LoadScene("Scenes/ARSemaphore");
    }
    
    public void Morseebtn()
    {
        SceneManager.LoadScene("Scenes/ARMorse");
    }
    public void Simpulebtn()
    {
        SceneManager.LoadScene("Scenes/Simpul");
    }
    public void Backbtn()
    {
        SceneManager.LoadScene(forBack);
    }

    public void SimpulMati()
    {
        SceneManager.LoadScene("Scenes/ARSimpulMati");
    }
    
    public void SimpulJangkar()
    {
        SceneManager.LoadScene("Scenes/ARSimpulJangkar");
    }
    
    public void SimpulPangkal()
    {
        SceneManager.LoadScene("ARSimpulPangkal");
    }

    public void OpenURLS()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1z0JcllfnnvyOlW-yav07K9ebttgLezxg?usp=sharing");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
