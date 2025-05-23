using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class GameEventListener : MonoBehaviour{
    [SerializeField] private GameEvent gEvent;
    [SerializeField] private UnityEvent response;

    private void OnEnable(){
        gEvent.addListener(this);
    }

    private void OnDisable() {
        gEvent.removeListener(this);
    }

    public void OnEventTriggered(){
        Debug.LogError("Event raised in GameEventListener!");
        response.Invoke();
    }
}
