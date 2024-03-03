using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAxe : MonoBehaviour
{
    public Vector3 rotation;

    private void Start()
    {
        transform.localEulerAngles = new Vector3(0, 0, 140f);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime * 40f);
    }
}
