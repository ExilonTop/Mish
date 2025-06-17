using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public List<Panel> panels;

    public void SwitchPanel(string name)
    {
        panels.Where(c => c.gameObject.activeSelf == true).ToList().ForEach(pnl => pnl.Interact(false));
        panels.Where(c => c.theName == name).ToList().ForEach(pnl => pnl.Interact(true));
    }
}
