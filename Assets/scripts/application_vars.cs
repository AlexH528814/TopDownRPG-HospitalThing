using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class application_vars
{
    //ints
    public static int patients_saved { get; set; }


    //bools
    public static bool has_pneumonia_medicine { get; set; }
    public static bool has_cold_medicine { get; set; }
    public static bool has_item { get; set; }

    public static bool patient1_saved { get; set; }
    public static bool patient2_saved { get; set; }
    public static bool patient3_saved { get; set; }
    public static bool patient4_saved { get; set; }

    public static bool patient1_radius { get; set;}
    public static bool patient2_radius { get; set;}
    public static bool patient3_radius { get; set;}
    public static bool patient4_radius { get; set;}

    //current item
    public static string current_item { get; set; }

}
