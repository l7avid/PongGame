using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnePlayer : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameVsAI");
    }
}
