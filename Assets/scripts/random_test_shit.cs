using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_test_shit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (application_vars.has_cold_medicine)
        {
            Debug.Log("YOu have cold medicine\n");
        }

        if (application_vars.has_pneumonia_medicine)
        {
            Debug.Log("YOu have pneumonia medicine\n");
        }
    }
}
