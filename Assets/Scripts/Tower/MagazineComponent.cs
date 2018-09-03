using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineComponent : MonoBehaviour {

	public float baseDmg;
	public float chanceElementalEffect;	//only used when type is not PHYS/MAGICAL

	enum TypeOfDmg{PHYS, FIRE, POISON};
	TypeOfDmg myTypeOfDmg;

	public GameObject myBullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
