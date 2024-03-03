using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : Singleton<ChangeWeapon>
{
    private float[] rangeList = { 5f, 4f, 5f};
    public void ChangeRangeWhenChangeWeapon(WeaponType type, Character character)
    {
        float range = rangeList[(int)type];
        character.atkRange.TF.localScale = new Vector3(range, range, range);
    }
}