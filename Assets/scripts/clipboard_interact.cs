using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clipboard_interact : MonoBehaviour
{
    public GameObject clipboard;

    public float radius;

    public Transform playerTransform;
    public Transform interactionTransform;


    private void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
            interactionTransform = transform;


        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }

    private void Update()
    {
    }
}
