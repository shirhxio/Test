using UnityEngine;
using System.Collections;

public class RayTest : MonoBehaviour {
	private Ray2D ray;
	private RaycastHit2D hit;
	private int layerMask = 1 << 8;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero,1,layerMask);
			if(hit){
				if(hit.transform.gameObject.tag == "obj"){
					Destroy(hit.transform.gameObject);
				}
			}
		}
	}
}
