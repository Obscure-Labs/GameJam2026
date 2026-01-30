using System.Threading;
using UnityEditor;
using UnityEngine;

public class CentralController : MonoBehaviour
{
    public CentralController Instance = null;
    public Events Events = new Events();
    public float _timeSinceLastTick;

    [Header("Global Controls")]
    public int EventDrivenTickrate = 60;
    [Header("Player Settings")]
    public float Volume = 50f;
    public Resolution Resolution;

    void Start()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
            Thread t = new Thread(new ThreadStart(() => {
                if (_timeSinceLastTick > ) {
                    Instance.Events.SendCentralTick();
                }
                else
                {
                    _timeSinceLastTick += Time.deltaTime;
                }
                    Thread.Sleep(1);
            }));
            t.Start();
            Resolution = Screen.currentResolution;
        }
    }
}
