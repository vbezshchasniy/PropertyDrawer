using System;
using UnityEngine;

public enum IngredientUnitSimple { Spoon, Cup, Bowl, Piece }

[Serializable]
public class IngredientSimple
{
    public string name;
    public int amount = 1;
    public IngredientUnitSimple unit;
}

public class RecipeSimple : MonoBehaviour
{
    public IngredientSimple potionResult;
    public IngredientSimple[] potionIngredients;
}