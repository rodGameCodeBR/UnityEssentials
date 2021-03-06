﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeItem : CubeInteractive
{
    public Material hoverColor;
    public Material exitColor;

    public override void Hover()
    {
        GetComponent<Renderer>().material = hoverColor;
    }

    public override void Exit()
    {
        GetComponent<Renderer>().material = exitColor;
    }
}
