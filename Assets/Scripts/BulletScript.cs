using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	GameObject target;
	public float speed = 10f;
	public float myDamage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (target == null) {
			Die();
			return;
		}
		FlyTowardsTarget ();
		/*if (this.transform.position == target.transform.position) {
			target.GetComponent<EnemyScript>().TakeDamage(myDamage);
			Die ();
			return;
		}*/
	}

	void Die(){
		Destroy (this.gameObject);
	}

	void FlyTowardsTarget(){
		if (target == null) {
			Debug.Log("no target on a bullet?");
			return;
		}
		Vector3 dir = target.transform.position - transform.position;
		dir.Normalize ();

		this.transform.position += dir * speed * Time.deltaTime;
	}

	public void SetValues(GameObject _target, float _myDamage){
		target = _target;
		myDamage = _myDamage;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Enemy") {
			target.GetComponent<EnemyScript>().TakeDamage(myDamage);
			Die ();
			return;
		}
	}
}