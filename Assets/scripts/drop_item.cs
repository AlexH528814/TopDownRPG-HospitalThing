using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop_item : MonoBehaviour
{
    public GameObject pneumonia_object;
    public GameObject cold_object;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (application_vars.current_item == "pneumonia")
            {
                Instantiate(pneumonia_object, new Vector3(8.08f , -8.62f , 0), Quaternion.identity);
		application_vars.current_item = null;
		application_vars.has_item = false;
		application_vars.has_pneumonia_medicine = false;
            }

            if (application_vars.current_item == "cold")
            {
                Instantiate(cold_object, new Vector3(-8.08f, -8.92f , 0), Quaternion.identity);
		application_vars.current_item = null;
		application_vars.has_item = false;
		application_vars.has_cold_medicine = false;
            }
        }
    }

}
