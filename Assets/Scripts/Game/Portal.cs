using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public enum TypeGame
{
  type1 = 1,
  type2 = 2,
  type3 = 3
}

public class Portal : MonoBehaviour
{
  public TypeGame type;
  public UnityEvent takeItemEvent;
}
