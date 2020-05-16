using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateCodePrefab : MonoBehaviour
{
    public enum NAME_State
    {
        STATE_ZERO,
        STATE_ONE,
        STATE_TWO,
        STATE_THREE,
        STATE_FOUR,
        STATE_FIVE
    }
    public NAME_State startState;
    private NAME_State currentState;

    #region Internal
    private enum StateFlow
    {
        ENTER,
        UPDATE,
        EXIT
    }

    void Start()
    {
        CommonStart();
        SetStartState(startState);
    }

    private void SetStartState(NAME_State startState)
    {
        currentState = startState;

        switch (currentState)
        {
            case NAME_State.STATE_ZERO: STATE_ZERO(StateFlow.ENTER); break;
            case NAME_State.STATE_ONE: STATE_ONE(StateFlow.ENTER); break;
            case NAME_State.STATE_TWO: STATE_TWO(StateFlow.ENTER);  break;
            case NAME_State.STATE_THREE: STATE_THREE(StateFlow.ENTER); break;
            case NAME_State.STATE_FOUR: STATE_FOUR(StateFlow.ENTER); break;
            case NAME_State.STATE_FIVE: STATE_FIVE(StateFlow.ENTER);  break;
        }
    }

    void Update()
    {
        CommonUpdate();

        switch (currentState)
        {
            case NAME_State.STATE_ZERO: STATE_ZERO(StateFlow.UPDATE); break;
            case NAME_State.STATE_ONE: STATE_ONE(StateFlow.UPDATE); break;
            case NAME_State.STATE_TWO: STATE_TWO(StateFlow.UPDATE); break;
            case NAME_State.STATE_THREE: STATE_THREE(StateFlow.UPDATE); break;
            case NAME_State.STATE_FOUR: STATE_FOUR(StateFlow.UPDATE); break;
            case NAME_State.STATE_FIVE: STATE_FIVE(StateFlow.UPDATE); break;
        }
    }

    private void ChangeState(NAME_State nextState)
    {
        switch (this.currentState)
        {
            case NAME_State.STATE_ZERO: STATE_ZERO(StateFlow.EXIT); break;
            case NAME_State.STATE_ONE: STATE_ONE(StateFlow.EXIT); break;
            case NAME_State.STATE_TWO: STATE_TWO(StateFlow.EXIT); break;
            case NAME_State.STATE_THREE: STATE_THREE(StateFlow.EXIT); break;
            case NAME_State.STATE_FOUR: STATE_FOUR(StateFlow.EXIT); break;
            case NAME_State.STATE_FIVE: STATE_FIVE(StateFlow.EXIT); break;
        }

        this.currentState = nextState;

        switch (this.currentState)
        {
            case NAME_State.STATE_ZERO: STATE_ZERO(StateFlow.ENTER); break;
            case NAME_State.STATE_ONE: STATE_ONE(StateFlow.ENTER); break;
            case NAME_State.STATE_TWO: STATE_TWO(StateFlow.ENTER); break;
            case NAME_State.STATE_THREE: STATE_THREE(StateFlow.ENTER); break;
            case NAME_State.STATE_FOUR: STATE_FOUR(StateFlow.ENTER); break;
            case NAME_State.STATE_FIVE: STATE_FIVE(StateFlow.ENTER); break;
        }
    }
    #endregion;


    private void CommonStart()
    {

    }

    
    private void CommonUpdate()
    {
        
    }


    private void STATE_ZERO(StateFlow state)
    {
        switch (state)
        {
            case StateFlow.ENTER:
                break;
            case StateFlow.UPDATE:
                break;
            case StateFlow.EXIT:
                break;
        }
    }


    private void STATE_ONE(StateFlow state)
    {
        switch (state)
        {
            case StateFlow.ENTER:
                break;
            case StateFlow.UPDATE:
                break;
            case StateFlow.EXIT:
                break;
        }
    }


    private void STATE_TWO(StateFlow state)
    {
        switch (state)
        {
            case StateFlow.ENTER:
                break;
            case StateFlow.UPDATE:
                break;
            case StateFlow.EXIT:
                break;
        }
    }


    private void STATE_THREE(StateFlow state)
    {
        switch (state)
        {
            case StateFlow.ENTER:
                break;
            case StateFlow.UPDATE:
                break;
            case StateFlow.EXIT:
                break;
        }
    }



    private void STATE_FOUR(StateFlow state)
    {
        switch (state)
        {
            case StateFlow.ENTER:
                break;
            case StateFlow.UPDATE:
                break;
            case StateFlow.EXIT:
                break;
        }
    }



    private void STATE_FIVE(StateFlow state)
    {
        switch (state)
        {
            case StateFlow.ENTER:
                break;
            case StateFlow.UPDATE:
                break;
            case StateFlow.EXIT:
                break;
        }
    }
}
