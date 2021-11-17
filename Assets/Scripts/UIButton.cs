using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class UIButton : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    public Color highlightColor = Color.magenta;
    public void OnMouseOver()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = highlightColor; 
        }
    }
    public void OnMouseExit()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = Color.white;
        }
    }
    public void OnMouseDown()
    {
        transform.localScale = new Vector3(0.3f, 0.3f, 0.3f); 
 }
    public void OnMouseUp()
    {
        transform.localScale = new Vector3(0.4377f, 0.4377f, 0.4377f);
        if (targetObject != null)
        {
            SceneManager.LoadScene("Game");
        }
    }
}