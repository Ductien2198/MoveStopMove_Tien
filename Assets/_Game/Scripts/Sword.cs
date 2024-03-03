using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    public bool onAttack = false;
    public float angle;
    protected override void OnEnable()
    {
        base.OnEnable();
        Invoke(nameof(DestroyWeapon), 3f);
    }
    protected override void OnDisable()
    {
        CancelInvoke(nameof(DestroyWeapon));
        base.OnDisable();
    }

    protected override void Start()
    {
        base.Start();
        type = WeaponType.Sword;
        //transform.forward = player.FindNearestBotInRange() - transform.position;
        
    }

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }

}