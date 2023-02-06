using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    public Button exitButton;

    public void ExitGame()
    {
        Application.Quit();
    }
}