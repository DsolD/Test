using UnityEngine;
using UnityEngine.SceneManagement;

public class ScebeMag : MonoBehaviour
{
    [SerializeField] private int SceneNumber;
     
     public void SceneMenu()
    {
        SceneManager.LoadScene(SceneNumber);
    }
}  

