﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Recipe",menuName ="Item/Recipe")]
public class Recipe : ScriptableObject {

    public CCSBaseItem ingredient1, ingredient2, ingredient3;
    public CCSBaseItem producedItem;
}
