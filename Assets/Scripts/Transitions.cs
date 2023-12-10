using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transitions : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject DevsMenu;
    public void MainMenu_DevsMenu()
    {
        MainMenu.SetActive(false);
        DevsMenu.SetActive(true);
    }
    public void DevsMenu_MainMenu()
    {
        MainMenu.SetActive(true);
        DevsMenu.SetActive(false);
    }
}
