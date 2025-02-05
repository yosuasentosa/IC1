﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonMonobehaviour<T> : MonoBehaviour where T:MonoBehaviour
{
    public static T instance;

    public static T Instance
    {
        get
        {
            return instance;
        }
    }

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
