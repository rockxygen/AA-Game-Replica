using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCreator : MonoBehaviour
{
    public GameObject pin;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShotPin();
        }
    }

    void ShotPin()
    {
        Instantiate(pin, transform.position, Quaternion.identity);
    }
}
