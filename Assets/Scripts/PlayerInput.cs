using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    private MovementHandler movementHandler;
    
    // Start is called before the first frame update
    void Start()
    {
        movementHandler = GetComponent<MovementHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (!IsLocalPlayer) return;
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        movementHandler.Move(x, y);
    }
}
