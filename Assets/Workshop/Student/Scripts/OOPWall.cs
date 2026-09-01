using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// OOPWall aka "Demon Wall"
public class OOPWall : Identity
{
    public int damage;
    public bool IsIceWall;

    public void Start()
    {
        
    }
    public override void Hit()
    {
        mapGenerator.player.TakeDamage(damage);
        Destroy(gameObject);
        mapGenerator.mapdata[positionX,positionY] = mapGenerator.empty;
    }
}