﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonkeyKongEnter : MonoBehaviour
{
    private DonkeyKongSegment script;

    private void Start()
    {
        script = GetComponentInParent<DonkeyKongSegment>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !script.throwingBarrels & !script.doneThrowingBarrels)
            script.StartThrowing();
    }
}
