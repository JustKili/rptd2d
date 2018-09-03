using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelComponent : MonoBehaviour {

	public GameObject bulletSpawn;

	public float bulletSpeed = 10f;
	public int noOfBullets = 1;
	public float baseDmg;

	// Use this for initialization
	void Start () {
		bulletSpawn = transform.GetChild (0).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
