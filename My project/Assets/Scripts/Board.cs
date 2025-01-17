using UnityEngine;
using UnityEngine.Tilemaps;

public class Board : MonoBehaviour
{
  public Tilemap tilemap {get; private set; }
  public TetrominoData[] tetrominoes;

  private void Awake()
  {
    this.tilemap = GetComponentInChildren<Tilemap>();
    
    for (int i =0; i< this.tetrominoes.Lenght; i++; ){
      this.tetrominoes[i].Initialize();
    }
  }
}
