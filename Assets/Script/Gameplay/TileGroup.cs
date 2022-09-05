using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGroup : MonoBehaviour
{
    [SerializeField]
    private int X, Y;
    [SerializeField]
    private TileObject _tileObject;
    [SerializeField]
    private Transform GameGrids;
    [SerializeField]
    private GameObject[] MorphingGrid;
    [SerializeField]
    private int[] MatchNumb;
    // Start is called before the first frame update
    void Start()
    {
        SpawnGrid();
        MorphingGrid = GameObject.FindGameObjectsWithTag("Tiles");
        MatchNumb = new int[MorphingGrid.Length/2];
        for (int i = 0; i < MatchNumb.Length; i++)
        {
            MatchNumb[i] = i + 1;
        }
        foreach (var item in MorphingGrid)
        {
            for (int i = 0; i < MorphingGrid.Length; i++)
            {
                Debug.Log("Array " + i);
                if (i >= MorphingGrid.Length / 2)
                {
                    _tileObject.IconTxT.text = MatchNumb[i - MorphingGrid.Length / 2].ToString();
                }
                else if (MatchNumb[i] <= MorphingGrid.Length / 2)
                {
                    _tileObject.IconTxT.text = MatchNumb[i].ToString();
                }
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnGrid()
    {
        for (int x = -2; x < X; x++)
        {
            for (int y = -4; y < Y; y++)
            {
                var spawnedTile = Instantiate(_tileObject, new Vector2(x, y), Quaternion.identity, GameGrids);
                spawnedTile.name = $"Tile {x} {y}";
            }

        }
        //for (int i = 0; i < X; i++)
        //{
        //    var spawnedTile = Instantiate(_tileObject, new Vector2(0, 0), Quaternion.identity, GameGrids);
        //}
    }
}
