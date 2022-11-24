using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnRestartButtonPressed()
    {
        SceneManager.LoadScene("Main");
    }


}
