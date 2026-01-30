using System;
using UnityEngine;

public class Events
{
    public event EventHandler CentralTick;
    public virtual void SendCentralTick()
    {
        CentralTick?.Invoke(this, null);
    }
}
