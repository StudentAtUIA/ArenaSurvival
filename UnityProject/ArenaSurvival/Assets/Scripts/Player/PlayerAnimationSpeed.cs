using System.Collections;
using UnityEngine;

public class PlayerAnimationSpeed : MonoBehaviour {

    public float animSpeed = 0.25f;
    private Animation anim;
    
    void Start ()
    {
       GetComponent<Animation>();
    }
	
	void Update ()
    {

       //anim["FUCM_0012b_EH_RUN_LP_NoZ"].speed = animSpeed;
       //anim["Run"].speed = animSpeed;

    }
}
