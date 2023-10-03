using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public ButtonsManager shakeImage;

    public void OnButtonClick()
    {
        shakeImage.StartShake();
    }
}
