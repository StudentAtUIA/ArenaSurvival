using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AggroToPlayer : MonoBehaviour {

    #region Singelton

    public static AggroToPlayer instance;

    void Awake ()
    {
        instance = this;
    }

    #endregion

    public GameObject player;

    void Start () {
		
	}
	
	
	void Update () {
		
	}
}
