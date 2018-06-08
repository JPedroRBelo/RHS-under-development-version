using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Part of OntSense ontology
[System.Serializable]
public class OdorComposition
{
    [SerializeField]
    [Range(0.0f, 1.0f)]
    /// Represents the level of chemical odorant present in a olfatory information.
    public double chemicalLevel;
    [SerializeField]
    [Range(0.0f, 1.0f)]
    /// Represents the level of decayed odorant present in a olfatory information.
    public double decayedLevel;
    [SerializeField]
    [Range(0.0f, 1.0f)]
    /// Represents the level of fragrant odorant present in a olfatory information.
    public double fragrantLevel;
    [SerializeField]
    [Range(0.0f, 1.0f)]
    /// Represents the level of fruity odorant present in a olfatory information.
    public double fruityLevel;
    [SerializeField]
    [Range(0.0f, 1.0f)]
    /// Represents the level of lemon odorant present in a olfatory information.
    public double lemonLevel;
    [SerializeField]
    [Range(0.0f, 1.0f)]
    /// Represents the level of minty odorant present in a olfatory information.
    public double mintyLevel;
    [SerializeField]
    [Range(0.0f, 1.0f)]
    /// Represents the level of popcorn odorant present in a olfatory information.
    public double popcornLevel;
    [SerializeField]
    [Range(0.0f, 1.0f)]
    /// Represents the level of pungent odorant present in a olfatory information.
    public double pungentLevel;
    [SerializeField]
    [Range(0.0f, 1.0f)]
    /// Represents the level of sweet odorant present in a olfatory information.
    public double sweetLevel;
    [SerializeField]
    [Range(0.0f, 1.0f)]
    /// Represents the level of woody odorant present in a olfatory information.
    public double woodyLevel;



    public OdorComposition(double chemical, double decayed, double fragrant, double fruity, double lemon, double minty, double popcorn, double pungent, double sweet, double woody)
    {
        chemicalLevel = chemical;
        decayedLevel = decayed;
        fragrantLevel = fragrant;
        fruityLevel = fruity;
        lemonLevel = lemon;
        mintyLevel = minty;
        popcornLevel = popcorn;
        pungentLevel = pungent;
        sweetLevel = sweet;
        woodyLevel = woody;
    }
}