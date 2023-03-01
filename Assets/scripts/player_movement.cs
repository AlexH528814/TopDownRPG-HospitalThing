using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

	const string FI_IDLE_UP = "fi_idle_up";
        const string FI_IDLE_DOWN = "fi_idle_down";
        const string FI_IDLE_RIGHT = "fi_idle_left";
        const string FI_IDLE_LEFT = "fi_idle_right";
        const string FI_WALK_UP = "fi_walk_up";
	const string FI_WALK_DOWN = "fi_walk_down";
	const string FI_WALK_RIGHT = "fi_walk_right";
	const string FI_WALK_LEFT = "fi_walk_left";
	
	public string lastState;
	string lastDir;

	public GameObject Canvas;

    	public float move_speed;
    	Rigidbody2D rb;
    	Animator anim;
   	// Start is called before the first frame update
    	void Start()
    	{
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
    	}

    	// Update is called once per frame
    	void Update()
    	{

        	if (Canvas.activeInHierarchy) return;

	        float horizontal = Input.GetAxisRaw("Horizontal");
        	float vertical = Input.GetAxisRaw("Vertical");
			
        	rb.velocity = new Vector2(horizontal * move_speed, vertical * move_speed);

		    if (vertical < 0 && horizontal == 0) { ChangeAnimationState(FI_WALK_DOWN); lastDir = "fi_idle_down"; }
		    if (vertical > 0 && horizontal == 0) { ChangeAnimationState(FI_WALK_UP); lastDir = "fi_idle_up"; }
		    if (horizontal < 0 && vertical == 0) { ChangeAnimationState(FI_WALK_LEFT); lastDir = "fi_idle_right"; }
		    if (horizontal > 0 && vertical == 0) { ChangeAnimationState(FI_WALK_RIGHT); lastDir = "fi_idle_left"; }
		    if (vertical < 0 && horizontal < 0) { ChangeAnimationState(FI_WALK_LEFT); lastDir = "fi_idle_left"; }
		    if (vertical > 0 && horizontal > 0) { ChangeAnimationState(FI_WALK_RIGHT); lastDir = "fi_idle_right"; }
		    if (vertical == 0 && horizontal == 0)
		    { 
                switch (lastDir)
			    {
				    case "fi_idle_down":
                        ChangeAnimationState(FI_IDLE_DOWN);
                    break;
                    case "fi_idle_up":
                        ChangeAnimationState(FI_IDLE_UP);
                    break;
                    case "fi_idle_left":
                        ChangeAnimationState(FI_IDLE_LEFT);
                    break;
                    case "fi_idle_right":
                        ChangeAnimationState(FI_IDLE_RIGHT);
                    break;
                }
            }
		    Debug.Log($"{horizontal}, {vertical}");
	    }

    	void ChangeAnimationState(string newState){
			if (newState == lastState) return;
    
			anim.Play(newState);

			lastState = newState;
    	}
}
