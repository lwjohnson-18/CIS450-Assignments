/*
 * Lucas Johnson
 * BlockDecorator
 * Assignment 4
 * Block Decorator Abstract Class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BlockDecorator : Block
{
    public Block wrappedBlock;

    public new abstract int GetPointValue();
}
