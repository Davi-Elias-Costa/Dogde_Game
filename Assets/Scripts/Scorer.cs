using UnityEngine;

public class Score : MonoBehaviour
{
     int hits = 1;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
        Debug.Log("você atingiu esse objeto muitas vezes: " + hits);
        hits++;
        }
    }
}
