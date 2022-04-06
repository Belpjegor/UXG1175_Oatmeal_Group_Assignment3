using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface TypeStates
{
    void InitialiseStates(Main mScript, params string[] paramList);

    void HandleInput (int inputA);

    string GetStateDisplay();
}
