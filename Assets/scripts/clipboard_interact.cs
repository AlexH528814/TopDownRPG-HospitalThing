using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clipboard_interact : MonoBehaviour
{
    public GameObject clipboard;

    public float radius;

    public Transform playerTransform;
    public Transform interactionTransform;

    public bool isInRadius;

    public GameObject Canvas;
    public GameObject symptoms;
    public GameObject face;
    public GameObject dialogue;

    private void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
            interactionTransform = transform;


        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }

    private void Update()
    {
        float distance = Vector2.Distance(playerTransform.position, interactionTransform.position);

        if (distance <= radius)
        {
            StartCoroutine(CheckInput());
        }
    }

    IEnumerator CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Canvas.SetActive(true);
            symptoms.SetActive(true);

            yield return new WaitForSeconds(3);

            face.SetActive(true);

            yield return new WaitForSeconds(2);

            dialogue.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Canvas.SetActive(false);
            symptoms.SetActive(false);
            face.SetActive(false);
            dialogue.SetActive(false);
        }
    }
}
