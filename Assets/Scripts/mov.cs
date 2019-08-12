using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    public float speed;
    public float speedG;
    bool player = true; // true = player 1, false = player
    public string horizontal, vertical;


    // Update is called once per frame
    void Update()
    {
        //Debug.Log("horizontal: "+horizontal);
        //Debug.Log("vertical: " + vertical);
        float axisX = Input.GetAxis(horizontal) * speedG;
        float axisY = Input.GetAxis(vertical) * speed;
        Vector3 velo = GetComponent<Rigidbody>().velocity;

        if (transform.position.y < -1.4f)
            GetComponent<Rigidbody>().velocity = new Vector3(velo.x, 2.5f, velo.z);

        if (Input.GetKey("up") || Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("down"))
            transform.Translate(new Vector3(axisY, velo.y, velo.z)*Time.deltaTime);
        
        
        if(Input.GetKey("left") || Input.GetKey("right") || Input.GetKey("a") || Input.GetKey("d"))
            transform.Rotate(new Vector3(0, axisX, 0));
        
    }
}
