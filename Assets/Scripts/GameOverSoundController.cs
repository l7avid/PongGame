using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSoundController : MonoBehaviour
{
    public AudioSource gameOverSound;
    // Start is called before the first frame update
    void Start()
    {
        gameOverSound.Play();
    }

}
