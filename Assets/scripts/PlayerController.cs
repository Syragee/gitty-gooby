using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //speed
    public float speed = 10;

    //bounds
    public float topBound = 4.5F;
    public float bottomBound = -4.5F;

    void start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        //pause and play (p)
        if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 1)
        {
            Time.timeScale = 1;
        } else if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
    }

    //update once per frame
    void FixedUpadate()
    {
        //player input and speed
        float movementSpeedY = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(0, movementSpeedY, 0);
        
        //player bounds
        if (transform.position.y > topBound)
        {
            transform.position = new Vector3(tranform.position.x, topBound, 0);
        }else if (transform.position.y < topBound)
        {
            transform.position = new Vector3(transform.position.x, bottomBound, 0);
        }

    }
}
