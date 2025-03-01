using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GradeScript : MonoBehaviour
{
    //WW
    public InputField WRITTENWORKSCORE;
    public InputField TOTALWRITTENWORK;
    public float  WRITTENWORKPERCENTAGE;
    public InputField WRITTENWORKWEIGHTEDPERCENTAGE;
    //PT
    public InputField PERFORMANCETASKSCORE;
    public float PERFORMANCETASKPERCENTAGE;
    public InputField PERFORMANCETASKWEIGHTEDPERCENTAGE;
    
    //QA
    public InputField QUARTERLYASSESSMENTSCORE;
    public float QUARTERLYASSESSMENTPERCENTAGE;
    public InputField QUARTERLYASSESSMENTWEIGHTEDPERCENTAGE;

    public Text result_text;

    public void Grade()
    {
         float.TryParse(WRITTENWORKSCORE.text, out WRITTENWORKPERCENTAGE);
         float.TryParse(PERFORMANCETASKSCORE.text, out PERFORMANCETASKPERCENTAGE);
         float.TryParse(QUARTERLYASSESSMENTSCORE.text, out QUARTERLYASSESSMENTPERCENTAGE);


        
    }
}
