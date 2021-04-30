using UnityEngine;
using System.Collections.Generic;
using System.Net;
using UnityEngine.UI;
using System.Collections;
using System;


public class ReadStream : MonoBehaviour
{
    public string PhotonParticleURL = "https://api.particle.io/v1/devices/events?access_token=7cefafe8e8ee7c69cd349d26ae9fe70bafcc620a";
    WebStreamReader request = null;

    DataClassDice parseDataDice = new DataClassDice();

    public Dice dice; 

    bool DiceTrue = false;
 

    public class DataClass
    {
        public int data;
    }

    public class DataClassDice
    {
        public int data;
    }


    void Start()
    {
        //parseDataHumidity = new DataClass ();
        StartCoroutine(WRequest());
    }

    void Update()
    {

    }

    IEnumerator WRequest()
    {
        request = new WebStreamReader();
        request.Start(PhotonParticleURL); 
        string stream = "";
        while (true)
        {
            string block = request.GetNextBlock();
            if (!string.IsNullOrEmpty(block))
            {
                stream += block;
                //Debug.Log ("Stream1: " + stream);
                string[] data = stream.Split(new string[] { "\n\n" }, System.StringSplitOptions.None);
                //Debug.Log ("Data length: " + data.Length);
                stream = data[data.Length - 1];

                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (!string.IsNullOrEmpty(data[i]))
                    {
                        	Debug.Log ("Data: " + data [i]); // print all block of data (event + data)
                        if (data[i].Contains("Dice"))
                        {
                            DiceTrue = true;
                            string output = data[i].Substring(data[i].IndexOf("{"));
                            parseDataDice = JsonUtility.FromJson<DataClassDice>(output);
                            dice.OnDataReceived();
                            //Debug.Log ("Data of Photoresistor: " + parseData.data);
                            //text.text = parseData.data.ToString ();
                            //gameObject.GetComponent<IoT> ().microPhotoresistorVal = parseDataLight.data;
                        }

                            DiceTrue = false;
                           
                        }
                    }
                }

            
            yield return new WaitForSeconds(1);
        }
    }

    void OnApplicationQuit()
    {
        if (request != null)
            request.Dispose();
    }

    void OnDataUpdate(decimal aAmount)
    {
        Debug.Log("Received new amount: " + aAmount);
        // Do whatever you want with the value
    }
}