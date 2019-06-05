using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 0f;
  [SerializeField] float maxX = 14f;

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits= Input.mousePosition.x/ Screen.width*screenWidthInUnits;
        Vector2 paddlePos = new Vector2(mousePosInUnits,transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        transform.position = paddlePos;
      
   
    }
}
