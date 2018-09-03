using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Dropzone : MonoBehaviour, IPointerClickHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler {
	
	ConstructManager cM;

	public string partToDrop;
	
	// Use this for initialization
	void Start () {
		cM = GameObject.FindGameObjectWithTag ("_MANAGER_").GetComponent<ConstructManager>() as ConstructManager;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnPointerClick(PointerEventData eventData){
		if (cM.selectedPart == null) {
			return;
		}
		if (cM.selectedPart.tag == partToDrop) {
			cM.selectedPart.transform.SetParent(this.gameObject.transform);
			cM.selectedPart.transform.position = this.transform.position + new Vector3(0, 0, -1);
			cM.selectedPart = null;
		}
	}
	
	public void OnDrag(PointerEventData eventData){
		//TODO: well guess what...draggable objects u clown
	}
	
	public void OnPointerEnter(PointerEventData eventData){
		if (cM.selectedPart == null) {
			return;
		}
		if (cM.selectedPart.tag == partToDrop) {	//selected part must have the right tag
			this.GetComponent<Image> ().color = Color.green;
		} else {
			this.GetComponent<Image> ().color = Color.red;
		}
	}
	
	public void OnPointerExit(PointerEventData eventData){
		this.GetComponent<Image> ().color = Color.white;
	}
}
