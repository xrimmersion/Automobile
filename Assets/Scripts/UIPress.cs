using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;
using UnityEngine.Events;

public class UIPress : MonoBehaviour
{
    public UnityEvent OnPress = null;

    private void OnTriggerEnter(Collider other) {
        UITrigger uiTrigger = other.gameObject.GetComponent<UITrigger>();
        if (uiTrigger != null) {
            if (OnPress!=null) OnPress.Invoke();
        }
    }
}
