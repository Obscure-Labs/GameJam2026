using System;
using Assets.Resources.Scripts;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance = null;

    public MaskColour maskEqupped = MaskColour.None;

    public void Start()
    {
        if (Instance != null)
        {
            Instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mask"))
        {
            other.gameObject.transform.parent.GetComponent<Mask>();
        }
    }
}
