using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private Material material;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Constant.GAME_PLAYER))
        {
            Color color = material.color;
            color.a = 0.3f;
            material.color = color;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(Constant.GAME_PLAYER))
        {
            Color color = material.color;
            color.a = 1f;
            material.color = color;
        }
    }
}
