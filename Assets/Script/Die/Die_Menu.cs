using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die_Menu : MonoBehaviour
{


    public void Exit()
    {
        Application.LoadLevel("Level1");
    }
    public void LoadMenu()
    {
        Application.LoadLevel("Menu");
    }
}
