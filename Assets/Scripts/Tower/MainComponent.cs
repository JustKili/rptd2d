using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainComponent : MonoBehaviour {

	public float fireCooldown = 5f;
	public float dmgMultiplier = 1.00f;
	public float baseDmg = 0f;
	public bool isAOE = false;
	public float aoeMultiplier = 1.00f;	//turn down if AOE is true
	public float aoeRange = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
}
