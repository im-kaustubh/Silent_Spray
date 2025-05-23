using UnityEngine;

public interface StateInterface{
    public void beginState();
    public void executeState();
    public void endState();
}

public class StateMachine{
    StateInterface currentState;

    public StateInterface getCs(){
        return this.currentState;
    }

    public void switchState(StateInterface newState){
    //    Debug.Log("TTT:");
    //    Debug.Log(currentState);
        if (currentState != null)
            currentState.endState();

        currentState = newState;
        currentState.beginState();
    }

    public void executeState(){
        if (currentState != null)
            currentState.executeState();
    }
}

