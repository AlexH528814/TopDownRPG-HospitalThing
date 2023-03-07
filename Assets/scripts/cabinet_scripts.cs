using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
	   Image cabinet_sprite; 
    public TextMeshProUGUI Text;

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
	cabinet_sprite = cabinet.GetComponent<Image>();

        float distance = Vector3.Distance(playerTransform.position, interactionTransform.position);

        if (Input.GetKeyDown(KeyCode.Tab) && distance <= radius)
        {
            StartCoroutine(OpenCabinet(newSprite));
	}
    }

    public IEnumerator OpenCabinet(Sprite newsprite)
    {
        yield return new WaitForSeconds(0.5f);
        tempSprite = oldsprite;
        oldsprite = newsprite;
        sprite.sprite = newsprite;
        newSprite = tempSprite;
	cabinet.SetActive(!cabinet.activeInHierarchy);
	Canvas.SetActive(!Canvas.activeInHierarchy);
    }

    public void ChangeImageLeft(){
   		if (cabinet_sprite.sprite == cabinet_item_2){
			cabinet_sprite.sprite = cabinet_item_1; Text.text = "1/3" ;  return;}
		if (cabinet_sprite.sprite == cabinet_item_3){
			cabinet_sprite.sprite = cabinet_item_2; Text.text = "2/3" ; return;}
		if (cabinet_sprite.sprite == cabinet_item_1){
			cabinet_sprite.sprite = cabinet_item_3; Text.text = "3/3" ; return;}
    }

    public void ChangeImageRight(){
		if (cabinet_sprite.sprite == cabinet_item_2){
			cabinet_sprite.sprite = cabinet_item_3; Text.text = "3/3" ; return;}
		if (cabinet_sprite.sprite == cabinet_item_3){
			cabinet_sprite.sprite = cabinet_item_1; Text.text = "1/3" ; return;}
		if (cabinet_sprite.sprite == cabinet_item_1){
			cabinet_sprite.sprite = cabinet_item_2; Text.text = "2/3" ; return;}
    }

    public void SelectMedicine(){
	      if (cabinet_sprite.sprite == cabinet_item_1) global_vars.medicine_1 = true;
	      if (cabinet_sprite.sprite == cabinet_item_2) global_vars.medicine_2 = true;
	      if (cabinet_sprite.sprite == cabinet_item_3) global_vars.medicine_3 = true;
	      Debug.Log("picked up medicine");
	      StartCoroutine(OpenCabinet(newSprite));
    }
}
