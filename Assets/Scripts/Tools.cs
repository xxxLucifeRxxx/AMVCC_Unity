using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Tools {

    public static GameObject FindGameObject(string name)
    {
        var childTransForm = GameObject.FindGameObjectWithTag("Application").gameObject.transform.GetComponentsInChildren<Transform>(true).FirstOrDefault(t => t.name == name);
        return childTransForm != null ? childTransForm.gameObject : null;
    }

}
