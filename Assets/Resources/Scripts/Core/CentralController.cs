using System.Threading;
using UnityEditor;
using UnityEngine;

public class CentralController : MonoBehaviour
{
    public static CentralController Instance = null;
    public Events Events = new Events();
    public float _timeSinceLastTick;

    [Header("Player Settings")]
    public float MovementSpeed = 1;
    public float Volume = 50f;
    public Resolution Resolution;

    void Start()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
            Resolution = Screen.currentResolution;
        }
        else
        {
            DestroyImmediate(this);
        }
    }
}
