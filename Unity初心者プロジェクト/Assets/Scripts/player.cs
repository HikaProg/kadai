using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //  右キーを押したら右に移動
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.position += new Vector3( 1.0f, 0.0f, 0.0f) * Time.deltaTime;
        }
        //  左キーを押したら左に移動
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position += new Vector3( -1.0f, 0.0f, 0.0f) * Time.deltaTime;
        }
        //  上キーを押したら前に移動
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.position += new Vector3( 0.0f, 0.0f, 1.0f) * Time.deltaTime;
        }
        //  下キーを押したら後ろに移動
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.position += new Vector3(0.0f, 0.0f, -1.0f) * Time.deltaTime;
        }
    }
}
