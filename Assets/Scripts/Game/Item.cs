using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    public TypeGame type;

    public UnityEvent getRightEvent;
    public UnityEvent getWrongEvent;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.GetComponent<Portal>().type == type)
            getRightEvent?.Invoke();
        else getWrongEvent?.Invoke();
        
            
        
    }
}
