using UnityEngine;
using UnityEngine.Tilemaps;

public enum Tetromino{
    I,
    O,
    T,
    J,
    L,
    S,
    Z
}
[System.Serializable] //lássa az unity
public struct TetrominoData{
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells {get; private set;} //Unity-be ne jelenen meg az adat, ha specko darabokat akarok akkor vegyem ki a private set-et.
    public Vector2Int[,] wallKicks {get; private set;}

    public void Initialize(){
        this.cells = Data.Cells[this.tetromino];
        this.wallKicks = Data.WallKicks[this.tetromino];
    }
}