using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clipboard_interact : MonoBehaviour
{

    public GameObject clipboard;
    public GameObject clipboard_ui;
    public GameObject Canvas;

    public float radius;

    public Transform playerTransform;
    public Transform interactionTransform;

    // Start is called before the first frame update
    void Start()
    {
	Canvas.SetActive(false);
    }
    
    void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
                interactionTransform = transform;

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(playerTransform.position, interactionTransform.position);

        if (Input.GetKeyDown(KeyCode.Tab) && distance <= radius)
        {
		clipboard_ui.SetActive(!clipboard_ui.activeInHierarchy);
        	Canvas.SetActive(!Canvas.activeInHierarchy);
	}

    }

    public IEnumerator Dialogue(){
		yield return new WaitForSeconds(0.5f);
    }

}
