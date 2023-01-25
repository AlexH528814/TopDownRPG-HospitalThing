using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_optiona : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject symptoms;
    public GameObject face;
    public GameObject dialogue;
    void Correct_Option()
    {
        Debug.Log("You chose the correct option");
    }

    void Incorrect_Option()
    {
        Debug.Log("You chose the incorrect option");
    }

    void Leave_Option()
    {
        Canvas.SetActive(false);
        symptoms.SetActive(false);
        face.SetActive(false);
        dialogue.SetActive(false);
    }
}
