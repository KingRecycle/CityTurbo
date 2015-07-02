using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 5f;
    public float camSpeed = 5f;
    public Camera cam;

    // Use this for initialization
    private void Start() {
    }

    // Update is called once per frame
    private void Update() {
        float axisH = Input.GetAxis( "Horizontal" );
        float axisV = Input.GetAxis( "Vertical" );

        if ( axisH != 0 ) {
            transform.Translate( Vector2.right * axisH * speed * Time.deltaTime );
        }
        if ( axisV != 0 ) {
            //transform.Translate( Vector2.up * axisV * speed * Time.deltaTime );
        }

        //When Players reaches desired (L/R)possition make him stop
        if ( transform.position.x <= -2f )
            transform.position = new Vector3( -2f, transform.position.y, transform.position.z );
        else if ( transform.position.x >= 2f )
            transform.position = new Vector3( 2f, transform.position.y, transform.position.z );

        cam.transform.Translate( Vector3.forward * camSpeed * Time.deltaTime );
    }
}