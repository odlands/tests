using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SinglePlayButt : MonoBehaviour
{
    public void SinglePlayGame()
    {
        SceneManager.LoadScene("Level 1 Single");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
