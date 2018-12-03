using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevel : MonoBehaviour {

    public void LoadNextLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
