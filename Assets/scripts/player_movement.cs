using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

	const string FI_IDLE = "fi_idle";
	const string FI_WALK_UP = "fi_walk_up";
	const string FI_WALK_DOWN = "fi_walk_down";
	const string FI_WALK_RIGHT = "fi_walk_right";
	const string FI_WALK_LEFT = "fi_walk_left";
	
	public string lastState;
    	

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
    
		if (vertical < 0 && horizontal == 0) ChangeAnimationState(FI_WALK_DOWN);
		if (vertical > 0 && horizontal == 0) ChangeAnimationState(FI_WALK_UP);
		if (horizontal < 0 && vertical == 0) ChangeAnimationState(FI_WALK_LEFT);
		if (horizontal > 0 && vertical == 0) ChangeAnimationState(FI_WALK_RIGHT);
		if (vertical < 0 && horizontal < 0) ChangeAnimationState(FI_WALK_DOWN);
		if (vertical > 0 && horizontal > 0) ChangeAnimationState(FI_WALK_DOWN);
		if (vertical > 0 && horizontal > 0) ChangeAnimationState(FI_IDLE);


	}

    	void ChangeAnimationState(string newState){
		if (newState == lastState) return;
    
		anim.Play(newState);

		lastState = newState;
    	}
}
