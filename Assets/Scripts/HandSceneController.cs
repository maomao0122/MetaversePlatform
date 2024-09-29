using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandSceneController : MonoBehaviour
{
    public void OnBackButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void OnInteractButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3 );
    }
}
