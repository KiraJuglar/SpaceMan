using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public LevelManager sharedInstance;

    public List<LevelBlock> allLevelBlocks = new List<LevelBlock>();
    public List<LevelBlock> currentLevelBlocks = new List<LevelBlock>();

    private void Awake()
    {
        if(sharedInstance == null)
        {
            sharedInstance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GenerateInitialBlocks();
    }

    void AddLevelBlock()
    {

    }

    void DeleteLevelBlock()
    {

    }

    void DestroyAllLevelBlocks()
    {

    }

    void GenerateInitialBlocks()
    {
        for(int i = 0; i < 2; i++)
        {
            AddLevelBlock();
        }
    }

    
}
