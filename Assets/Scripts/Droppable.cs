using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Droppable : MonoBehaviour, IPointerClickHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler {
	
	ConstructManager cM;

	// Use this for initialization
	void Start () {
		cM = GameObject.FindGameObjectWithTag ("_MANAGER_").GetComponent<ConstructManager>() as ConstructManager;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerClick(PointerEventData eventData){
		cM.selectedPart = this.gameObject;
	}
	
	public void OnDrag(PointerEventData eventData){
		//TODO: well guess what...draggable objects u clown
	}
	
	public void OnPointerEnter(PointerEventData eventData){

	}
	
	public void OnPointerExit(PointerEventData eventData){

	}
}
