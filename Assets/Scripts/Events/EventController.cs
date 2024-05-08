using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController 
{
    public Action baseEvent;

    public void AddListner(Action listener)
    {
        baseEvent += listener;
    }

    public void RemoveListner(Action listener)
    {
        baseEvent -= listener;
    }

    public void InvokeEvent()
    {
        baseEvent?.Invoke();
    }
}
