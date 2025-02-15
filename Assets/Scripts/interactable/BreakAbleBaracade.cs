﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakAbleBaracade : MonoBehaviour, Iinteractable
{
    public void Action(PlayerControllerScript player)
    {
        player.GiveFeedBack("This stone is cracked, it should break if you hit it hard enough");
    }

    public void OnCollisionEnter(Collision collision)
    {
        BreakObject(collision);
    }

    protected virtual void BreakObject(Collision collision)
    {
        float collisionForce = collision.impulse.magnitude / Time.fixedDeltaTime;

        if (collisionForce > 500)
        {
            Destroy(this.gameObject);
        }
    }
}

