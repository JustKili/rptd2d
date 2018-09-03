using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	float maxHealth = 9999999f;
	public float curHealth = 9999999f;

	// Use this for initialization
	void Start () {
		curHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TakeDamage(float amt){
		curHealth -= amt;
		if (curHealth <= 0) {
			Die();
		}
	}

	void Die(){
		//give money and/or whatever to player
		//roll dropchance for parts or crafting items
		Destroy (this.gameObject);
	}
}
