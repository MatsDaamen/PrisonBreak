﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleItem : ItemProperties
{
    //properties
    public string keyWord { get; private set; }
    public string riddle { get; private set; }
    public bool Solved { get; private set; }

    //constructor
    public PuzzleItem(string itemName, float ItemWeight, string keyWord, string riddle) : base(itemName, ItemWeight)
    {
        this.keyWord = keyWord;
        this.riddle = riddle;
        Solved = false;
    }

    //methods
    public override string ToString()
    {
        return base.ToString() + $"| the riddle is is {riddle}| awnser is {keyWord}";
    }

    public bool AwnserIsTo(string input)
    {
        Debug.Log($"the qeustion was: {riddle}, your anwser was {input}, the awnser is {keyWord}");
        Solved = (input == keyWord);
        return Solved;
    }
}
