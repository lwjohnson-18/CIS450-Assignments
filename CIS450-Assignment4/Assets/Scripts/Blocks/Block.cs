/*
 * Lucas Johnson
 * Block
 * Assignment 4
 * Block Abstract Class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Block : MonoBehaviour
{
    private Material blockColor;

    public abstract void ApplyBehaviour();

    public abstract void PlayerInteraction();

    public Material BaseColor
    {
		get
		{
			return blockColor;
		}
		set
		{
			blockColor = value;
		}
	}
}
