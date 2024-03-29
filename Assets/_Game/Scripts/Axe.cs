using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Weapon
{
    protected override void OnEnable()
    {
        base.OnEnable();
        //TF.localEulerAngles = new Vector3(0f, 90f, 0f);
        TF.localEulerAngles = new Vector3(90f, 0, 0);
        Invoke(nameof(DestroyWeapon), 3f);
    }
    protected override void OnDisable()
    {
        CancelInvoke(nameof(DestroyWeapon));
        base.OnDisable();
        //TF.localEulerAngles = new Vector3(0f, 90f, 0f);
        TF.localEulerAngles = new Vector3(90f, 0, 0);
    }

    protected override void Start()
    {
        base.Start();
        type = WeaponType.Axe;
    }
    void FixedUpdate()
    {
        tf.localEulerAngles += new Vector3(0, 0, 10);
    }
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }
}