using UnityEngine;

public class busca_posiciones : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("el objeto " + gameObject.tag + " está en " + gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
