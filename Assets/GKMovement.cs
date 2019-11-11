using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GKMovement : MonoBehaviour
{
void Update()
    {
        int randNum = Random.Range(0, 3);
        
        if (randNum == 0 && Input.GetMouseButtonDown(0))
        {
            transform.position = new Vector3(900, 200, 0) * 0.5f * Time.deltaTime;
        }
        if (randNum == 1 && Input.GetMouseButtonDown(0))
        {
            transform.position = new Vector3(900, 200, 350) * 0.5f * Time.deltaTime;
        }
        if (randNum == 2 && Input.GetMouseButtonDown(0))
        {
            transform.position = new Vector3(900, 200, -350) * 0.5f * Time.deltaTime;
        }
    }
}
