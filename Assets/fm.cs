using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int res;
        FMODUnity.RuntimeManager.CoreSystem.setOutput(FMOD.OUTPUTTYPE.ASIO);
        FMODUnity.RuntimeManager.CoreSystem.getNumDrivers(out res);
        for (int i = 0; i < res; i++)
        {
            string str;
            System.Guid guid;
            int sysRate;
            FMOD.SPEAKERMODE mode;
            int modChannel;

            FMODUnity.RuntimeManager.CoreSystem.getDriverInfo(i, out str, 1024, out guid, out sysRate, out mode, out modChannel);
            Debug.Log("Device: ");
            Debug.Log(str);

            if (str.Contains("Dante"))
            {
                FMODUnity.RuntimeManager.CoreSystem.setDriver(i);
                Debug.Log("Assigned to dante virtual soundcard");
            }
        }

        Debug.Log("Devices: " + res);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
