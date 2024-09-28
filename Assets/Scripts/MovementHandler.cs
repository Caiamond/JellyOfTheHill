using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Object;
using FishNet.Connection;
public class MovementHandler : NetworkObject
{
    public float Speed = 3f;
    
    private Rigidbody2D rigidbody2d;

    public void Start()
    {
        base.Start();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        
    }

    public void Move(float x, float y)
    {
        if (!base.IsOwner) return;
        rigidbody2d.velocity = new Vector2(x, y) * Speed;
    }
}
