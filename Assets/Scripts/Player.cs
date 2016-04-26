using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Vector2 fuerzaSalto = new Vector2 (0, 300);
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp("space")){
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(fuerzaSalto);

        }
	}

}
