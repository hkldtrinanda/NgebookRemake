using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour
{
    public string sceneName, sceneName2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GoBackToMenuMateri()
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void GoToBeranda()
    {
        SceneManager.LoadScene(sceneName2);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    
    
}
