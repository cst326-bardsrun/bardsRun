using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneButton : MonoBehaviour {

    public void goToMainMenu()
    {
        SceneManager.LoadScene("Start");
    }
}
