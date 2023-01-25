using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop_item : MonoBehaviour
{
    public GameObject pneumonia_object;
    public GameObject cold_object;
    public Transform player_transform;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (application_vars.current_item == "pneumonia")
            {
                Instantiate(pneumonia_object, new Vector3(0, 0, 0), Quaternion.identity, player_transform);
            }

            if (application_vars.current_item == "")
            {
                Instantiate(cold_object, new Vector3(0,0,0), Quaternion.identity, player_transform);
            }
        }
    }

}
