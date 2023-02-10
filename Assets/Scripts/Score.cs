using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
  public Transform player;
  public Text scoreText;
  //public int x = -250;

  void update()
  {
      
      scoreText.text = player.position.z.ToString();
  }
}
