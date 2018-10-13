using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour 
{
	
	public GameObject cone;
	public bool shrinking= false;
	public float targetScale = 0.00000000000000000000000000000000000000000000000000000000000000000000000000000005f;
 	public float shrinkSpeed = 0.015f;
	public bool enter = true;

	// Use this for initialization
	void Start () 
	{
		cone= GameObject.Find("trigger");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (shrinking) 
		{
         	cone.transform.localScale -= Vector3.one*Time.deltaTime*shrinkSpeed;
            cone.transform.position -= Time.deltaTime*new Vector3(0, 0.6f, 0);
            if (cone.transform.localScale.y < targetScale) {
                cone.GetComponent<Test>().enabled = false;
            }
		}
	}

	private void OnTriggerEnter(Collider other)
    	{
        	if (enter)
        	{
            		Shrink();
           

            }
    	}
 	void Shrink() 
	{
     	shrinking = true;
 	}
}
