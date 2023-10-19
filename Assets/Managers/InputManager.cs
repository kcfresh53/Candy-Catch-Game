using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static Controlls _controls;
    public static void Init(Player myPlayer)
    {
        _controls = new Controlls();

        _controls.Game.Movement.performed += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector3>());
        };
    }
}