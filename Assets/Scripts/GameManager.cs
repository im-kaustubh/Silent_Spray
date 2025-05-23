using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Need new Monobehaviors on the Hierarchy under the GameManager for the different
    //game states
    private StateMachine gameStateMachine;

    StateInterface mainMenuState;
    StateInterface inGameState;
    StateInterface gameOverState;
    StateInterface levelTransitionState;
    //We will need more States in the Future
    private void Start()
    {

        gameStateMachine = new StateMachine();

        mainMenuState = GetComponent<MainMenuState>(); //MainMenuState = Monobehaviour, s.o.
        inGameState = GetComponent<InGameState>();  //etc.
        gameOverState = GetComponent<GameOverState>();
        levelTransitionState = GetComponent<LevelTransitionState>();

        mainMenuState.switchState(mainMenuState);
        //Can be exchanged with the inGameState for skipping the Mainmenu
        //and therefore directly enter the game


    }

    // public StateInterface getInterface(StateInterface a)
    // {

    // }

    public void switchGamestate(StateInterface oldState)
    {
        gameStateMachine.switchState(nextState(oldState));
    }

    private StateInterface nextState(StateInterface oldState)
    {
        StateInterface newState = null;
        //TODO: When the actual States exists
        //oldState --> newState

        return newState;
    }

    private void Update()
    {
        gameStateMachine.executeState();
    }

}