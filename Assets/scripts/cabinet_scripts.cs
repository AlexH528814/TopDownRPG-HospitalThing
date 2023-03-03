using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cabinet_scripts : MonoBehaviour
{
    SpriteRenderer sprite;

    public Sprite oldsprite;
    public Sprite newSprite;
    Sprite tempSprite;


    public GameObject Canvas;
    public GameObject cabinet;
    public Sprite cabinet_item_1;
    public Sprite cabinet_item_2;
    public Sprite cabinet_item_3;

    public float radius;

    public Transform playerTransform;
    public Transform interactionTransform;

    // Start is called before the first frame update
    void Start()
    {
        sprite= GetComponent<SpriteRenderer>();

    }
    private void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
                interactionTransform = transform;

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }

    // Update is called once per frame
    void Update()
    {
	Image cabinet_sprite = cabinet.GetComponent<Image>();

        float distance = Vector3.Distance(playerTransform.position, interactionTransform.position);

        if (Input.GetKeyDown(KeyCode.Tab) && distance <= radius)
        {
            StartCoroutine(OpenCabinet(newSprite));
	}
    }

    public IEnumerator OpenCabinet(Sprite newsprite)
    {
        yield return new WaitForSeconds(1);
        tempSprite = oldsprite;
        oldsprite = newsprite;
        sprite.sprite = newsprite;
        newSprite = tempSprite;
	cabinet.SetActive(!cabinet.activeInHierarchy);
	Canvas.SetActive(!Canvas.activeInHierarchy);
    }

    public void ChangeImage(){
    

    }
}
