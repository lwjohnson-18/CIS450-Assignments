/*
 * Lucas Johnson
 * I_State
 * Assignment 9
 * State Interface
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    void PlayerInRange();
    void PlayerOutOfRange();
    void CatchPlayer();
}
