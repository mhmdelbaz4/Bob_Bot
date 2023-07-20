using System;

namespace Bob_Bot;

class MedicalBot
{
    public const string BotName = "Bob";

    public void PrescribeMedication(Patient patient)
    {
        if(patient.GetSymptomCode().Equals("s1" , StringComparison.OrdinalIgnoreCase))
        {
            patient.Prescription = GetDosage("ibuprofen");
        }
        else if(patient.GetSymptomCode().Equals("s2", StringComparison.OrdinalIgnoreCase))
        {
            patient.Prescription = GetDosage("diphenhydramine");
        }
        else if(patient.GetSymptomCode().Equals("s3", StringComparison.OrdinalIgnoreCase) 
                && ! patient.SuffersDiabetes)
        {
            patient.Prescription = GetDosage("metformin");
        }
        else
        {
            patient.Prescription = GetDosage("dimenhydrinate");
        }


        string GetDosage(string medicineName)
        {
            if (medicineName == "ibuprofen" && patient.GetAge() < 18)
                return "ibuprofen, 400 mg";
            else if (medicineName == "ibuprofen" && patient.GetAge() >= 18)
                return "ibuprofen, 800 mg";
            else if (medicineName == "diphenhydramine" && patient.GetAge() < 18)
                return "diphenhydramine, 50 mg";
            else if (medicineName == "diphenhydramine" && patient.GetAge() >= 18)
                return "diphenhydramine ,300 mg";
            else if (medicineName == "diphenhydramine" && patient.GetAge() < 18)
                return "diphenhydramine ,50 mg";
            else if (medicineName == "diphenhydramine" && patient.GetAge() >= 18)
                return "diphenhydramine ,300 mg";
            else if (medicineName == "dimenhydrinate" && patient.GetAge() < 18)
                return "dimenhydrinate ,50 mg";
            else if (medicineName == "dimenhydrinate" && patient.GetAge() >= 18)
                return "dimenhydrinate ,400 mg";
            else
                return "500 mg";
        }
    }


}
