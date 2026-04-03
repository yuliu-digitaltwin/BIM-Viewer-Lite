using UnityEngine;

public class ModelLoader : MonoBehaviour
{
    public string modelName = "sample"; // put sample.obj in Resources
    public bool Finish = false;

    void Start()
    {
        GameObject model = Resources.Load<GameObject>(modelName);

        if (model != null)
        {
            GameObject instance = Instantiate(model, transform);
            instance.transform.localPosition = Vector3.zero;
            Finish = true;
        }
        else
        {
            Debug.LogError("Model not found!");
        }
    }
}