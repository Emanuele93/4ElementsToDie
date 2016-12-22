﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class chestEnemiesActivator : MonoBehaviour
{
    public GameplayManager gm;
    private List<GameObject> enemies = new List<GameObject>();
    public GameObject buttom;
    protected bool inChestArea;
    protected CharacterManager player;
    public List<Item> objects = new List<Item>();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inChestArea && Input.GetKeyDown(KeyCode.F))
        {
            remouveKey();
            gm.SpawnChestDrops(gameObject);
            Destroy(gameObject);
        }
    }

    public void addChild(GameObject child)
    {
        enemies.Add(child);
    }

    public abstract void addItemOnChest(GameObject enemyObjectCollection);

    protected abstract void remouveKey();
}
