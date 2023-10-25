using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSoundController : MonoBehaviour
{
    public AudioSource mainMenuSound;

    public void Start()
    {
        mainMenuSound.Play();
    }
}
