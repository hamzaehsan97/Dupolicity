using UnityEngine;


[System.Serializable]

public class Questions
{

 public string prompt;
 [Range(1.0f, 10.0f)]
 public float isLiberal = 0f;

 [Range(1.0f, 5.0f)]
 public float impact = 1f;

}
