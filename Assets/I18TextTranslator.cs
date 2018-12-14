using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class I18TextTranslator : MonoBehaviour
{   
    public string TextId;
    public TextMeshProUGUI meshPro;

    // Use this for initialization
    void Start()
    {
        var text = GetComponent<Text>();
        if (text != null)
        {
            if (TextId == "ISOCode")
                text.text = I18n.GetLanguage();
            else
                text.text = I18n.Fields[TextId];
        }
        else
        {
            if (TextId == "ISOCode")
                meshPro.text = I18n.GetLanguage();
            else
                meshPro.text = I18n.Fields[TextId];
            Debug.Log("no text asset");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}