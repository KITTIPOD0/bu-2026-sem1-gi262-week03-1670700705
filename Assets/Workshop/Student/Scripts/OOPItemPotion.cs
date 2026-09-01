using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPItemPotion : Identity   
{
    public int healpoint;
    public bool isBonus;
    public void Start()
    {
        
    }
    public override void Hit()
    {
        mapGenerator.player.Heal(healpoint);
        Destroy(gameObject);
        mapGenerator.mapdata[positionX,positionY] = mapGenerator.empty;
    }
}