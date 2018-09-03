using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

	public MainComponent mainComp;
	public BarrelComponent barrelComp;
	public BaseComponent baseComp;
	public MagazineComponent magComp;

	public float upgradeDmgMultiplier = 1.00f;
	public float dmgPerBullet;

	public GameObject curTarget;

	public float shootCD = 50f;

	// Use this for initialization
	void Start () {
		baseComp = GetComponentInChildren <BaseComponent>();
		mainComp = GetComponentInChildren <MainComponent>();
		barrelComp = mainComp.gameObject.GetComponentInChildren <BarrelComponent>();
		magComp = GetComponentInChildren <MagazineComponent>();
		CalculateDamage ();
		shootCD = mainComp.fireCooldown;
	}
	
	// Update is called once per frame
	void Update () {
		shootCD -= Time.deltaTime;
		if (shootCD <= 0f) {
			if (curTarget != null) {
				ShootAtTarget();
				shootCD = mainComp.fireCooldown;
			}
		}
		AimAtTarget (1);	//TODO:switch the 1 later on to the target mode number
	}

	void ShootAtTarget(){
		AimAtTarget (1);	//TODO:switch the 1 later on to the target mode number
		//actually shoot at the target
		GameObject tempBullet = Instantiate (magComp.myBullet, barrelComp.bulletSpawn.transform.position, Quaternion.identity) as GameObject;
		tempBullet.GetComponent<BulletScript> ().SetValues (curTarget, dmgPerBullet);
	}

	void CalculateDamage(){
		dmgPerBullet = (((magComp.baseDmg + baseComp.baseDmg + mainComp.baseDmg + barrelComp.baseDmg) * baseComp.dmgMultiplier * mainComp.dmgMultiplier) * mainComp.aoeMultiplier)*upgradeDmgMultiplier ;
	}

	void AimAtTarget(int targetMode){
		curTarget = FindClosestEnemy();
		if (curTarget != null) {
			if (targetMode == 1) {
				Vector3 diff = curTarget.transform.position - transform.position;
				diff.Normalize();
				
				float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
				mainComp.transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
			} //TODO: add target modes
		}
	}

	public GameObject FindClosestEnemy() {
		GameObject[] gos;
		gos = GameObject.FindGameObjectsWithTag("Enemy");
		GameObject closest = null;
		float distance = baseComp.maxFireRange;
		Vector3 position = transform.position;
		foreach (GameObject go in gos) {
			Vector3 diff = go.transform.position - position;
			float curDistance = diff.sqrMagnitude;
			if (curDistance < distance) {
				closest = go;
				distance = curDistance;
			}
		}
		return closest;
	}
}
