using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MultiPlayButt : MonoBehaviour
{
    public void MultiPlayGame()
    {
        SceneManager.LoadScene("Level 1 Multi");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
