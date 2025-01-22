using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Actions
{
    // Variables for the events of the different game inputs, that'll happen when the context is started

    // Cube
    public static Action jumpEvent;
    // Cylinder
    public static Action squashEvent;
    // Sphere
    public static Action greenEvent;

    // Variables for the events of the different game inputs, that'll happen when the context is performed

    // Cube
    public static Action spinEvent;
    // Cylinder
    public static Action stretchEvent;
    // Sphere
    public static Action yellowEvent;

    // Variables for the events of the different game inputs, that'll happen when the context is canceled

    // Cube
    public static Action fallEvent;
    // Cylinder
    public static Action turnToNormalEvent;
    // Sphere
    public static Action disappearEvent;
}
