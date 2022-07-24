using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Charecter")]
public class Charecter : ScriptableObject
{
    [Header("Name")]
    public string firstName = "John";
    public string lastName = "Handcock";

    [Header("Information")]
    [Range(1,31)] [SerializeField] int birthDay = 1;
    [Range(1,12)] [SerializeField] int birthMonth = 1;
    [Range(0, 100)] [SerializeField] int age = 50;
    [Range(0, 1000)] [SerializeField] int weight = 150;
    [Range(0, 100)] [SerializeField] int height = 60;
    [SerializeField] List<string> hobbies = new List<string>();

    private bool alive;
    public Dictionary<Stat, int> statIndex = new Dictionary<Stat, int>();
    public Dictionary<Stat, int[]> statArray = new Dictionary<Stat, int[]>();

    [Range(0,8)] [SerializeField] int speedIndex;
    [SerializeField] int[] speedArray = new int[8];
    [Range(0, 8)] [SerializeField] int mightIndex;
    [SerializeField] int[] mightArray = new int[8];
    [Range(0, 8)] [SerializeField] int sanityIndex;
    [SerializeField] int[] sanityArray = new int[8];
    [Range(0, 8)] [SerializeField] int knowlegeIndex;
    [SerializeField] int[] knowlegeArray = new int[8];

    public Charecter()
    {
        statIndex.Add(Stat.speed, speedIndex);
        statArray.Add(Stat.speed, speedArray);
        statIndex.Add(Stat.might, mightIndex);
        statArray.Add(Stat.might, mightArray);
        statIndex.Add(Stat.speed, sanityIndex);
        statArray.Add(Stat.speed, sanityArray);
        statIndex.Add(Stat.speed, knowlegeIndex);
        statArray.Add(Stat.speed, knowlegeArray);
    }

    public void ChangeStat(Stat stat, int amount, bool limit = true)
    {
        int index = statIndex[stat];
        index += amount;
        statIndex[stat] = index;

        alive = index <= 0;

    }
    public bool isAlive() => alive;
}

public enum Stat { speed, might, sanity, knowlege}